using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe generado. (En producción aquí se generaría el reporte.)", "Informes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
