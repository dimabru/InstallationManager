using HelperProject.HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExecutorView.View
{
    public partial class BuildExecute : HelperProject.BaseView.BaseMainForm
    {
        public BuildExecute(Build build)
        {
            InitializeComponent();
            this.labelBuildName.Text = build.name;
        }
    }
}
