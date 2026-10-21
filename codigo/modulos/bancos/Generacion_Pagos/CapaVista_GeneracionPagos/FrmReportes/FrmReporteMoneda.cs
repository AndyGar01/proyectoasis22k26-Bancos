using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaControlador_GeneracionPagos;

namespace CapaVista_GeneracionPagos.FrmReportes
{
    public partial class FrmReporteMoneda : Form
    {
        private ClsModeloMoneda _Moneda = new ClsModeloMoneda();

        public FrmReporteMoneda()
        {
            InitializeComponent();
        }

        private void FrmReporteMoneda_Load(object sender, EventArgs e)
        {
            ReportDataSource Datos = new ReportDataSource("RPMoneda", _Moneda.BancosMetObtenerTodos());
            BancosRvMoneda.LocalReport.ReportEmbeddedResource = "CapaVista_GeneracionPagos.Reportes.RpReporteMoneda.rdlc";
            BancosRvMoneda.LocalReport.DataSources.Clear();
            BancosRvMoneda.LocalReport.DataSources.Add(Datos);
            BancosRvMoneda.RefreshReport();
        }
    }
}