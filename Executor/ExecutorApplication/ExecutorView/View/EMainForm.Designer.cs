namespace ExecutorApplication.View
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentBuilds = new System.Windows.Forms.Label();
            this.listViewCurrentBuilds = new System.Windows.Forms.ListView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCurrentBuildsFolder = new System.Windows.Forms.Label();
            this.labelBuildsFolderPath = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(861, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // labelCurrentBuilds
            // 
            this.labelCurrentBuilds.AutoSize = true;
            this.labelCurrentBuilds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCurrentBuilds.Location = new System.Drawing.Point(15, 64);
            this.labelCurrentBuilds.Name = "labelCurrentBuilds";
            this.labelCurrentBuilds.Size = new System.Drawing.Size(135, 25);
            this.labelCurrentBuilds.TabIndex = 3;
            this.labelCurrentBuilds.Text = "Current Builds";
            // 
            // listViewCurrentBuilds
            // 
            this.listViewCurrentBuilds.Location = new System.Drawing.Point(20, 91);
            this.listViewCurrentBuilds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewCurrentBuilds.Name = "listViewCurrentBuilds";
            this.listViewCurrentBuilds.Size = new System.Drawing.Size(199, 179);
            this.listViewCurrentBuilds.TabIndex = 4;
            this.listViewCurrentBuilds.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentBuilds.SelectedIndexChanged += new System.EventHandler(this.LoadDescription);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(647, 426);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(200, 42);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(20, 356);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(588, 99);
            this.richTextBoxDescription.TabIndex = 8;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.Location = new System.Drawing.Point(15, 329);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 25);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            // 
            // labelCurrentBuildsFolder
            // 
            this.labelCurrentBuildsFolder.AutoSize = true;
            this.labelCurrentBuildsFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentBuildsFolder.Location = new System.Drawing.Point(291, 91);
            this.labelCurrentBuildsFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentBuildsFolder.Name = "labelCurrentBuildsFolder";
            this.labelCurrentBuildsFolder.Size = new System.Drawing.Size(188, 24);
            this.labelCurrentBuildsFolder.TabIndex = 10;
            this.labelCurrentBuildsFolder.Text = "Current Builds Folder";
            // 
            // labelBuildsFolderPath
            // 
            this.labelBuildsFolderPath.AutoSize = true;
            this.labelBuildsFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildsFolderPath.Location = new System.Drawing.Point(291, 129);
            this.labelBuildsFolderPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuildsFolderPath.Name = "labelBuildsFolderPath";
            this.labelBuildsFolderPath.Size = new System.Drawing.Size(42, 24);
            this.labelBuildsFolderPath.TabIndex = 11;
            this.labelBuildsFolderPath.Text = "N\\A";
            // 
            // EMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(861, 497);
            this.Controls.Add(this.labelBuildsFolderPath);
            this.Controls.Add(this.labelCurrentBuildsFolder);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listViewCurrentBuilds);
            this.Controls.Add(this.labelCurrentBuilds);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(289, 384);
            this.Name = "EMainForm";
            this.Controls.SetChildIndex(this.menuStripMain, 0);
            this.Controls.SetChildIndex(this.labelCurrentBuilds, 0);
            this.Controls.SetChildIndex(this.listViewCurrentBuilds, 0);
            this.Controls.SetChildIndex(this.buttonLoad, 0);
            this.Controls.SetChildIndex(this.richTextBoxDescription, 0);
            this.Controls.SetChildIndex(this.labelDescription, 0);
            this.Controls.SetChildIndex(this.labelCurrentBuildsFolder, 0);
            this.Controls.SetChildIndex(this.labelBuildsFolderPath, 0);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label labelCurrentBuilds;
        private System.Windows.Forms.ListView listViewCurrentBuilds;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCurrentBuildsFolder;
        private System.Windows.Forms.Label labelBuildsFolderPath;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    }
}
