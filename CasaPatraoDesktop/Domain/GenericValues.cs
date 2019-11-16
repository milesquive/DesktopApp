using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPatraoDesktop.Domain
{

    class GenericValues
    {
        private static ArrayList _genericArrayList = null;

        public static System.Collections.ArrayList getSalesType()
        {
            _genericArrayList = new ArrayList();
            _genericArrayList.Add(new AddValue("Venda por unidade", "VU"));
            _genericArrayList.Add(new AddValue("Venda por caixa", "VC"));

            return _genericArrayList;
        }
    }
}
