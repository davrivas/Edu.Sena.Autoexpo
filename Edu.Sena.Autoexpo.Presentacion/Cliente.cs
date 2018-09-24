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

        public void ActualizarTablas() {
            try {
                this.vistaAutoDisponibleTableAdapter.ClearBeforeFill = true;
                this.vistaAutoDisponibleTableAdapter.Fill(this.autoexpoVistaDataSet.VistaAutoDisponible);
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e) {
            PresentacionUtil.ConfirmarCerrarSesion(this);
        }

        private void Cliente_Load(object sender, EventArgs e) {
            ActualizarTablas();
        }

        private void BtnComprar_Click(object sender, EventArgs e) {
            ComprarAuto compra = new ComprarAuto();
            compra.Show();
        }
    }
}
