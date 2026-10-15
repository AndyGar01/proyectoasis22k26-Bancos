using CapaVista_Navegador;
using System;
using CapaControlador_Seguridad.Objetos_de_valor;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras
{
    public partial class FrmMDICompras : Form
    {
        private bool _NavegadorContraido;

        public FrmMDICompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ComprasMetActualizarInfoUsuario();
            foreach (Control ControlActual in _ComprasTlpNavegador.Controls)
            {
                if (_ComprasTlpNavegador.GetColumn(ControlActual) != 0) continue;
                Button Boton = _ComprasTlpNavegador.GetControlFromPosition(
                    1, _ComprasTlpNavegador.GetRow(ControlActual)) as Button;
                if (Boton != null)
                {
                    ControlActual.Click += (Remitente, Evento) => Boton.PerformClick();
                }
            }
            if (ClsNavegadorSesion.NavegadorFuncHaySesion())
            {
                Text += " - " + ClsNavegadorSesion.NavegadorFuncNombreUsuario()
                    + " (" + ClsNavegadorSesion.NavegadorFuncRoles() + ")";
            }
        }

        protected override void OnLoad(EventArgs Evento)
        {
            base.OnLoad(Evento);
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            ComprasMetActualizarInfoUsuario();
        }

        private void ComprasMetActualizarInfoUsuario()
        {
            ComprasUsrUsuario.Texto = ClsSesionSeguridad.HaySesionActiva
                ? (string.IsNullOrWhiteSpace(ClsSesionSeguridad.NombreEmpleado)
                    ? ClsSesionSeguridad.NombreUsuario : ClsSesionSeguridad.NombreEmpleado)
                : "Sin sesión";
            ComprasUsrRol.Texto = ClsSesionSeguridad.HaySesionActiva
                ? ClsSesionSeguridad.SeguridadMetRolesComoTexto() : string.Empty;
        }

        private void ComprasMetOpcionPendienteClick(object Remitente, EventArgs Evento)
        {
            // Punto de integración para los futuros formularios emergentes.
            // Por ahora las opciones conservan el dashboard como contenido fijo.
        }

        private void ComprasBtnSalir_Click(object Remitente, EventArgs Evento)
        {
            Close();
        }

        private void ComprasBtnBurger_Click(object Remitente, EventArgs Evento)
        {
            _NavegadorContraido = !_NavegadorContraido;
            _ComprasTlpPrincipal.SuspendLayout();
            _ComprasTlpNavegador.SuspendLayout();
            try
            {
                // Ventas recorta el menú sin cambiar el ancho ni el texto de sus opciones.
                _ComprasTlpNavegador.Width = _NavegadorContraido ? 64 : 270;
                _ComprasTlpPrincipal.ColumnStyles[0].Width = _NavegadorContraido ? 186F : 286F;
                _ComprasBtnAlternarNavegador.AccessibleName = _NavegadorContraido
                    ? "Expandir menú" : "Contraer menú";
            }
            finally
            {
                _ComprasTlpNavegador.ResumeLayout(true);
                _ComprasTlpPrincipal.ResumeLayout(true);
            }
        }
    }
}
