/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 12/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Definir controles visibles desde el diseñador de Windows Forms.
 */
namespace CapaVista_Ventas
{
    partial class FrmComisionesVendedoresVentas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel ComisionesPnlEncabezado;
        private System.Windows.Forms.PictureBox ComisionesPicMarca;
        private System.Windows.Forms.Label ComisionesLblTitulo;
        private System.Windows.Forms.Label ComisionesLblSubtitulo;
        private System.Windows.Forms.Label ComisionesLblPeriodo;
        private System.Windows.Forms.TabControl ComisionesTabControl;
        private System.Windows.Forms.TabPage ComisionesTabCalculo;
        private System.Windows.Forms.TabPage ComisionesTabConsulta;
        private System.Windows.Forms.TabPage ComisionesTabAutorizacion;
        private System.Windows.Forms.Label ComisionesLblDesde;
        private System.Windows.Forms.Label ComisionesLblHasta;
        private System.Windows.Forms.Label ComisionesLblVendedor;
        private System.Windows.Forms.Label ComisionesLblRegla;
        private System.Windows.Forms.TextBox ComisionesTxtDesde;
        private System.Windows.Forms.TextBox ComisionesTxtHasta;
        private System.Windows.Forms.TextBox ComisionesTxtVendedor;
        private System.Windows.Forms.TextBox ComisionesTxtRegla;
        private System.Windows.Forms.Button ComisionesBtnCalcular;
        private System.Windows.Forms.Panel ComisionesPnlCardVentas;
        private System.Windows.Forms.Panel ComisionesPnlCardMonto;
        private System.Windows.Forms.Panel ComisionesPnlCardEstado;
        private System.Windows.Forms.Label ComisionesLblCardVentas;
        private System.Windows.Forms.Label ComisionesLblCardVentasValor;
        private System.Windows.Forms.Label ComisionesLblCardVentasDetalle;
        private System.Windows.Forms.Label ComisionesLblCardMonto;
        private System.Windows.Forms.Label ComisionesLblCardMontoValor;
        private System.Windows.Forms.Label ComisionesLblCardMontoDetalle;
        private System.Windows.Forms.Label ComisionesLblCardEstado;
        private System.Windows.Forms.Label ComisionesLblCardEstadoValor;
        private System.Windows.Forms.Label ComisionesLblCardEstadoDetalle;
        private System.Windows.Forms.Label ComisionesLblVentasElegibles;
        private System.Windows.Forms.Label ComisionesLblAyudaElegibles;
        private System.Windows.Forms.DataGridView ComisionesDgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColVentaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColVentaDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColVentaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColVentaBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColVentaTasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColVentaComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColVentaEstado;
        private System.Windows.Forms.Label ComisionesLblPaginacion;
        private System.Windows.Forms.Button ComisionesBtnAnterior;
        private System.Windows.Forms.Button ComisionesBtnSiguiente;
        private System.Windows.Forms.Panel ComisionesPnlPieCalculo;
        private System.Windows.Forms.Label ComisionesLblAvisoAutorizacion;
        private System.Windows.Forms.Button ComisionesBtnSolicitar;
        private System.Windows.Forms.Label ComisionesLblConsultaVendedor;
        private System.Windows.Forms.Label ComisionesLblConsultaPeriodo;
        private System.Windows.Forms.Label ComisionesLblConsultaDocumento;
        private System.Windows.Forms.Label ComisionesLblConsultaEstado;
        private System.Windows.Forms.TextBox ComisionesTxtConsultaVendedor;
        private System.Windows.Forms.TextBox ComisionesTxtConsultaPeriodo;
        private System.Windows.Forms.TextBox ComisionesTxtConsultaDocumento;
        private System.Windows.Forms.TextBox ComisionesTxtConsultaEstado;
        private System.Windows.Forms.Button ComisionesBtnBuscar;
        private System.Windows.Forms.Label ComisionesLblHistorial;
        private System.Windows.Forms.DataGridView ComisionesDgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColHistorialPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColHistorialVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColHistorialVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColHistorialComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColHistorialDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColHistorialEstado;
        private System.Windows.Forms.Panel ComisionesPnlHistorialCard1;
        private System.Windows.Forms.Panel ComisionesPnlHistorialCard2;
        private System.Windows.Forms.Panel ComisionesPnlHistorialCard3;
        private System.Windows.Forms.Label ComisionesLblHistorialCard1;
        private System.Windows.Forms.Label ComisionesLblHistorialCard2;
        private System.Windows.Forms.Label ComisionesLblHistorialCard3;
        private System.Windows.Forms.Label ComisionesLblHistorialCard1Detalle;
        private System.Windows.Forms.Label ComisionesLblHistorialCard2Detalle;
        private System.Windows.Forms.Label ComisionesLblHistorialCard3Detalle;
        private System.Windows.Forms.Label ComisionesLblBandeja;
        private System.Windows.Forms.Label ComisionesLblAyudaBandeja;
        private System.Windows.Forms.DataGridView ComisionesDgvAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColAutorizacionPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColAutorizacionVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColAutorizacionVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColAutorizacionMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColAutorizacionSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesColAutorizacionEstado;
        private System.Windows.Forms.Panel ComisionesPnlResumen;
        private System.Windows.Forms.Label ComisionesLblResumenTitulo;
        private System.Windows.Forms.Label ComisionesLblResumenVendedor;
        private System.Windows.Forms.Label ComisionesLblResumenPeriodo;
        private System.Windows.Forms.Label ComisionesLblResumenVentas;
        private System.Windows.Forms.Label ComisionesLblResumenMonto;
        private System.Windows.Forms.Label ComisionesLblComentario;
        private System.Windows.Forms.TextBox ComisionesTxtComentario;
        private System.Windows.Forms.Button ComisionesBtnRechazar;
        private System.Windows.Forms.Button ComisionesBtnAprobar;
        private System.Windows.Forms.Panel ComisionesPnlPieAutorizacion;
        private System.Windows.Forms.Label ComisionesLblAvisoEnvio;
        private System.Windows.Forms.Button ComisionesBtnEnviar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComisionesPnlEncabezado = new System.Windows.Forms.Panel();
            this.ComisionesPicMarca = new System.Windows.Forms.PictureBox();
            this.ComisionesLblTitulo = new System.Windows.Forms.Label();
            this.ComisionesLblSubtitulo = new System.Windows.Forms.Label();
            this.ComisionesLblPeriodo = new System.Windows.Forms.Label();
            this.ComisionesTabControl = new System.Windows.Forms.TabControl();
            this.ComisionesTabCalculo = new System.Windows.Forms.TabPage();
            this.ComisionesLblDesde = new System.Windows.Forms.Label();
            this.ComisionesTxtDesde = new System.Windows.Forms.TextBox();
            this.ComisionesLblHasta = new System.Windows.Forms.Label();
            this.ComisionesTxtHasta = new System.Windows.Forms.TextBox();
            this.ComisionesLblVendedor = new System.Windows.Forms.Label();
            this.ComisionesTxtVendedor = new System.Windows.Forms.TextBox();
            this.ComisionesLblRegla = new System.Windows.Forms.Label();
            this.ComisionesTxtRegla = new System.Windows.Forms.TextBox();
            this.ComisionesBtnCalcular = new System.Windows.Forms.Button();
            this.ComisionesPnlCardVentas = new System.Windows.Forms.Panel();
            this.ComisionesLblCardVentas = new System.Windows.Forms.Label();
            this.ComisionesLblCardVentasValor = new System.Windows.Forms.Label();
            this.ComisionesLblCardVentasDetalle = new System.Windows.Forms.Label();
            this.ComisionesPnlCardMonto = new System.Windows.Forms.Panel();
            this.ComisionesLblCardMonto = new System.Windows.Forms.Label();
            this.ComisionesLblCardMontoValor = new System.Windows.Forms.Label();
            this.ComisionesLblCardMontoDetalle = new System.Windows.Forms.Label();
            this.ComisionesPnlCardEstado = new System.Windows.Forms.Panel();
            this.ComisionesLblCardEstado = new System.Windows.Forms.Label();
            this.ComisionesLblCardEstadoValor = new System.Windows.Forms.Label();
            this.ComisionesLblCardEstadoDetalle = new System.Windows.Forms.Label();
            this.ComisionesLblVentasElegibles = new System.Windows.Forms.Label();
            this.ComisionesLblAyudaElegibles = new System.Windows.Forms.Label();
            this.ComisionesDgvVentas = new System.Windows.Forms.DataGridView();
            this.ComisionesVentaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesVentaDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesVentaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesVentaBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesVentaTasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesVentaImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesVentaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesLblPaginacion = new System.Windows.Forms.Label();
            this.ComisionesBtnAnterior = new System.Windows.Forms.Button();
            this.ComisionesBtnSiguiente = new System.Windows.Forms.Button();
            this.ComisionesPnlPieCalculo = new System.Windows.Forms.Panel();
            this.ComisionesLblAvisoAutorizacion = new System.Windows.Forms.Label();
            this.ComisionesBtnSolicitar = new System.Windows.Forms.Button();
            this.ComisionesTabConsulta = new System.Windows.Forms.TabPage();
            this.ComisionesLblConsultaVendedor = new System.Windows.Forms.Label();
            this.ComisionesTxtConsultaVendedor = new System.Windows.Forms.TextBox();
            this.ComisionesLblConsultaPeriodo = new System.Windows.Forms.Label();
            this.ComisionesTxtConsultaPeriodo = new System.Windows.Forms.TextBox();
            this.ComisionesLblConsultaDocumento = new System.Windows.Forms.Label();
            this.ComisionesTxtConsultaDocumento = new System.Windows.Forms.TextBox();
            this.ComisionesLblConsultaEstado = new System.Windows.Forms.Label();
            this.ComisionesTxtConsultaEstado = new System.Windows.Forms.TextBox();
            this.ComisionesBtnBuscar = new System.Windows.Forms.Button();
            this.ComisionesLblHistorial = new System.Windows.Forms.Label();
            this.ComisionesDgvHistorial = new System.Windows.Forms.DataGridView();
            this.ComisionesHistorialPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesHistorialVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesHistorialVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesHistorialImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesHistorialDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesHistorialEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesPnlHistorialCard1 = new System.Windows.Forms.Panel();
            this.ComisionesLblHistorialCard1 = new System.Windows.Forms.Label();
            this.ComisionesLblHistorialCard1Detalle = new System.Windows.Forms.Label();
            this.ComisionesPnlHistorialCard2 = new System.Windows.Forms.Panel();
            this.ComisionesLblHistorialCard2 = new System.Windows.Forms.Label();
            this.ComisionesLblHistorialCard2Detalle = new System.Windows.Forms.Label();
            this.ComisionesPnlHistorialCard3 = new System.Windows.Forms.Panel();
            this.ComisionesLblHistorialCard3 = new System.Windows.Forms.Label();
            this.ComisionesLblHistorialCard3Detalle = new System.Windows.Forms.Label();
            this.ComisionesTabAutorizacion = new System.Windows.Forms.TabPage();
            this.ComisionesLblBandeja = new System.Windows.Forms.Label();
            this.ComisionesLblAyudaBandeja = new System.Windows.Forms.Label();
            this.ComisionesDgvAutorizacion = new System.Windows.Forms.DataGridView();
            this.ComisionesAutorizacionPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesAutorizacionVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesAutorizacionVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesAutorizacionMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesAutorizacionSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesAutorizacionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesPnlResumen = new System.Windows.Forms.Panel();
            this.ComisionesLblResumenTitulo = new System.Windows.Forms.Label();
            this.ComisionesLblResumenVendedor = new System.Windows.Forms.Label();
            this.ComisionesLblResumenPeriodo = new System.Windows.Forms.Label();
            this.ComisionesLblResumenVentas = new System.Windows.Forms.Label();
            this.ComisionesLblResumenMonto = new System.Windows.Forms.Label();
            this.ComisionesLblComentario = new System.Windows.Forms.Label();
            this.ComisionesTxtComentario = new System.Windows.Forms.TextBox();
            this.ComisionesBtnRechazar = new System.Windows.Forms.Button();
            this.ComisionesBtnAprobar = new System.Windows.Forms.Button();
            this.ComisionesPnlPieAutorizacion = new System.Windows.Forms.Panel();
            this.ComisionesLblAvisoEnvio = new System.Windows.Forms.Label();
            this.ComisionesBtnEnviar = new System.Windows.Forms.Button();
            this.ComisionesPnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesPicMarca)).BeginInit();
            this.ComisionesTabControl.SuspendLayout();
            this.ComisionesTabCalculo.SuspendLayout();
            this.ComisionesPnlCardVentas.SuspendLayout();
            this.ComisionesPnlCardMonto.SuspendLayout();
            this.ComisionesPnlCardEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesDgvVentas)).BeginInit();
            this.ComisionesPnlPieCalculo.SuspendLayout();
            this.ComisionesTabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesDgvHistorial)).BeginInit();
            this.ComisionesPnlHistorialCard1.SuspendLayout();
            this.ComisionesPnlHistorialCard2.SuspendLayout();
            this.ComisionesPnlHistorialCard3.SuspendLayout();
            this.ComisionesTabAutorizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesDgvAutorizacion)).BeginInit();
            this.ComisionesPnlResumen.SuspendLayout();
            this.ComisionesPnlPieAutorizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComisionesPnlEncabezado
            // 
            this.ComisionesPnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesPnlEncabezado.Controls.Add(this.ComisionesPicMarca);
            this.ComisionesPnlEncabezado.Controls.Add(this.ComisionesLblTitulo);
            this.ComisionesPnlEncabezado.Controls.Add(this.ComisionesLblSubtitulo);
            this.ComisionesPnlEncabezado.Controls.Add(this.ComisionesLblPeriodo);
            this.ComisionesPnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComisionesPnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.ComisionesPnlEncabezado.Name = "ComisionesPnlEncabezado";
            this.ComisionesPnlEncabezado.Size = new System.Drawing.Size(1060, 82);
            this.ComisionesPnlEncabezado.TabIndex = 0;
            // 
            // ComisionesPicMarca
            // 
            this.ComisionesPicMarca.Image = global::CapaVista_Ventas.Properties.Resources.IconoVentasImagen;
            this.ComisionesPicMarca.Location = new System.Drawing.Point(20, 14);
            this.ComisionesPicMarca.Name = "ComisionesPicMarca";
            this.ComisionesPicMarca.Size = new System.Drawing.Size(52, 52);
            this.ComisionesPicMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComisionesPicMarca.TabIndex = 0;
            this.ComisionesPicMarca.TabStop = false;
            // 
            // ComisionesLblTitulo
            // 
            this.ComisionesLblTitulo.AutoSize = true;
            this.ComisionesLblTitulo.Font = new System.Drawing.Font("Lucida Sans", 17F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblTitulo.ForeColor = System.Drawing.Color.White;
            this.ComisionesLblTitulo.Location = new System.Drawing.Point(86, 14);
            this.ComisionesLblTitulo.Name = "ComisionesLblTitulo";
            this.ComisionesLblTitulo.Size = new System.Drawing.Size(467, 33);
            this.ComisionesLblTitulo.TabIndex = 1;
            this.ComisionesLblTitulo.Text = "COMISIONES DE VENDEDORES";
            // 
            // ComisionesLblSubtitulo
            // 
            this.ComisionesLblSubtitulo.AutoSize = true;
            this.ComisionesLblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ComisionesLblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.ComisionesLblSubtitulo.Location = new System.Drawing.Point(88, 45);
            this.ComisionesLblSubtitulo.Name = "ComisionesLblSubtitulo";
            this.ComisionesLblSubtitulo.Size = new System.Drawing.Size(330, 21);
            this.ComisionesLblSubtitulo.TabIndex = 2;
            this.ComisionesLblSubtitulo.Text = "Cálculo, consulta y autorización de comisiones";
            // 
            // ComisionesLblPeriodo
            // 
            this.ComisionesLblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComisionesLblPeriodo.AutoSize = true;
            this.ComisionesLblPeriodo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblPeriodo.ForeColor = System.Drawing.Color.White;
            this.ComisionesLblPeriodo.Location = new System.Drawing.Point(827, 31);
            this.ComisionesLblPeriodo.Name = "ComisionesLblPeriodo";
            this.ComisionesLblPeriodo.Size = new System.Drawing.Size(217, 18);
            this.ComisionesLblPeriodo.TabIndex = 3;
            this.ComisionesLblPeriodo.Text = "PERIODO  ·  OCTUBRE 2026";
            // 
            // ComisionesTabControl
            // 
            this.ComisionesTabControl.Controls.Add(this.ComisionesTabCalculo);
            this.ComisionesTabControl.Controls.Add(this.ComisionesTabConsulta);
            this.ComisionesTabControl.Controls.Add(this.ComisionesTabAutorizacion);
            this.ComisionesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComisionesTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComisionesTabControl.Location = new System.Drawing.Point(0, 82);
            this.ComisionesTabControl.Name = "ComisionesTabControl";
            this.ComisionesTabControl.Padding = new System.Drawing.Point(18, 8);
            this.ComisionesTabControl.SelectedIndex = 0;
            this.ComisionesTabControl.Size = new System.Drawing.Size(1060, 578);
            this.ComisionesTabControl.TabIndex = 1;
            // 
            // ComisionesTabCalculo
            // 
            this.ComisionesTabCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesLblDesde);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesTxtDesde);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesLblHasta);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesTxtHasta);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesLblVendedor);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesTxtVendedor);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesLblRegla);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesTxtRegla);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesBtnCalcular);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesPnlCardVentas);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesPnlCardMonto);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesPnlCardEstado);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesLblVentasElegibles);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesLblAyudaElegibles);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesDgvVentas);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesLblPaginacion);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesBtnAnterior);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesBtnSiguiente);
            this.ComisionesTabCalculo.Controls.Add(this.ComisionesPnlPieCalculo);
            this.ComisionesTabCalculo.Location = new System.Drawing.Point(4, 42);
            this.ComisionesTabCalculo.Name = "ComisionesTabCalculo";
            this.ComisionesTabCalculo.Padding = new System.Windows.Forms.Padding(10);
            this.ComisionesTabCalculo.Size = new System.Drawing.Size(1052, 532);
            this.ComisionesTabCalculo.TabIndex = 0;
            this.ComisionesTabCalculo.Text = "Calcular comisión";
            // 
            // ComisionesLblDesde
            // 
            this.ComisionesLblDesde.AutoSize = true;
            this.ComisionesLblDesde.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComisionesLblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblDesde.Location = new System.Drawing.Point(24, 18);
            this.ComisionesLblDesde.Name = "ComisionesLblDesde";
            this.ComisionesLblDesde.Size = new System.Drawing.Size(111, 18);
            this.ComisionesLblDesde.TabIndex = 0;
            this.ComisionesLblDesde.Text = "Periodo · Desde";
            // 
            // ComisionesTxtDesde
            // 
            this.ComisionesTxtDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComisionesTxtDesde.Location = new System.Drawing.Point(24, 42);
            this.ComisionesTxtDesde.Name = "ComisionesTxtDesde";
            this.ComisionesTxtDesde.ReadOnly = true;
            this.ComisionesTxtDesde.Size = new System.Drawing.Size(145, 30);
            this.ComisionesTxtDesde.TabIndex = 1;
            this.ComisionesTxtDesde.Text = "01/10/2026";
            // 
            // ComisionesLblHasta
            // 
            this.ComisionesLblHasta.AutoSize = true;
            this.ComisionesLblHasta.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComisionesLblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblHasta.Location = new System.Drawing.Point(180, 18);
            this.ComisionesLblHasta.Name = "ComisionesLblHasta";
            this.ComisionesLblHasta.Size = new System.Drawing.Size(46, 18);
            this.ComisionesLblHasta.TabIndex = 2;
            this.ComisionesLblHasta.Text = "Hasta";
            // 
            // ComisionesTxtHasta
            // 
            this.ComisionesTxtHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComisionesTxtHasta.Location = new System.Drawing.Point(180, 42);
            this.ComisionesTxtHasta.Name = "ComisionesTxtHasta";
            this.ComisionesTxtHasta.ReadOnly = true;
            this.ComisionesTxtHasta.Size = new System.Drawing.Size(145, 30);
            this.ComisionesTxtHasta.TabIndex = 3;
            this.ComisionesTxtHasta.Text = "31/10/2026";
            // 
            // ComisionesLblVendedor
            // 
            this.ComisionesLblVendedor.AutoSize = true;
            this.ComisionesLblVendedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComisionesLblVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblVendedor.Location = new System.Drawing.Point(337, 18);
            this.ComisionesLblVendedor.Name = "ComisionesLblVendedor";
            this.ComisionesLblVendedor.Size = new System.Drawing.Size(70, 18);
            this.ComisionesLblVendedor.TabIndex = 4;
            this.ComisionesLblVendedor.Text = "Vendedor";
            // 
            // ComisionesTxtVendedor
            // 
            this.ComisionesTxtVendedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComisionesTxtVendedor.Location = new System.Drawing.Point(337, 42);
            this.ComisionesTxtVendedor.Name = "ComisionesTxtVendedor";
            this.ComisionesTxtVendedor.ReadOnly = true;
            this.ComisionesTxtVendedor.Size = new System.Drawing.Size(220, 30);
            this.ComisionesTxtVendedor.TabIndex = 5;
            this.ComisionesTxtVendedor.Text = "Todos los vendedores  ▾";
            // 
            // ComisionesLblRegla
            // 
            this.ComisionesLblRegla.AutoSize = true;
            this.ComisionesLblRegla.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComisionesLblRegla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblRegla.Location = new System.Drawing.Point(569, 18);
            this.ComisionesLblRegla.Name = "ComisionesLblRegla";
            this.ComisionesLblRegla.Size = new System.Drawing.Size(124, 18);
            this.ComisionesLblRegla.TabIndex = 6;
            this.ComisionesLblRegla.Text = "Regla de comisión";
            // 
            // ComisionesTxtRegla
            // 
            this.ComisionesTxtRegla.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComisionesTxtRegla.Location = new System.Drawing.Point(569, 42);
            this.ComisionesTxtRegla.Name = "ComisionesTxtRegla";
            this.ComisionesTxtRegla.ReadOnly = true;
            this.ComisionesTxtRegla.Size = new System.Drawing.Size(220, 30);
            this.ComisionesTxtRegla.TabIndex = 7;
            this.ComisionesTxtRegla.Text = "Comisión estándar  ▾";
            // 
            // ComisionesBtnCalcular
            // 
            this.ComisionesBtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesBtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnCalcular.ForeColor = System.Drawing.Color.White;
            this.ComisionesBtnCalcular.Location = new System.Drawing.Point(807, 37);
            this.ComisionesBtnCalcular.Name = "ComisionesBtnCalcular";
            this.ComisionesBtnCalcular.Size = new System.Drawing.Size(215, 44);
            this.ComisionesBtnCalcular.TabIndex = 8;
            this.ComisionesBtnCalcular.Text = "Calcular comisión";
            this.ComisionesBtnCalcular.UseVisualStyleBackColor = false;
            // 
            // ComisionesPnlCardVentas
            // 
            this.ComisionesPnlCardVentas.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlCardVentas.Controls.Add(this.ComisionesLblCardVentas);
            this.ComisionesPnlCardVentas.Controls.Add(this.ComisionesLblCardVentasValor);
            this.ComisionesPnlCardVentas.Controls.Add(this.ComisionesLblCardVentasDetalle);
            this.ComisionesPnlCardVentas.Location = new System.Drawing.Point(24, 104);
            this.ComisionesPnlCardVentas.Name = "ComisionesPnlCardVentas";
            this.ComisionesPnlCardVentas.Size = new System.Drawing.Size(313, 76);
            this.ComisionesPnlCardVentas.TabIndex = 9;
            // 
            // ComisionesLblCardVentas
            // 
            this.ComisionesLblCardVentas.AutoSize = true;
            this.ComisionesLblCardVentas.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblCardVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesLblCardVentas.Location = new System.Drawing.Point(14, 10);
            this.ComisionesLblCardVentas.Name = "ComisionesLblCardVentas";
            this.ComisionesLblCardVentas.Size = new System.Drawing.Size(149, 17);
            this.ComisionesLblCardVentas.TabIndex = 0;
            this.ComisionesLblCardVentas.Text = "VENTAS ELEGIBLES";
            // 
            // ComisionesLblCardVentasValor
            // 
            this.ComisionesLblCardVentasValor.AutoSize = true;
            this.ComisionesLblCardVentasValor.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblCardVentasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblCardVentasValor.Location = new System.Drawing.Point(14, 29);
            this.ComisionesLblCardVentasValor.Name = "ComisionesLblCardVentasValor";
            this.ComisionesLblCardVentasValor.Size = new System.Drawing.Size(155, 27);
            this.ComisionesLblCardVentasValor.TabIndex = 1;
            this.ComisionesLblCardVentasValor.Text = "Q 48,750.00";
            // 
            // ComisionesLblCardVentasDetalle
            // 
            this.ComisionesLblCardVentasDetalle.AutoSize = true;
            this.ComisionesLblCardVentasDetalle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ComisionesLblCardVentasDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblCardVentasDetalle.Location = new System.Drawing.Point(15, 54);
            this.ComisionesLblCardVentasDetalle.Name = "ComisionesLblCardVentasDetalle";
            this.ComisionesLblCardVentasDetalle.Size = new System.Drawing.Size(201, 20);
            this.ComisionesLblCardVentasDetalle.TabIndex = 2;
            this.ComisionesLblCardVentasDetalle.Text = "12 ventas dentro del periodo";
            // 
            // ComisionesPnlCardMonto
            // 
            this.ComisionesPnlCardMonto.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlCardMonto.Controls.Add(this.ComisionesLblCardMonto);
            this.ComisionesPnlCardMonto.Controls.Add(this.ComisionesLblCardMontoValor);
            this.ComisionesPnlCardMonto.Controls.Add(this.ComisionesLblCardMontoDetalle);
            this.ComisionesPnlCardMonto.Location = new System.Drawing.Point(349, 104);
            this.ComisionesPnlCardMonto.Name = "ComisionesPnlCardMonto";
            this.ComisionesPnlCardMonto.Size = new System.Drawing.Size(313, 76);
            this.ComisionesPnlCardMonto.TabIndex = 10;
            // 
            // ComisionesLblCardMonto
            // 
            this.ComisionesLblCardMonto.AutoSize = true;
            this.ComisionesLblCardMonto.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblCardMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesLblCardMonto.Location = new System.Drawing.Point(14, 10);
            this.ComisionesLblCardMonto.Name = "ComisionesLblCardMonto";
            this.ComisionesLblCardMonto.Size = new System.Drawing.Size(166, 17);
            this.ComisionesLblCardMonto.TabIndex = 0;
            this.ComisionesLblCardMonto.Text = "COMISIÓN ESTIMADA";
            // 
            // ComisionesLblCardMontoValor
            // 
            this.ComisionesLblCardMontoValor.AutoSize = true;
            this.ComisionesLblCardMontoValor.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblCardMontoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblCardMontoValor.Location = new System.Drawing.Point(14, 29);
            this.ComisionesLblCardMontoValor.Name = "ComisionesLblCardMontoValor";
            this.ComisionesLblCardMontoValor.Size = new System.Drawing.Size(140, 27);
            this.ComisionesLblCardMontoValor.TabIndex = 1;
            this.ComisionesLblCardMontoValor.Text = "Q 2,437.50";
            // 
            // ComisionesLblCardMontoDetalle
            // 
            this.ComisionesLblCardMontoDetalle.AutoSize = true;
            this.ComisionesLblCardMontoDetalle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ComisionesLblCardMontoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblCardMontoDetalle.Location = new System.Drawing.Point(15, 54);
            this.ComisionesLblCardMontoDetalle.Name = "ComisionesLblCardMontoDetalle";
            this.ComisionesLblCardMontoDetalle.Size = new System.Drawing.Size(144, 20);
            this.ComisionesLblCardMontoDetalle.TabIndex = 2;
            this.ComisionesLblCardMontoDetalle.Text = "Tasa aplicada: 5.00%";
            // 
            // ComisionesPnlCardEstado
            // 
            this.ComisionesPnlCardEstado.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlCardEstado.Controls.Add(this.ComisionesLblCardEstado);
            this.ComisionesPnlCardEstado.Controls.Add(this.ComisionesLblCardEstadoValor);
            this.ComisionesPnlCardEstado.Controls.Add(this.ComisionesLblCardEstadoDetalle);
            this.ComisionesPnlCardEstado.Location = new System.Drawing.Point(674, 104);
            this.ComisionesPnlCardEstado.Name = "ComisionesPnlCardEstado";
            this.ComisionesPnlCardEstado.Size = new System.Drawing.Size(348, 76);
            this.ComisionesPnlCardEstado.TabIndex = 11;
            // 
            // ComisionesLblCardEstado
            // 
            this.ComisionesLblCardEstado.AutoSize = true;
            this.ComisionesLblCardEstado.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblCardEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesLblCardEstado.Location = new System.Drawing.Point(14, 10);
            this.ComisionesLblCardEstado.Name = "ComisionesLblCardEstado";
            this.ComisionesLblCardEstado.Size = new System.Drawing.Size(168, 17);
            this.ComisionesLblCardEstado.TabIndex = 0;
            this.ComisionesLblCardEstado.Text = "ESTADO DEL PERIODO";
            // 
            // ComisionesLblCardEstadoValor
            // 
            this.ComisionesLblCardEstadoValor.AutoSize = true;
            this.ComisionesLblCardEstadoValor.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblCardEstadoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblCardEstadoValor.Location = new System.Drawing.Point(14, 29);
            this.ComisionesLblCardEstadoValor.Name = "ComisionesLblCardEstadoValor";
            this.ComisionesLblCardEstadoValor.Size = new System.Drawing.Size(118, 27);
            this.ComisionesLblCardEstadoValor.TabIndex = 1;
            this.ComisionesLblCardEstadoValor.Text = "Borrador";
            // 
            // ComisionesLblCardEstadoDetalle
            // 
            this.ComisionesLblCardEstadoDetalle.AutoSize = true;
            this.ComisionesLblCardEstadoDetalle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ComisionesLblCardEstadoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblCardEstadoDetalle.Location = new System.Drawing.Point(15, 54);
            this.ComisionesLblCardEstadoDetalle.Name = "ComisionesLblCardEstadoDetalle";
            this.ComisionesLblCardEstadoDetalle.Size = new System.Drawing.Size(231, 20);
            this.ComisionesLblCardEstadoDetalle.TabIndex = 2;
            this.ComisionesLblCardEstadoDetalle.Text = "Pendiente de solicitar aprobación";
            // 
            // ComisionesLblVentasElegibles
            // 
            this.ComisionesLblVentasElegibles.AutoSize = true;
            this.ComisionesLblVentasElegibles.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblVentasElegibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblVentasElegibles.Location = new System.Drawing.Point(24, 194);
            this.ComisionesLblVentasElegibles.Name = "ComisionesLblVentasElegibles";
            this.ComisionesLblVentasElegibles.Size = new System.Drawing.Size(183, 23);
            this.ComisionesLblVentasElegibles.TabIndex = 12;
            this.ComisionesLblVentasElegibles.Text = "Ventas elegibles";
            // 
            // ComisionesLblAyudaElegibles
            // 
            this.ComisionesLblAyudaElegibles.AutoSize = true;
            this.ComisionesLblAyudaElegibles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComisionesLblAyudaElegibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblAyudaElegibles.Location = new System.Drawing.Point(24, 220);
            this.ComisionesLblAyudaElegibles.Name = "ComisionesLblAyudaElegibles";
            this.ComisionesLblAyudaElegibles.Size = new System.Drawing.Size(424, 20);
            this.ComisionesLblAyudaElegibles.TabIndex = 13;
            this.ComisionesLblAyudaElegibles.Text = "Las ventas anuladas o fuera de vigencia se excluyen de la base.";
            // 
            // ComisionesDgvVentas
            // 
            this.ComisionesDgvVentas.AllowUserToAddRows = false;
            this.ComisionesDgvVentas.AllowUserToDeleteRows = false;
            this.ComisionesDgvVentas.AllowUserToResizeRows = false;
            this.ComisionesDgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComisionesDgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.ComisionesDgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComisionesDgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ComisionesDgvVentas.ColumnHeadersHeight = 38;
            this.ComisionesDgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComisionesVentaFecha,
            this.ComisionesVentaDocumento,
            this.ComisionesVentaCliente,
            this.ComisionesVentaBase,
            this.ComisionesVentaTasa,
            this.ComisionesVentaImporte,
            this.ComisionesVentaEstado});
            this.ComisionesDgvVentas.EnableHeadersVisualStyles = false;
            this.ComisionesDgvVentas.Location = new System.Drawing.Point(34, 243);
            this.ComisionesDgvVentas.Name = "ComisionesDgvVentas";
            this.ComisionesDgvVentas.ReadOnly = true;
            this.ComisionesDgvVentas.RowHeadersVisible = false;
            this.ComisionesDgvVentas.RowHeadersWidth = 51;
            this.ComisionesDgvVentas.RowTemplate.Height = 38;
            this.ComisionesDgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComisionesDgvVentas.Size = new System.Drawing.Size(971, 159);
            this.ComisionesDgvVentas.TabIndex = 12;
            // 
            // ComisionesVentaFecha
            // 
            this.ComisionesVentaFecha.HeaderText = "Fecha";
            this.ComisionesVentaFecha.MinimumWidth = 6;
            this.ComisionesVentaFecha.Name = "ComisionesVentaFecha";
            this.ComisionesVentaFecha.ReadOnly = true;
            // 
            // ComisionesVentaDocumento
            // 
            this.ComisionesVentaDocumento.HeaderText = "Documento";
            this.ComisionesVentaDocumento.MinimumWidth = 6;
            this.ComisionesVentaDocumento.Name = "ComisionesVentaDocumento";
            this.ComisionesVentaDocumento.ReadOnly = true;
            // 
            // ComisionesVentaCliente
            // 
            this.ComisionesVentaCliente.HeaderText = "Cliente";
            this.ComisionesVentaCliente.MinimumWidth = 6;
            this.ComisionesVentaCliente.Name = "ComisionesVentaCliente";
            this.ComisionesVentaCliente.ReadOnly = true;
            // 
            // ComisionesVentaBase
            // 
            this.ComisionesVentaBase.HeaderText = "Base de comisión";
            this.ComisionesVentaBase.MinimumWidth = 6;
            this.ComisionesVentaBase.Name = "ComisionesVentaBase";
            this.ComisionesVentaBase.ReadOnly = true;
            // 
            // ComisionesVentaTasa
            // 
            this.ComisionesVentaTasa.HeaderText = "Tasa";
            this.ComisionesVentaTasa.MinimumWidth = 6;
            this.ComisionesVentaTasa.Name = "ComisionesVentaTasa";
            this.ComisionesVentaTasa.ReadOnly = true;
            // 
            // ComisionesVentaImporte
            // 
            this.ComisionesVentaImporte.HeaderText = "Comisión";
            this.ComisionesVentaImporte.MinimumWidth = 6;
            this.ComisionesVentaImporte.Name = "ComisionesVentaImporte";
            this.ComisionesVentaImporte.ReadOnly = true;
            // 
            // ComisionesVentaEstado
            // 
            this.ComisionesVentaEstado.HeaderText = "Estado";
            this.ComisionesVentaEstado.MinimumWidth = 6;
            this.ComisionesVentaEstado.Name = "ComisionesVentaEstado";
            this.ComisionesVentaEstado.ReadOnly = true;
            // 
            // ComisionesLblPaginacion
            // 
            this.ComisionesLblPaginacion.AutoSize = true;
            this.ComisionesLblPaginacion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ComisionesLblPaginacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblPaginacion.Location = new System.Drawing.Point(24, 462);
            this.ComisionesLblPaginacion.Name = "ComisionesLblPaginacion";
            this.ComisionesLblPaginacion.Size = new System.Drawing.Size(244, 20);
            this.ComisionesLblPaginacion.TabIndex = 14;
            this.ComisionesLblPaginacion.Text = "Mostrando 3 de 12 ventas elegibles";
            // 
            // ComisionesBtnAnterior
            // 
            this.ComisionesBtnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.ComisionesBtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesBtnAnterior.Location = new System.Drawing.Point(770, 426);
            this.ComisionesBtnAnterior.Name = "ComisionesBtnAnterior";
            this.ComisionesBtnAnterior.Size = new System.Drawing.Size(105, 30);
            this.ComisionesBtnAnterior.TabIndex = 15;
            this.ComisionesBtnAnterior.Text = "Anterior";
            this.ComisionesBtnAnterior.UseVisualStyleBackColor = false;
            // 
            // ComisionesBtnSiguiente
            // 
            this.ComisionesBtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.ComisionesBtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesBtnSiguiente.Location = new System.Drawing.Point(897, 426);
            this.ComisionesBtnSiguiente.Name = "ComisionesBtnSiguiente";
            this.ComisionesBtnSiguiente.Size = new System.Drawing.Size(108, 30);
            this.ComisionesBtnSiguiente.TabIndex = 16;
            this.ComisionesBtnSiguiente.Text = "Siguiente";
            this.ComisionesBtnSiguiente.UseVisualStyleBackColor = false;
            // 
            // ComisionesPnlPieCalculo
            // 
            this.ComisionesPnlPieCalculo.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlPieCalculo.Controls.Add(this.ComisionesLblAvisoAutorizacion);
            this.ComisionesPnlPieCalculo.Controls.Add(this.ComisionesBtnSolicitar);
            this.ComisionesPnlPieCalculo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComisionesPnlPieCalculo.Location = new System.Drawing.Point(10, 462);
            this.ComisionesPnlPieCalculo.Name = "ComisionesPnlPieCalculo";
            this.ComisionesPnlPieCalculo.Size = new System.Drawing.Size(1032, 60);
            this.ComisionesPnlPieCalculo.TabIndex = 13;
            // 
            // ComisionesLblAvisoAutorizacion
            // 
            this.ComisionesLblAvisoAutorizacion.AutoSize = true;
            this.ComisionesLblAvisoAutorizacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComisionesLblAvisoAutorizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblAvisoAutorizacion.Location = new System.Drawing.Point(20, 23);
            this.ComisionesLblAvisoAutorizacion.Name = "ComisionesLblAvisoAutorizacion";
            this.ComisionesLblAvisoAutorizacion.Size = new System.Drawing.Size(523, 20);
            this.ComisionesLblAvisoAutorizacion.TabIndex = 0;
            this.ComisionesLblAvisoAutorizacion.Text = "La comisión requiere autorización antes de enviarse a Contabilidad / Nómina.";
            // 
            // ComisionesBtnSolicitar
            // 
            this.ComisionesBtnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesBtnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnSolicitar.ForeColor = System.Drawing.Color.White;
            this.ComisionesBtnSolicitar.Location = new System.Drawing.Point(780, 9);
            this.ComisionesBtnSolicitar.Name = "ComisionesBtnSolicitar";
            this.ComisionesBtnSolicitar.Size = new System.Drawing.Size(242, 42);
            this.ComisionesBtnSolicitar.TabIndex = 1;
            this.ComisionesBtnSolicitar.Text = "Solicitar aprobación";
            this.ComisionesBtnSolicitar.UseVisualStyleBackColor = false;
            // 
            // ComisionesTabConsulta
            // 
            this.ComisionesTabConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesLblConsultaVendedor);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesTxtConsultaVendedor);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesLblConsultaPeriodo);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesTxtConsultaPeriodo);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesLblConsultaDocumento);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesTxtConsultaDocumento);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesLblConsultaEstado);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesTxtConsultaEstado);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesBtnBuscar);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesLblHistorial);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesDgvHistorial);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesPnlHistorialCard1);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesPnlHistorialCard2);
            this.ComisionesTabConsulta.Controls.Add(this.ComisionesPnlHistorialCard3);
            this.ComisionesTabConsulta.Location = new System.Drawing.Point(4, 42);
            this.ComisionesTabConsulta.Name = "ComisionesTabConsulta";
            this.ComisionesTabConsulta.Padding = new System.Windows.Forms.Padding(10);
            this.ComisionesTabConsulta.Size = new System.Drawing.Size(1052, 532);
            this.ComisionesTabConsulta.TabIndex = 1;
            this.ComisionesTabConsulta.Text = "Consultar comisiones";
            // 
            // ComisionesLblConsultaVendedor
            // 
            this.ComisionesLblConsultaVendedor.AutoSize = true;
            this.ComisionesLblConsultaVendedor.Location = new System.Drawing.Point(24, 22);
            this.ComisionesLblConsultaVendedor.Name = "ComisionesLblConsultaVendedor";
            this.ComisionesLblConsultaVendedor.Size = new System.Drawing.Size(84, 23);
            this.ComisionesLblConsultaVendedor.TabIndex = 0;
            this.ComisionesLblConsultaVendedor.Text = "Vendedor";
            // 
            // ComisionesTxtConsultaVendedor
            // 
            this.ComisionesTxtConsultaVendedor.Location = new System.Drawing.Point(24, 46);
            this.ComisionesTxtConsultaVendedor.Name = "ComisionesTxtConsultaVendedor";
            this.ComisionesTxtConsultaVendedor.ReadOnly = true;
            this.ComisionesTxtConsultaVendedor.Size = new System.Drawing.Size(225, 30);
            this.ComisionesTxtConsultaVendedor.TabIndex = 1;
            this.ComisionesTxtConsultaVendedor.Text = "Todos los vendedores  ▾";
            // 
            // ComisionesLblConsultaPeriodo
            // 
            this.ComisionesLblConsultaPeriodo.AutoSize = true;
            this.ComisionesLblConsultaPeriodo.Location = new System.Drawing.Point(266, 22);
            this.ComisionesLblConsultaPeriodo.Name = "ComisionesLblConsultaPeriodo";
            this.ComisionesLblConsultaPeriodo.Size = new System.Drawing.Size(68, 23);
            this.ComisionesLblConsultaPeriodo.TabIndex = 2;
            this.ComisionesLblConsultaPeriodo.Text = "Periodo";
            // 
            // ComisionesTxtConsultaPeriodo
            // 
            this.ComisionesTxtConsultaPeriodo.Location = new System.Drawing.Point(266, 46);
            this.ComisionesTxtConsultaPeriodo.Name = "ComisionesTxtConsultaPeriodo";
            this.ComisionesTxtConsultaPeriodo.ReadOnly = true;
            this.ComisionesTxtConsultaPeriodo.Size = new System.Drawing.Size(240, 30);
            this.ComisionesTxtConsultaPeriodo.TabIndex = 3;
            this.ComisionesTxtConsultaPeriodo.Text = "01/10/2026 – 31/10/2026";
            // 
            // ComisionesLblConsultaDocumento
            // 
            this.ComisionesLblConsultaDocumento.AutoSize = true;
            this.ComisionesLblConsultaDocumento.Location = new System.Drawing.Point(523, 22);
            this.ComisionesLblConsultaDocumento.Name = "ComisionesLblConsultaDocumento";
            this.ComisionesLblConsultaDocumento.Size = new System.Drawing.Size(100, 23);
            this.ComisionesLblConsultaDocumento.TabIndex = 4;
            this.ComisionesLblConsultaDocumento.Text = "Documento";
            // 
            // ComisionesTxtConsultaDocumento
            // 
            this.ComisionesTxtConsultaDocumento.Location = new System.Drawing.Point(523, 46);
            this.ComisionesTxtConsultaDocumento.Name = "ComisionesTxtConsultaDocumento";
            this.ComisionesTxtConsultaDocumento.ReadOnly = true;
            this.ComisionesTxtConsultaDocumento.Size = new System.Drawing.Size(220, 30);
            this.ComisionesTxtConsultaDocumento.TabIndex = 5;
            this.ComisionesTxtConsultaDocumento.Text = "Buscar por número";
            // 
            // ComisionesLblConsultaEstado
            // 
            this.ComisionesLblConsultaEstado.AutoSize = true;
            this.ComisionesLblConsultaEstado.Location = new System.Drawing.Point(760, 22);
            this.ComisionesLblConsultaEstado.Name = "ComisionesLblConsultaEstado";
            this.ComisionesLblConsultaEstado.Size = new System.Drawing.Size(61, 23);
            this.ComisionesLblConsultaEstado.TabIndex = 6;
            this.ComisionesLblConsultaEstado.Text = "Estado";
            // 
            // ComisionesTxtConsultaEstado
            // 
            this.ComisionesTxtConsultaEstado.Location = new System.Drawing.Point(760, 46);
            this.ComisionesTxtConsultaEstado.Name = "ComisionesTxtConsultaEstado";
            this.ComisionesTxtConsultaEstado.ReadOnly = true;
            this.ComisionesTxtConsultaEstado.Size = new System.Drawing.Size(205, 30);
            this.ComisionesTxtConsultaEstado.TabIndex = 7;
            this.ComisionesTxtConsultaEstado.Text = "Todos los estados  ▾";
            // 
            // ComisionesBtnBuscar
            // 
            this.ComisionesBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.ComisionesBtnBuscar.Location = new System.Drawing.Point(888, 105);
            this.ComisionesBtnBuscar.Name = "ComisionesBtnBuscar";
            this.ComisionesBtnBuscar.Size = new System.Drawing.Size(134, 42);
            this.ComisionesBtnBuscar.TabIndex = 8;
            this.ComisionesBtnBuscar.Text = "Buscar";
            this.ComisionesBtnBuscar.UseVisualStyleBackColor = false;
            // 
            // ComisionesLblHistorial
            // 
            this.ComisionesLblHistorial.AutoSize = true;
            this.ComisionesLblHistorial.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblHistorial.Location = new System.Drawing.Point(24, 120);
            this.ComisionesLblHistorial.Name = "ComisionesLblHistorial";
            this.ComisionesLblHistorial.Size = new System.Drawing.Size(276, 25);
            this.ComisionesLblHistorial.TabIndex = 9;
            this.ComisionesLblHistorial.Text = "Historial de comisiones";
            // 
            // ComisionesDgvHistorial
            // 
            this.ComisionesDgvHistorial.AllowUserToAddRows = false;
            this.ComisionesDgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComisionesDgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.ComisionesDgvHistorial.ColumnHeadersHeight = 29;
            this.ComisionesDgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComisionesHistorialPeriodo,
            this.ComisionesHistorialVendedor,
            this.ComisionesHistorialVentas,
            this.ComisionesHistorialImporte,
            this.ComisionesHistorialDocumento,
            this.ComisionesHistorialEstado});
            this.ComisionesDgvHistorial.Location = new System.Drawing.Point(24, 158);
            this.ComisionesDgvHistorial.Name = "ComisionesDgvHistorial";
            this.ComisionesDgvHistorial.ReadOnly = true;
            this.ComisionesDgvHistorial.RowHeadersVisible = false;
            this.ComisionesDgvHistorial.RowHeadersWidth = 51;
            this.ComisionesDgvHistorial.Size = new System.Drawing.Size(998, 275);
            this.ComisionesDgvHistorial.TabIndex = 10;
            // 
            // ComisionesHistorialPeriodo
            // 
            this.ComisionesHistorialPeriodo.HeaderText = "Periodo";
            this.ComisionesHistorialPeriodo.MinimumWidth = 6;
            this.ComisionesHistorialPeriodo.Name = "ComisionesHistorialPeriodo";
            this.ComisionesHistorialPeriodo.ReadOnly = true;
            // 
            // ComisionesHistorialVendedor
            // 
            this.ComisionesHistorialVendedor.HeaderText = "Vendedor";
            this.ComisionesHistorialVendedor.MinimumWidth = 6;
            this.ComisionesHistorialVendedor.Name = "ComisionesHistorialVendedor";
            this.ComisionesHistorialVendedor.ReadOnly = true;
            // 
            // ComisionesHistorialVentas
            // 
            this.ComisionesHistorialVentas.HeaderText = "Ventas";
            this.ComisionesHistorialVentas.MinimumWidth = 6;
            this.ComisionesHistorialVentas.Name = "ComisionesHistorialVentas";
            this.ComisionesHistorialVentas.ReadOnly = true;
            // 
            // ComisionesHistorialImporte
            // 
            this.ComisionesHistorialImporte.HeaderText = "Comisión";
            this.ComisionesHistorialImporte.MinimumWidth = 6;
            this.ComisionesHistorialImporte.Name = "ComisionesHistorialImporte";
            this.ComisionesHistorialImporte.ReadOnly = true;
            // 
            // ComisionesHistorialDocumento
            // 
            this.ComisionesHistorialDocumento.HeaderText = "Documento";
            this.ComisionesHistorialDocumento.MinimumWidth = 6;
            this.ComisionesHistorialDocumento.Name = "ComisionesHistorialDocumento";
            this.ComisionesHistorialDocumento.ReadOnly = true;
            // 
            // ComisionesHistorialEstado
            // 
            this.ComisionesHistorialEstado.HeaderText = "Estado";
            this.ComisionesHistorialEstado.MinimumWidth = 6;
            this.ComisionesHistorialEstado.Name = "ComisionesHistorialEstado";
            this.ComisionesHistorialEstado.ReadOnly = true;
            // 
            // ComisionesPnlHistorialCard1
            // 
            this.ComisionesPnlHistorialCard1.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlHistorialCard1.Controls.Add(this.ComisionesLblHistorialCard1);
            this.ComisionesPnlHistorialCard1.Controls.Add(this.ComisionesLblHistorialCard1Detalle);
            this.ComisionesPnlHistorialCard1.Location = new System.Drawing.Point(24, 456);
            this.ComisionesPnlHistorialCard1.Name = "ComisionesPnlHistorialCard1";
            this.ComisionesPnlHistorialCard1.Size = new System.Drawing.Size(313, 68);
            this.ComisionesPnlHistorialCard1.TabIndex = 11;
            // 
            // ComisionesLblHistorialCard1
            // 
            this.ComisionesLblHistorialCard1.AutoSize = true;
            this.ComisionesLblHistorialCard1.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblHistorialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblHistorialCard1.Location = new System.Drawing.Point(14, 10);
            this.ComisionesLblHistorialCard1.Name = "ComisionesLblHistorialCard1";
            this.ComisionesLblHistorialCard1.Size = new System.Drawing.Size(160, 25);
            this.ComisionesLblHistorialCard1.TabIndex = 0;
            this.ComisionesLblHistorialCard1.Text = "4 comisiones";
            // 
            // ComisionesLblHistorialCard1Detalle
            // 
            this.ComisionesLblHistorialCard1Detalle.AutoSize = true;
            this.ComisionesLblHistorialCard1Detalle.Location = new System.Drawing.Point(15, 40);
            this.ComisionesLblHistorialCard1Detalle.Name = "ComisionesLblHistorialCard1Detalle";
            this.ComisionesLblHistorialCard1Detalle.Size = new System.Drawing.Size(182, 23);
            this.ComisionesLblHistorialCard1Detalle.TabIndex = 1;
            this.ComisionesLblHistorialCard1Detalle.Text = "Resultados de ejemplo";
            // 
            // ComisionesPnlHistorialCard2
            // 
            this.ComisionesPnlHistorialCard2.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlHistorialCard2.Controls.Add(this.ComisionesLblHistorialCard2);
            this.ComisionesPnlHistorialCard2.Controls.Add(this.ComisionesLblHistorialCard2Detalle);
            this.ComisionesPnlHistorialCard2.Location = new System.Drawing.Point(349, 456);
            this.ComisionesPnlHistorialCard2.Name = "ComisionesPnlHistorialCard2";
            this.ComisionesPnlHistorialCard2.Size = new System.Drawing.Size(313, 68);
            this.ComisionesPnlHistorialCard2.TabIndex = 12;
            // 
            // ComisionesLblHistorialCard2
            // 
            this.ComisionesLblHistorialCard2.AutoSize = true;
            this.ComisionesLblHistorialCard2.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblHistorialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblHistorialCard2.Location = new System.Drawing.Point(14, 10);
            this.ComisionesLblHistorialCard2.Name = "ComisionesLblHistorialCard2";
            this.ComisionesLblHistorialCard2.Size = new System.Drawing.Size(131, 25);
            this.ComisionesLblHistorialCard2.TabIndex = 0;
            this.ComisionesLblHistorialCard2.Text = "Q 7,427.50";
            // 
            // ComisionesLblHistorialCard2Detalle
            // 
            this.ComisionesLblHistorialCard2Detalle.AutoSize = true;
            this.ComisionesLblHistorialCard2Detalle.Location = new System.Drawing.Point(15, 40);
            this.ComisionesLblHistorialCard2Detalle.Name = "ComisionesLblHistorialCard2Detalle";
            this.ComisionesLblHistorialCard2Detalle.Size = new System.Drawing.Size(217, 23);
            this.ComisionesLblHistorialCard2Detalle.TabIndex = 1;
            this.ComisionesLblHistorialCard2Detalle.Text = "Total ilustrativo del periodo";
            // 
            // ComisionesPnlHistorialCard3
            // 
            this.ComisionesPnlHistorialCard3.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlHistorialCard3.Controls.Add(this.ComisionesLblHistorialCard3);
            this.ComisionesPnlHistorialCard3.Controls.Add(this.ComisionesLblHistorialCard3Detalle);
            this.ComisionesPnlHistorialCard3.Location = new System.Drawing.Point(674, 456);
            this.ComisionesPnlHistorialCard3.Name = "ComisionesPnlHistorialCard3";
            this.ComisionesPnlHistorialCard3.Size = new System.Drawing.Size(348, 68);
            this.ComisionesPnlHistorialCard3.TabIndex = 13;
            // 
            // ComisionesLblHistorialCard3
            // 
            this.ComisionesLblHistorialCard3.AutoSize = true;
            this.ComisionesLblHistorialCard3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblHistorialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblHistorialCard3.Location = new System.Drawing.Point(14, 10);
            this.ComisionesLblHistorialCard3.Name = "ComisionesLblHistorialCard3";
            this.ComisionesLblHistorialCard3.Size = new System.Drawing.Size(245, 23);
            this.ComisionesLblHistorialCard3.TabIndex = 0;
            this.ComisionesLblHistorialCard3.Text = "Seleccione un registro";
            // 
            // ComisionesLblHistorialCard3Detalle
            // 
            this.ComisionesLblHistorialCard3Detalle.AutoSize = true;
            this.ComisionesLblHistorialCard3Detalle.Location = new System.Drawing.Point(15, 40);
            this.ComisionesLblHistorialCard3Detalle.Name = "ComisionesLblHistorialCard3Detalle";
            this.ComisionesLblHistorialCard3Detalle.Size = new System.Drawing.Size(190, 23);
            this.ComisionesLblHistorialCard3Detalle.TabIndex = 1;
            this.ComisionesLblHistorialCard3Detalle.Text = "Detalle, ventas y estado";
            // 
            // ComisionesTabAutorizacion
            // 
            this.ComisionesTabAutorizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesLblBandeja);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesLblAyudaBandeja);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesDgvAutorizacion);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesPnlResumen);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesLblComentario);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesTxtComentario);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesBtnRechazar);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesBtnAprobar);
            this.ComisionesTabAutorizacion.Controls.Add(this.ComisionesPnlPieAutorizacion);
            this.ComisionesTabAutorizacion.Location = new System.Drawing.Point(4, 42);
            this.ComisionesTabAutorizacion.Name = "ComisionesTabAutorizacion";
            this.ComisionesTabAutorizacion.Padding = new System.Windows.Forms.Padding(10);
            this.ComisionesTabAutorizacion.Size = new System.Drawing.Size(1052, 532);
            this.ComisionesTabAutorizacion.TabIndex = 2;
            this.ComisionesTabAutorizacion.Text = "Autorizar comisión";
            // 
            // ComisionesLblBandeja
            // 
            this.ComisionesLblBandeja.AutoSize = true;
            this.ComisionesLblBandeja.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblBandeja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesLblBandeja.Location = new System.Drawing.Point(24, 20);
            this.ComisionesLblBandeja.Name = "ComisionesLblBandeja";
            this.ComisionesLblBandeja.Size = new System.Drawing.Size(286, 25);
            this.ComisionesLblBandeja.TabIndex = 0;
            this.ComisionesLblBandeja.Text = "Bandeja de autorización";
            // 
            // ComisionesLblAyudaBandeja
            // 
            this.ComisionesLblAyudaBandeja.AutoSize = true;
            this.ComisionesLblAyudaBandeja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblAyudaBandeja.Location = new System.Drawing.Point(24, 48);
            this.ComisionesLblAyudaBandeja.Name = "ComisionesLblAyudaBandeja";
            this.ComisionesLblAyudaBandeja.Size = new System.Drawing.Size(462, 23);
            this.ComisionesLblAyudaBandeja.TabIndex = 1;
            this.ComisionesLblAyudaBandeja.Text = "Revise el resumen del periodo antes de aprobar o rechazar.";
            // 
            // ComisionesDgvAutorizacion
            // 
            this.ComisionesDgvAutorizacion.AllowUserToAddRows = false;
            this.ComisionesDgvAutorizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComisionesDgvAutorizacion.BackgroundColor = System.Drawing.Color.White;
            this.ComisionesDgvAutorizacion.ColumnHeadersHeight = 29;
            this.ComisionesDgvAutorizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComisionesAutorizacionPeriodo,
            this.ComisionesAutorizacionVendedor,
            this.ComisionesAutorizacionVentas,
            this.ComisionesAutorizacionMonto,
            this.ComisionesAutorizacionSolicitada,
            this.ComisionesAutorizacionEstado});
            this.ComisionesDgvAutorizacion.Location = new System.Drawing.Point(24, 82);
            this.ComisionesDgvAutorizacion.Name = "ComisionesDgvAutorizacion";
            this.ComisionesDgvAutorizacion.ReadOnly = true;
            this.ComisionesDgvAutorizacion.RowHeadersVisible = false;
            this.ComisionesDgvAutorizacion.RowHeadersWidth = 51;
            this.ComisionesDgvAutorizacion.Size = new System.Drawing.Size(998, 190);
            this.ComisionesDgvAutorizacion.TabIndex = 2;
            // 
            // ComisionesAutorizacionPeriodo
            // 
            this.ComisionesAutorizacionPeriodo.HeaderText = "Periodo";
            this.ComisionesAutorizacionPeriodo.MinimumWidth = 6;
            this.ComisionesAutorizacionPeriodo.Name = "ComisionesAutorizacionPeriodo";
            this.ComisionesAutorizacionPeriodo.ReadOnly = true;
            // 
            // ComisionesAutorizacionVendedor
            // 
            this.ComisionesAutorizacionVendedor.HeaderText = "Vendedor";
            this.ComisionesAutorizacionVendedor.MinimumWidth = 6;
            this.ComisionesAutorizacionVendedor.Name = "ComisionesAutorizacionVendedor";
            this.ComisionesAutorizacionVendedor.ReadOnly = true;
            // 
            // ComisionesAutorizacionVentas
            // 
            this.ComisionesAutorizacionVentas.HeaderText = "Ventas";
            this.ComisionesAutorizacionVentas.MinimumWidth = 6;
            this.ComisionesAutorizacionVentas.Name = "ComisionesAutorizacionVentas";
            this.ComisionesAutorizacionVentas.ReadOnly = true;
            // 
            // ComisionesAutorizacionMonto
            // 
            this.ComisionesAutorizacionMonto.HeaderText = "Monto";
            this.ComisionesAutorizacionMonto.MinimumWidth = 6;
            this.ComisionesAutorizacionMonto.Name = "ComisionesAutorizacionMonto";
            this.ComisionesAutorizacionMonto.ReadOnly = true;
            // 
            // ComisionesAutorizacionSolicitada
            // 
            this.ComisionesAutorizacionSolicitada.HeaderText = "Solicitada";
            this.ComisionesAutorizacionSolicitada.MinimumWidth = 6;
            this.ComisionesAutorizacionSolicitada.Name = "ComisionesAutorizacionSolicitada";
            this.ComisionesAutorizacionSolicitada.ReadOnly = true;
            // 
            // ComisionesAutorizacionEstado
            // 
            this.ComisionesAutorizacionEstado.HeaderText = "Estado";
            this.ComisionesAutorizacionEstado.MinimumWidth = 6;
            this.ComisionesAutorizacionEstado.Name = "ComisionesAutorizacionEstado";
            this.ComisionesAutorizacionEstado.ReadOnly = true;
            // 
            // ComisionesPnlResumen
            // 
            this.ComisionesPnlResumen.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlResumen.Controls.Add(this.ComisionesLblResumenTitulo);
            this.ComisionesPnlResumen.Controls.Add(this.ComisionesLblResumenVendedor);
            this.ComisionesPnlResumen.Controls.Add(this.ComisionesLblResumenPeriodo);
            this.ComisionesPnlResumen.Controls.Add(this.ComisionesLblResumenVentas);
            this.ComisionesPnlResumen.Controls.Add(this.ComisionesLblResumenMonto);
            this.ComisionesPnlResumen.Location = new System.Drawing.Point(24, 286);
            this.ComisionesPnlResumen.Name = "ComisionesPnlResumen";
            this.ComisionesPnlResumen.Size = new System.Drawing.Size(998, 132);
            this.ComisionesPnlResumen.TabIndex = 3;
            // 
            // ComisionesLblResumenTitulo
            // 
            this.ComisionesLblResumenTitulo.AutoSize = true;
            this.ComisionesLblResumenTitulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblResumenTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesLblResumenTitulo.Location = new System.Drawing.Point(18, 16);
            this.ComisionesLblResumenTitulo.Name = "ComisionesLblResumenTitulo";
            this.ComisionesLblResumenTitulo.Size = new System.Drawing.Size(343, 18);
            this.ComisionesLblResumenTitulo.TabIndex = 0;
            this.ComisionesLblResumenTitulo.Text = "RESUMEN DE LA SOLICITUD SELECCIONADA";
            // 
            // ComisionesLblResumenVendedor
            // 
            this.ComisionesLblResumenVendedor.AutoSize = true;
            this.ComisionesLblResumenVendedor.Location = new System.Drawing.Point(20, 50);
            this.ComisionesLblResumenVendedor.Name = "ComisionesLblResumenVendedor";
            this.ComisionesLblResumenVendedor.Size = new System.Drawing.Size(90, 46);
            this.ComisionesLblResumenVendedor.TabIndex = 1;
            this.ComisionesLblResumenVendedor.Text = "Vendedor\nAna López";
            // 
            // ComisionesLblResumenPeriodo
            // 
            this.ComisionesLblResumenPeriodo.AutoSize = true;
            this.ComisionesLblResumenPeriodo.Location = new System.Drawing.Point(240, 50);
            this.ComisionesLblResumenPeriodo.Name = "ComisionesLblResumenPeriodo";
            this.ComisionesLblResumenPeriodo.Size = new System.Drawing.Size(205, 46);
            this.ComisionesLblResumenPeriodo.TabIndex = 2;
            this.ComisionesLblResumenPeriodo.Text = "Periodo\n01/10/2026 al 31/10/2026";
            // 
            // ComisionesLblResumenVentas
            // 
            this.ComisionesLblResumenVentas.AutoSize = true;
            this.ComisionesLblResumenVentas.Location = new System.Drawing.Point(520, 50);
            this.ComisionesLblResumenVentas.Name = "ComisionesLblResumenVentas";
            this.ComisionesLblResumenVentas.Size = new System.Drawing.Size(132, 46);
            this.ComisionesLblResumenVentas.TabIndex = 3;
            this.ComisionesLblResumenVentas.Text = "Ventas elegibles\n12 documentos";
            // 
            // ComisionesLblResumenMonto
            // 
            this.ComisionesLblResumenMonto.AutoSize = true;
            this.ComisionesLblResumenMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ComisionesLblResumenMonto.Location = new System.Drawing.Point(770, 50);
            this.ComisionesLblResumenMonto.Name = "ComisionesLblResumenMonto";
            this.ComisionesLblResumenMonto.Size = new System.Drawing.Size(98, 46);
            this.ComisionesLblResumenMonto.TabIndex = 4;
            this.ComisionesLblResumenMonto.Text = "Comisión\nQ 2,437.50";
            // 
            // ComisionesLblComentario
            // 
            this.ComisionesLblComentario.AutoSize = true;
            this.ComisionesLblComentario.Location = new System.Drawing.Point(24, 432);
            this.ComisionesLblComentario.Name = "ComisionesLblComentario";
            this.ComisionesLblComentario.Size = new System.Drawing.Size(223, 23);
            this.ComisionesLblComentario.TabIndex = 4;
            this.ComisionesLblComentario.Text = "Comentario de autorización";
            // 
            // ComisionesTxtComentario
            // 
            this.ComisionesTxtComentario.Location = new System.Drawing.Point(24, 456);
            this.ComisionesTxtComentario.Name = "ComisionesTxtComentario";
            this.ComisionesTxtComentario.ReadOnly = true;
            this.ComisionesTxtComentario.Size = new System.Drawing.Size(620, 30);
            this.ComisionesTxtComentario.TabIndex = 5;
            this.ComisionesTxtComentario.Text = "Agregar comentario (opcional)";
            // 
            // ComisionesBtnRechazar
            // 
            this.ComisionesBtnRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.ComisionesBtnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnRechazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.ComisionesBtnRechazar.Location = new System.Drawing.Point(665, 452);
            this.ComisionesBtnRechazar.Name = "ComisionesBtnRechazar";
            this.ComisionesBtnRechazar.Size = new System.Drawing.Size(170, 38);
            this.ComisionesBtnRechazar.TabIndex = 6;
            this.ComisionesBtnRechazar.Text = "Rechazar";
            this.ComisionesBtnRechazar.UseVisualStyleBackColor = false;
            // 
            // ComisionesBtnAprobar
            // 
            this.ComisionesBtnAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesBtnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnAprobar.ForeColor = System.Drawing.Color.White;
            this.ComisionesBtnAprobar.Location = new System.Drawing.Point(846, 452);
            this.ComisionesBtnAprobar.Name = "ComisionesBtnAprobar";
            this.ComisionesBtnAprobar.Size = new System.Drawing.Size(176, 38);
            this.ComisionesBtnAprobar.TabIndex = 7;
            this.ComisionesBtnAprobar.Text = "Aprobar comisión";
            this.ComisionesBtnAprobar.UseVisualStyleBackColor = false;
            // 
            // ComisionesPnlPieAutorizacion
            // 
            this.ComisionesPnlPieAutorizacion.BackColor = System.Drawing.Color.White;
            this.ComisionesPnlPieAutorizacion.Controls.Add(this.ComisionesLblAvisoEnvio);
            this.ComisionesPnlPieAutorizacion.Controls.Add(this.ComisionesBtnEnviar);
            this.ComisionesPnlPieAutorizacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComisionesPnlPieAutorizacion.Location = new System.Drawing.Point(10, 462);
            this.ComisionesPnlPieAutorizacion.Name = "ComisionesPnlPieAutorizacion";
            this.ComisionesPnlPieAutorizacion.Size = new System.Drawing.Size(1032, 60);
            this.ComisionesPnlPieAutorizacion.TabIndex = 8;
            // 
            // ComisionesLblAvisoEnvio
            // 
            this.ComisionesLblAvisoEnvio.AutoSize = true;
            this.ComisionesLblAvisoEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.ComisionesLblAvisoEnvio.Location = new System.Drawing.Point(20, 21);
            this.ComisionesLblAvisoEnvio.Name = "ComisionesLblAvisoEnvio";
            this.ComisionesLblAvisoEnvio.Size = new System.Drawing.Size(555, 23);
            this.ComisionesLblAvisoEnvio.TabIndex = 0;
            this.ComisionesLblAvisoEnvio.Text = "Al aprobar, el resumen queda listo para envío a Contabilidad / Nómina.";
            // 
            // ComisionesBtnEnviar
            // 
            this.ComisionesBtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.ComisionesBtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComisionesBtnEnviar.ForeColor = System.Drawing.Color.White;
            this.ComisionesBtnEnviar.Location = new System.Drawing.Point(760, 9);
            this.ComisionesBtnEnviar.Name = "ComisionesBtnEnviar";
            this.ComisionesBtnEnviar.Size = new System.Drawing.Size(262, 42);
            this.ComisionesBtnEnviar.TabIndex = 1;
            this.ComisionesBtnEnviar.Text = "Enviar resumen aprobado";
            this.ComisionesBtnEnviar.UseVisualStyleBackColor = false;
            // 
            // FrmComisionesVendedoresVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.ComisionesTabControl);
            this.Controls.Add(this.ComisionesPnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::CapaVista_Ventas.Properties.Resources.IconoVentas;
            this.MaximizeBox = false;
            this.Name = "FrmComisionesVendedoresVentas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "7008 – ComisionesVendedores";
            this.ComisionesPnlEncabezado.ResumeLayout(false);
            this.ComisionesPnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesPicMarca)).EndInit();
            this.ComisionesTabControl.ResumeLayout(false);
            this.ComisionesTabCalculo.ResumeLayout(false);
            this.ComisionesTabCalculo.PerformLayout();
            this.ComisionesPnlCardVentas.ResumeLayout(false);
            this.ComisionesPnlCardVentas.PerformLayout();
            this.ComisionesPnlCardMonto.ResumeLayout(false);
            this.ComisionesPnlCardMonto.PerformLayout();
            this.ComisionesPnlCardEstado.ResumeLayout(false);
            this.ComisionesPnlCardEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesDgvVentas)).EndInit();
            this.ComisionesPnlPieCalculo.ResumeLayout(false);
            this.ComisionesPnlPieCalculo.PerformLayout();
            this.ComisionesTabConsulta.ResumeLayout(false);
            this.ComisionesTabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesDgvHistorial)).EndInit();
            this.ComisionesPnlHistorialCard1.ResumeLayout(false);
            this.ComisionesPnlHistorialCard1.PerformLayout();
            this.ComisionesPnlHistorialCard2.ResumeLayout(false);
            this.ComisionesPnlHistorialCard2.PerformLayout();
            this.ComisionesPnlHistorialCard3.ResumeLayout(false);
            this.ComisionesPnlHistorialCard3.PerformLayout();
            this.ComisionesTabAutorizacion.ResumeLayout(false);
            this.ComisionesTabAutorizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComisionesDgvAutorizacion)).EndInit();
            this.ComisionesPnlResumen.ResumeLayout(false);
            this.ComisionesPnlResumen.PerformLayout();
            this.ComisionesPnlPieAutorizacion.ResumeLayout(false);
            this.ComisionesPnlPieAutorizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVentaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVentaDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVentaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVentaBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVentaTasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVentaImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVentaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesHistorialPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesHistorialVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesHistorialVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesHistorialImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesHistorialDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesHistorialEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesAutorizacionPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesAutorizacionVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesAutorizacionVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesAutorizacionMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesAutorizacionSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesAutorizacionEstado;
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 12/10/2026
