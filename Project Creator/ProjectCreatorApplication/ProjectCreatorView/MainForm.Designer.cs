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
            this.buttonProperties = new System.Windows.Forms.Button();
            this.buttonViewProjects = new System.Windows.Forms.Button();
            this.buttonCreateProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProperties
            // 
            this.buttonProperties.Location = new System.Drawing.Point(77, 222);
            this.buttonProperties.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(106, 23);
            this.buttonProperties.TabIndex = 6;
            this.buttonProperties.Text = "Properties";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // buttonViewProjects
            // 
            this.buttonViewProjects.Location = new System.Drawing.Point(77, 143);
            this.buttonViewProjects.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonViewProjects.Name = "buttonViewProjects";
            this.buttonViewProjects.Size = new System.Drawing.Size(106, 23);
            this.buttonViewProjects.TabIndex = 5;
            this.buttonViewProjects.Text = "View Projects";
            this.buttonViewProjects.UseVisualStyleBackColor = true;
            // 
            // buttonCreateProject
            // 
            this.buttonCreateProject.Location = new System.Drawing.Point(77, 68);
            this.buttonCreateProject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCreateProject.Name = "buttonCreateProject";
            this.buttonCreateProject.Size = new System.Drawing.Size(106, 23);
            this.buttonCreateProject.TabIndex = 4;
            this.buttonCreateProject.Text = "Create Project";
            this.buttonCreateProject.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(250, 299);
            this.Controls.Add(this.buttonProperties);
            this.Controls.Add(this.buttonViewProjects);
            this.Controls.Add(this.buttonCreateProject);
            this.Name = "MainForm";
            this.Text = "Project Creator";
            this.Controls.SetChildIndex(this.buttonCreateProject, 0);
            this.Controls.SetChildIndex(this.buttonViewProjects, 0);
            this.Controls.SetChildIndex(this.buttonProperties, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonViewProjects;
        private System.Windows.Forms.Button buttonCreateProject;
    }
}
