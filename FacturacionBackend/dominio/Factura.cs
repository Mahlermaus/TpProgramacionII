using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.dominio
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public FormaPago FormaPago { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<DetallesFactura> Detalles { get; set; }
        public double Total { get; set; }


        public Factura()
        {
            Detalles = new List<DetallesFactura>();
            Usuario = new Usuario();
            Cliente = new Cliente();
            FormaPago = new FormaPago();
            FechaFactura = DateTime.Today;
        }

        public void AgregarDetalle(DetallesFactura detalle)
        {
            Detalles.Add(detalle);

        }
        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }
        public double CalcularTotalFactura()
        {
            double total = 0;
            foreach(DetallesFactura item in Detalles)
            {
                total += (item.Cantidad * item.Articulo.PrecioUnitario);
            }
            return total;
        }
        public double CalcularGanancia()
        {
            double total = 0;
            foreach(DetallesFactura item in Detalles)
            {
                total += item.CalcularGanancia();
            }
            return total;
        }

        
        
    }
}
