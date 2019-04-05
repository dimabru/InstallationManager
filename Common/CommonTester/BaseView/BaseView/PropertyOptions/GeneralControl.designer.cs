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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralControl));
            this.labelBuildPath = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelBuildPath
            // 
            this.labelBuildPath.AutoSize = true;
            this.labelBuildPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.labelBuildPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBuildPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBuildPath.Location = new System.Drawing.Point(31, 15);
            this.labelBuildPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuildPath.Name = "labelBuildPath";
            this.labelBuildPath.Size = new System.Drawing.Size(55, 13);
            this.labelBuildPath.TabIndex = 0;
            this.labelBuildPath.Text = "Build Path";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBrowse.Location = new System.Drawing.Point(158, 15);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(56, 19);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.labelCurrentPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurrentPath.Location = new System.Drawing.Point(31, 53);
            this.labelCurrentPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(88, 13);
            this.labelCurrentPath.TabIndex = 2;
            this.labelCurrentPath.Text = "Path Not Loaded";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GeneralControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelCurrentPath);
            this.Controls.Add(this.labelBuildPath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GeneralControl";
            this.Size = new System.Drawing.Size(405, 334);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuildPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
