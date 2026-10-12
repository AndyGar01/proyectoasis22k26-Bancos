using System;
using System.Data;
using System.Windows.Forms;
using CapaVista_Compras.Componentes;

namespace CapaVista_Compras
{
    public partial class UsrEstadoDeCuenta : UsrBaseCompras
    {
        private readonly object[,] movimientos =
        {
            // Fecha, Tipo de movimiento, Documento, Descripción, Debe, Haber, Saldo, Estado

            {
                new DateTime(2026, 10, 1),
                "Saldo inicial",
                "SAL-001",
                "Saldo inicial del proveedor",
                0.00m, 0.00m, 0.00m,
                "Aplicado"
            },
            {
                new DateTime(2026, 10, 2),
                "Factura",
                "FAC-00125",
                "Compra de suministros de oficina",
                2500.00m, 0.00m, 2500.00m,
                "Pendiente"
            },
            {
                new DateTime(2026, 10, 3),
                "Factura",
                "FAC-00128",
                "Compra de equipo informático",
                4800.00m, 0.00m, 7300.00m,
                "Aplicado"
            },
            {
                new DateTime(2026, 10, 5),
                "Pago",
                "PAG-00045",
                "Pago parcial mediante transferencia",
                0.00m, 3000.00m, 4300.00m,
                "Aplicado"
            },
            {
                new DateTime(2026, 10, 6),
                "Nota de crédito",
                "NC-00018",
                "Descuento por productos defectuosos",
                0.00m, 500.00m, 3800.00m,
                "Aplicado"
            },
            {
                new DateTime(2026, 10, 7),
                "Factura",
                "FAC-00134",
                "Compra de materiales de limpieza",
                1200.00m, 0.00m, 5000.00m,
                "Pendiente"
            },
            {
                new DateTime(2026, 10, 8),
                "Pago",
                "PAG-00049",
                "Pago de factura FAC-00128",
                0.00m, 2000.00m, 3000.00m,
                "Aplicado"
            },
            {
                new DateTime(2026, 10, 10),
                "Factura",
                "FAC-00140",
                "Compra de repuestos para mantenimiento",
                1750.00m, 0.00m, 4750.00m,
                "Pendiente"
            }
        };

        private readonly DataTable dtMovimientos = new DataTable();

        public UsrEstadoDeCuenta()
        {
            InitializeComponent();

            this.BackColor = ClsTemaCompras.FondoGeneral;

            CboProveedores.DropDownStyle = ComboBoxStyle.DropDown;
            CboProveedores.Text = "Buscar Proveedor...";
            InicializarTablaMovimientos();
            CargarMovimientos();
        }
        private void InicializarTablaMovimientos()
        {
            dtMovimientos.Columns.Add("Fecha", typeof(DateTime));
            dtMovimientos.Columns.Add("Tipo de movimiento", typeof(string));
            dtMovimientos.Columns.Add("Documento", typeof(string));
            dtMovimientos.Columns.Add("Descripción", typeof(string));
            dtMovimientos.Columns.Add("Debe", typeof(decimal));
            dtMovimientos.Columns.Add("Haber", typeof(decimal));
            dtMovimientos.Columns.Add("Saldo", typeof(decimal));
            dtMovimientos.Columns.Add("Estado", typeof(string));
        }

        private void CargarMovimientos()
        {
            for (int i = 0; i < movimientos.GetLength(0); i++)
            {
                dtMovimientos.Rows.Add(
                    movimientos[i, 0],
                    movimientos[i, 1],
                    movimientos[i, 2],
                    movimientos[i, 3],
                    movimientos[i, 4],
                    movimientos[i, 5],
                    movimientos[i, 6],
                    movimientos[i, 7]
                );
            }

            DgvMovimientos.AutoGenerateColumns = true;
            DgvMovimientos.DataSource = dtMovimientos;
        }
    }
}