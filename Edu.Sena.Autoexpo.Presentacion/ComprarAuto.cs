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
    public partial class ComprarAuto : Form {
        private AutoDTO auto;

        public ComprarAuto() {
            InitializeComponent();
            lblColor.Hide();
            lblMarca.Hide();
            lblModelo.Hide();
            lblPlaca.Hide();
            lblPrecio.Hide();
            lblPuertas.Hide();
            btnComprar.Hide();
        }

        private void BtnBuscar_Click(object sender, EventArgs e) {
            string autoIdString = tbId.Text.Trim();

            if (autoIdString.Equals("")) {
                MessageBox.Show("Ingrese el Id del auto a comprar");
            } else {
                int autoId = Convert.ToInt32(autoIdString);
                auto = LogicaUtil.ADAO.BuscarDisponible(autoId);

                if (auto != null) {
                    lblColor.Show();
                    lblColor.Text = "Color: " + auto.Color;
                    lblMarca.Show();
                    lblMarca.Text = "Marca: " + auto.Marca.Marca;
                    lblModelo.Show();
                    lblModelo.Text = "Modelo: " + auto.Modelo;
                    lblPlaca.Show();
                    lblPlaca.Text = "Placa: " + auto.Placa;
                    lblPrecio.Show();
                    lblPrecio.Text = "Precio: $" + auto.Precio.ToString();
                    lblPuertas.Show();
                    lblPuertas.Text = "# de puertas: " + auto.NumeroPuertas.ToString();
                    btnComprar.Show();
                }
            }
        }

        private void BtnComprar_Click(object sender, EventArgs e) {
            double precioAuto = auto.Precio,
                iva = precioAuto * 0.16;
            VentaDTO nuevaVenta = new VentaDTO {
                Iva = iva,
                Total = precioAuto + iva,
                Cliente = LogicaUtil.Sesion,
                Auto = auto
            };

            LogicaUtil.VDAO.Ingresar(nuevaVenta);
            PresentacionUtil.Index.VentanaCliente.ActualizarTablas();
            this.Close();
        }
    }
}
