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
            throw new NotImplementedException();
        }

        public void Eliminar(AutoDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(AutoDTO obj) {
            throw new NotImplementedException();
        }
    }
}
