
using FacturacionBackend.dominio;
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

namespace Forms
{
    public partial class FrmNuevoCliente : Form
    {
        public Cliente cliente;
        public Barrio barrio;
        public FacturaService servicio;
        public FrmNuevoCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            barrio = new Barrio();
            servicio = new FacturaService(new DaoFactory());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CargarComboBarrios();
            MostrarClientes();

        }

        private void CargarComboBarrios() //en vez de llamarlo con GETBARRIOS lo llamamos del service
        {
            List<Barrio> lst = servicio.GetBarrios();

            cboBarrio.DataSource = lst;
            cboBarrio.ValueMember = "IdBarrio";
            cboBarrio.DisplayMember = "NombreBarrio";
        }

        private void btnAgregar_Click(object sender, EventArgs e) // LLAMAMOS DESDE EL DAO
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }

            btnEditar.Enabled = false;
            cliente.NomCliente = txtNombre.Text;
            cliente.ApeCliente = txtApellido.Text;
            cliente.Barrio.IdBarrio = cboBarrio.SelectedIndex + 1;
            cliente.Calle = txtCalle.Text;
            cliente.Altura = txtAltura.Text;
            cliente.Email = txtEmail.Text;
            cliente.Tel = txtTelefono.Text;            

            if (servicio.GuardarCliente(cliente)) 
            {
                MessageBox.Show("Se guardo un nuevo cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al intentar grabar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tpProgFacturacionDataSet2.clientes' Puede moverla o quitarla según sea necesario.
           // this.clientesTableAdapter.Fill(this.tpProgFacturacionDataSet2.clientes);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)/// EN VEZ DE LLAMAR A ELIMINAR CLIENTES , LLAMAMOS AL SERVICE
        {
            if (dgvClientes.CurrentCell.ColumnIndex == 8)
            {
                Cliente EdicionCliente = new Cliente();

                EdicionCliente.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["colId"].Value.ToString());
                EdicionCliente.NomCliente = dgvClientes.CurrentRow.Cells["colNombre"].Value.ToString();
                EdicionCliente.ApeCliente = dgvClientes.CurrentRow.Cells["colApellido"].Value.ToString();
                EdicionCliente.Calle = dgvClientes.CurrentRow.Cells["colCalle"].Value.ToString();
                EdicionCliente.Altura = dgvClientes.CurrentRow.Cells["colAltura"].Value.ToString();
                EdicionCliente.Barrio.IdBarrio = Convert.ToInt32(dgvClientes.CurrentRow.Cells["colIdBarrio"].Value.ToString());
                EdicionCliente.Email = dgvClientes.CurrentRow.Cells["colEmail"].Value.ToString();
                EdicionCliente.Tel = dgvClientes.CurrentRow.Cells["colTel"].Value.ToString();

                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;

                lblId.Text = EdicionCliente.IdCliente.ToString();
                cboBarrio.SelectedItem = EdicionCliente.Barrio.IdBarrio;
                txtNombre.Text = EdicionCliente.NomCliente;
                txtApellido.Text = EdicionCliente.ApeCliente;
                txtCalle.Text = EdicionCliente.Calle;
                txtAltura.Text = EdicionCliente.Altura;
                txtEmail.Text = EdicionCliente.Email;
                txtTelefono.Text = EdicionCliente.Tel;
            }
            if (dgvClientes.CurrentCell.ColumnIndex == 9) /// EN VEZ DE LLAMAR A ELIMINAR CLIENTES , LLAMAMOS AL SERVICE
            {
                DataGridViewRow row = dgvClientes.CurrentRow;
                if (row != null)
                {
                    int IdCliente = Int32.Parse(row.Cells["colId"].Value.ToString());
                    if (MessageBox.Show("Se dara de baja el Cliente seleccionado", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        servicio.EliminarCliente(IdCliente);
                        MostrarClientes();
                    }
                }
            }
        }      

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }
            cliente.IdCliente = Convert.ToInt32(lblId.Text);
            cliente.NomCliente = txtNombre.Text;
            cliente.ApeCliente = txtApellido.Text;
            cliente.Barrio.IdBarrio = Convert.ToInt32(cboBarrio.SelectedIndex.ToString()+1);
            cliente.Calle = txtCalle.Text;
            cliente.Altura = txtAltura.Text;
            cliente.Email = txtEmail.Text;
            cliente.Tel = txtTelefono.Text;

           

            if (servicio.EditarCliente(cliente))
            {
                MessageBox.Show("Se edito correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarClientes();
            }
            else
            {
                MessageBox.Show("Error al editar el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarClientes()
        {
            DataTable table = servicio.CargarClientes();
            dgvClientes.DataSource = table;
            dgvClientes.Show();
        }
    }
}
