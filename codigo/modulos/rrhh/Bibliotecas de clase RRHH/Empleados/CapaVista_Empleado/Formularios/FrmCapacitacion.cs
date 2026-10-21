using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Empleado.Formularios
{
    public partial class FrmCapacitacion : Form
    {
        public FrmCapacitacion()
        {
            InitializeComponent();
        }

        private void RrhhBtnCapacitacion_Click(object sender, EventArgs e)
        {

            FrmCapacitacionesNavegador Empleados = new FrmCapacitacionesNavegador();
            Empleados.ShowDialog();
        }

        private void RrhhBtnInstructores_Click(object sender, EventArgs e)
        {

            FrmInstructoresNavegador Instructores = new FrmInstructoresNavegador();
            Instructores.ShowDialog();
        }
    }
}
