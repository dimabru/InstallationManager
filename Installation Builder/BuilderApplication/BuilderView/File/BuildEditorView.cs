﻿using BuilderEngine;
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
            checkSaveButton();
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

            Plugin.LoadPlugins();
            foreach (Plugin plugin in Plugin.PluginList)
            {
                comboBoxChoosePlugin.Items.Add(plugin.name);
            }
        }

        private void buttonAddPlugin_Click(object sender, EventArgs e)
        {
            string pluginName = comboBoxChoosePlugin.Text;

            if (string.IsNullOrEmpty(pluginName))
            {
                return;
            }
            if (treeViewPlugins.SelectedNode == null || treeViewPlugins.SelectedNode.Level != 0)
            {
                Dialogs.ErrorMessage($"Please select a task to assign {pluginName} to");
                return;
            }
            if (checkCorrectPluginControlInput())
            {
                treeViewPlugins.SelectedNode.Nodes.Add(pluginName);
                Plugin plugin = Plugin.LocatePlugin(pluginName);
                
                foreach(string label in pluginControl.inputDict.Keys)
                {
                    plugin.updateInsertion(label, pluginControl.inputDict[label].Text);
                }
                pluginControl.resetInputs(plugin);
            }
            else
            {
                Dialogs.ErrorMessage("Please fill all fields");
            }

            treeViewPlugins.ExpandAll();
        }

        private bool checkCorrectPluginControlInput()
        {
            return pluginControl.filledInputs();
        }  

        private void updatePlugin(object sender, EventArgs e)
        {
            string selectedPlugin = comboBoxChoosePlugin.Text;

            if (string.IsNullOrEmpty(selectedPlugin))
            {
                pluginControl.setPluginStatus(visible: true);
                textBoxDescription.Text = String.Empty;
                return;
            }

            else
            {
                Plugin plugin = Plugin.LocatePlugin(selectedPlugin);
                textBoxDescription.Text = plugin.description;
                pluginControl.appendPluginInfo(plugin);
            }

        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {

        }

        private void checkSaveButton()
        {
            if (this.treeViewPlugins.Nodes.Count != 0)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
