using BaseView.HelperLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HelperProject.HelperLibrary.Plugins
{
    public class Plugin
    {
        public string name { get; }
        public string description { get; }
        public List<InsertionValueHelper> insertions { get; set; }
        public Dictionary<InsertionValueHelper, string> valueDict { get; set; }
        public bool enabled { get; set; }
        public bool importedPlugin = false;

        public Plugin(string desc, string Name)
        {
            name = Name;
            description = desc;
            insertions = new List<InsertionValueHelper>();
            valueDict = new Dictionary<InsertionValueHelper, string>();
            enabled = true;
        }

        public Plugin(string Name)
        {
            name = Name;
            description = "";
            insertions = new List<InsertionValueHelper>();
            valueDict = new Dictionary<InsertionValueHelper, string>();
            enabled = true;
        }

        public void updateInsertion(string label, string value)
        {
            foreach(InsertionValueHelper insert in insertions)
            {
                if (insert.label == label)
                {
                    valueDict[insert] = value;
                    return;
                }
            }
            throw new InvalidOperationException($"Unable to locate value with label {label} in the list");
        }

        public static List<Plugin> PluginList = new List<Plugin>();

        public static void LoadPlugins()
        {
            PluginList.Clear();
            Type[] types = Utils.GetTypesInNamespace("Plugin", "HelperProject.HelperLibrary.Plugins");

            foreach (Type type in types)
            {
                if (Utils.HasInheritedClass(type.ToString(), "Plugin"))
                {
                    Plugin plugin = (Plugin)Activator.CreateInstance(type);
                    PluginList.Add(plugin);
                }
            }

            if (Directory.Exists(DefaultInfo.ImportedPluginsLocation))
            {
                List<string> subDirs = new List<string>(Directory.GetDirectories(DefaultInfo.ImportedPluginsLocation));
                foreach (string dir in subDirs)
                {
                    try
                    {
                        string xmlPath = Path.Combine(dir, "setup.xml");
                        XMLPlugin plugin = new XMLPlugin(xmlPath, imported: true);
                        PluginList.Add(plugin.plugin);
                    }
                    catch
                    {
                        continue;
                    }
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

        public List<string> getValues()
        {
            List<string> values = new List<string>();
            
            foreach (string value in this.valueDict.Values)
            {
                values.Add(value);
            }

            return values;
        }

        public XElement Save(string buildPath)
        {
            XElement pluginElement = new XElement("Plugin");
            pluginElement.Add(new XAttribute("Name", name));
            pluginElement.Add(new XAttribute("Description", description));
            pluginElement.Add(new XAttribute("Imported", this.importedPlugin));

            foreach (InsertionValueHelper insert in insertions)
            {
                XElement inputValue = new XElement("Input");
                inputValue.Add(new XAttribute("Type", insert.input));
                inputValue.Add(new XAttribute("Label", insert.label));
                inputValue.Add(new XAttribute("Value", valueDict[insert]));

                if (insert.input == InsertionValueHelper.InputType.BrowseFile)
                {
                    string filePath = valueDict[insert];
                    string targetPath = Path.Combine(buildPath, Path.GetFileName(filePath));
                    File.Copy(filePath, targetPath);
                }

                pluginElement.Add(inputValue);
            }

            return pluginElement;
        }
    }

}
