namespace ProjectCreatorView
{
    partial class MainForm
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
            this.PropertiesButton = new System.Windows.Forms.Button();
            this.ViewProjectsButton = new System.Windows.Forms.Button();
            this.CreateProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PropertiesButton
            // 
            this.PropertiesButton.Location = new System.Drawing.Point(77, 222);
            this.PropertiesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PropertiesButton.Name = "PropertiesButton";
            this.PropertiesButton.Size = new System.Drawing.Size(106, 23);
            this.PropertiesButton.TabIndex = 6;
            this.PropertiesButton.Text = "Properties";
            this.PropertiesButton.UseVisualStyleBackColor = true;
            this.PropertiesButton.Click += new System.EventHandler(this.PropertiesButton_Click);
            // 
            // ViewProjectsButton
            // 
            this.ViewProjectsButton.Location = new System.Drawing.Point(77, 143);
            this.ViewProjectsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ViewProjectsButton.Name = "ViewProjectsButton";
            this.ViewProjectsButton.Size = new System.Drawing.Size(106, 23);
            this.ViewProjectsButton.TabIndex = 5;
            this.ViewProjectsButton.Text = "View Projects";
            this.ViewProjectsButton.UseVisualStyleBackColor = true;
            this.ViewProjectsButton.Click += new System.EventHandler(this.ViewProjectsButton_Click);
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.Location = new System.Drawing.Point(77, 65);
            this.CreateProjectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(106, 23);
            this.CreateProjectButton.TabIndex = 4;
            this.CreateProjectButton.Text = "Create Project";
            this.CreateProjectButton.UseVisualStyleBackColor = true;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(254, 331);
            this.Controls.Add(this.PropertiesButton);
            this.Controls.Add(this.ViewProjectsButton);
            this.Controls.Add(this.CreateProjectButton);
            this.MinimumSize = new System.Drawing.Size(270, 370);
            this.Name = "MainForm";
            this.Text = "Project Creator";
            this.Controls.SetChildIndex(this.CreateProjectButton, 0);
            this.Controls.SetChildIndex(this.ViewProjectsButton, 0);
            this.Controls.SetChildIndex(this.PropertiesButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PropertiesButton;
        private System.Windows.Forms.Button ViewProjectsButton;
        private System.Windows.Forms.Button CreateProjectButton;
    }
}
