using CapaVista_Componentes.Componentes;
using CapaVista_Navegador;
using System;
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
    public partial class FrmMantenimientoMetodoPago : Form
    {
        public FrmMantenimientoMetodoPago()
        {
            InitializeComponent();
            ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
            ComprasUsrMantenimiento.NavegadorMetConfigurar("tlbMetodopago", 4, 5);
        }


        private void ComprasMetFrmMantenimientoMetodoPago_Load(object Remitente, EventArgs Evento)
        {

        }
    }
}
