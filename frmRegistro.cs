using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Banco
{
    public partial class frmRegistro : Form
    {
        int edad;
        private const string connectionString = "Data Source=.;DataBase = Banco;User id = sa;Password = 123456";
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
        private bool CedulaEnUso(SqlConnection connection, string cedula)
        {
            string query = "SELECT COUNT(*) FROM Donantes WHERE Cédula = @Cedula";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cedula", cedula);

            int count = (int)command.ExecuteScalar();

            return count > 0;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
            string.IsNullOrWhiteSpace(cmbGenero.Text) || string.IsNullOrWhiteSpace(cmbSangre.Text) ||
            string.IsNullOrWhiteSpace(cmbCiudad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.");
                return false;
            }

            // Validar Cedula
            if (!Regex.IsMatch(txtCedula.Text, @"^\d+$"))
            {
                MessageBox.Show("La cédula solo debe contener números.");
                return false;
            }

            // Validar Nombres y Apellidos
            // Validación del nombre  
            if (!Regex.IsMatch(txtNombre.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras y espacios.");
                return false;
            }

            // Validación del apellido  
            if (!Regex.IsMatch(txtApellido.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El apellido solo debe contener letras y espacios.");
                return false;
            }

            if (edad > 65)
            {
                MessageBox.Show("Lo sentimos, pero no es recomendable ser donante de sangre si tienes más de 65 años de edad.");
                return false;
            }
            if (edad < 17)
            {
                MessageBox.Show("Lo sentimos, pero no es recomendable ser donante de sangre si tienes menos de 17 años de edad.");
                return false;
            }

            // Validar Email
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("El email no es válido.");
                return false;
            }

            // Validar Telefono
            if (!Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
            {
                MessageBox.Show("El teléfono solo debe contener números.");
                return false;
            }
            // Validar cantidad de números en el teléfono
            if (txtTelefono.Text.Length < 10)
            {
                MessageBox.Show("El teléfono debe contener al menos 10 números.");
                return false;
            }

            if (dptFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.");
                return false;
            }

            return true;
        }

        private bool EsCedulaValida(string cedula)
        {
            if (cedula.Length != 10 || !cedula.All(char.IsDigit))
            {
                MessageBox.Show("La cédula debe contener 10 dígitos numéricos.");
                return false;
            }

            int[] digitos = cedula.Take(9).Select(c => int.Parse(c.ToString())).ToArray();

            int sumaPares = 0;
            int sumaImpares = 0;

            for (int i = 0; i < digitos.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int resultado = digitos[i] * 2;
                    sumaImpares += resultado > 9 ? resultado - 9 : resultado;
                }
                else
                {
                    sumaPares += digitos[i];
                }
            }

            int sumaTotal = sumaPares + sumaImpares;

            int verificadorCalculado = (sumaTotal % 10 == 0) ? 0 : 10 - (sumaTotal % 10);

            int verificadorCedula = int.Parse(cedula.Substring(9, 1));

            if (verificadorCedula != verificadorCalculado)
            {
                MessageBox.Show("La cédula no es válida, no es una cedula real.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                // Verificar si la dirección de correo electrónico es válida
                if (addr.Address != email)
                    return false;

                // Verificar si el dominio termina en ".com" o ".edu.ec"
                string[] validDomains = { ".com", ".edu.ec" };
                foreach (string domain in validDomains)
                {
                    if (email.EndsWith(domain))
                        return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (CedulaEnUso(connection, txtCedula.Text))
                    {
                        MessageBox.Show("La cédula ya está en uso. Por favor, utiliza otra.");
                        return;
                    }
                    if (ValidarCampos() && EsCedulaValida(txtCedula.Text))
                    {
                        frmContraseña ContraForm = new frmContraseña();

                        ContraForm.Nombre = txtNombre.Text;
                        ContraForm.Apellido = txtApellido.Text;
                        ContraForm.Genero = cmbGenero.SelectedItem.ToString();
                        ContraForm.Ciudad = cmbCiudad.Text;
                        ContraForm.Cedula = txtCedula.Text;
                        ContraForm.Telefono = txtTelefono.Text;
                        ContraForm.FechaNacimiento = dptFechaNacimiento.Value;
                        ContraForm.Sangre = cmbSangre.Text;
                        ContraForm.Gmail = txtEmail.Text;

                        this.Hide();
                        ContraForm.Show();
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbGenero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbCiudad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dptFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbSangre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dptFechaNacimiento_ValueChanged_1(object sender, EventArgs e)
        {
            // Obtener la fecha de nacimiento del control DateTimePicker
            DateTime fechaNacimiento = dptFechaNacimiento.Value;

            // Calcular la edad a partir de la fecha de nacimiento
            edad = DateTime.Today.Year - fechaNacimiento.Year;

            // Restar un año si aún no ha pasado el cumpleaños en este año
            if (fechaNacimiento > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
