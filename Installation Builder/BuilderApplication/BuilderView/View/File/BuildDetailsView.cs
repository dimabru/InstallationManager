using HelperProject.HelperLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BuilderApplication.View.File
{
    public partial class BuildDetailsView : Form
    {
        /*
         * integers set so the borderless form could move
         */
        int mov;
        int movX;
        int movY;

        List<Task> tasks;

        public BuildDetailsView(List<Task> tsks, string name, string description)
        {
            InitializeComponent();

            tasks = tsks;
            textBoxName.Text = name;
            richTextBoxDescription.Text = description;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkValidFields()
        {
            return !string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(richTextBoxDescription.Text);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (!checkValidFields())
            {
                Dialogs.ErrorMessage("Please fill all fields");
                return;
            }

            string buildName = textBoxName.Text;
            string description = richTextBoxDescription.Text;
            string path = DefaultInfo.BuildsLocation + "\\" + buildName;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            Build build = new Build(buildName, path ,description);
            build.addTasks(tasks);
            build.save();

            Dialogs.NoticeMessage("Build saved succesfully");
            this.Close();
        }

        private void ExitPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
         * the functions that give the borderless form, moving capabilities
         */

        private void panelBuilderMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelBuilderMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelBuilderMainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        
    }
}
