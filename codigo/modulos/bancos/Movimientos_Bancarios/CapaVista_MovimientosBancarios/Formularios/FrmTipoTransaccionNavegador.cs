using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_MovimientosBancarios.Formularios
{
    public partial class FrmTipoTransaccionNavegador : Form
    {
        public FrmTipoTransaccionNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblmodulo", 4, 6);
        }
    }
}
