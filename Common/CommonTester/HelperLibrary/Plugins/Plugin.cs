using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HelperLibrary.Plugins
{
    public class Plugin
    {
        public string name { get; }
        public string description { get; }
        public List<InsertionValueHelper> insertions { get; set; }

        public Plugin(string desc, string Name)
        {
            name = Name;
            description = desc;
            insertions = new List<InsertionValueHelper>();
        }

        public void updateInsertion(string label, string value)
        {
            
        }

        public static List<Plugin> PluginList = new List<Plugin>();

        public static void LoadPlugins()
        {
            PluginList.Clear();
            Type[] types = Utils.GetTypesInNamespace("Plugin", "HelperLibrary.Plugins");

            foreach (Type type in types)
            {
                if (Utils.HasInheritedClass(type.ToString(), "Plugin"))
                {
                    Plugin plugin = (Plugin)Activator.CreateInstance(type);
                    PluginList.Add(plugin);
                }
            }
        }

        public static Plugin LocatePlugin(string name)
        {
            foreach (Plugin plugin in PluginList)
            {
                if (plugin.name == name)
                {
                    return plugin;
                }
            }
            return null;
        }
    }

}
