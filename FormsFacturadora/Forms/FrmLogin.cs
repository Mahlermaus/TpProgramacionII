
using FacturacionBackend.servicio.cache;
using FacturacionBackend.servicio.implementaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Formularios
{
    public partial class FrmLogin : Form
    {
       // public string Usuario ;
        FrmPrincipal frm;
        FacturaService servicio;
        public FrmLogin()
        {
            InitializeComponent();
            frm = new FrmPrincipal();
            servicio = new FacturaService(new DaoFactory());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {;
            if (
            MessageBox.Show("Seguro que quiere Salir?",
                                "Notificacion",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                this.Dispose();
            else
                return;
                
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            string contraseña = txtPassword.Text.Trim();//txtContraseña.Text.Trim();
            string usuario = txtUsuario.Text;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = VINCENT\SQLEXPRESS; Initial Catalog = TpProgFacturacion; Integrated Security = True";
            connection.Open();

            SqlCommand cmd = new SqlCommand("pa_Login",connection);
            //cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "pa_Login";

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@password", contraseña);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    
                    LoginUser.IdUserActivo = reader.GetInt32(0);
                    LoginUser.UsuarioActivo = reader.GetString(1);
                    LoginUser.Email = reader.GetString(4);
                }
                this.Hide();
                frm.Show();
            }
            else
            {

                MessageBox.Show("Usuario no encontrado",
                               "Notificacion",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

            }
            

        }
    }
}
