namespace Pantallas_Sistema_facturacion
{
    partial class frmAcercaDe
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
            this.pnlAcercaDe = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlAcercaDe.SuspendLayout();
            this.SuspendLayout();
            this.pnlAcercaDe.Controls.Add(this.btnCerrar);
            this.pnlAcercaDe.Controls.Add(this.txtInformacion);
            this.pnlAcercaDe.Controls.Add(this.lblVersion);
            this.pnlAcercaDe.Controls.Add(this.lblTitulo);
            this.pnlAcercaDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcercaDe.Location = new System.Drawing.Point(0, 0);
            this.pnlAcercaDe.Name = "pnlAcercaDe";
            this.pnlAcercaDe.Size = new System.Drawing.Size(484, 361);
            this.pnlAcercaDe.TabIndex = 0;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Facturación";
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(20, 55);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Versión: 1.0";
            this.txtInformacion.Location = new System.Drawing.Point(24, 85);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.ReadOnly = true;
            this.txtInformacion.Size = new System.Drawing.Size(436, 220);
            this.txtInformacion.TabIndex = 2;
            this.txtInformacion.Text = "Aplicativo de escritorio para gestión de facturación.\r\n\r\nDesarrollado como práctica de laboratorio - Herramientas de programación III.\r\n\r\nPrograma: Tecnología en Desarrollo de Software\r\nFacultad: Ingeniería\r\nAsignatura: Herramientas de programación III";
            this.btnCerrar.Location = new System.Drawing.Point(385, 320);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 28);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pnlAcercaDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de...";
            this.pnlAcercaDe.ResumeLayout(false);
            this.pnlAcercaDe.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlAcercaDe;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Button btnCerrar;
    }
}
