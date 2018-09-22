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

        internal static AutoDAO ADAO { get => aDAO; set => aDAO = value; }
        internal static EstadoAutoDAO EaDAO { get => eaDAO; set => eaDAO = value; }
        internal static MarcaDAO MDAO { get => mDAO; set => mDAO = value; }
        internal static RolDAO RDAO { get => rDAO; set => rDAO = value; }
        internal static UsuarioDAO UDAO { get => uDAO; set => uDAO = value; }
        internal static VentaDAO VDAO { get => vDAO; set => vDAO = value; }
    }
}
