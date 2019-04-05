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
                this.richTextBoxDescription.Text = $"{selectedPlugin.name}\n{selectedPlugin.description}";
            }
            else
            {
                this.richTextBoxDescription.Text = string.Empty;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            new ExecutionService(this.build).execute();
        }
    }
}
