using System.Windows.Forms;
using System.Drawing;

namespace CapaVista_Componentes.Componentes
{
    public static class ClsPresentacionCompras
    {
        public static Size TamanoFormulario => new Size(1300, 700);
        public static int AlturaContenido => 723;

        public static void ComprasMetFijarTamanoFormulario(Form Formulario)
        {
            Formulario.AutoSize = false;
            Formulario.FormBorderStyle = FormBorderStyle.FixedSingle;
            Formulario.MaximizeBox = false;
            Formulario.ClientSize = TamanoFormulario;
            Formulario.MinimumSize = Formulario.Size;
            Formulario.MaximumSize = Formulario.Size;
            ComprasMetAplicarScrollVertical(Formulario);
        }

        private static void ComprasMetAplicarScrollVertical(Control Contenedor)
        {
            DataGridView Tabla = Contenedor as DataGridView;
            if (Tabla != null) Tabla.ScrollBars = ScrollBars.Vertical;
            foreach (Control Hijo in Contenedor.Controls) ComprasMetAplicarScrollVertical(Hijo);
        }

        public static void ComprasProcAgregarColumna(UsrDataGridViewCompras Tabla, string Campo,
            string Encabezado, int Peso, bool EsMonto)
        {
            Tabla.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn
            {
                Name = "ComprasCol" + Campo,
                DataPropertyName = Campo,
                HeaderText = Encabezado,
                FillWeight = Peso
            };

            if (EsMonto)
            {
                Columna.DefaultCellStyle.Format = "N2";
                Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            Tabla.Columns.Add(Columna);
        }

        public static void ComprasProcMostrarMonto(UsrTextBoxCompras Entrada, decimal Monto)
        {
            Entrada.Text = Monto.ToString("N2");
            Entrada.Entrada.SelectAll();
            Entrada.Entrada.SelectionAlignment = HorizontalAlignment.Right;
        }

    }
}
