namespace BuilderApplication.View
{
    partial class BMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewBuildtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewCurrentBuilds = new System.Windows.Forms.ListView();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCreateNewBuild = new System.Windows.Forms.Button();
            this.panelBuilderMainForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCurrentBuilds = new System.Windows.Forms.Button();
            this.buttonDescription = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.panelBuilderMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(22, 9);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(142, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMain_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewBuildtoolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewBuildtoolStripMenuItem
            // 
            this.createNewBuildtoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.createNewBuildtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createNewBuildtoolStripMenuItem.Name = "createNewBuildtoolStripMenuItem";
            this.createNewBuildtoolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.createNewBuildtoolStripMenuItem.Text = "Create New Build";
            this.createNewBuildtoolStripMenuItem.Click += new System.EventHandler(this.createNewBuildtoolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.propertiesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.quitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // listViewCurrentBuilds
            // 
            this.listViewCurrentBuilds.Location = new System.Drawing.Point(153, 63);
            this.listViewCurrentBuilds.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCurrentBuilds.Name = "listViewCurrentBuilds";
            this.listViewCurrentBuilds.Size = new System.Drawing.Size(454, 112);
            this.listViewCurrentBuilds.TabIndex = 3;
            this.listViewCurrentBuilds.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentBuilds.SelectedIndexChanged += new System.EventHandler(this.LoadDescription);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(153, 207);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(454, 150);
            this.richTextBoxDescription.TabIndex = 5;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(0, 73);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(153, 34);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCreateNewBuild
            // 
            this.buttonCreateNewBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonCreateNewBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNewBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateNewBuild.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateNewBuild.Location = new System.Drawing.Point(0, 237);
            this.buttonCreateNewBuild.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateNewBuild.Name = "buttonCreateNewBuild";
            this.buttonCreateNewBuild.Size = new System.Drawing.Size(153, 38);
            this.buttonCreateNewBuild.TabIndex = 7;
            this.buttonCreateNewBuild.Text = "Create New Build";
            this.buttonCreateNewBuild.UseVisualStyleBackColor = false;
            this.buttonCreateNewBuild.Click += new System.EventHandler(this.buttonCreateNewBuild_Click);
            // 
            // panelBuilderMainForm
            // 
            this.panelBuilderMainForm.AccessibleName = "Header";
            this.panelBuilderMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panelBuilderMainForm.Controls.Add(this.pictureBox2);
            this.panelBuilderMainForm.Controls.Add(this.pictureBox1);
            this.panelBuilderMainForm.Controls.Add(this.menuStripMain);
            this.panelBuilderMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuilderMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuilderMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelBuilderMainForm.Margin = new System.Windows.Forms.Padding(1);
            this.panelBuilderMainForm.Name = "panelBuilderMainForm";
            this.panelBuilderMainForm.Size = new System.Drawing.Size(645, 43);
            this.panelBuilderMainForm.TabIndex = 9;
            this.panelBuilderMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseDown);
            this.panelBuilderMainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseMove);
            this.panelBuilderMainForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(576, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox2.Size = new System.Drawing.Size(31, 42);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(607, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox1.Size = new System.Drawing.Size(38, 43);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonDescription);
            this.panel1.Controls.Add(this.buttonCurrentBuilds);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonCreateNewBuild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 354);
            this.panel1.TabIndex = 10;
            // 
            // buttonCurrentBuilds
            // 
            this.buttonCurrentBuilds.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonCurrentBuilds.Enabled = false;
            this.buttonCurrentBuilds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCurrentBuilds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonCurrentBuilds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCurrentBuilds.Location = new System.Drawing.Point(0, 43);
            this.buttonCurrentBuilds.Name = "buttonCurrentBuilds";
            this.buttonCurrentBuilds.Size = new System.Drawing.Size(153, 32);
            this.buttonCurrentBuilds.TabIndex = 8;
            this.buttonCurrentBuilds.Text = "Current Builds";
            this.buttonCurrentBuilds.UseVisualStyleBackColor = true;
            this.buttonCurrentBuilds.Click += new System.EventHandler(this.buttonCurrentBuilds_Click);
            // 
            // buttonDescription
            // 
            this.buttonDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonDescription.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonDescription.Enabled = false;
            this.buttonDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDescription.Location = new System.Drawing.Point(0, 200);
            this.buttonDescription.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDescription.Name = "buttonDescription";
            this.buttonDescription.Size = new System.Drawing.Size(153, 37);
            this.buttonDescription.TabIndex = 9;
            this.buttonDescription.Text = "Description";
            this.buttonDescription.UseVisualStyleBackColor = false;
            // 
            // BMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBuilderMainForm);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.listViewCurrentBuilds);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(132, 227);
            this.Name = "BMainForm";
            this.Text = "Installation Builder";
            this.Load += new System.EventHandler(this.BMainForm_Load);
            this.Controls.SetChildIndex(this.listViewCurrentBuilds, 0);
            this.Controls.SetChildIndex(this.richTextBoxDescription, 0);
            this.Controls.SetChildIndex(this.panelBuilderMainForm, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelBuilderMainForm.ResumeLayout(false);
            this.panelBuilderMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView listViewCurrentBuilds;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCreateNewBuild;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewBuildtoolStripMenuItem;
        private System.Windows.Forms.Panel panelBuilderMainForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCurrentBuilds;
        private System.Windows.Forms.Button buttonDescription;
    }
}
