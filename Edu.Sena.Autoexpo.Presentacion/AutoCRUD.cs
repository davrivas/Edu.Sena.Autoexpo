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
            OcultarTodo();
        }

        private void AutoCRUD_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tablasDataSet.Marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.tablasDataSet.Marca);

        }

        private void OcultarTodo() {
            lblId.Hide();
            tbId.Hide();
            btnBuscar.Hide();
            OcultarEtiquetasControles();
        }

        public void MostrarAgregar() {
            this.Text = "Agregar auto";
            lblAutoCRUD.Text = "Agregar auto";
            MostrarEtiquetas();
            MostrarControles();
            btnCRUD.Text = "Agregar auto";
            btnCRUD.Show();
        }

        public void MostrarEditarEliminar(string accion) {
            this.Text = accion + " auto";
            lblAutoCRUD.Text = accion + " auto";
            lblId.Show();
            tbId.Show();
            btnBuscar.Show();
        }

        private void MostrarEtiquetas() {
            lblPlaca.Show();
            lblModelo.Show();
            lblPuertas.Show();
            lblColor.Show();
            lblPrecio.Show();
            lblMarca.Show();
        }

        private void MostrarControles() {
            tbPlaca.Show();
            cbModelo.Show();
            cbPuertas.Show();
            tbColor.Show();
            tbPrecio.Show();
            cbMarca.Show();
        }

        private void OcultarEtiquetasControles() {
            lblPlaca.Hide();
            tbPlaca.Hide();
            lblModelo.Hide();
            cbModelo.Hide();
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
                OcultarEtiquetasControles();
                MessageBox.Show("Debe digitar el Id del auto");
            } else {
                int id = Convert.ToInt32(autoIdString);
                auto = LogicaUtil.ADAO.BuscarPorId(id);

                if (auto != null) {
                    if (lblAutoCRUD.Text.Trim().Equals("Editar auto")) {
                        MostrarEtiquetas();
                        MostrarControles();
                        ActualizarControles(auto);
                    } else {
                        MostrarEtiquetas();
                        lblPlaca.Text = "Placa: " + auto.Placa;
                        lblModelo.Text = "Modelo: " + auto.Modelo;
                        lblPuertas.Text = "# de puertas: " + auto.NumeroPuertas;
                        lblColor.Text = "Color: " + auto.Color;
                        lblPrecio.Text = "Precio: " + auto.Precio;
                        lblMarca.Text = "Marca: " + auto.Marca.Marca;
                        btnCRUD.Text = "Eliminar auto";
                    }
                } else {
                    OcultarEtiquetasControles();
                }                
            }
        }

        private void BtnCRUD_Click(object sender, EventArgs e) {
            string placa = tbPlaca.Text.Trim(),
                modelo = cbModelo.SelectedItem.ToString().Trim(),
                puertas = cbPuertas.SelectedItem.ToString().Trim(),
                color = tbColor.Text.Trim(),
                precio = tbPrecio.Text.Trim();
            int marcaId = Convert.ToInt32(cbMarca.SelectedValue.ToString().Trim());
            
            if ((tbPlaca.Text.Equals("") || cbModelo.SelectedItem.Equals("") ||
                cbPuertas.SelectedItem.Equals("") || tbColor.Text.Equals("") ||
                tbPrecio.Text.Equals(""))) {
                MessageBox.Show("Llene todos los campos", "ERROR");
            } else {
                switch (btnCRUD.Text) {
                    case "Agregar auto":
                        auto = new AutoDTO {
                            Placa = placa,
                            Modelo = modelo,
                            NumeroPuertas = Convert.ToInt32(puertas),
                            Color = color,
                            Precio = Convert.ToDouble(precio),
                            Marca = LogicaUtil.MDAO.BuscarPorId(marcaId)
                        };
                        LogicaUtil.ADAO.Ingresar(auto);
                        break;
                    case "Editar auto":
                        LogicaUtil.ADAO.Editar(auto);
                        break;
                }
            }

            switch (btnCRUD.Text) {
                case "Eliminar auto":
                    DialogResult confirmar = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión",
                        MessageBoxButtons.YesNo);
                    if (confirmar == DialogResult.Yes) {
                        LogicaUtil.ADAO.Eliminar(auto);
                    } else {
                        return;
                    }
                    break;
            }

            this.Close();
        }
    }
}
