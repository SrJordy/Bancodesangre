using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class csCita
    {
        csConexion conexion;
        public int CitaID { get; set; }
        public string CedulaDonante { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public bool Confirmacion { get; set; }
        public csCita()
        {
            conexion = new csConexion();
        }

        public bool insertarCita(string cedula, DateTime fecha)
        {
            try
            {
                conexion.AbrirConexion();

                SqlCommand command = new SqlCommand("INSERT INTO Citas (CedulaDonante, FechaHora) VALUES (@Cedula, @Fecha)", conexion.ObtenerConexion());

                command.Parameters.AddWithValue("@Cedula", cedula);
                command.Parameters.AddWithValue("@Fecha", fecha);

                command.ExecuteNonQuery();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Método para verificar si ya existe una cita para el mismo día y hora
        public bool ExisteCitaMismaFechaHora(string cedula, DateTime fechaHora)
        {
            try
            {
                conexion.AbrirConexion();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Citas WHERE CedulaDonante = @Cedula AND FechaHora = @FechaHora", conexion.ObtenerConexion());
                command.Parameters.AddWithValue("@Cedula", cedula);
                command.Parameters.AddWithValue("@FechaHora", fechaHora);

                int count = (int)command.ExecuteScalar();

                conexion.CerrarConexion();

                return count > 0; // Retorna true si existe al menos una cita, false en caso contrario
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public string[] ObtenerCorreo(string cedula)
        {
            string[] dato = new string[2];
            conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand("SELECT Email, Nombres FROM Donantes WHERE Cédula = @cedula", conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.ExecuteNonQuery();
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                dato[0] = reader.GetString(0);
                dato[1] = reader.GetString(1);
            }
            reader.Close();
            conexion.CerrarConexion();

            return dato;
        }

        public List<csCita> ObtenerCitas()
        {
            List<csCita> citas = new List<csCita>();

            using (SqlCommand comando = new SqlCommand("SELECT * FROM Citas", conexion.ObtenerConexion()))
            {
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    csCita cita = new csCita();
                    cita.CitaID = reader.GetInt32(0);
                    cita.CedulaDonante = reader.GetString(1);
                    cita.FechaHora = reader.GetDateTime(2);

                    if (reader.IsDBNull(3))
                        cita.Confirmacion = false;
                    else
                        cita.Confirmacion = reader.GetBoolean(3);

                    citas.Add(cita);
                }
                reader.Close();
                conexion.CerrarConexion();
            }

            return citas;
        }

        public void ActualizarCita(csCita cita)
        {
            using (SqlCommand comando = new SqlCommand("UPDATE Citas SET FechaHora=@FechaHora, Confirmacion=@Confirmacion WHERE CitaID=@CitaID", conexion.ObtenerConexion()))
            {
                conexion.AbrirConexion();
                comando.Parameters.AddWithValue("@CitaID", cita.CitaID);
                comando.Parameters.AddWithValue("@FechaHora", cita.FechaHora);
                comando.Parameters.AddWithValue("@Confirmacion", cita.Confirmacion);
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
        }
    }
}
