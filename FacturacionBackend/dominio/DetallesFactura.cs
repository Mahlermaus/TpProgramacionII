using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.dominio
{
    public class DetallesFactura
    {
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }

        public DetallesFactura()
        {
            Articulo = new Articulo();
            Cantidad = 0;
        }

      

        public double CalcularGanancia()
        {
            return (Articulo.PrecioUnitario * Cantidad) -
                   (Articulo.Costo * Cantidad);
        }

        public bool GuardarArticulo(Articulo articulo)
        {
            SqlTransaction transaction = null;
            SqlConnection conexion = new SqlConnection(@"Data Source = VINCENT\SQLEXPRESS; Initial Catalog = TpProgFacturacion; Integrated Security = True");


            bool flag = true;
            try
            {
                conexion.Open();
                transaction = conexion.BeginTransaction();

                SqlCommand cmd = new SqlCommand("pa_InsertarArticulo", conexion, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", articulo.NombreArticulo);
                cmd.Parameters.AddWithValue("@preUnitario", articulo.PrecioUnitario);
                cmd.Parameters.AddWithValue("@stock", articulo.Stock);
                cmd.Parameters.AddWithValue("@preCosto", articulo.Costo);
                              

                transaction.Commit();

            }
            catch (Exception)
            {
                transaction.Rollback();
                flag = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return flag;
        }
    }
}
