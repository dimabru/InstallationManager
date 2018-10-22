using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFilesPlugin
{
    class Program
    {
        // Create 3 log files.
        // Warning.log
        // Error.log
        // Notify.log
        static void Main(string[] args)
        {
            args = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (args.ToList().Count == 0)
            {
                Logger.LogError("No files to delete\n");
                return;
            }
            List<string> notRemovedFiles = new List<string>();
            foreach (string arg in args)
            {
                try
                {
                    FileAttributes attr = File.GetAttributes(arg);
                    if (!attr.HasFlag(FileAttributes.Directory))
                    {
                        Logger.LogNotify($"Deleting file {arg}");
                        try
                        {
                            File.Delete(arg);
                        }
                        //should be our own created exeption(for example - administrator permissions)
                        catch (IOException ex)
                        {
                            notRemovedFiles.Add(arg);
                            Logger.LogError($"Unable to delete file {arg} because {ex}");
                        }
                    }
                }
                catch (FileNotFoundException Fex)
                {
                    Logger.LogError($"Unable to delete file {arg} because {Fex}");
                }
            }
            // If not all files were removed
            if (notRemovedFiles.Any())
            {
                foreach (string notRmv in notRemovedFiles)
                {
                    Logger.LogWarning($"The following were not removed {notRmv}");
                }
            }
            // else
            else Logger.LogNotify(" - Process completed \n");
        }
    }
}
