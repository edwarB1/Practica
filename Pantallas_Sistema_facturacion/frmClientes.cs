using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProviderClientes.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderClientes.SetError(txtNombre, "El nombre es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                errorProviderClientes.SetError(txtIdentificacion, "La identificación es obligatoria.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProviderClientes.SetError(txtTelefono, "El teléfono es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProviderClientes.SetError(txtDireccion, "La dirección es obligatoria.");
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
