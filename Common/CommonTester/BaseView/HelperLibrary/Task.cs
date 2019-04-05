using HelperProject.HelperLibrary.Plugins;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HelperProject.HelperLibrary
{
    public class Task
    {
        public List<Plugin> plugins { get; set; }
        public string name { get; set; }
        public bool enabled { get; set; }

        public Task(string n, List<Plugin> plugs)
        {
            name = n;
            plugins = plugs;
            enabled = true;
        }

        public Task(string n)
        {
            name = n;
            plugins = new List<Plugin>();
            enabled = true;
        }

        public void addPlugin(Plugin plugin)
        {
            plugins.Add(plugin);
        }

        public XElement Save()
        {
            XElement taskElement = new XElement("Task");
            taskElement.Add(new XAttribute("Name", name));

            foreach (Plugin plugin in plugins)
            {
                taskElement.Add(plugin.Save());
            }

            return taskElement;
        }
    }
}
