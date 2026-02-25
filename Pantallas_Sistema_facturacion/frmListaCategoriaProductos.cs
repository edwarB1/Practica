using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmListaCategoriaProductos : Form
    {
        public frmListaCategoriaProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmCategoriaProductos();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var frm = new frmCategoriaProductos();
            frm.ShowDialog();
        }
    }
}
