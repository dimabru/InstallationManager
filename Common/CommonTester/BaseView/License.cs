using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseView
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();

            this.richTextBoxLicense.Text = File.ReadAllText(@".\LICENSE.md");

            using (Graphics g = CreateGraphics())
            {
                this.Height = (int)g.MeasureString(richTextBoxLicense.Text,
                    richTextBoxLicense.Font, richTextBoxLicense.Width).Height;
            }
        }
    }
}
