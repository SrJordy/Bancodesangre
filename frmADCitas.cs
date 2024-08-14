using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Banco
{
    public partial class frmADCitas : Form
    {
        csCita db = new csCita();
        public frmADCitas()
        {
            InitializeComponent();

            List<csCita> personas = db.ObtenerCitas();
            dgvCitas.DataSource = personas;

            dgvCitas.Columns["CedulaDonante"].ReadOnly = true;
            dgvCitas.Columns["CitaID"].ReadOnly = true;

            DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            botonModificar.Name = "Modificar";
            botonModificar.HeaderText = "Modificar";
            botonModificar.Text = "Guardar";
            botonModificar.UseColumnTextForButtonValue = true;

            dgvCitas.Columns.Add(botonModificar);

            int headerWidth = dgvCitas.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int margin = 5;
            dgvCitas.Width = headerWidth + dgvCitas.RowHeadersWidth + margin;

            //Centrar dgv
            int xDgv = (this.ClientSize.Width - dgvCitas.Width) / 2;
            int yDgv = (this.ClientSize.Height - dgvCitas.Height) / 2;
            dgvCitas.Location = new Point(xDgv, yDgv);


            //Centar Titulo
            int xTitulo = (pTituloDonantes.Width - label1.Width) / 2;
            int yTitulo = (pTituloDonantes.Height - label1.Height) / 2;
            label1.Location = new Point(xTitulo, yTitulo);
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmADCitas_Load(object sender, EventArgs e)
        {

        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCitas.Columns["Modificar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
                bool confirmacion = Convert.ToBoolean(fila.Cells["Confirmacion"].Value);
                DateTime fechaHora = Convert.ToDateTime(fila.Cells["FechaHora"].Value);

                if (confirmacion)
                {
                    string cedula = fila.Cells["CedulaDonante"].Value.ToString();
                    string[] datos = db.ObtenerCorreo(cedula);
                    DialogResult result = MessageBox.Show($"Se enviara una notificación por correo electrónico:\n" +
                        $"Paciente: {cedula}\nCorreo: {datos[0]}\nDía: {fechaHora.ToShortDateString()}\nHora: {fechaHora.ToShortTimeString()}\n" +
                        $"¿Estas seguro que quieres enviar la notificacion?", "Confirmar Envío de Correo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                    if (result == DialogResult.OK)
                    {

                        string mensaje = @"Estimado [Nombre del Donante],

Esperamos que te encuentres bien. Queremos recordarte que tu generosa donación de sangre está programada para el siguiente evento:

Fecha: [Fecha de la Donación]
Hora: [Hora de la Donación]
Lugar: [Nombre del Centro de Donación]
Dirección: [Dirección del Centro de Donación]

Tu contribución puede marcar una diferencia significativa en la vida de quienes necesitan desesperadamente transfusiones sanguíneas. Agradecemos sinceramente tu disposición para donar y tu valiosa contribución para ayudar a salvar vidas.

Por favor, ten en cuenta los siguientes recordatorios antes de tu donación:

- Asegúrate de haber descansado adecuadamente y de haber consumido una comida nutritiva antes de tu donación.
- No olvides llevar contigo una identificación con fotografía válida.
- Si eres menor de edad asegurate de llevar un permiso firmado de tus padres.
- Si tienes alguna pregunta o inquietud antes de la donación, no dudes en comunicarte con nosotros. Estamos aquí para ayudarte en cualquier momento.

Te recordamos que tu donación puede marcar la diferencia entre la vida y la muerte para alguien que lo necesita desesperadamente. Gracias por tu altruismo y generosidad.

¡Esperamos verte en el evento de donación!

Con gratitud,
[El equipo de Donaciones de Sangre]";

                        mensaje = mensaje.Replace("[Nombre del Donante]", datos[1]);
                        mensaje = mensaje.Replace("[Fecha de la Donación]", fechaHora.ToShortDateString());
                        mensaje = mensaje.Replace("[Hora de la Donación]", fechaHora.ToShortTimeString());
                        mensaje = mensaje.Replace("[Nombre del Centro de Donación]", "Banco de sangre");
                        mensaje = mensaje.Replace("[Dirección del Centro de Donación]", "Quevedo, N\\A");
                        mensaje = mensaje.Replace("[El equipo de Donaciones de Sangre]", "Banco de sangre");

                        MailMessage mail = new MailMessage(); // Esto es para instanciar un mensaje de correo
                        mail.From = new MailAddress("bancodesangre0011@gmail.com"); //Quien envia el correo
                        mail.To.Add(datos[0]); //A quien va destinado
                        mail.Subject = "Cita de donacion";//Asunto
                        mail.Body = mensaje;//Mensaje del correo

                        try
                        {
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");//llamas al cercicio de gmail
                            smtp.Port = 587;
                            smtp.Credentials = new NetworkCredential("bancodesangre0011@gmail.com", "p h d o q d q o k e q p u b p m"); // Aquí ingresas las credenciales
                            smtp.EnableSsl = true;//Habilita el certiicado de ssl
                            smtp.Send(mail);

                            db.FechaHora = fechaHora;
                            db.Confirmacion = bool.Parse(fila.Cells["Confirmacion"].Value.ToString());
                            db.CitaID = int.Parse(fila.Cells["CitaID"].Value.ToString());

                            db.ActualizarCita(db);

                            MessageBox.Show("Se actualizaron los datos correctamentes");

                            fila.Cells["FechaHora"].Style = dgvCitas.DefaultCellStyle;
                            //fila.Cells["Comentario"].Style = dgvCitas.DefaultCellStyle;
                            fila.Cells["Confirmacion"].Style = dgvCitas.DefaultCellStyle;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                {
                    db.FechaHora = fechaHora;
                    db.Confirmacion = bool.Parse(fila.Cells["Confirmacion"].Value.ToString());
                    db.CitaID = int.Parse(fila.Cells["CitaID"].Value.ToString());

                    db.ActualizarCita(db);

                    MessageBox.Show("Se actualizaron los datos correctamentes");

                    fila.Cells["FechaHora"].Style = dgvCitas.DefaultCellStyle;
                    //fila.Cells["Comentario"].Style = dgvCitas.DefaultCellStyle;
                    fila.Cells["Confirmacion"].Style = dgvCitas.DefaultCellStyle;
                }

            }
        }

        private void dgvCitas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle estiloModificado = new DataGridViewCellStyle();

            DataGridViewCell celda = dgvCitas.Rows[e.RowIndex].Cells[e.ColumnIndex];

            estiloModificado.BackColor = Color.LightGreen;

            if (celda.Value != null && !celda.Value.Equals(celda.Tag))
            {
                celda.Style = estiloModificado;
            }
            else
            {
                celda.Style = dgvCitas.DefaultCellStyle;
            }
        }

        private void dgvCitas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvCitas.CurrentCell.Tag = dgvCitas.CurrentCell.Value;
        }

        private void frmADCitas_SizeChanged(object sender, EventArgs e)
        {
            //Centrar dgv
            int xDgv = (this.ClientSize.Width - dgvCitas.Width) / 2;
            int yDgv = (this.ClientSize.Height - dgvCitas.Height) / 2;
            dgvCitas.Location = new Point(xDgv, yDgv);


            //Centar Titulo
            int xTitulo = (pTituloDonantes.Width - label1.Width) / 2;
            int yTitulo = (pTituloDonantes.Height - label1.Height) / 2;
            label1.Location = new Point(xTitulo, yTitulo);
        }
    }
}
