using BuilderEngine.BuildOptions;
using HelperLibrary;
using HelperLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BuilderEngine
{
    // Class consists of static methods, created to retreive basic information in the Builder Application
    public class BasicInfo
    {
        // Location of the 'Builds' directory. Where all the builds will reside.
        public static string BuildsLocation = $"{DefaultInfo.ProjectLocation}\\Builds";
        // Location of the info file containing all information about the current builds.
        public static string BuildsInfoLocation = $"{BuildsLocation}\\Builds.xml";

        // Creates default directory in the project's location
        public static void CreateDefaultDirectory()
        {
            Directory.CreateDirectory(DefaultInfo.ProjectLocation);
        }

        // Set default information. Use in case no information available
        public static void CreateDefaultInformation()
        {
            CreateDefaultDirectory();
            createDefaultConfig();
        }

        // Create default config.xml file. Use in case file doesn't exist or corrupted
        private static void createDefaultConfig()
        {
            XDocument defaultValues = XDocument.Load(DefaultInfo.BuildsDefaultConfigFileLocation);
            defaultValues.Save(DefaultInfo.BuildsConfigLocation);
        }

        // Create default Builds.xml file. Use in case file doesn't exist or corrupted 
        private static void createDefaultBuildsFile()
        {
            XDocument emptyBuilds = new XDocument();
            XElement builds = new XElement("Builds");
            emptyBuilds.Add(builds);

            Directory.CreateDirectory(BuildsLocation);
            emptyBuilds.Save(BuildsInfoLocation);
        }

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

        // Load all builds from the Builds.xml file to use in the BMainForm builds list.
        public static XMLBuilds LoadBuilds()
        {
            XMLBuilds builds;
            try
            {
                builds = new XMLBuilds(BuildsInfoLocation);
            }
            catch (Exception ex) when (ex is DirectoryNotFoundException || ex is XmlException || ex is FileNotFoundException)
            {
                createDefaultBuildsFile();
                builds = new XMLBuilds(BuildsInfoLocation);
            }
            return builds;
        }
    }
}
