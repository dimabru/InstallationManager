using HelperProject.HelperLibrary;
using System.Xml.Linq;

namespace HelperProject.BaseView.BuildOptions
{
    public class General : BuildOption
    {
        public string buildPath { get; set; }

        public General() : base(name: "General")
        {
            buildPath = DefaultInfo.BuildsLocation;
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
