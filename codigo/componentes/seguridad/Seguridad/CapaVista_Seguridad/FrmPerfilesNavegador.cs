using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
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

namespace CapaVista_Seguridad
{
    public partial class FrmPerfilesNavegador : Form
    {

        public FrmPerfilesNavegador()


        {

            InitializeComponent();
            navegador3.NavegadorMetConfigurar("tblaplicacion", 4, 7);
        }
    }
}
