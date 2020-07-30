using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Avat.XUnitView
{
    class XunitProject
    {
        public XunitProject(string fileName)
        {
            var file = new FileInfo(fileName);
            var xml = new XmlDocument();
            xml.Load(fileName);

            _name = file.Name;
            _outputName = Path.GetTempFileName();

            PrepareStartInfo(xml.DocumentElement);
        }

        public string Name { get { return _name; } }

        public IResultNode Run()
        {
            var builder = new TestResultBuilder();

            foreach(var startInfo in _startInfo)
            {
                using (var process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                }

                var xml = new XmlDocument();
                xml.Load(_outputName);
                File.Delete(_outputName);

                builder.AddResult(xml);
            }

            return builder.Result;
        }

        private string _name;
        private string _outputName;
        private List<ProcessStartInfo> _startInfo = new List<ProcessStartInfo>();

        private void PrepareStartInfo(XmlElement xml)
        {
            foreach(XmlElement node in xml.SelectNodes("test-dlls/test-dll"))
            {
                var startInfo = new ProcessStartInfo();
                startInfo.WorkingDirectory = xml.SelectSingleNode("base-folder").InnerText;
                startInfo.FileName = xml.SelectSingleNode("xunit-path").InnerText;
                startInfo.Arguments = $"{node.InnerText} -xml {_outputName}";
                _startInfo.Add(startInfo);
            }
        }
    }
}
