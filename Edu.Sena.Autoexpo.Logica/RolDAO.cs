using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Logica {
    class RolDAO : IDAO<RolDTO> {
        public RolDAO() {
        }

        public RolDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Rol " +
                    "WHERE RolId = " + id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    RolDTO rol = new RolDTO(
                        Convert.ToInt32(lector["RolId"].ToString().Trim()),
                        lector["Rol"].ToString().Trim()
                    );
                    return rol;
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

        public void Editar(RolDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(RolDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(RolDTO obj) {
            throw new NotImplementedException();
        }
    }
}
