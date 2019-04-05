namespace ExecutorView.View
{
    partial class BuildExecute
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
            this.labelBuildName = new System.Windows.Forms.Label();
            this.groupBoxBuildTasks = new System.Windows.Forms.GroupBox();
            this.treeViewTasks = new System.Windows.Forms.TreeView();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxBuildTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuildName
            // 
            this.labelBuildName.AutoSize = true;
            this.labelBuildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBuildName.Location = new System.Drawing.Point(334, 7);
            this.labelBuildName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuildName.Name = "labelBuildName";
            this.labelBuildName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBuildName.Size = new System.Drawing.Size(112, 25);
            this.labelBuildName.TabIndex = 1;
            this.labelBuildName.Text = "Build Name";
            // 
            // groupBoxBuildTasks
            // 
            this.groupBoxBuildTasks.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxBuildTasks.Controls.Add(this.treeViewTasks);
            this.groupBoxBuildTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxBuildTasks.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBuildTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBuildTasks.Name = "groupBoxBuildTasks";
            this.groupBoxBuildTasks.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBuildTasks.Size = new System.Drawing.Size(329, 382);
            this.groupBoxBuildTasks.TabIndex = 2;
            this.groupBoxBuildTasks.TabStop = false;
            // 
            // treeViewTasks
            // 
            this.treeViewTasks.CheckBoxes = true;
            this.treeViewTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewTasks.Location = new System.Drawing.Point(2, 15);
            this.treeViewTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeViewTasks.Name = "treeViewTasks";
            this.treeViewTasks.Size = new System.Drawing.Size(228, 365);
            this.treeViewTasks.TabIndex = 0;
            this.treeViewTasks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LoadDescription);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(335, 61);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(338, 77);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(300, 64);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(338, 145);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(56, 19);
            this.buttonExecute.TabIndex = 5;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // BuildExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelBuildName);
            this.Controls.Add(this.groupBoxBuildTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(132, 227);
            this.Name = "BuildExecute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.groupBoxBuildTasks, 0);
            this.Controls.SetChildIndex(this.labelBuildName, 0);
            this.Controls.SetChildIndex(this.labelDescription, 0);
            this.Controls.SetChildIndex(this.richTextBoxDescription, 0);
            this.Controls.SetChildIndex(this.buttonExecute, 0);
            this.groupBoxBuildTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuildName;
        private System.Windows.Forms.GroupBox groupBoxBuildTasks;
        private System.Windows.Forms.TreeView treeViewTasks;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonExecute;
    }
}
