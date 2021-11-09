using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend
{
    public class FormaPago
    {
        public int IdFormasPago { get; set; }
        public string NombreFormaPago { get; set; }

        public FormaPago()
        {

        }

        public override string ToString()
        {
            return IdFormasPago.ToString() + " - " + NombreFormaPago;
        }
    }
}
