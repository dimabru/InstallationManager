using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperLibrary.Plugins;

namespace BuilderView.File
{
    public partial class PluginControl : UserControl
    {
        public PluginControl()
        {
            InitializeComponent();
        }

        public void setPluginStatus(bool visible)
        {
            labelSelectPlugin.Visible = visible;
        }

        public void appendPluginInfo(Plugin plugin)
        {
            setPluginStatus(visible: false);

            TextBox text = new TextBox();

            text.Name = "labelSelectPlugin";
            text.Text = "";
            text.Left = (Width - text.Width) / 2;
            text.Top = (Height - text.Height) / 2;
            text.Dock = DockStyle.Top;
            TextBox text1 = new TextBox();

            text1.Name = "labelSelectPlugin1";
            text1.Text = "";
            text1.Left = (Width - text1.Width) / 2;
            text1.Top = (Height - text1.Height) / 2;
            text1.Dock = DockStyle.Top;
            Controls.Add(text);
            Controls.Add(text1);
        }

    }
}
