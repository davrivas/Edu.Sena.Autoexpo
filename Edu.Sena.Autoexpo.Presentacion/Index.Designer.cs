namespace Edu.Sena.Autoexpo.Presentacion {
    partial class Index {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbConfimacion = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblClaveIniciarSesion = new System.Windows.Forms.Label();
            this.lblEmailIniciarSesion = new System.Windows.Forms.Label();
            this.tbClaveIniciarSesion = new System.Windows.Forms.TextBox();
            this.tbEmailIniciarSesion = new System.Windows.Forms.TextBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.Location = new System.Drawing.Point(243, 169);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(71, 13);
            this.lblRegistrarse.TabIndex = 0;
            this.lblRegistrarse.Text = "Registrarse";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(177, 208);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(100, 20);
            this.tbNombres.TabIndex = 1;
            this.tbNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterRegistrarse);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(174, 192);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(283, 208);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 2;
            this.tbApellidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterRegistrarse);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(180, 247);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterRegistrarse);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(283, 247);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 4;
            this.tbTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterRegistrarse);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(179, 286);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(204, 20);
            this.tbDireccion.TabIndex = 5;
            this.tbDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterRegistrarse);
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(178, 325);
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 6;
            this.tbClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterRegistrarse);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(280, 192);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 9;
            this.lblApellidos.Text = "Apellidos";
            // 
            // tbConfimacion
            // 
            this.tbConfimacion.Location = new System.Drawing.Point(280, 325);
            this.tbConfimacion.Name = "tbConfimacion";
            this.tbConfimacion.PasswordChar = '*';
            this.tbConfimacion.Size = new System.Drawing.Size(100, 20);
            this.tbConfimacion.TabIndex = 7;
            this.tbConfimacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterRegistrarse);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(177, 231);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(177, 270);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(280, 231);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(175, 309);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 15;
            this.lblClave.Text = "Clave";
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(277, 309);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(68, 13);
            this.lblConfirmacion.TabIndex = 16;
            this.lblConfirmacion.Text = "Confirmación";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(246, 351);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 17;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // lblClaveIniciarSesion
            // 
            this.lblClaveIniciarSesion.AutoSize = true;
            this.lblClaveIniciarSesion.Location = new System.Drawing.Point(11, 231);
            this.lblClaveIniciarSesion.Name = "lblClaveIniciarSesion";
            this.lblClaveIniciarSesion.Size = new System.Drawing.Size(34, 13);
            this.lblClaveIniciarSesion.TabIndex = 21;
            this.lblClaveIniciarSesion.Text = "Clave";
            // 
            // lblEmailIniciarSesion
            // 
            this.lblEmailIniciarSesion.AutoSize = true;
            this.lblEmailIniciarSesion.Location = new System.Drawing.Point(11, 192);
            this.lblEmailIniciarSesion.Name = "lblEmailIniciarSesion";
            this.lblEmailIniciarSesion.Size = new System.Drawing.Size(32, 13);
            this.lblEmailIniciarSesion.TabIndex = 20;
            this.lblEmailIniciarSesion.Text = "Email";
            // 
            // tbClaveIniciarSesion
            // 
            this.tbClaveIniciarSesion.Location = new System.Drawing.Point(14, 247);
            this.tbClaveIniciarSesion.Name = "tbClaveIniciarSesion";
            this.tbClaveIniciarSesion.PasswordChar = '*';
            this.tbClaveIniciarSesion.Size = new System.Drawing.Size(100, 20);
            this.tbClaveIniciarSesion.TabIndex = 99;
            this.tbClaveIniciarSesion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterIniciarSesion);
            // 
            // tbEmailIniciarSesion
            // 
            this.tbEmailIniciarSesion.Location = new System.Drawing.Point(14, 208);
            this.tbEmailIniciarSesion.Name = "tbEmailIniciarSesion";
            this.tbEmailIniciarSesion.Size = new System.Drawing.Size(100, 20);
            this.tbEmailIniciarSesion.TabIndex = 98;
            this.tbEmailIniciarSesion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OprimirEnterIniciarSesion);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(12, 169);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(82, 13);
            this.lblIniciarSesion.TabIndex = 22;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(14, 273);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarSesion.TabIndex = 23;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
            this.button1.TabIndex = 100;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConfirmarSalida);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.lblClaveIniciarSesion);
            this.Controls.Add(this.lblEmailIniciarSesion);
            this.Controls.Add(this.tbClaveIniciarSesion);
            this.Controls.Add(this.tbEmailIniciarSesion);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbConfimacion);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.lblRegistrarse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoexpo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox tbConfimacion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblClaveIniciarSesion;
        private System.Windows.Forms.Label lblEmailIniciarSesion;
        private System.Windows.Forms.TextBox tbClaveIniciarSesion;
        private System.Windows.Forms.TextBox tbEmailIniciarSesion;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

