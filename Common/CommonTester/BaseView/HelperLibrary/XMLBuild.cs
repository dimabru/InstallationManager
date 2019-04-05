using HelperProject.HelperLibrary.Exceptions;
using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HelperProject.HelperLibrary
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
                    List<XElement> inputElements = pluginElement.Descendants("Input").ToList();
                    Plugin plugin = new Plugin(name);

                    foreach (XElement inputElement in inputElements)
                    {
                        string label = inputElement.Attribute("Label").Value;
                        string value = inputElement.Attribute("Value").Value;
                        InsertionValueHelper.InputType input = (InsertionValueHelper.InputType)Enum.Parse(typeof(InsertionValueHelper.InputType), inputElement.Attribute("Type").Value);
                        InsertionValueHelper insertion = new InsertionValueHelper(input, label);

                        plugin.valueDict[insertion] = value;
                    }

                    plugins.Add(plugin);
                }
                Task task = new Task(taskName);
                task.plugins = plugins;
                tasks.Add(task);
            }
        }
    }
}
