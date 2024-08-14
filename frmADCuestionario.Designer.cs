namespace Banco
{
    partial class frmADCuestionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmADCuestionario));
            this.dgvRespuestas = new System.Windows.Forms.DataGridView();
            this.pTituloDonantes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuestas)).BeginInit();
            this.pTituloDonantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRespuestas
            // 
            this.dgvRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespuestas.Location = new System.Drawing.Point(29, 45);
            this.dgvRespuestas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRespuestas.MinimumSize = new System.Drawing.Size(0, 300);
            this.dgvRespuestas.Name = "dgvRespuestas";
            this.dgvRespuestas.RowHeadersWidth = 51;
            this.dgvRespuestas.RowTemplate.Height = 29;
            this.dgvRespuestas.Size = new System.Drawing.Size(634, 345);
            this.dgvRespuestas.TabIndex = 20;
            this.dgvRespuestas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRespuestas_CellFormatting);
            // 
            // pTituloDonantes
            // 
            this.pTituloDonantes.BackColor = System.Drawing.Color.DarkRed;
            this.pTituloDonantes.Controls.Add(this.label1);
            this.pTituloDonantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTituloDonantes.Location = new System.Drawing.Point(0, 0);
            this.pTituloDonantes.Name = "pTituloDonantes";
            this.pTituloDonantes.Size = new System.Drawing.Size(687, 26);
            this.pTituloDonantes.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(246, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de respuestas";
            // 
            // frmADCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.dgvRespuestas);
            this.Controls.Add(this.pTituloDonantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmADCuestionario";
            this.Text = "SGBS Administrar Cuestionario";
            this.SizeChanged += new System.EventHandler(this.frmADCuestionario_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuestas)).EndInit();
            this.pTituloDonantes.ResumeLayout(false);
            this.pTituloDonantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRespuestas;
        private System.Windows.Forms.Panel pTituloDonantes;
        private System.Windows.Forms.Label label1;
    }
}