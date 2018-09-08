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
            this.menuStripBase = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripBase
            // 
            this.menuStripBase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStripBase.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStripBase.Location = new System.Drawing.Point(0, 0);
            this.menuStripBase.Name = "menuStripBase";
            this.menuStripBase.Size = new System.Drawing.Size(860, 28);
            this.menuStripBase.TabIndex = 0;
            this.menuStripBase.Text = "menuStripBase";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BaseMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 489);
            this.Controls.Add(this.menuStripBase);
            this.MainMenuStrip = this.menuStripBase;
            this.MinimumSize = new System.Drawing.Size(878, 536);
            this.Name = "BaseMainForm";
            this.Text = "Installation Manager";
            this.menuStripBase.ResumeLayout(false);
            this.menuStripBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripBase;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}