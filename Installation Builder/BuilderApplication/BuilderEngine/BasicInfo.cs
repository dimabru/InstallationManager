using HelperLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            XDocument defaultValues = XMLProperties.CreateDefaultValues();
            defaultValues.Save(BuildsConfigLocation);
        }
    }
}
