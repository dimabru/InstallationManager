namespace BuilderView.File
{
    partial class PluginControl
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
            this.labelSelectPlugin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSelectPlugin
            // 
            this.labelSelectPlugin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectPlugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPlugin.Location = new System.Drawing.Point(0, 0);
            this.labelSelectPlugin.Name = "labelSelectPlugin";
            this.labelSelectPlugin.Size = new System.Drawing.Size(605, 263);
            this.labelSelectPlugin.TabIndex = 0;
            this.labelSelectPlugin.Text = "Select Plugin";
            this.labelSelectPlugin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelSelectPlugin);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(605, 263);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSelectPlugin;
    }
}
