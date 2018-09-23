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
    public partial class Cliente : Form {
        public Cliente() {
            InitializeComponent();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e) {
            PresentacionUtil.CerrarSesion(this);
        }

        private void Cliente_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoexpoVistaDataSet.VistaAutoDisponible' table. You can move, or remove it, as needed.
            this.vistaAutoDisponibleTableAdapter.Fill(this.autoexpoVistaDataSet.VistaAutoDisponible);

        }
    }
}
