using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class ClienteDTO : PersonaDTO {
        private string email;
        private string direccion;
        private string telefono;

        public ClienteDTO() {
        }

        public ClienteDTO(string email, string direccion, string telefono) {
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
