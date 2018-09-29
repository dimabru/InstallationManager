using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary.Plugins
{
    public class InsertionValueHelper
    {
        public string label { get; set; }
        public InputType input { get; set; }

        public enum InputType
        {
            TextBox, 
            ComboBox
        }

        public InsertionValueHelper(InputType box, string lbl)
        {
            input = box;
            label = lbl;
        }
    }
}
