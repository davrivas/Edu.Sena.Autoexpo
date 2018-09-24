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
        private ComprarAuto compra = new ComprarAuto();

        public Cliente() {
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

        private void BtnCerrarSesion_Click(object sender, EventArgs e) {
            PresentacionUtil.ConfirmarCerrarSesion(this);
        }

        private void Cliente_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoexpoVistaDataSet.VistaAutoDisponible' table. You can move, or remove it, as needed.
            this.vistaAutoDisponibleTableAdapter.Fill(this.autoexpoVistaDataSet.VistaAutoDisponible);

        }

        private void BtnComprar_Click(object sender, EventArgs e) {
            ComprarAuto compra = new ComprarAuto();
            compra.Show();
        }
    }
}
