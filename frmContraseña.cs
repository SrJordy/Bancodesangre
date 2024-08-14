using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Banco
{
    public partial class frmContraseña : Form
    {
        private const string connectionString = "Data Source=.;DataBase = Banco;User id = sa;Password = 123456";
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sangre { get; set; }
        public string Gmail { get; set; }

        public frmContraseña()
        {
            InitializeComponent();
        }

        private void frmContraseña_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos()
        {
            if ( string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtConfirmarContra.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.");
                return false;
            }

            // Confirmar Contraseña
            if (txtContraseña.Text != txtConfirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;

            // Validación de la contraseña  
            if (!Regex.IsMatch(contraseña, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                // Si la contraseña no cumple con los requisitos  
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, " +
                                              "una letra minúscula, una letra mayúscula y un número.");
            }
            else
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar datos en la tabla Donantes
                    string query = "INSERT INTO Donantes VALUES (@Cedula, @Nombres, @Apellidos, @Sexo, @FechaNacimiento, @Ciudad, @Email, @Telefono, @TipoSangre, @Contraseña)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Establecer parámetros
                    command.Parameters.AddWithValue("@Cedula", Cedula);
                    command.Parameters.AddWithValue("@Nombres", Nombre.Trim());
                    command.Parameters.AddWithValue("@Apellidos", Apellido.Trim());
                    command.Parameters.AddWithValue("@Sexo", Genero.Trim());
                    command.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    command.Parameters.AddWithValue("@Ciudad", Ciudad.Trim());
                    command.Parameters.AddWithValue("@Email", Gmail);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@TipoSangre", Sangre);
                    command.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Registro exitoso");

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtConfirmarContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
