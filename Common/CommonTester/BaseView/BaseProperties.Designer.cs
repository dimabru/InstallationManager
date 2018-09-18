namespace BaseView
{
    partial class BaseProperties
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
            this.treeViewOptions = new System.Windows.Forms.TreeView();
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
            this.splitContainerProperties.Panel1.Controls.Add(this.treeViewOptions);
            this.splitContainerProperties.Size = new System.Drawing.Size(657, 522);
            this.splitContainerProperties.SplitterDistance = 219;
            this.splitContainerProperties.TabIndex = 1;
            // 
            // treeViewOptions
            // 
            this.treeViewOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOptions.Location = new System.Drawing.Point(0, 0);
            this.treeViewOptions.Name = "treeViewOptions";
            this.treeViewOptions.Size = new System.Drawing.Size(219, 522);
            this.treeViewOptions.TabIndex = 0;
            // 
            // BaseProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(657, 548);
            this.Controls.Add(this.splitContainerProperties);
            this.Name = "BaseProperties";
            this.Controls.SetChildIndex(this.splitContainerProperties, 0);
            this.splitContainerProperties.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProperties)).EndInit();
            this.splitContainerProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerProperties;
        protected System.Windows.Forms.TreeView treeViewOptions;
    }
}
