namespace Banco
{
    partial class frmADdonantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmADdonantes));
            this.pTituloDonantes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonante = new System.Windows.Forms.DataGridView();
            this.pTituloDonantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonante)).BeginInit();
            this.SuspendLayout();
            // 
            // pTituloDonantes
            // 
            this.pTituloDonantes.BackColor = System.Drawing.Color.DarkRed;
            this.pTituloDonantes.Controls.Add(this.label1);
            this.pTituloDonantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTituloDonantes.Location = new System.Drawing.Point(0, 0);
            this.pTituloDonantes.Name = "pTituloDonantes";
            this.pTituloDonantes.Size = new System.Drawing.Size(930, 29);
            this.pTituloDonantes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de donantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDonante
            // 
            this.dgvDonante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonante.Location = new System.Drawing.Point(11, 44);
            this.dgvDonante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDonante.MinimumSize = new System.Drawing.Size(200, 200);
            this.dgvDonante.Name = "dgvDonante";
            this.dgvDonante.RowHeadersWidth = 51;
            this.dgvDonante.RowTemplate.Height = 29;
            this.dgvDonante.Size = new System.Drawing.Size(900, 348);
            this.dgvDonante.TabIndex = 15;
            this.dgvDonante.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDonante_CellBeginEdit);
            this.dgvDonante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonante_CellClick);
            this.dgvDonante.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonante_CellEndEdit);
            // 
            // frmADdonantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 415);
            this.Controls.Add(this.pTituloDonantes);
            this.Controls.Add(this.dgvDonante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmADdonantes";
            this.Text = "SGBS Administrar donantes";
            this.Load += new System.EventHandler(this.frmADdonantes_Load);
            this.SizeChanged += new System.EventHandler(this.frmADdonantes_SizeChanged);
            this.pTituloDonantes.ResumeLayout(false);
            this.pTituloDonantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTituloDonantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDonante;
    }
}