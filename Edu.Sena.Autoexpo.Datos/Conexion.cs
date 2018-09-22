using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Autoexpo.Datos {
    public class Conexion {
        public static SqlConnection ConexionObj { get; set; } = new SqlConnection("Data Source=DESKTOP-0S26F42\\SQLEXPRESS;Initial Catalog=Autoexpo;Integrated Security=True");

        public static void Abrir() {
            try {
                Cerrar();
                ConexionObj.Open();
                MessageBox.Show("¡Conexión exitosa!");
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("ERROR: no se pudo conectar a la base de datos");
            }
        }

        public static void Cerrar() {
            try {
                ConexionObj.Close();
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("ERROR: no se pudo cerrar la conexión a la base de datos");
            }
        }
    }
}
