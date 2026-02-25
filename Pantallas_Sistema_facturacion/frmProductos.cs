using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProviderProductos.Clear();

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProviderProductos.SetError(txtCodigo, "El código es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderProductos.SetError(txtNombre, "El nombre es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                errorProviderProductos.SetError(txtPrecio, "El precio es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                errorProviderProductos.SetError(txtStock, "El stock es obligatorio.");
                valido = false;
            }

            return valido;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Corrija los campos marcados antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
