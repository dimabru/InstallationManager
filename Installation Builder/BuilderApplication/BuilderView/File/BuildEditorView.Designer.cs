namespace BuilderView.File
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
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.treeViewPlugins = new System.Windows.Forms.TreeView();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddPlugin = new System.Windows.Forms.Button();
            this.comboBoxChoosePlugin = new System.Windows.Forms.ComboBox();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pluginControl = new BuilderView.File.PluginControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
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
            this.splitContainer1.Panel2.Controls.Add(this.pluginControl);
            this.splitContainer1.Size = new System.Drawing.Size(622, 367);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(358, 163);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelChoosePlugin
            // 
            this.labelChoosePlugin.AutoSize = true;
            this.labelChoosePlugin.Location = new System.Drawing.Point(23, 12);
            this.labelChoosePlugin.Name = "labelChoosePlugin";
            this.labelChoosePlugin.Size = new System.Drawing.Size(75, 13);
            this.labelChoosePlugin.TabIndex = 11;
            this.labelChoosePlugin.Text = "Choose Plugin";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(20, 70);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(632, 32);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(63, 23);
            this.buttonEditTask.TabIndex = 9;
            this.buttonEditTask.Text = "Edit";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Visible = false;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(358, 46);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(63, 23);
            this.buttonAddTask.TabIndex = 8;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(320, 20);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(101, 20);
            this.textBoxTaskName.TabIndex = 0;
            this.textBoxTaskName.Text = "Task name";
            // 
            // treeViewPlugins
            // 
            this.treeViewPlugins.HideSelection = false;
            this.treeViewPlugins.Location = new System.Drawing.Point(427, 20);
            this.treeViewPlugins.Name = "treeViewPlugins";
            this.treeViewPlugins.Size = new System.Drawing.Size(192, 166);
            this.treeViewPlugins.TabIndex = 7;
            this.treeViewPlugins.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.validTreeButtons);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(20, 89);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(280, 97);
            this.textBoxDescription.TabIndex = 6;
            // 
            // buttonAddPlugin
            // 
            this.buttonAddPlugin.Location = new System.Drawing.Point(167, 29);
            this.buttonAddPlugin.Name = "buttonAddPlugin";
            this.buttonAddPlugin.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlugin.TabIndex = 4;
            this.buttonAddPlugin.Text = "Add";
            this.buttonAddPlugin.UseVisualStyleBackColor = true;
            this.buttonAddPlugin.Click += new System.EventHandler(this.buttonAddPlugin_Click);
            // 
            // comboBoxChoosePlugin
            // 
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
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(632, 58);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(63, 23);
            this.buttonMoveUp.TabIndex = 13;
            this.buttonMoveUp.Text = "Move Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Visible = false;
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveDown.Location = new System.Drawing.Point(632, 82);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(63, 34);
            this.buttonMoveDown.TabIndex = 14;
            this.buttonMoveDown.Text = "Move Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(632, 122);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // pluginControl
            // 
            this.pluginControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.ClientSize = new System.Drawing.Size(695, 404);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonEditTask);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}
