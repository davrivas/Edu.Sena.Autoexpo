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
            if (tbDocumentoIniciarSesion.Text.Equals("") || tbClaveIniciarSesion.Text.Equals("")) {
                MessageBox.Show("Llene todos los campos");
            } else {
                MessageBox.Show("Bien");
            }
        }
    }
}
