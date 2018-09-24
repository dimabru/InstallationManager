using BuilderEngine;
using BuilderEngine.BuildOptions;
using BuilderView.File.BuildEditor;
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
    public partial class BuildView : BaseView.BaseMainForm
    {
        private Dictionary<string, UserControl> Builds;
        private XMLBuildEditor newBuild { get; set; }

        public BuildView()
        {
            InitializeComponent();

            //populateBuild();
           // listViewBuild.Items[0].Selected = true;
        }


        //private void populateBuild()
        //{
        //    try
        //    {
        //        newBuild = BasicInfo.LoadOptions();
        //    }
        //    catch (XmlException ex)
        //    {
        //        Dialogs.ErrorMessage(ex.Message);
        //        return;
        //    }

        //    Builds = new Dictionary<string, UserControl>()
        //    {
        //        { "Action Provider1", new Builds(newBuild) }
        //    };

        //    foreach (string option in newBuild.build)
        //    {
        //        listViewBuild.Items.Add(option);
        //    }


        //}
    }
}
