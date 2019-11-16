using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPatraoDesktop.Domain
{
    class AddValue
    {
        /// <summary>
        /// Classe Generica para adicao de valores
        /// 
        /// </summary>
        private string _Display { get; set; }
        private string _Value { get; set; }

        public AddValue(string display, string value)
        {
            this._Display = display;
            this._Value = value;
        }
    }
}
