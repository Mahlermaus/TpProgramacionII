using FacturacionBackend.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.accesoDatos
{
    public interface IFacturaDao
    {
        //***Load General ***
        int IdProximaFactura();
        DataTable ConsultarArticulos();
        DataTable ConsultarClientes();
        DataTable ConsultarFormaPago();
        bool CrearFactura(Factura oFactura);


        bool GuardarArticulo(Articulo oArticulo);

        bool EditarArticulo(Articulo oArticulo);
        bool EliminarArticulo(int idArticulo);



        bool GuardarCliente(Cliente oCliente);
        bool EditarCliente(Cliente oCliente);
        List<Barrio> GetBarrios();
        void EliminarCliente(int idCliente);


       
       







    }
}
