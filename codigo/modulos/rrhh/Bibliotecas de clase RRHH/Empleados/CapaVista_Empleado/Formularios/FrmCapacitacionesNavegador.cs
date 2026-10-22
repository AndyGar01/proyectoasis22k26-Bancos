using CapaVista_Navegador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Empleado.Formularios
{
    public partial class FrmCapacitacionesNavegador : Form
    {
        public FrmCapacitacionesNavegador()
        {
            InitializeComponent();
            RrhhNavCapacitaciones.NavegadorMetConfigurar("tblCapacitacion", 9000, 9302);

            RrhhNavCapacitaciones.NavegadorAccionSolicitada += (Accion) =>
            {
                BeginInvoke((Action)(() => RrhhMetTraerBotonesAlFrente()));
            };

            this.Shown += (s, e) => RrhhMetTraerBotonesAlFrente();
        }

        private void RrhhMetTraerBotonesAlFrente()
        {
            RrhhBtnReporteCapacitacion.BringToFront();
            RrhhBtnAyudaCapacitacion.BringToFront();
        }

        private void RrhhBtnReporteCapacitacion_Click(object sender, EventArgs e)
        {
            frmReportes.FrmReporteCapacitacion reporte = new frmReportes.FrmReporteCapacitacion();
            reporte.ShowDialog();
        }

    }
     
}
