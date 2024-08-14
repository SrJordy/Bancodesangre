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
    public partial class frmAgregarNuevo : Form
    {
        public frmAgregarNuevo()
        {
            InitializeComponent();
        }

        private void frmAgregarNuevo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            // Validar y obtener datos del formulario
            string tipoSangre = cmbTipoSangre.Text;
            string estado = cmbEstado.Text;
            string ubicacion = txtUbicacion.Text;
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            DateTime fechaExpiracion = dtpFechaCaducidad.Value;

            // Llamar al método para agregar un nuevo registro en la base de datos
            csInventario nuevoInventario = new csInventario();
            nuevoInventario.AgregarInventario(tipoSangre, estado, ubicacion, fechaIngreso, fechaExpiracion);

            MessageBox.Show("Nuevo componente agregado exitosamente");
            this.Close();
        }

        private void cmbTipoSangre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtUbicacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtpFechaIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtpFechaCaducidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
