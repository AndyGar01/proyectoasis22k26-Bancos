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
        private readonly object[,] pagos =
        {
            // No. pago, Proveedor, Factura, Fecha, Monto, Estado
            { "PG-0041", "Distribuidora Maya",    "F-1032", new DateTime(2026, 10, 8),  12500.00m, "Pagado" },
            { "PG-0040", "Papelera del Sur",      "F-0987", new DateTime(2026, 10, 10),  3240.50m, "Programado" },
            { "PG-0039", "Insumos Industriales",  "F-2210", new DateTime(2026, 10, 5),   8900.00m, "Rechazado" },
            { "PG-0038", "Servicios Tecnicos GT", "F-0455", new DateTime(2026, 10, 2),   1750.00m, "Anulado" }
        };

        private readonly DataTable dtPagos = new DataTable();

        public UsrPagosProveedores()
        {
            InitializeComponent();

            this.BackColor = ClsTemaCompras.FondoGeneral;

            CargarCombos();
            InicializarTablaPagos();
            CargarPagos();
            ConfigurarGrid();
        }

        private void CargarCombos()
        {

            CboProveedor.Items.AddRange(new object[] { "Todos", "Distribuidora Maya", "Papelera del Sur", "Insumos Industriales", "Servicios Tecnicos GT" });
            CboProveedor.SelectedIndex = 0;

            CboEstado.Items.AddRange(new object[] { "Todos", "Pagado", "Programado", "Rechazado", "Anulado" });
            CboEstado.SelectedIndex = 0;

            TxtDesde.Text = "01/10/2026";
            TxtHasta.Text = "31/10/2026";

          
            CboProveedorPago.Items.AddRange(new object[] { "Distribuidora Mava", "Distribuidora Maya", "Papelera del Sur" });
            CboProveedorPago.SelectedIndex = 0;

            CboFactura.Items.Add("F-1045 · Q 5,600.00");
            CboFactura.SelectedIndex = 0;

            TxtFechaPago.Text = "10/10/2026";
            TxtMonto.Text = "5600.00";

            CboMetodo.Items.AddRange(new object[] { "Transferencia", "Cheque", "Efectivo" });
            CboMetodo.SelectedIndex = 0;
        }

        private void InicializarTablaPagos()
        {
            dtPagos.Columns.Add("No. pago", typeof(string));
            dtPagos.Columns.Add("Proveedor", typeof(string));
            dtPagos.Columns.Add("Factura", typeof(string));
            dtPagos.Columns.Add("Fecha", typeof(DateTime));
            dtPagos.Columns.Add("Monto", typeof(decimal));
            dtPagos.Columns.Add("Estado", typeof(string));
        }

        private void CargarPagos()
        {
            for (int i = 0; i < pagos.GetLength(0); i++)
            {
                dtPagos.Rows.Add(
                    pagos[i, 0], pagos[i, 1], pagos[i, 2],
                    pagos[i, 3], pagos[i, 4], pagos[i, 5]
                );
            }

            DgvPagos.AutoGenerateColumns = true;
            DgvPagos.DataSource = dtPagos;
        }

        private void ConfigurarGrid()
        {
            DataGridView t = DgvPagos.Tabla;

            t.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            t.Columns["Monto"].DefaultCellStyle.Format = "'Q' #,##0.00";

            AgregarColumnaAccion("Ver", "👁");
            AgregarColumnaAccion("Editar", "✎");
            AgregarColumnaAccion("Eliminar", "🗑");

            
            t.CellFormatting += DgvPagos_CellFormatting;
            t.CellPainting += DgvPagos_CellPainting;
        }

        private void AgregarColumnaAccion(string nombre, string texto)
        {
            var col = new DataGridViewButtonColumn
            {
                Name = nombre,
                HeaderText = "",
                Text = texto,
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                FillWeight = 25,
                MinimumWidth = 44
            };
            col.DefaultCellStyle.BackColor = ClsTemaCompras.PrincipalNavegador;
            col.DefaultCellStyle.ForeColor = Color.White;
            col.DefaultCellStyle.SelectionBackColor = ClsTemaCompras.AcentoNavegador;
            col.DefaultCellStyle.SelectionForeColor = Color.White;
            col.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 9F);
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvPagos.Columns.Add(col);
        }

        // Color del texto según el estado
        private void DgvPagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null) return;
            if (DgvPagos.Columns[e.ColumnIndex].Name != "Estado") return;

            switch (e.Value.ToString())
            {
                case "Pagado": e.CellStyle.ForeColor = Color.LimeGreen; break;
                case "Programado": e.CellStyle.ForeColor = Color.Orange; break;
                case "Rechazado": e.CellStyle.ForeColor = Color.IndianRed; break;
                default: e.CellStyle.ForeColor = Color.Gray; break;
            }
        }

        // En filas "Anulado" solo se muestra el botón Ver (como en la imagen)
        private void DgvPagos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string col = DgvPagos.Columns[e.ColumnIndex].Name;
            if (col != "Editar" && col != "Eliminar") return;

            string estado = Convert.ToString(DgvPagos.Rows[e.RowIndex].Cells["Estado"].Value);
            if (estado != "Anulado") return;

            DataGridView t = DgvPagos.Tabla;
            bool seleccionada = (e.State & DataGridViewElementStates.Selected) != 0;
            Color fondo = seleccionada ? t.DefaultCellStyle.SelectionBackColor : t.DefaultCellStyle.BackColor;

            using (var pincel = new SolidBrush(fondo))
                e.Graphics.FillRectangle(pincel, e.CellBounds);

            e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
            e.Handled = true;
        }

        private void DgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
/*Fin de código de Diana Mishel Loeiza Ramirez 9959-23-3457 el 11/10/2026*/
