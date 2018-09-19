using BuilderEngine;
using BuilderEngine.BuildOptions;
using BuilderView.File.PropertyOptions;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BuilderView.File
{
    public partial class PropertiesView : BaseView.BaseMainForm
    {
        private Dictionary<string, UserControl> optionsToControl;
        private XMLProperties buildOptions { get; set; }

        public PropertiesView()
        {
            InitializeComponent();

            populateOptions();
            listViewOptions.Items[0].Selected = true;
        }

        private void populateOptions()
        {
            try
            {
                buildOptions = BasicInfo.LoadOptions();
            }
            catch(XmlException ex)
            {
                Dialogs.ErrorMessage(ex.Message);
                return;
            }

            optionsToControl = new Dictionary<string, UserControl>()
            {
                { "General", new GeneralControl(buildOptions) }
            };

            foreach (string option in buildOptions.options)
            {
                listViewOptions.Items.Add(option);
            }


        }

        private void populateSettings(object sender, EventArgs e)
        {
            splitContainerProperties.Panel2.Controls.Clear();

            if (listViewOptions.SelectedItems.Count != 0)
            {
                string selected = listViewOptions.SelectedItems[0].Text;
                splitContainerProperties.Panel2.Controls.Add(optionsToControl[selected]);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            buildOptions.Save();
            this.Close();
        }
    }
}
