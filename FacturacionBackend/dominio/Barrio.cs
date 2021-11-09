using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.dominio
{
    public class Barrio
    {
        public int IdBarrio { get; set; }
        public string NombreBarrio { get; set; }

        public Barrio()
        {

        }

        public override string ToString()
        {
            return IdBarrio.ToString() + " - " + NombreBarrio;
        }

    }
}
