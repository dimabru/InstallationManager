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

namespace ExecutorApplication.View
{
    public partial class EMainForm : BaseMainForm
    {
        private XMLBuilds buildsInfo { get; set; }

        public EMainForm()
        {
            InitializeComponent();
            PropertiesHandler.CreateDefaultDirectory();
            this.createBuildsPathLabel();
            this.populateBuilds();
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
    }
}
