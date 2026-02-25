using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            foreach (Control ctrl in pnlContenedor.Controls)
            {
                if (ctrl is Form f)
                {
                    f.Close();
                    f.Dispose();
                }
            }
            pnlContenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmListaClientes());

        private void productosToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmListaProductos());

        private void categoríaProductosToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmListaCategoriaProductos());

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmFacturas());

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmListaEmpleados());

        private void rolEmpleadosToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmListaRolEmpleados());

        private void administraciónSeguridadToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmAdminSeguridad());

        private void informesToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmInformes());

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmAyuda());

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) =>
            AbrirFormularioEnPanel(new frmAcercaDe());

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
