using System;
using System.Drawing;
using System.Windows.Forms;
using CapaVista_Compras.Componentes;

namespace CapaVista_Compras
{
    partial class UsrPagosProveedores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.PnlEncabezado = new System.Windows.Forms.Panel();
            this.LblTitulo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblSubtitulo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.BtnNuevoPago = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this.TlpFiltros = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this.LblProveedor = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblEstado = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblDesde = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblHasta = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.CboProveedor = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.CboEstado = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.TxtDesde = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.TxtHasta = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.DgvPagos = new CapaVista_Compras.Componentes.UsrDataGridViewCompras();
            this.GbRegistrarPago = new CapaVista_Compras.Componentes.ClsGroupBoxCompras();
            this.TlpRegistro = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this.LblProveedorPago = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblFactura = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblFechaPago = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.CboProveedorPago = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.CboFactura = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.TxtFechaPago = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.LblMonto = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblMetodo = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.LblReferencia = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.TxtMonto = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.CboMetodo = new CapaVista_Compras.Componentes.UsrComboBoxCompras();
            this.TxtReferencia = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnCancelar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this.BtnGuardar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this.PnlEncabezado.SuspendLayout();
            this.TlpFiltros.SuspendLayout();
            this.GbRegistrarPago.SuspendLayout();
            this.TlpRegistro.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.PnlEncabezado.Controls.Add(this.LblTitulo);
            this.PnlEncabezado.Controls.Add(this.LblSubtitulo);
            this.PnlEncabezado.Controls.Add(this.BtnNuevoPago);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(16, 16);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(1118, 72);
            this.PnlEncabezado.TabIndex = 3;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblTitulo.Location = new System.Drawing.Point(0, 4);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LblTitulo.MaximumSize = new System.Drawing.Size(1500, 34);
            this.LblTitulo.MostrarAsterisco = false;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(420, 30);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.TabStop = false;
            this.LblTitulo.Text = "Pagos a proveedores";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTitulo.Texto = "Pagos a proveedores";
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblSubtitulo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblSubtitulo.Location = new System.Drawing.Point(0, 36);
            this.LblSubtitulo.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblSubtitulo.MostrarAsterisco = false;
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(420, 22);
            this.LblSubtitulo.TabIndex = 1;
            this.LblSubtitulo.TabStop = false;
            this.LblSubtitulo.Text = "ERP Compras–CxP · módulo 3.5";
            this.LblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblSubtitulo.Texto = "ERP Compras–CxP · módulo 3.5";
            // 
            // BtnNuevoPago
            // 
            this.BtnNuevoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.BtnNuevoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.BtnNuevoPago.Location = new System.Drawing.Point(968, 4);
            this.BtnNuevoPago.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevoPago.MaximumSize = new System.Drawing.Size(80, 80);
            this.BtnNuevoPago.MinimumSize = new System.Drawing.Size(150, 40);
            this.BtnNuevoPago.Name = "BtnNuevoPago";
            this.BtnNuevoPago.Size = new System.Drawing.Size(150, 40);
            this.BtnNuevoPago.TabIndex = 2;
            this.BtnNuevoPago.Text = "+ Nuevo pago";
            this.BtnNuevoPago.UseVisualStyleBackColor = false;
            // 
            // TlpFiltros
            // 
            this.TlpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TlpFiltros.ColumnCount = 4;
            this.TlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpFiltros.Controls.Add(this.LblProveedor, 0, 0);
            this.TlpFiltros.Controls.Add(this.LblEstado, 1, 0);
            this.TlpFiltros.Controls.Add(this.LblDesde, 2, 0);
            this.TlpFiltros.Controls.Add(this.LblHasta, 3, 0);
            this.TlpFiltros.Controls.Add(this.CboProveedor, 0, 1);
            this.TlpFiltros.Controls.Add(this.CboEstado, 1, 1);
            this.TlpFiltros.Controls.Add(this.TxtDesde, 2, 1);
            this.TlpFiltros.Controls.Add(this.TxtHasta, 3, 1);
            this.TlpFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.TlpFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.TlpFiltros.Location = new System.Drawing.Point(16, 88);
            this.TlpFiltros.Name = "TlpFiltros";
            this.TlpFiltros.RowCount = 2;
            this.TlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.TlpFiltros.Size = new System.Drawing.Size(1118, 98);
            this.TlpFiltros.TabIndex = 2;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblProveedor.Location = new System.Drawing.Point(3, 3);
            this.LblProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblProveedor.MostrarAsterisco = false;
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(273, 20);
            this.LblProveedor.TabIndex = 0;
            this.LblProveedor.TabStop = false;
            this.LblProveedor.Text = "Proveedor";
            this.LblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblProveedor.Texto = "Proveedor";
            // 
            // LblEstado
            // 
            this.LblEstado.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEstado.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblEstado.Location = new System.Drawing.Point(282, 3);
            this.LblEstado.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblEstado.MostrarAsterisco = false;
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(273, 20);
            this.LblEstado.TabIndex = 1;
            this.LblEstado.TabStop = false;
            this.LblEstado.Text = "Estado";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblEstado.Texto = "Estado";
            // 
            // LblDesde
            // 
            this.LblDesde.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDesde.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblDesde.Location = new System.Drawing.Point(561, 3);
            this.LblDesde.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblDesde.MostrarAsterisco = false;
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(273, 20);
            this.LblDesde.TabIndex = 2;
            this.LblDesde.TabStop = false;
            this.LblDesde.Text = "Desde";
            this.LblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblDesde.Texto = "Desde";
            // 
            // LblHasta
            // 
            this.LblHasta.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblHasta.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblHasta.Location = new System.Drawing.Point(840, 3);
            this.LblHasta.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblHasta.MostrarAsterisco = false;
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(275, 20);
            this.LblHasta.TabIndex = 3;
            this.LblHasta.TabStop = false;
            this.LblHasta.Text = "Hasta";
            this.LblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblHasta.Texto = "Hasta";
            // 
            // CboProveedor
            // 
            this.CboProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.CboProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CboProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.CboProveedor.Location = new System.Drawing.Point(3, 29);
            this.CboProveedor.MaxLength = 0;
            this.CboProveedor.Name = "CboProveedor";
            this.CboProveedor.Size = new System.Drawing.Size(273, 66);
            this.CboProveedor.TabIndex = 4;
            // 
            // CboEstado
            // 
            this.CboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.CboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.CboEstado.Location = new System.Drawing.Point(282, 29);
            this.CboEstado.MaxLength = 0;
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(273, 66);
            this.CboEstado.TabIndex = 5;
            // 
            // TxtDesde
            // 
            this.TxtDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TxtDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.TxtDesde.Location = new System.Drawing.Point(561, 29);
            this.TxtDesde.MaxLength = 2147483647;
            this.TxtDesde.Name = "TxtDesde";
            this.TxtDesde.SelectedText = "";
            this.TxtDesde.SelectionLength = 0;
            this.TxtDesde.SelectionStart = 0;
            this.TxtDesde.Size = new System.Drawing.Size(273, 66);
            this.TxtDesde.TabIndex = 6;
            // 
            // TxtHasta
            // 
            this.TxtHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TxtHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.TxtHasta.Location = new System.Drawing.Point(840, 29);
            this.TxtHasta.MaxLength = 2147483647;
            this.TxtHasta.Name = "TxtHasta";
            this.TxtHasta.SelectedText = "";
            this.TxtHasta.SelectionLength = 0;
            this.TxtHasta.SelectionStart = 0;
            this.TxtHasta.Size = new System.Drawing.Size(275, 66);
            this.TxtHasta.TabIndex = 7;
            // 
            // DgvPagos
            // 
            this.DgvPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.DgvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.DgvPagos.Location = new System.Drawing.Point(16, 186);
            this.DgvPagos.Margin = new System.Windows.Forms.Padding(0);
            this.DgvPagos.Name = "DgvPagos";
            this.DgvPagos.Size = new System.Drawing.Size(1118, 228);
            this.DgvPagos.TabIndex = 0;
            this.DgvPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPagos_CellClick);
            // 
            // GbRegistrarPago
            // 
            this.GbRegistrarPago.BackColor = System.Drawing.Color.Transparent;
            this.GbRegistrarPago.Controls.Add(this.TlpRegistro);
            this.GbRegistrarPago.Controls.Add(this.PnlBotones);
            this.GbRegistrarPago.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbRegistrarPago.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.GbRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.GbRegistrarPago.Location = new System.Drawing.Point(16, 414);
            this.GbRegistrarPago.Name = "GbRegistrarPago";
            this.GbRegistrarPago.Size = new System.Drawing.Size(1118, 320);
            this.GbRegistrarPago.TabIndex = 1;
            this.GbRegistrarPago.TabStop = false;
            this.GbRegistrarPago.Text = "Registrar pago";
            // 
            // TlpRegistro
            // 
            this.TlpRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TlpRegistro.ColumnCount = 3;
            this.TlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.TlpRegistro.Controls.Add(this.LblProveedorPago, 0, 0);
            this.TlpRegistro.Controls.Add(this.LblFactura, 1, 0);
            this.TlpRegistro.Controls.Add(this.LblFechaPago, 2, 0);
            this.TlpRegistro.Controls.Add(this.CboProveedorPago, 0, 1);
            this.TlpRegistro.Controls.Add(this.CboFactura, 1, 1);
            this.TlpRegistro.Controls.Add(this.TxtFechaPago, 2, 1);
            this.TlpRegistro.Controls.Add(this.LblMonto, 0, 2);
            this.TlpRegistro.Controls.Add(this.LblMetodo, 1, 2);
            this.TlpRegistro.Controls.Add(this.LblReferencia, 2, 2);
            this.TlpRegistro.Controls.Add(this.TxtMonto, 0, 3);
            this.TlpRegistro.Controls.Add(this.CboMetodo, 1, 3);
            this.TlpRegistro.Controls.Add(this.TxtReferencia, 2, 3);
            this.TlpRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.TlpRegistro.Location = new System.Drawing.Point(3, 24);
            this.TlpRegistro.Name = "TlpRegistro";
            this.TlpRegistro.RowCount = 4;
            this.TlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.TlpRegistro.Size = new System.Drawing.Size(1112, 200);
            this.TlpRegistro.TabIndex = 0;
            // 
            // LblProveedorPago
            // 
            this.LblProveedorPago.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblProveedorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblProveedorPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblProveedorPago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblProveedorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblProveedorPago.Location = new System.Drawing.Point(3, 3);
            this.LblProveedorPago.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblProveedorPago.MostrarAsterisco = false;
            this.LblProveedorPago.Name = "LblProveedorPago";
            this.LblProveedorPago.Size = new System.Drawing.Size(364, 20);
            this.LblProveedorPago.TabIndex = 0;
            this.LblProveedorPago.TabStop = false;
            this.LblProveedorPago.Text = "Proveedor";
            this.LblProveedorPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblProveedorPago.Texto = "Proveedor";
            // 
            // LblFactura
            // 
            this.LblFactura.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFactura.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblFactura.Location = new System.Drawing.Point(373, 3);
            this.LblFactura.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblFactura.MostrarAsterisco = false;
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(364, 20);
            this.LblFactura.TabIndex = 1;
            this.LblFactura.TabStop = false;
            this.LblFactura.Text = "Factura por pagar";
            this.LblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFactura.Texto = "Factura por pagar";
            // 
            // LblFechaPago
            // 
            this.LblFechaPago.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFechaPago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblFechaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblFechaPago.Location = new System.Drawing.Point(743, 3);
            this.LblFechaPago.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblFechaPago.MostrarAsterisco = false;
            this.LblFechaPago.Name = "LblFechaPago";
            this.LblFechaPago.Size = new System.Drawing.Size(366, 20);
            this.LblFechaPago.TabIndex = 2;
            this.LblFechaPago.TabStop = false;
            this.LblFechaPago.Text = "Fecha de pago";
            this.LblFechaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblFechaPago.Texto = "Fecha de pago";
            // 
            // CboProveedorPago
            // 
            this.CboProveedorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.CboProveedorPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboProveedorPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CboProveedorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.CboProveedorPago.Location = new System.Drawing.Point(3, 29);
            this.CboProveedorPago.MaxLength = 0;
            this.CboProveedorPago.Name = "CboProveedorPago";
            this.CboProveedorPago.Size = new System.Drawing.Size(364, 69);
            this.CboProveedorPago.TabIndex = 3;
            // 
            // CboFactura
            // 
            this.CboFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.CboFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CboFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.CboFactura.Location = new System.Drawing.Point(373, 29);
            this.CboFactura.MaxLength = 0;
            this.CboFactura.Name = "CboFactura";
            this.CboFactura.Size = new System.Drawing.Size(364, 69);
            this.CboFactura.TabIndex = 4;
            // 
            // TxtFechaPago
            // 
            this.TxtFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TxtFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtFechaPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtFechaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.TxtFechaPago.Location = new System.Drawing.Point(743, 29);
            this.TxtFechaPago.MaxLength = 2147483647;
            this.TxtFechaPago.Name = "TxtFechaPago";
            this.TxtFechaPago.SelectedText = "";
            this.TxtFechaPago.SelectionLength = 0;
            this.TxtFechaPago.SelectionStart = 0;
            this.TxtFechaPago.Size = new System.Drawing.Size(366, 69);
            this.TxtFechaPago.TabIndex = 5;
            // 
            // LblMonto
            // 
            this.LblMonto.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMonto.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblMonto.Location = new System.Drawing.Point(3, 104);
            this.LblMonto.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblMonto.MostrarAsterisco = false;
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(364, 17);
            this.LblMonto.TabIndex = 6;
            this.LblMonto.TabStop = false;
            this.LblMonto.Text = "Monto";
            this.LblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblMonto.Texto = "Monto";
            // 
            // LblMetodo
            // 
            this.LblMetodo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblMetodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMetodo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblMetodo.Location = new System.Drawing.Point(373, 104);
            this.LblMetodo.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblMetodo.MostrarAsterisco = false;
            this.LblMetodo.Name = "LblMetodo";
            this.LblMetodo.Size = new System.Drawing.Size(364, 17);
            this.LblMetodo.TabIndex = 7;
            this.LblMetodo.TabStop = false;
            this.LblMetodo.Text = "Método";
            this.LblMetodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblMetodo.Texto = "Método";
            // 
            // LblReferencia
            // 
            this.LblReferencia.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.LblReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblReferencia.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.LblReferencia.Location = new System.Drawing.Point(743, 104);
            this.LblReferencia.MaximumSize = new System.Drawing.Size(1000, 22);
            this.LblReferencia.MostrarAsterisco = false;
            this.LblReferencia.Name = "LblReferencia";
            this.LblReferencia.Size = new System.Drawing.Size(366, 17);
            this.LblReferencia.TabIndex = 8;
            this.LblReferencia.TabStop = false;
            this.LblReferencia.Text = "Referencia";
            this.LblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblReferencia.Texto = "Referencia";
            // 
            // TxtMonto
            // 
            this.TxtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TxtMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.TxtMonto.Location = new System.Drawing.Point(3, 127);
            this.TxtMonto.MaxLength = 2147483647;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.SelectedText = "";
            this.TxtMonto.SelectionLength = 0;
            this.TxtMonto.SelectionStart = 0;
            this.TxtMonto.Size = new System.Drawing.Size(364, 70);
            this.TxtMonto.TabIndex = 9;
            // 
            // CboMetodo
            // 
            this.CboMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.CboMetodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboMetodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CboMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.CboMetodo.Location = new System.Drawing.Point(373, 127);
            this.CboMetodo.MaxLength = 0;
            this.CboMetodo.Name = "CboMetodo";
            this.CboMetodo.Size = new System.Drawing.Size(364, 70);
            this.CboMetodo.TabIndex = 10;
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TxtReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtReferencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.TxtReferencia.Location = new System.Drawing.Point(743, 127);
            this.TxtReferencia.MaxLength = 2147483647;
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.SelectedText = "";
            this.TxtReferencia.SelectionLength = 0;
            this.TxtReferencia.SelectionStart = 0;
            this.TxtReferencia.Size = new System.Drawing.Size(366, 70);
            this.TxtReferencia.TabIndex = 11;
            // 
            // PnlBotones
            // 
            this.PnlBotones.BackColor = System.Drawing.Color.Transparent;
            this.PnlBotones.Controls.Add(this.BtnCancelar);
            this.PnlBotones.Controls.Add(this.BtnGuardar);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotones.Location = new System.Drawing.Point(3, 224);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(1112, 93);
            this.PnlBotones.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.BtnCancelar.Location = new System.Drawing.Point(832, 8);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.MaximumSize = new System.Drawing.Size(80, 80);
            this.BtnCancelar.MinimumSize = new System.Drawing.Size(110, 40);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 65);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.BtnGuardar.Location = new System.Drawing.Point(952, 8);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this.BtnGuardar.MinimumSize = new System.Drawing.Size(150, 40);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(150, 65);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar pago";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // UsrPagosProveedores
            // 
            this.Controls.Add(this.DgvPagos);
            this.Controls.Add(this.GbRegistrarPago);
            this.Controls.Add(this.TlpFiltros);
            this.Controls.Add(this.PnlEncabezado);
            this.Name = "UsrPagosProveedores";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.PnlEncabezado.ResumeLayout(false);
            this.TlpFiltros.ResumeLayout(false);
            this.GbRegistrarPago.ResumeLayout(false);
            this.TlpRegistro.ResumeLayout(false);
            this.PnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel PnlEncabezado;
        private UsrLabelCompras LblTitulo, LblSubtitulo;
        private ClsButtonCompras BtnNuevoPago;

        private ClsTableLayoutPanelCompras TlpFiltros;
        private UsrLabelCompras LblProveedor, LblEstado, LblDesde, LblHasta;
        private UsrComboBoxCompras CboProveedor, CboEstado;
        private UsrTextBoxCompras TxtDesde, TxtHasta;

        private UsrDataGridViewCompras DgvPagos;

        private ClsGroupBoxCompras GbRegistrarPago;
        private ClsTableLayoutPanelCompras TlpRegistro;
        private UsrLabelCompras LblProveedorPago, LblFactura, LblFechaPago, LblMonto, LblMetodo, LblReferencia;
        private UsrComboBoxCompras CboProveedorPago, CboFactura, CboMetodo;
        private UsrTextBoxCompras TxtFechaPago, TxtMonto, TxtReferencia;
        private Panel PnlBotones;
        private ClsButtonCompras BtnCancelar, BtnGuardar;
    }
}