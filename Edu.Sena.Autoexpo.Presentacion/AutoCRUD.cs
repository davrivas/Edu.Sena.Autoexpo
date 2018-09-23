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
    public partial class AutoCRUD : Form {
        public AutoCRUD() {
            InitializeComponent();
        }

        private void AutoCRUD_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tablasDataSet.Marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.tablasDataSet.Marca);

        }

        public void MostrarAgregar() {
            this.Show();
            lblAutoCRUD.Text = "Agregar auto";
            MostrarControles();
            btnCRUD.Text = "Agregar auto";
        }

        public void MostrarEditarEliminar(string accion) {
            this.Show();
            lblAutoCRUD.Text = accion + " auto";
            lblId.Show();
            tbId.Show();
            btnBuscar.Show();
        }

        public void MostrarControles() {
            lblPlaca.Show();
            tbPlaca.Show();
            lblPuertas.Show();
            cbPuertas.Show();
            lblColor.Show();
            tbColor.Show();
            lblPrecio.Show();
            tbPrecio.Show();
            lblMarca.Show();
            cbMarca.Show();
            btnCRUD.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e) {

        }
    }
}
