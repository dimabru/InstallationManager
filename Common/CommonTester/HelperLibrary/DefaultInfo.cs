using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary
{
    public class DefaultInfo
    {
        public static string MyDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string FolderName = "Installation Manager";
        public static string DefaultPath = $"{MyDocumentsPath}\\{FolderName}";
    }
}
