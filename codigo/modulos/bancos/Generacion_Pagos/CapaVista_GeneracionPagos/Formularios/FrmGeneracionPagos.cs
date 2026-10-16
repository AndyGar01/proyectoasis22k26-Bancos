// ============================================================================
// Área       : Bancos
// Subproceso : 5.6 Proceso de generación de pagos
// Autor      : Evelyn Sofía Andrade Luna
// Carné      : 9959-23-1224
// Fecha      : 15/10/2026
// Propósito  : Ventana 8004 – Generación de Pagos (prototipo no funcional).
// Reglas     : Los datos que se muestran son de ejemplo y sirven solo para
//              presentar el diseño. Los importes usan el formato
//              "Q 1,250.00" y las fechas DD/MM/AAAA. Cuando se conecte la
//              lógica, la Vista solo debe conversar con el Controlador.
// ============================================================================

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_GeneracionPagos.Formularios
{
    public partial class FrmGeneracionPagos : Form
    {
        private const string TextoBusqueda = "Documento o beneficiario";

        private static readonly Color _ColorPrincipal = Color.FromArgb(28, 74, 48);
        private static readonly Color _ColorAcento = Color.FromArgb(46, 138, 85);
        private static readonly Color _ColorEtiquetas = Color.FromArgb(210, 169, 59);
        private static readonly Color _ColorBotones = Color.FromArgb(212, 231, 211);
        private static readonly Color _ColorTexto = Color.FromArgb(40, 40, 40);
        private static readonly Color _ColorMarcador = Color.FromArgb(120, 130, 122);
        private static readonly Color _ColorPestanaInactiva = Color.FromArgb(228, 236, 227);

        public FrmGeneracionPagos()
        {
            InitializeComponent();
        }

        private void FrmGeneracionPagos_Load(object sender, EventArgs e)
        {
            BancosMetCargarVistaPrevia();
        }

        // Datos de ejemplo

        private void BancosMetCargarVistaPrevia()
        {
            BancosDgvObligaciones.Rows.Clear();
            BancosDgvObligaciones.Rows.Add("Compras y CxP", "OC-1042", "Cárnicos del Norte, S.A.", "20/10/2026", "GTQ", "Q 25,000.00");
            BancosDgvObligaciones.Rows.Add("Recursos Humanos", "PL-1015", "Planilla quincenal octubre", "15/10/2026", "GTQ", "Q 48,500.00");
            BancosDgvObligaciones.Rows.Add("Logística", "GU-0377", "Guatex, S.A. (transporte)", "22/10/2026", "USD", "US$ 1,000.00");
            BancosDgvObligaciones.CurrentCell = BancosDgvObligaciones.Rows[2].Cells[0];

            BancosDgvOrdenes.Rows.Clear();
            BancosDgvOrdenes.Rows.Add("OP-0001", "Cárnicos del Norte, S.A.", "GTQ", "Q 18,000.00", "Pendiente");
            BancosDgvOrdenes.Rows.Add("OP-0002", "Transporte Rápido, S.A.", "GTQ", "Q 12,000.00", "Autorizada");
            BancosDgvOrdenes.Rows.Add("OP-0003", "Distribuidora La Fortuna, S.A.", "GTQ", "Q 9,200.00", "Emitida");
            foreach (DataGridViewRow Fila in BancosDgvOrdenes.Rows)
            {
                BancosMetPintarEstado(Fila.Cells[4]);
            }
            BancosDgvOrdenes.ClearSelection();

            BancosDgvRegPoliza.Rows.Clear();
            BancosDgvRegPoliza.Rows.Add("2.01.03.001", "Fletes por pagar", "Q 7,753.20", string.Empty);
            BancosDgvRegPoliza.Rows.Add("1.01.02.003", "Bancos – Industrial 001-987654-3", string.Empty, "Q 7,753.20");
            BancosDgvRegPoliza.ClearSelection();
        }

        // Muestra el estado de la orden como una etiqueta de color dentro de la celda.
        private void BancosMetPintarEstado(DataGridViewCell Celda)
        {
            Color Fondo;
            Color Texto;
            switch (Convert.ToString(Celda.Value))
            {
                case "Autorizada":
                    Fondo = _ColorBotones;
                    Texto = _ColorPrincipal;
                    break;
                case "Emitida":
                    Fondo = _ColorAcento;
                    Texto = Color.White;
                    break;
                default:
                    Fondo = _ColorEtiquetas;
                    Texto = Color.FromArgb(60, 45, 5);
                    break;
            }

            Celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Celda.Style.BackColor = Fondo;
            Celda.Style.ForeColor = Texto;
            Celda.Style.SelectionBackColor = Fondo;
            Celda.Style.SelectionForeColor = Texto;
        }

        // Pestañas del proceso: Preparar, Autorizar, Emitir y Registrar

        private void BancosTbcProceso_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl Pestanas = (TabControl)sender;
            Rectangle Area = Pestanas.GetTabRect(e.Index);
            bool Activa = e.Index == Pestanas.SelectedIndex;

            using (SolidBrush Fondo = new SolidBrush(Activa ? Color.White : _ColorPestanaInactiva))
            {
                e.Graphics.FillRectangle(Fondo, Area);
            }
            if (Activa)
            {
                using (SolidBrush Linea = new SolidBrush(_ColorAcento))
                {
                    e.Graphics.FillRectangle(Linea, Area.X, Area.Y, Area.Width, 3);
                }
            }

            const int Diametro = 20;
            Rectangle Circulo = new Rectangle(Area.X + 18, Area.Y + ((Area.Height - Diametro) / 2) + 1, Diametro, Diametro);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (SolidBrush Relleno = new SolidBrush(Activa ? _ColorAcento : Color.FromArgb(150, 165, 152)))
            {
                e.Graphics.FillEllipse(Relleno, Circulo);
            }

            TextFormatFlags Centrado = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;
            using (Font FuenteNumero = new Font("Segoe UI", 9F, FontStyle.Bold))
            {
                TextRenderer.DrawText(e.Graphics, (e.Index + 1).ToString(), FuenteNumero, Circulo, Color.White, Centrado);
            }

            Rectangle Texto = new Rectangle(Circulo.Right + 8, Area.Y, Area.Right - Circulo.Right - 10, Area.Height);
            TextFormatFlags Izquierda = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;
            using (Font FuenteTexto = new Font("Segoe UI", 10F, Activa ? FontStyle.Bold : FontStyle.Regular))
            {
                TextRenderer.DrawText(e.Graphics, Pestanas.TabPages[e.Index].Text, FuenteTexto, Texto,
                    Activa ? _ColorPrincipal : _ColorMarcador, Izquierda);
            }
        }

        // Cuadro de búsqueda con texto guía

        private void BancosTxtBuscar_Enter(object sender, EventArgs e)
        {
            if (BancosTxtBuscar.Text == TextoBusqueda)
            {
                BancosTxtBuscar.Text = string.Empty;
                BancosTxtBuscar.ForeColor = _ColorTexto;
            }
        }

        private void BancosTxtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BancosTxtBuscar.Text))
            {
                BancosTxtBuscar.Text = TextoBusqueda;
                BancosTxtBuscar.ForeColor = _ColorMarcador;
            }
        }

        private void BancosBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
