using System;
using System.IO;
using System.Xml;

namespace HelperProject.HelperLibrary
{
    public class DefaultInfo
    {
        public static string MyDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string FolderName = "Installation Manager";
        public static string DefaultPath = $"{MyDocumentsPath}\\{FolderName}";
        public static string BuildsConfigLocation = $".\\Config.xml";
        public static string BuildsDefaultConfigFileLocation = $".\\HelperLibrary\\OutFiles\\BuilderDefaultConfig.xml";
        public static string BuildDetailsFileName = "BuildDetails.xml";
        public static string ProjectLocation
        {
            get
            {
                try
                {
                    XMLProperties prop = new XMLProperties(BuildsConfigLocation);
                    return prop.general.buildPath;
                }
                catch(Exception ex) when (ex is XmlException || ex is FileNotFoundException)
                {
                    return DefaultPath;
                }
            }
        }

        // Location of the 'Builds' directory. Where all the builds will reside.
        public static string BuildsLocation = $"{DefaultInfo.ProjectLocation}\\Builds";
        // Location of the info file containing all information about the current builds.
        public static string BuildsInfoLocation = $"{BuildsLocation}\\Builds.xml";

    }
}
