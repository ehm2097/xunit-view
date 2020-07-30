using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avat.XUnitView
{
    public partial class XUnitForm : Form
    {
        public XUnitForm(string projectFileName)
        {
            InitializeComponent();

            _baseTitle = Text;
            if (projectFileName == null) SetProject(null);
            else SetProject(new XunitProject(projectFileName));
        }

        private XunitProject _project = null;
        private string _baseTitle;

        private void CloseProject()
        {
            if(_project != null)
            {
                ResultTree.Nodes.Clear();
                SetProject(null);
            }
        }

        private void SetProject(XunitProject project)
        {
            _project = project;

            var withProject = _project != null;
            Text = withProject ? $"{_baseTitle} - {_project.Name}" : _baseTitle;
            MenuTestRun.Enabled = withProject;
            MenuClose.Enabled = withProject;
        }

        private void CreateNode(TreeNodeCollection parentNodes,  IResultNode data)
        {
            var node = parentNodes.Add(data.Name);
            node.ImageIndex = (int) data.Outcome;
            node.SelectedImageIndex = (int)data.Outcome;
            node.Tag = data;
            foreach (var subdata in data.Subnodes)
            {
                CreateNode(node.Nodes, subdata);
            }
            if (data.Outcome == TestOutcomes.Fail)
            {
                node.Expand();
            }
        }

        private void ShowDescription(TreeNode node)
        {
            TestOutputBox.Clear();
            TestErrorsBox.Clear();

            var data = node.Tag as IResultNode;
            if (data == null) return;

            if (data.OutputText != null)
            {
                TestOutputBox.SelectionFont = new Font(FontFamily.GenericMonospace, 10f);
                TestOutputBox.AppendText(data.OutputText);
            }

            if(data.FailText != null)
            {
                TestErrorsBox.AppendText($"{data.FailText}\r\n\r\n{data.FailStack}");
            }
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            if (DlgOpenProject.ShowDialog() == DialogResult.OK)
            {
                SetProject(new XunitProject(DlgOpenProject.FileName));
            }
        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            CloseProject();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuTestRun_Click(object sender, EventArgs e)
        {
            ResultTree.Nodes.Clear();
            CreateNode(ResultTree.Nodes, _project.Run());
        }

        private void XUnitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProject();
        }

        private void ResultTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowDescription(e.Node);
        }
    }
}
