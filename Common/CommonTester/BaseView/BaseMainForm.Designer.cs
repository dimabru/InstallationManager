namespace BaseView
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
        private void InitializeComponent()
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
            this.statusStripBase.Location = new System.Drawing.Point(0, 463);
            this.statusStripBase.Name = "statusStripBase";
            this.statusStripBase.Size = new System.Drawing.Size(860, 26);
            this.statusStripBase.TabIndex = 0;
            this.statusStripBase.Text = "statusStripBase";
            // 
            // toolStripStatusLabelCurrentProject
            // 
            this.toolStripStatusLabelCurrentProject.Name = "toolStripStatusLabelCurrentProject";
            this.toolStripStatusLabelCurrentProject.Size = new System.Drawing.Size(150, 21);
            this.toolStripStatusLabelCurrentProject.Text = "Current Project: None";
            // 
            // toolStripDropDownButtonLicense
            // 
            this.toolStripDropDownButtonLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonLicense.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonLicense.Image")));
            this.toolStripDropDownButtonLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonLicense.Name = "toolStripDropDownButtonLicense";
            this.toolStripDropDownButtonLicense.Size = new System.Drawing.Size(71, 24);
            this.toolStripDropDownButtonLicense.Text = "License";
            this.toolStripDropDownButtonLicense.Click += new System.EventHandler(this.toolStripDropDownButtonLicense_Click);
            // 
            // BaseMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 489);
            this.Controls.Add(this.statusStripBase);
            this.MinimumSize = new System.Drawing.Size(878, 536);
            this.Name = "BaseMainForm";
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