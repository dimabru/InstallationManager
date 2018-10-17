using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary.Plugins
{
    public class RunCmd : Plugin
    {
        public string command { get; private set; }

        public RunCmd(string cmd) : base(desc: "Execute a cmd.exe command", Name: "Run Command")
        {
            command = cmd;
            populateInsertions();
        }

        public RunCmd() : base(desc: "Execute a cmd.exe command", Name: "Run Command")
        {
            command = "";
            populateInsertions();
        }

        private void populateInsertions()
        {
            InsertionValueHelper insert = new InsertionValueHelper(InsertionValueHelper.InputType.TextBox, "Enter a command to run");

            insertions.Add(insert);
        }

    }
}