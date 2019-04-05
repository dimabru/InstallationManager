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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildExecute));
            this.labelBuildName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.richTextBoxExecution = new System.Windows.Forms.RichTextBox();
            this.treeViewTasks = new System.Windows.Forms.TreeView();
            this.panelBuilderMainForm = new System.Windows.Forms.Panel();
            this.ExitpictureBox12 = new System.Windows.Forms.PictureBox();
            this.ResumepictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelBuilderMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumepictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuildName
            // 
            this.labelBuildName.AutoSize = true;
            this.labelBuildName.BackColor = System.Drawing.Color.Gray;
            this.labelBuildName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBuildName.Location = new System.Drawing.Point(333, 53);
            this.labelBuildName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuildName.Name = "labelBuildName";
            this.labelBuildName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBuildName.Size = new System.Drawing.Size(139, 33);
            this.labelBuildName.TabIndex = 1;
            this.labelBuildName.Text = "Build Name";
            this.labelBuildName.Click += new System.EventHandler(this.labelBuildName_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Gray;
            this.labelDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescription.Location = new System.Drawing.Point(236, 126);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(95, 23);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBoxDescription.Location = new System.Drawing.Point(335, 114);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(300, 64);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExecute.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonExecute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExecute.Location = new System.Drawing.Point(243, 208);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(73, 26);
            this.buttonExecute.TabIndex = 5;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // richTextBoxExecution
            // 
            this.richTextBoxExecution.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBoxExecution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxExecution.Location = new System.Drawing.Point(338, 208);
            this.richTextBoxExecution.Name = "richTextBoxExecution";
            this.richTextBoxExecution.ReadOnly = true;
            this.richTextBoxExecution.Size = new System.Drawing.Size(300, 162);
            this.richTextBoxExecution.TabIndex = 6;
            this.richTextBoxExecution.Text = "";
            // 
            // treeViewTasks
            // 
            this.treeViewTasks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeViewTasks.CheckBoxes = true;
            this.treeViewTasks.Location = new System.Drawing.Point(0, 43);
            this.treeViewTasks.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewTasks.Name = "treeViewTasks";
            this.treeViewTasks.Size = new System.Drawing.Size(228, 337);
            this.treeViewTasks.TabIndex = 0;
            this.treeViewTasks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LoadDescription);
            // 
            // panelBuilderMainForm
            // 
            this.panelBuilderMainForm.AccessibleName = "Header";
            this.panelBuilderMainForm.BackColor = System.Drawing.Color.Gray;
            this.panelBuilderMainForm.Controls.Add(this.ExitpictureBox12);
            this.panelBuilderMainForm.Controls.Add(this.ResumepictureBox3);
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
            this.ResumepictureBox3.Click += new System.EventHandler(this.ResumepictureBox3_Click);
            this.ResumepictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseDown);
            this.ResumepictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseMove);
            this.ResumepictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseUp);
            // 
            // BuildExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.panelBuilderMainForm);
            this.Controls.Add(this.treeViewTasks);
            this.Controls.Add(this.richTextBoxExecution);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelBuildName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(136, 234);
            this.Name = "BuildExecute";
            this.Controls.SetChildIndex(this.labelBuildName, 0);
            this.Controls.SetChildIndex(this.labelDescription, 0);
            this.Controls.SetChildIndex(this.richTextBoxDescription, 0);
            this.Controls.SetChildIndex(this.buttonExecute, 0);
            this.Controls.SetChildIndex(this.richTextBoxExecution, 0);
            this.Controls.SetChildIndex(this.treeViewTasks, 0);
            this.Controls.SetChildIndex(this.panelBuilderMainForm, 0);
            this.panelBuilderMainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumepictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuildName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.RichTextBox richTextBoxExecution;
        private System.Windows.Forms.TreeView treeViewTasks;
        private System.Windows.Forms.Panel panelBuilderMainForm;
        private System.Windows.Forms.PictureBox ExitpictureBox12;
        private System.Windows.Forms.PictureBox ResumepictureBox3;
    }
}
