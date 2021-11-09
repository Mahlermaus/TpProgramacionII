using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomCliente { get; set; }
        public string ApeCliente { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public Barrio Barrio { get; set; }

        public Cliente()
        {
            Barrio = new Barrio();
            NomCliente = "";
            ApeCliente = "";
            Calle = "";
            Altura = "";
            Email = "";
            Tel = "";
            IdCliente=0;

        }
        public override string ToString()
        {
            return NomCliente + " " + ApeCliente;
                 
        }
              
    }
}
