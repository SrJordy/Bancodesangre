namespace Banco
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.pTituloDonantes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.pTituloDonantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(58, 48);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInventario.MinimumSize = new System.Drawing.Size(0, 300);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 29;
            this.dgvInventario.Size = new System.Drawing.Size(571, 332);
            this.dgvInventario.TabIndex = 20;
            this.dgvInventario.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInventario_CellBeginEdit);
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRespuestas_CellContentClick);
            this.dgvInventario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellEndEdit);
            // 
            // pTituloDonantes
            // 
            this.pTituloDonantes.BackColor = System.Drawing.Color.Firebrick;
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Inventario";
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(584, 385);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(91, 26);
            this.btnAgregarNuevo.TabIndex = 83;
            this.btnAgregarNuevo.Text = "Registrar";
            this.btnAgregarNuevo.UseVisualStyleBackColor = false;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pTituloDonantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInventario";
            this.Text = "SGBS Inventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pTituloDonantes.ResumeLayout(false);
            this.pTituloDonantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel pTituloDonantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarNuevo;
    }
}