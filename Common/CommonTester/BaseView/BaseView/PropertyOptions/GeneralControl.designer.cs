namespace HelperProject.BaseView.PropertyOptions
{
    partial class GeneralControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBuildPath = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxBuildPath = new System.Windows.Forms.GroupBox();
            this.groupBoxBuildPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuildPath
            // 
            this.labelBuildPath.AutoSize = true;
            this.labelBuildPath.Location = new System.Drawing.Point(21, 15);
            this.labelBuildPath.Name = "labelBuildPath";
            this.labelBuildPath.Size = new System.Drawing.Size(72, 17);
            this.labelBuildPath.TabIndex = 0;
            this.labelBuildPath.Text = "Build Path";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(231, 15);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(21, 49);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(115, 17);
            this.labelCurrentPath.TabIndex = 2;
            this.labelCurrentPath.Text = "Path Not Loaded";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBoxBuildPath
            // 
            this.groupBoxBuildPath.Controls.Add(this.buttonBrowse);
            this.groupBoxBuildPath.Controls.Add(this.labelCurrentPath);
            this.groupBoxBuildPath.Controls.Add(this.labelBuildPath);
            this.groupBoxBuildPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBuildPath.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBuildPath.Name = "groupBoxBuildPath";
            this.groupBoxBuildPath.Size = new System.Drawing.Size(540, 87);
            this.groupBoxBuildPath.TabIndex = 4;
            this.groupBoxBuildPath.TabStop = false;
            // 
            // GeneralControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBuildPath);
            this.Name = "GeneralControl";
            this.Size = new System.Drawing.Size(540, 411);
            this.groupBoxBuildPath.ResumeLayout(false);
            this.groupBoxBuildPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBuildPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxBuildPath;
    }
}
