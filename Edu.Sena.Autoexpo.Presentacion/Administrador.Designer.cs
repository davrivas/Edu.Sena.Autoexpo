namespace Edu.Sena.Autoexpo.Presentacion {
    partial class Administrador {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.tabsAdmin = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDePuertasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioSinIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaVentaCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoexpoVistaDataSet = new Edu.Sena.Autoexpo.Presentacion.AutoexpoVistaDataSet();
            this.tabAutos = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroDePuertasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaAutoCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.vistaVentaCompletoTableAdapter = new Edu.Sena.Autoexpo.Presentacion.AutoexpoVistaDataSetTableAdapters.VistaVentaCompletoTableAdapter();
            this.vistaAutoCompletoTableAdapter = new Edu.Sena.Autoexpo.Presentacion.AutoexpoVistaDataSetTableAdapters.VistaAutoCompletoTableAdapter();
            this.vistaClienteTableAdapter = new Edu.Sena.Autoexpo.Presentacion.AutoexpoVistaDataSetTableAdapters.VistaClienteTableAdapter();
            this.tabsAdmin.SuspendLayout();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentaCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoexpoVistaDataSet)).BeginInit();
            this.tabAutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAutoCompletoBindingSource)).BeginInit();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsAdmin
            // 
            this.tabsAdmin.Controls.Add(this.tabVentas);
            this.tabsAdmin.Controls.Add(this.tabAutos);
            this.tabsAdmin.Controls.Add(this.tabClientes);
            this.tabsAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabsAdmin.Name = "tabsAdmin";
            this.tabsAdmin.SelectedIndex = 0;
            this.tabsAdmin.Size = new System.Drawing.Size(960, 366);
            this.tabsAdmin.TabIndex = 0;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.dataGridView1);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(952, 340);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.apellidoClienteDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.númeroDePuertasDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.precioSinIVADataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.totalIVADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaVentaCompletoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(952, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre cliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "Apellido Cliente";
            this.apellidoClienteDataGridViewTextBoxColumn.HeaderText = "Apellido Cliente";
            this.apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            this.apellidoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroDePuertasDataGridViewTextBoxColumn
            // 
            this.númeroDePuertasDataGridViewTextBoxColumn.DataPropertyName = "Número de puertas";
            this.númeroDePuertasDataGridViewTextBoxColumn.HeaderText = "Número de puertas";
            this.númeroDePuertasDataGridViewTextBoxColumn.Name = "númeroDePuertasDataGridViewTextBoxColumn";
            this.númeroDePuertasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioSinIVADataGridViewTextBoxColumn
            // 
            this.precioSinIVADataGridViewTextBoxColumn.DataPropertyName = "Precio sin IVA";
            this.precioSinIVADataGridViewTextBoxColumn.HeaderText = "Precio sin IVA";
            this.precioSinIVADataGridViewTextBoxColumn.Name = "precioSinIVADataGridViewTextBoxColumn";
            this.precioSinIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "Iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            this.ivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalIVADataGridViewTextBoxColumn
            // 
            this.totalIVADataGridViewTextBoxColumn.DataPropertyName = "Total + IVA";
            this.totalIVADataGridViewTextBoxColumn.HeaderText = "Total + IVA";
            this.totalIVADataGridViewTextBoxColumn.Name = "totalIVADataGridViewTextBoxColumn";
            this.totalIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaVentaCompletoBindingSource
            // 
            this.vistaVentaCompletoBindingSource.DataMember = "VistaVentaCompleto";
            this.vistaVentaCompletoBindingSource.DataSource = this.autoexpoVistaDataSet;
            // 
            // autoexpoVistaDataSet
            // 
            this.autoexpoVistaDataSet.DataSetName = "AutoexpoVistaDataSet";
            this.autoexpoVistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabAutos
            // 
            this.tabAutos.Controls.Add(this.dataGridView2);
            this.tabAutos.Location = new System.Drawing.Point(4, 22);
            this.tabAutos.Name = "tabAutos";
            this.tabAutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutos.Size = new System.Drawing.Size(952, 340);
            this.tabAutos.TabIndex = 1;
            this.tabAutos.Text = "Autos";
            this.tabAutos.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.númeroDePuertasDataGridViewTextBoxColumn1,
            this.colorDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vistaAutoCompletoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(952, 340);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn1
            // 
            this.placaDataGridViewTextBoxColumn1.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn1.Name = "placaDataGridViewTextBoxColumn1";
            this.placaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn1
            // 
            this.marcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn1.Name = "marcaDataGridViewTextBoxColumn1";
            this.marcaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn1
            // 
            this.modeloDataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.Name = "modeloDataGridViewTextBoxColumn1";
            this.modeloDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // númeroDePuertasDataGridViewTextBoxColumn1
            // 
            this.númeroDePuertasDataGridViewTextBoxColumn1.DataPropertyName = "Número de puertas";
            this.númeroDePuertasDataGridViewTextBoxColumn1.HeaderText = "Número de puertas";
            this.númeroDePuertasDataGridViewTextBoxColumn1.Name = "númeroDePuertasDataGridViewTextBoxColumn1";
            this.númeroDePuertasDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn1
            // 
            this.colorDataGridViewTextBoxColumn1.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn1.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn1.Name = "colorDataGridViewTextBoxColumn1";
            this.colorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaAutoCompletoBindingSource
            // 
            this.vistaAutoCompletoBindingSource.DataMember = "VistaAutoCompleto";
            this.vistaAutoCompletoBindingSource.DataSource = this.autoexpoVistaDataSet;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.dataGridView3);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(952, 340);
            this.tabClientes.TabIndex = 2;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.vistaClienteBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(952, 340);
            this.dataGridView3.TabIndex = 0;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaClienteBindingSource
            // 
            this.vistaClienteBindingSource.DataMember = "VistaCliente";
            this.vistaClienteBindingSource.DataSource = this.autoexpoVistaDataSet;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Location = new System.Drawing.Point(16, 384);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar auto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.Location = new System.Drawing.Point(100, 385);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar auto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Location = new System.Drawing.Point(181, 384);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar auto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.Location = new System.Drawing.Point(891, 384);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(81, 23);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // vistaVentaCompletoTableAdapter
            // 
            this.vistaVentaCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // vistaAutoCompletoTableAdapter
            // 
            this.vistaAutoCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // vistaClienteTableAdapter
            // 
            this.vistaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 420);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tabsAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador - Autoexpo";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.tabsAdmin.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentaCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoexpoVistaDataSet)).EndInit();
            this.tabAutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAutoCompletoBindingSource)).EndInit();
            this.tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsAdmin;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabAutos;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private AutoexpoVistaDataSet autoexpoVistaDataSet;
        private System.Windows.Forms.BindingSource vistaVentaCompletoBindingSource;
        private AutoexpoVistaDataSetTableAdapters.VistaVentaCompletoTableAdapter vistaVentaCompletoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDePuertasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioSinIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vistaAutoCompletoBindingSource;
        private AutoexpoVistaDataSetTableAdapters.VistaAutoCompletoTableAdapter vistaAutoCompletoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroDePuertasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vistaClienteBindingSource;
        private AutoexpoVistaDataSetTableAdapters.VistaClienteTableAdapter vistaClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
    }
}