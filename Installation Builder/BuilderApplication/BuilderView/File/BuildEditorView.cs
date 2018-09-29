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
    public partial class BuildEditorView : BaseView.BaseMainForm
    {

        public BuildEditorView()
        {
            InitializeComponent();

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Task already exists!\nYou can now edit the task");
            buttonEdit.Visible = true;
        }
    }
}
