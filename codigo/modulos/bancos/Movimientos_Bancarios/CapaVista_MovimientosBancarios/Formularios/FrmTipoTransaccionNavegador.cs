using CapaVista_MovimientosBancarios.FrmReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_MovimientosBancarios.Formularios
{
    public partial class FrmTipoTransaccionNavegador : Form
    {
        public FrmTipoTransaccionNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblTipoTransaccion", 8000, 8004);

            navegador1.NavegadorAccionSolicitada += (Accion) =>
            {
                BeginInvoke((Action)(() =>
                {
                    BancosbtnReportes.BringToFront();
                    BancosbtnAyudas.BringToFront();
                }));
            };

        }

        private void BancosbtnReportes_Click(object sender, EventArgs e)
        {
            FrmTipoTransaccion reporte = new FrmTipoTransaccion();
            reporte.Show();
        }

        private void BancosbtnAyudas_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/BancosAyudas/CapaBancos.chm", "TipoTransaccion_Bancos.html");
        }
    }
}
