using ExecutorView.Engine;
using HelperProject.HelperLibrary;
using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExecutorView.View
{
    public partial class BuildExecute : HelperProject.BaseView.BaseMainForm
    {
        private Build build { get; set; }
        public BuildExecute(Build build)
        {
            InitializeComponent();
            this.build = build;
            this.labelBuildName.Text = build.name;
            this.populateTasks();
        }

        private void populateTasks()
        {
            foreach (Task task in this.build.tasks)
            {
                TreeNode taskNode = new TreeNode(task.name);
                taskNode.Name = "task";
                taskNode.Checked = true;
                foreach (Plugin plugin in task.plugins)
                {
                    TreeNode pluginNode = new TreeNode(plugin.name);
                    pluginNode.Checked = true;
                    pluginNode.Name = "plugin";
                    taskNode.Nodes.Add(pluginNode);
                }
                this.treeViewTasks.Nodes.Add(taskNode);
            }
            this.treeViewTasks.ExpandAll();
        }

        private void LoadDescription(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = this.treeViewTasks.SelectedNode;
            if (selectedNode.Name == "plugin")
            {
                TreeNode parentTask = selectedNode.Parent;
                Task selectedTask = this.build.tasks.Find(t => t.name == parentTask.Text);
                Plugin selectedPlugin = selectedTask.plugins.Find(p => p.name == selectedNode.Text);

                List<string> values = selectedPlugin.getValues();
                this.richTextBoxDescription.Text = $"{selectedPlugin.name}\n";

                foreach (string value in values)
                {
                    this.richTextBoxDescription.Text += $"{value}\n";
                }

            }
            else
            {
                this.richTextBoxDescription.Text = string.Empty;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            this.updateEnabled();
            new ExecutionService(this.build, this.richTextBoxExecution).execute();
        }

        private void updateEnabled()
        {
            for (int i = 0; i < treeViewTasks.Nodes.Count; i++)
            {
                Task task = this.build.tasks[i];
                task.enabled = treeViewTasks.Nodes[i].Checked;

                for (int j = 0; j < treeViewTasks.Nodes[i].Nodes.Count; j++)
                {
                    task.plugins[j].enabled = treeViewTasks.Nodes[i].Nodes[j].Checked;
                }
            }
        }
    }
}
