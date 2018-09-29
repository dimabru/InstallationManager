using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary.Plugins
{
    public class Plugin
    {
        public string name { get; }
        public string description { get; }
        protected List<InsertionValueHelper> insertions { get; set; }

        public Plugin(string desc, string Name)
        {
            name = Name;
            description = desc;
        }

        public static List<string> PluginList = new List<string>()
        {
            "RunCmd"
        };
    }

}
