
namespace Forms.Formularios
{
    partial class FrmNuevaFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCantidadArticulo = new System.Windows.Forms.NumericUpDown();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
        //    this.tpProgFacturacionDataSet = new Forms.TpProgFacturacionDataSet();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacturaNro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNuevaFactura = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
         //   this.articulosTableAdapter = new Forms.TpProgFacturacionDataSetTableAdapters.articulosTableAdapter();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.tpProgFacturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.nudCantidadArticulo);
            this.groupBox1.Controls.Add(this.cboFormaPago);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboArticulo);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFacturaNro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Usuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FACTURA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nudCantidadArticulo
            // 
            this.nudCantidadArticulo.Location = new System.Drawing.Point(363, 179);
            this.nudCantidadArticulo.Name = "nudCantidadArticulo";
            this.nudCantidadArticulo.Size = new System.Drawing.Size(138, 26);
            this.nudCantidadArticulo.TabIndex = 20;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(537, 113);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(201, 28);
            this.cboFormaPago.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregar.Location = new System.Drawing.Point(516, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(222, 53);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Articulo";
            // 
            // cboArticulo
            // 
            this.cboArticulo.DataSource = this.articulosBindingSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(23, 178);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(327, 28);
            this.cboArticulo.TabIndex = 15;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "articulos";
        //    this.articulosBindingSource.DataSource = this.tpProgFacturacionDataSet;
            // 
            // tpProgFacturacionDataSet
            // 
          //  this.tpProgFacturacionDataSet.DataSetName = "TpProgFacturacionDataSet";
          //  this.tpProgFacturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(21, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(201, 26);
            this.txtUsuario.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(500, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forma de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente";
            // 
            // txtFacturaNro
            // 
            this.txtFacturaNro.Location = new System.Drawing.Point(259, 54);
            this.txtFacturaNro.Name = "txtFacturaNro";
            this.txtFacturaNro.ReadOnly = true;
            this.txtFacturaNro.Size = new System.Drawing.Size(88, 26);
            this.txtFacturaNro.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factura Nro";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(17, 31);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(64, 20);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Engravers MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(532, 571);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(222, 38);
            this.txtTotal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total";
            // 
            // dgvNuevaFactura
            // 
            this.dgvNuevaFactura.AllowUserToAddRows = false;
            this.dgvNuevaFactura.AllowUserToDeleteRows = false;
            this.dgvNuevaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNombreArticulo,
            this.colPrecioArticulo,
            this.colCantidad,
            this.colBorrar});
            this.dgvNuevaFactura.Location = new System.Drawing.Point(12, 242);
            this.dgvNuevaFactura.Name = "dgvNuevaFactura";
            this.dgvNuevaFactura.ReadOnly = true;
            this.dgvNuevaFactura.RowHeadersWidth = 62;
            this.dgvNuevaFactura.RowTemplate.Height = 28;
            this.dgvNuevaFactura.Size = new System.Drawing.Size(754, 290);
            this.dgvNuevaFactura.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.HeaderText = "";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 150;
            // 
            // colNombreArticulo
            // 
            this.colNombreArticulo.HeaderText = "Articulo";
            this.colNombreArticulo.MinimumWidth = 8;
            this.colNombreArticulo.Name = "colNombreArticulo";
            this.colNombreArticulo.ReadOnly = true;
            this.colNombreArticulo.Width = 150;
            // 
            // colPrecioArticulo
            // 
            this.colPrecioArticulo.HeaderText = "Precio";
            this.colPrecioArticulo.MinimumWidth = 8;
            this.colPrecioArticulo.Name = "colPrecioArticulo";
            this.colPrecioArticulo.ReadOnly = true;
            this.colPrecioArticulo.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 150;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "Borrar";
            this.colBorrar.MinimumWidth = 8;
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Width = 150;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAceptar.Location = new System.Drawing.Point(12, 561);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 50);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancelar.Location = new System.Drawing.Point(184, 561);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 50);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnImprimir.Location = new System.Drawing.Point(375, 558);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(138, 53);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // articulosTableAdapter
            // 
         //   this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // cboCliente
            // 
            this.cboCliente.DataSource = this.articulosBindingSource;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(20, 115);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(481, 28);
            this.cboCliente.TabIndex = 21;
            // 
            // FrmNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 634);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvNuevaFactura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNuevaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "----- Nueva Factura -----";
            this.Load += new System.EventHandler(this.FrmNuevaFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.tpProgFacturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFacturaNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNuevaFactura;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboFormaPago;
      //  private TpProgFacturacionDataSet tpProgFacturacionDataSet;
        private System.Windows.Forms.BindingSource articulosBindingSource;
       // private TpProgFacturacionDataSetTableAdapters.articulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.NumericUpDown nudCantidadArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.ComboBox cboCliente;
    }
}