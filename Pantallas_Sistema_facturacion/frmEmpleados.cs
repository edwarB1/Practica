using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProviderEmpleados.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProviderEmpleados.SetError(txtNombre, "El nombre es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                errorProviderEmpleados.SetError(txtIdentificacion, "La identificación es obligatoria.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                errorProviderEmpleados.SetError(txtCargo, "El cargo es obligatorio.");
                valido = false;
            }
            if (cboRol.SelectedIndex < 0)
            {
                errorProviderEmpleados.SetError(cboRol, "Seleccione un rol.");
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
