using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Avat.XUnitView
{
    class TestResultBuilder
    {
        public TestResultBuilder()
        {

        }

        public void AddResult(XmlDocument xml)
        {
            BuildAssemblyList(xml.SelectNodes("/assemblies/assembly").Cast<XmlElement>(), _root);
        }

        public IResultNode Result { get { return _root; } }

        private ResultNode _root = new ResultNode(null, "All Tests");

        private void BuildAssemblyList(IEnumerable<XmlElement> assemblies, ResultNode parent)
        {
            foreach(var assembly in assemblies)
            {
                var node = new ResultNode(parent, assembly.GetAttribute("name").Split('\\').Last());
                BuildNamespaceList(assembly.SelectNodes("collection/test").Cast<XmlElement>().Select(x => new TestInfo(x)), node);
            }
        }

        private void BuildNamespaceList(IEnumerable<TestInfo> tests, ResultNode parent)
        {
            foreach (var group in tests.GroupBy(t => t.Namespace))
            {
                var node = new ResultNode(parent, group.Key);
                BuildTypeList(group, node);
            }

        }

        private void BuildTypeList(IEnumerable<TestInfo> tests, ResultNode parent)
        {
            foreach(var group in tests.GroupBy(t => t.Type))
            {
                var node = new ResultNode(parent, group.Key);
                BuildMethodList(group, node);
            }
            
        }

        private void BuildMethodList(IEnumerable<TestInfo> tests, ResultNode parent)
        {
            foreach (var group in tests.GroupBy(t => t.Method))
            {
                if (group.Count() > 1)
                {
                    var node = new ResultNode(parent, group.Key);
                    BuildTestList(group, node);
                }
                else
                {
                    var test = group.First();
                    var node = new ResultNode(parent, group.Key);
                    node.Outcome = test.Outcome;
                    node.OutputText = test.OutputText;
                    node.FailText = test.FailText;
                    node.FailTypeName = test.FailTypeName;
                    node.FailStack = test.FailStack;
                }
            }
        }

        private void BuildTestList(IEnumerable<TestInfo> tests, ResultNode parent)
        {
            foreach (var test in tests)
            {
                var node = new ResultNode(parent, test.Suffix);
                node.Outcome = test.Outcome;
                node.OutputText = test.OutputText;
                node.FailText = test.FailText;
                node.FailTypeName = test.FailTypeName;
                node.FailStack = test.FailStack;
            }
        }

        private static string ReadCDataText(XmlElement baseElement, string path)
        {
            // Locate named sub-element
            var element = baseElement.SelectSingleNode(path) as XmlElement;
            if (element == null) return null;

            // Locate CData section
            var cdata = element.ChildNodes.OfType<XmlCDataSection>().FirstOrDefault();
            if (cdata == null) return null;

            return cdata.Value.Replace(@"\r", "\r").Replace(@"\n", "\n");
        }

        private class ResultNode : IResultNode
        {
            public ResultNode(ResultNode parent, string name)
            {
                _name = name;
                _parent = parent;
                if (parent != null) parent._subnodes.Add(this);
            }

            public string Name { get { return _name; } }
            public TestOutcomes Outcome { get { return _outcome; } set { SetOutcome(value); } }
            public string FailTypeName { get; set; }
            public string FailText { get; set; }
            public string FailStack { get; set; }
            public string OutputText { get; set; }
            public IEnumerable<IResultNode> Subnodes { get { return _subnodes.Cast<IResultNode>(); } }

            private string _name;
            private ResultNode _parent = null;
            private TestOutcomes _outcome = TestOutcomes.Skip;
            private List<ResultNode> _subnodes = new List<ResultNode>();

            private void SetOutcome(TestOutcomes outcome)
            {
                _outcome = outcome;
                if ((_parent != null) && (_parent.Outcome > _outcome)) _parent.Outcome = _outcome;
            }
        }

        private class TestInfo
        {
            public TestInfo(XmlElement xml)
            {
                // Read raw information
                _name = xml.GetAttribute("name");
                _type = xml.GetAttribute("type");
                _method = xml.GetAttribute("method");
                _outcome = (TestOutcomes)Enum.Parse(typeof(TestOutcomes), xml.GetAttribute("result"));
                var failType = xml.SelectSingleNode("failure/@exception-type") as XmlAttribute;
                if (failType != null) _failTypeName = failType.Value; 
                _failText = ReadCDataText(xml, "failure/message");
                _failStack = ReadCDataText(xml, "failure/stack-trace");
                _outputText = ReadCDataText(xml, "output");

                // Split type name
                var parts = _type.Split('.');
                var type = parts.Last();
                _namespace = _type.Substring(0, _type.Length - type.Length - 1);
                _type = type;

                // Extract name suffix
                var prefix = $"{_namespace}.{_type}.{_method}";
                _suffix = _name.Replace(prefix, string.Empty);
            }

            public string Name { get { return _name; } }
            public string Suffix { get { return _suffix; } }
            public string Namespace { get { return _namespace; } }
            public string Type { get { return _type; } }
            public string Method { get { return _method; } }
            public TestOutcomes Outcome { get { return _outcome; } }
            public string FailTypeName { get { return _failTypeName; } }
            public string FailText { get { return _failText; } }
            public string FailStack { get { return _failStack; } }
            public string OutputText { get { return _outputText; } }

            private string _name;
            private string _suffix;
            private string _namespace;
            private string _type;
            private string _method;
            private TestOutcomes _outcome;
            private string _failTypeName;
            private string _failText;
            private string _failStack;
            private string _outputText;
        }
    }
}
