namespace Avat.XUnitView
{
    partial class XUnitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XUnitForm));
            this.ResultTree = new System.Windows.Forms.TreeView();
            this.ResultImages = new System.Windows.Forms.ImageList(this.components);
            this.TestInfoPanel = new System.Windows.Forms.TabControl();
            this.TestOutputPage = new System.Windows.Forms.TabPage();
            this.TestOutputBox = new System.Windows.Forms.RichTextBox();
            this.TestErrorPage = new System.Windows.Forms.TabPage();
            this.TestErrorsBox = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTestRun = new System.Windows.Forms.ToolStripMenuItem();
            this.DlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.TestInfoPanel.SuspendLayout();
            this.TestOutputPage.SuspendLayout();
            this.TestErrorPage.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultTree
            // 
            this.ResultTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResultTree.ImageIndex = 0;
            this.ResultTree.ImageList = this.ResultImages;
            this.ResultTree.Location = new System.Drawing.Point(0, 24);
            this.ResultTree.Name = "ResultTree";
            this.ResultTree.SelectedImageIndex = 0;
            this.ResultTree.Size = new System.Drawing.Size(334, 504);
            this.ResultTree.TabIndex = 0;
            this.ResultTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ResultTree_AfterSelect);
            // 
            // ResultImages
            // 
            this.ResultImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ResultImages.ImageStream")));
            this.ResultImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ResultImages.Images.SetKeyName(0, "iconfinder_Error_132716.png");
            this.ResultImages.Images.SetKeyName(1, "iconfinder_OK_132710.png");
            this.ResultImages.Images.SetKeyName(2, "iconfinder_Warning_132616.png");
            // 
            // TestInfoPanel
            // 
            this.TestInfoPanel.Controls.Add(this.TestOutputPage);
            this.TestInfoPanel.Controls.Add(this.TestErrorPage);
            this.TestInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestInfoPanel.Location = new System.Drawing.Point(334, 24);
            this.TestInfoPanel.Name = "TestInfoPanel";
            this.TestInfoPanel.SelectedIndex = 0;
            this.TestInfoPanel.Size = new System.Drawing.Size(634, 504);
            this.TestInfoPanel.TabIndex = 1;
            // 
            // TestOutputPage
            // 
            this.TestOutputPage.Controls.Add(this.TestOutputBox);
            this.TestOutputPage.Location = new System.Drawing.Point(4, 22);
            this.TestOutputPage.Name = "TestOutputPage";
            this.TestOutputPage.Padding = new System.Windows.Forms.Padding(3);
            this.TestOutputPage.Size = new System.Drawing.Size(626, 478);
            this.TestOutputPage.TabIndex = 0;
            this.TestOutputPage.Text = "Output";
            this.TestOutputPage.UseVisualStyleBackColor = true;
            // 
            // TestOutputBox
            // 
            this.TestOutputBox.BackColor = System.Drawing.SystemColors.Window;
            this.TestOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestOutputBox.Location = new System.Drawing.Point(3, 3);
            this.TestOutputBox.Name = "TestOutputBox";
            this.TestOutputBox.ReadOnly = true;
            this.TestOutputBox.Size = new System.Drawing.Size(620, 472);
            this.TestOutputBox.TabIndex = 0;
            this.TestOutputBox.Text = "";
            // 
            // TestErrorPage
            // 
            this.TestErrorPage.Controls.Add(this.TestErrorsBox);
            this.TestErrorPage.Location = new System.Drawing.Point(4, 22);
            this.TestErrorPage.Name = "TestErrorPage";
            this.TestErrorPage.Padding = new System.Windows.Forms.Padding(3);
            this.TestErrorPage.Size = new System.Drawing.Size(626, 478);
            this.TestErrorPage.TabIndex = 1;
            this.TestErrorPage.Text = "Errors";
            this.TestErrorPage.UseVisualStyleBackColor = true;
            // 
            // TestErrorsBox
            // 
            this.TestErrorsBox.BackColor = System.Drawing.SystemColors.Window;
            this.TestErrorsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestErrorsBox.Location = new System.Drawing.Point(3, 3);
            this.TestErrorsBox.Name = "TestErrorsBox";
            this.TestErrorsBox.ReadOnly = true;
            this.TestErrorsBox.Size = new System.Drawing.Size(620, 472);
            this.TestErrorsBox.TabIndex = 0;
            this.TestErrorsBox.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(334, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 504);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuTest});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(968, 24);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuClose,
            this.toolStripSeparator1,
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(103, 22);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(103, 22);
            this.MenuClose.Text = "Close";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(103, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuTest
            // 
            this.MenuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTestRun});
            this.MenuTest.Name = "MenuTest";
            this.MenuTest.Size = new System.Drawing.Size(39, 20);
            this.MenuTest.Text = "Test";
            // 
            // MenuTestRun
            // 
            this.MenuTestRun.Name = "MenuTestRun";
            this.MenuTestRun.Size = new System.Drawing.Size(95, 22);
            this.MenuTestRun.Text = "Run";
            this.MenuTestRun.Click += new System.EventHandler(this.MenuTestRun_Click);
            // 
            // DlgOpenProject
            // 
            this.DlgOpenProject.Filter = "XML files|*.xml";
            // 
            // XUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 528);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TestInfoPanel);
            this.Controls.Add(this.ResultTree);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "XUnitForm";
            this.Text = "XUnit Test Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XUnitForm_FormClosing);
            this.TestInfoPanel.ResumeLayout(false);
            this.TestOutputPage.ResumeLayout(false);
            this.TestErrorPage.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ResultTree;
        private System.Windows.Forms.TabControl TestInfoPanel;
        private System.Windows.Forms.TabPage TestOutputPage;
        private System.Windows.Forms.TabPage TestErrorPage;
        private System.Windows.Forms.RichTextBox TestOutputBox;
        private System.Windows.Forms.RichTextBox TestErrorsBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.OpenFileDialog DlgOpenProject;
        private System.Windows.Forms.ToolStripMenuItem MenuTest;
        private System.Windows.Forms.ToolStripMenuItem MenuTestRun;
        private System.Windows.Forms.ImageList ResultImages;
    }
}

