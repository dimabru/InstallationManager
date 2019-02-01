using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HelperProject.BaseView
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
