using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CapaVista_Componentes.Componentes
{
    [DefaultProperty("DataSource")]
    [DefaultEvent("CellClick")]
    public partial class UsrDataGridViewCompras : UserControl
    {

        private int _FilaHover = -1;
        private bool _ResaltarFilasAlPasar;
        private Cursor _CursorHabitual;

        [Category("Comportamiento")]
        [DefaultValue(false)]
        public bool ResaltarFilasAlPasar
        {
            get { return _ResaltarFilasAlPasar; }
            set { _ResaltarFilasAlPasar = value; ComprasProcHover(-1); }
        }

        private void ComprasProcHover(int Fila)
        {
            int Anterior = _FilaHover;
            _FilaHover = Fila;
            _ComprasDgvMain.Cursor = Fila >= 0 ? Cursors.Hand : _CursorHabitual;
            if (Anterior >= 0 && Anterior < _ComprasDgvMain.Rows.Count) _ComprasDgvMain.InvalidateRow(Anterior);
            if (Fila >= 0 && Fila < _ComprasDgvMain.Rows.Count) _ComprasDgvMain.InvalidateRow(Fila);
        }

        private const int _AlturaMinimaFila = 28;
        private const int _AlturaMaximaFila = 40;

        public UsrDataGridViewCompras()
        {
            InitializeComponent();
            Enter += (Sender, Evento) => _ComprasDgvMain.Focus();
            _ComprasDgvMain.KeyDown += (Sender, Evento) => OnKeyDown(Evento);
            _ComprasDgvMain.KeyPress += (Sender, Evento) => OnKeyPress(Evento);
            _ComprasDgvMain.KeyUp += (Sender, Evento) => OnKeyUp(Evento);
            _CursorHabitual = _ComprasDgvMain.Cursor;
            _ComprasDgvMain.MouseMove += (Sender, Evento) =>
            {
                DataGridView.HitTestInfo Zona = _ComprasDgvMain.HitTest(Evento.X, Evento.Y);
                int Fila = ResaltarFilasAlPasar && Zona.Type == DataGridViewHitTestType.Cell && Zona.RowIndex >= 0 && !_ComprasDgvMain.Rows[Zona.RowIndex].IsNewRow ? Zona.RowIndex : -1;
                if (_FilaHover != Fila) ComprasProcHover(Fila);
            };
            _ComprasDgvMain.MouseLeave += (Sender, Evento) => ComprasProcHover(-1);
            _ComprasDgvMain.DataBindingComplete += (Sender, Evento) => ComprasProcHover(-1);
            _ComprasDgvMain.CellPainting += (Sender, Evento) =>
            {
                if (ResaltarFilasAlPasar && Evento.RowIndex == _FilaHover && Evento.RowIndex >= 0 && Evento.ColumnIndex >= 0)
                {
                    System.Drawing.Color Fondo = Evento.CellStyle.BackColor;
                    System.Drawing.Color Texto = Evento.CellStyle.ForeColor;
                    try
                    {
                        Evento.CellStyle.BackColor = Evento.CellStyle.SelectionBackColor;
                        Evento.CellStyle.ForeColor = Evento.CellStyle.SelectionForeColor;
                        Evento.Paint(Evento.ClipBounds, Evento.PaintParts);
                        Evento.Handled = true;
                    }
                    finally
                    {
                        Evento.CellStyle.BackColor = Fondo;
                        Evento.CellStyle.ForeColor = Texto;
                    }
                }
            };

            _ComprasDgvMain.Resize += ComprasMetActualizarAlturaFilas;
            _ComprasDgvMain.RowsAdded += ComprasMetFilasAgregadas;
            _ComprasDgvMain.RowsRemoved += ComprasMetFilasEliminadas;
            _ComprasDgvMain.DataBindingComplete += ComprasMetEnlaceCompletado;
            _ComprasDgvMain.HandleCreated += ComprasMetTablaCreada;

            ComprasMetActivarDobleBuffer();
        }

        private void ComprasMetTablaCreada(object Remitente, EventArgs Evento)
        {
            ComprasMetActivarDobleBuffer();
            ComprasMetAjustarAlturaFilas();
        }
        private void ComprasMetActivarDobleBuffer()
        {
            System.Reflection.PropertyInfo PropiedadDobleBuffer =
                typeof(DataGridView).GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic);

            if (PropiedadDobleBuffer != null)
            {
                PropiedadDobleBuffer.SetValue(_ComprasDgvMain, true, null);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridView Tabla
        {
            get { return _ComprasDgvMain; }
        }

        [Category("Datos")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return _ComprasDgvMain.DataSource; }
            set { _ComprasDgvMain.DataSource = value; }
        }

        [Category("Datos")]
        [DefaultValue("")]
        public string DataMember
        {
            get { return _ComprasDgvMain.DataMember; }
            set { _ComprasDgvMain.DataMember = value; }
        }

        [Category("Datos")]
        [DefaultValue(true)]
        public bool AutoGenerateColumns
        {
            get { return _ComprasDgvMain.AutoGenerateColumns; }
            set { _ComprasDgvMain.AutoGenerateColumns = value; }
        }

        [Category("Comportamiento")]
        [DefaultValue(true)]
        public bool ReadOnly
        {
            get { return _ComprasDgvMain.ReadOnly; }
            set { _ComprasDgvMain.ReadOnly = value; }
        }

        [Category("Comportamiento")]
        [DefaultValue(false)]
        public bool AllowUserToAddRows
        {
            get { return _ComprasDgvMain.AllowUserToAddRows; }
            set { _ComprasDgvMain.AllowUserToAddRows = value; }
        }

        [Category("Comportamiento")]
        [DefaultValue(false)]
        public bool AllowUserToDeleteRows
        {
            get { return _ComprasDgvMain.AllowUserToDeleteRows; }
            set { _ComprasDgvMain.AllowUserToDeleteRows = value; }
        }

        [Category("Comportamiento")]
        [DefaultValue(false)]
        public bool AllowUserToResizeRows
        {
            get { return _ComprasDgvMain.AllowUserToResizeRows; }
            set { _ComprasDgvMain.AllowUserToResizeRows = value; }
        }

        [Category("Comportamiento")]
        [DefaultValue(false)]
        public bool MultiSelect
        {
            get { return _ComprasDgvMain.MultiSelect; }
            set { _ComprasDgvMain.MultiSelect = value; }
        }

        [Category("Comportamiento")]
        [DefaultValue(DataGridViewSelectionMode.FullRowSelect)]
        public DataGridViewSelectionMode SelectionMode
        {
            get { return _ComprasDgvMain.SelectionMode; }
            set { _ComprasDgvMain.SelectionMode = value; }
        }

        [Category("Comportamiento")]
        [DefaultValue(DataGridViewEditMode.EditProgrammatically)]
        public DataGridViewEditMode EditMode
        {
            get { return _ComprasDgvMain.EditMode; }
            set { _ComprasDgvMain.EditMode = value; }
        }

        [Category("Apariencia")]
        [DefaultValue(DataGridViewAutoSizeColumnsMode.Fill)]
        public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode
        {
            get { return _ComprasDgvMain.AutoSizeColumnsMode; }
            set { _ComprasDgvMain.AutoSizeColumnsMode = value; }
        }

        [Category("Apariencia")]
        [DefaultValue(false)]
        public bool RowHeadersVisible
        {
            get { return _ComprasDgvMain.RowHeadersVisible; }
            set { _ComprasDgvMain.RowHeadersVisible = value; }
        }

        [Category("Apariencia")]
        [DefaultValue(true)]
        public bool ColumnHeadersVisible
        {
            get { return _ComprasDgvMain.ColumnHeadersVisible; }
            set
            {
                _ComprasDgvMain.ColumnHeadersVisible = value;
                ComprasMetAjustarAlturaFilas();
            }
        }

        [Category("Datos")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataGridViewColumnCollection Columns
        {
            get { return _ComprasDgvMain.Columns; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewRowCollection Rows
        {
            get { return _ComprasDgvMain.Rows; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewSelectedRowCollection SelectedRows
        {
            get { return _ComprasDgvMain.SelectedRows; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewSelectedCellCollection SelectedCells
        {
            get { return _ComprasDgvMain.SelectedCells; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewRow CurrentRow
        {
            get { return _ComprasDgvMain.CurrentRow; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewCell CurrentCell
        {
            get { return _ComprasDgvMain.CurrentCell; }
            set { _ComprasDgvMain.CurrentCell = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RowCount
        {
            get { return _ComprasDgvMain.RowCount; }
            set { _ComprasDgvMain.RowCount = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ColumnCount
        {
            get { return _ComprasDgvMain.ColumnCount; }
            set { _ComprasDgvMain.ColumnCount = value; }
        }

        public DataGridViewCell this[int IndiceColumna, int IndiceFila]
        {
            get { return _ComprasDgvMain[IndiceColumna, IndiceFila]; }
            set { _ComprasDgvMain[IndiceColumna, IndiceFila] = value; }
        }

        public DataGridViewCell this[string NombreColumna, int IndiceFila]
        {
            get { return _ComprasDgvMain[NombreColumna, IndiceFila]; }
            set { _ComprasDgvMain[NombreColumna, IndiceFila] = value; }
        }

        [Category("Acción")]
        public event DataGridViewCellEventHandler CellClick
        {
            add { _ComprasDgvMain.CellClick += value; }
            remove { _ComprasDgvMain.CellClick -= value; }
        }

        [Category("Acción")]
        public event DataGridViewCellEventHandler CellDoubleClick
        {
            add { _ComprasDgvMain.CellDoubleClick += value; }
            remove { _ComprasDgvMain.CellDoubleClick -= value; }
        }

        [Category("Acción")]
        public event DataGridViewCellEventHandler CellContentClick
        {
            add { _ComprasDgvMain.CellContentClick += value; }
            remove { _ComprasDgvMain.CellContentClick -= value; }
        }

        [Category("Acción")]
        public event EventHandler SelectionChanged
        {
            add { _ComprasDgvMain.SelectionChanged += value; }
            remove { _ComprasDgvMain.SelectionChanged -= value; }
        }

        [Category("Datos")]
        public event DataGridViewBindingCompleteEventHandler DataBindingComplete
        {
            add { _ComprasDgvMain.DataBindingComplete += value; }
            remove { _ComprasDgvMain.DataBindingComplete -= value; }
        }

        [Category("Datos")]
        public event DataGridViewRowsAddedEventHandler RowsAdded
        {
            add { _ComprasDgvMain.RowsAdded += value; }
            remove { _ComprasDgvMain.RowsAdded -= value; }
        }

        [Category("Datos")]
        public event DataGridViewRowsRemovedEventHandler RowsRemoved
        {
            add { _ComprasDgvMain.RowsRemoved += value; }
            remove { _ComprasDgvMain.RowsRemoved -= value; }
        }

        [Category("Datos")]
        public event DataGridViewCellEventHandler CellValueChanged
        {
            add { _ComprasDgvMain.CellValueChanged += value; }
            remove { _ComprasDgvMain.CellValueChanged -= value; }
        }

        [Category("Datos")]
        public event DataGridViewCellValidatingEventHandler CellValidating
        {
            add { _ComprasDgvMain.CellValidating += value; }
            remove { _ComprasDgvMain.CellValidating -= value; }
        }

        [Category("Datos")]
        public event DataGridViewDataErrorEventHandler DataError
        {
            add { _ComprasDgvMain.DataError += value; }
            remove { _ComprasDgvMain.DataError -= value; }
        }

        protected override void OnCausesValidationChanged(EventArgs Evento)
        {
            base.OnCausesValidationChanged(Evento);
            if (_ComprasDgvMain != null) _ComprasDgvMain.CausesValidation = CausesValidation;
        }

        public void ClearSelection()
        {
            _ComprasDgvMain.ClearSelection();
        }

        public bool BeginEdit(bool SeleccionarTodo)
        {
            return _ComprasDgvMain.BeginEdit(SeleccionarTodo);
        }

        public bool EndEdit()
        {
            return _ComprasDgvMain.EndEdit();
        }

        public bool CancelEdit()
        {
            return _ComprasDgvMain.CancelEdit();
        }

        public void ComprasMetEnfocarTabla()
        {
            _ComprasDgvMain.Focus();
        }

        private void ComprasMetActualizarAlturaFilas(object Remitente, EventArgs Evento)
        {
            ComprasMetAjustarAlturaFilas();
        }

        private void ComprasMetFilasAgregadas(object Remitente, DataGridViewRowsAddedEventArgs Evento)
        {
            ComprasMetAjustarAlturaFilas();
        }

        private void ComprasMetFilasEliminadas(object Remitente, DataGridViewRowsRemovedEventArgs Evento)
        {
            ComprasMetAjustarAlturaFilas();
        }

        private void ComprasMetEnlaceCompletado(object Remitente, DataGridViewBindingCompleteEventArgs Evento)
        {
            ComprasMetAjustarAlturaFilas();
        }

        internal bool ComprasFilasUniformes { get; set; }

        private void ComprasMetAjustarAlturaFilas()
        {
            if (_ComprasDgvMain.AutoSizeRowsMode != DataGridViewAutoSizeRowsMode.None)
            {
                return;
            }

            int CantidadFilas = 0;

            foreach (DataGridViewRow Fila in _ComprasDgvMain.Rows)
            {
                if (Fila.Visible)
                {
                    CantidadFilas++;
                }
            }

            if (CantidadFilas == 0)
            {
                return;
            }

            int AlturaEncabezado = _ComprasDgvMain.ColumnHeadersVisible
                ? _ComprasDgvMain.ColumnHeadersHeight
                : 0;

            int EspacioDisponible = _ComprasDgvMain.ClientSize.Height - AlturaEncabezado;

            foreach (Control ControlInterno in _ComprasDgvMain.Controls)
            {
                if (ControlInterno is HScrollBar && ControlInterno.Visible)
                {
                    EspacioDisponible -= ControlInterno.Height;
                }
            }

            if (EspacioDisponible <= 0)
            {
                return;
            }

            int AlturaCalculada = EspacioDisponible / CantidadFilas;
            int AlturaBase = Math.Max(_AlturaMinimaFila, Math.Min(_AlturaMaximaFila, AlturaCalculada));
            int Sobrante = !ComprasFilasUniformes && AlturaCalculada >= _AlturaMinimaFila && AlturaCalculada < _AlturaMaximaFila
                ? EspacioDisponible % CantidadFilas
                : 0;

            foreach (DataGridViewRow Fila in _ComprasDgvMain.Rows)
            {
                if (!Fila.Visible)
                {
                    continue;
                }

                int AlturaFila = Math.Max(Fila.MinimumHeight, AlturaBase + (Sobrante > 0 ? 1 : 0));

                if (Fila.Height != AlturaFila)
                {
                    Fila.Height = AlturaFila;
                }

                if (Sobrante > 0)
                {
                    Sobrante--;
                }
            }

        }
    }
}
