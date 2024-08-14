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
    public partial class frmAgendarCita : Form
    {
        csCita cita;
        string cedula;
        public frmAgendarCita(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            cita = new csCita();
        }

        private void lbllunes_Click(object sender, EventArgs e)
        {

        }

        private void frmAgendarCita_Load(object sender, EventArgs e)
        {
            txtCedula.Text = cedula;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = dptFecha.Value;

            // Verificar si ya existe una cita para el mismo día y hora
            if (cita.ExisteCitaMismaFechaHora(cedula, fechaHora))
            {
                MessageBox.Show("Ya existe una cita programada para el mismo día y hora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si ya existe una cita
            }

            bool seRegistro = cita.insertarCita(cedula, fechaHora);

            if (seRegistro)
            {
                MessageBox.Show("La cita se registró correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dptFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dptFecha.Value;
            DayOfWeek selectedDay = selectedDateTime.DayOfWeek;

            // Verificar si la fecha seleccionada es sábado o domingo
            if (selectedDay == DayOfWeek.Saturday || selectedDay == DayOfWeek.Sunday)
            {
                // Agregar días adicionales para seleccionar un día hábil
                int daysToAdd = (selectedDay == DayOfWeek.Sunday) ? 2 : 1;
                DateTime newDateTime = selectedDateTime.AddDays(daysToAdd);
                dptFecha.Value = newDateTime;
            }

            int selectedHour = (int)nudHora.Value;

            DateTime newDateWithHour = new DateTime(selectedDateTime.Year, selectedDateTime.Month, selectedDateTime.Day, selectedHour, 0, 0);
            dptFecha.Value = newDateWithHour;
        }

        private void dptFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void nudHora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void nudHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
