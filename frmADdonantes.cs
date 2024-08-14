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
    public partial class frmADdonantes : Form
    {
        csUsuario db = new csUsuario();
        public frmADdonantes()
        {
            InitializeComponent();

            List<csUsuario> donantes = db.ObtenerDonantes();

            dgvDonante.DataSource = donantes;


            dgvDonante.Columns["Cedula"].ReadOnly = true;
            dgvDonante.Columns["Nombres"].ReadOnly = true;
            dgvDonante.Columns["Apellidos"].ReadOnly = true;
            dgvDonante.Columns["Sexo"].ReadOnly = true;
            dgvDonante.Columns["FechaNacimiento"].ReadOnly = true;
            dgvDonante.Columns["TipoSangre"].ReadOnly = true;

            DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            botonModificar.Name = "Modificar";
            botonModificar.HeaderText = "Modificar";
            botonModificar.Text = "Guardar";
            botonModificar.UseColumnTextForButtonValue = true;

            dgvDonante.Columns.Add(botonModificar);

            //Centrar dgv
            int xDgv = (this.ClientSize.Width - dgvDonante.Width) / 2;
            int yDgv = (this.ClientSize.Height - dgvDonante.Height) / 2;
            dgvDonante.Location = new Point(xDgv, yDgv);


            //Centar Titulo
            int xTitulo = (pTituloDonantes.Width - label1.Width) / 2;
            int yTitulo = (pTituloDonantes.Height - label1.Height) / 2;
            label1.Location = new Point(xTitulo, yTitulo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmADdonantes_Load(object sender, EventArgs e)
        {

        }

        private void dgvDonante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDonante.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDonante.Rows[e.RowIndex];

                db.Ciudad = fila.Cells["Ciudad"].Value.ToString();
                db.Email = fila.Cells["Email"].Value.ToString();
                db.Telefono = fila.Cells["Telefono"].Value.ToString();
                db.Contraseña = fila.Cells["Contraseña"].Value.ToString();
                db.Cedula = fila.Cells["Cedula"].Value.ToString();

                db.ActualizarDonante(db);

                MessageBox.Show("Se actualizaron los datos correctamentes");

                fila.Cells["Ciudad"].Style = dgvDonante.DefaultCellStyle;
                fila.Cells["Email"].Style = dgvDonante.DefaultCellStyle;
                fila.Cells["Telefono"].Style = dgvDonante.DefaultCellStyle;
                fila.Cells["Contraseña"].Style = dgvDonante.DefaultCellStyle;
            }
        }

        private void dgvDonante_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvDonante.CurrentCell.Tag = dgvDonante.CurrentCell.Value;
        }

        private void dgvDonante_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle estiloModificado = new DataGridViewCellStyle();

            DataGridViewCell celda = dgvDonante.Rows[e.RowIndex].Cells[e.ColumnIndex];

            estiloModificado.BackColor = Color.LightGreen;

            if (celda.Value != null && !celda.Value.Equals(celda.Tag))
            {
                celda.Style = estiloModificado;
            }
            else
            {
                celda.Style = dgvDonante.DefaultCellStyle;
            }
        }

        private void frmADdonantes_SizeChanged(object sender, EventArgs e)
        {
            //Centrar dgv
            int xDgv = (this.ClientSize.Width - dgvDonante.Width) / 2;
            int yDgv = (this.ClientSize.Height - dgvDonante.Height) / 2;
            dgvDonante.Location = new Point(xDgv, yDgv);


            //Centar Titulo
            int xTitulo = (pTituloDonantes.Width - label1.Width) / 2;
            int yTitulo = (pTituloDonantes.Height - label1.Height) / 2;
            label1.Location = new Point(xTitulo, yTitulo);
        }
    }
}
