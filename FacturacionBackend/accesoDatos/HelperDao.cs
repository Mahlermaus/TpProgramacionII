using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.accesoDatos
{
     class HelperDao
    {
        private static HelperDao instancia;

        private string stringConexion;
        public SqlConnection cnn { get; set; }
        
        private HelperDao()
        {
            stringConexion = @"Data Source = VINCENT\SQLEXPRESS; Initial Catalog = TpProgFacturacion; Integrated Security = True";
            
        }
        public static HelperDao InstanciaHelperDao()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;
        }
        public DataTable SqlConsulta(string nombrePA)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable table = new DataTable();
            try
            {
                cnn.ConnectionString = stringConexion;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombrePA;

                
                table.Load(cmd.ExecuteReader());
                
                return table;
            }
            catch (SqlException ex)
            {

                throw(ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
            
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
        }
    }
}
