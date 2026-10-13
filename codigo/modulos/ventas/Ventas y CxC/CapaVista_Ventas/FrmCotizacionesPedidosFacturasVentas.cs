/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Dejar una base vacía y editable para cotizaciones, pedidos y facturas.
 */
using System.Windows.Forms;

namespace CapaVista_Ventas
{
    public partial class FrmCotizacionesPedidosFacturasVentas : Form
    {
        public FrmCotizacionesPedidosFacturasVentas()
        {
            InitializeComponent();
        }

        private void VentasBtnAbrirPedidos_Click(object sender, System.EventArgs e)
        {
            using (FrmPedidoVentas Formulario = new FrmPedidoVentas())
            {
                Formulario.ShowDialog(this);
            }
        }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
