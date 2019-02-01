using System;
using System.Windows.Forms;
using HelperProject.BaseView.BuildOptions;
using HelperProject.HelperLibrary;

namespace HelperProject.BaseView.PropertyOptions
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
