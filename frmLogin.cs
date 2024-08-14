using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmLogin : Form
    {
        csUsuario usuario;
        public frmLogin()
        {
            InitializeComponent();
            usuario = new csUsuario();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmRegistro registroForm = new frmRegistro();
            this.Hide();
            registroForm.Show();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (usuario.Login(txtUsuario.Text.ToString(), txtContra.Text.ToString()))
            {
                frmDonante menu = new frmDonante(this, txtUsuario.Text);
                this.Hide();
                menu.Show();
                
            }
            else
                MessageBox.Show("Las credenciales ingresadas son incorrectas. Por favor, vuelva a intentarlo.");
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();
            string contraseniaIngresada = txtContra.Text.Trim();

            // Verificar si el usuario y la contraseña coinciden con el administrador predefinido
            if (usuarioIngresado.Equals("0123456789") && contraseniaIngresada.Equals("Admin"))
            {
                // Acceso para el administrador predefinido
                frmAdmin menu = new frmAdmin(this, usuarioIngresado);
                this.Hide();
                menu.Show();
               
            }
            else
            {
                MessageBox.Show("Las credenciales ingresadas son incorrectas. Por favor, vuelva a intentarlo.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
