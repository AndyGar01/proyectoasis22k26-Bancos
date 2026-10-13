/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Formulario de diseño para el prototipo no funcional de comisiones.
 */
using System.Windows.Forms;

namespace CapaVista_Ventas
{
    public partial class FrmComisionesVendedoresVentas : Form
    {
        public FrmComisionesVendedoresVentas()
        {
            InitializeComponent();
            CargarFilasDeMuestra();
        }

        private void CargarFilasDeMuestra()
        {
            ComisionesDgvVentas.Rows.Add("03/10/2026", "FAC-004581", "Distribuidora El Roble", "Q 12,500.00", "5.00%", "Q 625.00", "Elegible");
            ComisionesDgvVentas.Rows.Add("08/10/2026", "FAC-004612", "Abarrotería San Miguel", "Q 18,750.00", "5.00%", "Q 937.50", "Elegible");
            ComisionesDgvVentas.Rows.Add("14/10/2026", "FAC-004689", "Comercial La Esperanza", "Q 17,500.00", "5.00%", "Q 875.00", "Elegible");
            ComisionesDgvHistorial.Rows.Add("Octubre 2026", "Ana López", "12", "Q 2,437.50", "COM-2026-0108", "Pendiente");
            ComisionesDgvHistorial.Rows.Add("Octubre 2026", "Mario Castillo", "9", "Q 1,820.00", "COM-2026-0107", "Aprobada");
            ComisionesDgvHistorial.Rows.Add("Septiembre 2026", "Ana López", "15", "Q 2,190.00", "COM-2026-0092", "Enviada a nómina");
            ComisionesDgvHistorial.Rows.Add("Septiembre 2026", "Carlos Méndez", "7", "Q 980.00", "COM-2026-0091", "Rechazada");
            ComisionesDgvAutorizacion.Rows.Add("Octubre 2026", "Ana López", "12", "Q 2,437.50", "20/10/2026", "Pendiente");
            ComisionesDgvAutorizacion.Rows.Add("Octubre 2026", "Luis García", "8", "Q 1,480.00", "19/10/2026", "Pendiente");
        }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
