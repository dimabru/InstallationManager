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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.treeViewPlugins = new System.Windows.Forms.TreeView();
            this.textBoxActionDescription = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.comboBoxChooseActionProvider = new System.Windows.Forms.ComboBox();
            this.listViewPluginEditor = new System.Windows.Forms.ListView();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonEdit);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddTask);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTaskName);
            this.splitContainer1.Panel1.Controls.Add(this.treeViewPlugins);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxActionDescription);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxChooseActionProvider);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewPluginEditor);
            this.splitContainer1.Size = new System.Drawing.Size(622, 367);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(232, 56);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(68, 23);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(150, 56);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(63, 23);
            this.buttonAddTask.TabIndex = 8;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(20, 56);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(112, 20);
            this.textBoxTaskName.TabIndex = 0;
            this.textBoxTaskName.Text = "Task name";
            // 
            // treeViewPlugins
            // 
            this.treeViewPlugins.Location = new System.Drawing.Point(333, 20);
            this.treeViewPlugins.Name = "treeViewPlugins";
            this.treeViewPlugins.Size = new System.Drawing.Size(264, 166);
            this.treeViewPlugins.TabIndex = 7;
            // 
            // textBoxActionDescription
            // 
            this.textBoxActionDescription.Location = new System.Drawing.Point(20, 89);
            this.textBoxActionDescription.Multiline = true;
            this.textBoxActionDescription.Name = "textBoxActionDescription";
            this.textBoxActionDescription.Size = new System.Drawing.Size(280, 97);
            this.textBoxActionDescription.TabIndex = 6;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(195, 20);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseActionProvider
            // 
            this.comboBoxChooseActionProvider.FormattingEnabled = true;
            this.comboBoxChooseActionProvider.Items.AddRange(new object[] {
            "Action Provider1",
            "Action Provider2",
            "Action Provider3",
            "Action Provider4"});
            this.comboBoxChooseActionProvider.Location = new System.Drawing.Point(20, 20);
            this.comboBoxChooseActionProvider.Name = "comboBoxChooseActionProvider";
            this.comboBoxChooseActionProvider.Size = new System.Drawing.Size(141, 21);
            this.comboBoxChooseActionProvider.TabIndex = 3;
            this.comboBoxChooseActionProvider.Text = "Choose Action Provider";
            // 
            // listViewPluginEditor
            // 
            this.listViewPluginEditor.Location = new System.Drawing.Point(20, 19);
            this.listViewPluginEditor.Name = "listViewPluginEditor";
            this.listViewPluginEditor.Size = new System.Drawing.Size(577, 126);
            this.listViewPluginEditor.TabIndex = 0;
            this.listViewPluginEditor.UseCompatibleStateImageBehavior = false;
            // 
            // BuildEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildEditorView";
            this.Text = "Build Editor";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
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
        private System.Windows.Forms.TextBox textBoxActionDescription;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseActionProvider;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.TreeView treeViewPlugins;
        private System.Windows.Forms.ListView listViewPluginEditor;
    }
}
