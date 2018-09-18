using BuilderEngine;
using BuilderEngine.BuildOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BuilderView.File
{
    public partial class PropertiesView : BaseView.BaseMainForm
    {
        public PropertiesView()
        {
            InitializeComponent();

            populateOptions();
        }

        private void populateOptions()
        {
            XMLProperties properties;
            try
            {
                properties = new XMLProperties(BasicInfo.BuildsConfigLocation);
            }
            catch (DirectoryNotFoundException)
            {
                BasicInfo.CreateDefaultInformation();
                properties = new XMLProperties(BasicInfo.BuildsConfigLocation);
            }
            List<BuildOption> buildOptions = properties.options;

            foreach(BuildOption option in buildOptions)
            {
                addNode(new TreeNode(option.optionName));
            }
        }

        private void addNode(TreeNode node)
        {
            treeViewOptions.Nodes.Add(node);
        }
    }
}
