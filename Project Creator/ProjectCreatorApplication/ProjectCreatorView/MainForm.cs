﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectCreatorView
{
    public partial class MainForm : BaseView.BaseMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            new PropertiesView().Show();
        }
    }
}
