namespace CapaVista_OrdenesCompra
{
    partial class FrmOrdenesCompra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras _ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel _ComprasPnlContenido;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this._ComprasPnlContenido = new System.Windows.Forms.Panel();
            this._ComprasTlpPrincipal = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasGbxEncabezado = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this._ComprasTlpEncabezado = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasTlpProveedor = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrContactoProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrCorreoProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrTelefonoProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrNombreProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaNombreProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaTelefonoProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaCorreoProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaContactoProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasBtnProveedor = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasTlpResponsable = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrCorreoResponsable = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrPuestoResponsable = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrNombreResponsable = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrResponsable = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrCodigoResponsable = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaNombreResponsable = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaCodigoResponsable = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaCorreoResponsable = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaPuestoResponsable = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasBtnResponsable = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasGbxFinalizacion = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this._ComprasTlpFinalizacion = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasTlpImportes = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasTlpAcciones = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnGuardar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnDescartar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasUsrEtiquetaComentario = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrComentario = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this._ComprasTlpTotales = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrImpuesto = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaSubtotal = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrSubtotal = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrDescuento = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrGastosAdicionales = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaDescuento = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaGastosAdicionales = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaImpuesto = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaTotal = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrTotal = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this._ComprasBtnPorcentaje = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasGbxDetalles = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this._ComprasTlpDetalles = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasPnlArticulos = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasUsrArticulos = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this._ComprasBtnArticulos = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnLogistica = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnFinanzas = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnAnexos = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._ComprasPnlDesplazamiento.SuspendLayout();
            this._ComprasPnlContenido.SuspendLayout();
            this._ComprasTlpPrincipal.SuspendLayout();
            this._ComprasGbxEncabezado.SuspendLayout();
            this._ComprasTlpEncabezado.SuspendLayout();
            this._ComprasTlpProveedor.SuspendLayout();
            this._ComprasTlpResponsable.SuspendLayout();
            this._ComprasGbxFinalizacion.SuspendLayout();
            this._ComprasTlpFinalizacion.SuspendLayout();
            this._ComprasTlpImportes.SuspendLayout();
            this._ComprasTlpAcciones.SuspendLayout();
            this._ComprasTlpTotales.SuspendLayout();
            this._ComprasGbxDetalles.SuspendLayout();
            this._ComprasTlpDetalles.SuspendLayout();
            this._ComprasPnlArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ComprasPnlDesplazamiento
            // 
            this._ComprasPnlDesplazamiento.AutoScroll = true;
            this._ComprasPnlDesplazamiento.Controls.Add(this._ComprasPnlContenido);
            this._ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlDesplazamiento.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlDesplazamiento.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlDesplazamiento.Name = "_ComprasPnlDesplazamiento";
            this._ComprasPnlDesplazamiento.Size = new System.Drawing.Size(1300, 853);
            this._ComprasPnlDesplazamiento.TabIndex = 0;
            // 
            // _ComprasPnlContenido
            // 
            this._ComprasPnlContenido.Controls.Add(this._ComprasTlpPrincipal);
            this._ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlContenido.Name = "_ComprasPnlContenido";
            this._ComprasPnlContenido.Size = new System.Drawing.Size(1279, 900);
            this._ComprasPnlContenido.TabIndex = 0;
            // 
            // _ComprasTlpPrincipal
            // 
            this._ComprasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpPrincipal.ColumnCount = 1;
            this._ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasGbxEncabezado, 0, 0);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasGbxFinalizacion, 0, 2);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasGbxDetalles, 0, 1);
            this._ComprasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpPrincipal.Name = "_ComprasTlpPrincipal";
            this._ComprasTlpPrincipal.RowCount = 3;
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this._ComprasTlpPrincipal.Size = new System.Drawing.Size(1279, 900);
            this._ComprasTlpPrincipal.TabIndex = 0;
            // 
            // _ComprasGbxEncabezado
            // 
            this._ComprasGbxEncabezado.BackColor = System.Drawing.Color.Transparent;
            this._ComprasGbxEncabezado.Controls.Add(this._ComprasTlpEncabezado);
            this._ComprasGbxEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasGbxEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasGbxEncabezado.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this._ComprasGbxEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasGbxEncabezado.Location = new System.Drawing.Point(3, 3);
            this._ComprasGbxEncabezado.Name = "_ComprasGbxEncabezado";
            this._ComprasGbxEncabezado.Size = new System.Drawing.Size(1273, 234);
            this._ComprasGbxEncabezado.TabIndex = 4;
            this._ComprasGbxEncabezado.TabStop = false;
            this._ComprasGbxEncabezado.Text = "Encabezado";
            // 
            // _ComprasTlpEncabezado
            // 
            this._ComprasTlpEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpEncabezado.ColumnCount = 3;
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._ComprasTlpEncabezado.Controls.Add(this._ComprasTlpProveedor, 0, 0);
            this._ComprasTlpEncabezado.Controls.Add(this._ComprasTlpResponsable, 2, 0);
            this._ComprasTlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpEncabezado.Location = new System.Drawing.Point(3, 24);
            this._ComprasTlpEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpEncabezado.Name = "_ComprasTlpEncabezado";
            this._ComprasTlpEncabezado.RowCount = 1;
            this._ComprasTlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpEncabezado.Size = new System.Drawing.Size(1267, 207);
            this._ComprasTlpEncabezado.TabIndex = 3;
            // 
            // _ComprasTlpProveedor
            // 
            this._ComprasTlpProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpProveedor.ColumnCount = 3;
            this._ComprasTlpProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this._ComprasTlpProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrContactoProveedor, 1, 4);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrCorreoProveedor, 1, 3);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrTelefonoProveedor, 1, 2);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrProveedor, 0, 0);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrNombreProveedor, 1, 1);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrEtiquetaNombreProveedor, 0, 1);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrEtiquetaTelefonoProveedor, 0, 2);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrEtiquetaCorreoProveedor, 0, 3);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasUsrEtiquetaContactoProveedor, 0, 4);
            this._ComprasTlpProveedor.Controls.Add(this.ComprasBtnProveedor, 2, 2);
            this._ComprasTlpProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpProveedor.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpProveedor.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpProveedor.Name = "_ComprasTlpProveedor";
            this._ComprasTlpProveedor.RowCount = 6;
            this._ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpProveedor.Size = new System.Drawing.Size(623, 207);
            this._ComprasTlpProveedor.TabIndex = 4;
            // 
            // ComprasUsrContactoProveedor
            // 
            this.ComprasUsrContactoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrContactoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrContactoProveedor.Enabled = false;
            this.ComprasUsrContactoProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrContactoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrContactoProveedor.Location = new System.Drawing.Point(132, 152);
            this.ComprasUsrContactoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrContactoProveedor.MaxLength = 2147483647;
            this.ComprasUsrContactoProveedor.MostrarEtiquetaError = false;
            this.ComprasUsrContactoProveedor.Name = "ComprasUsrContactoProveedor";
            this.ComprasUsrContactoProveedor.SelectedText = "";
            this.ComprasUsrContactoProveedor.SelectionLength = 0;
            this.ComprasUsrContactoProveedor.SelectionStart = 0;
            this.ComprasUsrContactoProveedor.Size = new System.Drawing.Size(399, 36);
            this.ComprasUsrContactoProveedor.TabIndex = 10;
            // 
            // ComprasUsrCorreoProveedor
            // 
            this.ComprasUsrCorreoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCorreoProveedor.Enabled = false;
            this.ComprasUsrCorreoProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCorreoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCorreoProveedor.Location = new System.Drawing.Point(132, 112);
            this.ComprasUsrCorreoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrCorreoProveedor.MaxLength = 2147483647;
            this.ComprasUsrCorreoProveedor.MostrarEtiquetaError = false;
            this.ComprasUsrCorreoProveedor.Name = "ComprasUsrCorreoProveedor";
            this.ComprasUsrCorreoProveedor.SelectedText = "";
            this.ComprasUsrCorreoProveedor.SelectionLength = 0;
            this.ComprasUsrCorreoProveedor.SelectionStart = 0;
            this.ComprasUsrCorreoProveedor.Size = new System.Drawing.Size(399, 36);
            this.ComprasUsrCorreoProveedor.TabIndex = 9;
            // 
            // ComprasUsrTelefonoProveedor
            // 
            this.ComprasUsrTelefonoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrTelefonoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTelefonoProveedor.Enabled = false;
            this.ComprasUsrTelefonoProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTelefonoProveedor.Location = new System.Drawing.Point(132, 72);
            this.ComprasUsrTelefonoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrTelefonoProveedor.MaxLength = 2147483647;
            this.ComprasUsrTelefonoProveedor.MostrarEtiquetaError = false;
            this.ComprasUsrTelefonoProveedor.Name = "ComprasUsrTelefonoProveedor";
            this.ComprasUsrTelefonoProveedor.SelectedText = "";
            this.ComprasUsrTelefonoProveedor.SelectionLength = 0;
            this.ComprasUsrTelefonoProveedor.SelectionStart = 0;
            this.ComprasUsrTelefonoProveedor.Size = new System.Drawing.Size(399, 36);
            this.ComprasUsrTelefonoProveedor.TabIndex = 8;
            // 
            // ComprasUsrProveedor
            // 
            this.ComprasUsrProveedor.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasUsrProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpProveedor.SetColumnSpan(this.ComprasUsrProveedor, 3);
            this.ComprasUsrProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrProveedor.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.ComprasUsrProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrProveedor.Location = new System.Drawing.Point(4, 4);
            this.ComprasUsrProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.ComprasUsrProveedor.MaximumSize = new System.Drawing.Size(1250, 27);
            this.ComprasUsrProveedor.MostrarAsterisco = false;
            this.ComprasUsrProveedor.Name = "ComprasUsrProveedor";
            this.ComprasUsrProveedor.Size = new System.Drawing.Size(615, 22);
            this.ComprasUsrProveedor.TabIndex = 7;
            this.ComprasUsrProveedor.TabStop = false;
            this.ComprasUsrProveedor.TamanoTipografia = 10.8F;
            this.ComprasUsrProveedor.Text = "PROVEEDOR";
            this.ComprasUsrProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasUsrProveedor.Texto = "PROVEEDOR";
            // 
            // ComprasUsrNombreProveedor
            // 
            this.ComprasUsrNombreProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrNombreProveedor.Enabled = false;
            this.ComprasUsrNombreProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrNombreProveedor.Location = new System.Drawing.Point(132, 32);
            this.ComprasUsrNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrNombreProveedor.MaxLength = 2147483647;
            this.ComprasUsrNombreProveedor.MostrarEtiquetaError = false;
            this.ComprasUsrNombreProveedor.Name = "ComprasUsrNombreProveedor";
            this.ComprasUsrNombreProveedor.SelectedText = "";
            this.ComprasUsrNombreProveedor.SelectionLength = 0;
            this.ComprasUsrNombreProveedor.SelectionStart = 0;
            this.ComprasUsrNombreProveedor.Size = new System.Drawing.Size(399, 36);
            this.ComprasUsrNombreProveedor.TabIndex = 5;
            // 
            // ComprasUsrEtiquetaNombreProveedor
            // 
            this.ComprasUsrEtiquetaNombreProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaNombreProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaNombreProveedor.Location = new System.Drawing.Point(3, 33);
            this.ComprasUsrEtiquetaNombreProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaNombreProveedor.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaNombreProveedor.Name = "ComprasUsrEtiquetaNombreProveedor";
            this.ComprasUsrEtiquetaNombreProveedor.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaNombreProveedor.TabIndex = 1;
            this.ComprasUsrEtiquetaNombreProveedor.TabStop = false;
            this.ComprasUsrEtiquetaNombreProveedor.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaNombreProveedor.Text = "Nombre";
            this.ComprasUsrEtiquetaNombreProveedor.Texto = "Nombre";
            // 
            // ComprasUsrEtiquetaTelefonoProveedor
            // 
            this.ComprasUsrEtiquetaTelefonoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaTelefonoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaTelefonoProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaTelefonoProveedor.Location = new System.Drawing.Point(3, 73);
            this.ComprasUsrEtiquetaTelefonoProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaTelefonoProveedor.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaTelefonoProveedor.Name = "ComprasUsrEtiquetaTelefonoProveedor";
            this.ComprasUsrEtiquetaTelefonoProveedor.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaTelefonoProveedor.TabIndex = 2;
            this.ComprasUsrEtiquetaTelefonoProveedor.TabStop = false;
            this.ComprasUsrEtiquetaTelefonoProveedor.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaTelefonoProveedor.Text = "Teléfono";
            this.ComprasUsrEtiquetaTelefonoProveedor.Texto = "Teléfono";
            // 
            // ComprasUsrEtiquetaCorreoProveedor
            // 
            this.ComprasUsrEtiquetaCorreoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaCorreoProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaCorreoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaCorreoProveedor.Location = new System.Drawing.Point(3, 113);
            this.ComprasUsrEtiquetaCorreoProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaCorreoProveedor.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaCorreoProveedor.Name = "ComprasUsrEtiquetaCorreoProveedor";
            this.ComprasUsrEtiquetaCorreoProveedor.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaCorreoProveedor.TabIndex = 3;
            this.ComprasUsrEtiquetaCorreoProveedor.TabStop = false;
            this.ComprasUsrEtiquetaCorreoProveedor.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaCorreoProveedor.Text = "Correo";
            this.ComprasUsrEtiquetaCorreoProveedor.Texto = "Correo";
            // 
            // ComprasUsrEtiquetaContactoProveedor
            // 
            this.ComprasUsrEtiquetaContactoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaContactoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaContactoProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaContactoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaContactoProveedor.Location = new System.Drawing.Point(3, 153);
            this.ComprasUsrEtiquetaContactoProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaContactoProveedor.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaContactoProveedor.Name = "ComprasUsrEtiquetaContactoProveedor";
            this.ComprasUsrEtiquetaContactoProveedor.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaContactoProveedor.TabIndex = 4;
            this.ComprasUsrEtiquetaContactoProveedor.TabStop = false;
            this.ComprasUsrEtiquetaContactoProveedor.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaContactoProveedor.Text = "Contacto";
            this.ComprasUsrEtiquetaContactoProveedor.Texto = "Contacto";
            // 
            // ComprasBtnProveedor
            // 
            this.ComprasBtnProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnProveedor.FlatAppearance.BorderSize = 0;
            this.ComprasBtnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnProveedor.Location = new System.Drawing.Point(538, 70);
            this.ComprasBtnProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnProveedor.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnProveedor.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnProveedor.Name = "ComprasBtnProveedor";
            this.ComprasBtnProveedor.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnProveedor.TabIndex = 11;
            this.ComprasBtnProveedor.Text = "Proveedor";
            this.ComprasBtnProveedor.UseVisualStyleBackColor = false;
            // 
            // _ComprasTlpResponsable
            // 
            this._ComprasTlpResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpResponsable.ColumnCount = 3;
            this._ComprasTlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this._ComprasTlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrCorreoResponsable, 1, 4);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrPuestoResponsable, 1, 3);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrNombreResponsable, 1, 2);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrResponsable, 0, 0);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrCodigoResponsable, 1, 1);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrEtiquetaNombreResponsable, 0, 1);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrEtiquetaCodigoResponsable, 0, 2);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrEtiquetaCorreoResponsable, 0, 3);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasUsrEtiquetaPuestoResponsable, 0, 4);
            this._ComprasTlpResponsable.Controls.Add(this.ComprasBtnResponsable, 2, 2);
            this._ComprasTlpResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpResponsable.Location = new System.Drawing.Point(643, 0);
            this._ComprasTlpResponsable.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpResponsable.Name = "_ComprasTlpResponsable";
            this._ComprasTlpResponsable.RowCount = 6;
            this._ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpResponsable.Size = new System.Drawing.Size(624, 207);
            this._ComprasTlpResponsable.TabIndex = 3;
            // 
            // ComprasUsrCorreoResponsable
            // 
            this.ComprasUsrCorreoResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrCorreoResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCorreoResponsable.Enabled = false;
            this.ComprasUsrCorreoResponsable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCorreoResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCorreoResponsable.Location = new System.Drawing.Point(132, 152);
            this.ComprasUsrCorreoResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrCorreoResponsable.MaxLength = 2147483647;
            this.ComprasUsrCorreoResponsable.MostrarEtiquetaError = false;
            this.ComprasUsrCorreoResponsable.Name = "ComprasUsrCorreoResponsable";
            this.ComprasUsrCorreoResponsable.SelectedText = "";
            this.ComprasUsrCorreoResponsable.SelectionLength = 0;
            this.ComprasUsrCorreoResponsable.SelectionStart = 0;
            this.ComprasUsrCorreoResponsable.Size = new System.Drawing.Size(400, 36);
            this.ComprasUsrCorreoResponsable.TabIndex = 10;
            // 
            // ComprasUsrPuestoResponsable
            // 
            this.ComprasUsrPuestoResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrPuestoResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrPuestoResponsable.Enabled = false;
            this.ComprasUsrPuestoResponsable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrPuestoResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrPuestoResponsable.Location = new System.Drawing.Point(132, 112);
            this.ComprasUsrPuestoResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrPuestoResponsable.MaxLength = 2147483647;
            this.ComprasUsrPuestoResponsable.MostrarEtiquetaError = false;
            this.ComprasUsrPuestoResponsable.Name = "ComprasUsrPuestoResponsable";
            this.ComprasUsrPuestoResponsable.SelectedText = "";
            this.ComprasUsrPuestoResponsable.SelectionLength = 0;
            this.ComprasUsrPuestoResponsable.SelectionStart = 0;
            this.ComprasUsrPuestoResponsable.Size = new System.Drawing.Size(400, 36);
            this.ComprasUsrPuestoResponsable.TabIndex = 9;
            // 
            // ComprasUsrNombreResponsable
            // 
            this.ComprasUsrNombreResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrNombreResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrNombreResponsable.Enabled = false;
            this.ComprasUsrNombreResponsable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrNombreResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrNombreResponsable.Location = new System.Drawing.Point(132, 72);
            this.ComprasUsrNombreResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrNombreResponsable.MaxLength = 2147483647;
            this.ComprasUsrNombreResponsable.MostrarEtiquetaError = false;
            this.ComprasUsrNombreResponsable.Name = "ComprasUsrNombreResponsable";
            this.ComprasUsrNombreResponsable.SelectedText = "";
            this.ComprasUsrNombreResponsable.SelectionLength = 0;
            this.ComprasUsrNombreResponsable.SelectionStart = 0;
            this.ComprasUsrNombreResponsable.Size = new System.Drawing.Size(400, 36);
            this.ComprasUsrNombreResponsable.TabIndex = 8;
            // 
            // ComprasUsrResponsable
            // 
            this.ComprasUsrResponsable.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasUsrResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpResponsable.SetColumnSpan(this.ComprasUsrResponsable, 3);
            this.ComprasUsrResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrResponsable.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.ComprasUsrResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrResponsable.Location = new System.Drawing.Point(4, 4);
            this.ComprasUsrResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.ComprasUsrResponsable.MaximumSize = new System.Drawing.Size(1250, 27);
            this.ComprasUsrResponsable.MostrarAsterisco = false;
            this.ComprasUsrResponsable.Name = "ComprasUsrResponsable";
            this.ComprasUsrResponsable.Size = new System.Drawing.Size(616, 22);
            this.ComprasUsrResponsable.TabIndex = 7;
            this.ComprasUsrResponsable.TabStop = false;
            this.ComprasUsrResponsable.TamanoTipografia = 10.8F;
            this.ComprasUsrResponsable.Text = "RESPONSABLE DE COMPRA";
            this.ComprasUsrResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasUsrResponsable.Texto = "RESPONSABLE DE COMPRA";
            // 
            // ComprasUsrCodigoResponsable
            // 
            this.ComprasUsrCodigoResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrCodigoResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCodigoResponsable.Enabled = false;
            this.ComprasUsrCodigoResponsable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCodigoResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCodigoResponsable.Location = new System.Drawing.Point(132, 32);
            this.ComprasUsrCodigoResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrCodigoResponsable.MaxLength = 2147483647;
            this.ComprasUsrCodigoResponsable.MostrarEtiquetaError = false;
            this.ComprasUsrCodigoResponsable.Name = "ComprasUsrCodigoResponsable";
            this.ComprasUsrCodigoResponsable.SelectedText = "";
            this.ComprasUsrCodigoResponsable.SelectionLength = 0;
            this.ComprasUsrCodigoResponsable.SelectionStart = 0;
            this.ComprasUsrCodigoResponsable.Size = new System.Drawing.Size(400, 36);
            this.ComprasUsrCodigoResponsable.TabIndex = 5;
            // 
            // ComprasUsrEtiquetaNombreResponsable
            // 
            this.ComprasUsrEtiquetaNombreResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaNombreResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaNombreResponsable.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaNombreResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaNombreResponsable.Location = new System.Drawing.Point(3, 33);
            this.ComprasUsrEtiquetaNombreResponsable.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaNombreResponsable.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaNombreResponsable.Name = "ComprasUsrEtiquetaNombreResponsable";
            this.ComprasUsrEtiquetaNombreResponsable.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaNombreResponsable.TabIndex = 2;
            this.ComprasUsrEtiquetaNombreResponsable.TabStop = false;
            this.ComprasUsrEtiquetaNombreResponsable.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaNombreResponsable.Text = "Nombre";
            this.ComprasUsrEtiquetaNombreResponsable.Texto = "Nombre";
            // 
            // ComprasUsrEtiquetaCodigoResponsable
            // 
            this.ComprasUsrEtiquetaCodigoResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaCodigoResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaCodigoResponsable.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaCodigoResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaCodigoResponsable.Location = new System.Drawing.Point(3, 73);
            this.ComprasUsrEtiquetaCodigoResponsable.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaCodigoResponsable.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaCodigoResponsable.Name = "ComprasUsrEtiquetaCodigoResponsable";
            this.ComprasUsrEtiquetaCodigoResponsable.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaCodigoResponsable.TabIndex = 1;
            this.ComprasUsrEtiquetaCodigoResponsable.TabStop = false;
            this.ComprasUsrEtiquetaCodigoResponsable.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaCodigoResponsable.Text = "Código";
            this.ComprasUsrEtiquetaCodigoResponsable.Texto = "Código";
            // 
            // ComprasUsrEtiquetaCorreoResponsable
            // 
            this.ComprasUsrEtiquetaCorreoResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaCorreoResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaCorreoResponsable.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaCorreoResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaCorreoResponsable.Location = new System.Drawing.Point(3, 113);
            this.ComprasUsrEtiquetaCorreoResponsable.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaCorreoResponsable.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaCorreoResponsable.Name = "ComprasUsrEtiquetaCorreoResponsable";
            this.ComprasUsrEtiquetaCorreoResponsable.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaCorreoResponsable.TabIndex = 4;
            this.ComprasUsrEtiquetaCorreoResponsable.TabStop = false;
            this.ComprasUsrEtiquetaCorreoResponsable.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaCorreoResponsable.Text = "Correo";
            this.ComprasUsrEtiquetaCorreoResponsable.Texto = "Correo";
            // 
            // ComprasUsrEtiquetaPuestoResponsable
            // 
            this.ComprasUsrEtiquetaPuestoResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaPuestoResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaPuestoResponsable.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaPuestoResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaPuestoResponsable.Location = new System.Drawing.Point(3, 153);
            this.ComprasUsrEtiquetaPuestoResponsable.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaPuestoResponsable.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaPuestoResponsable.Name = "ComprasUsrEtiquetaPuestoResponsable";
            this.ComprasUsrEtiquetaPuestoResponsable.Size = new System.Drawing.Size(124, 18);
            this.ComprasUsrEtiquetaPuestoResponsable.TabIndex = 3;
            this.ComprasUsrEtiquetaPuestoResponsable.TabStop = false;
            this.ComprasUsrEtiquetaPuestoResponsable.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaPuestoResponsable.Text = "Puesto";
            this.ComprasUsrEtiquetaPuestoResponsable.Texto = "Puesto";
            // 
            // ComprasBtnResponsable
            // 
            this.ComprasBtnResponsable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnResponsable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnResponsable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnResponsable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnResponsable.FlatAppearance.BorderSize = 0;
            this.ComprasBtnResponsable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnResponsable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnResponsable.Location = new System.Drawing.Point(539, 70);
            this.ComprasBtnResponsable.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnResponsable.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnResponsable.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnResponsable.Name = "ComprasBtnResponsable";
            this.ComprasBtnResponsable.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnResponsable.TabIndex = 11;
            this.ComprasBtnResponsable.Text = "Responsable de Compra";
            this.ComprasBtnResponsable.UseVisualStyleBackColor = false;
            // 
            // _ComprasGbxFinalizacion
            // 
            this._ComprasGbxFinalizacion.BackColor = System.Drawing.Color.Transparent;
            this._ComprasGbxFinalizacion.Controls.Add(this._ComprasTlpFinalizacion);
            this._ComprasGbxFinalizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasGbxFinalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasGbxFinalizacion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this._ComprasGbxFinalizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasGbxFinalizacion.Location = new System.Drawing.Point(3, 653);
            this._ComprasGbxFinalizacion.Name = "_ComprasGbxFinalizacion";
            this._ComprasGbxFinalizacion.Size = new System.Drawing.Size(1273, 244);
            this._ComprasGbxFinalizacion.TabIndex = 5;
            this._ComprasGbxFinalizacion.TabStop = false;
            this._ComprasGbxFinalizacion.Text = "Finalización";
            // 
            // _ComprasTlpFinalizacion
            // 
            this._ComprasTlpFinalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpFinalizacion.ColumnCount = 2;
            this._ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpFinalizacion.Controls.Add(this._ComprasTlpImportes, 1, 0);
            this._ComprasTlpFinalizacion.Controls.Add(this._ComprasTlpTotales, 0, 0);
            this._ComprasTlpFinalizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpFinalizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpFinalizacion.Location = new System.Drawing.Point(3, 24);
            this._ComprasTlpFinalizacion.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpFinalizacion.Name = "_ComprasTlpFinalizacion";
            this._ComprasTlpFinalizacion.RowCount = 1;
            this._ComprasTlpFinalizacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpFinalizacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this._ComprasTlpFinalizacion.Size = new System.Drawing.Size(1267, 217);
            this._ComprasTlpFinalizacion.TabIndex = 3;
            // 
            // _ComprasTlpImportes
            // 
            this._ComprasTlpImportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpImportes.ColumnCount = 2;
            this._ComprasTlpImportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this._ComprasTlpImportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpImportes.Controls.Add(this._ComprasTlpAcciones, 0, 2);
            this._ComprasTlpImportes.Controls.Add(this.ComprasUsrEtiquetaComentario, 0, 0);
            this._ComprasTlpImportes.Controls.Add(this.ComprasUsrComentario, 1, 0);
            this._ComprasTlpImportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpImportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpImportes.Location = new System.Drawing.Point(633, 0);
            this._ComprasTlpImportes.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpImportes.Name = "_ComprasTlpImportes";
            this._ComprasTlpImportes.RowCount = 4;
            this._ComprasTlpImportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._ComprasTlpImportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this._ComprasTlpImportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this._ComprasTlpImportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpImportes.Size = new System.Drawing.Size(634, 217);
            this._ComprasTlpImportes.TabIndex = 6;
            // 
            // _ComprasTlpAcciones
            // 
            this._ComprasTlpAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpAcciones.ColumnCount = 3;
            this._ComprasTlpImportes.SetColumnSpan(this._ComprasTlpAcciones, 2);
            this._ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this._ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this._ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpAcciones.Controls.Add(this._ComprasBtnGuardar, 1, 0);
            this._ComprasTlpAcciones.Controls.Add(this._ComprasBtnDescartar, 2, 0);
            this._ComprasTlpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpAcciones.Location = new System.Drawing.Point(0, 110);
            this._ComprasTlpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpAcciones.Name = "_ComprasTlpAcciones";
            this._ComprasTlpAcciones.RowCount = 1;
            this._ComprasTlpAcciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpAcciones.Size = new System.Drawing.Size(634, 90);
            this._ComprasTlpAcciones.TabIndex = 13;
            // 
            // _ComprasBtnGuardar
            // 
            this._ComprasBtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnGuardar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnGuardar.Location = new System.Drawing.Point(459, 5);
            this._ComprasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnGuardar.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnGuardar.Name = "_ComprasBtnGuardar";
            this._ComprasBtnGuardar.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnGuardar.TabIndex = 1;
            this._ComprasBtnGuardar.Text = "GUARDAR";
            this._ComprasBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnDescartar
            // 
            this._ComprasBtnDescartar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnDescartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnDescartar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnDescartar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnDescartar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnDescartar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnDescartar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnDescartar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnDescartar.Location = new System.Drawing.Point(549, 5);
            this._ComprasBtnDescartar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnDescartar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnDescartar.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnDescartar.Name = "_ComprasBtnDescartar";
            this._ComprasBtnDescartar.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnDescartar.TabIndex = 0;
            this._ComprasBtnDescartar.Text = "DESCARTAR";
            this._ComprasBtnDescartar.UseVisualStyleBackColor = false;
            // 
            // ComprasUsrEtiquetaComentario
            // 
            this.ComprasUsrEtiquetaComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaComentario.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaComentario.Location = new System.Drawing.Point(3, 3);
            this.ComprasUsrEtiquetaComentario.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaComentario.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaComentario.Name = "ComprasUsrEtiquetaComentario";
            this.ComprasUsrEtiquetaComentario.Size = new System.Drawing.Size(89, 18);
            this.ComprasUsrEtiquetaComentario.TabIndex = 12;
            this.ComprasUsrEtiquetaComentario.TabStop = false;
            this.ComprasUsrEtiquetaComentario.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaComentario.Text = "Comentario";
            this.ComprasUsrEtiquetaComentario.Texto = "Comentario";
            // 
            // ComprasUsrComentario
            // 
            this.ComprasUsrComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrComentario.Location = new System.Drawing.Point(95, 0);
            this.ComprasUsrComentario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrComentario.MaxLength = 2147483647;
            this.ComprasUsrComentario.MostrarEtiquetaError = false;
            this.ComprasUsrComentario.Multiline = true;
            this.ComprasUsrComentario.Name = "ComprasUsrComentario";
            this.ComprasUsrComentario.SelectedText = "";
            this.ComprasUsrComentario.SelectionLength = 0;
            this.ComprasUsrComentario.SelectionStart = 0;
            this.ComprasUsrComentario.Size = new System.Drawing.Size(539, 100);
            this.ComprasUsrComentario.TabIndex = 14;
            // 
            // _ComprasTlpTotales
            // 
            this._ComprasTlpTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpTotales.ColumnCount = 3;
            this._ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this._ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrImpuesto, 1, 0);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaSubtotal, 0, 0);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrSubtotal, 1, 4);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrDescuento, 1, 3);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrGastosAdicionales, 1, 2);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaDescuento, 0, 1);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaGastosAdicionales, 0, 2);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaImpuesto, 0, 3);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaTotal, 0, 4);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrTotal, 1, 1);
            this._ComprasTlpTotales.Controls.Add(this._ComprasBtnPorcentaje, 2, 1);
            this._ComprasTlpTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpTotales.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpTotales.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpTotales.Name = "_ComprasTlpTotales";
            this._ComprasTlpTotales.RowCount = 6;
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpTotales.Size = new System.Drawing.Size(633, 217);
            this._ComprasTlpTotales.TabIndex = 5;
            // 
            // ComprasUsrImpuesto
            // 
            this.ComprasUsrImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpTotales.SetColumnSpan(this.ComprasUsrImpuesto, 2);
            this.ComprasUsrImpuesto.Enabled = false;
            this.ComprasUsrImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrImpuesto.Location = new System.Drawing.Point(212, 2);
            this.ComprasUsrImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrImpuesto.MaxLength = 2147483647;
            this.ComprasUsrImpuesto.MostrarEtiquetaError = false;
            this.ComprasUsrImpuesto.Name = "ComprasUsrImpuesto";
            this.ComprasUsrImpuesto.SelectedText = "";
            this.ComprasUsrImpuesto.SelectionLength = 0;
            this.ComprasUsrImpuesto.SelectionStart = 0;
            this.ComprasUsrImpuesto.Size = new System.Drawing.Size(419, 36);
            this.ComprasUsrImpuesto.TabIndex = 12;
            // 
            // ComprasUsrEtiquetaSubtotal
            // 
            this.ComprasUsrEtiquetaSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaSubtotal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaSubtotal.Location = new System.Drawing.Point(3, 11);
            this.ComprasUsrEtiquetaSubtotal.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaSubtotal.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaSubtotal.Name = "ComprasUsrEtiquetaSubtotal";
            this.ComprasUsrEtiquetaSubtotal.Size = new System.Drawing.Size(204, 18);
            this.ComprasUsrEtiquetaSubtotal.TabIndex = 11;
            this.ComprasUsrEtiquetaSubtotal.TabStop = false;
            this.ComprasUsrEtiquetaSubtotal.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaSubtotal.Text = "Total antes del descuento";
            this.ComprasUsrEtiquetaSubtotal.Texto = "Total antes del descuento";
            // 
            // ComprasUsrSubtotal
            // 
            this.ComprasUsrSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpTotales.SetColumnSpan(this.ComprasUsrSubtotal, 2);
            this.ComprasUsrSubtotal.Enabled = false;
            this.ComprasUsrSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrSubtotal.Location = new System.Drawing.Point(212, 162);
            this.ComprasUsrSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrSubtotal.MaxLength = 2147483647;
            this.ComprasUsrSubtotal.MostrarEtiquetaError = false;
            this.ComprasUsrSubtotal.Name = "ComprasUsrSubtotal";
            this.ComprasUsrSubtotal.SelectedText = "";
            this.ComprasUsrSubtotal.SelectionLength = 0;
            this.ComprasUsrSubtotal.SelectionStart = 0;
            this.ComprasUsrSubtotal.Size = new System.Drawing.Size(419, 36);
            this.ComprasUsrSubtotal.TabIndex = 10;
            // 
            // ComprasUsrDescuento
            // 
            this.ComprasUsrDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpTotales.SetColumnSpan(this.ComprasUsrDescuento, 2);
            this.ComprasUsrDescuento.Enabled = false;
            this.ComprasUsrDescuento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrDescuento.Location = new System.Drawing.Point(212, 122);
            this.ComprasUsrDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrDescuento.MaxLength = 2147483647;
            this.ComprasUsrDescuento.MostrarEtiquetaError = false;
            this.ComprasUsrDescuento.Name = "ComprasUsrDescuento";
            this.ComprasUsrDescuento.SelectedText = "";
            this.ComprasUsrDescuento.SelectionLength = 0;
            this.ComprasUsrDescuento.SelectionStart = 0;
            this.ComprasUsrDescuento.Size = new System.Drawing.Size(419, 36);
            this.ComprasUsrDescuento.TabIndex = 9;
            // 
            // ComprasUsrGastosAdicionales
            // 
            this.ComprasUsrGastosAdicionales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrGastosAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpTotales.SetColumnSpan(this.ComprasUsrGastosAdicionales, 2);
            this.ComprasUsrGastosAdicionales.Enabled = false;
            this.ComprasUsrGastosAdicionales.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrGastosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrGastosAdicionales.Location = new System.Drawing.Point(212, 82);
            this.ComprasUsrGastosAdicionales.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrGastosAdicionales.MaxLength = 2147483647;
            this.ComprasUsrGastosAdicionales.MostrarEtiquetaError = false;
            this.ComprasUsrGastosAdicionales.Name = "ComprasUsrGastosAdicionales";
            this.ComprasUsrGastosAdicionales.SelectedText = "";
            this.ComprasUsrGastosAdicionales.SelectionLength = 0;
            this.ComprasUsrGastosAdicionales.SelectionStart = 0;
            this.ComprasUsrGastosAdicionales.Size = new System.Drawing.Size(419, 36);
            this.ComprasUsrGastosAdicionales.TabIndex = 8;
            // 
            // ComprasUsrEtiquetaDescuento
            // 
            this.ComprasUsrEtiquetaDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaDescuento.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaDescuento.Location = new System.Drawing.Point(3, 51);
            this.ComprasUsrEtiquetaDescuento.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaDescuento.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaDescuento.Name = "ComprasUsrEtiquetaDescuento";
            this.ComprasUsrEtiquetaDescuento.Size = new System.Drawing.Size(204, 18);
            this.ComprasUsrEtiquetaDescuento.TabIndex = 1;
            this.ComprasUsrEtiquetaDescuento.TabStop = false;
            this.ComprasUsrEtiquetaDescuento.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaDescuento.Text = "Descuento";
            this.ComprasUsrEtiquetaDescuento.Texto = "Descuento";
            // 
            // ComprasUsrEtiquetaGastosAdicionales
            // 
            this.ComprasUsrEtiquetaGastosAdicionales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaGastosAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaGastosAdicionales.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaGastosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaGastosAdicionales.Location = new System.Drawing.Point(3, 91);
            this.ComprasUsrEtiquetaGastosAdicionales.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaGastosAdicionales.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaGastosAdicionales.Name = "ComprasUsrEtiquetaGastosAdicionales";
            this.ComprasUsrEtiquetaGastosAdicionales.Size = new System.Drawing.Size(204, 18);
            this.ComprasUsrEtiquetaGastosAdicionales.TabIndex = 2;
            this.ComprasUsrEtiquetaGastosAdicionales.TabStop = false;
            this.ComprasUsrEtiquetaGastosAdicionales.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaGastosAdicionales.Text = "Gastos Adicionales";
            this.ComprasUsrEtiquetaGastosAdicionales.Texto = "Gastos Adicionales";
            // 
            // ComprasUsrEtiquetaImpuesto
            // 
            this.ComprasUsrEtiquetaImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaImpuesto.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaImpuesto.Location = new System.Drawing.Point(3, 131);
            this.ComprasUsrEtiquetaImpuesto.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaImpuesto.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaImpuesto.Name = "ComprasUsrEtiquetaImpuesto";
            this.ComprasUsrEtiquetaImpuesto.Size = new System.Drawing.Size(204, 18);
            this.ComprasUsrEtiquetaImpuesto.TabIndex = 3;
            this.ComprasUsrEtiquetaImpuesto.TabStop = false;
            this.ComprasUsrEtiquetaImpuesto.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaImpuesto.Text = "Impuesto";
            this.ComprasUsrEtiquetaImpuesto.Texto = "Impuesto";
            // 
            // ComprasUsrEtiquetaTotal
            // 
            this.ComprasUsrEtiquetaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaTotal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaTotal.Location = new System.Drawing.Point(3, 171);
            this.ComprasUsrEtiquetaTotal.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaTotal.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaTotal.Name = "ComprasUsrEtiquetaTotal";
            this.ComprasUsrEtiquetaTotal.Size = new System.Drawing.Size(204, 18);
            this.ComprasUsrEtiquetaTotal.TabIndex = 4;
            this.ComprasUsrEtiquetaTotal.TabStop = false;
            this.ComprasUsrEtiquetaTotal.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaTotal.Text = "Total pago vencido";
            this.ComprasUsrEtiquetaTotal.Texto = "Total pago vencido";
            // 
            // ComprasUsrTotal
            // 
            this.ComprasUsrTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTotal.Enabled = false;
            this.ComprasUsrTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTotal.Location = new System.Drawing.Point(212, 42);
            this.ComprasUsrTotal.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrTotal.MaxLength = 2147483647;
            this.ComprasUsrTotal.MostrarEtiquetaError = false;
            this.ComprasUsrTotal.Name = "ComprasUsrTotal";
            this.ComprasUsrTotal.SelectedText = "";
            this.ComprasUsrTotal.SelectionLength = 0;
            this.ComprasUsrTotal.SelectionStart = 0;
            this.ComprasUsrTotal.Size = new System.Drawing.Size(379, 36);
            this.ComprasUsrTotal.TabIndex = 5;
            this._ComprasBtnPorcentaje.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnPorcentaje
            // 
            this._ComprasBtnPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnPorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnPorcentaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnPorcentaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnPorcentaje.FlatAppearance.BorderSize = 0;
            this._ComprasBtnPorcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnPorcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnPorcentaje.Location = new System.Drawing.Point(596, 43);
            this._ComprasBtnPorcentaje.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnPorcentaje.Name = "_ComprasBtnPorcentaje";
            this._ComprasBtnPorcentaje.Size = new System.Drawing.Size(34, 34);
            this._ComprasBtnPorcentaje.TabIndex = 13;
            this._ComprasBtnPorcentaje.Text = "%";
            this._ComprasBtnPorcentaje.UseVisualStyleBackColor = false;
            // 
            // _ComprasGbxDetalles
            // 
            this._ComprasGbxDetalles.BackColor = System.Drawing.Color.Transparent;
            this._ComprasGbxDetalles.Controls.Add(this._ComprasTlpDetalles);
            this._ComprasGbxDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasGbxDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasGbxDetalles.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this._ComprasGbxDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasGbxDetalles.Location = new System.Drawing.Point(3, 243);
            this._ComprasGbxDetalles.Name = "_ComprasGbxDetalles";
            this._ComprasGbxDetalles.Size = new System.Drawing.Size(1273, 404);
            this._ComprasGbxDetalles.TabIndex = 6;
            this._ComprasGbxDetalles.TabStop = false;
            this._ComprasGbxDetalles.Text = "Detalles";
            // 
            // _ComprasTlpDetalles
            // 
            this._ComprasTlpDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpDetalles.ColumnCount = 4;
            this._ComprasTlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpDetalles.Controls.Add(this._ComprasPnlArticulos, 0, 1);
            this._ComprasTlpDetalles.Controls.Add(this._ComprasBtnArticulos, 0, 0);
            this._ComprasTlpDetalles.Controls.Add(this._ComprasBtnLogistica, 1, 0);
            this._ComprasTlpDetalles.Controls.Add(this._ComprasBtnFinanzas, 2, 0);
            this._ComprasTlpDetalles.Controls.Add(this._ComprasBtnAnexos, 3, 0);
            this._ComprasTlpDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpDetalles.Location = new System.Drawing.Point(3, 24);
            this._ComprasTlpDetalles.Name = "_ComprasTlpDetalles";
            this._ComprasTlpDetalles.RowCount = 2;
            this._ComprasTlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpDetalles.Size = new System.Drawing.Size(1267, 377);
            this._ComprasTlpDetalles.TabIndex = 0;
            // 
            // _ComprasPnlArticulos
            // 
            this._ComprasPnlArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpDetalles.SetColumnSpan(this._ComprasPnlArticulos, 4);
            this._ComprasPnlArticulos.Controls.Add(this.ComprasUsrArticulos);
            this._ComprasPnlArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasPnlArticulos.Location = new System.Drawing.Point(0, 40);
            this._ComprasPnlArticulos.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlArticulos.Name = "_ComprasPnlArticulos";
            this._ComprasPnlArticulos.Size = new System.Drawing.Size(1267, 337);
            this._ComprasPnlArticulos.TabIndex = 0;
            // 
            // ComprasUsrArticulos
            // 
            this.ComprasUsrArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrArticulos.Location = new System.Drawing.Point(0, 0);
            this.ComprasUsrArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrArticulos.Name = "ComprasUsrArticulos";
            this.ComprasUsrArticulos.Size = new System.Drawing.Size(1267, 337);
            this.ComprasUsrArticulos.TabIndex = 0;
            this._ComprasBtnArticulos.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnArticulos
            // 
            this._ComprasBtnArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnArticulos.FlatAppearance.BorderSize = 0;
            this._ComprasBtnArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnArticulos.Location = new System.Drawing.Point(0, 0);
            this._ComprasBtnArticulos.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnArticulos.Name = "_ComprasBtnArticulos";
            this._ComprasBtnArticulos.Size = new System.Drawing.Size(316, 40);
            this._ComprasBtnArticulos.TabIndex = 1;
            this._ComprasBtnArticulos.Text = "ARTÍCULOS";
            this._ComprasBtnArticulos.UseVisualStyleBackColor = false;
            this._ComprasBtnLogistica.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnLogistica
            // 
            this._ComprasBtnLogistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnLogistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnLogistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnLogistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnLogistica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnLogistica.FlatAppearance.BorderSize = 0;
            this._ComprasBtnLogistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnLogistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnLogistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnLogistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnLogistica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnLogistica.Location = new System.Drawing.Point(316, 0);
            this._ComprasBtnLogistica.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnLogistica.Name = "_ComprasBtnLogistica";
            this._ComprasBtnLogistica.Size = new System.Drawing.Size(316, 40);
            this._ComprasBtnLogistica.TabIndex = 2;
            this._ComprasBtnLogistica.Text = "LOGÍSTICA";
            this._ComprasBtnLogistica.UseVisualStyleBackColor = false;
            this._ComprasBtnFinanzas.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnFinanzas
            // 
            this._ComprasBtnFinanzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnFinanzas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnFinanzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnFinanzas.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnFinanzas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnFinanzas.FlatAppearance.BorderSize = 0;
            this._ComprasBtnFinanzas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnFinanzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnFinanzas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnFinanzas.Location = new System.Drawing.Point(632, 0);
            this._ComprasBtnFinanzas.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnFinanzas.Name = "_ComprasBtnFinanzas";
            this._ComprasBtnFinanzas.Size = new System.Drawing.Size(316, 40);
            this._ComprasBtnFinanzas.TabIndex = 3;
            this._ComprasBtnFinanzas.Text = "FINANZAS";
            this._ComprasBtnFinanzas.UseVisualStyleBackColor = false;
            this._ComprasBtnAnexos.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnAnexos
            // 
            this._ComprasBtnAnexos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnAnexos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnAnexos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnAnexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnAnexos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAnexos.FlatAppearance.BorderSize = 0;
            this._ComprasBtnAnexos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnAnexos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnAnexos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnAnexos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAnexos.Location = new System.Drawing.Point(948, 0);
            this._ComprasBtnAnexos.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnAnexos.Name = "_ComprasBtnAnexos";
            this._ComprasBtnAnexos.Size = new System.Drawing.Size(319, 40);
            this._ComprasBtnAnexos.TabIndex = 4;
            this._ComprasBtnAnexos.Text = "ANEXOS";
            this._ComprasBtnAnexos.UseVisualStyleBackColor = false;
            // 
            // FrmOrdenesCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 853);
            this.Controls.Add(this._ComprasPnlDesplazamiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "FrmOrdenesCompra";
            this.Text = "6003 – OrdenesCompra";
            this._ComprasPnlDesplazamiento.ResumeLayout(false);
            this._ComprasPnlContenido.ResumeLayout(false);
            this._ComprasTlpPrincipal.ResumeLayout(false);
            this._ComprasGbxEncabezado.ResumeLayout(false);
            this._ComprasTlpEncabezado.ResumeLayout(false);
            this._ComprasTlpProveedor.ResumeLayout(false);
            this._ComprasTlpResponsable.ResumeLayout(false);
            this._ComprasGbxFinalizacion.ResumeLayout(false);
            this._ComprasTlpFinalizacion.ResumeLayout(false);
            this._ComprasTlpImportes.ResumeLayout(false);
            this._ComprasTlpAcciones.ResumeLayout(false);
            this._ComprasTlpTotales.ResumeLayout(false);
            this._ComprasGbxDetalles.ResumeLayout(false);
            this._ComprasTlpDetalles.ResumeLayout(false);
            this._ComprasPnlArticulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpPrincipal;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras _ComprasGbxEncabezado;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpEncabezado;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpResponsable;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrCodigoResponsable;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaCodigoResponsable;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaNombreResponsable;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaPuestoResponsable;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaCorreoResponsable;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrResponsable;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrNombreProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaNombreProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaTelefonoProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaCorreoProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaContactoProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrContactoProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrCorreoProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrTelefonoProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrCorreoResponsable;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrPuestoResponsable;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrNombreResponsable;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras _ComprasGbxFinalizacion;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpFinalizacion;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpImportes;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpTotales;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrImpuesto;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaSubtotal;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrSubtotal;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrDescuento;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrGastosAdicionales;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrTotal;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaDescuento;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaGastosAdicionales;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaImpuesto;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaTotal;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaComentario;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpAcciones;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnDescartar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnGuardar;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras _ComprasGbxDetalles;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpDetalles;
        private CapaVista_Componentes.Componentes.ClsPanelCompras _ComprasPnlArticulos;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnArticulos;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnLogistica;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnFinanzas;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnAnexos;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrComentario;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnPorcentaje;
        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasUsrArticulos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnProveedor;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnResponsable;
    }
}
