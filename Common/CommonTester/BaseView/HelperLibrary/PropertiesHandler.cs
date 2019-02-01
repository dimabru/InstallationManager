using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace HelperProject.HelperLibrary
{
    public class PropertiesHandler
    {

        // Load all options from the config.xml file to use in the 'Properties' window.
        public static XMLProperties LoadOptions()
        {
            XMLProperties properties;
            try
            {
                properties = new XMLProperties(DefaultInfo.BuildsConfigLocation);
            }
            catch (Exception ex) when (ex is DirectoryNotFoundException || ex is XmlException || ex is FileNotFoundException)
            {
                CreateDefaultInformation();
                properties = new XMLProperties(DefaultInfo.BuildsConfigLocation);
            }
            return properties;
        }

        // Set default information. Use in case no information available
        public static void CreateDefaultInformation()
        {
            CreateDefaultDirectory();
            createDefaultConfig();
        }

        // Creates default directory in the project's location
        public static void CreateDefaultDirectory()
        {
            Directory.CreateDirectory(DefaultInfo.ProjectLocation);
        }

        // Create default config.xml file. Use in case file doesn't exist or corrupted
        private static void createDefaultConfig()
        {
            XDocument defaultValues = XDocument.Load(DefaultInfo.BuildsDefaultConfigFileLocation);
            defaultValues.Save(DefaultInfo.BuildsConfigLocation);
        }
    }
}
