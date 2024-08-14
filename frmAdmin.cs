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
    public partial class frmAdmin : Form
    {
        frmLogin frmLogin;
        string cedula;
        public frmAdmin(frmLogin frmLogin, string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            this.frmLogin = frmLogin;
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmADCitas ADCitas = new frmADCitas();
            ADCitas.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmADdonantes frmADdonantes = new frmADdonantes();
            frmADdonantes.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmInventario frmInventario = new frmInventario();
            frmInventario.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmADCuestionario frmADCuestionario = new frmADCuestionario();
            frmADCuestionario.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            frmADdonantes frmADdonantes = new frmADdonantes();
            frmADdonantes.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmInventario frmInventario = new frmInventario();
            frmInventario.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmADCitas ADCitas = new frmADCitas();
            ADCitas.Show();
        }
    }
}
