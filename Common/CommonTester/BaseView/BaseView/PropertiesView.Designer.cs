namespace BaseView
{
    partial class PropertiesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesView));
            this.splitContainerProperties = new System.Windows.Forms.SplitContainer();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listViewOptions = new System.Windows.Forms.ListView();
            this.ResumepictureBox3 = new System.Windows.Forms.PictureBox();
            this.ExitpictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBuilderMainForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProperties)).BeginInit();
            this.splitContainerProperties.Panel1.SuspendLayout();
            this.splitContainerProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResumepictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox1)).BeginInit();
            this.panelBuilderMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerProperties
            // 
            this.splitContainerProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerProperties.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainerProperties.Location = new System.Drawing.Point(0, 45);
            this.splitContainerProperties.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerProperties.Name = "splitContainerProperties";
            // 
            // splitContainerProperties.Panel1
            // 
            this.splitContainerProperties.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.splitContainerProperties.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainerProperties.Panel1.BackgroundImage")));
            this.splitContainerProperties.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainerProperties.Panel1.Controls.Add(this.buttonSave);
            this.splitContainerProperties.Panel1.Controls.Add(this.listViewOptions);
            // 
            // splitContainerProperties.Panel2
            // 
            this.splitContainerProperties.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.splitContainerProperties.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainerProperties.Panel2.BackgroundImage")));
            this.splitContainerProperties.Size = new System.Drawing.Size(646, 337);
            this.splitContainerProperties.SplitterDistance = 215;
            this.splitContainerProperties.SplitterWidth = 3;
            this.splitContainerProperties.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(121, 291);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(65, 27);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(51, 291);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 27);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // listViewOptions
            // 
            this.listViewOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.listViewOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewOptions.BackgroundImage")));
            this.listViewOptions.GridLines = true;
            this.listViewOptions.Location = new System.Drawing.Point(0, 0);
            this.listViewOptions.Margin = new System.Windows.Forms.Padding(2);
            this.listViewOptions.MultiSelect = false;
            this.listViewOptions.Name = "listViewOptions";
            this.listViewOptions.Size = new System.Drawing.Size(222, 335);
            this.listViewOptions.TabIndex = 0;
            this.listViewOptions.UseCompatibleStateImageBehavior = false;
            this.listViewOptions.SelectedIndexChanged += new System.EventHandler(this.populateSettings);
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
            this.ExitpictureBox1.Click += new System.EventHandler(this.ExitpictureBox1_Click_1);
            // 
            // panelBuilderMainForm
            // 
            this.panelBuilderMainForm.AccessibleName = "Header";
            this.panelBuilderMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panelBuilderMainForm.Controls.Add(this.ExitpictureBox1);
            this.panelBuilderMainForm.Controls.Add(this.ResumepictureBox3);
            this.panelBuilderMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuilderMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuilderMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelBuilderMainForm.Margin = new System.Windows.Forms.Padding(1);
            this.panelBuilderMainForm.Name = "panelBuilderMainForm";
            this.panelBuilderMainForm.Size = new System.Drawing.Size(646, 43);
            this.panelBuilderMainForm.TabIndex = 10;
            this.panelBuilderMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainFrom_MouseDown);
            this.panelBuilderMainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseMove);
            this.panelBuilderMainForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseUp);
            // 
            // PropertiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.panelBuilderMainForm);
            this.Controls.Add(this.splitContainerProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(132, 227);
            this.Name = "PropertiesView";
            this.Text = "Properties";
            this.Controls.SetChildIndex(this.splitContainerProperties, 0);
            this.Controls.SetChildIndex(this.panelBuilderMainForm, 0);
            this.splitContainerProperties.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProperties)).EndInit();
            this.splitContainerProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResumepictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox1)).EndInit();
            this.panelBuilderMainForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerProperties;
        private System.Windows.Forms.ListView listViewOptions;
        private System.Windows.Forms.PictureBox ResumepictureBox3;
        private System.Windows.Forms.PictureBox ExitpictureBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelBuilderMainForm;
    }
}

