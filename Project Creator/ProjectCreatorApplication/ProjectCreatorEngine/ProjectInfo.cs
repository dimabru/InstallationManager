using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreatorEngine
{
    public class ProjectInfo
    {
        // Project location needs to be extracted from an xml file. 
        // If file corrupted or missing, go to DefaultInfo.DefaultPath.
        public static string ProjectLocation = DefaultInfo.DefaultPath;
    }
}
