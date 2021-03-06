﻿using Edu.Sena.Autoexpo.Datos;
using Edu.Sena.Autoexpo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Autoexpo.Presentacion {
    public partial class Index : Form {
        private Administrador ventanaAdministrador;
        private Cliente ventanaCliente;

        public Index() {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams {
            get {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public Administrador VentanaAdministrador { get => ventanaAdministrador; set => ventanaAdministrador = value; }
        public Cliente VentanaCliente { get => ventanaCliente; set => ventanaCliente = value; }

        private void IniciarSesion() {
            string email = tbEmailIniciarSesion.Text.Trim(),
                clave = tbClaveIniciarSesion.Text.Trim();

            if (email.Equals("") || clave.Equals("")) {
                MessageBox.Show("Digite ambos campos", "ERROR");
            } else {
                bool login = LogicaUtil.UDAO.BuscarPorEmailClave(email, clave);

                if (login) {
                    MessageBox.Show("Hola " + LogicaUtil.Sesion.Nombres + " " +
                        LogicaUtil.Sesion.Apellidos,
                    LogicaUtil.Sesion.Rol.Rol);
                    tbEmailIniciarSesion.Text = "";
                    tbClaveIniciarSesion.Text = "";
                    switch (LogicaUtil.Sesion.Rol.Id) {
                        case 1:
                            VentanaAdministrador = new Administrador();
                            VentanaAdministrador.Show();
                            this.Hide();
                            break;
                        case 2:
                            VentanaCliente = new Cliente();
                            VentanaCliente.Show();
                            this.Hide();
                            break;
                    }
                } else { 
                    MessageBox.Show("ERROR: Usuario no encontrado");
                }
            }
        }

        public void Registrarse() {
            string nombres = tbNombres.Text.Trim(),
                apellidos = tbApellidos.Text.Trim(),
                email = tbEmail.Text.Trim(),
                telefono = tbTelefono.Text.Trim(),
                direccion = tbDireccion.Text.Trim(),
                clave = tbClave.Text.Trim(),
                confirmacion = tbConfimacion.Text.Trim();

            if (nombres.Equals("") || apellidos.Equals("") || email.Equals("") ||
                telefono.Equals("") || direccion.Equals("") || clave.Equals("") ||
                confirmacion.Equals("")) {
                MessageBox.Show("Llene todos los campos", "ERROR");
            } else {
                if (clave.Equals(confirmacion)) {
                    UsuarioDTO nuevoCliente = new UsuarioDTO {
                        Nombres = nombres,
                        Apellidos = apellidos,
                        Email = email,
                        Telefono = telefono,
                        Direccion = direccion,
                        Clave = clave
                    };
                    LogicaUtil.UDAO.Ingresar(nuevoCliente);
                    tbNombres.Text = "";
                    tbApellidos.Text = "";
                    tbEmail.Text = "";
                    tbTelefono.Text = "";
                    tbDireccion.Text = "";
                    tbClave.Text = "";
                    tbConfimacion.Text = "";
                } else {
                    MessageBox.Show("Las contraseñas no coinciden", "ERROR");
                }
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e) {
            IniciarSesion();
        }

        private void OprimirEnterIniciarSesion(object sender, KeyEventArgs e) {
            switch (e.KeyValue) {
                case 13: // Cuando se oprime enter
                    IniciarSesion();
                    break;
            }
        }

        private void OprimirEnterRegistrarse(object sender, KeyEventArgs e) {
            switch (e.KeyValue) {
                case 13: // Cuando se oprime enter
                    Registrarse();
                    break;
            }
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e) {
            Registrarse();
        }

        private void ConfirmarSalida(object sender, EventArgs e) {
            DialogResult salir = MessageBox.Show("¿Salir de Autoexpo?", "Autoexpo",
            MessageBoxButtons.YesNo);
            if (salir == DialogResult.Yes) {
                Application.Exit();
            } else {
                return;
            }
        }
    }
}
