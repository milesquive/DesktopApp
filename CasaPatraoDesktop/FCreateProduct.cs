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
    public partial class FCreateProduct : Form
    {
        public FCreateProduct()
        {
            InitializeComponent();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
