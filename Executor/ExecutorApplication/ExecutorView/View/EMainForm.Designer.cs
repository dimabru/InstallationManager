﻿namespace ExecutorApplication.View
{
    partial class EMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMainForm));
            this.labelCurrentBuilds = new System.Windows.Forms.Label();
            this.listViewCurrentBuilds = new System.Windows.Forms.ListView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCurrentBuildsFolder = new System.Windows.Forms.Label();
            this.labelBuildsFolderPath = new System.Windows.Forms.Label();
            this.ExitpictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResumepictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBuilderMainForm = new System.Windows.Forms.Panel();
            this.ExitpictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripTool = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumepictureBox3)).BeginInit();
            this.panelBuilderMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentBuilds
            // 
            this.labelCurrentBuilds.AutoSize = true;
            this.labelCurrentBuilds.BackColor = System.Drawing.Color.Gray;
            this.labelCurrentBuilds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentBuilds.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelCurrentBuilds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurrentBuilds.Location = new System.Drawing.Point(23, 74);
            this.labelCurrentBuilds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentBuilds.Name = "labelCurrentBuilds";
            this.labelCurrentBuilds.Size = new System.Drawing.Size(116, 23);
            this.labelCurrentBuilds.TabIndex = 3;
            this.labelCurrentBuilds.Text = "Current Builds";
            this.labelCurrentBuilds.Click += new System.EventHandler(this.labelCurrentBuilds_Click);
            // 
            // listViewCurrentBuilds
            // 
            this.listViewCurrentBuilds.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewCurrentBuilds.Location = new System.Drawing.Point(147, 57);
            this.listViewCurrentBuilds.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCurrentBuilds.Name = "listViewCurrentBuilds";
            this.listViewCurrentBuilds.Size = new System.Drawing.Size(412, 117);
            this.listViewCurrentBuilds.TabIndex = 4;
            this.listViewCurrentBuilds.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentBuilds.SelectedIndexChanged += new System.EventHandler(this.LoadDescription);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoad.Font = new System.Drawing.Font("Comic Sans MS", 9.25F);
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.Location = new System.Drawing.Point(515, 208);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(93, 34);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBoxDescription.Location = new System.Drawing.Point(147, 258);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(412, 116);
            this.richTextBoxDescription.TabIndex = 8;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Gray;
            this.labelDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescription.Location = new System.Drawing.Point(23, 303);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(95, 23);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // labelCurrentBuildsFolder
            // 
            this.labelCurrentBuildsFolder.AutoSize = true;
            this.labelCurrentBuildsFolder.BackColor = System.Drawing.Color.Gray;
            this.labelCurrentBuildsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentBuildsFolder.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelCurrentBuildsFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurrentBuildsFolder.Location = new System.Drawing.Point(24, 188);
            this.labelCurrentBuildsFolder.Name = "labelCurrentBuildsFolder";
            this.labelCurrentBuildsFolder.Size = new System.Drawing.Size(169, 23);
            this.labelCurrentBuildsFolder.TabIndex = 10;
            this.labelCurrentBuildsFolder.Text = "Current Builds Folder";
            this.labelCurrentBuildsFolder.Click += new System.EventHandler(this.labelCurrentBuildsFolder_Click);
            // 
            // labelBuildsFolderPath
            // 
            this.labelBuildsFolderPath.AutoSize = true;
            this.labelBuildsFolderPath.BackColor = System.Drawing.Color.Gray;
            this.labelBuildsFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBuildsFolderPath.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelBuildsFolderPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBuildsFolderPath.Location = new System.Drawing.Point(24, 219);
            this.labelBuildsFolderPath.Name = "labelBuildsFolderPath";
            this.labelBuildsFolderPath.Size = new System.Drawing.Size(43, 23);
            this.labelBuildsFolderPath.TabIndex = 11;
            this.labelBuildsFolderPath.Text = "N\\A";
            this.labelBuildsFolderPath.Click += new System.EventHandler(this.labelBuildsFolderPath_Click);
            // 
            // ExitpictureBox1
            // 
            this.ExitpictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ExitpictureBox1.Image")));
            this.ExitpictureBox1.Location = new System.Drawing.Point(608, 1);
            this.ExitpictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.ExitpictureBox1.Name = "ExitpictureBox1";
            this.ExitpictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.ExitpictureBox1.Size = new System.Drawing.Size(38, 43);
            this.ExitpictureBox1.TabIndex = 6;
            this.ExitpictureBox1.TabStop = false;
            this.ExitpictureBox1.Click += new System.EventHandler(this.ExitpictureBox1_Click);
            // 
            // ResumepictureBox3
            // 
            this.ResumepictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("ResumepictureBox3.Image")));
            this.ResumepictureBox3.Location = new System.Drawing.Point(577, 1);
            this.ResumepictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.ResumepictureBox3.Name = "ResumepictureBox3";
            this.ResumepictureBox3.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.ResumepictureBox3.Size = new System.Drawing.Size(31, 42);
            this.ResumepictureBox3.TabIndex = 7;
            this.ResumepictureBox3.TabStop = false;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Location = new System.Drawing.Point(15, 9);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(100, 24);
            this.menuStripMain.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.propertiesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.quitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // panelBuilderMainForm
            // 
            this.panelBuilderMainForm.AccessibleName = "Header";
            this.panelBuilderMainForm.BackColor = System.Drawing.Color.Gray;
            this.panelBuilderMainForm.Controls.Add(this.ExitpictureBox12);
            this.panelBuilderMainForm.Controls.Add(this.pictureBox1);
            this.panelBuilderMainForm.Controls.Add(this.menuStripTool);
            this.panelBuilderMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuilderMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuilderMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelBuilderMainForm.Margin = new System.Windows.Forms.Padding(1);
            this.panelBuilderMainForm.Name = "panelBuilderMainForm";
            this.panelBuilderMainForm.Size = new System.Drawing.Size(646, 43);
            this.panelBuilderMainForm.TabIndex = 14;
            this.panelBuilderMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseDown);
            this.panelBuilderMainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseMove);
            this.panelBuilderMainForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseUp);
            // 
            // ExitpictureBox12
            // 
            this.ExitpictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("ExitpictureBox12.Image")));
            this.ExitpictureBox12.Location = new System.Drawing.Point(608, 1);
            this.ExitpictureBox12.Margin = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.ExitpictureBox12.Name = "ExitpictureBox12";
            this.ExitpictureBox12.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.ExitpictureBox12.Size = new System.Drawing.Size(38, 43);
            this.ExitpictureBox12.TabIndex = 6;
            this.ExitpictureBox12.TabStop = false;
            this.ExitpictureBox12.Click += new System.EventHandler(this.ExitpictureBox12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(577, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox1.Size = new System.Drawing.Size(31, 42);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStripTool
            // 
            this.menuStripTool.BackColor = System.Drawing.Color.Gray;
            this.menuStripTool.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStripTool.Location = new System.Drawing.Point(32, 9);
            this.menuStripTool.Name = "menuStripTool";
            this.menuStripTool.Size = new System.Drawing.Size(49, 25);
            this.menuStripTool.TabIndex = 8;
            this.menuStripTool.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem1,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(41, 21);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.propertiesToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.propertiesToolStripMenuItem1.Text = "Properties";
            this.propertiesToolStripMenuItem1.Click += new System.EventHandler(this.propertiesToolStripMenuItem1_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.quitToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // EMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.panelBuilderMainForm);
            this.Controls.Add(this.labelBuildsFolderPath);
            this.Controls.Add(this.labelCurrentBuildsFolder);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listViewCurrentBuilds);
            this.Controls.Add(this.labelCurrentBuilds);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(221, 319);
            this.Name = "EMainForm";
            this.Controls.SetChildIndex(this.labelCurrentBuilds, 0);
            this.Controls.SetChildIndex(this.listViewCurrentBuilds, 0);
            this.Controls.SetChildIndex(this.buttonLoad, 0);
            this.Controls.SetChildIndex(this.richTextBoxDescription, 0);
            this.Controls.SetChildIndex(this.labelDescription, 0);
            this.Controls.SetChildIndex(this.labelCurrentBuildsFolder, 0);
            this.Controls.SetChildIndex(this.labelBuildsFolderPath, 0);
            this.Controls.SetChildIndex(this.panelBuilderMainForm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumepictureBox3)).EndInit();
            this.panelBuilderMainForm.ResumeLayout(false);
            this.panelBuilderMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripTool.ResumeLayout(false);
            this.menuStripTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentBuilds;
        private System.Windows.Forms.ListView listViewCurrentBuilds;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCurrentBuildsFolder;
        private System.Windows.Forms.Label labelBuildsFolderPath;
        private System.Windows.Forms.PictureBox ExitpictureBox1;
        private System.Windows.Forms.PictureBox ResumepictureBox3;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel panelBuilderMainForm;
        private System.Windows.Forms.PictureBox ExitpictureBox12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStripTool;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
    }
}
