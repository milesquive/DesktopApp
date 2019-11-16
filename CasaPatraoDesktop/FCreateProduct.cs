using CasaPatraoDesktop.Domain;
using CasaPatraoDesktop.Services;
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

        private CasaPatraoServiceConsumer serviceConsumer = null;
        public FCreateProduct()
        {
            InitializeComponent();
            this.SetupCombobox();
            this.setupGridProducts();

        }

        private void SetupCombobox()
        {
            CMBSalesType.DataSource = GenericValues.getSalesType();
          //  CMBSalesType.DisplayMember = "_Display";
          //  CMBSalesType.ValueMember = "_Value";
        }

        private void setupGridProducts()
        {
            this.serviceConsumer = new CasaPatraoServiceConsumer();
            DTProductListView.DataSource = serviceConsumer.getProducts().records;
            
        }
        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSubmit_Click(object sender, EventArgs e)
        {
            this.serviceConsumer.createProduct();
        }
    }
}
