
namespace Forms
{
    partial class FrmNuevoCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.tpProgFacturacionDataSet2 = new Forms.TpProgFacturacionDataSet2();
      //      this.clientesTableAdapter = new Forms.TpProgFacturacionDataSet2TableAdapters.clientesTableAdapter();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.tpProgFacturacionDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.cboBarrio);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(578, 168);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 40);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(202, 168);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 40);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Guardar Edicion";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(345, 119);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(145, 28);
            this.cboBarrio.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 168);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(518, 55);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 26);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(518, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(260, 121);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(79, 26);
            this.txtAltura.TabIndex = 11;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(10, 121);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(230, 26);
            this.txtCalle.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(260, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(230, 26);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Barrio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colCalle,
            this.colAltura,
            this.colIdBarrio,
            this.colEmail,
            this.colTel,
            this.colEditar,
            this.colBorrar});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 238);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(754, 384);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
         //   this.clientesBindingSource.DataSource = this.tpProgFacturacionDataSet2;
            // 
            // tpProgFacturacionDataSet2
            // 
       //     this.tpProgFacturacionDataSet2.DataSetName = "TpProgFacturacionDataSet2";
       //     this.tpProgFacturacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
         //   this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id_cliente";
            this.colId.HeaderText = "id_cliente";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 150;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.HeaderText = "nombre";
            this.colNombre.MinimumWidth = 8;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 150;
            // 
            // colApellido
            // 
            this.colApellido.DataPropertyName = "apellido";
            this.colApellido.HeaderText = "apellido";
            this.colApellido.MinimumWidth = 8;
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Width = 150;
            // 
            // colCalle
            // 
            this.colCalle.DataPropertyName = "calle";
            this.colCalle.HeaderText = "calle";
            this.colCalle.MinimumWidth = 8;
            this.colCalle.Name = "colCalle";
            this.colCalle.ReadOnly = true;
            this.colCalle.Width = 150;
            // 
            // colAltura
            // 
            this.colAltura.DataPropertyName = "altura";
            this.colAltura.HeaderText = "altura";
            this.colAltura.MinimumWidth = 8;
            this.colAltura.Name = "colAltura";
            this.colAltura.ReadOnly = true;
            this.colAltura.Width = 150;
            // 
            // colIdBarrio
            // 
            this.colIdBarrio.DataPropertyName = "id_barrio";
            this.colIdBarrio.HeaderText = "id_barrio";
            this.colIdBarrio.MinimumWidth = 8;
            this.colIdBarrio.Name = "colIdBarrio";
            this.colIdBarrio.ReadOnly = true;
            this.colIdBarrio.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 150;
            // 
            // colTel
            // 
            this.colTel.DataPropertyName = "tel";
            this.colTel.HeaderText = "tel";
            this.colTel.MinimumWidth = 8;
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            this.colTel.Width = 150;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.MinimumWidth = 8;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditar.Text = "Editar";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 150;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "Borrar";
            this.colBorrar.MinimumWidth = 8;
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Text = "Borrar";
            this.colBorrar.UseColumnTextForButtonValue = true;
            this.colBorrar.Width = 150;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(175, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 20);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID ";
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 634);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNuevoCliente";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.FrmNuevoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.tpProgFacturacionDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvClientes;
      //  private TpProgFacturacionDataSet2 tpProgFacturacionDataSet2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    //    private TpProgFacturacionDataSet2TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.Label lblId;
    }
}

