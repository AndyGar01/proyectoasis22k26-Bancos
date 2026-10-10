/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Mostrar la presentación de Ventas y abrir el MDI con el usuario autenticado.
 */
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaVista_Ventas
{
    public partial class FrmSplashVentas : Form
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr Handle, string NombreAplicacion, string ListaIdentificadores);

        // Avance visual del splash; la autenticación ya se completó en FrmLoginVentas.
        private int _Progreso;
        private readonly string _NombreUsuario;
        private readonly string _RolUsuario;

        public FrmSplashVentas()
        {
            InitializeComponent();
        }

        public FrmSplashVentas(string NombreUsuario, string RolUsuario) : this()
        {
            _NombreUsuario = NombreUsuario;
            _RolUsuario = RolUsuario;
        }

        // Inicia la presentación sólo al ejecutar el formulario, nunca dentro del diseñador.
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            // ProgressBar de la caja de herramientas, con el color de Ventas (como Seguridad).
            SetWindowTheme(VentasPgbCarga.Handle, string.Empty, string.Empty);
            _TimerCarga.Start();
        }

        private void VentasTimerCarga_Tick(object sender, EventArgs e)
        {
            // Transición de presentación; no representa validación de credenciales.
            _Progreso = Math.Min(100, _Progreso + 2);
            VentasPgbCarga.Value = _Progreso;
            VentasLblPorcentaje.Text = _Progreso + "%";
            if (_Progreso < 100) return;
            _TimerCarga.Stop();
            // Tras completar la presentación, abre el MDI y espera a que termine la sesión.
            using (FrmMdiVentas Principal = new FrmMdiVentas(_NombreUsuario, _RolUsuario))
            {
                Hide();
                try { Principal.ShowDialog(); }
                finally { Close(); }
            }
        }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
