using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using CapaControlador_Navegador;
using CapaVista_DisponibilidadDiaria.Reportes;


namespace CapaVista_DisponibilidadDiaria.Formularios
{
    public partial class FrmCuentaBancariaNavegador : Form
    {
        public FrmCuentaBancariaNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblCuentaBancaria", 8000, 8005);
        }

        private void BancosBtnFooterReporte_Click(object sender, EventArgs e)
        {
            try
            {
                using (var datos = new ClsCtrlTabla().NavegadorFuncLlenarDgv("tblCuentaBancaria"))
                using (var reporte = new FrmReporteCuentaBancaria(datos))
                    reporte.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo cargar el reporte de cuentas bancarias.\n" + ex.Message,
                    "Reporte de cuentas bancarias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BancosBtnFooterAyuda_Click(object sender, EventArgs e)
        {
            try
            {
                var directorio = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                while (directorio != null)
                {
                    string ruta = Path.Combine(directorio.FullName, "ayuda", "modulos", "bancos",
                        "BancosAyudas", "CuentaBancaria_Bancos.html");
                    if (File.Exists(ruta))
                    {
                        Process.Start(new ProcessStartInfo(ruta) { UseShellExecute = true });
                        return;
                    }
                    directorio = directorio.Parent;
                }
                MessageBox.Show(this, "No se encontró CuentaBancaria_Bancos.html en ayuda/modulos/bancos/BancosAyudas.",
                    "Ayuda de cuentas bancarias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo abrir la ayuda.\n" + ex.Message,
                    "Ayuda de cuentas bancarias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
