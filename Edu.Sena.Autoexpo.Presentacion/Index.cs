using Edu.Sena.Autoexpo.Datos;
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
        public Index() {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e) {
            string email = tbEmailIniciarSesion.Text.Trim(),
                clave = tbClaveIniciarSesion.Text.Trim();

            if (email.Equals("") || clave.Equals("")) {
                MessageBox.Show("Digite ambos campos");
            } else {
                int login = LogicaUtil.UDAO.BuscarPorDocumentoClave(email, clave);

                switch (login) {
                    case 1:
                        MessageBox.Show("Hola " + LogicaUtil.Sesion.Nombres + " " +
                            LogicaUtil.Sesion.Apellidos,
                        LogicaUtil.Sesion.Rol.Rol);
                        //switch (LogicaUtil.Sesion.Rol.Id) {
                        //    case 1:
                        //        break;
                        //    case 2:
                        //        break;
                        //}
                        break;
                    case 2:
                        MessageBox.Show("ERROR: Usuario no encontrado");
                        break;
                }
            }
        }
    }
}
