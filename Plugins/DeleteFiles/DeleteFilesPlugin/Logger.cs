using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFilesPlugin
{
    class Logger
    {
        public static void LogError(string msg)
        {
            File.AppendAllText(".\\Error.log", msg);
        }

        public static void LogWarning(string msg)
        {
            File.AppendAllText(".\\Warning.log", msg);

        }

        public static void LogNotify(string msg)
        {
            File.AppendAllText(".\\Notify.log", msg);

        }
    }
}
