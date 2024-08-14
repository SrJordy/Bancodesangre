namespace Banco
{
    partial class frmAgregarNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarNuevo));
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(514, 227);
            this.btnAgregarNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(161, 32);
            this.btnAgregarNuevo.TabIndex = 6;
            this.btnAgregarNuevo.Text = "Guardar";
            this.btnAgregarNuevo.UseVisualStyleBackColor = false;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponible",
            "En uso",
            "Expirado"});
            this.cmbEstado.Location = new System.Drawing.Point(347, 155);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(132, 25);
            this.cmbEstado.TabIndex = 2;
            this.cmbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEstado_KeyDown);
            // 
            // cmbTipoSangre
            // 
            this.cmbTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSangre.FormattingEnabled = true;
            this.cmbTipoSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbTipoSangre.Location = new System.Drawing.Point(347, 81);
            this.cmbTipoSangre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Size = new System.Drawing.Size(132, 25);
            this.cmbTipoSangre.TabIndex = 1;
            this.cmbTipoSangre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoSangre_KeyDown);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(519, 81);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUbicacion.MaxLength = 50;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(156, 23);
            this.txtUbicacion.TabIndex = 3;
            this.txtUbicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUbicacion_KeyDown);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(514, 157);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaIngreso.MaxDate = new System.DateTime(2024, 8, 9, 0, 0, 0, 0);
            this.dtpFechaIngreso.MinDate = new System.DateTime(2024, 8, 9, 0, 0, 0, 0);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(161, 23);
            this.dtpFechaIngreso.TabIndex = 4;
            this.dtpFechaIngreso.Value = new System.DateTime(2024, 8, 9, 0, 0, 0, 0);
            this.dtpFechaIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaIngreso_KeyDown);
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(347, 236);
            this.dtpFechaCaducidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaCaducidad.MaxDate = new System.DateTime(4000, 2, 2, 0, 0, 0, 0);
            this.dtpFechaCaducidad.MinDate = new System.DateTime(2024, 8, 9, 0, 0, 0, 0);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(132, 23);
            this.dtpFechaCaducidad.TabIndex = 5;
            this.dtpFechaCaducidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaCaducidad_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR INVENTARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(344, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de sangre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(516, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ubicación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(516, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(344, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expiración:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(344, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado: ";
            // 
            // frmAgregarNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.Captura_de_pantalla_2024_08_11_195253;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaCaducidad);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.cmbTipoSangre);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnAgregarNuevo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAgregarNuevo";
            this.Text = "SGBS Nuevo Componente";
            this.Load += new System.EventHandler(this.frmAgregarNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTipoSangre;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}