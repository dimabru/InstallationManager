using HelperProject.BaseView.BuildOptions;
using HelperProject.HelperLibrary.Exceptions;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HelperProject.HelperLibrary
{
    // Properties xml file. Loads data from config.xml file. 
    public class XMLProperties : XMLFile
    {
        public List<string> options { get; }

        public General general { get; set; }

        public XMLProperties(string path) : base(path)
        {
            options = new List<string>()
            {
                "General"
            };

            populateGeneral();
        }

        // Populates the General option in properties. 
        private void populateGeneral()
        {
            string path = "";
            string element = "BuildPath";
            try
            {
                path = GetAttributeValue(element, "Source");
                if (path == "MyDocuments")
                {
                    path = DefaultInfo.MyDocumentsPath;
                }
            }
            catch (MissingAttributeException)
            {
            }
            path += GetElementValue(element);
            general = new General(path);
        }

        // Create an XElement item with all data
        public void Save()
        {
            XDocument newDoc = new XDocument();
            XElement generalElement = general.Save();
            newDoc.Add(generalElement);

            newDoc.Save(DefaultInfo.BuildsConfigLocation);
        }
    }
}
