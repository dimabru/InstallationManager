using HelperProject.HelperLibrary;
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

        private Plugin plugin;
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
            this.plugin = plugin;
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
                else if (insertionValue.input == InsertionValueHelper.InputType.BrowseFile)
                {
                    input = new Button();
                    input.Text = "Browse";
                    input.Click += new EventHandler(this.browseFileOnClick);
                    input.Tag = plugin.insertions.IndexOf(insertionValue).ToString();
                }
                else
                {
                    input = new Control();
                }
                int pluginHeight = Height / (plugin.insertions.Count + 1) * (plugin.insertions.IndexOf(insertionValue) + 1);

                Label label = new Label();
                label.Width = label.Width * 3;
                label.Text = insertionValue.label;
                label.Left = (Width - label.Width) / 10;
                label.Top = pluginHeight;
                input.Left = (Width - input.Width) / 2;
                input.Top = pluginHeight;
                input.Width = input.Width * 2;

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

        private void browseFileOnClick(object sender, EventArgs e)
        {
            string selectedFile = Dialogs.SelectFile();
            if (String.IsNullOrEmpty(selectedFile))
            {
                return;
            }

            if (!selectedFile.EndsWith(".exe") && !selectedFile.EndsWith(".msi"))
            {
                Dialogs.ErrorMessage("File must end with exe or msi");
                return;
            }
            
            Button button = (Button)sender;
            button.Text = selectedFile;
            int index = Int32.Parse(button.Tag.ToString());
            InsertionValueHelper insertion = this.plugin.insertions[index];
            this.plugin.valueDict[insertion] = selectedFile;
        }
    }
}
