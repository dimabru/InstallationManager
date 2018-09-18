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
        public static string BuildsConfigLocation = $"{BuildsLocation}\\Config.xml";
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
            Directory.CreateDirectory(BuildsLocation);

            XDocument defaultValues = XDocument.Load(BuildsDefaultConfigFileLocation);
            defaultValues.Save(BuildsConfigLocation);
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
    }
}
