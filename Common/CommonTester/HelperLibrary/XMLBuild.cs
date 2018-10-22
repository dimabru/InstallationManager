using BuilderEngine.BuildOptions;
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
        private List<Task> tasks { get; set; }

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
                List<Plugin> plugins;
            }
        }
    }
}
