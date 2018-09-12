using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelperLibrary
{
    public class Utils
    {

        public static bool IsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);

            return attr.HasFlag(FileAttributes.Directory);
        }
    }
}
