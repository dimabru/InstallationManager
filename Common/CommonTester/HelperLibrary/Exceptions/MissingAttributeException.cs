using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HelperLibrary.Exceptions
{
    public class MissingAttributeException : XmlException
    {
        public MissingAttributeException(string attribute, string element, string path) : 
            base ($"There's a missing attribue '{attribute}' in element '{element}'\nIn file: {path}")
        {

        }
    }
}
