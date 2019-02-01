using System;
using System.Collections.Generic;
using System.Text;

namespace HelperProject.HelperLibrary.Exceptions
{
    public class NotAFolderException : Exception
    {
        public NotAFolderException(string path) : base($"The following path: '{path}' is not of a folder")
        {

        }
    }
}
