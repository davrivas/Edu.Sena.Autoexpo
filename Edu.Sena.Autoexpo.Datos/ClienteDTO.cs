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

        public ClienteDTO() : base() {
        }

        public ClienteDTO(int id, string nombres, string apellidos, string clave, RolDTO rol, string email, string direccion, string telefono) : base(id, nombres, apellidos, clave, rol) {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Clave = clave;
            this.Rol = rol;
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
