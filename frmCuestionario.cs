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
    public partial class frmCuestionario : Form
    {
        csCuestionario cuestionario;
        string cedula;
        public frmCuestionario(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            cuestionario = new csCuestionario();
        }

        private void frmCuestionario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarRespuestas();
        }
        private void GuardarRespuestas()
        {
            // Crear un diccionario para almacenar el ID de pregunta y la respuesta
            var respuestas = new Dictionary<int, int>();

            // Agregar las respuestas al diccionario
            respuestas.Add(1, cbSi1.Checked ? 1 : 0);
            respuestas.Add(2, cbSi2.Checked ? 1 : 0);
            respuestas.Add(3, cbSi3.Checked ? 1 : 0);
            respuestas.Add(4, cbSi4.Checked ? 1 : 0);
            respuestas.Add(5, cbSi5.Checked ? 1 : 0);
            respuestas.Add(6, cbSi6.Checked ? 1 : 0);
            respuestas.Add(7, cbSi7.Checked ? 1 : 0);
            respuestas.Add(8, cbSi8.Checked ? 1 : 0);
            respuestas.Add(9, cbSi9.Checked ? 1 : 0);
            respuestas.Add(10, cbSi10.Checked ? 1 : 0);

            // Guardar las respuestas en la base de datos
            foreach (var respuesta in respuestas)
            {
                cuestionario.GuardarRespuesta(cedula, respuesta.Key, respuesta.Value);
            }

            MessageBox.Show("Respuestas guardadas correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cbSi1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi1.Checked)
            {
                cbNo1.Checked = false;
            }
        }
        private void cbNo1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo1.Checked)
            {
                cbSi1.Checked = false;
            }
        }

        private void cbSi2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi2.Checked)
            {
                cbNo2.Checked = false;
            }
        }

        private void cbNo2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo2.Checked)
            {
                cbSi2.Checked = false;
            }
        }

        private void cbSi3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi3.Checked)
            {
                cbNo3.Checked = false;
            }
        }

        private void cbNo3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo3.Checked)
            {
                cbSi3.Checked = false;
            }
        }

        private void cbSi4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi4.Checked)
            {
                cbNo4.Checked = false;
            }
        }

        private void cbNo4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo4.Checked)
            {
                cbSi4.Checked = false;
            }
        }

        private void cbSi5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi5.Checked)
            {
                cbNo5.Checked = false;
            }
        }

        private void cbNo5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo5.Checked)
            {
                cbSi5.Checked = false;
            }
        }

        private void cbSi6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi6.Checked)
            {
                cbNo6.Checked = false;
            }
        }

        private void cbNo6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo6.Checked)
            {
                cbSi6.Checked = false;
            }
        }

        private void cbSi7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi7.Checked)
            {
                cbNo7.Checked = false;
            }
        }

        private void cbNo7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo7.Checked)
            {
                cbSi7.Checked = false;
            }
        }

        private void cbSi8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi8.Checked)
            {
                cbNo8.Checked = false;
            }
        }

        private void cbNo8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo8.Checked)
            {
                cbSi8.Checked = false;
            }
        }

        private void cbSi9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi9.Checked)
            {
                cbNo9.Checked = false;
            }
        }

        private void cbNo9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo9.Checked)
            {
                cbSi9.Checked = false;
            }
        }

        private void cbSi10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSi10.Checked)
            {
                cbNo10.Checked = false;
            }
        }

        private void cbNo10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo10.Checked)
            {
                cbSi10.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
