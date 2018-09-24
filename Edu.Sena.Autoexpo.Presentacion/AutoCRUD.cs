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
            btnCRUD.Show();
            btnCRUD.Text = "Agregar auto";
        }

        public void MostrarEditarEliminar(string accion) {
            this.Text = accion + " auto";
            lblAutoCRUD.Text = accion + " auto";
            btnCRUD.Text = accion + " auto";
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
            cbPuertas.SelectedText = Convert.ToString(auto.NumeroPuertas);
            tbColor.Text = auto.Color;
            tbPrecio.Text = Convert.ToString(auto.Precio);
            cbMarca.SelectedValue = auto.Marca.Id;
            cbModelo.SelectedText = auto.Modelo;
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
                    btnCRUD.Show();

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
                    }
                } else {
                    OcultarEtiquetasControles();
                }                
            }
        }

        private void BtnCRUD_Click(object sender, EventArgs e) {
            string placa = "", modelo = "", puertas = "", 
                color = "", precio = "";
            int marcaId = 0;

            if (btnCRUD.Text.Equals("Agregar auto") || btnCRUD.Text.Equals("Editar auto")) {
                placa = tbPlaca.Text.Trim();
                modelo = cbModelo.SelectedItem.ToString().Trim();
                puertas = cbPuertas.SelectedItem.ToString().Trim();
                color = tbColor.Text.Trim();
                precio = tbPrecio.Text.Trim();
                marcaId = Convert.ToInt32(cbMarca.SelectedValue.ToString().Trim());

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
            }

            if (btnCRUD.Text.Equals("Eliminar auto")) {
                DialogResult confirmar = MessageBox.Show("¿Desea eliminar el auto?", "Eliminar auto",
                    MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes) {
                    LogicaUtil.ADAO.Eliminar(auto);
                } else {
                    return;
                }
            }

            PresentacionUtil.Index.VentanaAdministrador.ActualizarTablas();
            this.Close();
        }
    }
}
