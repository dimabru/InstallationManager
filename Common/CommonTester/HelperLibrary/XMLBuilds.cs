using BuilderEngine;
using HelperLibrary;
using HelperLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelperLibrary
{
    // Builds class. Loads Builds.xml file and conatins all builds listed in the xml.
    public class XMLBuilds : XMLFile
    {
        public List<Build> builds { get; set; }

        public XMLBuilds(string path) : base(path)
        {
            populateBuilds();
        }

        public XMLBuilds() : base(BasicInfo.BuildsInfoLocation)
        {
            populateBuilds();
        }

        // Populate all builds inside Builds.xml.
        private void populateBuilds()
        {
            List<XElement> elements;
            try
            {
                elements = GetElements("Build");
            }
            catch (MissingElementException)
            {
                return;
            }
            finally
            {
                builds = new List<Build>();
            }

            foreach (XElement element in elements)
            {
                string name = element.Attribute("Name").Value;
                string path = element.Attribute("Path").Value;
                string description = element.Attribute("Description").Value;

                builds.Add(new Build(name, path, description));
            }
        }

        public void addBuild(Build build)
        {
            builds.Add(build);
        }

        public void Save()
        {
            XDocument buildsXml = new XDocument();
            XElement buildsElement = new XElement("Builds");

            foreach (Build build in builds)
            {
                XElement buildElement = new XElement("Build");
                buildElement.Add(new XAttribute("Name", build.name));
                buildElement.Add(new XAttribute("Path", build.path));
                buildElement.Add(new XAttribute("Description", build.description));

                buildsElement.Add(buildElement);
            }
            buildsXml.Add(buildsElement);

            buildsXml.Save(xmlPath);
        }

        public string getDescription(string buildName)
        {
            return builds.Find(b => b.name == buildName).description; 
        }

        public Build getBuild(string buildName)
        {
            return builds.Find(b => b.name == buildName);
        }

        public string getBuildPath(string buildName)
        {
            return builds.Find(b => b.name == buildName).path;
        }
    }
}