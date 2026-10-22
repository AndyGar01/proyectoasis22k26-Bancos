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
    public partial class FrmInstructoresNavegador : Form
    {
        public FrmInstructoresNavegador()
        {
            InitializeComponent();
            RrhhNavInstructores.NavegadorMetConfigurar("tblInstructor", 9000, 9303);
        }

        private void RrhhBtnReporteInstructor_Click(object sender, EventArgs e)
        {
            frmReportes.FrmReporteInstructor Instructor = new frmReportes.FrmReporteInstructor();
            Instructor.ShowDialog();
        }

        private void RrhhBtnAyudaInstructor_Click(object sender, EventArgs e)
        {

        }
    }
}
