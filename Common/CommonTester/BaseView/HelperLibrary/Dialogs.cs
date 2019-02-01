using HelperProject.HelperLibrary.Exceptions;
using System.Windows.Forms;

namespace HelperProject.HelperLibrary
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

        public static void NoticeMessage(string message)
        {
            MessageBox.Show(message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
