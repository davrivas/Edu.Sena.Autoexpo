using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Autoexpo.Logica {
    class EstadoAutoDAO : IDAO<EstadoAutoDTO> {
        public EstadoAutoDAO() {
        }

        public EstadoAutoDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM EstadoAuto " +
                    "WHERE EstadoAutoId = " + id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    EstadoAutoDTO estadoAuto = new EstadoAutoDTO(
                        Convert.ToInt32(lector["EstadoAutoId"].ToString().Trim()),
                        lector["EstadoAuto"].ToString().Trim()
                    );
                    return estadoAuto;
                } else {
                    return null;
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                return null;
            } finally {
                Conexion.Cerrar();
            }
        }

        public int Contar() {
            throw new NotImplementedException();
        }

        public void Editar(EstadoAutoDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(EstadoAutoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(EstadoAutoDTO obj) {
            throw new NotImplementedException();
        }
    }
}
