using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    public partial class UsrBaseCompras : UserControl
    {

        private Size _TamanoDiseno;
        private float _EscalaAltura = 1F;
        internal event EventHandler ComprasEvtTamanoNecesario;
        internal Size ComprasTamanoDiseno => _TamanoDiseno;

        [Category("Compras")]
        [DisplayName("Ancho maximizado")]
        [Description("True: ancho de 1807. False: ancho de 1610. Conserva la altura actual, con un mínimo de 723.")]
        [DefaultValue(false)]
        [RefreshProperties(RefreshProperties.All)]
        public bool AnchoMaximizado
        {
            get { return Width == 1807; }
            set
            {
                int Altura = Math.Max(Height, 723);
                MaximumSize = new Size(1807, 0);
                MinimumSize = new Size(1610, 723);
                Size = new Size(value ? 1807 : 1610, Altura);
                if (!_TamanoDiseno.IsEmpty)
                {
                    _TamanoDiseno = new Size(Width, _TamanoDiseno.Height);
                    ComprasProcNotificarTamano();
                }
            }
        }

        internal void ComprasProcRegistrarDiseno()
        {
            _TamanoDiseno = ClientSize;
        }

        internal int ComprasFuncEscalarAltura(float Altura)
        {
            return (int)Math.Ceiling(Altura * _EscalaAltura);
        }

        internal void ComprasProcNotificarTamano()
        {
            ComprasEvtTamanoNecesario?.Invoke(this, EventArgs.Empty);
        }

        internal virtual Size ComprasFuncTamanoNecesario()
        {
            return _TamanoDiseno;
        }

        protected override void OnLoad(EventArgs Evento)
        {
            if (_TamanoDiseno.IsEmpty) ComprasProcRegistrarDiseno();
            base.OnLoad(Evento);
        }

        protected void ComprasProcAgregarColumna(UsrDataGridViewCompras Tabla, string Campo,
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

        protected void ComprasProcMostrarMonto(UsrTextBoxCompras Entrada, decimal Monto)
        {
            Entrada.Text = Monto.ToString("N2");
            Entrada.Entrada.SelectAll();
            Entrada.Entrada.SelectionAlignment = HorizontalAlignment.Right;
        }

        protected void ComprasMetSalir(object Remitente, EventArgs Evento)
        {
            Hide();
        }

        protected override void ScaleControl(SizeF Factor, BoundsSpecified Especificado)
        {
            base.ScaleControl(Factor, Especificado);
            if (_TamanoDiseno.IsEmpty) return;
            _TamanoDiseno = new Size((int)Math.Ceiling(_TamanoDiseno.Width * Factor.Width), (int)Math.Ceiling(_TamanoDiseno.Height * Factor.Height));
            _EscalaAltura *= Factor.Height;
            ComprasProcNotificarTamano();
        }

        public UsrBaseCompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

    }
}
