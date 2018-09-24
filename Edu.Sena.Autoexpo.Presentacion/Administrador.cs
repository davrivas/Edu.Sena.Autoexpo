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
        private AutoCRUD crud;

        public Administrador() {
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

        private void BtnAgregar_Click(object sender, EventArgs e) {
            crud = new AutoCRUD();
            crud.Show();
            crud.MostrarAgregar();
        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            crud = new AutoCRUD();
            crud.Show();
            crud.MostrarEditarEliminar("Editar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e) {
            crud = new AutoCRUD();
            crud.Show();
            crud.MostrarEditarEliminar("Eliminar");
        }
    }
}
