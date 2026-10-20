using CapaControlador_AutorizacionOrdenes.ClsModeloTipoCuentaBancaria.cs;
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

namespace CapaVista_AutorizacionOrdenes.frmReportes
{
    public partial class FrmReporteTipoCuentaBancaria : Form
    {
        private ClsModeloTipoCuentaBancaria TipoCuentaBancaria = new ClsModeloTipoCuentaBancaria();
        public FrmReporteTipoCuentaBancaria()
        {
            InitializeComponent();
        }

        private void FrmReporteTipoCuentaBancaria_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("ReporteTipoCuentaBancaria", TipoCuentaBancaria.BancosMetObtenerTodos());
            BancosRvTipoCuentaBancaria.LocalReport.ReportEmbeddedResource = "CapaVista_AutorizacionOrdenes.Reportes.RpReporteTipoCuentaBancaria.rdlc";
            BancosRvTipoCuentaBancaria.LocalReport.DataSources.Clear();
            BancosRvTipoCuentaBancaria.LocalReport.DataSources.Add(reportDataSource);
            this.BancosRvTipoCuentaBancaria.RefreshReport();
        }
    }
}
