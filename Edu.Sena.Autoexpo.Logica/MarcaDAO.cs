using Edu.Sena.Autoexpo.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Autoexpo.Logica {
    public class MarcaDAO : IDAO<MarcaDTO> {
        public MarcaDAO() {
        }

        public MarcaDTO BuscarPorId(int id) {
            try {
                Conexion.Abrir();
                string sql = "SELECT * " +
                    "FROM Marca " +
                    "WHERE MarcaId = " + id;
                SqlCommand comando = new SqlCommand(sql, Conexion.ConexionObj);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read()) {
                    MarcaDTO marca = new MarcaDTO(
                        Convert.ToInt32(lector["MarcaId"].ToString().Trim()),
                        lector["Marca"].ToString().Trim()
                    );
                    return marca;
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

        public void Editar(MarcaDTO obj) {
            throw new NotImplementedException();
        }

        public void Eliminar(MarcaDTO obj) {
            throw new NotImplementedException();
        }

        public void Ingresar(MarcaDTO obj) {
            throw new NotImplementedException();
        }
    }
}
