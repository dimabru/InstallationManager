using BuilderEngine;
using BuilderEngine.BuildOptions;
using HelperLibrary;
using HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            populatePlugins();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string task = textBoxTaskName.Text;

            if (taskExists(task))
            {
                Dialogs.ErrorMessage("Task already exist. Please enter a different name");
                return;
            }

            treeViewPlugins.Nodes.Add(task);
        }

        private bool taskExists(string task)
        {
            foreach (TreeNode node in treeViewPlugins.Nodes)
            {
                if (node.Text == task)
                {
                    return true;
                }
            }
            return false;
        }

        private void populatePlugins()
        {
            comboBoxChoosePlugin.Items.Clear();

            foreach (string plugin in Plugin.PluginList)
            {
                comboBoxChoosePlugin.Items.Add(plugin);
            }
        }

        private void buttonAddPlugin_Click(object sender, EventArgs e)
        {
            string plugin = comboBoxChoosePlugin.Text;

            if (string.IsNullOrEmpty(plugin))
            {
                return;
            }
            if (treeViewPlugins.SelectedNode == null || treeViewPlugins.SelectedNode.Level != 0)
            {
                Dialogs.ErrorMessage($"Please select a task to assign {plugin} to");
                return;
            }
            if (checkCorrectPluginControlInput())
            {
                treeViewPlugins.SelectedNode.Nodes.Add(plugin);
            }

            treeViewPlugins.ExpandAll();
        }

        private bool checkCorrectPluginControlInput()
        {
            return true;
        }  

        private void updatePlugin(object sender, EventArgs e)
        {
            string selectedPlugin = comboBoxChoosePlugin.Text;

            if (string.IsNullOrEmpty(selectedPlugin))
            {
                pluginControl.setPluginStatus(visible: true);
                return;
            }

            Type[] types = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "HelperLibrary.Plugins");

            foreach (Type type in types)
            {
                MessageBox.Show(type.ToString());
            }

        }

        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();
        }
    }
}
