using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmClientes();
            frm.ShowDialog();
            // Aquí se podría recargar la lista
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var frm = new frmClientes();
            frm.ShowDialog();
        }
    }
}
