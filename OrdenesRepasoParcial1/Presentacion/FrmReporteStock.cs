using OrdenesRepasoParcial1.Datos;
using OrdenesRepasoParcial1.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenesRepasoParcial1.Presentacion
{
    public partial class FrmReporteStock : Form
    {
        public FrmReporteStock()
        {
            InitializeComponent();
        }

        private void FrmReporteStock_Load(object sender, EventArgs e)
        {
            this.t_MATERIALESTableAdapter.Fill(this.dsReporteStock.T_MATERIALES);
            this.rvReporteStock.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
