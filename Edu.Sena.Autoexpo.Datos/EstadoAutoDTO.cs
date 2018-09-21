using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class EstadoAutoDTO {
        private int id;
        private string marca;

        public EstadoAutoDTO() {
        }

        public EstadoAutoDTO(int id, string marca) {
            this.Id = id;
            this.Marca = marca;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
