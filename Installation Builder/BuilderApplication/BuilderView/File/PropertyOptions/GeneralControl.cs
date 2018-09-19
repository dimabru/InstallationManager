using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperLibrary;
using BuilderEngine.BuildOptions;
using BuilderEngine;

namespace BuilderView.File.PropertyOptions
{
    public partial class GeneralControl : UserControl
    {
        General general;
        public GeneralControl(XMLProperties properties)
        {
            InitializeComponent();

            general = properties.general;
            updateCurrentPath();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            string path = Dialogs.OpenFolder();

            if (!string.IsNullOrEmpty(path))
            {
                general.buildPath = path;
                updateCurrentPath();
            }
        }

        private void updateCurrentPath()
        {
            labelCurrentPath.Text = general.buildPath;
        }
    }
}
