using HelperProject.HelperLibrary.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperProject.HelperLibrary.Plugins
{
    class RunExternalFile : Plugin
    {
        private string filePath;
        public RunExternalFile(string filePath): base(desc: "Execute an external file", Name: "Run External File")
        {
            this.filePath = filePath;
            populateInsertions();
        }

        public RunExternalFile(): base(desc: "Execute an external file", Name: "Run External File")
        {
            this.filePath = "";
            populateInsertions();
        }

        private void populateInsertions()
        {
            InsertionValueHelper insert = new InsertionValueHelper(InsertionValueHelper.InputType.BrowseFile, "Select a file you wish to run");
            insertions.Add(insert);
        }
    }
}
