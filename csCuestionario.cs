using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    internal class csCuestionario
    {
        csConexion conexion;
        public int IDRespuestaText { get; set; }
        public string CedulaDonante { get; set; } = string.Empty;
        public int IDPreguntaText { get; set; }
        public bool Respuesta { get; set; }
        public csCuestionario()
        {
            conexion = new csConexion();
        }

        public List<Tuple<int, string>> CargarPreguntas()
        {
            string consulta = "SELECT IDPreguntaText, Enunciado FROM PreguntasText";

            List<Tuple<int, string>> lstPreguntas = new List<Tuple<int, string>>();
            using (SqlDataReader lector = conexion.EjecutarConsulta(consulta))
            {
                while (lector.Read())
                {
                    int idPregunta = lector.GetInt32(0);
                    string enunciado = lector.GetString(1);

                    Tuple<int, string> pregunta = new Tuple<int, string>(idPregunta, enunciado);
                    lstPreguntas.Add(pregunta);
                }
            }

            return lstPreguntas;
        }

        public void GuardarRespuesta(string cedula, int idPregunta, int respuesta)
        {
            try
            {
                // Verificar si ya existe un registro para el usuario y la pregunta actual
                string consulta = String.Format("SELECT COUNT(*) FROM Respuestas WHERE CedulaDonante = '{0}' AND IDPreguntaText = {1}", cedula, idPregunta);
                int count = conexion.EjecutarConsultaScalar(consulta);

                // Si ya existe un registro, actualizarlo
                if (count > 0)
                {
                    consulta = "UPDATE Respuestas SET Respuesta = @Respuesta WHERE CedulaDonante = @CedulaDonante AND IDPreguntaText = @IDPreguntaText";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion()))
                    {
                        // Asignar valores a los parámetros
                        //Aqui asigne de forma predeterminada el numero de cedula pero este debe ser de acuerdo al donante que inicio sesion
                        comando.Parameters.AddWithValue("@CedulaDonante", cedula); //Cedula del donante que incio sesion predeterminada.
                        comando.Parameters.AddWithValue("@IDPreguntaText", idPregunta);
                        comando.Parameters.AddWithValue("@Respuesta", respuesta);

                        // Abrir la conexión y ejecutar la consulta
                        conexion.AbrirConexion();
                        comando.ExecuteNonQuery();
                    }
                }
                // Si no existe un registro, insertar uno nuevo
                else
                {
                    consulta = "INSERT INTO Respuestas (CedulaDonante, IDPreguntaText, Respuesta) VALUES (@CedulaDonante, @IDPreguntaText, @Respuesta)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion.ObtenerConexion()))
                    {
                        // Asignar valores a los parámetros
                        comando.Parameters.AddWithValue("@CedulaDonante", cedula);
                        comando.Parameters.AddWithValue("@IDPreguntaText", idPregunta);
                        comando.Parameters.AddWithValue("@Respuesta", respuesta);

                        // Abrir la conexión y ejecutar la consulta
                        conexion.AbrirConexion();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al guardar la respuesta
                MessageBox.Show("Error al guardar la respuesta en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                conexion.CerrarConexion();
            }
        }

        public List<csCuestionario> ObtenerRespuestas()
        {
            List<csCuestionario> respuestas = new List<csCuestionario>();

            using (SqlCommand comando = new SqlCommand("SELECT * FROM Respuestas", conexion.ObtenerConexion()))
            {
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    csCuestionario respuesta = new csCuestionario();
                    respuesta.IDRespuestaText = reader.GetInt32(0);
                    respuesta.CedulaDonante = reader.GetString(1);
                    respuesta.IDPreguntaText = reader.GetInt32(2);
                    respuesta.Respuesta = reader.GetBoolean(3);
                    respuestas.Add(respuesta);
                }
                reader.Close();
                conexion.CerrarConexion();
            }

            return respuestas;
        }
    }
}
