using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelperLibrary.BuildOptions
{
    public abstract class BuildOption
    {
        public string optionName { get; set; }
        public BuildOption(string name)
        {
            optionName = name;
        }

        public abstract XElement Save();
    }
}
