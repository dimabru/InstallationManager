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
        /*.
         * integers set so the borderless form could move
         */
        int mov;
        int movX;
        int movY;

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

        private void ExitpictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResumepictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
         * the functions that give the borderless form, moving capabilities
         */

        private void panelBuilderMainForm_MouseDown(object sender, MouseEventArgs e)
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

        private void labelDescription_Click(object sender, EventArgs e)
        {
            labelDescription.BackColor = System.Drawing.Color.Transparent;
        }

        private void labelBuildName_Click(object sender, EventArgs e)
        {
            labelBuildName.BackColor = System.Drawing.Color.Transparent;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.labelDescription_Click(null, null);
            this.labelBuildName_Click(null, null);
        }
    }
}
