using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Logica {
    public class LogicaUtil {
        public static void Conectar() {
            Conexion.Abrir();
            Conexion.Cerrar();
        }
    }
}
