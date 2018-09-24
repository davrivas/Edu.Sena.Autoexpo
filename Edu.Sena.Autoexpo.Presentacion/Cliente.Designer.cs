namespace Edu.Sena.Autoexpo.Presentacion {
    partial class Cliente {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.tabsCliente = new System.Windows.Forms.TabControl();
            this.tabAutosVenta = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPuertasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaAutoDisponibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoexpoVistaDataSet = new Edu.Sena.Autoexpo.Presentacion.AutoexpoVistaDataSet();
            this.tabEditarPerfil = new System.Windows.Forms.TabPage();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.lblCambiarClave = new System.Windows.Forms.Label();
            this.lblEditarPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbConfimacion = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.vistaAutoDisponibleTableAdapter = new Edu.Sena.Autoexpo.Presentacion.AutoexpoVistaDataSetTableAdapters.VistaAutoDisponibleTableAdapter();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPuertasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsCliente.SuspendLayout();
            this.tabAutosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAutoDisponibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoexpoVistaDataSet)).BeginInit();
            this.tabEditarPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsCliente
            // 
            this.tabsCliente.Controls.Add(this.tabAutosVenta);
            this.tabsCliente.Controls.Add(this.tabEditarPerfil);
            this.tabsCliente.Location = new System.Drawing.Point(12, 12);
            this.tabsCliente.Name = "tabsCliente";
            this.tabsCliente.SelectedIndex = 0;
            this.tabsCliente.Size = new System.Drawing.Size(960, 366);
            this.tabsCliente.TabIndex = 5;
            // 
            // tabAutosVenta
            // 
            this.tabAutosVenta.Controls.Add(this.dataGridView1);
            this.tabAutosVenta.Location = new System.Drawing.Point(4, 22);
            this.tabAutosVenta.Name = "tabAutosVenta";
            this.tabAutosVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutosVenta.Size = new System.Drawing.Size(952, 340);
            this.tabAutosVenta.TabIndex = 0;
            this.tabAutosVenta.Text = "Autos en venta";
            this.tabAutosVenta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.placaDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.numeroPuertasDataGridViewTextBoxColumn1,
            this.colorDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.vistaAutoDisponibleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(952, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // numeroPuertasDataGridViewTextBoxColumn1
            // 
            this.numeroPuertasDataGridViewTextBoxColumn1.DataPropertyName = "NumeroPuertas";
            this.numeroPuertasDataGridViewTextBoxColumn1.HeaderText = "NumeroPuertas";
            this.numeroPuertasDataGridViewTextBoxColumn1.Name = "numeroPuertasDataGridViewTextBoxColumn1";
            this.numeroPuertasDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn1
            // 
            this.colorDataGridViewTextBoxColumn1.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn1.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn1.Name = "colorDataGridViewTextBoxColumn1";
            this.colorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vistaAutoDisponibleBindingSource
            // 
            this.vistaAutoDisponibleBindingSource.DataMember = "VistaAutoDisponible";
            this.vistaAutoDisponibleBindingSource.DataSource = this.autoexpoVistaDataSet;
            // 
            // autoexpoVistaDataSet
            // 
            this.autoexpoVistaDataSet.DataSetName = "AutoexpoVistaDataSet";
            this.autoexpoVistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabEditarPerfil
            // 
            this.tabEditarPerfil.Controls.Add(this.btnCambiarClave);
            this.tabEditarPerfil.Controls.Add(this.btnEditarPerfil);
            this.tabEditarPerfil.Controls.Add(this.lblCambiarClave);
            this.tabEditarPerfil.Controls.Add(this.lblEditarPerfil);
            this.tabEditarPerfil.Controls.Add(this.label1);
            this.tabEditarPerfil.Controls.Add(this.textBox1);
            this.tabEditarPerfil.Controls.Add(this.lblConfirmacion);
            this.tabEditarPerfil.Controls.Add(this.lblClave);
            this.tabEditarPerfil.Controls.Add(this.lblTelefono);
            this.tabEditarPerfil.Controls.Add(this.lblDireccion);
            this.tabEditarPerfil.Controls.Add(this.lblEmail);
            this.tabEditarPerfil.Controls.Add(this.tbConfimacion);
            this.tabEditarPerfil.Controls.Add(this.lblApellidos);
            this.tabEditarPerfil.Controls.Add(this.tbClave);
            this.tabEditarPerfil.Controls.Add(this.tbTelefono);
            this.tabEditarPerfil.Controls.Add(this.tbDireccion);
            this.tabEditarPerfil.Controls.Add(this.tbEmail);
            this.tabEditarPerfil.Controls.Add(this.tbApellidos);
            this.tabEditarPerfil.Controls.Add(this.lblNombres);
            this.tabEditarPerfil.Controls.Add(this.tbNombres);
            this.tabEditarPerfil.Location = new System.Drawing.Point(4, 22);
            this.tabEditarPerfil.Name = "tabEditarPerfil";
            this.tabEditarPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditarPerfil.Size = new System.Drawing.Size(952, 340);
            this.tabEditarPerfil.TabIndex = 2;
            this.tabEditarPerfil.Text = "Editar perfil";
            this.tabEditarPerfil.UseVisualStyleBackColor = true;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Location = new System.Drawing.Point(294, 170);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarClave.TabIndex = 35;
            this.btnCambiarClave.Text = "Cambiar clave";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Location = new System.Drawing.Point(12, 170);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPerfil.TabIndex = 10;
            this.btnEditarPerfil.Text = "Editar pefil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            // 
            // lblCambiarClave
            // 
            this.lblCambiarClave.AutoSize = true;
            this.lblCambiarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarClave.Location = new System.Drawing.Point(291, 17);
            this.lblCambiarClave.Name = "lblCambiarClave";
            this.lblCambiarClave.Size = new System.Drawing.Size(110, 17);
            this.lblCambiarClave.TabIndex = 34;
            this.lblCambiarClave.Text = "Cambiar clave";
            // 
            // lblEditarPerfil
            // 
            this.lblEditarPerfil.AutoSize = true;
            this.lblEditarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarPerfil.Location = new System.Drawing.Point(8, 17);
            this.lblEditarPerfil.Name = "lblEditarPerfil";
            this.lblEditarPerfil.Size = new System.Drawing.Size(93, 17);
            this.lblEditarPerfil.TabIndex = 33;
            this.lblEditarPerfil.Text = "Editar perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Clave";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(291, 128);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(68, 13);
            this.lblConfirmacion.TabIndex = 30;
            this.lblConfirmacion.Text = "Confirmación";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(291, 50);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 29;
            this.lblClave.Text = "Clave";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(115, 89);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 28;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 128);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 27;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // tbConfimacion
            // 
            this.tbConfimacion.Location = new System.Drawing.Point(294, 144);
            this.tbConfimacion.Name = "tbConfimacion";
            this.tbConfimacion.PasswordChar = '*';
            this.tbConfimacion.Size = new System.Drawing.Size(100, 20);
            this.tbConfimacion.TabIndex = 24;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(115, 50);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 25;
            this.lblApellidos.Text = "Apellidos";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(294, 66);
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 23;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(115, 105);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 21;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(11, 144);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(204, 20);
            this.tbDireccion.TabIndex = 22;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 105);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 20;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(118, 66);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 18;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(12, 50);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 19;
            this.lblNombres.Text = "Nombres";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(12, 66);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(100, 20);
            this.tbNombres.TabIndex = 17;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.Location = new System.Drawing.Point(890, 379);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(78, 23);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(16, 384);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // vistaAutoDisponibleTableAdapter
            // 
            this.vistaAutoDisponibleTableAdapter.ClearBeforeFill = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPuertasDataGridViewTextBoxColumn
            // 
            this.numeroPuertasDataGridViewTextBoxColumn.DataPropertyName = "NumeroPuertas";
            this.numeroPuertasDataGridViewTextBoxColumn.HeaderText = "NumeroPuertas";
            this.numeroPuertasDataGridViewTextBoxColumn.Name = "numeroPuertasDataGridViewTextBoxColumn";
            this.numeroPuertasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 414);
            this.Controls.Add(this.tabsCliente);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnComprar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente - Autoexpo";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.tabsCliente.ResumeLayout(false);
            this.tabAutosVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAutoDisponibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoexpoVistaDataSet)).EndInit();
            this.tabEditarPerfil.ResumeLayout(false);
            this.tabEditarPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsCliente;
        private System.Windows.Forms.TabPage tabEditarPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbConfimacion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCambiarClave;
        private System.Windows.Forms.Label lblEditarPerfil;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnEditarPerfil;
        private AutoexpoVistaDataSet autoexpoVistaDataSet;
        private System.Windows.Forms.BindingSource vistaAutoDisponibleBindingSource;
        private AutoexpoVistaDataSetTableAdapters.VistaAutoDisponibleTableAdapter vistaAutoDisponibleTableAdapter;
        private System.Windows.Forms.TabPage tabAutosVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPuertasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPuertasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}