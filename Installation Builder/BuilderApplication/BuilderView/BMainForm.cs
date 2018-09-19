using BuilderEngine;
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
            BasicInfo.CreateDefaultDirectory();

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
                buildsInfo = BasicInfo.LoadBuilds();

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
    }
}
