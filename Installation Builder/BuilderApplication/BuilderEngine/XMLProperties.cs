using BuilderEngine.BuildOptions;
using HelperLibrary;
using HelperLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BuilderEngine
{
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
            catch(MissingAttributeException)
            {
            }
            catch (XmlException ex)
            {
                Dialogs.ErrorMessage(ex.Message);
                return;
            }
            path += GetElementValue(element);
            general = new General(path);
        }
    }
}
