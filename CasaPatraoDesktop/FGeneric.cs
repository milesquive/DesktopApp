using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaPatraoDesktop
{
    public partial class FGeneric : Form
    {
        public FGeneric()
        {
            InitializeComponent();
        }

        private void PExitButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip exitTollTip = new ToolTip();
           // exitTollTip.te
        }

        private void PExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
