﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuilderEngine;

namespace BuilderView.File.BuildEditor
{
    public partial class Builds : UserControl
    {
        public Builds(XMLBuildEditor properties)
        {
            InitializeComponent();

            //buildEditor = properties.buildEditor;
            //updateCurrentPath();
        }
    }
    
}
