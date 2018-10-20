using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFilePlugin
{
    class DeleteFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path: ");
            string path = Console.ReadLine();
            Console.WriteLine("{0}", Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            Console.WriteLine("{0}", File.Exists(path));
            string destFile = System.IO.Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), path);
            try
            {
                File.Delete(destFile);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            Console.WriteLine("{0} was deleted!",path);
            Console.ReadKey();
        }
    }
}