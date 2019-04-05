using HelperProject.BaseView.PropertyOptions;
using HelperProject.HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BaseView;
using System.Xml;
using System.Drawing.Drawing2D;


namespace BaseView
{
    public partial class PropertiesView : HelperProject.BaseView.BaseMainForm
    {
        /*
         * integers set so the borderless form could move
         */

        int mov;
        int movX;
        int movY;

        private Dictionary<string, UserControl> optionsToControl;
        private XMLProperties buildOptions { get; set; }

        public PropertiesView()
        {
            InitializeComponent();

            populateOptions();
            listViewOptions.Items[0].Selected = true;
        }

        private void populateOptions()
        {
            try
            {
                buildOptions = PropertiesHandler.LoadOptions();
            }
            catch (System.Xml.XmlException ex)
            {
                Dialogs.ErrorMessage(ex.Message);
                return;
            }

            optionsToControl = new Dictionary<string, UserControl>()
            {
                { "General", new GeneralControl(buildOptions) }
            };

            foreach (string option in buildOptions.options)
            {
                listViewOptions.Items.Add(option);
            }

        }

        private void populateSettings(object sender, EventArgs e)
        {
            splitContainerProperties.Panel2.Controls.Clear();

            if (listViewOptions.SelectedItems.Count != 0)
            {
                string selected = listViewOptions.SelectedItems[0].Text;
                splitContainerProperties.Panel2.Controls.Add(optionsToControl[selected]);
            }
        }

        private void ExitpictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResumepictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            buildOptions.Save();
            this.Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private object BMainForm()
        {
            throw new NotImplementedException();
        }

        /*
         * the functions that give the borderless form, moving capabilities
         */

        private void panelBuilderMainFrom_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelBuilderMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelBuilderMainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

    }
}
