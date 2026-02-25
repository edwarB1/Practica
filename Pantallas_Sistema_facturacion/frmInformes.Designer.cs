namespace Pantallas_Sistema_facturacion
{
    partial class frmInformes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoInforme = new System.Windows.Forms.Label();
            this.cboTipoInforme = new System.Windows.Forms.ComboBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Informes";
            this.lblTipoInforme.AutoSize = true;
            this.lblTipoInforme.Location = new System.Drawing.Point(12, 50);
            this.lblTipoInforme.Name = "lblTipoInforme";
            this.lblTipoInforme.Size = new System.Drawing.Size(72, 13);
            this.lblTipoInforme.TabIndex = 1;
            this.lblTipoInforme.Text = "Tipo informe:";
            this.cboTipoInforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoInforme.FormattingEnabled = true;
            this.cboTipoInforme.Items.AddRange(new object[] { "Ventas por período", "Productos más vendidos", "Clientes", "Facturación" });
            this.cboTipoInforme.Location = new System.Drawing.Point(120, 47);
            this.cboTipoInforme.Name = "cboTipoInforme";
            this.cboTipoInforme.Size = new System.Drawing.Size(220, 21);
            this.cboTipoInforme.TabIndex = 2;
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(12, 85);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha desde:";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(120, 82);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaDesde.TabIndex = 4;
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(12, 120);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 5;
            this.lblFechaHasta.Text = "Fecha hasta:";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(120, 117);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaHasta.TabIndex = 6;
            this.btnGenerar.Location = new System.Drawing.Point(120, 155);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 28);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(12, 195);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(760, 255);
            this.dgvResultado.TabIndex = 8;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.cboTipoInforme);
            this.Controls.Add(this.lblTipoInforme);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmInformes";
            this.Text = "Informes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoInforme;
        private System.Windows.Forms.ComboBox cboTipoInforme;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvResultado;
    }
}
