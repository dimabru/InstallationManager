using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelperLibrary
{
    // Build class. Has all necessary information to execute a succesfull build.
    public class Build
    {
        public string name { get; }
        public string path { get; }
        public string description { get; set; }
        public List<Task> tasks { get; set; }

        public Build(string buildName, string buildPath, string desc)
        {
            name = buildName;
            path = buildPath;
            description = desc;
            tasks = new List<Task>();
        }

        public void addTasks(List<Task> tsks)
        {
            foreach (Task task in tsks)
            {
                tasks.Add(task);
            }
        }

        public void save()
        {
            XDocument buildXml = new XDocument();
            XElement buildElement = new XElement("Build");
            buildElement.Add(new XAttribute("Name", name));
            buildElement.Add(new XAttribute("Description", description));

            foreach (Task task in tasks)
            {
                buildElement.Add(task.Save());
            }
            string filepath = path + "\\BuildDetails.xml";
            Directory.CreateDirectory(path);
            buildXml.Add(buildElement);
            buildXml.Save(filepath);

            XMLBuilds xmlBuilds = new XMLBuilds();
            xmlBuilds.addBuild(this);
            xmlBuilds.Save();
        }

    }
}
