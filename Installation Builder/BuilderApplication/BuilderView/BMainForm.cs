using BuilderView.File;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BuilderView
{
    public partial class BMainForm : BaseView.BaseMainForm
    {
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
            new PropertiesView().ShowDialog();
        }

        private void populateBuilds()
        {
            try
            {
                listViewCurrentBuilds.Clear();
                buildsInfo = PropertiesHandler.LoadBuilds();

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
    }
}
