using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaVista_DisponibilidadDiaria.Reportes
{
    public sealed class FrmReporteCuentaBancaria : Form
    {
        public FrmReporteCuentaBancaria(DataTable datos)
        {
            if (datos == null || datos.Columns.Count == 0)
                throw new ArgumentException("No se recibió la estructura de cuentas bancarias.", "datos");

            Text = "8005 - Reporte de cuentas bancarias";
            Size = new Size(1100, 700);
            StartPosition = FormStartPosition.CenterParent;
            var visor = new ReportViewer { Dock = DockStyle.Fill, ProcessingMode = ProcessingMode.Local };
            Controls.Add(visor);
            visor.LocalReport.DisplayName = "CuentasBancarias_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            using (var definicion = new StringReader(ClsReporteCuentaBancaria.CrearDefinicion(datos)))
                visor.LocalReport.LoadReportDefinition(definicion);
            visor.LocalReport.DataSources.Add(new ReportDataSource("CuentasBancarias", datos));
            Load += (sender, e) => visor.RefreshReport();
        }
    }
}
