/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 12/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Mostrar únicamente el diseño estandarizado de reportes.
 */

namespace CapaVista_Ventas
{
    partial class FrmReportesVentas
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VentasPnlEncabezado = new System.Windows.Forms.Panel();
            this.VentasPbMarca = new System.Windows.Forms.PictureBox();
            this.VentasLblTitulo = new System.Windows.Forms.Label();
            this.VentasLblSubtitulo = new System.Windows.Forms.Label();
            this.VentasPnlAntiguedad = new System.Windows.Forms.Panel();
            this.VentasPnlFiltrosCorte = new System.Windows.Forms.Panel();
            this.VentasLblTipoCorte = new System.Windows.Forms.Label();
            this.VentasCboTipoCorte = new System.Windows.Forms.ComboBox();
            this.VentasLblCorte = new System.Windows.Forms.Label();
            this.VentasLblCorteObligatorio = new System.Windows.Forms.Label();
            this.VentasDtpCorte = new System.Windows.Forms.DateTimePicker();
            this.VentasLblClienteCorte = new System.Windows.Forms.Label();
            this.VentasCboClienteCorte = new System.Windows.Forms.ComboBox();
            this.VentasBtnVistaCorte = new System.Windows.Forms.Button();
            this.VentasBtnLimpiarCorte = new System.Windows.Forms.Button();
            this.VentasLblEstadoCorte = new System.Windows.Forms.Label();
            this.VentasCboEstadoCorte = new System.Windows.Forms.ComboBox();
            this.VentasLblAvisoCorte = new System.Windows.Forms.Label();
            this.VentasPnlSaldoCorte = new System.Windows.Forms.Panel();
            this.VentasLblTituloSaldoCorte = new System.Windows.Forms.Label();
            this.VentasLblSaldoCorte = new System.Windows.Forms.Label();
            this.VentasPnlVencidoCorte = new System.Windows.Forms.Panel();
            this.VentasLblTituloVencidoCorte = new System.Windows.Forms.Label();
            this.VentasLblVencidoCorte = new System.Windows.Forms.Label();
            this.VentasPnlVigenteCorte = new System.Windows.Forms.Panel();
            this.VentasLblTituloVigenteCorte = new System.Windows.Forms.Label();
            this.VentasLblVigenteCorte = new System.Windows.Forms.Label();
            this.VentasDgvCorte = new System.Windows.Forms.DataGridView();
            this.VentasPnlPaginaCorte = new System.Windows.Forms.Panel();
            this.VentasLblPaginaCorte = new System.Windows.Forms.Label();
            this.VentasBtnPaginaCorteAnterior = new System.Windows.Forms.Button();
            this.VentasBtnPaginaCorteSiguiente = new System.Windows.Forms.Button();
            this.VentasBtnCerrar = new System.Windows.Forms.Button();
            this.VentasBtnPdf = new System.Windows.Forms.Button();
            this.VentasBtnExcel = new System.Windows.Forms.Button();
            this.VentasBtnImprimir = new System.Windows.Forms.Button();
            this.VentasPnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMarca)).BeginInit();
            this.VentasPnlAntiguedad.SuspendLayout();
            this.VentasPnlFiltrosCorte.SuspendLayout();
            this.VentasPnlSaldoCorte.SuspendLayout();
            this.VentasPnlVencidoCorte.SuspendLayout();
            this.VentasPnlVigenteCorte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDgvCorte)).BeginInit();
            this.VentasPnlPaginaCorte.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentasPnlEncabezado
            // 
            this.VentasPnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasPnlEncabezado.Controls.Add(this.VentasPbMarca);
            this.VentasPnlEncabezado.Controls.Add(this.VentasLblTitulo);
            this.VentasPnlEncabezado.Controls.Add(this.VentasLblSubtitulo);
            this.VentasPnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.VentasPnlEncabezado.Name = "VentasPnlEncabezado";
            this.VentasPnlEncabezado.Size = new System.Drawing.Size(1100, 78);
            this.VentasPnlEncabezado.TabIndex = 0;
            // 
            // VentasPbMarca
            // 
            this.VentasPbMarca.Image = global::CapaVista_Ventas.Properties.Resources.IconoVentasImagen;
            this.VentasPbMarca.Location = new System.Drawing.Point(20, 13);
            this.VentasPbMarca.Name = "VentasPbMarca";
            this.VentasPbMarca.Size = new System.Drawing.Size(52, 52);
            this.VentasPbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasPbMarca.TabIndex = 1;
            this.VentasPbMarca.TabStop = false;
            // 
            // VentasLblTitulo
            // 
            this.VentasLblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTitulo.Font = new System.Drawing.Font("Lucida Fax", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.VentasLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasLblTitulo.Location = new System.Drawing.Point(87, 12);
            this.VentasLblTitulo.Name = "VentasLblTitulo";
            this.VentasLblTitulo.Size = new System.Drawing.Size(670, 35);
            this.VentasLblTitulo.TabIndex = 2;
            this.VentasLblTitulo.Text = "Reportes";
            // 
            // VentasLblSubtitulo
            // 
            this.VentasLblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblSubtitulo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasLblSubtitulo.Location = new System.Drawing.Point(89, 47);
            this.VentasLblSubtitulo.Name = "VentasLblSubtitulo";
            this.VentasLblSubtitulo.Size = new System.Drawing.Size(660, 23);
            this.VentasLblSubtitulo.TabIndex = 3;
            this.VentasLblSubtitulo.Text = "Antigüedad de saldos por cliente y documento a la fecha de corte";
            // 
            // VentasPnlAntiguedad
            // 
            this.VentasPnlAntiguedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasPnlAntiguedad.Controls.Add(this.VentasPnlFiltrosCorte);
            this.VentasPnlAntiguedad.Controls.Add(this.VentasPnlSaldoCorte);
            this.VentasPnlAntiguedad.Controls.Add(this.VentasPnlVencidoCorte);
            this.VentasPnlAntiguedad.Controls.Add(this.VentasPnlVigenteCorte);
            this.VentasPnlAntiguedad.Controls.Add(this.VentasDgvCorte);
            this.VentasPnlAntiguedad.Controls.Add(this.VentasPnlPaginaCorte);
            this.VentasPnlAntiguedad.Location = new System.Drawing.Point(24, 112);
            this.VentasPnlAntiguedad.Name = "VentasPnlAntiguedad";
            this.VentasPnlAntiguedad.Size = new System.Drawing.Size(1052, 469);
            this.VentasPnlAntiguedad.TabIndex = 7;
            this.VentasPnlAntiguedad.Text = "Antigüedad de saldos";
            // 
            // VentasPnlFiltrosCorte
            // 
            this.VentasPnlFiltrosCorte.BackColor = System.Drawing.Color.White;
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasLblTipoCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasCboTipoCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasLblCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasLblCorteObligatorio);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasDtpCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasLblClienteCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasCboClienteCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasBtnVistaCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasBtnLimpiarCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasLblEstadoCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasCboEstadoCorte);
            this.VentasPnlFiltrosCorte.Controls.Add(this.VentasLblAvisoCorte);
            this.VentasPnlFiltrosCorte.Location = new System.Drawing.Point(8, 8);
            this.VentasPnlFiltrosCorte.Name = "VentasPnlFiltrosCorte";
            this.VentasPnlFiltrosCorte.Size = new System.Drawing.Size(1036, 120);
            this.VentasPnlFiltrosCorte.TabIndex = 39;
            // 
            // VentasLblTipoCorte
            // 
            this.VentasLblTipoCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTipoCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblTipoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblTipoCorte.Location = new System.Drawing.Point(14, 12);
            this.VentasLblTipoCorte.Name = "VentasLblTipoCorte";
            this.VentasLblTipoCorte.Size = new System.Drawing.Size(320, 20);
            this.VentasLblTipoCorte.TabIndex = 40;
            this.VentasLblTipoCorte.Text = "Tipo de reporte";
            // 
            // VentasCboTipoCorte
            // 
            this.VentasCboTipoCorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VentasCboTipoCorte.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.VentasCboTipoCorte.Items.AddRange(new object[] {
            "Antigüedad de saldos"});
            this.VentasCboTipoCorte.Location = new System.Drawing.Point(14, 37);
            this.VentasCboTipoCorte.Name = "VentasCboTipoCorte";
            this.VentasCboTipoCorte.Size = new System.Drawing.Size(320, 33);
            this.VentasCboTipoCorte.TabIndex = 41;
            // 
            // VentasLblCorte
            // 
            this.VentasLblCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblCorte.Location = new System.Drawing.Point(358, 12);
            this.VentasLblCorte.Name = "VentasLblCorte";
            this.VentasLblCorte.Size = new System.Drawing.Size(270, 20);
            this.VentasLblCorte.TabIndex = 42;
            this.VentasLblCorte.Text = "Fecha de corte";
            // 
            // VentasLblCorteObligatorio
            // 
            this.VentasLblCorteObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblCorteObligatorio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblCorteObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.VentasLblCorteObligatorio.Location = new System.Drawing.Point(451, 10);
            this.VentasLblCorteObligatorio.Name = "VentasLblCorteObligatorio";
            this.VentasLblCorteObligatorio.Size = new System.Drawing.Size(14, 21);
            this.VentasLblCorteObligatorio.TabIndex = 43;
            this.VentasLblCorteObligatorio.Text = "*";
            // 
            // VentasDtpCorte
            // 
            this.VentasDtpCorte.CustomFormat = "dd/MM/yyyy";
            this.VentasDtpCorte.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.VentasDtpCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.VentasDtpCorte.Location = new System.Drawing.Point(358, 37);
            this.VentasDtpCorte.Name = "VentasDtpCorte";
            this.VentasDtpCorte.Size = new System.Drawing.Size(322, 32);
            this.VentasDtpCorte.TabIndex = 44;
            this.VentasDtpCorte.Value = new System.DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // VentasLblClienteCorte
            // 
            this.VentasLblClienteCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblClienteCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblClienteCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblClienteCorte.Location = new System.Drawing.Point(704, 12);
            this.VentasLblClienteCorte.Name = "VentasLblClienteCorte";
            this.VentasLblClienteCorte.Size = new System.Drawing.Size(314, 20);
            this.VentasLblClienteCorte.TabIndex = 45;
            this.VentasLblClienteCorte.Text = "Cliente";
            // 
            // VentasCboClienteCorte
            // 
            this.VentasCboClienteCorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VentasCboClienteCorte.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.VentasCboClienteCorte.Items.AddRange(new object[] {
            "Todos los clientes"});
            this.VentasCboClienteCorte.Location = new System.Drawing.Point(704, 37);
            this.VentasCboClienteCorte.Name = "VentasCboClienteCorte";
            this.VentasCboClienteCorte.Size = new System.Drawing.Size(314, 33);
            this.VentasCboClienteCorte.TabIndex = 46;
            // 
            // VentasBtnVistaCorte
            // 
            this.VentasBtnVistaCorte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasBtnVistaCorte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(74)))));
            this.VentasBtnVistaCorte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasBtnVistaCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnVistaCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnVistaCorte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnVistaCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnVistaCorte.Location = new System.Drawing.Point(14, 80);
            this.VentasBtnVistaCorte.Name = "VentasBtnVistaCorte";
            this.VentasBtnVistaCorte.Size = new System.Drawing.Size(184, 32);
            this.VentasBtnVistaCorte.TabIndex = 47;
            this.VentasBtnVistaCorte.Text = "Generar vista previa";
            this.VentasBtnVistaCorte.UseVisualStyleBackColor = false;
            // 
            // VentasBtnLimpiarCorte
            // 
            this.VentasBtnLimpiarCorte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnLimpiarCorte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnLimpiarCorte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnLimpiarCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnLimpiarCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnLimpiarCorte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnLimpiarCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasBtnLimpiarCorte.Location = new System.Drawing.Point(210, 80);
            this.VentasBtnLimpiarCorte.Name = "VentasBtnLimpiarCorte";
            this.VentasBtnLimpiarCorte.Size = new System.Drawing.Size(105, 32);
            this.VentasBtnLimpiarCorte.TabIndex = 48;
            this.VentasBtnLimpiarCorte.Text = "Limpiar";
            this.VentasBtnLimpiarCorte.UseVisualStyleBackColor = false;
            // 
            // VentasLblEstadoCorte
            // 
            this.VentasLblEstadoCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblEstadoCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblEstadoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblEstadoCorte.Location = new System.Drawing.Point(337, 86);
            this.VentasLblEstadoCorte.Name = "VentasLblEstadoCorte";
            this.VentasLblEstadoCorte.Size = new System.Drawing.Size(64, 20);
            this.VentasLblEstadoCorte.TabIndex = 49;
            this.VentasLblEstadoCorte.Text = "Estado";
            // 
            // VentasCboEstadoCorte
            // 
            this.VentasCboEstadoCorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VentasCboEstadoCorte.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.VentasCboEstadoCorte.Items.AddRange(new object[] {
            "Todos",
            "Pendiente",
            "Aplicado"});
            this.VentasCboEstadoCorte.Location = new System.Drawing.Point(403, 81);
            this.VentasCboEstadoCorte.Name = "VentasCboEstadoCorte";
            this.VentasCboEstadoCorte.Size = new System.Drawing.Size(175, 33);
            this.VentasCboEstadoCorte.TabIndex = 50;
            // 
            // VentasLblAvisoCorte
            // 
            this.VentasLblAvisoCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblAvisoCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblAvisoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblAvisoCorte.Location = new System.Drawing.Point(600, 86);
            this.VentasLblAvisoCorte.Name = "VentasLblAvisoCorte";
            this.VentasLblAvisoCorte.Size = new System.Drawing.Size(412, 23);
            this.VentasLblAvisoCorte.TabIndex = 51;
            this.VentasLblAvisoCorte.Text = "Días de mora desde el vencimiento hasta el corte.";
            // 
            // VentasPnlSaldoCorte
            // 
            this.VentasPnlSaldoCorte.BackColor = System.Drawing.Color.White;
            this.VentasPnlSaldoCorte.Controls.Add(this.VentasLblTituloSaldoCorte);
            this.VentasPnlSaldoCorte.Controls.Add(this.VentasLblSaldoCorte);
            this.VentasPnlSaldoCorte.Location = new System.Drawing.Point(8, 140);
            this.VentasPnlSaldoCorte.Name = "VentasPnlSaldoCorte";
            this.VentasPnlSaldoCorte.Size = new System.Drawing.Size(338, 65);
            this.VentasPnlSaldoCorte.TabIndex = 52;
            // 
            // VentasLblTituloSaldoCorte
            // 
            this.VentasLblTituloSaldoCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTituloSaldoCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblTituloSaldoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblTituloSaldoCorte.Location = new System.Drawing.Point(14, 8);
            this.VentasLblTituloSaldoCorte.Name = "VentasLblTituloSaldoCorte";
            this.VentasLblTituloSaldoCorte.Size = new System.Drawing.Size(310, 20);
            this.VentasLblTituloSaldoCorte.TabIndex = 53;
            this.VentasLblTituloSaldoCorte.Text = "Saldo a la fecha de corte";
            // 
            // VentasLblSaldoCorte
            // 
            this.VentasLblSaldoCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblSaldoCorte.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.VentasLblSaldoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblSaldoCorte.Location = new System.Drawing.Point(14, 30);
            this.VentasLblSaldoCorte.Name = "VentasLblSaldoCorte";
            this.VentasLblSaldoCorte.Size = new System.Drawing.Size(310, 29);
            this.VentasLblSaldoCorte.TabIndex = 54;
            this.VentasLblSaldoCorte.Text = "Q 0.00";
            // 
            // VentasPnlVencidoCorte
            // 
            this.VentasPnlVencidoCorte.BackColor = System.Drawing.Color.White;
            this.VentasPnlVencidoCorte.Controls.Add(this.VentasLblTituloVencidoCorte);
            this.VentasPnlVencidoCorte.Controls.Add(this.VentasLblVencidoCorte);
            this.VentasPnlVencidoCorte.Location = new System.Drawing.Point(357, 140);
            this.VentasPnlVencidoCorte.Name = "VentasPnlVencidoCorte";
            this.VentasPnlVencidoCorte.Size = new System.Drawing.Size(338, 65);
            this.VentasPnlVencidoCorte.TabIndex = 55;
            // 
            // VentasLblTituloVencidoCorte
            // 
            this.VentasLblTituloVencidoCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTituloVencidoCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblTituloVencidoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblTituloVencidoCorte.Location = new System.Drawing.Point(14, 8);
            this.VentasLblTituloVencidoCorte.Name = "VentasLblTituloVencidoCorte";
            this.VentasLblTituloVencidoCorte.Size = new System.Drawing.Size(310, 20);
            this.VentasLblTituloVencidoCorte.TabIndex = 56;
            this.VentasLblTituloVencidoCorte.Text = "Saldo vencido";
            // 
            // VentasLblVencidoCorte
            // 
            this.VentasLblVencidoCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblVencidoCorte.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.VentasLblVencidoCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblVencidoCorte.Location = new System.Drawing.Point(14, 30);
            this.VentasLblVencidoCorte.Name = "VentasLblVencidoCorte";
            this.VentasLblVencidoCorte.Size = new System.Drawing.Size(310, 29);
            this.VentasLblVencidoCorte.TabIndex = 57;
            this.VentasLblVencidoCorte.Text = "Q 0.00";
            // 
            // VentasPnlVigenteCorte
            // 
            this.VentasPnlVigenteCorte.BackColor = System.Drawing.Color.White;
            this.VentasPnlVigenteCorte.Controls.Add(this.VentasLblTituloVigenteCorte);
            this.VentasPnlVigenteCorte.Controls.Add(this.VentasLblVigenteCorte);
            this.VentasPnlVigenteCorte.Location = new System.Drawing.Point(706, 140);
            this.VentasPnlVigenteCorte.Name = "VentasPnlVigenteCorte";
            this.VentasPnlVigenteCorte.Size = new System.Drawing.Size(338, 65);
            this.VentasPnlVigenteCorte.TabIndex = 58;
            // 
            // VentasLblTituloVigenteCorte
            // 
            this.VentasLblTituloVigenteCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTituloVigenteCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblTituloVigenteCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblTituloVigenteCorte.Location = new System.Drawing.Point(14, 8);
            this.VentasLblTituloVigenteCorte.Name = "VentasLblTituloVigenteCorte";
            this.VentasLblTituloVigenteCorte.Size = new System.Drawing.Size(310, 20);
            this.VentasLblTituloVigenteCorte.TabIndex = 59;
            this.VentasLblTituloVigenteCorte.Text = "Saldo vigente";
            // 
            // VentasLblVigenteCorte
            // 
            this.VentasLblVigenteCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblVigenteCorte.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.VentasLblVigenteCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblVigenteCorte.Location = new System.Drawing.Point(14, 30);
            this.VentasLblVigenteCorte.Name = "VentasLblVigenteCorte";
            this.VentasLblVigenteCorte.Size = new System.Drawing.Size(310, 29);
            this.VentasLblVigenteCorte.TabIndex = 60;
            this.VentasLblVigenteCorte.Text = "Q 0.00";
            // 
            // VentasDgvCorte
            // 
            this.VentasDgvCorte.AllowUserToAddRows = false;
            this.VentasDgvCorte.AllowUserToDeleteRows = false;
            this.VentasDgvCorte.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasDgvCorte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VentasDgvCorte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VentasDgvCorte.BackgroundColor = System.Drawing.Color.White;
            this.VentasDgvCorte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasDgvCorte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VentasDgvCorte.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VentasDgvCorte.DefaultCellStyle = dataGridViewCellStyle3;
            this.VentasDgvCorte.EnableHeadersVisualStyles = false;
            this.VentasDgvCorte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasDgvCorte.Location = new System.Drawing.Point(8, 218);
            this.VentasDgvCorte.MultiSelect = false;
            this.VentasDgvCorte.Name = "VentasDgvCorte";
            this.VentasDgvCorte.ReadOnly = true;
            this.VentasDgvCorte.RowHeadersVisible = false;
            this.VentasDgvCorte.RowHeadersWidth = 51;
            this.VentasDgvCorte.RowTemplate.Height = 27;
            this.VentasDgvCorte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VentasDgvCorte.Size = new System.Drawing.Size(1036, 191);
            this.VentasDgvCorte.TabIndex = 61;
            // 
            // VentasPnlPaginaCorte
            // 
            this.VentasPnlPaginaCorte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasPnlPaginaCorte.Controls.Add(this.VentasLblPaginaCorte);
            this.VentasPnlPaginaCorte.Controls.Add(this.VentasBtnPaginaCorteAnterior);
            this.VentasPnlPaginaCorte.Controls.Add(this.VentasBtnPaginaCorteSiguiente);
            this.VentasPnlPaginaCorte.Location = new System.Drawing.Point(8, 422);
            this.VentasPnlPaginaCorte.Name = "VentasPnlPaginaCorte";
            this.VentasPnlPaginaCorte.Size = new System.Drawing.Size(1036, 37);
            this.VentasPnlPaginaCorte.TabIndex = 62;
            // 
            // VentasLblPaginaCorte
            // 
            this.VentasLblPaginaCorte.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblPaginaCorte.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblPaginaCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblPaginaCorte.Location = new System.Drawing.Point(12, 10);
            this.VentasLblPaginaCorte.Name = "VentasLblPaginaCorte";
            this.VentasLblPaginaCorte.Size = new System.Drawing.Size(530, 21);
            this.VentasLblPaginaCorte.TabIndex = 63;
            this.VentasLblPaginaCorte.Text = "0 registros · Página 1 de 1";
            // 
            // VentasBtnPaginaCorteAnterior
            // 
            this.VentasBtnPaginaCorteAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.VentasBtnPaginaCorteAnterior.Enabled = false;
            this.VentasBtnPaginaCorteAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnPaginaCorteAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnPaginaCorteAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnPaginaCorteAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnPaginaCorteAnterior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnPaginaCorteAnterior.ForeColor = System.Drawing.Color.Gray;
            this.VentasBtnPaginaCorteAnterior.Location = new System.Drawing.Point(738, 5);
            this.VentasBtnPaginaCorteAnterior.Name = "VentasBtnPaginaCorteAnterior";
            this.VentasBtnPaginaCorteAnterior.Size = new System.Drawing.Size(140, 27);
            this.VentasBtnPaginaCorteAnterior.TabIndex = 64;
            this.VentasBtnPaginaCorteAnterior.Text = "Anterior";
            this.VentasBtnPaginaCorteAnterior.UseVisualStyleBackColor = false;
            // 
            // VentasBtnPaginaCorteSiguiente
            // 
            this.VentasBtnPaginaCorteSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.VentasBtnPaginaCorteSiguiente.Enabled = false;
            this.VentasBtnPaginaCorteSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnPaginaCorteSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnPaginaCorteSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnPaginaCorteSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnPaginaCorteSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnPaginaCorteSiguiente.ForeColor = System.Drawing.Color.Gray;
            this.VentasBtnPaginaCorteSiguiente.Location = new System.Drawing.Point(888, 5);
            this.VentasBtnPaginaCorteSiguiente.Name = "VentasBtnPaginaCorteSiguiente";
            this.VentasBtnPaginaCorteSiguiente.Size = new System.Drawing.Size(136, 27);
            this.VentasBtnPaginaCorteSiguiente.TabIndex = 65;
            this.VentasBtnPaginaCorteSiguiente.Text = "Siguiente";
            this.VentasBtnPaginaCorteSiguiente.UseVisualStyleBackColor = false;
            // 
            // VentasBtnCerrar
            // 
            this.VentasBtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.VentasBtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasBtnCerrar.Location = new System.Drawing.Point(936, 620);
            this.VentasBtnCerrar.Name = "VentasBtnCerrar";
            this.VentasBtnCerrar.Size = new System.Drawing.Size(144, 37);
            this.VentasBtnCerrar.TabIndex = 97;
            this.VentasBtnCerrar.Text = "Cerrar";
            this.VentasBtnCerrar.UseVisualStyleBackColor = false;
            // 
            // VentasBtnPdf
            // 
            this.VentasBtnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.VentasBtnPdf.Enabled = false;
            this.VentasBtnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnPdf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnPdf.ForeColor = System.Drawing.Color.Gray;
            this.VentasBtnPdf.Location = new System.Drawing.Point(20, 626);
            this.VentasBtnPdf.Name = "VentasBtnPdf";
            this.VentasBtnPdf.Size = new System.Drawing.Size(144, 31);
            this.VentasBtnPdf.TabIndex = 98;
            this.VentasBtnPdf.Text = "Exportar PDF";
            this.VentasBtnPdf.UseVisualStyleBackColor = false;
            // 
            // VentasBtnExcel
            // 
            this.VentasBtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.VentasBtnExcel.Enabled = false;
            this.VentasBtnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnExcel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnExcel.ForeColor = System.Drawing.Color.Gray;
            this.VentasBtnExcel.Location = new System.Drawing.Point(176, 626);
            this.VentasBtnExcel.Name = "VentasBtnExcel";
            this.VentasBtnExcel.Size = new System.Drawing.Size(144, 31);
            this.VentasBtnExcel.TabIndex = 99;
            this.VentasBtnExcel.Text = "Exportar Excel";
            this.VentasBtnExcel.UseVisualStyleBackColor = false;
            // 
            // VentasBtnImprimir
            // 
            this.VentasBtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.VentasBtnImprimir.Enabled = false;
            this.VentasBtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasBtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasBtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnImprimir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnImprimir.ForeColor = System.Drawing.Color.Gray;
            this.VentasBtnImprimir.Location = new System.Drawing.Point(332, 626);
            this.VentasBtnImprimir.Name = "VentasBtnImprimir";
            this.VentasBtnImprimir.Size = new System.Drawing.Size(144, 31);
            this.VentasBtnImprimir.TabIndex = 100;
            this.VentasBtnImprimir.Text = "Imprimir";
            this.VentasBtnImprimir.UseVisualStyleBackColor = false;
            // 
            // FrmReportesVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.CancelButton = this.VentasBtnCerrar;
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.VentasPnlEncabezado);
            this.Controls.Add(this.VentasPnlAntiguedad);
            this.Controls.Add(this.VentasBtnCerrar);
            this.Controls.Add(this.VentasBtnPdf);
            this.Controls.Add(this.VentasBtnExcel);
            this.Controls.Add(this.VentasBtnImprimir);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::CapaVista_Ventas.Properties.Resources.IconoVentas;
            this.MaximizeBox = false;
            this.Name = "FrmReportesVentas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "7006 – Reportes";
            this.VentasPnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMarca)).EndInit();
            this.VentasPnlAntiguedad.ResumeLayout(false);
            this.VentasPnlFiltrosCorte.ResumeLayout(false);
            this.VentasPnlSaldoCorte.ResumeLayout(false);
            this.VentasPnlVencidoCorte.ResumeLayout(false);
            this.VentasPnlVigenteCorte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasDgvCorte)).EndInit();
            this.VentasPnlPaginaCorte.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel VentasPnlEncabezado;
        private System.Windows.Forms.PictureBox VentasPbMarca;
        private System.Windows.Forms.Label VentasLblTitulo;
        private System.Windows.Forms.Label VentasLblSubtitulo;
        private System.Windows.Forms.Panel VentasPnlAntiguedad;
        private System.Windows.Forms.Panel VentasPnlFiltrosCorte;
        private System.Windows.Forms.Label VentasLblTipoCorte;
        private System.Windows.Forms.ComboBox VentasCboTipoCorte;
        private System.Windows.Forms.Label VentasLblCorte;
        private System.Windows.Forms.Label VentasLblCorteObligatorio;
        private System.Windows.Forms.DateTimePicker VentasDtpCorte;
        private System.Windows.Forms.Label VentasLblClienteCorte;
        private System.Windows.Forms.ComboBox VentasCboClienteCorte;
        private System.Windows.Forms.Button VentasBtnVistaCorte;
        private System.Windows.Forms.Button VentasBtnLimpiarCorte;
        private System.Windows.Forms.Label VentasLblEstadoCorte;
        private System.Windows.Forms.ComboBox VentasCboEstadoCorte;
        private System.Windows.Forms.Label VentasLblAvisoCorte;
        private System.Windows.Forms.Panel VentasPnlSaldoCorte;
        private System.Windows.Forms.Label VentasLblTituloSaldoCorte;
        private System.Windows.Forms.Label VentasLblSaldoCorte;
        private System.Windows.Forms.Panel VentasPnlVencidoCorte;
        private System.Windows.Forms.Label VentasLblTituloVencidoCorte;
        private System.Windows.Forms.Label VentasLblVencidoCorte;
        private System.Windows.Forms.Panel VentasPnlVigenteCorte;
        private System.Windows.Forms.Label VentasLblTituloVigenteCorte;
        private System.Windows.Forms.Label VentasLblVigenteCorte;
        private System.Windows.Forms.DataGridView VentasDgvCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColVigente;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColMora30;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColMora60;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColMora90;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColMoraMayor90;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasDgvCorteColTotal;
        private System.Windows.Forms.Panel VentasPnlPaginaCorte;
        private System.Windows.Forms.Label VentasLblPaginaCorte;
        private System.Windows.Forms.Button VentasBtnPaginaCorteAnterior;
        private System.Windows.Forms.Button VentasBtnPaginaCorteSiguiente;
        private System.Windows.Forms.Button VentasBtnCerrar;
        private System.Windows.Forms.Button VentasBtnPdf;
        private System.Windows.Forms.Button VentasBtnExcel;
        private System.Windows.Forms.Button VentasBtnImprimir;
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 12/10/2026
