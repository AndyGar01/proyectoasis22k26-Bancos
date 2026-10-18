using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Inventario_Logistica;
using CapaVista_Inventario_Logistica.Formas;


namespace CapaVista_Logistica
{
    public partial class FrmMDILogistica : Form
    {
        public FrmMDILogistica()
        {
            InitializeComponent();
        }

        private void LogisticaBtnUbicaciones_Click(object sender, EventArgs e)
        {
            CapaVista_Inventario_Logistica.Formas.FrmMantenimientoSucursales frmMantenimientoSucursales = new CapaVista_Inventario_Logistica.Formas.FrmMantenimientoSucursales();
            frmMantenimientoSucursales.ShowDialog();
        }

        private void LogisticaBtnCatalogo_Click(object sender, EventArgs e)
        {
            

        }

        private void LogisticaMetActualizarInfoUsuario(string Nombre, string Rol)
            {
            LogisticaLblUsuario.Text = Nombre;
            LogisticaLblRolUsuario.Text = Rol;  
            LogisticaLbUsuarioRol.Left = LogisticaLblUsuario.Right + 30;
        }
}
}