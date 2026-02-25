using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProviderSeguridad.Clear();

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProviderSeguridad.SetError(txtUsuario, "El usuario es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                errorProviderSeguridad.SetError(txtContrasena, "La contraseña es obligatoria.");
                valido = false;
            }
            if (cboRol.SelectedIndex < 0)
            {
                errorProviderSeguridad.SetError(cboRol, "Seleccione un rol.");
                valido = false;
            }

            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Corrija los campos marcados antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Usuario de seguridad guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
