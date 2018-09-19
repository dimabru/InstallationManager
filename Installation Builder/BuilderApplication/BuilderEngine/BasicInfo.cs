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
    public class BasicInfo
    {
        // Project location needs to be extracted from an xml file.
        // If file corrupted or missing, go to DefaultInfo.DefaultPath.
        public static string ProjectLocation = DefaultInfo.DefaultPath;
        public static string BuildsLocation = $"{ProjectLocation}\\Builds";
        public static string BuildsInfoLocation = $"{BuildsLocation}\\Builds.xml";
        public static string BuildsConfigLocation = $".\\Config.xml";
        public static string BuildsDefaultConfigFileLocation = $".\\OutFiles\\BuilderDefaultConfig.xml";

        public static void CreateDefaultDirectory()
        {
            Directory.CreateDirectory(ProjectLocation);
        }

        public static void CreateDefaultInformation()
        {
            CreateDefaultDirectory();
            createDefaultConfig();
        }

        private static void createDefaultConfig()
        {
            XDocument defaultValues = XDocument.Load(BuildsDefaultConfigFileLocation);
            defaultValues.Save(BuildsConfigLocation);
        }

        private static void createDefaultBuildsFile()
        {
            XDocument emptyBuilds = new XDocument();
            XElement builds = new XElement("Builds");
            emptyBuilds.Add(builds);

            emptyBuilds.Save(BuildsInfoLocation);
        }
        public static XMLProperties LoadOptions()
        {
            XMLProperties properties;
            try
            {
                properties = new XMLProperties(BuildsConfigLocation);
            }
            catch (Exception ex) when (ex is DirectoryNotFoundException || ex is XmlException || ex is FileNotFoundException)
            {
                CreateDefaultInformation();
                properties = new XMLProperties(BuildsConfigLocation);
            }
            return properties;
        }

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
                builds = new XMLBuilds(BuildsLocation);
            }
            return builds;
        }
    }
}
