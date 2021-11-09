
namespace Forms.Formularios
{
    partial class FrmArticulos
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
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecioUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
 //           this.dsArticulos = new Forms.DsArticulos();
   //         this.articulosTableAdapter = new Forms.DsArticulosTableAdapters.articulosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.dsArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.txtPrecioCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescripcionArticulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.txtPrecioUnit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNuevoArticulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(201, 117);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(151, 26);
            this.txtStock.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(652, 55);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(95, 26);
            this.txtId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(201, 167);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 40);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(599, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 40);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(395, 117);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(151, 26);
            this.txtPrecioCosto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio Costo";
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(10, 55);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(592, 26);
            this.txtDescripcionArticulo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(197, 94);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            // 
            // txtPrecioUnit
            // 
            this.txtPrecioUnit.Location = new System.Drawing.Point(10, 117);
            this.txtPrecioUnit.Name = "txtPrecioUnit";
            this.txtPrecioUnit.Size = new System.Drawing.Size(150, 26);
            this.txtPrecioUnit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Precio Unitario";
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Location = new System.Drawing.Point(10, 167);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(149, 40);
            this.btnNuevoArticulo.TabIndex = 3;
            this.btnNuevoArticulo.Text = "Agregar";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoGenerateColumns = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colDescripcionArticulo,
            this.colPrecioUnit,
            this.colStock,
            this.colPrecioCosto,
            this.colEditar,
            this.colBorrar});
            this.dgvArticulos.DataSource = this.articulosBindingSource;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 238);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.Size = new System.Drawing.Size(754, 384);
            this.dgvArticulos.TabIndex = 4;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_articulo";
            this.ID.HeaderText = "id_articulo";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // colDescripcionArticulo
            // 
            this.colDescripcionArticulo.DataPropertyName = "descripcion";
            this.colDescripcionArticulo.HeaderText = "descripcion";
            this.colDescripcionArticulo.MinimumWidth = 8;
            this.colDescripcionArticulo.Name = "colDescripcionArticulo";
            this.colDescripcionArticulo.ReadOnly = true;
            this.colDescripcionArticulo.Width = 150;
            // 
            // colPrecioUnit
            // 
            this.colPrecioUnit.DataPropertyName = "pre_unitario";
            this.colPrecioUnit.HeaderText = "pre_unitario";
            this.colPrecioUnit.MinimumWidth = 8;
            this.colPrecioUnit.Name = "colPrecioUnit";
            this.colPrecioUnit.ReadOnly = true;
            this.colPrecioUnit.Width = 150;
            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "stock";
            this.colStock.HeaderText = "stock";
            this.colStock.MinimumWidth = 8;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 150;
            // 
            // colPrecioCosto
            // 
            this.colPrecioCosto.DataPropertyName = "pre_costo";
            this.colPrecioCosto.HeaderText = "pre_costo";
            this.colPrecioCosto.MinimumWidth = 8;
            this.colPrecioCosto.Name = "colPrecioCosto";
            this.colPrecioCosto.ReadOnly = true;
            this.colPrecioCosto.Width = 150;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.MinimumWidth = 8;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Text = "Edicion";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 150;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "Borrar";
            this.colBorrar.MinimumWidth = 8;
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Text = "Dar de Baja";
            this.colBorrar.UseColumnTextForButtonValue = true;
            this.colBorrar.Width = 150;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "articulos";
            //this.articulosBindingSource.DataSource = this.dsArticulos;
            // 
            // dsArticulos
            // 
        //    this.dsArticulos.DataSetName = "DsArticulos";
          //  this.dsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosTableAdapter
            // 
       //     this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 634);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.dsArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecioUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvArticulos;
    //    private DsArticulos dsArticulos;
        private System.Windows.Forms.BindingSource articulosBindingSource;
      //  private DsArticulosTableAdapters.articulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCosto;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
    }
}