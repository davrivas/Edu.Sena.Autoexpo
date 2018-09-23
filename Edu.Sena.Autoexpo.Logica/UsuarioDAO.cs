using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Autoexpo.Logica {
    public class UsuarioDAO : IDAO<UsuarioDTO> {
        public UsuarioDAO() {
        }

        public UsuarioDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Usuario " +
                    "WHERE UsuarioId = " + id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    int rolId = Convert.ToInt32(lector["RolId"].ToString().Trim());
                    UsuarioDTO usuario = new UsuarioDTO(
                        Convert.ToInt32(lector["UsuarioId"].ToString().Trim()),
                        lector["Nombre"].ToString().Trim(),
                        lector["Apellido"].ToString().Trim(),
                        lector["Email"].ToString().Trim(), 
                        lector["Clave"].ToString().Trim(),
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
                    "'" + obj.Nombres + "', " +
                    "'" + obj.Apellidos + "', " +
                    "'" + obj.Email + "', " + 
                    "'" + obj.Clave + "', " +
                    "'" + obj.Direccion + "', " +
                    "'" + obj.Telefono + "', " +
                    "2)";
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                int cont = comando.ExecuteNonQuery();

                if (cont == 1)  {
                    MessageBox.Show("Registro satisfactorio");
                } else {
                    MessageBox.Show("No se pudo realizar registro", "ERROR");
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("No se pudo realizar registro", "ERROR");
            } finally {
                Conexion.Cerrar();
            }
        }

        public bool BuscarPorEmailClave(string email, string clave) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Usuario " +
                    "WHERE Email = '" + email + "' " +
                    "AND Clave = '" + clave + "'";
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    int rolId = Convert.ToInt32(lector["RolId"].ToString().Trim());
                    LogicaUtil.Sesion = new UsuarioDTO(
                        Convert.ToInt32(lector["UsuarioId"].ToString().Trim()),
                        lector["Nombre"].ToString().Trim(),
                        lector["Apellido"].ToString().Trim(),
                        lector["Email"].ToString().Trim(),
                        lector["Clave"].ToString().Trim(),
                        lector["Direccion"].ToString().Trim(),
                        lector["Telefono"].ToString().Trim(),
                        LogicaUtil.RDAO.BuscarPorId(rolId)
                    );
                    return true;
                } else {
                    return false;
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                return false;
            } finally {
                Conexion.Cerrar();
            }
        }
    }
}
