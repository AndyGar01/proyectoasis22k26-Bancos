using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Navegador;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaVista_Compras
{
    public partial class FrmMDICompras : Form
    {
        private bool _NavegadorContraido;
        private readonly Dictionary<TableLayoutPanel, ColumnStyle> _ColumnasNavegador =
            new Dictionary<TableLayoutPanel, ColumnStyle>();

        public FrmMDICompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
            foreach (Control ControlActual in _ComprasTlpNavegador.Controls)
            {
                Componentes.ClsTableLayoutPanelCompras Panel = ControlActual as Componentes.ClsTableLayoutPanelCompras;
                if (Panel != null) ComprasMetConfigurarEstadosTab(Panel, Panel);
            }
            ComprasTlpPresentacion.SizeChanged += (Origen, Argumentos) => ComprasMetAjustarPresentacion();
            ComprasMetAjustarPresentacion();
            ComprasMetActualizarInfoUsuario();
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
            ComprasMetAjustarDashboard();
            _ComprasTlpPrincipal.PerformLayout();
            _ComprasPnlMain.PerformLayout();
            ComprasMetActualizarInfoUsuario();
        }

        private void ComprasMetConfigurarEstadosTab(Control Elemento, Componentes.ClsTableLayoutPanelCompras Panel)
        {
            Elemento.MouseEnter += (Origen, Argumentos) => Panel.ComprasProcActualizarHover(true);
            Elemento.MouseLeave += (Origen, Argumentos) =>
            {
                if (!IsHandleCreated || IsDisposed || Disposing) return;
                BeginInvoke(new Action(() =>
                {
                    if (Panel.IsDisposed || IsDisposed || Disposing) return;
                    Panel.ComprasProcActualizarHover(Panel.ClientRectangle.Contains(Panel.PointToClient(Cursor.Position)));
                }));
            };
            Elemento.Click += (Origen, Argumentos) =>
            {
                if (IsDisposed || Disposing) return;
                foreach (Control ControlActual in _ComprasTlpNavegador.Controls)
                {
                    Componentes.ClsTableLayoutPanelCompras Opcion = ControlActual as Componentes.ClsTableLayoutPanelCompras;
                    if (Opcion != null) Opcion.Seleccionado = ReferenceEquals(Opcion, Panel);
                }
            };
            foreach (Control Hijo in Elemento.Controls) ComprasMetConfigurarEstadosTab(Hijo, Panel);
        }

        private void ComprasMetActualizarInfoUsuario()
        {
            string Usuario = ClsSesionSeguridad.HaySesionActiva
                ? ClsSesionSeguridad.NombreUsuario : "Sin sesión";
            string Rol = ClsSesionSeguridad.HaySesionActiva
                ? ClsSesionSeguridad.SeguridadMetRolesComoTexto() : string.Empty;
            ComprasLblUsuarioRol.Texto = "Usuario: " + Usuario + "   Rol: " + Rol;
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
                ComprasMetAjustarDashboard();
                ComprasMetAlternarSegundaColumna(_ComprasTlpNavegador);
                foreach (Control ControlActual in _ComprasTlpNavegador.Controls)
                {
                    TableLayoutPanel Panel = ControlActual as TableLayoutPanel;
                    if (Panel != null) ComprasMetAlternarSegundaColumna(Panel);
                }
                _ComprasTlpNavegador.Width = _NavegadorContraido
                    ? 64 + _ComprasTlpNavegador.Padding.Horizontal : 270;
                _ComprasTlpPrincipal.ColumnStyles[0].Width = _NavegadorContraido
                    ? _ComprasTlpNavegador.Width + 16 : 286F;
                _ComprasBtnAlternarNavegador.AccessibleName = _NavegadorContraido
                    ? "Expandir menú" : "Contraer menú";
            }
            finally
            {
                _ComprasTlpNavegador.ResumeLayout(true);
                _ComprasTlpPrincipal.ResumeLayout(true);
                _ComprasPnlMain.PerformLayout();
                ComprasMetAjustarDashboard();
            }
        }

        private void ComprasMetAjustarDashboard()
        {
            ComprasPnlDashboard.PerformLayout();
            ComprasTlpDashboard.PerformLayout();
            ComprasTlpHero.PerformLayout();
            ComprasMetAjustarPresentacion();
        }

        private void ComprasMetAjustarPresentacion()
        {
            bool Compacto = ComprasTlpPresentacion.Height < 320;
            RowStyle Fila = ComprasTlpPresentacion.RowStyles[1];
            SizeType Tipo = Compacto ? SizeType.Absolute : SizeType.Percent;
            float Altura = Compacto ? 64F : 22F;
            if (Fila.SizeType == Tipo && Fila.Height == Altura) return;
            ComprasTlpPresentacion.SuspendLayout();
            try
            {
                Fila.SizeType = Tipo;
                Fila.Height = Altura;
            }
            finally
            {
                ComprasTlpPresentacion.ResumeLayout(true);
            }
        }

        private void ComprasMetAlternarSegundaColumna(TableLayoutPanel Panel)
        {
            if (Panel.ColumnCount < 2 || Panel.ColumnStyles.Count < 2) return;
            Panel.SuspendLayout();
            try
            {
                ColumnStyle Columna = Panel.ColumnStyles[1];
                if (_NavegadorContraido)
                {
                    _ColumnasNavegador[Panel] = new ColumnStyle(Columna.SizeType, Columna.Width);
                    foreach (Control ControlActual in Panel.Controls)
                        if (Panel.GetColumn(ControlActual) == 1) ControlActual.Visible = false;
                    Columna.SizeType = SizeType.Absolute;
                    Columna.Width = 0;
                }
                else
                {
                    ColumnStyle Original;
                    if (!_ColumnasNavegador.TryGetValue(Panel, out Original)) return;
                    Columna.SizeType = Original.SizeType;
                    Columna.Width = Original.Width;
                    foreach (Control ControlActual in Panel.Controls)
                        if (Panel.GetColumn(ControlActual) == 1) ControlActual.Visible = true;
                    _ColumnasNavegador.Remove(Panel);
                }
            }
            finally
            {
                Panel.ResumeLayout(true);
            }
        }
    }
}
