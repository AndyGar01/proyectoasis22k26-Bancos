using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Navegador;

namespace CapaVista_Inventario_Logistica.Formas
{
    public partial class FrmMantenimientoSucursales : Form
    {
        public FrmMantenimientoSucursales()
        {
            InitializeComponent();
            LogisticaNavSucursales.NavegadorMetConfigurar("tblsucursal", 4, 5);
        

    }
    }
}
