using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CapaVista_Compras
{
    public partial class FrmSplash : Form
    {
        [System.Runtime.InteropServices.DllImport("uxtheme.dll", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr Ventana, string Aplicacion, string Identificador);

        private int _Progreso;

        public FrmSplash()
        {
            InitializeComponent();
            _ComprasPgbCarga.HandleCreated += ComprasMetAplicarColorBarra;
        }

        private void ComprasMetAplicarColorBarra(object Remitente, EventArgs Evento)
        {
            SetWindowTheme(_ComprasPgbCarga.Handle, string.Empty, string.Empty);
            _ComprasPgbCarga.ForeColor = ClsTemaCompras.AcentoNavegador;
            _ComprasPgbCarga.BackColor = ClsTemaCompras.FondoBotones;
        }

        protected override void OnShown(EventArgs Evento)
        {
            base.OnShown(Evento);
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            _Progreso = 0;
            _ComprasPgbCarga.Value = 0;
            _ComprasLblPorcentaje.Text = "0%";
            _ComprasTmrContenido.Start();
        }

        private void ComprasMetActualizarProgreso(object Remitente, EventArgs Evento)
        {
            _Progreso = Math.Min(_ComprasPgbCarga.Maximum, _Progreso + 2);
            _ComprasPgbCarga.Value = _Progreso;
            _ComprasLblPorcentaje.Text = _Progreso + "%";
            if (_Progreso < _ComprasPgbCarga.Maximum) return;

            _ComprasTmrContenido.Stop();
            try
            {
                using (FrmMDICompras Principal = new FrmMDICompras())
                {
                    Hide();
                    Principal.ShowDialog();
                }
            }
            finally
            {
                Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs Evento)
        {
            _ComprasTmrContenido.Stop();
            base.OnFormClosed(Evento);
        }
    }
}
