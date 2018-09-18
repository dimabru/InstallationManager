using HelperLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (!HasElement(element))
            {
                throw new MissingElementException(element, xmlPath);
            }
            if (!HasAttribute(element, attr))
            {
                throw new MissingAttributeException(attr, element, xmlPath);
            }
            return doc.Root.Element(element).Attribute(attr).Value;
        }

        protected bool HasAttribute(string element, string attr)
        {
            if (HasElement(element))
            {
                IEnumerable<XElement> found = from elem in doc.Descendants(element) select elem;

                foreach (XElement elem in found)
                {
                    if (elem.Attributes(attr).Any())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected bool HasElement(string element)
        {
            IEnumerable<XElement> found = from elem in doc.Descendants(element) select elem;
            return found.Any();
        }

        protected string GetElementValue(string element)
        {
            if (!HasElement(element))
            {
                throw new MissingElementException(element, xmlPath);
            }
            return doc.Descendants(element).ToList()[0].Value;
        }
    }
}
