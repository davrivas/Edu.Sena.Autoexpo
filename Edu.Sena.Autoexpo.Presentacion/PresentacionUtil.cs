using Edu.Sena.Autoexpo.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Autoexpo.Presentacion {
    public class PresentacionUtil {
        private static Index index = new Index();

        public static Index Index { get => index; set => index = value; }

        public static void CerrarSesion(Form este) {
            LogicaUtil.Sesion = null;
            Index.Show();
            este.Close();
        }

        public static void ConfirmarCerrarSesion(Form este) {
            DialogResult logout = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión",
            MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes) {
                CerrarSesion(este);
            } else {
                return;
            }
        }
    }
}
