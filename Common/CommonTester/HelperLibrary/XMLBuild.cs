using HelperLibrary;
using HelperLibrary.Exceptions;
using HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace HelperLibrary
{
    public class XMLBuild : XMLFile
    {
        public List<Task> tasks { get; private set; }

        public XMLBuild(string path) : base(path)
        {
            populateTasks();
        }

        private void populateTasks()
        {
            List<XElement> elements;
            try
            {
                elements = GetElements("Task");
            }
            catch (MissingElementException)
            {
                return;
            }
            finally
            {
                tasks = new List<Task>();
            }

            foreach (XElement element in elements)
            {
                List<Plugin> plugins = new List<Plugin>();
                List<XElement> pluginElements = element.Descendants("Plugin").ToList();
                string taskName = element.Attribute("Name").Value;

                foreach (XElement pluginElement in pluginElements)
                {
                    string name = pluginElement.Attribute("Name").Value;
                    plugins.Add(new Plugin(name));
                }
                Task task = new Task(taskName);
                task.plugins = plugins;
                tasks.Add(task);
            }
        }
    }
}
