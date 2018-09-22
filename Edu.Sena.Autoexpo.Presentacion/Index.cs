using Edu.Sena.Autoexpo.Datos;
using Edu.Sena.Autoexpo.Logica;
using Edu.Sena.Autoexpo.Presentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Sena.Autoexpo.Presentacion.Cliente;

namespace Edu.Sena.Autoexpo.Presentacion {
    public partial class Index : Form {
        public Index() {
            InitializeComponent();
        }

        private void IniciarSesion() {
            string email = tbEmailIniciarSesion.Text.Trim(),
                clave = tbClaveIniciarSesion.Text.Trim();

            if (email.Equals("") || clave.Equals("")) {
                MessageBox.Show("Digite ambos campos", "ERROR");
            } else {
                int login = LogicaUtil.UDAO.BuscarPorEmailClave(email, clave);

                switch (login) {
                    case 1:
                        MessageBox.Show("Hola " + LogicaUtil.Sesion.Nombres + " " +
                            LogicaUtil.Sesion.Apellidos,
                        LogicaUtil.Sesion.Rol.Rol);
                        switch (LogicaUtil.Sesion.Rol.Id) {
                            case 1:
                                Ventas v = new Ventas();
                                this.Hide();
                                v.Show();
                                break;
                            case 2:
                                AutosDisponibles a = new AutosDisponibles();
                                this.Hide();
                                a.Show();
                                break;
                        }
                        break;
                    case 2:
                        MessageBox.Show("ERROR: Usuario no encontrado");
                        break;
                }
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e) {
            IniciarSesion();
        }

        private void TbClaveIniciarSesion_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyValue) {
                case 13: // Cuando se oprime enter
                    IniciarSesion();
                    break;
            }
        }

        private void TbEmailIniciarSesion_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyValue) {
                case 13:
                    IniciarSesion();
                    break;
            }
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e) {
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

        private void Index_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
