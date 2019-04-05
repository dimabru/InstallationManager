using HelperProject.HelperLibrary;
using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExecutorView.Engine
{
    public class ExecutionService
    {
        public Build build { get; set; }

        public ExecutionService(Build build)
        {
            this.build = build;
        }

        public void execute()
        {
            List<Task> tasks = this.build.tasks;
            foreach (Task task in tasks)
            {
                foreach (Plugin plugin in task.plugins)
                {
                    this.executePlugin(plugin);
                }
            }
        } 

        private void executePlugin(Plugin plugin)
        {
            List<InsertionValueHelper> insertions = plugin.insertions;

            foreach (InsertionValueHelper insertion in insertions)
            {
                MessageBox.Show(insertion.label);
            }
        }
    }
}
