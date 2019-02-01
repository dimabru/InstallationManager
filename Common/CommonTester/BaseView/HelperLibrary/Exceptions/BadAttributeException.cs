using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HelperLibrary.Exceptions
{
    class BadAttributeException : XmlException
    {
        public BadAttributeException(string attribute, string filePath) : base($"The following attribute: {attribute} is not a valid option." +
            $"\nCheck the file: {filePath}")
        { }
    }
}
