using System.Windows.Forms;

namespace CapaVista_Polizas
{
    public partial class FrmPolizas : Form
    {
        public FrmPolizas()
        {
            InitializeComponent();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
        }
    }
}
