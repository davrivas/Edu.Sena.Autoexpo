using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class UsuarioDTO {
        private int id;
        private string nombres;
        private string apellidos;
        private string email;
        private string clave;
        private string direccion;
        private string telefono;
        private RolDTO rol;

        public UsuarioDTO() {
        }

        public UsuarioDTO(int id, string nombres, string apellidos, string email,  string clave, string direccion, string telefono, RolDTO rol) {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Email = email;
            this.Clave = clave;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Rol = rol;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public RolDTO Rol { get => rol; set => rol = value; }
    }
}
