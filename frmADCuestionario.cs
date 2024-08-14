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
    public partial class frmADCuestionario : Form
    {
        csCuestionario db = new csCuestionario();
        public frmADCuestionario()
        {
            InitializeComponent();

            List<csCuestionario> datos = db.ObtenerRespuestas();

            dgvRespuestas.DataSource = datos;

            //Esto es solo para evitar que se modifiquen las celdas
            dgvRespuestas.Columns["IDRespuestaText"].ReadOnly = true;
            dgvRespuestas.Columns["CedulaDonante"].ReadOnly = true;
            dgvRespuestas.Columns["IDPreguntaText"].ReadOnly = true;
            dgvRespuestas.Columns["Respuesta"].ReadOnly = true;

            //Ajusta el tamaño del dataGridView para que se visualicen todos los campos del modelo respuesta
            int headerWidth = dgvRespuestas.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int margin = 5;
            dgvRespuestas.Width = headerWidth + dgvRespuestas.RowHeadersWidth + margin;

            //Centrar dgv
            int xDgv = (this.ClientSize.Width - dgvRespuestas.Width) / 2;
            int yDgv = (this.ClientSize.Height - dgvRespuestas.Height) / 2;
            dgvRespuestas.Location = new Point(xDgv, yDgv);


            //Centar Titulo
            int xTitulo = (pTituloDonantes.Width - label1.Width) / 2;
            int yTitulo = (pTituloDonantes.Height - label1.Height) / 2;
            label1.Location = new Point(xTitulo, yTitulo);
        }

        private void dgvRespuestas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la columna que queremos formatear es la columna "Respuesta"
            //if (dgvRespuestas.Columns[e.ColumnIndex].Name == "Respuesta")
            //{
            //    if (e.Value != null)
            //    {
            //        int respuesta = (int)e.Value;
            //        e.Value = respuesta == 1 ? "Sí" : "No";
            //        e.FormattingApplied = true;
            //    }
            //}
        }

        private void frmADCuestionario_SizeChanged(object sender, EventArgs e)
        {
            //Centrar dgv
            int xDgv = (this.ClientSize.Width - dgvRespuestas.Width) / 2;
            int yDgv = (this.ClientSize.Height - dgvRespuestas.Height) / 2;
            dgvRespuestas.Location = new Point(xDgv, yDgv);


            //Centar Titulo
            int xTitulo = (pTituloDonantes.Width - label1.Width) / 2;
            int yTitulo = (pTituloDonantes.Height - label1.Height) / 2;
            label1.Location = new Point(xTitulo, yTitulo);
        }
    }
}
