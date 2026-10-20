using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_AutorizacionOrdenes.Formularios
{
    public partial class FrmTipoCuentaBancariaNavegador : Form
    {
        public FrmTipoCuentaBancariaNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblTipoCuentaBancaria", 8000, 8003);
        }
    }
}
