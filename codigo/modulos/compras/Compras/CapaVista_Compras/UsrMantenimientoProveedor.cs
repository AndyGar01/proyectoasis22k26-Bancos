using CapaVista_Compras.Componentes;
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
    public partial class UsrMantenimientoProveedor : UsrBaseCompras
    {
        public UsrMantenimientoProveedor()
        {
            InitializeComponent();
            ComprasUsrMantenimiento.NavegadorMetConfigurar("tblproveedor", 4, 5);

        }
    }
}
