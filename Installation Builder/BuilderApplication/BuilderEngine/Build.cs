﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderEngine
{
    public class Build
    {
        public string name { get; }
        public string path { get; }
        public string description { get; set; }

        public Build(string buildName, string buildPath, string desc)
        {
            name = buildName;
            path = buildPath;
            description = desc;
        }
    }
}
