﻿namespace BuilderApplication.View.File
{
    partial class BuildDetailsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildDetailsView));
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panelBuilderMainForm = new System.Windows.Forms.Panel();
            this.ResumePictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBuilderMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResumePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(45, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.labelDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescription.Location = new System.Drawing.Point(251, 73);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 18);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(171, 105);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(248, 119);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(344, 243);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirm.Location = new System.Drawing.Point(263, 243);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // panelBuilderMainForm
            // 
            this.panelBuilderMainForm.AccessibleName = "Header";
            this.panelBuilderMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panelBuilderMainForm.Controls.Add(this.pictureBox1);
            this.panelBuilderMainForm.Controls.Add(this.ResumePictureBox2);
            this.panelBuilderMainForm.Controls.Add(this.ExitPictureBox1);
            this.panelBuilderMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuilderMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuilderMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelBuilderMainForm.Margin = new System.Windows.Forms.Padding(1);
            this.panelBuilderMainForm.Name = "panelBuilderMainForm";
            this.panelBuilderMainForm.Size = new System.Drawing.Size(431, 43);
            this.panelBuilderMainForm.TabIndex = 17;
            // 
            // ResumePictureBox2
            // 
            this.ResumePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("ResumePictureBox2.Image")));
            this.ResumePictureBox2.Location = new System.Drawing.Point(676, 1);
            this.ResumePictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.ResumePictureBox2.Name = "ResumePictureBox2";
            this.ResumePictureBox2.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.ResumePictureBox2.Size = new System.Drawing.Size(31, 42);
            this.ResumePictureBox2.TabIndex = 4;
            this.ResumePictureBox2.TabStop = false;
            // 
            // ExitPictureBox1
            // 
            this.ExitPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ExitPictureBox1.Image")));
            this.ExitPictureBox1.Location = new System.Drawing.Point(393, 0);
            this.ExitPictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.ExitPictureBox1.Name = "ExitPictureBox1";
            this.ExitPictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.ExitPictureBox1.Size = new System.Drawing.Size(38, 43);
            this.ExitPictureBox1.TabIndex = 3;
            this.ExitPictureBox1.TabStop = false;
            this.ExitPictureBox1.Click += new System.EventHandler(this.ExitPictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox1.Size = new System.Drawing.Size(31, 42);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BuildDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 284);
            this.Controls.Add(this.panelBuilderMainForm);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuildDetailsView";
            this.Text = "Build Details";
            this.panelBuilderMainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResumePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panelBuilderMainForm;
        private System.Windows.Forms.PictureBox ResumePictureBox2;
        private System.Windows.Forms.PictureBox ExitPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}