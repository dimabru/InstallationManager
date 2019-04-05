using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HelperProject.BaseView;
using BaseView;
using HelperProject.HelperLibrary;
using System.Xml;
using BaseView.HelperLibrary;
using ExecutorView.View;
using System.Runtime.InteropServices;

namespace ExecutorApplication.View
{
    public partial class EMainForm : BaseMainForm
    {
        /*
         * integers set so the borderless form could move
         */
        int mov;
        int movX;
        int movY;

        private XMLBuilds buildsInfo { get; set; }


        public EMainForm()
        {
            InitializeComponent();
            PropertiesHandler.CreateDefaultDirectory();
            this.createBuildsPathLabel();
            this.populateBuilds();
        }



        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;

            }
            base.WndProc(ref m);
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

        private void createBuildsPathLabel()
        {
            string buildsPath = DefaultInfo.BuildsInfoLocation;
            string[] folderStack = buildsPath.Split('\\');
            int depth = folderStack.Length;

            if (depth <= 3)
            {
                this.labelBuildsFolderPath.Text = DefaultInfo.BuildsInfoLocation;
                return;
            }

            string buildString = $"{folderStack[0]}\\...\\{folderStack[folderStack.Length - 1]}";
            this.labelBuildsFolderPath.Text = buildString;

            ToolTip buildPathToolTip = new ToolTip();

            buildPathToolTip.ToolTipIcon = ToolTipIcon.Info;
            buildPathToolTip.IsBalloon = true;
            buildPathToolTip.SetToolTip(this.labelBuildsFolderPath, DefaultInfo.BuildsInfoLocation);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PropertiesView().ShowDialog();
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedBuild = listViewCurrentBuilds.SelectedItems[0].Text;
                if (string.IsNullOrEmpty(selectedBuild))
                {
                    return;
                }
                Build build = buildsInfo.getBuild(selectedBuild);

                new BuildExecute(build).ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
       

        private void ExitpictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void labelCurrentBuilds_Click(object sender, EventArgs e)
        {
            labelCurrentBuilds.BackColor = System.Drawing.Color.Transparent;
        }

        private void labelCurrentBuildsFolder_Click(object sender, EventArgs e)
        {

        }

        private void labelBuildsFolderPath_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
