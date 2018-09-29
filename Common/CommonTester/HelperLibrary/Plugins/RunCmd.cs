using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary.Plugins
{
    class RunCmd : Plugin
    {
        private string command { get; }

        public RunCmd(string cmd) : base(desc: "Execute a cmd.exe command", Name:"Run Command")
        {
            command = cmd;
            populateInsertions();
        }

        private void populateInsertions()
        {
            InsertionValueHelper insert = new InsertionValueHelper(InsertionValueHelper.InputType.TextBox, "Enter a command to run");
        }
    }
}
