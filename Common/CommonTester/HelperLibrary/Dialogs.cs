using HelperLibrary;
using HelperLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelperLibrary
{
    public class Dialogs
    {

        public static string OpenFolder()
        {
            FolderBrowserDialog folderBrowse = new FolderBrowserDialog()
            {
                ShowNewFolderButton = false
            };

            DialogResult result = folderBrowse.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Utils.IsDirectory(folderBrowse.SelectedPath))
                {
                    return folderBrowse.SelectedPath;
                }
                else
                {
                    NotAFolderException ex = new NotAFolderException(folderBrowse.SelectedPath);
                    throw ex;
                }
            }

            return "";
        }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
