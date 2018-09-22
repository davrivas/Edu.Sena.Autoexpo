using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Logica {
    public class VentaDAO : IDAO<VentaDTO> {
        private readonly double porcentajeIVA = 0.19;

        public VentaDAO() {
        }

        public VentaDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Venta " +
                    "WHERE VentaId = " + id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    int clienteId = Convert.ToInt32(lector["ClienteId"].ToString().Trim()),
                        placaAuto = Convert.ToInt32(lector["PlacaAuto"].ToString().Trim());
                    VentaDTO auto = new VentaDTO(
                        Convert.ToInt32(lector["VentaId"].ToString().Trim()),
                        Convert.ToDateTime(lector["Fecha"].ToString().Trim()),
                        Convert.ToDouble(lector["Iva"].ToString().Trim()),
                        Convert.ToDouble(lector["Total"].ToString().Trim()),
                        LogicaUtil.UDAO.BuscarPorId(clienteId),
                        LogicaUtil.ADAO.BuscarPorId(placaAuto)
                    );
                    return auto;
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

        public void Editar(VentaDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(VentaDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(VentaDTO obj) {
            throw new NotImplementedException();
        }
    }
}
