using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Logica {
    class UsuarioDAO : IDAO<UsuarioDTO> {
        public UsuarioDAO() {
        }

        public UsuarioDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Usuario " +
                    "WHERE Usuario = " + id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    int rolId = Convert.ToInt32(lector["RolId"].ToString().Trim());
                    UsuarioDTO usuario = new UsuarioDTO(
                        Convert.ToInt32(lector["UsuarioId"].ToString().Trim()),
                        lector["Nombre"].ToString().Trim(),
                        lector["Apellido"].ToString().Trim(),
                        lector["Clave"].ToString().Trim(),
                        lector["Email"].ToString().Trim(),
                        lector["Direccion"].ToString().Trim(),
                        lector["Telefono"].ToString().Trim(),
                        LogicaUtil.RDAO.BuscarPorId(rolId)
                    );
                    return usuario;
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

        public void Editar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(UsuarioDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(UsuarioDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "INSERT INTO Usuario VALUES(" +
                    "" + obj.Id + ", " +
                    "'" + obj.Nombres + "', " +
                    "'" + obj.Apellidos + "', " +
                    "'" + obj.Clave + "', " +
                    "'" + obj.Email + "', " +
                    "'" + obj.Direccion + "', " +
                    "'" + obj.Telefono + "')";
                SqlCommand comando
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                Conexion.Cerrar();
            }
        }

        public int BuscarPorDocumentoClave(int documento, string clave) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + documento + " " +
                    "AND Clave = '" + clave + "'";
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    LogicaUtil.Sesion = new UsuarioDTO();
                    return 1;
                } else {
                    return 0;
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                return 0;
            } finally {
                Conexion.Cerrar();
            }

        }
    }
}
