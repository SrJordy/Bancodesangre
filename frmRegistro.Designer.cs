namespace Banco
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.dptFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbSangre = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dptFechaNacimiento
            // 
            this.dptFechaNacimiento.Location = new System.Drawing.Point(273, 370);
            this.dptFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dptFechaNacimiento.Name = "dptFechaNacimiento";
            this.dptFechaNacimiento.Size = new System.Drawing.Size(215, 20);
            this.dptFechaNacimiento.TabIndex = 7;
            this.dptFechaNacimiento.ValueChanged += new System.EventHandler(this.dptFechaNacimiento_ValueChanged_1);
            this.dptFechaNacimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dptFechaNacimiento_KeyDown);
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.cmbGenero.Location = new System.Drawing.Point(273, 246);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(215, 21);
            this.cmbGenero.TabIndex = 3;
            this.cmbGenero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGenero_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(11, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCedula.Location = new System.Drawing.Point(11, 189);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(185, 20);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyDown);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTelefono.Location = new System.Drawing.Point(11, 258);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(187, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Items.AddRange(new object[] {
            "Quito",
            "",
            "Guayaquil",
            "",
            "Cuenca",
            "",
            "Santo Domingo",
            "",
            "Machala",
            "",
            "Manta",
            "",
            "Portoviejo",
            "",
            "Ambato",
            "",
            "Riobamba",
            "",
            "Esmeraldas",
            "",
            "Ibarra",
            "",
            "Loja",
            "",
            "Quevedo",
            "",
            "Milagro",
            "",
            "Babahoyo",
            "",
            "Tulcán",
            "",
            "Latacunga",
            "",
            "Tena",
            "",
            "Azogues",
            "",
            "Puyo",
            "",
            "Salinas",
            "",
            "La Libertad",
            "",
            "Chone",
            "",
            "Santa Elena",
            "",
            "Nueva Loja (Lago Agrio)"});
            this.cmbCiudad.Location = new System.Drawing.Point(11, 313);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(187, 21);
            this.cmbCiudad.TabIndex = 4;
            this.cmbCiudad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCiudad_KeyDown);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApellido.Location = new System.Drawing.Point(11, 134);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 20);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            // 
            // cmbSangre
            // 
            this.cmbSangre.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSangre.FormattingEnabled = true;
            this.cmbSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbSangre.Location = new System.Drawing.Point(273, 304);
            this.cmbSangre.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSangre.Name = "cmbSangre";
            this.cmbSangre.Size = new System.Drawing.Size(215, 21);
            this.cmbSangre.TabIndex = 8;
            this.cmbSangre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSangre_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEmail.Location = new System.Drawing.Point(11, 373);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Banco.Properties.Resources.Captura_de_pantalla_2024_08_04_141007;
            this.pictureBox1.Location = new System.Drawing.Point(561, 289);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Banco.Properties.Resources.Captura_de_pantalla_2024_08_04_141300;
            this.pictureBox2.Location = new System.Drawing.Point(561, 347);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(368, 31);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(192, 19);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "REGISTRO DE DATOS ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "PERSONALES";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Banco.Properties.Resources.Captura_de_pantalla_2024_08_11_180028;
            this.pictureBox3.Location = new System.Drawing.Point(380, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.Captura_de_pantalla_2024_08_11_180729;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbSangre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.dptFechaNacimiento);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegistro";
            this.Text = "SGBS REGISTRO";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dptFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbSangre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}