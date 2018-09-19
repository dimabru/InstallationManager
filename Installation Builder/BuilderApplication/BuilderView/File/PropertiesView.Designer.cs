namespace BuilderView.File
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
            this.splitContainerProperties = new System.Windows.Forms.SplitContainer();
            this.listViewOptions = new System.Windows.Forms.ListView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProperties)).BeginInit();
            this.splitContainerProperties.Panel1.SuspendLayout();
            this.splitContainerProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerProperties
            // 
            this.splitContainerProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProperties.Location = new System.Drawing.Point(0, 0);
            this.splitContainerProperties.Name = "splitContainerProperties";
            // 
            // splitContainerProperties.Panel1
            // 
            this.splitContainerProperties.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainerProperties.Panel1.Controls.Add(this.buttonSave);
            this.splitContainerProperties.Panel1.Controls.Add(this.listViewOptions);
            this.splitContainerProperties.Size = new System.Drawing.Size(861, 471);
            this.splitContainerProperties.SplitterDistance = 287;
            this.splitContainerProperties.TabIndex = 1;
            // 
            // listViewOptions
            // 
            this.listViewOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOptions.Location = new System.Drawing.Point(0, 0);
            this.listViewOptions.MultiSelect = false;
            this.listViewOptions.Name = "listViewOptions";
            this.listViewOptions.Size = new System.Drawing.Size(287, 471);
            this.listViewOptions.TabIndex = 0;
            this.listViewOptions.UseCompatibleStateImageBehavior = false;
            this.listViewOptions.SelectedIndexChanged += new System.EventHandler(this.populateSettings);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(128, 445);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(209, 445);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PropertiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(861, 497);
            this.Controls.Add(this.splitContainerProperties);
            this.Name = "PropertiesView";
            this.Text = "Properties";
            this.Controls.SetChildIndex(this.splitContainerProperties, 0);
            this.splitContainerProperties.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProperties)).EndInit();
            this.splitContainerProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerProperties;
        private System.Windows.Forms.ListView listViewOptions;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}
