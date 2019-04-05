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

        private void ExitPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
         * integers set so the borderless form could move
         */
        int mov;
        int movX;
        int movY;


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
