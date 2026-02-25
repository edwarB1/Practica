namespace Pantallas_Sistema_facturacion
{
    partial class frmAyuda
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
            this.webBrowserAyuda = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            this.webBrowserAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserAyuda.Location = new System.Drawing.Point(0, 0);
            this.webBrowserAyuda.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserAyuda.Name = "webBrowserAyuda";
            this.webBrowserAyuda.Size = new System.Drawing.Size(784, 461);
            this.webBrowserAyuda.TabIndex = 0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.webBrowserAyuda);
            this.Name = "frmAyuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.frmAyuda_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.WebBrowser webBrowserAyuda;
    }
}
