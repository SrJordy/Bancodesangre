namespace Banco
{
    partial class frmADCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmADCitas));
            this.pTituloDonantes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.pTituloDonantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // pTituloDonantes
            // 
            this.pTituloDonantes.BackColor = System.Drawing.Color.DarkRed;
            this.pTituloDonantes.Controls.Add(this.label1);
            this.pTituloDonantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTituloDonantes.Location = new System.Drawing.Point(0, 0);
            this.pTituloDonantes.Name = "pTituloDonantes";
            this.pTituloDonantes.Size = new System.Drawing.Size(687, 26);
            this.pTituloDonantes.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(274, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de citas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(45, 37);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCitas.MinimumSize = new System.Drawing.Size(0, 200);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 29;
            this.dgvCitas.Size = new System.Drawing.Size(608, 367);
            this.dgvCitas.TabIndex = 16;
            this.dgvCitas.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCitas_CellBeginEdit);
            this.dgvCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellClick);
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            this.dgvCitas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellEndEdit);
            // 
            // frmADCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.pTituloDonantes);
            this.Controls.Add(this.dgvCitas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmADCitas";
            this.Text = "SGBS Administrar Citas";
            this.Load += new System.EventHandler(this.frmADCitas_Load);
            this.SizeChanged += new System.EventHandler(this.frmADCitas_SizeChanged);
            this.pTituloDonantes.ResumeLayout(false);
            this.pTituloDonantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTituloDonantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCitas;
    }
}