/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 12/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Conservar los controles del prototipo visual de Facturas.
 */
namespace CapaVista_Ventas
{
    partial class FrmFacturas
    {
        private System.ComponentModel.IContainer components = null;

        // Libera los componentes que el equipo incorpore desde el diseñador.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.VentasLblTitulo = new System.Windows.Forms.Label();
            this.VentasLblEstablecimiento = new System.Windows.Forms.Label();
            this.VentasTxtEstablecimiento = new System.Windows.Forms.TextBox();
            this.VentasLblFechaEmision = new System.Windows.Forms.Label();
            this.VentasDtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.VentasLblTipoDte = new System.Windows.Forms.Label();
            this.VentasCboTipoDte = new System.Windows.Forms.ComboBox();
            this.VentasLblMoneda = new System.Windows.Forms.Label();
            this.VentasCboMoneda = new System.Windows.Forms.ComboBox();
            this.VentasRdbNit = new System.Windows.Forms.RadioButton();
            this.VentasGrpIdentificacion = new System.Windows.Forms.GroupBox();
            this.VentasRdbIdExtranjero = new System.Windows.Forms.RadioButton();
            this.VentasRdbCui = new System.Windows.Forms.RadioButton();
            this.VentasLblNitReceptor = new System.Windows.Forms.Label();
            this.VentasLblDireccionComprador = new System.Windows.Forms.Label();
            this.VentasTxtNitReceptor = new System.Windows.Forms.TextBox();
            this.VentasTxtDireccionComprador = new System.Windows.Forms.TextBox();
            this.VentasDgvItems = new System.Windows.Forms.DataGridView();
            this.VentasLblItems = new System.Windows.Forms.Label();
            this.VentasLblBienServicio = new System.Windows.Forms.Label();
            this.VentasLblCantidad = new System.Windows.Forms.Label();
            this.VentasLblDescripcion = new System.Windows.Forms.Label();
            this.VentasLblPrecioUnitario = new System.Windows.Forms.Label();
            this.VentasLblDescuentos = new System.Windows.Forms.Label();
            this.VentasLblTotal = new System.Windows.Forms.Label();
            this.VentasCboBienServicio = new System.Windows.Forms.ComboBox();
            this.VentasTxtCantidad = new System.Windows.Forms.TextBox();
            this.VentasTxtDescripcion = new System.Windows.Forms.TextBox();
            this.VentasTxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.VentasTxtDescuentos = new System.Windows.Forms.TextBox();
            this.VentasTxtTotal = new System.Windows.Forms.TextBox();
            this.VentasBtnEmitirFactura = new System.Windows.Forms.Button();
            this.VentasBtnAgregarItem = new System.Windows.Forms.Button();
            this.VentasGrpIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDgvItems)).BeginInit();
            this.SuspendLayout();
            //
            // VentasLblTitulo
            //
            this.VentasLblTitulo.AutoSize = true;
            this.VentasLblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblTitulo.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblTitulo.ForeColor = System.Drawing.Color.White;
            this.VentasLblTitulo.Location = new System.Drawing.Point(118, 36);
            this.VentasLblTitulo.Name = "VentasLblTitulo";
            this.VentasLblTitulo.Size = new System.Drawing.Size(937, 65);
            this.VentasLblTitulo.TabIndex = 0;
            this.VentasLblTitulo.Text = "EMISIÓN DE FACTURA ELECTRÓNICA (DTE)";
            //
            // VentasLblEstablecimiento
            //
            this.VentasLblEstablecimiento.AutoSize = true;
            this.VentasLblEstablecimiento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblEstablecimiento.Location = new System.Drawing.Point(122, 143);
            this.VentasLblEstablecimiento.Name = "VentasLblEstablecimiento";
            this.VentasLblEstablecimiento.Size = new System.Drawing.Size(144, 25);
            this.VentasLblEstablecimiento.TabIndex = 1;
            this.VentasLblEstablecimiento.Text = "Establecimiento";
            //
            // VentasTxtEstablecimiento
            //
            this.VentasTxtEstablecimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtEstablecimiento.Location = new System.Drawing.Point(395, 140);
            this.VentasTxtEstablecimiento.Name = "VentasTxtEstablecimiento";
            this.VentasTxtEstablecimiento.Size = new System.Drawing.Size(268, 31);
            this.VentasTxtEstablecimiento.TabIndex = 2;
            //
            // VentasLblFechaEmision
            //
            this.VentasLblFechaEmision.AutoSize = true;
            this.VentasLblFechaEmision.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblFechaEmision.Location = new System.Drawing.Point(122, 223);
            this.VentasLblFechaEmision.Name = "VentasLblFechaEmision";
            this.VentasLblFechaEmision.Size = new System.Drawing.Size(155, 25);
            this.VentasLblFechaEmision.TabIndex = 3;
            this.VentasLblFechaEmision.Text = "Fecha de emisión";
            //
            // VentasDtpFechaEmision
            //
            this.VentasDtpFechaEmision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasDtpFechaEmision.Location = new System.Drawing.Point(395, 218);
            this.VentasDtpFechaEmision.Name = "VentasDtpFechaEmision";
            this.VentasDtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.VentasDtpFechaEmision.CustomFormat = "dd/MM/yyyy";
            this.VentasDtpFechaEmision.Size = new System.Drawing.Size(268, 31);
            this.VentasDtpFechaEmision.TabIndex = 4;
            //
            // VentasLblTipoDte
            //
            this.VentasLblTipoDte.AutoSize = true;
            this.VentasLblTipoDte.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblTipoDte.Location = new System.Drawing.Point(122, 298);
            this.VentasLblTipoDte.Name = "VentasLblTipoDte";
            this.VentasLblTipoDte.Size = new System.Drawing.Size(111, 25);
            this.VentasLblTipoDte.TabIndex = 5;
            this.VentasLblTipoDte.Text = "Tipo de DTE";
            //
            // VentasCboTipoDte
            //
            this.VentasCboTipoDte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasCboTipoDte.FormattingEnabled = true;
            this.VentasCboTipoDte.Items.AddRange(new object[] {
            "Factura",
            "Factura Cambiaria",
            "Factura Especial"});
            this.VentasCboTipoDte.Location = new System.Drawing.Point(395, 295);
            this.VentasCboTipoDte.Name = "VentasCboTipoDte";
            this.VentasCboTipoDte.Size = new System.Drawing.Size(268, 33);
            this.VentasCboTipoDte.TabIndex = 6;
            //
            // VentasLblMoneda
            //
            this.VentasLblMoneda.AutoSize = true;
            this.VentasLblMoneda.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblMoneda.Location = new System.Drawing.Point(122, 384);
            this.VentasLblMoneda.Name = "VentasLblMoneda";
            this.VentasLblMoneda.Size = new System.Drawing.Size(81, 25);
            this.VentasLblMoneda.TabIndex = 7;
            this.VentasLblMoneda.Text = "Moneda";
            //
            // VentasCboMoneda
            //
            this.VentasCboMoneda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasCboMoneda.FormattingEnabled = true;
            this.VentasCboMoneda.Items.AddRange(new object[] {
            "GTQ-Quetzal",
            "USD-Dólar estadounidense"});
            this.VentasCboMoneda.Location = new System.Drawing.Point(395, 381);
            this.VentasCboMoneda.Name = "VentasCboMoneda";
            this.VentasCboMoneda.Size = new System.Drawing.Size(268, 33);
            this.VentasCboMoneda.TabIndex = 8;
            //
            // VentasRdbNit
            //
            this.VentasRdbNit.AutoSize = true;
            this.VentasRdbNit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasRdbNit.ForeColor = System.Drawing.Color.White;
            this.VentasRdbNit.Location = new System.Drawing.Point(25, 30);
            this.VentasRdbNit.Name = "VentasRdbNit";
            this.VentasRdbNit.Size = new System.Drawing.Size(66, 29);
            this.VentasRdbNit.TabIndex = 9;
            this.VentasRdbNit.TabStop = true;
            this.VentasRdbNit.Text = "NIT";
            this.VentasRdbNit.UseVisualStyleBackColor = true;
            //
            // VentasGrpIdentificacion
            //
            this.VentasGrpIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasGrpIdentificacion.Controls.Add(this.VentasRdbIdExtranjero);
            this.VentasGrpIdentificacion.Controls.Add(this.VentasRdbCui);
            this.VentasGrpIdentificacion.Controls.Add(this.VentasRdbNit);
            this.VentasGrpIdentificacion.Location = new System.Drawing.Point(709, 435);
            this.VentasGrpIdentificacion.Name = "VentasGrpIdentificacion";
            this.VentasGrpIdentificacion.Size = new System.Drawing.Size(198, 115);
            this.VentasGrpIdentificacion.TabIndex = 10;
            this.VentasGrpIdentificacion.TabStop = false;
            //
            // VentasRdbIdExtranjero
            //
            this.VentasRdbIdExtranjero.AutoSize = true;
            this.VentasRdbIdExtranjero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasRdbIdExtranjero.ForeColor = System.Drawing.Color.White;
            this.VentasRdbIdExtranjero.Location = new System.Drawing.Point(16, 65);
            this.VentasRdbIdExtranjero.Name = "VentasRdbIdExtranjero";
            this.VentasRdbIdExtranjero.Size = new System.Drawing.Size(168, 29);
            this.VentasRdbIdExtranjero.TabIndex = 11;
            this.VentasRdbIdExtranjero.TabStop = true;
            this.VentasRdbIdExtranjero.Text = "ID EXTRANJERO";
            this.VentasRdbIdExtranjero.UseVisualStyleBackColor = true;
            //
            // VentasRdbCui
            //
            this.VentasRdbCui.AutoSize = true;
            this.VentasRdbCui.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasRdbCui.ForeColor = System.Drawing.Color.White;
            this.VentasRdbCui.Location = new System.Drawing.Point(116, 30);
            this.VentasRdbCui.Name = "VentasRdbCui";
            this.VentasRdbCui.Size = new System.Drawing.Size(66, 29);
            this.VentasRdbCui.TabIndex = 10;
            this.VentasRdbCui.TabStop = true;
            this.VentasRdbCui.Text = "CUI";
            this.VentasRdbCui.UseVisualStyleBackColor = true;
            //
            // VentasLblNitReceptor
            //
            this.VentasLblNitReceptor.AutoSize = true;
            this.VentasLblNitReceptor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblNitReceptor.Location = new System.Drawing.Point(122, 498);
            this.VentasLblNitReceptor.Name = "VentasLblNitReceptor";
            this.VentasLblNitReceptor.Size = new System.Drawing.Size(201, 25);
            this.VentasLblNitReceptor.TabIndex = 11;
            this.VentasLblNitReceptor.Text = "NIT del receptor o (CF)";
            //
            // VentasLblDireccionComprador
            //
            this.VentasLblDireccionComprador.AutoSize = true;
            this.VentasLblDireccionComprador.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblDireccionComprador.Location = new System.Drawing.Point(122, 570);
            this.VentasLblDireccionComprador.Name = "VentasLblDireccionComprador";
            this.VentasLblDireccionComprador.Size = new System.Drawing.Size(217, 25);
            this.VentasLblDireccionComprador.TabIndex = 12;
            this.VentasLblDireccionComprador.Text = "Dirección del comprador";
            //
            // VentasTxtNitReceptor
            //
            this.VentasTxtNitReceptor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtNitReceptor.Location = new System.Drawing.Point(395, 495);
            this.VentasTxtNitReceptor.Name = "VentasTxtNitReceptor";
            this.VentasTxtNitReceptor.Size = new System.Drawing.Size(268, 31);
            this.VentasTxtNitReceptor.TabIndex = 13;
            //
            // VentasTxtDireccionComprador
            //
            this.VentasTxtDireccionComprador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtDireccionComprador.Location = new System.Drawing.Point(395, 567);
            this.VentasTxtDireccionComprador.Name = "VentasTxtDireccionComprador";
            this.VentasTxtDireccionComprador.Size = new System.Drawing.Size(268, 31);
            this.VentasTxtDireccionComprador.TabIndex = 14;
            //
            // VentasDgvItems
            //
            this.VentasDgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasDgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasDgvItems.Location = new System.Drawing.Point(127, 700);
            this.VentasDgvItems.Name = "VentasDgvItems";
            this.VentasDgvItems.RowHeadersWidth = 62;
            this.VentasDgvItems.RowTemplate.Height = 28;
            this.VentasDgvItems.Size = new System.Drawing.Size(1066, 206);
            this.VentasDgvItems.TabIndex = 15;
            //
            // VentasLblItems
            //
            this.VentasLblItems.AutoSize = true;
            this.VentasLblItems.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblItems.Location = new System.Drawing.Point(122, 642);
            this.VentasLblItems.Name = "VentasLblItems";
            this.VentasLblItems.Size = new System.Drawing.Size(90, 38);
            this.VentasLblItems.TabIndex = 16;
            this.VentasLblItems.Text = "Items";
            //
            // VentasLblBienServicio
            //
            this.VentasLblBienServicio.AutoSize = true;
            this.VentasLblBienServicio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblBienServicio.Location = new System.Drawing.Point(165, 716);
            this.VentasLblBienServicio.Name = "VentasLblBienServicio";
            this.VentasLblBienServicio.Size = new System.Drawing.Size(40, 25);
            this.VentasLblBienServicio.TabIndex = 17;
            this.VentasLblBienServicio.Text = "B/S";
            //
            // VentasLblCantidad
            //
            this.VentasLblCantidad.AutoSize = true;
            this.VentasLblCantidad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblCantidad.Location = new System.Drawing.Point(278, 716);
            this.VentasLblCantidad.Name = "VentasLblCantidad";
            this.VentasLblCantidad.Size = new System.Drawing.Size(86, 25);
            this.VentasLblCantidad.TabIndex = 18;
            this.VentasLblCantidad.Text = "Cantidad";
            //
            // VentasLblDescripcion
            //
            this.VentasLblDescripcion.AutoSize = true;
            this.VentasLblDescripcion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblDescripcion.Location = new System.Drawing.Point(471, 716);
            this.VentasLblDescripcion.Name = "VentasLblDescripcion";
            this.VentasLblDescripcion.Size = new System.Drawing.Size(109, 25);
            this.VentasLblDescripcion.TabIndex = 19;
            this.VentasLblDescripcion.Text = "Descripción";
            //
            // VentasLblPrecioUnitario
            //
            this.VentasLblPrecioUnitario.AutoSize = true;
            this.VentasLblPrecioUnitario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblPrecioUnitario.Location = new System.Drawing.Point(661, 716);
            this.VentasLblPrecioUnitario.Name = "VentasLblPrecioUnitario";
            this.VentasLblPrecioUnitario.Size = new System.Drawing.Size(216, 25);
            this.VentasLblPrecioUnitario.TabIndex = 20;
            this.VentasLblPrecioUnitario.Text = "Precio/Valor unitario (Q)";
            //
            // VentasLblDescuentos
            //
            this.VentasLblDescuentos.AutoSize = true;
            this.VentasLblDescuentos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblDescuentos.Location = new System.Drawing.Point(915, 716);
            this.VentasLblDescuentos.Name = "VentasLblDescuentos";
            this.VentasLblDescuentos.Size = new System.Drawing.Size(109, 25);
            this.VentasLblDescuentos.TabIndex = 21;
            this.VentasLblDescuentos.Text = "Descuentos";
            //
            // VentasLblTotal
            //
            this.VentasLblTotal.AutoSize = true;
            this.VentasLblTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLblTotal.Location = new System.Drawing.Point(1089, 716);
            this.VentasLblTotal.Name = "VentasLblTotal";
            this.VentasLblTotal.Size = new System.Drawing.Size(52, 25);
            this.VentasLblTotal.TabIndex = 22;
            this.VentasLblTotal.Text = "Total";
            //
            // VentasCboBienServicio
            //
            this.VentasCboBienServicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasCboBienServicio.FormattingEnabled = true;
            this.VentasCboBienServicio.Items.AddRange(new object[] {
            "Bien",
            "Servicio"});
            this.VentasCboBienServicio.Location = new System.Drawing.Point(137, 763);
            this.VentasCboBienServicio.Name = "VentasCboBienServicio";
            this.VentasCboBienServicio.Size = new System.Drawing.Size(96, 33);
            this.VentasCboBienServicio.TabIndex = 23;
            //
            // VentasTxtCantidad
            //
            this.VentasTxtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtCantidad.Location = new System.Drawing.Point(264, 763);
            this.VentasTxtCantidad.Name = "VentasTxtCantidad";
            this.VentasTxtCantidad.Size = new System.Drawing.Size(112, 31);
            this.VentasTxtCantidad.TabIndex = 24;
            //
            // VentasTxtDescripcion
            //
            this.VentasTxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtDescripcion.Location = new System.Drawing.Point(406, 763);
            this.VentasTxtDescripcion.Name = "VentasTxtDescripcion";
            this.VentasTxtDescripcion.Size = new System.Drawing.Size(232, 31);
            this.VentasTxtDescripcion.TabIndex = 25;
            //
            // VentasTxtPrecioUnitario
            //
            this.VentasTxtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtPrecioUnitario.Location = new System.Drawing.Point(666, 763);
            this.VentasTxtPrecioUnitario.Name = "VentasTxtPrecioUnitario";
            this.VentasTxtPrecioUnitario.Size = new System.Drawing.Size(211, 31);
            this.VentasTxtPrecioUnitario.TabIndex = 26;
            //
            // VentasTxtDescuentos
            //
            this.VentasTxtDescuentos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtDescuentos.Location = new System.Drawing.Point(918, 763);
            this.VentasTxtDescuentos.Name = "VentasTxtDescuentos";
            this.VentasTxtDescuentos.Size = new System.Drawing.Size(106, 31);
            this.VentasTxtDescuentos.TabIndex = 27;
            //
            // VentasTxtTotal
            //
            this.VentasTxtTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasTxtTotal.Location = new System.Drawing.Point(1065, 763);
            this.VentasTxtTotal.Name = "VentasTxtTotal";
            this.VentasTxtTotal.Size = new System.Drawing.Size(112, 31);
            this.VentasTxtTotal.TabIndex = 28;
            //
            // VentasBtnEmitirFactura
            //
            this.VentasBtnEmitirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasBtnEmitirFactura.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasBtnEmitirFactura.ForeColor = System.Drawing.Color.White;
            this.VentasBtnEmitirFactura.Image = global::CapaVista_Ventas.Properties.Resources.IconoCotizacionesPedidosFacturasVentas;
            this.VentasBtnEmitirFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentasBtnEmitirFactura.Location = new System.Drawing.Point(500, 944);
            this.VentasBtnEmitirFactura.Name = "VentasBtnEmitirFactura";
            this.VentasBtnEmitirFactura.Size = new System.Drawing.Size(257, 64);
            this.VentasBtnEmitirFactura.TabIndex = 30;
            this.VentasBtnEmitirFactura.Text = "Emitir factura";
            this.VentasBtnEmitirFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VentasBtnEmitirFactura.UseVisualStyleBackColor = false;
            //
            // VentasBtnAgregarItem
            //
            this.VentasBtnAgregarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasBtnAgregarItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasBtnAgregarItem.ForeColor = System.Drawing.Color.White;
            this.VentasBtnAgregarItem.Image = global::CapaVista_Ventas.Properties.Resources.IconoRecepcionPagosVentas;
            this.VentasBtnAgregarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentasBtnAgregarItem.Location = new System.Drawing.Point(999, 825);
            this.VentasBtnAgregarItem.Name = "VentasBtnAgregarItem";
            this.VentasBtnAgregarItem.Size = new System.Drawing.Size(178, 54);
            this.VentasBtnAgregarItem.TabIndex = 31;
            this.VentasBtnAgregarItem.Text = "Agregar ítem";
            this.VentasBtnAgregarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VentasBtnAgregarItem.UseVisualStyleBackColor = false;
            //
            // FrmFacturas
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1221, 1059);
            this.Controls.Add(this.VentasBtnAgregarItem);
            this.Controls.Add(this.VentasBtnEmitirFactura);
            this.Controls.Add(this.VentasTxtTotal);
            this.Controls.Add(this.VentasTxtDescuentos);
            this.Controls.Add(this.VentasTxtPrecioUnitario);
            this.Controls.Add(this.VentasTxtDescripcion);
            this.Controls.Add(this.VentasTxtCantidad);
            this.Controls.Add(this.VentasCboBienServicio);
            this.Controls.Add(this.VentasLblTotal);
            this.Controls.Add(this.VentasLblDescuentos);
            this.Controls.Add(this.VentasLblPrecioUnitario);
            this.Controls.Add(this.VentasLblDescripcion);
            this.Controls.Add(this.VentasLblCantidad);
            this.Controls.Add(this.VentasLblBienServicio);
            this.Controls.Add(this.VentasLblItems);
            this.Controls.Add(this.VentasDgvItems);
            this.Controls.Add(this.VentasTxtDireccionComprador);
            this.Controls.Add(this.VentasTxtNitReceptor);
            this.Controls.Add(this.VentasLblDireccionComprador);
            this.Controls.Add(this.VentasLblNitReceptor);
            this.Controls.Add(this.VentasGrpIdentificacion);
            this.Controls.Add(this.VentasCboMoneda);
            this.Controls.Add(this.VentasLblMoneda);
            this.Controls.Add(this.VentasCboTipoDte);
            this.Controls.Add(this.VentasLblTipoDte);
            this.Controls.Add(this.VentasDtpFechaEmision);
            this.Controls.Add(this.VentasLblFechaEmision);
            this.Controls.Add(this.VentasTxtEstablecimiento);
            this.Controls.Add(this.VentasLblEstablecimiento);
            this.Controls.Add(this.VentasLblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::CapaVista_Ventas.Properties.Resources.IconoVentas;
            this.MaximizeBox = false;
            this.Name = "FrmFacturas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "7007 – Facturas";
            this.VentasGrpIdentificacion.ResumeLayout(false);
            this.VentasGrpIdentificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VentasLblTitulo;
        private System.Windows.Forms.Label VentasLblEstablecimiento;
        private System.Windows.Forms.TextBox VentasTxtEstablecimiento;
        private System.Windows.Forms.Label VentasLblFechaEmision;
        private System.Windows.Forms.DateTimePicker VentasDtpFechaEmision;
        private System.Windows.Forms.Label VentasLblTipoDte;
        private System.Windows.Forms.ComboBox VentasCboTipoDte;
        private System.Windows.Forms.Label VentasLblMoneda;
        private System.Windows.Forms.ComboBox VentasCboMoneda;
        private System.Windows.Forms.RadioButton VentasRdbNit;
        private System.Windows.Forms.GroupBox VentasGrpIdentificacion;
        private System.Windows.Forms.RadioButton VentasRdbIdExtranjero;
        private System.Windows.Forms.RadioButton VentasRdbCui;
        private System.Windows.Forms.Label VentasLblNitReceptor;
        private System.Windows.Forms.Label VentasLblDireccionComprador;
        private System.Windows.Forms.TextBox VentasTxtNitReceptor;
        private System.Windows.Forms.TextBox VentasTxtDireccionComprador;
        private System.Windows.Forms.DataGridView VentasDgvItems;
        private System.Windows.Forms.Label VentasLblItems;
        private System.Windows.Forms.Label VentasLblBienServicio;
        private System.Windows.Forms.Label VentasLblCantidad;
        private System.Windows.Forms.Label VentasLblDescripcion;
        private System.Windows.Forms.Label VentasLblPrecioUnitario;
        private System.Windows.Forms.Label VentasLblDescuentos;
        private System.Windows.Forms.Label VentasLblTotal;
        private System.Windows.Forms.ComboBox VentasCboBienServicio;
        private System.Windows.Forms.TextBox VentasTxtCantidad;
        private System.Windows.Forms.TextBox VentasTxtDescripcion;
        private System.Windows.Forms.TextBox VentasTxtPrecioUnitario;
        private System.Windows.Forms.TextBox VentasTxtDescuentos;
        private System.Windows.Forms.TextBox VentasTxtTotal;
        private System.Windows.Forms.Button VentasBtnEmitirFactura;
        private System.Windows.Forms.Button VentasBtnAgregarItem;
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 12/10/2026
