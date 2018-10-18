using HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuilderView.File
{
    public partial class BuildDetailsView : Form
    {
        public BuildDetailsView(List<Task> tasks)
        {
            InitializeComponent();
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

            Dialogs.NoticeMessage("Build save succesfully");
            this.Close();
        }
    }
}
