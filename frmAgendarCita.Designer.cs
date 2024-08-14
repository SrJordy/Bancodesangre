namespace Banco
{
    partial class frmAgendarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendarCita));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.dptFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHoraa = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCédula = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lbllunes = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(337, 145);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(245, 20);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyDown);
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(337, 232);
            this.nudHora.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.nudHora.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(245, 20);
            this.nudHora.TabIndex = 3;
            this.nudHora.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudHora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudHora_KeyDown);
            this.nudHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudHora_KeyPress);
            // 
            // dptFecha
            // 
            this.dptFecha.Location = new System.Drawing.Point(337, 191);
            this.dptFecha.MaxDate = new System.DateTime(2034, 6, 14, 0, 0, 0, 0);
            this.dptFecha.MinDate = new System.DateTime(2024, 8, 5, 0, 0, 0, 0);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(245, 20);
            this.dptFecha.TabIndex = 2;
            this.dptFecha.Value = new System.DateTime(2024, 8, 5, 0, 0, 0, 0);
            this.dptFecha.ValueChanged += new System.EventHandler(this.dptFecha_ValueChanged);
            this.dptFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dptFecha_KeyDown);
            // 
            // lblHoraa
            // 
            this.lblHoraa.AutoSize = true;
            this.lblHoraa.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraa.Location = new System.Drawing.Point(289, 232);
            this.lblHoraa.Name = "lblHoraa";
            this.lblHoraa.Size = new System.Drawing.Size(43, 15);
            this.lblHoraa.TabIndex = 24;
            this.lblHoraa.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(281, 191);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 15);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCédula
            // 
            this.lblCédula.AutoSize = true;
            this.lblCédula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCédula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCédula.Location = new System.Drawing.Point(275, 145);
            this.lblCédula.Name = "lblCédula";
            this.lblCédula.Size = new System.Drawing.Size(57, 15);
            this.lblCédula.TabIndex = 22;
            this.lblCédula.Text = "Cédula:";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(401, 113);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(113, 13);
            this.lblhora.TabIndex = 21;
            this.lblhora.Text = "8:00 a.m. a 17:00 p.m.";
            // 
            // lbllunes
            // 
            this.lbllunes.AutoSize = true;
            this.lbllunes.Location = new System.Drawing.Point(419, 89);
            this.lbllunes.Name = "lbllunes";
            this.lbllunes.Size = new System.Drawing.Size(83, 13);
            this.lbllunes.TabIndex = 20;
            this.lbllunes.Text = "Lunes a Viernes";
            this.lbllunes.Click += new System.EventHandler(this.lbllunes_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(316, 47);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(277, 25);
            this.lblHorario.TabIndex = 19;
            this.lblHorario.Text = "HORARIO DE ATENCIÓN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(337, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(502, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.Captura_de_pantalla_2024_08_11_171815;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.nudHora);
            this.Controls.Add(this.dptFecha);
            this.Controls.Add(this.lblHoraa);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCédula);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lbllunes);
            this.Controls.Add(this.lblHorario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgendarCita";
            this.Text = "SGBS AGENDAR CITA";
            this.Load += new System.EventHandler(this.frmAgendarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.DateTimePicker dptFecha;
        private System.Windows.Forms.Label lblHoraa;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCédula;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lbllunes;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}