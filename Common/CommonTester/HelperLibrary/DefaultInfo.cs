using BuilderEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace HelperLibrary
{
    public class DefaultInfo
    {
        public static string MyDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string FolderName = "Installation Manager";
        public static string DefaultPath = $"{MyDocumentsPath}\\{FolderName}";
        public static string BuildsConfigLocation = $".\\Config.xml";
        public static string BuildsDefaultConfigFileLocation = $".\\OutFiles\\BuilderDefaultConfig.xml";
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
    }
}
