using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_GeneracionPagos.FrmReportes;

namespace CapaVista_GeneracionPagos.Formularios
{
    public partial class FrmMonedaNavegador : Form
    {
        public FrmMonedaNavegador()
        {
            InitializeComponent();
            BancosNavMoneda.NavegadorMetConfigurar("tblMoneda", 8000, 8001);

            BancosNavMoneda.NavegadorAccionSolicitada += (Accion) =>
            {
                BeginInvoke((Action)(() =>
                {
                    BancosBtnReporte.BringToFront();
                }));
            };
        }

        private void BancosBtnReporte_Click_1(object sender, EventArgs e)
        {
            FrmReporteMoneda Reporte = new FrmReporteMoneda();
            Reporte.Show();
        }

        private void BancosbtnAyudas_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/BancosAyudas/CapaBancos.chm", "Moneda_Bancos.html");
        }
    }
}