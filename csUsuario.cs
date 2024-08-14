using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    internal class csUsuario
    {
        csConexion conexion;

        public string Cedula { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string TipoSangre { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;

        public csUsuario()
        {
            conexion = new csConexion();
        }

        public bool Login(string cedula, string contraseña)
        {
            bool verificar = false;

            conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM Donantes WHERE Cédula = @cedula AND Contraseña = @contraseña", conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.ExecuteNonQuery();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                verificar = true;

            }
            reader.Close();
            conexion.CerrarConexion();

            return verificar;
        }


        public bool Registrarse(string cedula, string nombres, string apellidos, string sexo, DateTime fechaNacimiento, int edad, string ciudad, string direccion, string email, string telefono, string tipoSangre, string contrasenia)
        {
            try
            {
                conexion.AbrirConexion();

                // Verifica si la cédula ya está registrada
                string sqlQuery = $"SELECT COUNT(*) FROM Donantes WHERE Cédula = '{cedula}'";
                SqlCommand command = new SqlCommand(sqlQuery, conexion.ObtenerConexion());
                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("La cédula ya está registrada.");
                    return false;
                }

                // Inserta el nuevo registro con todos los campos
                sqlQuery = @"INSERT INTO Donantes (Cédula, Nombres, Apellidos, Sexo, FechaNacimiento, Edad, Ciudad, Direccion, Email, Teléfono, TipoSangre, Contraseña)
                    VALUES (@Cedula, @Nombres, @Apellidos, @Sexo, @FechaNacimiento, @Edad, @Ciudad, @Direccion, @Email, @Telefono, @TipoSangre, @Password)";

                command = new SqlCommand(sqlQuery, conexion.ObtenerConexion());
                command.Parameters.AddWithValue("@Cedula", cedula);
                command.Parameters.AddWithValue("@Nombres", nombres);
                command.Parameters.AddWithValue("@Apellidos", apellidos);
                command.Parameters.AddWithValue("@Sexo", sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@Edad", edad);
                command.Parameters.AddWithValue("@Ciudad", ciudad);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@TipoSangre", tipoSangre);
                command.Parameters.AddWithValue("@Password", contrasenia);

                int result = command.ExecuteNonQuery();

                conexion.CerrarConexion();

                if (result > 0)
                {
                    MessageBox.Show("Usuario registrado con éxito.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
                return false;
            }
        }

        public List<csUsuario> ObtenerDonantes()
        {
            List<csUsuario> donantes = new List<csUsuario>();

            conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand("SELECT * FROM Donantes", conexion.ObtenerConexion());
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                csUsuario donante = new csUsuario();
                if (reader.IsDBNull(0))
                    donante.Cedula = "";
                else
                    donante.Cedula = reader.GetString(0);
                if (reader.IsDBNull(1))
                    donante.Nombres = "";
                else
                    donante.Nombres = reader.GetString(1);
                if (reader.IsDBNull(2))
                    donante.Apellidos = "";
                else
                    donante.Apellidos = reader.GetString(2);
                if (reader.IsDBNull(3))
                    donante.Sexo = "";
                else
                    donante.Sexo = reader.GetString(3);
                if (reader.IsDBNull(4))
                    donante.FechaNacimiento = DateTime.MinValue;
                else
                    donante.FechaNacimiento = reader.GetDateTime(4);
                if (reader.IsDBNull(5))
                    donante.Ciudad = "";
                else
                    donante.Ciudad = reader.GetString(5);
                if (reader.IsDBNull(6))
                    donante.Email = "";
                else
                    donante.Email = reader.GetString(6);
                if (reader.IsDBNull(7))
                    donante.Telefono = "";
                else
                    donante.Telefono = reader.GetString(7);
                if (reader.IsDBNull(8))
                    donante.TipoSangre = "";
                else
                    donante.TipoSangre = reader.GetString(8);
                if (reader.IsDBNull(9))
                    donante.Contraseña = "";
                else
                    donante.Contraseña = reader.GetString(9);
                donantes.Add(donante);
            }
            reader.Close();
            conexion.CerrarConexion();

            return donantes;
        }

        public void ActualizarDonante(csUsuario donante)
        {
            conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand("UPDATE Donantes SET Ciudad=@Ciudad, Email=@Email, Telefono=@Telefono, TipoSangre=@TipoSangre, Contraseña=@Contraseña WHERE Cédula=@Cedula", conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Cedula", donante.Cedula);
            comando.Parameters.AddWithValue("@Ciudad", donante.Ciudad);
            comando.Parameters.AddWithValue("@Email", donante.Email);
            comando.Parameters.AddWithValue("@Telefono", donante.Telefono);
            comando.Parameters.AddWithValue("@TipoSangre", donante.TipoSangre);
            comando.Parameters.AddWithValue("@Contraseña", donante.Contraseña);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public bool EditarDatos(string cedula, string ciudad, string email, string telefono)
        {
            try
            {
                conexion.AbrirConexion();

                // Obtiene los nombres, apellidos, sexo y tipo de sangre del donante
                string sqlQuery = $"SELECT Nombres, Apellidos, Sexo, TipoSangre FROM Donantes WHERE Cédula = '{cedula}'";
                SqlCommand command = new SqlCommand(sqlQuery, conexion.ObtenerConexion());
                SqlDataReader reader = command.ExecuteReader();

                string nombres = "";
                string apellidos = "";
                string sexo = "";
                string tiposangre = "";

                if (reader.Read())
                {
                    nombres = reader["Nombres"].ToString();
                    apellidos = reader["Apellidos"].ToString();
                    sexo = reader["Sexo"].ToString();
                    tiposangre = reader["TipoSangre"].ToString();
                }

                reader.Close();

                // Actualiza el registro con los nuevos datos
                sqlQuery = @"UPDATE Donantes SET Ciudad = @Ciudad, Email = @Email, Telefono = @Telefono WHERE Cédula = @Cedula";

                command = new SqlCommand(sqlQuery, conexion.ObtenerConexion());
                command.Parameters.AddWithValue("@Ciudad", ciudad);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Cedula", cedula);

                int result = command.ExecuteNonQuery();

                conexion.CerrarConexion();

                if (result > 0)
                {
                    MessageBox.Show($"Los datos de {nombres} {apellidos} se han actualizado correctamente. Su tipo de sangre es {tiposangre}.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
                return false;
            }
        }
    }
}
