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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.tabsCliente = new System.Windows.Forms.TabControl();
            this.tabAutosVenta = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabHistorialCompras = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabEditarPerfil = new System.Windows.Forms.TabPage();
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
            this.tabsCliente.SuspendLayout();
            this.tabAutosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabHistorialCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabEditarPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsCliente
            // 
            this.tabsCliente.Controls.Add(this.tabAutosVenta);
            this.tabsCliente.Controls.Add(this.tabHistorialCompras);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(952, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabHistorialCompras
            // 
            this.tabHistorialCompras.Controls.Add(this.dataGridView2);
            this.tabHistorialCompras.Location = new System.Drawing.Point(4, 22);
            this.tabHistorialCompras.Name = "tabHistorialCompras";
            this.tabHistorialCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorialCompras.Size = new System.Drawing.Size(952, 340);
            this.tabHistorialCompras.TabIndex = 1;
            this.tabHistorialCompras.Text = "Historial de compras";
            this.tabHistorialCompras.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(952, 340);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabEditarPerfil
            // 
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
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(419, 201);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(68, 13);
            this.lblConfirmacion.TabIndex = 30;
            this.lblConfirmacion.Text = "Confirmación";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(317, 201);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 29;
            this.lblClave.Text = "Clave";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(422, 123);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 28;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(319, 162);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 27;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(319, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // tbConfimacion
            // 
            this.tbConfimacion.Location = new System.Drawing.Point(422, 217);
            this.tbConfimacion.Name = "tbConfimacion";
            this.tbConfimacion.PasswordChar = '*';
            this.tbConfimacion.Size = new System.Drawing.Size(100, 20);
            this.tbConfimacion.TabIndex = 24;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(422, 84);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 25;
            this.lblApellidos.Text = "Apellidos";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(320, 217);
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 23;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(425, 139);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 21;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(321, 178);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(204, 20);
            this.tbDireccion.TabIndex = 22;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(322, 139);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 20;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(425, 100);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 18;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(316, 84);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 19;
            this.lblNombres.Text = "Nombres";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(319, 100);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(100, 20);
            this.tbNombres.TabIndex = 17;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.Location = new System.Drawing.Point(97, 384);
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
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 414);
            this.Controls.Add(this.tabsCliente);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnComprar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cliente";
            this.Text = "Cliente - Autoexpo";
            this.tabsCliente.ResumeLayout(false);
            this.tabAutosVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabHistorialCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabEditarPerfil.ResumeLayout(false);
            this.tabEditarPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsCliente;
        private System.Windows.Forms.TabPage tabAutosVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabHistorialCompras;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}