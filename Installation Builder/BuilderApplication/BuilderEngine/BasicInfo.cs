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

        public static string BuildsLocation = $"{DefaultInfo.ProjectLocation}\\Builds";
        public static string BuildsInfoLocation = $"{BuildsLocation}\\Builds.xml";


        public static void CreateDefaultDirectory()
        {
            Directory.CreateDirectory(DefaultInfo.ProjectLocation);
        }

        public static void CreateDefaultInformation()
        {
            CreateDefaultDirectory();
            createDefaultConfig();
        }

        private static void createDefaultConfig()
        {
            XDocument defaultValues = XDocument.Load(DefaultInfo.BuildsDefaultConfigFileLocation);
            defaultValues.Save(DefaultInfo.BuildsConfigLocation);
        }

        private static void createDefaultBuildsFile()
        {
            XDocument emptyBuilds = new XDocument();
            XElement builds = new XElement("Builds");
            emptyBuilds.Add(builds);

            Directory.CreateDirectory(BuildsLocation);
            emptyBuilds.Save(BuildsInfoLocation);
        }
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
