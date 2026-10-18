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

namespace CapaVista_Inventario_Logistica.Formas
{
    public partial class FrmMantenimientoSucursales : Form
    {
        public FrmMantenimientoSucursales()
        {
            InitializeComponent(); // <-- Esta es la única llamada necesaria a InitializeComponent
        }

        private void LogisticaNavSucursales_Load(object sender, EventArgs e)
        {
            // Se eliminó la llamada duplicada a InitializeComponent()
            LogisticaNavSucursales.NavegadorMetConfigurar("tblSucursal", 4, 5);
        }
    }
}