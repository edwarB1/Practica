using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProviderCategoria.Clear();

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProviderCategoria.SetError(txtCodigo, "El código es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderCategoria.SetError(txtNombre, "El nombre es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProviderCategoria.SetError(txtDescripcion, "La descripción es obligatoria.");
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
