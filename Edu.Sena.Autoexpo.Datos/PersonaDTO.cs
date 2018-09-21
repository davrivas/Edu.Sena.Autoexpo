using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class PersonaDTO {
        private int id;
        private string nombres;
        private string apellidos;
        private string clave;
        private RolDTO rol;

        public PersonaDTO() {
        }

        public PersonaDTO(int id, string nombres, string apellidos, string clave, RolDTO rol) {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Clave = clave;
            this.Rol = rol;
        }

        protected int Id { get => id; set => id = value; }
        protected string Nombres { get => nombres; set => nombres = value; }
        protected string Apellidos { get => apellidos; set => apellidos = value; }
        protected string Clave { get => clave; set => clave = value; }
        public RolDTO Rol { get => rol; set => rol = value; }
    }
}
