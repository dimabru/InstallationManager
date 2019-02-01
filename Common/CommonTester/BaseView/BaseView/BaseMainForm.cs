using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelperProject.BaseView
{
    public partial class BaseMainForm : Form
    {
        public BaseMainForm()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButtonLicense_Click(object sender, EventArgs e)
        {
            new License().Show();
        }
    }
}
