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
        private List<Control> inputControls { get; set; }
        public PluginControl()
        {
            InitializeComponent();

            inputControls = new List<Control>();
        }

        public void setPluginStatus(bool visible)
        {
            labelSelectPlugin.Visible = visible;
        }

        public void appendPluginInfo(Plugin plugin)
        {
            setPluginStatus(visible: false);

            foreach (InsertionValueHelper insertionValue in plugin.insertions)
            {
                Control input;

                if (insertionValue.input == InsertionValueHelper.InputType.TextBox)
                {
                    input = new TextBox();
                }
                else if (insertionValue.input == InsertionValueHelper.InputType.ComboBox)
                {
                    input = new ComboBox();
                }
                else
                {
                    input = new Control();
                }
                int pluginHeight = Height / (plugin.insertions.Count + 1) * (plugin.insertions.IndexOf(insertionValue) + 1);

                Label label = new Label();
                label.Text = insertionValue.label;
                label.Left = (Width - label.Width) / 5;
                label.Top = pluginHeight;
                input.Left = (Width - input.Width) / 2;
                input.Top = pluginHeight;

                Controls.Add(input);
                Controls.Add(label);
                inputControls.Add(input);
            }
        }

        public bool filledInputs()
        {
            foreach (Control control in inputControls)
            {
                if (String.IsNullOrEmpty(control.Text))
                {
                    return false;
                }
            }
            return true;
        }

        public void resetInputs()
        {
            foreach (Control control in inputControls)
            {
                control.Text = String.Empty;
            }
        }
    }
}
