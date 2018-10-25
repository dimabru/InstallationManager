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
    public class PropertiesHandler
    {

        // Create default Builds.xml file. Use in case file doesn't exist or corrupted 
        private static void createDefaultBuildsFile()
        {
            XDocument emptyBuilds = new XDocument();
            XElement builds = new XElement("Builds");
            emptyBuilds.Add(builds);

            Directory.CreateDirectory(DefaultInfo.BuildsLocation);
            emptyBuilds.Save(DefaultInfo.BuildsInfoLocation);
        }

        // Load all builds from the Builds.xml file to use in the BMainForm builds list.
        public static XMLBuilds LoadBuilds()
        {
            XMLBuilds builds;
            try
            {
                builds = new XMLBuilds(DefaultInfo.BuildsInfoLocation);
            }
            catch (Exception ex) when (ex is DirectoryNotFoundException || ex is XmlException || ex is FileNotFoundException)
            {
                createDefaultBuildsFile();
                builds = new XMLBuilds(DefaultInfo.BuildsInfoLocation);
            }
            return builds;
        }
    }
}
