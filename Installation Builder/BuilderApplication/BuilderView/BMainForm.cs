using BuilderEngine;
using BuilderView.File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuilderView
{
    public partial class BMainForm : BaseView.BaseMainForm
    {
        public BMainForm()
        {
            InitializeComponent();
            BasicInfo.CreateDefaultDirectory();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PropertiesView().ShowDialog();
        }
    }
}
