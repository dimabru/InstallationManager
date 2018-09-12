using BaseView;
using HelperLibrary;
using HelperLibrary.Exceptions;
using ProjectCreatorEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectCreatorView
{
    public partial class PropertiesView : BaseMainForm
    {
        public PropertiesView()
        {
            InitializeComponent();

            labelCurrentLocation.Text = ProjectInfo.ProjectLocation;
        }

        private void buttonProjectLocation_Click(object sender, EventArgs e)
        {
            try
            {
                Dialogs.OpenFolder();
            }
            catch (NotAFolderException ex)
            {
                Dialogs.ErrorMessage(ex.Message);
            }
        }
    }
}
