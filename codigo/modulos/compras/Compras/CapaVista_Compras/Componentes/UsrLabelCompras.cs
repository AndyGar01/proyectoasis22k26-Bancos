using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    public enum TipografiaCompras
    {
        Etiqueta,
        Campo,
        TituloFormulario,
        TituloBienvenida
    }

    [DefaultBindingProperty("Text")]
    [DefaultEvent("Click")]
    public partial class UsrLabelCompras : UserControl
    {

        private bool _MostrarAsterisco = true;
        private TipografiaCompras _Tipografia = TipografiaCompras.Etiqueta;

        internal void ComprasProcConservarRojo()
        {
            ((ClsEtiquetaCompras)_ComprasLblTexto).ComprasConservarRojo = true;
            ColorTexto = Color.Red;
            _ComprasLblTexto.Invalidate();
        }

        public UsrLabelCompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ComprasProcAplicarTipografia(13F);
            _ComprasLblTexto.Font = Font;
            TabStop = false;
            _ComprasLblTexto.TextChanged += (Sender, Evento) => OnTextChanged(Evento);
            _ComprasLblTexto.Click += (Sender, Evento) => OnClick(Evento);
            _ComprasLblTexto.DoubleClick += (Sender, Evento) => OnDoubleClick(Evento);
            _ComprasLblAsterisco.Click += (Sender, Evento) => OnClick(Evento);
        }

        [Category("Compras")]
        [Description("Uso tipografico: Tahoma para etiquetas, Segoe UI para campos y Lucida Sans en negrita y cursiva para titulos. Al elegir un uso se aplica su tamano de referencia.")]
        [DefaultValue(TipografiaCompras.Etiqueta)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public TipografiaCompras Tipografia
        {
            get { return _Tipografia; }
            set
            {
                if (!Enum.IsDefined(typeof(TipografiaCompras), value))
                    throw new InvalidEnumArgumentException(nameof(value), (int)value, typeof(TipografiaCompras));
                if (_Tipografia == value) return;
                _Tipografia = value;
                ComprasProcAplicarTipografia(value == TipografiaCompras.TituloBienvenida ? 42F :
                    value == TipografiaCompras.TituloFormulario ? 18F :
                    value == TipografiaCompras.Campo ? 14F : 13F);
            }
        }

        [Category("Compras")]
        [Description("Tamano de la tipografia en puntos, ajustable segun el diseno y la legibilidad.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float TamanoTipografia
        {
            get { return Font.SizeInPoints; }
            set
            {
                if (float.IsNaN(value) || float.IsInfinity(value) || value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "El tamano debe ser un numero positivo y finito.");
                ComprasProcAplicarTipografia(value);
            }
        }

        public bool ShouldSerializeTamanoTipografia()
        {
            float Referencia = _Tipografia == TipografiaCompras.TituloBienvenida ? 42F :
                _Tipografia == TipografiaCompras.TituloFormulario ? 18F :
                _Tipografia == TipografiaCompras.Campo ? 14F : 13F;
            return Math.Abs(TamanoTipografia - Referencia) > 0.01F;
        }

        private void ComprasProcAplicarTipografia(float Tamano)
        {
            bool EsTitulo = _Tipografia == TipografiaCompras.TituloFormulario ||
                _Tipografia == TipografiaCompras.TituloBienvenida;
            Font = new Font(EsTitulo ? "Lucida Sans" :
                _Tipografia == TipografiaCompras.Campo ? "Segoe UI" : "Tahoma",
                Tamano, EsTitulo ? FontStyle.Bold | FontStyle.Italic : FontStyle.Regular,
                GraphicsUnit.Point);
        }

        [Browsable(true)]
        [Bindable(true)]
        [DefaultValue("Label de Compras")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => _ComprasLblTexto == null ? base.Text : _ComprasLblTexto.Text;
            set
            {
                if (_ComprasLblTexto == null) base.Text = value;
                else _ComprasLblTexto.Text = value ?? string.Empty;
            }
        }

        [DefaultValue(ContentAlignment.MiddleRight)]
        public ContentAlignment TextAlign
        {
            get => AlineacionTexto;
            set => AlineacionTexto = value;
        }

        protected override void OnFontChanged(EventArgs Evento)
        {
            base.OnFontChanged(Evento);
            if (_ComprasLblTexto != null) _ComprasLblTexto.Font = Font;
            if (_ComprasLblAsterisco != null) _ComprasLblAsterisco.Font = Font;
            if (_ComprasTlpMain != null) _ComprasTlpMain.Font = Font;
            if (_ComprasLblTexto != null) Height = Math.Max(Height, Font.Height + Padding.Vertical);
        }

        protected override void OnForeColorChanged(EventArgs Evento)
        {
            base.OnForeColorChanged(Evento);
            if (_ComprasLblTexto != null) _ComprasLblTexto.ForeColor = ForeColor;
        }

        protected override void OnBackColorChanged(EventArgs Evento)
        {
            base.OnBackColorChanged(Evento);
            if (_ComprasTlpMain != null) _ComprasTlpMain.BackColor = BackColor;
        }

        [Category("Compras")]
        [Description("Texto que se mostrará en el label.")]
        [DefaultValue("Label de Compras")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Texto
        {
            get { return Text; }
            set { Text = value; }
        }

        [Category("Compras")]
        [Description("Color del texto del label.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorTexto
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        public bool ShouldSerializeColorTexto() => ColorTexto != ClsTemaCompras.PrincipalNavegador;
        public void ResetColorTexto() => ColorTexto = ClsTemaCompras.PrincipalNavegador;

        [Category("Compras")]
        [Description("Muestra u oculta el asterisco y su columna.")]
        [DefaultValue(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool MostrarAsterisco
        {
            get { return _MostrarAsterisco; }
            set { ComprasMetMostrarAsterisco(value); }
        }

        [Category("Compras")]
        [Description("Define la alineación del texto de la etiqueta.")]
        [DefaultValue(ContentAlignment.MiddleRight)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ContentAlignment AlineacionTexto
        {
            get { return _ComprasLblTexto.TextAlign; }
            set { _ComprasLblTexto.TextAlign = value; }
        }


        public void ComprasMetMostrarAsterisco(bool Mostrar)
        {
            if (_MostrarAsterisco == Mostrar && _ComprasTlpMain.ColumnCount == (Mostrar ? 2 : 1)) return;
            using (new ClsActualizacionDisenoCompras(_ComprasTlpMain))
            {
                if (Mostrar)
                {
                    if (_ComprasTlpMain.ColumnCount == 1)
                    {
                        _ComprasTlpMain.ColumnCount = 2;
                        _ComprasTlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
                    }

                    if (!_ComprasTlpMain.Controls.Contains(_ComprasLblAsterisco))
                    {
                        _ComprasTlpMain.Controls.Add(_ComprasLblAsterisco, 1, 0);
                    }

                    if (!_ComprasLblAsterisco.Visible) _ComprasLblAsterisco.Visible = true;
                }
                else
                {
                    if (_ComprasLblAsterisco.Visible) _ComprasLblAsterisco.Visible = false;
                    _ComprasTlpMain.Controls.Remove(_ComprasLblAsterisco);

                    while (_ComprasTlpMain.ColumnStyles.Count > 1)
                    {
                        _ComprasTlpMain.ColumnStyles.RemoveAt(1);
                    }

                    _ComprasTlpMain.ColumnCount = 1;
                }

                _MostrarAsterisco = Mostrar;
            }
        }

    }
}
