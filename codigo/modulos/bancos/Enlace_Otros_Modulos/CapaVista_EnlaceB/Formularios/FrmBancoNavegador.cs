using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_EnlaceB.Formularios
{
    public partial class FrmBancoNavegador : Form
    {
        public FrmBancoNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblBanco", 8000, 8002);
            foreach (Control ctrl in navegador1.Controls)
            {
                ctrl.BackColor = Color.FromArgb(46, 138, 85);
                foreach (Control inner in ctrl.Controls)
                {
                    inner.BackColor = Color.FromArgb(46, 138, 85);
                }
            }
        }
    }
}
