using BaseView.HelperLibrary;
using HelperProject.HelperLibrary;
using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderView.Engine
{
    class PluginLoader
    {
        Plugin plugin;
        string exefile;
        string folderPath;
        public PluginLoader(string folderPath)
        {
            this.folderPath = folderPath;
            if (!Directory.Exists(folderPath))
            {
                throw new Exception($"Given path ${folderPath} is not a folder");
            }

            string setupPath = Path.Combine(folderPath, "setup.xml");
            if (!File.Exists(setupPath))
            {
                throw new Exception($"Missing setup.xml file");
            }

            if (!verifySetupFile(setupPath) || !verifyExeFile(folderPath))
            {
                return;
            }
            MessageBox.Show(exefile);
        }

        private bool verifySetupFile(string setupPath)
        {
            try
            {
                XMLPlugin setupFile = new XMLPlugin(setupPath);
                plugin = setupFile.plugin;
            }
            catch (Exception ex)
            {
                Dialogs.ErrorMessage(ex.Message);
                return false;
            }

            return true;
        }

        private bool verifyExeFile(string folderPath)
        {
            List<string> exefiles = Directory.GetFiles(folderPath).ToList().Where(f => f.EndsWith(".exe")).ToList();
            if (exefiles.Count != 1)
            {
                Dialogs.ErrorMessage($"The folder ${folderPath} must include exactly one exe file to run");
                return false;
            }
            exefile = exefiles[0];
            return true;
        }

        public void save()
        {
            string pluginsFolder = DefaultInfo.ImportedPluginsLocation;
            if (!Directory.Exists(pluginsFolder))
            {
                Directory.CreateDirectory(pluginsFolder);
            }

            string specificPluginFolder = Path.Combine(pluginsFolder, plugin.name);
            if (Directory.Exists(specificPluginFolder))
            {
                Utils.DeleteDirWithContent(specificPluginFolder);
            }
            Directory.CreateDirectory(specificPluginFolder);

            Utils.CopyDirectoryContent(folderPath, specificPluginFolder);
        }
    }
}
