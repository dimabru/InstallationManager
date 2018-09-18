using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HelperLibrary
{
    public class XMLFile
    {
        protected string xmlPath { get; }
        protected XDocument doc { get; }

        public XMLFile(string path)
        {
            xmlPath = path;
            doc = XDocument.Load(path);
        }

        protected string GetAttributeValue(string element, string attr)
        {
            return doc.Root.Element(element).Attribute(attr).Value;
        }
    }
}
