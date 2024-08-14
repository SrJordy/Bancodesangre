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
    public partial class frmDonante : Form
    {
        frmLogin frmLogin;
        string cedula;
        public frmDonante(frmLogin frmLogin, string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            this.frmLogin = frmLogin;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfo infofrom = new frmInfo();
            infofrom.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmCuestionario infofrom = new frmCuestionario(cedula);
            infofrom.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAgendarCita agendarfrom = new frmAgendarCita(cedula);
            agendarfrom.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmEditarDatos editarfrom = new frmEditarDatos(cedula);
            editarfrom.Show();
        }

        private void frmDonante_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = this.cedula;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}
