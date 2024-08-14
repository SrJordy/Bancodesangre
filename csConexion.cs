using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    internal class csConexion
    {
        private string server;
        private string database;
        private string user;
        private string password;
        private string Cadenaconexion;

        SqlConnection con;

        public csConexion()
        {
            try
            {

                server = ".";
                user = "sa";
                password = "123456";
                database = "Banco";

                con = new SqlConnection();

                // Definir la cadena de conexión
                Cadenaconexion = "Server = " + server + "; DataBase = " + database +
                    "; User id = " + user + "; Password = " + password;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
        }

        public int EjecutarConsultaScalar(string consulta)
        {
            //Para consultar si ya se ha realizado el formulario
            int resultado = 0;
            try
            {
                // Abrir la conexión
                AbrirConexion();

                // Crear el comando SQL
                SqlCommand comando = new SqlCommand(consulta, con);

                // Ejecutar la consulta y asignar el resultado a la variable
                resultado = (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al ejecutar la consulta
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                CerrarConexion();
            }

            // Devolver el resultado
            return resultado;
        }

        public SqlDataReader EjecutarConsulta(string consulta)
        {
            AbrirConexion();
            SqlConnection conexion = new SqlConnection(Cadenaconexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            CerrarConexion();
            return lector;
        }
        public SqlConnection ObtenerConexion()
        {
            return con;
        }
        public void AbrirConexion()
        {
            if (con.State != ConnectionState.Open)
            {
                con.ConnectionString = Cadenaconexion;
                con.Open();
            }
        }

        public void CerrarConexion()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
