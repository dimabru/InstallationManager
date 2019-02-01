using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderApplication.View.File
{
    public partial class EditNameView : Form
    {
        private BuildEditorView root { get; }
        private string oldName { get; }

        public EditNameView(string name, BuildEditorView editor)
        {
            InitializeComponent();

            textBoxName.Text = name;
            oldName = name;
            root = editor;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string newName = textBoxName.Text;
            root.updateTaskName(oldName, newName);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
