﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class VentaDTO {
        private int id;
        private double iva;
        private double total;
        private UsuarioDTO cliente;
        private AutoDTO auto;

        public VentaDTO() {
        }

        public VentaDTO(int id, double iva, double total, UsuarioDTO cliente, AutoDTO auto) {
            this.Id = id;
            this.Iva = iva;
            this.Total = total;
            this.Cliente = cliente;
            this.Auto = auto;
        }

        public int Id { get => id; set => id = value; }
        public double Iva { get => iva; set => iva = value; }
        public double Total { get => total; set => total = value; }
        public UsuarioDTO Cliente { get => cliente; set => cliente = value; }
        public AutoDTO Auto { get => auto; set => auto = value; }
    }
}
