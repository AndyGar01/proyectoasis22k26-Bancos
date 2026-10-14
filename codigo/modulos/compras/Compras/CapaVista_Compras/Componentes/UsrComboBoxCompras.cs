using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    [DefaultBindingProperty("SelectedValue")]
    [DefaultEvent("SelectedIndexChanged")]
    public partial class UsrComboBoxCompras : UserControl
    {

        private bool _ErrorVisible;
        private bool _MostrarEtiquetaError = true;
        private int _AlturaEtiquetaError = 22;
        private int _AlturaErrorAmpliada;
        private int _AlturaFilaErrorAplicada = 30;
        private int _VersionTexto;

        [Category("Compras")]
        [Description("Muestra la etiqueta de error y reserva su espacio. Al desactivarla, solo se conserva el borde de error.")]
        [DefaultValue(true)]
        [RefreshProperties(RefreshProperties.All)]
        public bool MostrarEtiquetaError
        {
            get => _MostrarEtiquetaError;
            set
            {
                if (_MostrarEtiquetaError == value) return;
                _MostrarEtiquetaError = value;
                ComprasProcActualizarEspacioError();
            }
        }

        [Category("Compras")]
        [Description("Altura en píxeles de la etiqueta de error, sin incluir sus márgenes.")]
        [DefaultValue(22)]
        [RefreshProperties(RefreshProperties.All)]
        public int AlturaEtiquetaError
        {
            get => _AlturaEtiquetaError;
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException(nameof(value));
                if (_AlturaEtiquetaError == value) return;
                _AlturaEtiquetaError = value;
                ComprasProcActualizarEspacioError();
            }
        }

        private void ComprasProcActualizarEspacioError()
        {
            if (ComprasUsrError == null || _ComprasTlpMain == null) return;
            using (new ClsActualizacionDisenoCompras(_ComprasTlpMain))
            {
                int Altura = Math.Max(_AlturaEtiquetaError, _AlturaErrorAmpliada);
                int AlturaFila = _MostrarEtiquetaError ? Altura + ComprasUsrError.Margin.Vertical : 0;
                int Diferencia = AlturaFila - _AlturaFilaErrorAplicada;
                _AlturaFilaErrorAplicada = AlturaFila;
                ComprasUsrError.MinimumSize = Size.Empty;
                ComprasUsrError.MaximumSize = new Size(0, Altura);
                ComprasUsrError.Visible = _MostrarEtiquetaError;
                ClsActualizacionDisenoCompras.ComprasProcAltura(_ComprasTlpMain.RowStyles[1], AlturaFila);
                if (Diferencia != 0) Height = Math.Max(1, Height + Diferencia);
            }
        }

        public UsrComboBoxCompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ComprasUsrError.ComprasProcConservarRojo();
            _ComprasCboEntrada.TextChanged += (Sender, Evento) => ComprasProcTextoCambiado(Evento);
            Enter += (Sender, Evento) => _ComprasCboEntrada.Focus();
            _ComprasCboEntrada.KeyDown += (Sender, Evento) => OnKeyDown(Evento);
            _ComprasCboEntrada.KeyPress += (Sender, Evento) => OnKeyPress(Evento);
            _ComprasCboEntrada.KeyUp += (Sender, Evento) => OnKeyUp(Evento);
            _ComprasCboEntrada.MouseClick += (Sender, Evento) => OnMouseClick(Evento);
            _ComprasCboEntrada.Enter += (Sender, Evento) => ComprasProcActualizarBorde();
            _ComprasCboEntrada.Leave += (Sender, Evento) => ComprasProcActualizarBorde();
            _ComprasCboEntrada.SelectedIndexChanged += (Sender, Evento) =>
            {
                ComprasMetLimpiarError();
                SelectedIndexChanged?.Invoke(this, Evento);
            };
            _ComprasCboEntrada.SelectedValueChanged += (Sender, Evento) => SelectedValueChanged?.Invoke(this, Evento);
            _ComprasCboEntrada.SelectionChangeCommitted += (Sender, Evento) => SelectionChangeCommitted?.Invoke(this, Evento);
            _ComprasCboEntrada.DropDown += (Sender, Evento) => DropDown?.Invoke(this, Evento);
            _ComprasCboEntrada.DropDownClosed += (Sender, Evento) => DropDownClosed?.Invoke(this, Evento);
            _ComprasCboEntrada.DataSourceChanged += (Sender, Evento) => DataSourceChanged?.Invoke(this, Evento);
            ComprasProcAjustarAlturaEntrada();
            ComprasMetLimpiarError();
        }

        private void ComprasProcTextoCambiado(EventArgs Evento)
        {
            _VersionTexto++;
            ComprasMetLimpiarError();
            OnTextChanged(Evento);
        }

        [Browsable(true)]
        [Bindable(true)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return _ComprasCboEntrada == null ? base.Text : _ComprasCboEntrada.Text;
            }
            set
            {
                if (_ComprasCboEntrada != null)
                {
                    string Nuevo = value ?? string.Empty;
                    string Anterior = _ComprasCboEntrada.Text;
                    int Version = _VersionTexto;
                    _ComprasCboEntrada.Text = Nuevo;
                    if (Anterior != _ComprasCboEntrada.Text && Version == _VersionTexto)
                        ComprasProcTextoCambiado(EventArgs.Empty);
                }
                else
                {
                    base.Text = value;
                }
            }
        }

        internal ClsSelectorCompras ComprasCboInterno => _ComprasCboEntrada;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ClsSelectorCompras Entrada => _ComprasCboEntrada;

        [Category("Datos")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComboBox.ObjectCollection Items => _ComprasCboEntrada.Items;

        [Category("Datos")]
        [DefaultValue(null)]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource { get => _ComprasCboEntrada.DataSource; set => _ComprasCboEntrada.DataSource = value; }

        [Category("Datos")]
        [DefaultValue("")]
        public string DisplayMember { get => _ComprasCboEntrada.DisplayMember; set => _ComprasCboEntrada.DisplayMember = value; }

        [Category("Datos")]
        [DefaultValue("")]
        public string ValueMember { get => _ComprasCboEntrada.ValueMember; set => _ComprasCboEntrada.ValueMember = value; }

        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedValue { get => _ComprasCboEntrada.SelectedValue; set => _ComprasCboEntrada.SelectedValue = value; }

        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem { get => _ComprasCboEntrada.SelectedItem; set => _ComprasCboEntrada.SelectedItem = value; }

        [Category("Datos")]
        [DefaultValue(-1)]
        [Bindable(true)]
        public int SelectedIndex { get => _ComprasCboEntrada.SelectedIndex; set => _ComprasCboEntrada.SelectedIndex = value; }

        [Category("Comportamiento")]
        [DefaultValue(ComboBoxStyle.DropDownList)]
        [RefreshProperties(RefreshProperties.All)]
        public ComboBoxStyle DropDownStyle
        {
            get => _ComprasCboEntrada.DropDownStyle;
            set { _ComprasCboEntrada.DropDownStyle = value; ComprasProcAjustarAlturaEntrada(); }
        }

        [Category("Comportamiento")]
        [DefaultValue(false)]
        public bool Sorted { get => _ComprasCboEntrada.Sorted; set => _ComprasCboEntrada.Sorted = value; }

        [Category("Comportamiento")]
        [DefaultValue(8)]
        public int MaxDropDownItems { get => _ComprasCboEntrada.MaxDropDownItems; set => _ComprasCboEntrada.MaxDropDownItems = value; }

        [Category("Comportamiento")]
        [DefaultValue(true)]
        public bool IntegralHeight { get => _ComprasCboEntrada.IntegralHeight; set => _ComprasCboEntrada.IntegralHeight = value; }

        [Category("Comportamiento")]
        [DefaultValue(AutoCompleteMode.None)]
        public AutoCompleteMode AutoCompleteMode { get => _ComprasCboEntrada.AutoCompleteMode; set => _ComprasCboEntrada.AutoCompleteMode = value; }

        [Category("Comportamiento")]
        [DefaultValue(AutoCompleteSource.None)]
        public AutoCompleteSource AutoCompleteSource { get => _ComprasCboEntrada.AutoCompleteSource; set => _ComprasCboEntrada.AutoCompleteSource = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AutoCompleteStringCollection AutoCompleteCustomSource => _ComprasCboEntrada.AutoCompleteCustomSource;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DroppedDown { get => _ComprasCboEntrada.DroppedDown; set => _ComprasCboEntrada.DroppedDown = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionStart { get => _ComprasCboEntrada.SelectionStart; set => _ComprasCboEntrada.SelectionStart = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionLength { get => _ComprasCboEntrada.SelectionLength; set => _ComprasCboEntrada.SelectionLength = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedText { get => _ComprasCboEntrada.SelectedText; set => _ComprasCboEntrada.SelectedText = value; }

        public event EventHandler SelectedIndexChanged;
        public event EventHandler SelectedValueChanged;
        public event EventHandler SelectionChangeCommitted;
        public event EventHandler DropDown;
        public event EventHandler DropDownClosed;
        public event EventHandler DataSourceChanged;

        public void BeginUpdate() => _ComprasCboEntrada.BeginUpdate();
        public void EndUpdate() => _ComprasCboEntrada.EndUpdate();
        public int FindString(string Texto) => _ComprasCboEntrada.FindString(Texto);
        public int FindStringExact(string Texto) => _ComprasCboEntrada.FindStringExact(Texto);
        public string GetItemText(object Elemento) => _ComprasCboEntrada.GetItemText(Elemento);
        public void Select(int Inicio, int Longitud) => _ComprasCboEntrada.Select(Inicio, Longitud);
        public void SelectAll() => _ComprasCboEntrada.SelectAll();

        private void ComprasProcAjustarAlturaEntrada()
        {
            if (_ComprasCboEntrada == null || _ComprasPnlBorde == null) return;
            _ComprasPnlBorde.MaximumSize = DropDownStyle == ComboBoxStyle.Simple ? Size.Empty :
                new Size(0, _ComprasCboEntrada.PreferredHeight + _ComprasPnlBorde.Padding.Vertical);
        }

        protected override void OnFontChanged(EventArgs Evento)
        {
            base.OnFontChanged(Evento);
            if (_ComprasCboEntrada != null) _ComprasCboEntrada.Font = Font;
            ComprasProcAjustarAlturaEntrada();
        }

        protected override void OnForeColorChanged(EventArgs Evento)
        {
            base.OnForeColorChanged(Evento);
            if (_ComprasCboEntrada != null) _ComprasCboEntrada.ForeColor = ForeColor;
        }

        protected override void OnBackColorChanged(EventArgs Evento)
        {
            base.OnBackColorChanged(Evento);
            if (_ComprasCboEntrada != null) _ComprasCboEntrada.BackColor = BackColor;
            if (_ComprasTlpMain != null) _ComprasTlpMain.BackColor = BackColor;
        }

        private void ComprasProcActualizarBorde()
        {
            _ComprasPnlBorde.BackColor = _ErrorVisible ? Color.Red :
                _ComprasCboEntrada.Focused ? ClsTemaCompras.AcentoNavegador : ClsTemaCompras.PrincipalNavegador;
        }

        protected override void OnCausesValidationChanged(EventArgs Evento)
        {
            base.OnCausesValidationChanged(Evento);
            if (_ComprasCboEntrada != null) _ComprasCboEntrada.CausesValidation = CausesValidation;
        }

        public int MaxLength
        {
            get
            {
                return _ComprasCboEntrada.MaxLength;
            }
            set
            {
                _ComprasCboEntrada.MaxLength = value;
            }
        }

        public event KeyEventHandler TextoKeyDown
        {
            add
            {
                _ComprasCboEntrada.KeyDown += value;
            }
            remove
            {
                _ComprasCboEntrada.KeyDown -= value;
            }
        }

        public void ComprasMetMostrarError(string Mensaje)
        {
            if (string.IsNullOrWhiteSpace(Mensaje))
            {
                ComprasMetLimpiarError();
                return;
            }

            using (new ClsActualizacionDisenoCompras(_ComprasTlpMain))
            {
                if (ComprasUsrError.Texto != Mensaje) ComprasUsrError.Texto = Mensaje;
                if (ComprasUsrError.ColorTexto != Color.Red) ComprasUsrError.ColorTexto = Color.Red;
                _ErrorVisible = true;
                ComprasProcActualizarEspacioError();
                if (_ComprasPnlBorde.BackColor != Color.Red) _ComprasPnlBorde.BackColor = Color.Red;
            }
        }

        internal int ComprasFuncAlturaError(string Mensaje)
        {
            int Ancho = System.Math.Max(1, Width - 12);
            int Altura = System.Math.Max(22, TextRenderer.MeasureText(Mensaje, ComprasUsrError.Font, new Size(Ancho, int.MaxValue), TextFormatFlags.WordBreak).Height);
            int AlturaEntrada = Math.Max(25, _ComprasPnlBorde.Height) + _ComprasTlpMain.Padding.Vertical;
            return AlturaEntrada + (_MostrarEtiquetaError ? Math.Max(_AlturaEtiquetaError, Altura) + ComprasUsrError.Margin.Vertical : 0);
        }

        internal void ComprasProcAmpliarError(int AlturaFila)
        {
            _AlturaErrorAmpliada = Math.Max(0, AlturaFila - Math.Max(25, _ComprasPnlBorde.Height)
                - _ComprasTlpMain.Padding.Vertical - ComprasUsrError.Margin.Vertical);
            ComprasProcActualizarEspacioError();
        }

        public void ComprasMetLimpiarError()
        {
            using (new ClsActualizacionDisenoCompras(_ComprasTlpMain))
            {
                if (ComprasUsrError.Texto != string.Empty) ComprasUsrError.Texto = string.Empty;
                _ErrorVisible = false;
                _AlturaErrorAmpliada = 0;
                ComprasProcActualizarEspacioError();
                ComprasProcActualizarBorde();
            }
        }

    }
}
