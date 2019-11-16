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

        private void PCreateProduct_Click(object sender, EventArgs e)
        {
            FCreateProduct createProduct = new FCreateProduct();
            this.addFormOnContainer(createProduct);
               }

        private void addFormOnContainer(Form form)
        {
            if (form == null)
                form = new Form();

            form.FormBorderStyle = FormBorderStyle.None;
            PGenericContainer.Controls.Clear();
                      form.TopLevel = false;
            form.Dock = DockStyle.Top;
            PGenericContainer.Controls.Add(form);
            form.Show();
        }
    }
}
