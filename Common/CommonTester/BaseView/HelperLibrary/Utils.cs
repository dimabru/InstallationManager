using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HelperProject.HelperLibrary
{
    public class Utils
    {

        public static bool IsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);

            return attr.HasFlag(FileAttributes.Directory);
        }

        public static Type[] GetTypesInNamespace(string assemblyClassName, string nameSpace)
        {
            Assembly assembly = GetAssemblyNameOfClass(assemblyClassName);

            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();
        }

        public static Assembly GetAssemblyNameOfClass(string className)
        {
            Type objectType = GetTypeByClassName("Plugin");

            return objectType.Assembly;
        }

        public static Type GetTypeByClassName(string className)
        {
            return (from asm in AppDomain.CurrentDomain.GetAssemblies()
                    from type in asm.GetTypes()
                    where type.IsClass && type.Name == className
                    select type).Single();
        }

        public static bool HasInheritedClass(string baseClass, string inheritCheck)
        {
            Type t = Type.GetType(baseClass);
            if (t.BaseType.Name == inheritCheck)
            {
                return true;
            }

            return false;
        }

        public static void CopyDirectoryContent(string sourcePath, string destinationPath)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourcePath);
            DirectoryInfo diTarget = new DirectoryInfo(destinationPath);

            void CopyAll(DirectoryInfo source, DirectoryInfo target) {
                diTarget.Create();

                foreach (FileInfo fi in diSource.GetFiles())
                {
                    fi.CopyTo(Path.Combine(diTarget.FullName, fi.Name), true);
                }

                foreach (DirectoryInfo di in source.GetDirectories())
                {
                    DirectoryInfo nextTarget = target.CreateSubdirectory(di.Name);
                    CopyAll(di, nextTarget);
                }
            }

            CopyAll(diSource, diTarget);
        }
    }
}
