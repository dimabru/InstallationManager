namespace BuilderApplication.View.File
{
    partial class BuildEditorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildEditorView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelChoosePlugin = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.treeViewPlugins = new System.Windows.Forms.TreeView();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddPlugin = new System.Windows.Forms.Button();
            this.comboBoxChoosePlugin = new System.Windows.Forms.ComboBox();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelBuilderMainForm = new System.Windows.Forms.Panel();
            this.ResumePictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox1 = new System.Windows.Forms.PictureBox();
            this.pluginControl = new BuilderApplication.View.File.PluginControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBuilderMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResumePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Location = new System.Drawing.Point(13, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.labelChoosePlugin);
            this.splitContainer1.Panel1.Controls.Add(this.labelDescription);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddTask);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTaskName);
            this.splitContainer1.Panel1.Controls.Add(this.treeViewPlugins);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDescription);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddPlugin);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxChoosePlugin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.pluginControl);
            this.splitContainer1.Size = new System.Drawing.Size(622, 367);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(338, 163);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelChoosePlugin
            // 
            this.labelChoosePlugin.AutoSize = true;
            this.labelChoosePlugin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.labelChoosePlugin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelChoosePlugin.Location = new System.Drawing.Point(19, 12);
            this.labelChoosePlugin.Name = "labelChoosePlugin";
            this.labelChoosePlugin.Size = new System.Drawing.Size(75, 13);
            this.labelChoosePlugin.TabIndex = 11;
            this.labelChoosePlugin.Text = "Choose Plugin";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescription.Location = new System.Drawing.Point(20, 70);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddTask.Location = new System.Drawing.Point(338, 46);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(63, 23);
            this.buttonAddTask.TabIndex = 8;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.textBoxTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTaskName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTaskName.Location = new System.Drawing.Point(320, 20);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(101, 20);
            this.textBoxTaskName.TabIndex = 0;
            this.textBoxTaskName.Text = "Task name ";
            // 
            // treeViewPlugins
            // 
            this.treeViewPlugins.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeViewPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewPlugins.HideSelection = false;
            this.treeViewPlugins.Location = new System.Drawing.Point(427, 20);
            this.treeViewPlugins.Name = "treeViewPlugins";
            this.treeViewPlugins.Size = new System.Drawing.Size(192, 166);
            this.treeViewPlugins.TabIndex = 7;
            this.treeViewPlugins.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.validTreeButtons);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Location = new System.Drawing.Point(20, 89);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(280, 97);
            this.textBoxDescription.TabIndex = 6;
            // 
            // buttonAddPlugin
            // 
            this.buttonAddPlugin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonAddPlugin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPlugin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPlugin.Location = new System.Drawing.Point(167, 29);
            this.buttonAddPlugin.Name = "buttonAddPlugin";
            this.buttonAddPlugin.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlugin.TabIndex = 4;
            this.buttonAddPlugin.Text = "Add";
            this.buttonAddPlugin.UseVisualStyleBackColor = false;
            this.buttonAddPlugin.Click += new System.EventHandler(this.buttonAddPlugin_Click);
            // 
            // comboBoxChoosePlugin
            // 
            this.comboBoxChoosePlugin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxChoosePlugin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoosePlugin.FormattingEnabled = true;
            this.comboBoxChoosePlugin.Items.AddRange(new object[] {
            "Action Provider1",
            "Action Provider2",
            "Action Provider3",
            "Action Provider4"});
            this.comboBoxChoosePlugin.Location = new System.Drawing.Point(20, 31);
            this.comboBoxChoosePlugin.Name = "comboBoxChoosePlugin";
            this.comboBoxChoosePlugin.Size = new System.Drawing.Size(141, 21);
            this.comboBoxChoosePlugin.TabIndex = 3;
            this.comboBoxChoosePlugin.SelectedIndexChanged += new System.EventHandler(this.updatePlugin);
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonEditTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditTask.Location = new System.Drawing.Point(650, 69);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(63, 23);
            this.buttonEditTask.TabIndex = 9;
            this.buttonEditTask.Text = "Edit";
            this.buttonEditTask.UseVisualStyleBackColor = false;
            this.buttonEditTask.Visible = false;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonMoveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMoveUp.Location = new System.Drawing.Point(650, 95);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(63, 23);
            this.buttonMoveUp.TabIndex = 13;
            this.buttonMoveUp.Text = "Move Up";
            this.buttonMoveUp.UseVisualStyleBackColor = false;
            this.buttonMoveUp.Visible = false;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonMoveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMoveDown.Location = new System.Drawing.Point(650, 119);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(63, 34);
            this.buttonMoveDown.TabIndex = 14;
            this.buttonMoveDown.Text = "Move Down";
            this.buttonMoveDown.UseVisualStyleBackColor = false;
            this.buttonMoveDown.Visible = false;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(650, 159);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelBuilderMainForm
            // 
            this.panelBuilderMainForm.AccessibleName = "Header";
            this.panelBuilderMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panelBuilderMainForm.Controls.Add(this.ResumePictureBox2);
            this.panelBuilderMainForm.Controls.Add(this.ExitPictureBox1);
            this.panelBuilderMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuilderMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuilderMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelBuilderMainForm.Margin = new System.Windows.Forms.Padding(1);
            this.panelBuilderMainForm.Name = "panelBuilderMainForm";
            this.panelBuilderMainForm.Size = new System.Drawing.Size(745, 43);
            this.panelBuilderMainForm.TabIndex = 16;
            this.panelBuilderMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseDown);
            this.panelBuilderMainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseMove);
            this.panelBuilderMainForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBuilderMainForm_MouseUp);
            // 
            // ResumePictureBox2
            // 
            this.ResumePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("ResumePictureBox2.Image")));
            this.ResumePictureBox2.Location = new System.Drawing.Point(676, 1);
            this.ResumePictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.ResumePictureBox2.Name = "ResumePictureBox2";
            this.ResumePictureBox2.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.ResumePictureBox2.Size = new System.Drawing.Size(31, 42);
            this.ResumePictureBox2.TabIndex = 4;
            this.ResumePictureBox2.TabStop = false;
            this.ResumePictureBox2.Click += new System.EventHandler(this.ResumePictureBox2_Click);
            // 
            // ExitPictureBox1
            // 
            this.ExitPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ExitPictureBox1.Image")));
            this.ExitPictureBox1.Location = new System.Drawing.Point(707, 0);
            this.ExitPictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.ExitPictureBox1.Name = "ExitPictureBox1";
            this.ExitPictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.ExitPictureBox1.Size = new System.Drawing.Size(38, 43);
            this.ExitPictureBox1.TabIndex = 3;
            this.ExitPictureBox1.TabStop = false;
            this.ExitPictureBox1.Click += new System.EventHandler(this.ExitPictureBox1_Click);
            // 
            // pluginControl
            // 
            this.pluginControl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pluginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginControl.inputDict = ((System.Collections.Generic.Dictionary<string, System.Windows.Forms.Control>)(resources.GetObject("pluginControl.inputDict")));
            this.pluginControl.Location = new System.Drawing.Point(0, 0);
            this.pluginControl.Margin = new System.Windows.Forms.Padding(4);
            this.pluginControl.Name = "pluginControl";
            this.pluginControl.Size = new System.Drawing.Size(622, 164);
            this.pluginControl.TabIndex = 0;
            // 
            // BuildEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(745, 462);
            this.Controls.Add(this.panelBuilderMainForm);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonEditTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(221, 319);
            this.Name = "BuildEditorView";
            this.Text = "Build Editor";
            this.Controls.SetChildIndex(this.buttonEditTask, 0);
            this.Controls.SetChildIndex(this.buttonMoveUp, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.buttonMoveDown, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.panelBuilderMainForm, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBuilderMainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResumePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddPlugin;
        private System.Windows.Forms.ComboBox comboBoxChoosePlugin;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.TreeView treeViewPlugins;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelChoosePlugin;
        private PluginControl pluginControl;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelBuilderMainForm;
        private System.Windows.Forms.PictureBox ResumePictureBox2;
        private System.Windows.Forms.PictureBox ExitPictureBox1;
    }
}
