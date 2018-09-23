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
    public partial class AutoCRUD : Form {
        private AutoDTO auto;

        public AutoCRUD() {
            InitializeComponent();
        }

        private void AutoCRUD_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tablasDataSet.Marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.tablasDataSet.Marca);

        }

        public void MostrarAgregar() {
            lblAutoCRUD.Text = "Agregar auto";
            MostrarControles();
            btnCRUD.Text = "Agregar auto";
        }

        public void MostrarEditarEliminar(string accion) {
            lblAutoCRUD.Text = accion + " auto";
            lblId.Show();
            tbId.Show();
            btnBuscar.Show();
        }

        private void MostrarControles() {
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

        private void OcultarControles() {
            lblPlaca.Hide();
            tbPlaca.Hide();
            lblPuertas.Hide();
            cbPuertas.Hide();
            lblColor.Hide();
            tbColor.Hide();
            lblPrecio.Hide();
            tbPrecio.Hide();
            lblMarca.Hide();
            cbMarca.Hide();
            btnCRUD.Hide();
        }

        private void ActualizarControles(AutoDTO auto) {
            tbPlaca.Text = auto.Placa;
            cbPuertas.SelectedValue = auto.NumeroPuertas;
            tbColor.Text = auto.Color;
            tbPrecio.Text = auto.Precio.ToString();
            cbMarca.SelectedValue = auto.Marca.Id;
            btnCRUD.Text = "Editar auto";
        }

        private void BtnBuscar_Click(object sender, EventArgs e) {
            string autoIdString = tbId.Text.Trim();
            if (autoIdString.Equals("")) {
                OcultarControles();
            } else {
                int id = Convert.ToInt32(autoIdString);
                auto = LogicaUtil.ADAO.BuscarPorId(id);

                if (auto != null) {
                    if (lblAutoCRUD.Text.Trim().Equals("Editar auto")) {
                        MostrarControles();
                        ActualizarControles(auto);
                    } /*else {
                        
                    }*/
                } else {
                    OcultarControles();
                }                
            }
        }
    }
}
