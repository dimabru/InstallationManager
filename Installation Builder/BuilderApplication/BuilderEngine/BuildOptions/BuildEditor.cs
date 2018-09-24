using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderEngine.BuildOptions
{
    class BuildEditor : BuildOption
    {
        public string buildPath { get; set; }

        public BuildEditor() : base(name: "Action Provider1")
        {
            buildPath = BasicInfo.BuildsLocation;
        }

        public BuildEditor(string path) : base(name: "Action Provider1")
        {
            buildPath = path;
        }
        public override XElement Save()
        {
            throw new NotImplementedException();
        }
    }
}
