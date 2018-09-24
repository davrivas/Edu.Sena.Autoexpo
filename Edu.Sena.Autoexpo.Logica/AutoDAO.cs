using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Autoexpo.Logica {
    public class AutoDAO : IDAO<AutoDTO> {
        public AutoDAO() {
        }

        public AutoDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Auto " +
                    "WHERE AutoId = " + id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    int marcaId = Convert.ToInt32(lector["MarcaId"].ToString().Trim()),
                        estadoAutoId = Convert.ToInt32(lector["EstadoAutoId"].ToString().Trim());
                    AutoDTO auto = new AutoDTO(
                        Convert.ToInt32(lector["AutoId"].ToString().Trim()),
                        lector["Placa"].ToString().Trim(),
                        lector["Modelo"].ToString().Trim(),
                        Convert.ToInt32(lector["NumeroPuertas"].ToString().Trim()),
                        lector["Color"].ToString().Trim(),
                        Convert.ToDouble(lector["Precio"].ToString().Trim()),
                        LogicaUtil.MDAO.BuscarPorId(marcaId),
                        LogicaUtil.EaDAO.BuscarPorId(estadoAutoId)
                    );
                    return auto;
                } else {
                    MessageBox.Show("No se encontró auto", "ERROR");
                    return null;
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("No se encontró auto", "ERROR");
                return null;
            } finally {
                Conexion.Cerrar();
            }
        }

        public int Contar() {
            throw new NotImplementedException();
        }

        public void Editar(AutoDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "UPDATE Auto SET " +
                    "Placa = '" + obj.Placa + "', " +
                    "Modelo = '" + obj.Modelo + "', " +
                    "NumeroPuertas = " + obj.NumeroPuertas + ", " +
                    "Color = '" + obj.Color + "', " +
                    "Precio = " + obj.Precio + ", " +
                    "MarcaId = " + obj.Marca.Id + " " +
                    "WHERE AutoId = " + obj.Id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                int cont = comando.ExecuteNonQuery();

                if (cont == 1) {
                    MessageBox.Show("Edición satisfactoria");
                } else {
                    MessageBox.Show("No se pudo realizar la edición", "ERROR");
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("No se pudo realizar la edición", "ERROR");
            } finally {
                Conexion.Cerrar();
            }
        }

        public void Eliminar(AutoDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "DELETE FROM Auto " +
                    "WHERE AutoId = " + obj.Id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                int cont = comando.ExecuteNonQuery();

                if (cont == 1) {
                    MessageBox.Show("Eliminación satisfactoria");
                } else {
                    MessageBox.Show("No se pudo realizar la eliminación", "ERROR");
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("No se pudo realizar la eliminación", "ERROR");
            } finally {
                Conexion.Cerrar();
            }
        }

        public void Ingresar(AutoDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "INSERT INTO Auto VALUES(" +
                    "'" + obj.Placa + "', " +
                    "'" + obj.Modelo + "', " +
                    obj.NumeroPuertas + ", " +
                    "'" + obj.Color + "', " +
                    obj.Precio + ", " +
                    obj.Marca.Id + ", " +
                    "1)";
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                int cont = comando.ExecuteNonQuery();

                if (cont == 1) {
                    MessageBox.Show("Registro satisfactorio");
                } else {
                    MessageBox.Show("No se pudo realizar el registro", "ERROR");
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("No se pudo realizar el registro", "ERROR");
            } finally {
                Conexion.Cerrar();
            }
        }

        public void Vender(AutoDTO obj) {
            try {
                Conexion.Abrir();
                string sql = "UPDATE Auto SET " +
                    "EstadoAutoId = 2 " +
                    "WHERE AutoId = " + obj.Id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                int cont = comando.ExecuteNonQuery();

                if (cont == 1) {
                    MessageBox.Show("El auto ya no se encuentra disponible en el concesionario");
                } else {
                    MessageBox.Show("No se pudo realizar el cambio de estado del auto", "ERROR");
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("No se pudo realizar el cambio de estado del auto", "ERROR");
            } finally {
                Conexion.Cerrar();
            }
        }

        public AutoDTO BuscarDisponible(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Auto " +
                    "WHERE AutoId = " + id + " " +
                    "AND EstadoAutoId = 1";
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    int marcaId = Convert.ToInt32(lector["MarcaId"].ToString().Trim()),
                        estadoAutoId = Convert.ToInt32(lector["EstadoAutoId"].ToString().Trim());
                    AutoDTO auto = new AutoDTO(
                        Convert.ToInt32(lector["AutoId"].ToString().Trim()),
                        lector["Placa"].ToString().Trim(),
                        lector["Modelo"].ToString().Trim(),
                        Convert.ToInt32(lector["NumeroPuertas"].ToString().Trim()),
                        lector["Color"].ToString().Trim(),
                        Convert.ToDouble(lector["Precio"].ToString().Trim()),
                        LogicaUtil.MDAO.BuscarPorId(marcaId),
                        LogicaUtil.EaDAO.BuscarPorId(estadoAutoId)
                    );
                    return auto;
                } else {
                    MessageBox.Show("No se encontró auto disponible", "ERROR");
                    return null;
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("No se encontró auto disponible", "ERROR");
                return null;
            } finally {
                Conexion.Cerrar();
            }
        }
    }
}
