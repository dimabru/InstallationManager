using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BuilderApplication.View.File
{
    public partial class PluginControl : UserControl
    {
        public Dictionary<string, Control> inputDict { get; set; }
        public PluginControl()
        {
            InitializeComponent();

            inputDict = new Dictionary<string, Control>();
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
                inputDict[label.Text] = input;
            }
        }

        public bool filledInputs()
        {
            foreach (string label in inputDict.Keys)
            {
                if (String.IsNullOrEmpty(inputDict[label].Text))
                {
                    return false;
                }
            }
            return true;
        }

        public void resetInputs(Plugin plugin)
        {
            foreach (Control control in inputDict.Values)
            {
                control.Text = String.Empty;
            }
        }
    }
}
