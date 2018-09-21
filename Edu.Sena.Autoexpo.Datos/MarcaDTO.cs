using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Datos {
    public class MarcaDTO {
        private int id;
        private string marca;

        public MarcaDTO() {
        }

        public MarcaDTO(int id, string marca) {
            this.Id = id;
            this.Marca = marca;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
