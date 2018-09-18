using BuilderEngine;
using BuilderEngine.BuildOptions;
using HelperLibrary;
using HelperLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuilderView.File
{
    public partial class PropertiesView : BaseView.BaseProperties
    {
        public PropertiesView()
        {
            InitializeComponent();

            populateOptions();
        }

        private void populateOptions()
        {
            XMLProperties buildOptions = BasicInfo.LoadOptions();


            foreach (string option in buildOptions.options)
            {
                addNode(new TreeNode(option));
            }

        }

        private void addNode(TreeNode node)
        {
            treeViewOptions.Nodes.Add(node);
        }
    }
}
