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
    public partial class frmInventario : Form
    {
        csInventario db = new csInventario();
        public frmInventario()
        {
            InitializeComponent();

            List<csInventario> inventario = db.ConsultarInventario();

            dgvInventario.DataSource = inventario;

            // Evitar que se modifiquen ciertas columnas
            dgvInventario.Columns["IDInventario"].ReadOnly = true;
            dgvInventario.Columns["TipoSangre"].ReadOnly = true;
            dgvInventario.Columns["FechaIngreso"].ReadOnly = true;
            dgvInventario.Columns["FechaExpiracion"].ReadOnly = true;

            // Agregar botón para guardar cambios
            DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            botonModificar.Name = "Modificar";
            botonModificar.HeaderText = "Modificar";
            botonModificar.Text = "Guardar";
            botonModificar.UseColumnTextForButtonValue = true;

            if (!dgvInventario.Columns.Contains("Modificar"))
            {
                dgvInventario.Columns.Add(botonModificar);
            }

            // Centrar el DataGridView
            int xDgv = (this.ClientSize.Width - dgvInventario.Width) / 2;
            int yDgv = (this.ClientSize.Height - dgvInventario.Height) / 2;
            dgvInventario.Location = new Point(xDgv, yDgv);
        }

        private void dgvRespuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventario.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

                // Obtener los valores editados
                int idInventario = Convert.ToInt32(fila.Cells["IDInventario"].Value);
                string nuevoEstado = fila.Cells["Estado"].Value.ToString();
                string nuevaUbicacion = fila.Cells["Ubicacion"].Value.ToString();

                // Actualizar la base de datos
                csInventario inventario = new csInventario();
                inventario.ActualizarInventario(idInventario, nuevoEstado, nuevaUbicacion);

                MessageBox.Show("Se actualizaron los datos correctamente");

                // Opcional: Aplicar estilo después de guardar
                fila.Cells["Estado"].Style = dgvInventario.DefaultCellStyle;
                fila.Cells["Ubicacion"].Style = dgvInventario.DefaultCellStyle;
            }
        }

        private void dgvInventario_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvInventario.CurrentCell.Tag = dgvInventario.CurrentCell.Value;
        }

        private void dgvInventario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle estiloModificado = new DataGridViewCellStyle();

            DataGridViewCell celda = dgvInventario.Rows[e.RowIndex].Cells[e.ColumnIndex];

            estiloModificado.BackColor = Color.LightGreen;

            if (celda.Value != null && !celda.Value.Equals(celda.Tag))
            {
                celda.Style = estiloModificado;
            }
            else
            {
                celda.Style = dgvInventario.DefaultCellStyle;
            }
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarNuevo frmAgregar = new frmAgregarNuevo();
            this.Hide();
            frmAgregar.Show();
        }
    }
}
