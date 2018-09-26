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

                XElement descriptionElem = element.Element("Description");
                string description = descriptionElem.Value;

                builds.Add(new Build(name, path, description));
            }
        }
    }
}
