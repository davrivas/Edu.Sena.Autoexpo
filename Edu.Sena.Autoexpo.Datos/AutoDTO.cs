using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class AutoDTO {
        private int id;
        private string placa;
        private string modelo;
        private int numeroPuertas;
        private string color;
        private double precio;
        private MarcaDTO marca;
        private EstadoAutoDTO estado;

        public AutoDTO() {
        }

        public AutoDTO(int id, string placa, string modelo, int numeroPuertas, string color, double precio, MarcaDTO marca, EstadoAutoDTO estado) {
            this.Id = id;
            this.Placa = placa;
            this.Modelo = modelo;
            this.NumeroPuertas = numeroPuertas;
            this.Color = color;
            this.Precio = precio;
            this.Marca = marca;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int NumeroPuertas { get => numeroPuertas; set => numeroPuertas = value; }
        public string Color { get => color; set => color = value; }
        public double Precio { get => precio; set => precio = value; }
        public MarcaDTO Marca { get => marca; set => marca = value; }
        public EstadoAutoDTO Estado { get => estado; set => estado = value; }
    }
}
