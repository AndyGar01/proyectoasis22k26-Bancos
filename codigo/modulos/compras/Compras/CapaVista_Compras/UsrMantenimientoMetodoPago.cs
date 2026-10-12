using CapaVista_Compras.Componentes;
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
    public partial class UsrMantenimientoMetodoPago : UsrBaseCompras
    {
        public UsrMantenimientoMetodoPago()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tlbMetodopago", 4, 5);
        }

        
        private void UsrMantenimientoMetodoPago_Load(object sender, EventArgs e)
        {

        }
    }
}
