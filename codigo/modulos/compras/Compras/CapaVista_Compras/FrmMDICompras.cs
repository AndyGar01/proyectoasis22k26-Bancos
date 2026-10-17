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
        private TransicionNavegador _TransicionNavegador;
        private Form _FormularioSubproceso;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _OpcionSubproceso;
        private bool _ContenidoOculto;
        private bool _NavegadorContraido;
        private bool _PantallaCompleta;
        private FormBorderStyle _BordeAnterior;
        private FormWindowState _EstadoAnterior;
        private System.Drawing.Rectangle _LimitesAnteriores;
        private readonly Dictionary<TableLayoutPanel, ColumnStyle> _ColumnasNavegador =
            new Dictionary<TableLayoutPanel, ColumnStyle>();

        public FrmMDICompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
            foreach (Control ControlActual in _ComprasTlpNavegador.Controls)
            {
                CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras Panel = ControlActual as CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras;
                if (Panel != null) ComprasMetConfigurarEstadosTab(Panel, Panel);
            }
            ComprasTlpPresentacion.SizeChanged += (Origen, Argumentos) => ComprasMetAjustarPresentacion();
            ComprasMetAjustarPresentacion();
            ComprasMetActualizarInfoUsuario();
        }

        protected override bool ProcessCmdKey(ref Message Mensaje, Keys Teclas)
        {
            if (Teclas != (Keys.Alt | Keys.Enter)) return base.ProcessCmdKey(ref Mensaje, Teclas);
            if ((Mensaje.LParam.ToInt64() & (1L << 30)) != 0) return true;
            ComprasMetAlternarPantallaCompleta();
            return true;
        }

        private void ComprasMetAlternarPantallaCompleta()
        {
            SuspendLayout();
            try
            {
                if (!_PantallaCompleta)
                {
                    _BordeAnterior = FormBorderStyle;
                    _EstadoAnterior = WindowState;
                    _LimitesAnteriores = WindowState == FormWindowState.Normal ? Bounds : RestoreBounds;
                    System.Drawing.Rectangle Pantalla = Screen.FromControl(this).WorkingArea;
                    WindowState = FormWindowState.Normal;
                    FormBorderStyle = FormBorderStyle.None;
                    Bounds = Pantalla;
                    _PantallaCompleta = true;
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    FormBorderStyle = _BordeAnterior;
                    Bounds = _LimitesAnteriores;
                    WindowState = _EstadoAnterior;
                    _PantallaCompleta = false;
                }
            }
            finally
            {
                ResumeLayout(true);
                ComprasMetAjustarDashboard();
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

        private void ComprasMetConfigurarEstadosTab(Control Elemento, CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras Panel)
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

        private void ComprasMetAbrirSubproceso<T>(CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras Opcion) where T : Form, new()
        {
            if (IsDisposed || Disposing) return;
            if (_FormularioSubproceso != null && !_FormularioSubproceso.IsDisposed)
            {
                if (_FormularioSubproceso is T)
                {
                    if (_FormularioSubproceso.WindowState == FormWindowState.Minimized)
                        _FormularioSubproceso.WindowState = FormWindowState.Normal;
                    _FormularioSubproceso.Activate();
                    return;
                }
                _FormularioSubproceso.Close();
                if (_FormularioSubproceso != null && !_FormularioSubproceso.IsDisposed) return;
            }

            T Formulario = new T();
            try
            {
                Formulario.StartPosition = FormStartPosition.Manual;
                Formulario.Load += (Origen, Evento) => ComprasMetCentrarSubproceso(Formulario);
                Formulario.ShowInTaskbar = false;
                Formulario.MaximizeBox = false;
                Formulario.MinimizeBox = false;
                Formulario.FormClosed += ComprasMetSubprocesoCerrado;
                _FormularioSubproceso = Formulario;
                _OpcionSubproceso = Opcion;
                ComprasMetActualizarSeleccionSubproceso();
                // La ventana pertenece a Compras y permanece encima de ella.
                Formulario.Show(this);
                Formulario.Activate();
            }
            catch
            {
                Formulario.FormClosed -= ComprasMetSubprocesoCerrado;
                Formulario.Dispose();
                _FormularioSubproceso = null;
                _OpcionSubproceso = null;
                ComprasMetActualizarSeleccionSubproceso();
                throw;
            }
        }

        private void ComprasMetCentrarSubproceso(Form Formulario)
        {
            System.Drawing.Rectangle Area = Screen.FromControl(this).WorkingArea;
            int Izquierda = Left + (Width - Formulario.Width) / 2;
            int Arriba = Top + (Height - Formulario.Height) / 2;
            Formulario.Location = new System.Drawing.Point(
                Math.Max(Area.Left, Math.Min(Izquierda, Area.Right - Formulario.Width)),
                Math.Max(Area.Top, Math.Min(Arriba, Area.Bottom - Formulario.Height)));
        }

        private void ComprasMetActualizarSeleccionSubproceso()
        {
            if (IsDisposed || Disposing) return;
            foreach (Control ControlActual in _ComprasTlpNavegador.Controls)
            {
                var Opcion = ControlActual as CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras;
                if (Opcion == null) continue;
                Opcion.Seleccionado = ReferenceEquals(Opcion, _OpcionSubproceso);
                if (!Opcion.Seleccionado) Opcion.ComprasProcActualizarHover(false);
            }
        }

        private void ComprasMetSubprocesoCerrado(object Remitente, FormClosedEventArgs Evento)
        {
            Form Formulario = (Form)Remitente;
            Formulario.FormClosed -= ComprasMetSubprocesoCerrado;
            if (!ReferenceEquals(_FormularioSubproceso, Formulario)) return;
            _FormularioSubproceso = null;
            _OpcionSubproceso = null;
            ComprasMetActualizarSeleccionSubproceso();
        }

        private void ComprasMetAbrirMovimientosProveedores(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<CapaVista_MovimientosProveedores.FrmMovimientosProveedores>(_ComprasTlpMovimientosProveedores);
        }

        private void ComprasMetAbrirPolizas(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<CapaVista_Polizas.FrmPolizas>(_ComprasTlpPolizas);
        }

        private void ComprasMetAbrirOrdenesCompra(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<CapaVista_OrdenesCompra.FrmOrdenesCompra>(_ComprasTlpOrdenesCompra);
        }

        private void ComprasMetAbrirPagosProveedores(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<CapaVista_PagosProveedores.FrmPagosProveedores>(_ComprasTlpPagosProveedores);
        }

        private void ComprasMetAbrirAprobacionFinanciera(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<CapaVista_AprobacionFinanciera.FrmAprobacionFinanciera>(_ComprasTlpAprobacionFinanciera);
        }

        private void ComprasMetAbrirCierreMovimientos(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<CapaVista_CierreMovimientos.FrmCierreMovimientos>(_ComprasTlpCierreMovimientos);
        }

        private void ComprasMetAbrirProveedores(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<FrmMantenimientoProveedor>(_ComprasTlpProveedores);
        }

        private void ComprasMetAbrirMetodosPago(object Remitente, EventArgs Evento)
        {
            ComprasMetAbrirSubproceso<FrmMantenimientoMetodoPago>(_ComprasTlpMetodosPago);
        }

        private void ComprasMetOpcionPendienteClick(object Remitente, EventArgs Evento)
        {
            // Punto de integracion existente para mantenimientos y bitacora.
        }

        private void ComprasBtnSalir_Click(object Remitente, EventArgs Evento)
        {
            Close();
        }

        private async void ComprasBtnBurger_Click(object Remitente, EventArgs Evento)
        {
            if (_ContenidoOculto || _TransicionNavegador != null) return;
            _ContenidoOculto = true;
            bool EncabezadoVisible = _ComprasTlpEncabezado.Visible;
            bool ContenidoVisible = _ComprasPnlMain.Visible;
            var Tiempo = System.Diagnostics.Stopwatch.StartNew();
            _ComprasTlpPrincipal.SuspendLayout();
            try
            {
                _ComprasTlpEncabezado.Visible = false;
                _ComprasPnlMain.Visible = false;
            }
            finally
            {
                _ComprasTlpPrincipal.ResumeLayout(true);
            }
            try
            {
                _ComprasTlpPrincipal.Refresh();
                ComprasMetCambiarNavegador();
                int Espera = Math.Max(1, 500 - (int)Tiempo.ElapsedMilliseconds);
                await System.Threading.Tasks.Task.Delay(Espera);
            }
            finally
            {
                if (!IsDisposed && !Disposing)
                {
                    using (var Cubierta = new Panel())
                    {
                        Cubierta.BackColor = _ComprasTlpPrincipal.BackColor;
                        int Izquierda = _ComprasTlpPrincipal.Left + _ComprasTlpPrincipal.Padding.Left
                            + (int)_ComprasTlpPrincipal.ColumnStyles[0].Width;
                        Cubierta.Bounds = new System.Drawing.Rectangle(Izquierda, _ComprasTlpPrincipal.Top,
                            Math.Max(0, _ComprasTlpPrincipal.Right - Izquierda), _ComprasTlpPrincipal.Height);
                        Controls.Add(Cubierta);
                        Cubierta.BringToFront();
                        Cubierta.Refresh();
                        _ComprasTlpPrincipal.SuspendLayout();
                        try
                        {
                            _ComprasTlpEncabezado.Visible = EncabezadoVisible;
                            _ComprasPnlMain.Visible = ContenidoVisible;
                        }
                        finally
                        {
                            _ComprasTlpPrincipal.ResumeLayout(true);
                        }
                        _ComprasPnlMain.PerformLayout();
                        ComprasMetAjustarDashboard();
                        _ComprasTlpEncabezado.Refresh();
                        _ComprasPnlMain.Refresh();
                        Controls.Remove(Cubierta);
                        _ComprasTlpPrincipal.Refresh();
                    }
                }
                _ContenidoOculto = false;
            }
        }

        private void ComprasMetCambiarNavegador()
        {
            bool Contraer = !_NavegadorContraido;
            int AnchoAnterior = _ComprasTlpNavegador.Width;
            int AnchoFinal = Contraer ? 64 + _ComprasTlpNavegador.Padding.Horizontal : 270;
            System.Drawing.Bitmap ImagenMenu = null;
            if (Contraer)
            {
                ImagenMenu = new System.Drawing.Bitmap(_ComprasTlpNavegador.Width, _ComprasTlpNavegador.Height);
                _ComprasTlpNavegador.DrawToBitmap(ImagenMenu, _ComprasTlpNavegador.ClientRectangle);
            }
            _NavegadorContraido = !_NavegadorContraido;
            _ComprasTlpPrincipal.SuspendLayout();
            _ComprasTlpNavegador.SuspendLayout();
            try
            {
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
                if (ImagenMenu == null)
                {
                    ImagenMenu = new System.Drawing.Bitmap(_ComprasTlpNavegador.Width, _ComprasTlpNavegador.Height);
                    _ComprasTlpNavegador.DrawToBitmap(ImagenMenu, _ComprasTlpNavegador.ClientRectangle);
                }
                var Cubierta = new TransicionNavegador(ImagenMenu, AnchoAnterior, AnchoFinal);
                _TransicionNavegador = Cubierta;
                Cubierta.Disposed += (Origen, Argumentos) => _TransicionNavegador = null;
                Cubierta.Location = PointToClient(_ComprasTlpNavegador.PointToScreen(System.Drawing.Point.Empty));
                Cubierta.Size = new System.Drawing.Size(Math.Max(AnchoAnterior, AnchoFinal), _ComprasTlpNavegador.Height);
                Cubierta.BackColor = _ComprasTlpPrincipal.BackColor;
                Controls.Add(Cubierta);
                Cubierta.BringToFront();
                Cubierta.Iniciar();
            }
        }

        private sealed class TransicionNavegador : Control
        {
            private readonly System.Drawing.Bitmap _Menu;
            private readonly Timer _Reloj = new Timer { Interval = 15 };
            private readonly System.Diagnostics.Stopwatch _Tiempo = new System.Diagnostics.Stopwatch();
            private readonly int _Desde, _Hasta;
            private int _AnchoVisible;

            internal TransicionNavegador(System.Drawing.Bitmap Menu, int Desde, int Hasta)
            {
                _Menu = Menu;
                _Desde = Desde;
                _Hasta = Hasta;
                _AnchoVisible = Desde;
                SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint
                    | ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque, true);
                _Reloj.Tick += (Origen, Argumentos) =>
                {
                    double Paso = Math.Min(1D, _Tiempo.Elapsed.TotalMilliseconds / 260D);
                    if (Paso >= 1D)
                    {
                        Dispose();
                        return;
                    }
                    Paso = Paso * Paso * Paso * (Paso * (Paso * 6D - 15D) + 10D);
                    _AnchoVisible = (int)Math.Round(_Desde + (_Hasta - _Desde) * Paso);
                    Invalidate();
                };
            }

            internal void Iniciar()
            {
                Refresh();
                _Tiempo.Start();
                _Reloj.Start();
            }

            protected override void OnPaintBackground(PaintEventArgs Evento) { }

            protected override void OnPaint(PaintEventArgs Evento)
            {
                Evento.Graphics.Clear(BackColor);
                var Estado = Evento.Graphics.Save();
                Evento.Graphics.SetClip(new System.Drawing.Rectangle(0, 0, _AnchoVisible, Height));
                Evento.Graphics.DrawImageUnscaled(_Menu, 0, 0);
                Evento.Graphics.Restore(Estado);
            }

            protected override void Dispose(bool Disposing)
            {
                if (Disposing)
                {
                    _Reloj.Dispose();
                    _Menu.Dispose();
                }
                base.Dispose(Disposing);
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
