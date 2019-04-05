namespace HelperProject.BaseView
{
    partial class BaseMainForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMainForm));
            this.statusStripBase = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCurrentProject = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButtonLicense = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStripBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripBase
            // 
            this.statusStripBase.GripMargin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.statusStripBase.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCurrentProject,
            this.toolStripDropDownButtonLicense});
            this.statusStripBase.Location = new System.Drawing.Point(0, 382);
            this.statusStripBase.Name = "statusStripBase";
            this.statusStripBase.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripBase.Size = new System.Drawing.Size(646, 22);
            this.statusStripBase.TabIndex = 0;
            this.statusStripBase.Text = "statusStripBase";
            // 
            // toolStripStatusLabelCurrentProject
            // 
            this.toolStripStatusLabelCurrentProject.Name = "toolStripStatusLabelCurrentProject";
            this.toolStripStatusLabelCurrentProject.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabelCurrentProject.Text = "Current Project: None";
            // 
            // toolStripDropDownButtonLicense
            // 
            this.toolStripDropDownButtonLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonLicense.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonLicense.Image")));
            this.toolStripDropDownButtonLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonLicense.Name = "toolStripDropDownButtonLicense";
            this.toolStripDropDownButtonLicense.Size = new System.Drawing.Size(59, 20);
            this.toolStripDropDownButtonLicense.Text = "License";
            this.toolStripDropDownButtonLicense.Click += new System.EventHandler(this.toolStripDropDownButtonLicense_Click);
            // 
            // BaseMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.statusStripBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(170, 270);
            this.Name = "BaseMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installation Manager";
            this.statusStripBase.ResumeLayout(false);
            this.statusStripBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripBase;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentProject;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonLicense;
    }
}