using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPatraoDesktop.Domain
{
    class Record
    {
        public string productId { get; set; }
        public string productBarcode { get; set; }
        public string productDesc { get; set; }
        public string prodQuant { get; set; }
        public string productPurchaseprice { get; set; }
        public string productSaleprice { get; set; }
        public string productLastquant { get; set; }
        public string productPreateuser { get; set; }
    }
}
