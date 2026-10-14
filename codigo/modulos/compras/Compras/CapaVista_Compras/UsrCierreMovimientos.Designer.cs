namespace CapaVista_Compras
{
    partial class UsrCierreMovimientos
    {
        private System.ComponentModel.IContainer _Componentes = null;

        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrCierreMovimientos));
            this._ComprasTlpPrincipal = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrTitulo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasGbxPeriodo = new CapaVista_Compras.Componentes.ClsGroupBoxCompras();
            this.ComprasUsrPeriodo = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.ComprasUsrEtiquetaPeriodo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasTlpContenido = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasGbxValidaciones = new CapaVista_Compras.Componentes.ClsGroupBoxCompras();
            this.ComprasUsrValidaciones = new CapaVista_Compras.Componentes.UsrDataGridViewCompras();
            this._ComprasGbxSaldos = new CapaVista_Compras.Componentes.ClsGroupBoxCompras();
            this.ComprasUsrSaldos = new CapaVista_Compras.Componentes.UsrDataGridViewCompras();
            this._ComprasTlpTotales = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrTotalCargos = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaTotalAbonos = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrTotalAbonos = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaSaldoFinal = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrSaldoFinal = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaTotalCargos = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasTlpBotones = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnEjecutarCierre = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnValidar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnImprimir = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnAyuda = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnSalir = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasTlpPrincipal.SuspendLayout();
            this._ComprasGbxPeriodo.SuspendLayout();
            this._ComprasTlpContenido.SuspendLayout();
            this._ComprasGbxValidaciones.SuspendLayout();
            this._ComprasGbxSaldos.SuspendLayout();
            this._ComprasTlpTotales.SuspendLayout();
            this._ComprasTlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ComprasTlpPrincipal
            // 
            this._ComprasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpPrincipal.ColumnCount = 1;
            this._ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.Controls.Add(this.ComprasUsrTitulo, 0, 0);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasGbxPeriodo, 0, 1);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasTlpContenido, 0, 2);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasTlpTotales, 0, 3);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasTlpBotones, 0, 4);
            this._ComprasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpPrincipal.Name = "_ComprasTlpPrincipal";
            this._ComprasTlpPrincipal.Padding = new System.Windows.Forms.Padding(16);
            this._ComprasTlpPrincipal.RowCount = 5;
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._ComprasTlpPrincipal.Size = new System.Drawing.Size(1610, 723);
            this._ComprasTlpPrincipal.TabIndex = 0;
            // 
            // ComprasUsrTitulo
            // 
            this.ComprasUsrTitulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTitulo.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.ComprasUsrTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTitulo.Location = new System.Drawing.Point(21, 22);
            this.ComprasUsrTitulo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasUsrTitulo.MaximumSize = new System.Drawing.Size(1875, 40);
            this.ComprasUsrTitulo.MostrarAsterisco = false;
            this.ComprasUsrTitulo.Name = "ComprasUsrTitulo";
            this.ComprasUsrTitulo.Size = new System.Drawing.Size(390, 38);
            this.ComprasUsrTitulo.TabIndex = 0;
            this.ComprasUsrTitulo.TabStop = false;
            this.ComprasUsrTitulo.TamanoTipografia = 16.2F;
            this.ComprasUsrTitulo.Text = "Cierre de Movimientos";
            this.ComprasUsrTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrTitulo.Texto = "Cierre de Movimientos";
            // 
            // _ComprasGbxPeriodo
            // 
            this._ComprasGbxPeriodo.BackColor = System.Drawing.Color.Transparent;
            this._ComprasGbxPeriodo.Controls.Add(this.ComprasUsrPeriodo);
            this._ComprasGbxPeriodo.Controls.Add(this.ComprasUsrEtiquetaPeriodo);
            this._ComprasGbxPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasGbxPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasGbxPeriodo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this._ComprasGbxPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasGbxPeriodo.Location = new System.Drawing.Point(19, 69);
            this._ComprasGbxPeriodo.Name = "_ComprasGbxPeriodo";
            this._ComprasGbxPeriodo.Size = new System.Drawing.Size(1572, 74);
            this._ComprasGbxPeriodo.TabIndex = 1;
            this._ComprasGbxPeriodo.TabStop = false;
            this._ComprasGbxPeriodo.Text = "Período a cerrar";
            // 
            // ComprasUsrPeriodo
            // 
            this.ComprasUsrPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrPeriodo.Location = new System.Drawing.Point(214, 24);
            this.ComprasUsrPeriodo.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrPeriodo.MaxLength = 0;
            this.ComprasUsrPeriodo.MostrarEtiquetaError = false;
            this.ComprasUsrPeriodo.Name = "ComprasUsrPeriodo";
            this.ComprasUsrPeriodo.Size = new System.Drawing.Size(174, 36);
            this.ComprasUsrPeriodo.TabIndex = 1;
            // 
            // ComprasUsrEtiquetaPeriodo
            // 
            this.ComprasUsrEtiquetaPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaPeriodo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaPeriodo.Location = new System.Drawing.Point(3, 27);
            this.ComprasUsrEtiquetaPeriodo.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaPeriodo.Name = "ComprasUsrEtiquetaPeriodo";
            this.ComprasUsrEtiquetaPeriodo.Size = new System.Drawing.Size(208, 22);
            this.ComprasUsrEtiquetaPeriodo.TabIndex = 0;
            this.ComprasUsrEtiquetaPeriodo.TabStop = false;
            this.ComprasUsrEtiquetaPeriodo.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaPeriodo.Text = "Período";
            this.ComprasUsrEtiquetaPeriodo.Texto = "Período";
            // 
            // _ComprasTlpContenido
            // 
            this._ComprasTlpContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpContenido.ColumnCount = 2;
            this._ComprasTlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._ComprasTlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._ComprasTlpContenido.Controls.Add(this._ComprasGbxValidaciones, 0, 0);
            this._ComprasTlpContenido.Controls.Add(this._ComprasGbxSaldos, 1, 0);
            this._ComprasTlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpContenido.Location = new System.Drawing.Point(19, 149);
            this._ComprasTlpContenido.Name = "_ComprasTlpContenido";
            this._ComprasTlpContenido.RowCount = 1;
            this._ComprasTlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this._ComprasTlpContenido.Size = new System.Drawing.Size(1572, 375);
            this._ComprasTlpContenido.TabIndex = 2;
            // 
            // _ComprasGbxValidaciones
            // 
            this._ComprasGbxValidaciones.BackColor = System.Drawing.Color.Transparent;
            this._ComprasGbxValidaciones.Controls.Add(this.ComprasUsrValidaciones);
            this._ComprasGbxValidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasGbxValidaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasGbxValidaciones.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this._ComprasGbxValidaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasGbxValidaciones.Location = new System.Drawing.Point(3, 3);
            this._ComprasGbxValidaciones.Name = "_ComprasGbxValidaciones";
            this._ComprasGbxValidaciones.Size = new System.Drawing.Size(622, 369);
            this._ComprasGbxValidaciones.TabIndex = 0;
            this._ComprasGbxValidaciones.TabStop = false;
            this._ComprasGbxValidaciones.Text = "Validaciones previas";
            // 
            // ComprasUsrValidaciones
            // 
            this.ComprasUsrValidaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrValidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrValidaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrValidaciones.Location = new System.Drawing.Point(3, 24);
            this.ComprasUsrValidaciones.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrValidaciones.Name = "ComprasUsrValidaciones";
            this.ComprasUsrValidaciones.Size = new System.Drawing.Size(616, 342);
            this.ComprasUsrValidaciones.TabIndex = 0;
            // 
            // _ComprasGbxSaldos
            // 
            this._ComprasGbxSaldos.BackColor = System.Drawing.Color.Transparent;
            this._ComprasGbxSaldos.Controls.Add(this.ComprasUsrSaldos);
            this._ComprasGbxSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasGbxSaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasGbxSaldos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this._ComprasGbxSaldos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasGbxSaldos.Location = new System.Drawing.Point(631, 3);
            this._ComprasGbxSaldos.Name = "_ComprasGbxSaldos";
            this._ComprasGbxSaldos.Size = new System.Drawing.Size(938, 369);
            this._ComprasGbxSaldos.TabIndex = 1;
            this._ComprasGbxSaldos.TabStop = false;
            this._ComprasGbxSaldos.Text = "Resumen por proveedor";
            // 
            // ComprasUsrSaldos
            // 
            this.ComprasUsrSaldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrSaldos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrSaldos.Location = new System.Drawing.Point(3, 24);
            this.ComprasUsrSaldos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrSaldos.Name = "ComprasUsrSaldos";
            this.ComprasUsrSaldos.Size = new System.Drawing.Size(932, 342);
            this.ComprasUsrSaldos.TabIndex = 0;
            // 
            // _ComprasTlpTotales
            // 
            this._ComprasTlpTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpTotales.ColumnCount = 3;
            this._ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrTotalCargos, 0, 1);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaTotalAbonos, 1, 0);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrTotalAbonos, 1, 1);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaSaldoFinal, 2, 0);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrSaldoFinal, 2, 1);
            this._ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaTotalCargos, 0, 0);
            this._ComprasTlpTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpTotales.Location = new System.Drawing.Point(19, 530);
            this._ComprasTlpTotales.Name = "_ComprasTlpTotales";
            this._ComprasTlpTotales.RowCount = 2;
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this._ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpTotales.Size = new System.Drawing.Size(1572, 74);
            this._ComprasTlpTotales.TabIndex = 3;
            // 
            // ComprasUsrTotalCargos
            // 
            this.ComprasUsrTotalCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTotalCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTotalCargos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTotalCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTotalCargos.Location = new System.Drawing.Point(0, 26);
            this.ComprasUsrTotalCargos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrTotalCargos.MaxLength = 2147483647;
            this.ComprasUsrTotalCargos.MostrarEtiquetaError = false;
            this.ComprasUsrTotalCargos.Name = "ComprasUsrTotalCargos";
            this.ComprasUsrTotalCargos.ReadOnly = true;
            this.ComprasUsrTotalCargos.SelectedText = "";
            this.ComprasUsrTotalCargos.SelectionLength = 0;
            this.ComprasUsrTotalCargos.SelectionStart = 0;
            this.ComprasUsrTotalCargos.Size = new System.Drawing.Size(524, 48);
            this.ComprasUsrTotalCargos.TabIndex = 1;
            // 
            // ComprasUsrEtiquetaTotalAbonos
            // 
            this.ComprasUsrEtiquetaTotalAbonos.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrEtiquetaTotalAbonos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaTotalAbonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEtiquetaTotalAbonos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaTotalAbonos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaTotalAbonos.Location = new System.Drawing.Point(527, 3);
            this.ComprasUsrEtiquetaTotalAbonos.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaTotalAbonos.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaTotalAbonos.Name = "ComprasUsrEtiquetaTotalAbonos";
            this.ComprasUsrEtiquetaTotalAbonos.Size = new System.Drawing.Size(518, 20);
            this.ComprasUsrEtiquetaTotalAbonos.TabIndex = 2;
            this.ComprasUsrEtiquetaTotalAbonos.TabStop = false;
            this.ComprasUsrEtiquetaTotalAbonos.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaTotalAbonos.Text = "Total Abonos (Q):";
            this.ComprasUsrEtiquetaTotalAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrEtiquetaTotalAbonos.Texto = "Total Abonos (Q):";
            // 
            // ComprasUsrTotalAbonos
            // 
            this.ComprasUsrTotalAbonos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTotalAbonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTotalAbonos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTotalAbonos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTotalAbonos.Location = new System.Drawing.Point(524, 26);
            this.ComprasUsrTotalAbonos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrTotalAbonos.MaxLength = 2147483647;
            this.ComprasUsrTotalAbonos.MostrarEtiquetaError = false;
            this.ComprasUsrTotalAbonos.Name = "ComprasUsrTotalAbonos";
            this.ComprasUsrTotalAbonos.ReadOnly = true;
            this.ComprasUsrTotalAbonos.SelectedText = "";
            this.ComprasUsrTotalAbonos.SelectionLength = 0;
            this.ComprasUsrTotalAbonos.SelectionStart = 0;
            this.ComprasUsrTotalAbonos.Size = new System.Drawing.Size(524, 48);
            this.ComprasUsrTotalAbonos.TabIndex = 3;
            // 
            // ComprasUsrEtiquetaSaldoFinal
            // 
            this.ComprasUsrEtiquetaSaldoFinal.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrEtiquetaSaldoFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaSaldoFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEtiquetaSaldoFinal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaSaldoFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaSaldoFinal.Location = new System.Drawing.Point(1051, 3);
            this.ComprasUsrEtiquetaSaldoFinal.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaSaldoFinal.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaSaldoFinal.Name = "ComprasUsrEtiquetaSaldoFinal";
            this.ComprasUsrEtiquetaSaldoFinal.Size = new System.Drawing.Size(518, 20);
            this.ComprasUsrEtiquetaSaldoFinal.TabIndex = 4;
            this.ComprasUsrEtiquetaSaldoFinal.TabStop = false;
            this.ComprasUsrEtiquetaSaldoFinal.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaSaldoFinal.Text = "Saldo Final CxP (Q):";
            this.ComprasUsrEtiquetaSaldoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrEtiquetaSaldoFinal.Texto = "Saldo Final CxP (Q):";
            // 
            // ComprasUsrSaldoFinal
            // 
            this.ComprasUsrSaldoFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrSaldoFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrSaldoFinal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrSaldoFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrSaldoFinal.Location = new System.Drawing.Point(1048, 26);
            this.ComprasUsrSaldoFinal.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrSaldoFinal.MaxLength = 2147483647;
            this.ComprasUsrSaldoFinal.MostrarEtiquetaError = false;
            this.ComprasUsrSaldoFinal.Name = "ComprasUsrSaldoFinal";
            this.ComprasUsrSaldoFinal.ReadOnly = true;
            this.ComprasUsrSaldoFinal.SelectedText = "";
            this.ComprasUsrSaldoFinal.SelectionLength = 0;
            this.ComprasUsrSaldoFinal.SelectionStart = 0;
            this.ComprasUsrSaldoFinal.Size = new System.Drawing.Size(524, 48);
            this.ComprasUsrSaldoFinal.TabIndex = 5;
            // 
            // ComprasUsrEtiquetaTotalCargos
            // 
            this.ComprasUsrEtiquetaTotalCargos.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrEtiquetaTotalCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaTotalCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEtiquetaTotalCargos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaTotalCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaTotalCargos.Location = new System.Drawing.Point(3, 3);
            this.ComprasUsrEtiquetaTotalCargos.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaTotalCargos.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaTotalCargos.Name = "ComprasUsrEtiquetaTotalCargos";
            this.ComprasUsrEtiquetaTotalCargos.Size = new System.Drawing.Size(518, 20);
            this.ComprasUsrEtiquetaTotalCargos.TabIndex = 0;
            this.ComprasUsrEtiquetaTotalCargos.TabStop = false;
            this.ComprasUsrEtiquetaTotalCargos.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaTotalCargos.Text = "Total Cargos (Q):";
            this.ComprasUsrEtiquetaTotalCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrEtiquetaTotalCargos.Texto = "Total Cargos (Q):";
            // 
            // _ComprasTlpBotones
            // 
            this._ComprasTlpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpBotones.ColumnCount = 5;
            this._ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._ComprasTlpBotones.Controls.Add(this._ComprasBtnEjecutarCierre, 1, 0);
            this._ComprasTlpBotones.Controls.Add(this._ComprasBtnValidar, 0, 0);
            this._ComprasTlpBotones.Controls.Add(this._ComprasBtnImprimir, 2, 0);
            this._ComprasTlpBotones.Controls.Add(this._ComprasBtnAyuda, 3, 0);
            this._ComprasTlpBotones.Controls.Add(this._ComprasBtnSalir, 4, 0);
            this._ComprasTlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpBotones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpBotones.Location = new System.Drawing.Point(19, 610);
            this._ComprasTlpBotones.Name = "_ComprasTlpBotones";
            this._ComprasTlpBotones.RowCount = 1;
            this._ComprasTlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpBotones.Size = new System.Drawing.Size(1572, 94);
            this._ComprasTlpBotones.TabIndex = 4;
            // 
            // _ComprasBtnEjecutarCierre
            // 
            this._ComprasBtnEjecutarCierre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnEjecutarCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnEjecutarCierre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnEjecutarCierre.BackgroundImage")));
            this._ComprasBtnEjecutarCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnEjecutarCierre.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnEjecutarCierre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnEjecutarCierre.FlatAppearance.BorderSize = 0;
            this._ComprasBtnEjecutarCierre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnEjecutarCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnEjecutarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnEjecutarCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnEjecutarCierre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnEjecutarCierre.Location = new System.Drawing.Point(431, 7);
            this._ComprasBtnEjecutarCierre.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnEjecutarCierre.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnEjecutarCierre.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnEjecutarCierre.Name = "_ComprasBtnEjecutarCierre";
            this._ComprasBtnEjecutarCierre.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnEjecutarCierre.TabIndex = 1;
            this._ComprasBtnEjecutarCierre.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnValidar
            // 
            this._ComprasBtnValidar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnValidar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnValidar.BackgroundImage")));
            this._ComprasBtnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnValidar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnValidar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnValidar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnValidar.Location = new System.Drawing.Point(117, 7);
            this._ComprasBtnValidar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnValidar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnValidar.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnValidar.Name = "_ComprasBtnValidar";
            this._ComprasBtnValidar.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnValidar.TabIndex = 0;
            this._ComprasBtnValidar.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnImprimir
            // 
            this._ComprasBtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnImprimir.FlatAppearance.BorderSize = 0;
            this._ComprasBtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnImprimir.Location = new System.Drawing.Point(745, 7);
            this._ComprasBtnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnImprimir.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnImprimir.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnImprimir.Name = "_ComprasBtnImprimir";
            this._ComprasBtnImprimir.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnImprimir.TabIndex = 2;
            this._ComprasBtnImprimir.Text = "Imprimir";
            this._ComprasBtnImprimir.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnAyuda
            // 
            this._ComprasBtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnAyuda.BackgroundImage")));
            this._ComprasBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAyuda.FlatAppearance.BorderSize = 0;
            this._ComprasBtnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAyuda.Location = new System.Drawing.Point(1059, 7);
            this._ComprasBtnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnAyuda.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnAyuda.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnAyuda.Name = "_ComprasBtnAyuda";
            this._ComprasBtnAyuda.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnAyuda.TabIndex = 3;
            this._ComprasBtnAyuda.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnSalir
            // 
            this._ComprasBtnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnSalir.BackgroundImage")));
            this._ComprasBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSalir.FlatAppearance.BorderSize = 0;
            this._ComprasBtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSalir.Location = new System.Drawing.Point(1374, 7);
            this._ComprasBtnSalir.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnSalir.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnSalir.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnSalir.Name = "_ComprasBtnSalir";
            this._ComprasBtnSalir.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnSalir.TabIndex = 4;
            this._ComprasBtnSalir.UseVisualStyleBackColor = false;
            // 
            // UsrCierreMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this._ComprasTlpPrincipal);
            this.Name = "UsrCierreMovimientos";
            this._ComprasTlpPrincipal.ResumeLayout(false);
            this._ComprasGbxPeriodo.ResumeLayout(false);
            this._ComprasTlpContenido.ResumeLayout(false);
            this._ComprasGbxValidaciones.ResumeLayout(false);
            this._ComprasGbxSaldos.ResumeLayout(false);
            this._ComprasTlpTotales.ResumeLayout(false);
            this._ComprasTlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.ClsTableLayoutPanelCompras _ComprasTlpPrincipal;
        private Componentes.UsrLabelCompras ComprasUsrTitulo;
        private Componentes.ClsGroupBoxCompras _ComprasGbxPeriodo;
        private Componentes.UsrComboBoxCompras ComprasUsrPeriodo;
        private Componentes.UsrLabelCompras ComprasUsrEtiquetaPeriodo;
        private Componentes.ClsTableLayoutPanelCompras _ComprasTlpContenido;
        private Componentes.ClsGroupBoxCompras _ComprasGbxValidaciones;
        private Componentes.UsrDataGridViewCompras ComprasUsrValidaciones;
        private Componentes.ClsGroupBoxCompras _ComprasGbxSaldos;
        private Componentes.UsrDataGridViewCompras ComprasUsrSaldos;
        private Componentes.ClsTableLayoutPanelCompras _ComprasTlpTotales;
        private Componentes.UsrLabelCompras ComprasUsrEtiquetaTotalCargos;
        private Componentes.UsrTextBoxCompras ComprasUsrTotalCargos;
        private Componentes.UsrLabelCompras ComprasUsrEtiquetaTotalAbonos;
        private Componentes.UsrTextBoxCompras ComprasUsrTotalAbonos;
        private Componentes.UsrLabelCompras ComprasUsrEtiquetaSaldoFinal;
        private Componentes.UsrTextBoxCompras ComprasUsrSaldoFinal;
        private Componentes.ClsTableLayoutPanelCompras _ComprasTlpBotones;
        private Componentes.ClsButtonCompras _ComprasBtnValidar;
        private Componentes.ClsButtonCompras _ComprasBtnEjecutarCierre;
        private Componentes.ClsButtonCompras _ComprasBtnImprimir;
        private Componentes.ClsButtonCompras _ComprasBtnAyuda;
        private Componentes.ClsButtonCompras _ComprasBtnSalir;
    }
}
