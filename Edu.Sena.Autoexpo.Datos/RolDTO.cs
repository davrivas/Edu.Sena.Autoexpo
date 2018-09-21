using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class RolDTO {
        private int id;
        private string rol;

        public RolDTO() {
        }

        public RolDTO(int id, string rol) {
            this.Id = id;
            this.Rol = rol;
        }

        public int Id { get => id; set => id = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
