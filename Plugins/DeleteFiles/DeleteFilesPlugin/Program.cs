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
            if (args.ToList().Count == 0)
            {
                Logger.LogError("No files to delete");
                return;
            }
            List<string> notRemovedFiles = new List<string>();
            foreach (string arg in args)
            {
                FileAttributes attr = File.GetAttributes(arg);
                if (!attr.HasFlag(FileAttributes.Directory))
                {
                    Logger.LogNotify($"Deleting file {arg}");
                    try
                    {
                        File.Delete(arg);
                    }
                    catch ()
                    {
                        notRemovedFiles.Add(arg);
                        Logger.LogError($"Unable to delete file {arg} because...");
                    }
                    catch ()
                    {
                        Logger.LogError($"Unable to delete file {arg} because...");
                    }
                }

            }
            // If not all files were removed
            if (notRemovedFiles.Any())
            {
                Logger.LogWarning("The following were not removed");
            }
            // else
            Logger.LogNotify("Process completed ");
        }
    }
}
