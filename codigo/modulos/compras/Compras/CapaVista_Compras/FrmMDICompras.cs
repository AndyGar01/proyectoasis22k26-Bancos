using CapaVista_Navegador;
using System;
using CapaControlador_Seguridad.Objetos_de_valor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Compras
{
    public partial class FrmMDICompras : Form
    {
        private bool _NavegadorContraido;
        private float _AnchoNavegadorExpandido;

        public FrmMDICompras()
        {
            InitializeComponent();
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
            ComprasProcMostrarControlCompras<UsrDashboardCompras>();
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

        private bool ComprasMetVerificarSesion()
        {
            if (ClsNavegadorSesion.NavegadorFuncHaySesion()) return true;

            MessageBox.Show(this,
                "Inicie sesión con el botón Compras del Login de Seguridad para abrir los mantenimientos.",
                "Sesión requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void ComprasProcMostrarControlCompras<T>() where T : UserControl, new()
        {
            var ComprasUsrActual = _ComprasPnlMain.Controls.OfType<T>().FirstOrDefault();

            if (ComprasUsrActual == null)
            {
                ComprasUsrActual = new T();
                ComprasUsrActual.MinimumSize = new Size(ComprasUsrActual.MinimumSize.Width,
                    Math.Max(ComprasUsrActual.MinimumSize.Height, ComprasUsrActual.Height));
                _ComprasPnlMain.Controls.Add(ComprasUsrActual);
            }

            foreach (Control OtroControl in _ComprasPnlMain.Controls)
            {
                if (OtroControl != ComprasUsrActual)
                {
                    OtroControl.Hide();
                }
            }

            _ComprasPnlMain.AutoScrollPosition = Point.Empty;
            ComprasUsrActual.Dock = DockStyle.Top;
            ComprasUsrActual.Show();
            ComprasUsrActual.BringToFront();
        }

        private void ComprasMetBtnCierreMovimientosClick(object Remitente, EventArgs Evento)
        {
            ComprasProcMostrarControlCompras<UsrCierreMovimientos>();
        }

        private void ComprasMetBtnMovimientosProveedoresClick(object Remitente, EventArgs Evento)
        {
            ComprasProcMostrarControlCompras<UsrEstadoDeCuenta>();
        }

        private void ComprasMetBtnOrdenesCompraClick(object Remitente, EventArgs Evento)
        {
            ComprasProcMostrarControlCompras<UsrOrdenesDeCompras>();
        }

        private void ComprasMetBtnAprobacionFinancieraClick(object Remitente, EventArgs Evento)
        {
            ComprasProcMostrarControlCompras<UsrOrdenesDisponibles>();
        }

        private void ComprasMetBtnProveedoresClick(object Remitente, EventArgs Evento)
        {
            if (!ComprasMetVerificarSesion()) return;
            ComprasProcMostrarControlCompras<UsrMantenimientoProveedor>();
        }

        private void ComprasMetBtnMetodosPagoClick(object Remitente, EventArgs Evento)
        {
            if (!ComprasMetVerificarSesion()) return;
            ComprasProcMostrarControlCompras<UsrMantenimientoMetodoPago>();
        }

        private void ComprasMetBtnPagosProveedoresClick(object Remitente, EventArgs Evento)
        {
            ComprasProcMostrarControlCompras<UsrPagosProveedores>();
        }

        private void ComprasBtnSalir_Click(object Remitente, EventArgs Evento)
        {
            Close();
        }

        private void ComprasBtnDashboard_Click(object Remitente, EventArgs Evento)
        {
            ComprasProcMostrarControlCompras<UsrDashboardCompras>();
        }

        private void ComprasBtnBurger_Click(object Remitente, EventArgs Evento)
        {
            if (!_NavegadorContraido)
                _AnchoNavegadorExpandido = _ComprasTlpPrincipal.ColumnStyles[0].Width;

            _NavegadorContraido = !_NavegadorContraido;
            _ComprasTlpPrincipal.SuspendLayout();
            _ComprasTlpNavegador.SuspendLayout();
            try
            {
                foreach (Control ControlActual in _ComprasTlpNavegador.Controls)
                {
                    if (_ComprasTlpNavegador.GetColumn(ControlActual) == 1)
                        ControlActual.Visible = !_NavegadorContraido;
                }

                ColumnStyle Columna = _ComprasTlpNavegador.ColumnStyles[1];
                Columna.SizeType = _NavegadorContraido ? SizeType.Absolute : SizeType.Percent;
                Columna.Width = _NavegadorContraido ? 0F : 100F;
                _ComprasTlpPrincipal.ColumnStyles[0].Width = _NavegadorContraido
                    ? _ComprasTlpNavegador.ColumnStyles[0].Width
                    : _AnchoNavegadorExpandido;
            }
            finally
            {
                _ComprasTlpNavegador.ResumeLayout(true);
                _ComprasTlpPrincipal.ResumeLayout(true);
            }
        }
    }
}
