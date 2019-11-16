using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPatraoDesktop.Domain
{
    class ProductDomain
    {
        public List<Record> records { get; set; }

        public static explicit operator ProductDomain(List<ProductDomain> v)
        {
            throw new NotImplementedException();
        }
    }
}
