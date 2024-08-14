using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    internal class csInventario
    {
        csConexion conexion;
        public int IDInventario { get; set; }
        public string TipoSangre { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string Estado { get; set; } = string.Empty; // Ejemplo: "Disponible", "En uso", "Expirado"
        public string Ubicacion { get; set; } = string.Empty; // Ejemplo: "Almacén A", "Sala de operaciones", etc.

        public csInventario()
        {
            conexion = new csConexion();
        }

        // Método para agregar una nueva entrada al inventario
        public void AgregarInventario(string tipoSangre, string estado, string ubicacion, DateTime fechaIngreso, DateTime fechaExpiracion)
        {
            try
            {
                string consulta = "INSERT INTO InventarioSangre (TipoSangre, Estado, Ubicacion, FechaExtraccion, FechaVencimiento) VALUES (@TipoSangre, @Estado, @Ubicacion, @FechaIngreso, @FechaExpiracion)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion()))
                {
                    comando.Parameters.AddWithValue("@TipoSangre", tipoSangre);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@Ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                    comando.Parameters.AddWithValue("@FechaExpiracion", fechaExpiracion);

                    conexion.AbrirConexion();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el nuevo componente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        //Metodo para actualizar Inventario
        public void ActualizarInventario(int idInventario, string estado, string ubicacion)
        {
            try
            {
                string consulta = "UPDATE InventarioSangre SET Estado = @Estado, Ubicacion = @Ubicacion WHERE UnidadID = @IDInventario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion()))
                {
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@Ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@IDInventario", idInventario);

                    conexion.AbrirConexion();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Método para eliminar una entrada del inventario
        public void EliminarInventario(int idInventario)
        {
            try
            {
                string consulta = "DELETE FROM InventarioSangre WHERE UnidadID = @IDInventario";
                using (SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion()))
                {
                    comando.Parameters.AddWithValue("@IDInventario", idInventario);

                    conexion.AbrirConexion();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar del inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Método para consultar todas las entradas del inventario
        public List<csInventario> ConsultarInventario()
        {
            List<csInventario> inventario = new List<csInventario>();

            try
            {
                string consulta = "SELECT * FROM InventarioSangre";
                using (SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion()))
                {
                    conexion.AbrirConexion();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        csInventario item = new csInventario
                        {
                            IDInventario = reader.GetInt32(0),
                            TipoSangre = reader.GetString(1),
                            FechaIngreso = reader.GetDateTime(2),
                            FechaExpiracion = reader.GetDateTime(3),
                            Estado = reader.GetString(4),
                            Ubicacion = reader.GetString(5)
                        };
                        inventario.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return inventario;
        }

    }
}
