using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_TransporteInterno_Logistica.Formas
{
    public partial class FrmTransporteInterno : Form
    {
        public FrmTransporteInterno()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestionViajes frmGestionViajes = new FrmGestionViajes();
            frmGestionViajes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmControlTransporte frmControlTransporte = new FrmControlTransporte();
            frmControlTransporte.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmConsultaTransporte frmConsultaTransporte = new FrmConsultaTransporte();
            frmConsultaTransporte.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
