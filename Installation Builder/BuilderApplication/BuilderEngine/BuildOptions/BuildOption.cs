using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEngine.BuildOptions
{
    public class BuildOption
    {
        public string optionName { get; set; }

        public BuildOption(string name)
        {
            optionName = name;
        }
    }
}
