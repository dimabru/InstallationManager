using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HelperProject.HelperLibrary.Exceptions
{
    public class MissingElementException : XmlException
    {
        public MissingElementException(string element, string path) : 
            base($"There's a missing element '{element}'\nIn file: {path}")
        {

        }
    }
}
