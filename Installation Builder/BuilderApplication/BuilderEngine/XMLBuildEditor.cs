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
    public class XMLBuildEditor : XMLFile
    {
        public List<string> build { get; }
        //public BuildEditor buildEditor { get; set; }

        public XMLBuildEditor(string path) : base(path)
        {
            build = new List<string>()
            {
                "Action Provider1"
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
            catch (MissingAttributeException)
            {
            }
            path += GetElementValue(element);
           // build = new BuildEditor(path);
        }
    }
}
