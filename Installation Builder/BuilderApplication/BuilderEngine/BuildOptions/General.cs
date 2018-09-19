using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderEngine.BuildOptions
{
    public class General : BuildOption
    {
        public string buildPath { get; set; }

        public General() : base(name: "General")
        {
            buildPath = BasicInfo.BuildsLocation;
        }

        public General(string path) : base(name: "General")
        {
            buildPath = path;
        }

        public override XElement Save()
        {
            XElement generalElement = new XElement(optionName);

            XElement buildPathElement = new XElement("BuildPath");
            buildPathElement.Value = buildPath;

            generalElement.Add(buildPathElement);

            return generalElement;
        }
    }
}
