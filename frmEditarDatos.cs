using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmEditarDatos : Form
    {
        csUsuario usuario;
        csCita cita;
        string cedula;
        public frmEditarDatos(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            usuario = new csUsuario();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarDatos_Load(object sender, EventArgs e)
        {

        }

        private void bttregresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(cmbCiudad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.");
                return false;
            }

            // Validar Ciudad
            if (!Regex.IsMatch(cmbCiudad.Text, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("La ciudad solo debe contener letras.");
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
            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length < 10)
            {
                txtTelefono.ForeColor = Color.Red;
                txtTelefono.Text = "El número de telefono debe tener 10 digitos";
            }
            if (ValidarCampos())
            {
                bool seRegistro = usuario.EditarDatos(cedula, cmbCiudad.Text, txtEmail.Text, txtTelefono.Text);
                if (seRegistro)
                {
                    this.Close();
                }
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.Text = null;
            txtTelefono.ForeColor = Color.Black;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
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

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
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

        private void txtTelefono_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

       
    }
}
