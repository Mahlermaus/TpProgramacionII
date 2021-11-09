using FacturacionBackend.dominio;
using FacturacionBackend.accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.servicio.implementaciones
{
      public class FacturaService : IFacturaService
    {
        private IFacturaDao Dao;

        public FacturaService(AbstractDaoFactory factory)
        {
            Dao = factory.CrearFactura();
        }
        public int IdProximaFactura()
        {
           return Dao.IdProximaFactura();
        }
        public DataTable CargarClientes()
        {
            return Dao.ConsultarClientes();
        }
        public DataTable CargarArticulos()
        {
            return Dao.ConsultarArticulos();
        }
        public DataTable CargarFormasPago()
        {
            return Dao.ConsultarFormaPago();
        }
        public bool CrearFactura(Factura oFactura)
        {
            return Dao.CrearFactura(oFactura);
        }



        public bool GuardarArticulo(Articulo oArticulo)
        {
            return Dao.GuardarArticulo(oArticulo);
        }

        public bool EditarArticulo(Articulo oArticulo)
        {
            return Dao.EditarArticulo(oArticulo);
        }

        public bool EliminarArticulo(int idArticulo)
        {
           return Dao.EliminarArticulo(idArticulo);
        }



        public bool GuardarCliente(Cliente oCliente)
        {
            return Dao.GuardarCliente(oCliente);
        }
        public bool EditarCliente(Cliente oCliente)
        {
            return Dao.EditarCliente(oCliente);
        }
        public List<Barrio> GetBarrios()
        {
            return Dao.GetBarrios();
        }
        public void EliminarCliente(int idCliente)
        {
            Dao.EliminarCliente(idCliente);

        }


        //public DataTable LoginIngreso(string Usuario , string Pass)
        //{
        //    return Dao.LoginIngreso(Usuario, Pass);
        //}


    }
}
