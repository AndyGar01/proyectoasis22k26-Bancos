using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_MovimientosBancarios;

namespace CapaVista_MovimientosBancarios.FrmReportes
{
    public partial class FrmTipoTransaccion : Form
    {
        private ClsModeloTipoTransaccion modulo = new ClsModeloTipoTransaccion();
        public FrmTipoTransaccion()
        {
            InitializeComponent();
        }

        private void FrmTipoTransaccion_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", modulo.BancosMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_MovimientosBancarios.Reportes.RpReportTipoTransaccion.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
