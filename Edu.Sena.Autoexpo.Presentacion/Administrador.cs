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
    public partial class Administrador : Form {
        public Administrador() {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoexpoVistaDataSet.VistaCliente' table. You can move, or remove it, as needed.
            this.vistaClienteTableAdapter.Fill(this.autoexpoVistaDataSet.VistaCliente);
            // TODO: This line of code loads data into the 'autoexpoVistaDataSet.VistaAutoCompleto' table. You can move, or remove it, as needed.
            this.vistaAutoCompletoTableAdapter.Fill(this.autoexpoVistaDataSet.VistaAutoCompleto);
            // TODO: This line of code loads data into the 'autoexpoVistaDataSet.VistaVentaCompleto' table. You can move, or remove it, as needed.
            this.vistaVentaCompletoTableAdapter.Fill(this.autoexpoVistaDataSet.VistaVentaCompleto);

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e) {
            PresentacionUtil.ConfirmarCerrarSesion(this);
        }
    }
}
