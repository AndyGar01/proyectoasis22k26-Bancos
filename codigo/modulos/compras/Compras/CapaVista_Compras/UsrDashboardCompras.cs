using CapaVista_Compras.Componentes;

namespace CapaVista_Compras
{
    public partial class UsrDashboardCompras : UsrBaseCompras
    {
        public UsrDashboardCompras()
        {
            InitializeComponent();
            ComprasTlpPresentacion.SizeChanged += (sender, e) => ComprasMetAjustarPresentacion();
            ComprasMetAjustarPresentacion();
        }

        private void ComprasMetAjustarPresentacion()
        {
            bool Compacto = ComprasTlpPresentacion.Height < 320;
            var Fila = ComprasTlpPresentacion.RowStyles[1];
            var Tipo = Compacto ? System.Windows.Forms.SizeType.Absolute : System.Windows.Forms.SizeType.Percent;
            float Altura = Compacto ? 64F : 22F;
            if (Fila.SizeType == Tipo && Fila.Height == Altura) return;
            ComprasTlpPresentacion.SuspendLayout();
            Fila.SizeType = Tipo;
            Fila.Height = Altura;
            ComprasTlpPresentacion.ResumeLayout(true);
        }
    }
}
