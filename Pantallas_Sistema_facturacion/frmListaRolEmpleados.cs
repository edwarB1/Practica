using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmListaRolEmpleados : Form
    {
        public frmListaRolEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmRolEmpleados();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var frm = new frmRolEmpleados();
            frm.ShowDialog();
        }
    }
}
