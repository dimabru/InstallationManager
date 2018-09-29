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

namespace HelperLibrary
{
    public class XMLBuildEditor : XMLFile
    {
        public Build build { get; set; }

        public XMLBuildEditor(string path) : base(path)
        {

        }
    }
}
