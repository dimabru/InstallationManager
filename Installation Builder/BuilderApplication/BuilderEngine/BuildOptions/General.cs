using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEngine.BuildOptions
{
    class General : BuildOption
    {
        public string buildPath { get; set; }

        public General() : base(name: "General")
        {
            buildPath = BasicInfo.ProjectLocation;
        }

        public General(string path) : base(name: "General")
        {
            buildPath = path;
        }

    }
}
