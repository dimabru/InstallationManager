using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary.Plugins
{
    class Plugin
    {
        public string name { get; }
        public string description { get; }

        public Plugin(string desc)
        {
            name = this.GetType().Name;
            description = desc;
        }
    }
}
