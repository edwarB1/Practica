using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            // Según la guía: para la ayuda se utiliza WebBrowser y se asigna la página oficial de Microsoft
            webBrowserAyuda.Navigate("https://www.microsoft.com");
        }
    }
}
