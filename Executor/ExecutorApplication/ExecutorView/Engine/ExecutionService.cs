using HelperProject.HelperLibrary;
using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

            foreach (InsertionValueHelper insertion in plugin.valueDict.Keys)
            {
                Output output;
                if (insertion.input == InsertionValueHelper.InputType.BrowseFile)
                {
                    string filepath = plugin.valueDict[insertion];
                    string filename = Path.GetFileName(filepath);
                    filepath = Path.Combine(this.build.path, filename);
                    output = this.executeCmd(filepath, "", true);
                }
                else
                {
                    output = this.executeCmd("cmd.exe", plugin.valueDict[insertion]);
                }

                if (!String.IsNullOrEmpty(output.errorOutput))
                {
                    this.outputWindow.Text += $"Error: {output.errorOutput}\n";
                    break;
                }
            }
        }

        private Output executeCmd(string filename, string cmd, bool externalFile = false)
        {
            cmd = cmd.Replace(@"\\", @"\");
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = filename;
            if (!externalFile)
            {
                this.outputWindow.Text += $"Executing command: {cmd}\n";
                p.StartInfo.Arguments = "/c " + cmd;
            }
            else
            {
                this.outputWindow.Text += $"Running file: {filename}";
            }
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
