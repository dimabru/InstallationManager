using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HelperLibrary.Exceptions
{
    public class BadElementException : XmlException
    {
        public BadElementException(string element, string filePath) : base($"The element '{element}' is not a valid option." +
            $"\nCheck the file: {filePath}")
        { }
    }
}
