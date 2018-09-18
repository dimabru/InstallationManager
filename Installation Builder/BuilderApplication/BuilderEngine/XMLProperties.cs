using BuilderEngine.BuildOptions;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderEngine
{
    public class XMLProperties : XMLFile
    {
        public List<BuildOption> options { get; }

        public XMLProperties(string path) : base(path)
        {
            options.Add(new General());
        }

        public static XDocument CreateDefaultValues()
        {
            
        }
    }
}
