using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Logica {
    public class LogicaUtil {
        private static UsuarioDTO sesion;

        private static AutoDAO aDAO = new AutoDAO();
        private static EstadoAutoDAO eaDAO = new EstadoAutoDAO();
        private static MarcaDAO mDAO = new MarcaDAO();
        private static RolDAO rDAO = new RolDAO();
        private static UsuarioDAO uDAO = new UsuarioDAO();
        private static VentaDAO vDAO = new VentaDAO();

        public static UsuarioDTO Sesion { get => sesion; set => sesion = value; }

        public static AutoDAO ADAO { get => aDAO; set => aDAO = value; }
        public static EstadoAutoDAO EaDAO { get => eaDAO; set => eaDAO = value; }
        public static MarcaDAO MDAO { get => mDAO; set => mDAO = value; }
        public static RolDAO RDAO { get => rDAO; set => rDAO = value; }
        public static UsuarioDAO UDAO { get => uDAO; set => uDAO = value; }
        public static VentaDAO VDAO { get => vDAO; set => vDAO = value; }
    }
}
