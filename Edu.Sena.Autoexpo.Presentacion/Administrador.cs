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

        public void ActualizarTablas() {
            try {
                this.vistaClienteTableAdapter.ClearBeforeFill = true;
                this.vistaClienteTableAdapter.Fill(this.autoexpoVistaDataSet.VistaCliente);
                this.vistaAutoCompletoTableAdapter.ClearBeforeFill = true;
                this.vistaAutoCompletoTableAdapter.Fill(this.autoexpoVistaDataSet.VistaAutoCompleto);
                //this.vistaVentaCompletoTableAdapter.ClearBeforeFill = true;
                //this.vistaVentaCompletoTableAdapter.Fill(this.autoexpoVistaDataSet.VistaVentaCompleto);
                this.vistaVentaCompletoTableAdapter1.ClearBeforeFill = true;
                this.vistaVentaCompletoTableAdapter1.Fill(this.ventaDataSet.VistaVentaCompleto);
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
        }

        private void Administrador_Load(object sender, EventArgs e) {
            ActualizarTablas();
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
