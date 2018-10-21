using HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HelperLibrary
{
    public class Task
    {
        public List<Plugin> plugins { get; set; }
        public string name { get; set; }

        public Task(string n, List<Plugin> plugs)
        {
            name = n;
            plugins = plugs;
        }

        public Task(string n)
        {
            name = n;
            plugins = new List<Plugin>();
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
