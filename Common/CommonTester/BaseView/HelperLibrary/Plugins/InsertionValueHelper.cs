using System;
using System.Collections.Generic;
using System.Text;

namespace HelperProject.HelperLibrary.Plugins
{
    public class InsertionValueHelper
    {
        public string label { get; set; }
        public InputType input { get; set; }

        public enum InputType
        {
            TextBox, 
            ComboBox,
            BrowseFile
        }

        public InsertionValueHelper(InputType box, string lbl)
        {
            input = box;
            label = lbl;
        }
    }
}
