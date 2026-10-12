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
    public partial class FrmMDICompras : Form
    {
        public FrmMDICompras()
        {
            InitializeComponent();
        }

        private void clsButtonMDICompras1_Click(object sender, EventArgs e)
        {
            MostrarControlCompras<UsrEstadoDeCuenta>();
        }

        private void clsButtonMDICompras4_Click(object sender, EventArgs e)
        {
            MostrarControlCompras<UsrOrdenesDeCompras>();
        }

        private void MostrarControlCompras<T>() where T : UserControl, new()
        {
            var control = ComprasPnlMain.Controls.OfType<T>().FirstOrDefault();

            if (control == null)
            {
                control = new T();
                ComprasPnlMain.Controls.Add(control);
            }

            foreach (Control otroControl in ComprasPnlMain.Controls)
            {
                if (otroControl != control)
                {
                    otroControl.Hide();
                }
            }

            control.Dock = DockStyle.Fill;
            control.Show();
            control.BringToFront();
        }
    }
}
