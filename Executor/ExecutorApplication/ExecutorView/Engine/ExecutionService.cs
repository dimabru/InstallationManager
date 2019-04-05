using HelperProject.HelperLibrary;
using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExecutorView.Engine
{
    struct Output {
        public string errorOutput;
        public string standardOutput;
    }

    public class ExecutionService
    {
        public Build build { get; set; }
        private RichTextBox outputWindow;

        public ExecutionService(Build build, RichTextBox outputWindow)
        {
            this.build = build;
            this.outputWindow = outputWindow;
        }

        public void execute()
        {
            List<Task> tasks = this.build.tasks;
            foreach (Task task in tasks)
            {
                if (!task.enabled)
                {
                    continue;
                }
                foreach (Plugin plugin in task.plugins)
                {
                    if (!plugin.enabled)
                    {
                        continue;
                    }
                    this.executePlugin(plugin);
                }
            }
        } 

        private void executePlugin(Plugin plugin)
        {
            List<string> values = plugin.getValues();
            this.outputWindow.Text = "";

            foreach (string value in values)
            {
                Output output = this.executeCmd("cmd.exe", value);
                if (!String.IsNullOrEmpty(output.errorOutput))
                {
                    this.outputWindow.Text += $"Error: {output.errorOutput}\n";
                    break;
                }
            }
        }

        private Output executeCmd(string filename, string cmd)
        {
            this.outputWindow.Text += $"Executing command: {cmd}\n";
            cmd = cmd.Replace(@"\\", @"\");
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = filename;
            p.StartInfo.Arguments = "/c " + cmd;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.Start();
            p.WaitForExit();

            string output = p.StandardOutput.ReadToEnd();
            string errorOutput = p.StandardError.ReadToEnd();

            return new Output()
            {
                errorOutput = errorOutput,
                standardOutput = output
            };
        }
    }
}
