using HelperProject.HelperLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuilderApplication.View.File
{
    public partial class BuildDetailsView : Form
    {
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
    }
}
