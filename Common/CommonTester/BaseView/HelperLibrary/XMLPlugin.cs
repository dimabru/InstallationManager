using HelperProject.HelperLibrary;
using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaseView.HelperLibrary
{
    public class XMLPlugin : XMLFile
    {
        public Plugin plugin;
        public XMLPlugin(string path, bool imported = false) : base(path)
        {
            populatPlugin(imported);
        }

        private void populatPlugin(bool imported)
        {
            List<XElement> elements = GetElements("Plugin");
            if (elements.Count != 1)
            {
                throw new Exception("setup.xml must include exactly one Plugin element");
            }
            XElement pluginElement = elements[0];
            string pluginName = pluginElement.Attribute("name").Value;
            string pluginDescription = pluginElement.Attribute("description").Value;

            plugin = new Plugin(pluginDescription, pluginName);
            plugin.importedPlugin = imported;
            List<XElement> inputValues = pluginElement.Descendants("InsertionValue").ToList();
            foreach (XElement inputValue in inputValues)
            {
                string label = inputValue.Attribute("Label").Value;
                InsertionValueHelper.InputType inputType = (InsertionValueHelper.InputType)Enum.Parse(typeof(InsertionValueHelper.InputType), inputValue.Attribute("InputType").Value);
                InsertionValueHelper insertionValue = new InsertionValueHelper(inputType, label);
                plugin.insertions.Add(insertionValue);
            }
        }

    }
}
