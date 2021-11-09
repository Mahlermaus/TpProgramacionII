using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFacturadora.dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public double PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public double Costo { get; set; }

        public Articulo()
        {

        }

        public override string ToString()
        {
            return IdArticulo.ToString() + " - " + NombreArticulo;
        }
    }
}
