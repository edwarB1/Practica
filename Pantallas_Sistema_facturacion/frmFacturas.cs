using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProviderFacturas.Clear();

            if (string.IsNullOrWhiteSpace(txtNumeroFactura.Text))
            {
                errorProviderFacturas.SetError(txtNumeroFactura, "El número de factura es obligatorio.");
                valido = false;
            }
            if (cboCliente.SelectedIndex < 0)
            {
                errorProviderFacturas.SetError(cboCliente, "Seleccione un cliente.");
                valido = false;
            }
            if (dtpFecha.Value == null)
            {
                errorProviderFacturas.SetError(dtpFecha, "La fecha es obligatoria.");
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
            MessageBox.Show("Factura registrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtNumeroFactura.Clear();
            cboCliente.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            dgvDetalle.Rows.Clear();
            errorProviderFacturas.Clear();
        }
    }
}
