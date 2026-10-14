using System;
using System.Drawing;
using System.Windows.Forms;
using CapaVista_Compras.Componentes;

namespace CapaVista_Compras
{
    partial class UsrPagosProveedores
    {
        private System.ComponentModel.IContainer _Componentes = null;

        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null)) _Componentes.Dispose();
            base.Dispose(LiberarRecursos);
        }

        private void InitializeComponent()
        {
            this._ComprasPnlEncabezado = new System.Windows.Forms.Panel();
            this.ComprasUsrLblTitulo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblSubtitulo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasBtnNuevoPago = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasTlpFiltros = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrLblProveedor = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblEstado = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblDesde = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblHasta = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrCboProveedor = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.ComprasUsrCboEstado = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.ComprasUsrTxtDesde = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrTxtHasta = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrPagos = new CapaVista_Compras.Componentes.UsrDataGridViewCompras();
            this._ComprasGbxRegistrarPago = new CapaVista_Compras.Componentes.ClsGroupBoxCompras();
            this._ComprasTlpRegistro = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrLblProveedorPago = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblFactura = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblFechaPago = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrCboProveedorPago = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.ComprasUsrCboFactura = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.ComprasUsrTxtFechaPago = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrLblMonto = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblMetodo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrLblReferencia = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrTxtMonto = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrCboMetodo = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.ComprasUsrTxtReferencia = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this._ComprasPnlBotones = new System.Windows.Forms.Panel();
            this._ComprasBtnCancelar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnGuardar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasPnlEncabezado.SuspendLayout();
            this._ComprasTlpFiltros.SuspendLayout();
            this._ComprasGbxRegistrarPago.SuspendLayout();
            this._ComprasTlpRegistro.SuspendLayout();
            this._ComprasPnlBotones.SuspendLayout();
            this.SuspendLayout();
            //
            // PnlEncabezado
            //
            this._ComprasPnlEncabezado.BackColor = System.Drawing.Color.Transparent;
            this._ComprasPnlEncabezado.Controls.Add(this.ComprasUsrLblTitulo);
            this._ComprasPnlEncabezado.Controls.Add(this.ComprasUsrLblSubtitulo);
            this._ComprasPnlEncabezado.Controls.Add(this._ComprasBtnNuevoPago);
            this._ComprasPnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasPnlEncabezado.Location = new System.Drawing.Point(16, 16);
            this._ComprasPnlEncabezado.Name = "ComprasPnlEncabezado";
            this._ComprasPnlEncabezado.Size = new System.Drawing.Size(1118, 72);
            this._ComprasPnlEncabezado.TabIndex = 3;
            //
            // LblTitulo
            //
            this.ComprasUsrLblTitulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ComprasUsrLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblTitulo.Location = new System.Drawing.Point(0, 4);
            this.ComprasUsrLblTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComprasUsrLblTitulo.MaximumSize = new System.Drawing.Size(1500, 34);
            this.ComprasUsrLblTitulo.MostrarAsterisco = false;
            this.ComprasUsrLblTitulo.Name = "ComprasUsrLblTitulo";
            this.ComprasUsrLblTitulo.Size = new System.Drawing.Size(420, 30);
            this.ComprasUsrLblTitulo.TabIndex = 0;
            this.ComprasUsrLblTitulo.TabStop = false;
            this.ComprasUsrLblTitulo.Text = "Pagos a proveedores";
            this.ComprasUsrLblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblTitulo.Texto = "Pagos a proveedores";
            //
            // LblSubtitulo
            //
            this.ComprasUsrLblSubtitulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblSubtitulo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblSubtitulo.Location = new System.Drawing.Point(0, 36);
            this.ComprasUsrLblSubtitulo.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblSubtitulo.MostrarAsterisco = false;
            this.ComprasUsrLblSubtitulo.Name = "ComprasUsrLblSubtitulo";
            this.ComprasUsrLblSubtitulo.Size = new System.Drawing.Size(420, 22);
            this.ComprasUsrLblSubtitulo.TabIndex = 1;
            this.ComprasUsrLblSubtitulo.TabStop = false;
            this.ComprasUsrLblSubtitulo.Text = "ERP Compras–CxP · módulo 3.5";
            this.ComprasUsrLblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblSubtitulo.Texto = "ERP Compras–CxP · módulo 3.5";
            //
            // BtnNuevoPago
            //
            this._ComprasBtnNuevoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._ComprasBtnNuevoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnNuevoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnNuevoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnNuevoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnNuevoPago.Location = new System.Drawing.Point(968, 4);
            this._ComprasBtnNuevoPago.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnNuevoPago.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnNuevoPago.MinimumSize = new System.Drawing.Size(150, 40);
            this._ComprasBtnNuevoPago.Name = "ComprasBtnNuevoPago";
            this._ComprasBtnNuevoPago.Size = new System.Drawing.Size(150, 40);
            this._ComprasBtnNuevoPago.TabIndex = 2;
            this._ComprasBtnNuevoPago.Text = "+ Nuevo pago";
            this._ComprasBtnNuevoPago.UseVisualStyleBackColor = false;
            //
            // TlpFiltros
            //
            this._ComprasTlpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpFiltros.ColumnCount = 4;
            this._ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblProveedor, 0, 0);
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblEstado, 1, 0);
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblDesde, 2, 0);
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblHasta, 3, 0);
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrCboProveedor, 0, 1);
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrCboEstado, 1, 1);
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrTxtDesde, 2, 1);
            this._ComprasTlpFiltros.Controls.Add(this.ComprasUsrTxtHasta, 3, 1);
            this._ComprasTlpFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasTlpFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpFiltros.Location = new System.Drawing.Point(16, 88);
            this._ComprasTlpFiltros.Name = "ComprasTlpFiltros";
            this._ComprasTlpFiltros.RowCount = 2;
            this._ComprasTlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this._ComprasTlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this._ComprasTlpFiltros.Size = new System.Drawing.Size(1118, 98);
            this._ComprasTlpFiltros.TabIndex = 2;
            //
            // LblProveedor
            //
            this.ComprasUsrLblProveedor.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblProveedor.Location = new System.Drawing.Point(3, 3);
            this.ComprasUsrLblProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblProveedor.MostrarAsterisco = false;
            this.ComprasUsrLblProveedor.Name = "ComprasUsrLblProveedor";
            this.ComprasUsrLblProveedor.Size = new System.Drawing.Size(273, 20);
            this.ComprasUsrLblProveedor.TabIndex = 0;
            this.ComprasUsrLblProveedor.TabStop = false;
            this.ComprasUsrLblProveedor.Text = "Proveedor";
            this.ComprasUsrLblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedor.Texto = "Proveedor";
            //
            // LblEstado
            //
            this.ComprasUsrLblEstado.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblEstado.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblEstado.Location = new System.Drawing.Point(282, 3);
            this.ComprasUsrLblEstado.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblEstado.MostrarAsterisco = false;
            this.ComprasUsrLblEstado.Name = "ComprasUsrLblEstado";
            this.ComprasUsrLblEstado.Size = new System.Drawing.Size(273, 20);
            this.ComprasUsrLblEstado.TabIndex = 1;
            this.ComprasUsrLblEstado.TabStop = false;
            this.ComprasUsrLblEstado.Text = "Estado";
            this.ComprasUsrLblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblEstado.Texto = "Estado";
            //
            // LblDesde
            //
            this.ComprasUsrLblDesde.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblDesde.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblDesde.Location = new System.Drawing.Point(561, 3);
            this.ComprasUsrLblDesde.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblDesde.MostrarAsterisco = false;
            this.ComprasUsrLblDesde.Name = "ComprasUsrLblDesde";
            this.ComprasUsrLblDesde.Size = new System.Drawing.Size(273, 20);
            this.ComprasUsrLblDesde.TabIndex = 2;
            this.ComprasUsrLblDesde.TabStop = false;
            this.ComprasUsrLblDesde.Text = "Desde";
            this.ComprasUsrLblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblDesde.Texto = "Desde";
            //
            // LblHasta
            //
            this.ComprasUsrLblHasta.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblHasta.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblHasta.Location = new System.Drawing.Point(840, 3);
            this.ComprasUsrLblHasta.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblHasta.MostrarAsterisco = false;
            this.ComprasUsrLblHasta.Name = "ComprasUsrLblHasta";
            this.ComprasUsrLblHasta.Size = new System.Drawing.Size(275, 20);
            this.ComprasUsrLblHasta.TabIndex = 3;
            this.ComprasUsrLblHasta.TabStop = false;
            this.ComprasUsrLblHasta.Text = "Hasta";
            this.ComprasUsrLblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblHasta.Texto = "Hasta";
            //
            // CboProveedor
            //
            this.ComprasUsrCboProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboProveedor.Location = new System.Drawing.Point(3, 29);
            this.ComprasUsrCboProveedor.MaxLength = 0;
            this.ComprasUsrCboProveedor.Name = "ComprasUsrCboProveedor";
            this.ComprasUsrCboProveedor.Size = new System.Drawing.Size(273, 66);
            this.ComprasUsrCboProveedor.TabIndex = 4;
            //
            // CboEstado
            //
            this.ComprasUsrCboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboEstado.Location = new System.Drawing.Point(282, 29);
            this.ComprasUsrCboEstado.MaxLength = 0;
            this.ComprasUsrCboEstado.Name = "ComprasUsrCboEstado";
            this.ComprasUsrCboEstado.Size = new System.Drawing.Size(273, 66);
            this.ComprasUsrCboEstado.TabIndex = 5;
            //
            // TxtDesde
            //
            this.ComprasUsrTxtDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtDesde.Location = new System.Drawing.Point(561, 29);
            this.ComprasUsrTxtDesde.MaxLength = 2147483647;
            this.ComprasUsrTxtDesde.Name = "ComprasUsrTxtDesde";
            this.ComprasUsrTxtDesde.SelectedText = "";
            this.ComprasUsrTxtDesde.SelectionLength = 0;
            this.ComprasUsrTxtDesde.SelectionStart = 0;
            this.ComprasUsrTxtDesde.Size = new System.Drawing.Size(273, 66);
            this.ComprasUsrTxtDesde.TabIndex = 6;
            //
            // TxtHasta
            //
            this.ComprasUsrTxtHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtHasta.Location = new System.Drawing.Point(840, 29);
            this.ComprasUsrTxtHasta.MaxLength = 2147483647;
            this.ComprasUsrTxtHasta.Name = "ComprasUsrTxtHasta";
            this.ComprasUsrTxtHasta.SelectedText = "";
            this.ComprasUsrTxtHasta.SelectionLength = 0;
            this.ComprasUsrTxtHasta.SelectionStart = 0;
            this.ComprasUsrTxtHasta.Size = new System.Drawing.Size(275, 66);
            this.ComprasUsrTxtHasta.TabIndex = 7;
            //
            // DgvPagos
            //
            this.ComprasUsrPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrPagos.Location = new System.Drawing.Point(16, 186);
            this.ComprasUsrPagos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrPagos.Name = "ComprasUsrPagos";
            this.ComprasUsrPagos.Size = new System.Drawing.Size(1118, 228);
            this.ComprasUsrPagos.TabIndex = 0;
            this.ComprasUsrPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComprasMetDgvPagosCellClick);
            //
            // GbRegistrarPago
            //
            this._ComprasGbxRegistrarPago.BackColor = System.Drawing.Color.Transparent;
            this._ComprasGbxRegistrarPago.Controls.Add(this._ComprasTlpRegistro);
            this._ComprasGbxRegistrarPago.Controls.Add(this._ComprasPnlBotones);
            this._ComprasGbxRegistrarPago.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ComprasGbxRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasGbxRegistrarPago.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this._ComprasGbxRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasGbxRegistrarPago.Location = new System.Drawing.Point(16, 414);
            this._ComprasGbxRegistrarPago.Name = "ComprasGbxRegistrarPago";
            this._ComprasGbxRegistrarPago.Size = new System.Drawing.Size(1118, 320);
            this._ComprasGbxRegistrarPago.TabIndex = 1;
            this._ComprasGbxRegistrarPago.TabStop = false;
            this._ComprasGbxRegistrarPago.Text = "Registrar pago";
            //
            // TlpRegistro
            //
            this._ComprasTlpRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpRegistro.ColumnCount = 3;
            this._ComprasTlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this._ComprasTlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this._ComprasTlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblProveedorPago, 0, 0);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblFactura, 1, 0);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblFechaPago, 2, 0);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrCboProveedorPago, 0, 1);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrCboFactura, 1, 1);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrTxtFechaPago, 2, 1);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblMonto, 0, 2);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblMetodo, 1, 2);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblReferencia, 2, 2);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrTxtMonto, 0, 3);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrCboMetodo, 1, 3);
            this._ComprasTlpRegistro.Controls.Add(this.ComprasUsrTxtReferencia, 2, 3);
            this._ComprasTlpRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpRegistro.Location = new System.Drawing.Point(3, 24);
            this._ComprasTlpRegistro.Name = "ComprasTlpRegistro";
            this._ComprasTlpRegistro.RowCount = 4;
            this._ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this._ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this._ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this._ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this._ComprasTlpRegistro.Size = new System.Drawing.Size(1112, 200);
            this._ComprasTlpRegistro.TabIndex = 0;
            //
            // LblProveedorPago
            //
            this.ComprasUsrLblProveedorPago.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblProveedorPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblProveedorPago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblProveedorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblProveedorPago.Location = new System.Drawing.Point(3, 3);
            this.ComprasUsrLblProveedorPago.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblProveedorPago.MostrarAsterisco = false;
            this.ComprasUsrLblProveedorPago.Name = "ComprasUsrLblProveedorPago";
            this.ComprasUsrLblProveedorPago.Size = new System.Drawing.Size(364, 20);
            this.ComprasUsrLblProveedorPago.TabIndex = 0;
            this.ComprasUsrLblProveedorPago.TabStop = false;
            this.ComprasUsrLblProveedorPago.Text = "Proveedor";
            this.ComprasUsrLblProveedorPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedorPago.Texto = "Proveedor";
            //
            // LblFactura
            //
            this.ComprasUsrLblFactura.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblFactura.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblFactura.Location = new System.Drawing.Point(373, 3);
            this.ComprasUsrLblFactura.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblFactura.MostrarAsterisco = false;
            this.ComprasUsrLblFactura.Name = "ComprasUsrLblFactura";
            this.ComprasUsrLblFactura.Size = new System.Drawing.Size(364, 20);
            this.ComprasUsrLblFactura.TabIndex = 1;
            this.ComprasUsrLblFactura.TabStop = false;
            this.ComprasUsrLblFactura.Text = "Factura por pagar";
            this.ComprasUsrLblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFactura.Texto = "Factura por pagar";
            //
            // LblFechaPago
            //
            this.ComprasUsrLblFechaPago.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblFechaPago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblFechaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblFechaPago.Location = new System.Drawing.Point(743, 3);
            this.ComprasUsrLblFechaPago.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblFechaPago.MostrarAsterisco = false;
            this.ComprasUsrLblFechaPago.Name = "ComprasUsrLblFechaPago";
            this.ComprasUsrLblFechaPago.Size = new System.Drawing.Size(366, 20);
            this.ComprasUsrLblFechaPago.TabIndex = 2;
            this.ComprasUsrLblFechaPago.TabStop = false;
            this.ComprasUsrLblFechaPago.Text = "Fecha de pago";
            this.ComprasUsrLblFechaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFechaPago.Texto = "Fecha de pago";
            //
            // CboProveedorPago
            //
            this.ComprasUsrCboProveedorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboProveedorPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboProveedorPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboProveedorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboProveedorPago.Location = new System.Drawing.Point(3, 29);
            this.ComprasUsrCboProveedorPago.MaxLength = 0;
            this.ComprasUsrCboProveedorPago.Name = "ComprasUsrCboProveedorPago";
            this.ComprasUsrCboProveedorPago.Size = new System.Drawing.Size(364, 69);
            this.ComprasUsrCboProveedorPago.TabIndex = 3;
            //
            // CboFactura
            //
            this.ComprasUsrCboFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboFactura.Location = new System.Drawing.Point(373, 29);
            this.ComprasUsrCboFactura.MaxLength = 0;
            this.ComprasUsrCboFactura.Name = "ComprasUsrCboFactura";
            this.ComprasUsrCboFactura.Size = new System.Drawing.Size(364, 69);
            this.ComprasUsrCboFactura.TabIndex = 4;
            //
            // TxtFechaPago
            //
            this.ComprasUsrTxtFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtFechaPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtFechaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtFechaPago.Location = new System.Drawing.Point(743, 29);
            this.ComprasUsrTxtFechaPago.MaxLength = 2147483647;
            this.ComprasUsrTxtFechaPago.Name = "ComprasUsrTxtFechaPago";
            this.ComprasUsrTxtFechaPago.SelectedText = "";
            this.ComprasUsrTxtFechaPago.SelectionLength = 0;
            this.ComprasUsrTxtFechaPago.SelectionStart = 0;
            this.ComprasUsrTxtFechaPago.Size = new System.Drawing.Size(366, 69);
            this.ComprasUsrTxtFechaPago.TabIndex = 5;
            //
            // LblMonto
            //
            this.ComprasUsrLblMonto.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblMonto.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblMonto.Location = new System.Drawing.Point(3, 104);
            this.ComprasUsrLblMonto.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblMonto.MostrarAsterisco = false;
            this.ComprasUsrLblMonto.Name = "ComprasUsrLblMonto";
            this.ComprasUsrLblMonto.Size = new System.Drawing.Size(364, 17);
            this.ComprasUsrLblMonto.TabIndex = 6;
            this.ComprasUsrLblMonto.TabStop = false;
            this.ComprasUsrLblMonto.Text = "Monto";
            this.ComprasUsrLblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMonto.Texto = "Monto";
            //
            // LblMetodo
            //
            this.ComprasUsrLblMetodo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblMetodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblMetodo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblMetodo.Location = new System.Drawing.Point(373, 104);
            this.ComprasUsrLblMetodo.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblMetodo.MostrarAsterisco = false;
            this.ComprasUsrLblMetodo.Name = "ComprasUsrLblMetodo";
            this.ComprasUsrLblMetodo.Size = new System.Drawing.Size(364, 17);
            this.ComprasUsrLblMetodo.TabIndex = 7;
            this.ComprasUsrLblMetodo.TabStop = false;
            this.ComprasUsrLblMetodo.Text = "Método";
            this.ComprasUsrLblMetodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMetodo.Texto = "Método";
            //
            // LblReferencia
            //
            this.ComprasUsrLblReferencia.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblReferencia.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblReferencia.Location = new System.Drawing.Point(743, 104);
            this.ComprasUsrLblReferencia.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblReferencia.MostrarAsterisco = false;
            this.ComprasUsrLblReferencia.Name = "ComprasUsrLblReferencia";
            this.ComprasUsrLblReferencia.Size = new System.Drawing.Size(366, 17);
            this.ComprasUsrLblReferencia.TabIndex = 8;
            this.ComprasUsrLblReferencia.TabStop = false;
            this.ComprasUsrLblReferencia.Text = "Referencia";
            this.ComprasUsrLblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblReferencia.Texto = "Referencia";
            //
            // TxtMonto
            //
            this.ComprasUsrTxtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtMonto.Location = new System.Drawing.Point(3, 127);
            this.ComprasUsrTxtMonto.MaxLength = 2147483647;
            this.ComprasUsrTxtMonto.Name = "ComprasUsrTxtMonto";
            this.ComprasUsrTxtMonto.SelectedText = "";
            this.ComprasUsrTxtMonto.SelectionLength = 0;
            this.ComprasUsrTxtMonto.SelectionStart = 0;
            this.ComprasUsrTxtMonto.Size = new System.Drawing.Size(364, 70);
            this.ComprasUsrTxtMonto.TabIndex = 9;
            //
            // CboMetodo
            //
            this.ComprasUsrCboMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboMetodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboMetodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboMetodo.Location = new System.Drawing.Point(373, 127);
            this.ComprasUsrCboMetodo.MaxLength = 0;
            this.ComprasUsrCboMetodo.Name = "ComprasUsrCboMetodo";
            this.ComprasUsrCboMetodo.Size = new System.Drawing.Size(364, 70);
            this.ComprasUsrCboMetodo.TabIndex = 10;
            //
            // TxtReferencia
            //
            this.ComprasUsrTxtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtReferencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtReferencia.Location = new System.Drawing.Point(743, 127);
            this.ComprasUsrTxtReferencia.MaxLength = 2147483647;
            this.ComprasUsrTxtReferencia.Name = "ComprasUsrTxtReferencia";
            this.ComprasUsrTxtReferencia.SelectedText = "";
            this.ComprasUsrTxtReferencia.SelectionLength = 0;
            this.ComprasUsrTxtReferencia.SelectionStart = 0;
            this.ComprasUsrTxtReferencia.Size = new System.Drawing.Size(366, 70);
            this.ComprasUsrTxtReferencia.TabIndex = 11;
            //
            // PnlBotones
            //
            this._ComprasPnlBotones.BackColor = System.Drawing.Color.Transparent;
            this._ComprasPnlBotones.Controls.Add(this._ComprasBtnCancelar);
            this._ComprasPnlBotones.Controls.Add(this._ComprasBtnGuardar);
            this._ComprasPnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ComprasPnlBotones.Location = new System.Drawing.Point(3, 224);
            this._ComprasPnlBotones.Name = "ComprasPnlBotones";
            this._ComprasPnlBotones.Size = new System.Drawing.Size(1112, 93);
            this._ComprasPnlBotones.TabIndex = 1;
            //
            // BtnCancelar
            //
            this._ComprasBtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._ComprasBtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnCancelar.Location = new System.Drawing.Point(832, 8);
            this._ComprasBtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnCancelar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnCancelar.MinimumSize = new System.Drawing.Size(110, 40);
            this._ComprasBtnCancelar.Name = "ComprasBtnCancelar";
            this._ComprasBtnCancelar.Size = new System.Drawing.Size(110, 65);
            this._ComprasBtnCancelar.TabIndex = 0;
            this._ComprasBtnCancelar.Text = "Cancelar";
            this._ComprasBtnCancelar.UseVisualStyleBackColor = false;
            //
            // BtnGuardar
            //
            this._ComprasBtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._ComprasBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnGuardar.Location = new System.Drawing.Point(952, 8);
            this._ComprasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnGuardar.MinimumSize = new System.Drawing.Size(150, 40);
            this._ComprasBtnGuardar.Name = "ComprasBtnGuardar";
            this._ComprasBtnGuardar.Size = new System.Drawing.Size(150, 65);
            this._ComprasBtnGuardar.TabIndex = 1;
            this._ComprasBtnGuardar.Text = "Guardar pago";
            this._ComprasBtnGuardar.UseVisualStyleBackColor = false;
            //
            // UsrPagosProveedores
            //
            this.Controls.Add(this.ComprasUsrPagos);
            this.Controls.Add(this._ComprasGbxRegistrarPago);
            this.Controls.Add(this._ComprasTlpFiltros);
            this.Controls.Add(this._ComprasPnlEncabezado);
            this.Name = "UsrPagosProveedores";
            this.Padding = new System.Windows.Forms.Padding(16);
            this._ComprasPnlEncabezado.ResumeLayout(false);
            this._ComprasTlpFiltros.ResumeLayout(false);
            this._ComprasGbxRegistrarPago.ResumeLayout(false);
            this._ComprasTlpRegistro.ResumeLayout(false);
            this._ComprasPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel _ComprasPnlEncabezado;
        private UsrLabelCompras ComprasUsrLblTitulo, ComprasUsrLblSubtitulo;
        private ClsButtonCompras _ComprasBtnNuevoPago;

        private ClsTableLayoutPanelCompras _ComprasTlpFiltros;
        private UsrLabelCompras ComprasUsrLblProveedor, ComprasUsrLblEstado, ComprasUsrLblDesde, ComprasUsrLblHasta;
        private UsrComboBoxCompras ComprasUsrCboProveedor, ComprasUsrCboEstado;
        private UsrTextBoxCompras ComprasUsrTxtDesde, ComprasUsrTxtHasta;

        private UsrDataGridViewCompras ComprasUsrPagos;

        private ClsGroupBoxCompras _ComprasGbxRegistrarPago;
        private ClsTableLayoutPanelCompras _ComprasTlpRegistro;
        private UsrLabelCompras ComprasUsrLblProveedorPago, ComprasUsrLblFactura, ComprasUsrLblFechaPago, ComprasUsrLblMonto, ComprasUsrLblMetodo, ComprasUsrLblReferencia;
        private UsrComboBoxCompras ComprasUsrCboProveedorPago, ComprasUsrCboFactura, ComprasUsrCboMetodo;
        private UsrTextBoxCompras ComprasUsrTxtFechaPago, ComprasUsrTxtMonto, ComprasUsrTxtReferencia;
        private Panel _ComprasPnlBotones;
        private ClsButtonCompras _ComprasBtnCancelar, _ComprasBtnGuardar;
    }
}