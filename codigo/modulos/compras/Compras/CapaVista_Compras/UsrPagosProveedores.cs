using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaVista_Compras.Componentes;

namespace CapaVista_Compras
{
    /*Inicio de código de Diana Mishel Loeiza Ramirez 9959-23-3457 el 11/10/2026*/

    public partial class UsrPagosProveedores : UsrBaseCompras
    {
        private readonly object[,] _Pagos =
        {
            // No. pago, Proveedor, Factura, Fecha, Monto, Estado
            { "PG-0041", "Distribuidora Maya",    "F-1032", new DateTime(2026, 10, 8),  12500.00m, "Pagado" },
            { "PG-0040", "Papelera del Sur",      "F-0987", new DateTime(2026, 10, 10),  3240.50m, "Programado" },
            { "PG-0039", "Insumos Industriales",  "F-2210", new DateTime(2026, 10, 5),   8900.00m, "Rechazado" },
            { "PG-0038", "Servicios Tecnicos GT", "F-0455", new DateTime(2026, 10, 2),   1750.00m, "Anulado" }
        };

        private readonly DataTable _TablaPagos = new DataTable();

        public UsrPagosProveedores()
        {
            InitializeComponent();

            this.BackColor = ClsTemaCompras.FondoGeneral;

            ComprasProcCargarCombos();
            ComprasProcInicializarTablaPagos();
            ComprasProcCargarPagos();
            ComprasProcConfigurarGrid();
        }

        private void ComprasProcCargarCombos()
        {

            ComprasUsrCboProveedor.Items.AddRange(new object[] { "Todos", "Distribuidora Maya", "Papelera del Sur", "Insumos Industriales", "Servicios Tecnicos GT" });
            ComprasUsrCboProveedor.SelectedIndex = 0;

            ComprasUsrCboEstado.Items.AddRange(new object[] { "Todos", "Pagado", "Programado", "Rechazado", "Anulado" });
            ComprasUsrCboEstado.SelectedIndex = 0;

            ComprasUsrTxtDesde.Text = "01/10/2026";
            ComprasUsrTxtHasta.Text = "31/10/2026";


            ComprasUsrCboProveedorPago.Items.AddRange(new object[] { "Distribuidora Mava", "Distribuidora Maya", "Papelera del Sur" });
            ComprasUsrCboProveedorPago.SelectedIndex = 0;

            ComprasUsrCboFactura.Items.Add("F-1045 · Q 5,600.00");
            ComprasUsrCboFactura.SelectedIndex = 0;

            ComprasUsrTxtFechaPago.Text = "10/10/2026";
            ComprasUsrTxtMonto.Text = "5600.00";

            ComprasUsrCboMetodo.Items.AddRange(new object[] { "Transferencia", "Cheque", "Efectivo" });
            ComprasUsrCboMetodo.SelectedIndex = 0;
        }

        private void ComprasProcInicializarTablaPagos()
        {
            _TablaPagos.Columns.Add("No. pago", typeof(string));
            _TablaPagos.Columns.Add("Proveedor", typeof(string));
            _TablaPagos.Columns.Add("Factura", typeof(string));
            _TablaPagos.Columns.Add("Fecha", typeof(DateTime));
            _TablaPagos.Columns.Add("Monto", typeof(decimal));
            _TablaPagos.Columns.Add("Estado", typeof(string));
        }

        private void ComprasProcCargarPagos()
        {
            for (int Indice = 0; Indice < _Pagos.GetLength(0); Indice++)
            {
                _TablaPagos.Rows.Add(
                    _Pagos[Indice, 0], _Pagos[Indice, 1], _Pagos[Indice, 2],
                    _Pagos[Indice, 3], _Pagos[Indice, 4], _Pagos[Indice, 5]
                );
            }

            ComprasUsrPagos.AutoGenerateColumns = true;
            ComprasUsrPagos.DataSource = _TablaPagos;
        }

        private void ComprasProcConfigurarGrid()
        {
            DataGridView Tabla = ComprasUsrPagos.Tabla;

            Tabla.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            Tabla.Columns["Monto"].DefaultCellStyle.Format = "'Q' #,##0.00";

            ComprasProcAgregarColumnaAccion("Ver", "👁");
            ComprasProcAgregarColumnaAccion("Editar", "✎");
            ComprasProcAgregarColumnaAccion("Eliminar", "🗑");


            Tabla.CellFormatting += ComprasMetDgvPagosCellFormatting;
            Tabla.CellPainting += ComprasMetDgvPagosCellPainting;
        }

        private void ComprasProcAgregarColumnaAccion(string Nombre, string Texto)
        {
            var Columna = new DataGridViewButtonColumn
            {
                Name = Nombre,
                HeaderText = "",
                Text = Texto,
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                FillWeight = 25,
                MinimumWidth = 44
            };
            Columna.DefaultCellStyle.BackColor = ClsTemaCompras.PrincipalNavegador;
            Columna.DefaultCellStyle.ForeColor = Color.White;
            Columna.DefaultCellStyle.SelectionBackColor = ClsTemaCompras.AcentoNavegador;
            Columna.DefaultCellStyle.SelectionForeColor = Color.White;
            Columna.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 9F);
            Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ComprasUsrPagos.Columns.Add(Columna);
        }

        // Color del texto según el estado
        private void ComprasMetDgvPagosCellFormatting(object Remitente, DataGridViewCellFormattingEventArgs Evento)
        {
            if (Evento.RowIndex < 0 || Evento.ColumnIndex < 0 || Evento.Value == null) return;
            if (ComprasUsrPagos.Columns[Evento.ColumnIndex].Name != "Estado") return;

            switch (Evento.Value.ToString())
            {
                case "Pagado": Evento.CellStyle.ForeColor = Color.LimeGreen; break;
                case "Programado": Evento.CellStyle.ForeColor = Color.Orange; break;
                case "Rechazado": Evento.CellStyle.ForeColor = Color.IndianRed; break;
                default: Evento.CellStyle.ForeColor = Color.Gray; break;
            }
        }

        // visualización filas anuladas para las columnas de accion
        private void ComprasMetDgvPagosCellPainting(object Remitente, DataGridViewCellPaintingEventArgs Evento)
        {
            if (Evento.RowIndex < 0 || Evento.ColumnIndex < 0) return;

            string Columna = ComprasUsrPagos.Columns[Evento.ColumnIndex].Name;
            if (Columna != "Editar" && Columna != "Eliminar") return;

            string Estado = Convert.ToString(ComprasUsrPagos.Rows[Evento.RowIndex].Cells["Estado"].Value);
            if (Estado != "Anulado") return;

            DataGridView Tabla = ComprasUsrPagos.Tabla;
            bool Seleccionada = (Evento.State & DataGridViewElementStates.Selected) != 0;
            Color Fondo = Seleccionada ? Tabla.DefaultCellStyle.SelectionBackColor : Tabla.DefaultCellStyle.BackColor;

            using (var Pincel = new SolidBrush(Fondo))
                Evento.Graphics.FillRectangle(Pincel, Evento.CellBounds);

            Evento.Paint(Evento.ClipBounds, DataGridViewPaintParts.Border);
            Evento.Handled = true;
        }

        private void ComprasMetDgvPagosCellClick(object Remitente, DataGridViewCellEventArgs Evento)
        {

        }
    }
}
/*Fin de código de Diana Mishel Loeiza Ramirez 9959-23-3457 el 11/10/2026*/
