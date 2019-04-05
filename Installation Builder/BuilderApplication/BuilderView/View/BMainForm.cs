using BaseView;
using BaseView.HelperLibrary;
using BuilderApplication.View.File;
using HelperProject.HelperLibrary;
using System;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Drawing2D;


namespace BuilderApplication.View
{
    
    public partial class BMainForm : HelperProject.BaseView.BaseMainForm
    {
        /*
         * integers set so the borderless form could move
         */
        int mov;
        int movX;
        int movY;
        private XMLBuilds buildsInfo { get; set; }

        public BMainForm()
        {
            InitializeComponent();
            PropertiesHandler.CreateDefaultDirectory();

            populateBuilds();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertiesView propView = new PropertiesView();
            propView.ShowDialog();

        }

        private void populateBuilds()
        {
            try
            {
                listViewCurrentBuilds.Clear();
                buildsInfo = BuildLoader.LoadBuilds();

                foreach (Build build in buildsInfo.builds)
                {
                    listViewCurrentBuilds.Items.Add(build.name);
                }
            }
            catch (XmlException ex)
            {
                Dialogs.ErrorMessage($"Unable to load builds list\n{ex.Message}");
            }
        }

        private void createNewBuildtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCreateNewBuild_Click(sender, e);
        }

        private void buttonCreateNewBuild_Click(object sender, EventArgs e)
        {
            new BuildEditorView().ShowDialog();
        }

        private void LoadDescription(object sender, EventArgs e)
        {
            try
            {
                string selectedBuild = listViewCurrentBuilds.SelectedItems[0].Text;
                richTextBoxDescription.Text = String.Empty;

                if (string.IsNullOrEmpty(selectedBuild))
                {
                    return;
                }

                string description = buildsInfo.getDescription(selectedBuild);
                richTextBoxDescription.Text = description;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCurrentBuilds.SelectedItems.Count == 0)
            {
                return;
            }

            string buildName = listViewCurrentBuilds.SelectedItems[0].Text;
            string buildPath = buildsInfo.getBuildPath(buildName);
            string buildDescription = richTextBoxDescription.Text;

            XMLBuild xmlBuild = new XMLBuild(buildPath + "\\" + DefaultInfo.BuildDetailsFileName);
            new BuildEditorView(xmlBuild.tasks, buildName, buildDescription).ShowDialog();
        }


        private void ExitPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResumePictureBox2_Click(object sender, EventArgs e)
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
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelBuilderMainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void propertiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonCreateNewBuild_Click(sender,e);
        }

        private void quitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertiesView propView = new PropertiesView();
            propView.ShowDialog();
        }

        private void ExitpictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
