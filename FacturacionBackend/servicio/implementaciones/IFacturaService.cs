using FacturacionBackend.dominio;
using System.Collections.Generic;
using System.Data;

namespace FacturacionBackend.servicio.implementaciones
{
    public interface IFacturaService
    {
        public int IdProximaFactura();
        public DataTable CargarClientes();
        public DataTable CargarArticulos();
        public DataTable CargarFormasPago();


        public bool CrearFactura(Factura oFactura);


        public bool GuardarArticulo(Articulo oArticulo);
        public bool EditarArticulo(Articulo oArticulo);
        public bool EliminarArticulo(int idArticulo);


        public bool GuardarCliente(Cliente oCliente);
        public bool EditarCliente(Cliente oCliente);
        public List<Barrio> GetBarrios();
        public void EliminarCliente(int idCliente);




    }
}