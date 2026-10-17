namespace CapaVista_Compras
{
    partial class FrmMDICompras
    {
        private System.ComponentModel.IContainer _Componentes = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && _Componentes != null) _Componentes.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDICompras));
            this._ComprasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this._ComprasTlpNavegador = new System.Windows.Forms.TableLayoutPanel();
            this._ComprasPbMarca = new System.Windows.Forms.PictureBox();
            this._ComprasTlpMovimientosProveedores = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoMovimientosProveedores = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblMovimientosProveedores = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpPolizas = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoPolizas = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblPolizas = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpProveedores = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoProveedores = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblProveedores = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpMetodosPago = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoMetodosPago = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblMetodosPago = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpOrdenesCompra = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoOrdenesCompra = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblOrdenesCompra = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpPagosProveedores = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoPagosProveedores = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblPagosProveedores = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpAprobacionFinanciera = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoAprobacionFinanciera = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblAprobacionFinanciera = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpCierreMovimientos = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoCierreMovimientos = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblCierreMovimientos = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpBitacora = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoBitacora = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblBitacora = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpSalir = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoSalir = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblSalir = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasLblUsuarioRol = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasBtnAlternarNavegador = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasPnlMain = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasPnlDashboard = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpDashboard = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasTlpHero = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasTlpPresentacion = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasLblBienvenido = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblModulo = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblParrafo = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasBtnAyuda = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasPbMascota = new System.Windows.Forms.PictureBox();
            this.ComprasPbIcono = new System.Windows.Forms.PictureBox();
            this.ComprasLblResumen = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTlpKpis = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPnlKpi1 = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpKpi1 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPbKpi1 = new System.Windows.Forms.PictureBox();
            this.ComprasLblValorKpi1 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblKpi1 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasPnlKpi2 = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpKpi2 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPbKpi2 = new System.Windows.Forms.PictureBox();
            this.ComprasLblValorKpi2 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblKpi2 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasPnlKpi3 = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpKpi3 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPbKpi3 = new System.Windows.Forms.PictureBox();
            this.ComprasLblValorKpi3 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblKpi3 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasPnlKpi4 = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpKpi4 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPbKpi4 = new System.Windows.Forms.PictureBox();
            this.ComprasLblValorKpi4 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblKpi4 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasPnlKpi5 = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpKpi5 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPbKpi5 = new System.Windows.Forms.PictureBox();
            this.ComprasLblValorKpi5 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblKpi5 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasPnlKpi6 = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpKpi6 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPbKpi6 = new System.Windows.Forms.PictureBox();
            this.ComprasLblValorKpi6 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblKpi6 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasPnlInformacion = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasTlpInformacion = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasLblInformacion = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblIntegracion = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasTlpPrincipal.SuspendLayout();
            this._ComprasTlpNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).BeginInit();
            this._ComprasTlpMovimientosProveedores.SuspendLayout();
            this._ComprasTlpPolizas.SuspendLayout();
            this._ComprasTlpProveedores.SuspendLayout();
            this._ComprasTlpMetodosPago.SuspendLayout();
            this._ComprasTlpOrdenesCompra.SuspendLayout();
            this._ComprasTlpPagosProveedores.SuspendLayout();
            this._ComprasTlpAprobacionFinanciera.SuspendLayout();
            this._ComprasTlpCierreMovimientos.SuspendLayout();
            this._ComprasTlpBitacora.SuspendLayout();
            this._ComprasTlpSalir.SuspendLayout();
            this._ComprasTlpEncabezado.SuspendLayout();
            this._ComprasPnlMain.SuspendLayout();
            this.ComprasPnlDashboard.SuspendLayout();
            this.ComprasTlpDashboard.SuspendLayout();
            this.ComprasTlpHero.SuspendLayout();
            this.ComprasTlpPresentacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbIcono)).BeginInit();
            this.ComprasTlpKpis.SuspendLayout();
            this.ComprasPnlKpi1.SuspendLayout();
            this.ComprasTlpKpi1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi1)).BeginInit();
            this.ComprasPnlKpi2.SuspendLayout();
            this.ComprasTlpKpi2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi2)).BeginInit();
            this.ComprasPnlKpi3.SuspendLayout();
            this.ComprasTlpKpi3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi3)).BeginInit();
            this.ComprasPnlKpi4.SuspendLayout();
            this.ComprasTlpKpi4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi4)).BeginInit();
            this.ComprasPnlKpi5.SuspendLayout();
            this.ComprasTlpKpi5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi5)).BeginInit();
            this.ComprasPnlKpi6.SuspendLayout();
            this.ComprasTlpKpi6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi6)).BeginInit();
            this.ComprasPnlInformacion.SuspendLayout();
            this.ComprasTlpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ComprasTlpPrincipal
            // 
            this._ComprasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpPrincipal.ColumnCount = 2;
            this._ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this._ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasTlpNavegador, 0, 0);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasTlpEncabezado, 1, 0);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasPnlMain, 1, 1);
            this._ComprasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpPrincipal.Name = "_ComprasTlpPrincipal";
            this._ComprasTlpPrincipal.Padding = new System.Windows.Forms.Padding(14);
            this._ComprasTlpPrincipal.RowCount = 2;
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.Size = new System.Drawing.Size(1554, 853);
            this._ComprasTlpPrincipal.TabIndex = 0;
            // 
            // _ComprasTlpNavegador
            // 
            this._ComprasTlpNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpNavegador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpNavegador.BackgroundImage")));
            this._ComprasTlpNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpNavegador.ColumnCount = 1;
            this._ComprasTlpNavegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpNavegador.Controls.Add(this._ComprasPbMarca, 0, 0);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpMovimientosProveedores, 0, 1);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpPolizas, 0, 2);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpProveedores, 0, 3);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpMetodosPago, 0, 4);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpOrdenesCompra, 0, 5);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpPagosProveedores, 0, 6);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpAprobacionFinanciera, 0, 7);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpCierreMovimientos, 0, 8);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpBitacora, 0, 9);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasTlpSalir, 0, 10);
            this._ComprasTlpNavegador.Dock = System.Windows.Forms.DockStyle.Left;
            this._ComprasTlpNavegador.Location = new System.Drawing.Point(14, 14);
            this._ComprasTlpNavegador.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpNavegador.Name = "_ComprasTlpNavegador";
            this._ComprasTlpNavegador.Padding = new System.Windows.Forms.Padding(6, 8, 6, 37);
            this._ComprasTlpNavegador.RowCount = 11;
            this._ComprasTlpPrincipal.SetRowSpan(this._ComprasTlpNavegador, 2);
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._ComprasTlpNavegador.Size = new System.Drawing.Size(270, 825);
            this._ComprasTlpNavegador.TabIndex = 0;
            // 
            // _ComprasPbMarca
            // 
            this._ComprasPbMarca.BackColor = System.Drawing.Color.Transparent;
            this._ComprasPbMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasPbMarca.BackgroundImage")));
            this._ComprasPbMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasPbMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPbMarca.Location = new System.Drawing.Point(70, 8);
            this._ComprasPbMarca.Margin = new System.Windows.Forms.Padding(64, 0, 64, 10);
            this._ComprasPbMarca.Name = "_ComprasPbMarca";
            this._ComprasPbMarca.Size = new System.Drawing.Size(130, 90);
            this._ComprasPbMarca.TabIndex = 0;
            this._ComprasPbMarca.TabStop = false;
            // 
            // _ComprasTlpMovimientosProveedores
            // 
            this._ComprasTlpMovimientosProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpMovimientosProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMovimientosProveedores.BackgroundImage")));
            this._ComprasTlpMovimientosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpMovimientosProveedores.ColumnCount = 2;
            this._ComprasTlpMovimientosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpMovimientosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMovimientosProveedores.Controls.Add(this._ComprasBtnIconoMovimientosProveedores, 0, 0);
            this._ComprasTlpMovimientosProveedores.Controls.Add(this._ComprasLblMovimientosProveedores, 1, 0);
            this._ComprasTlpMovimientosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpMovimientosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpMovimientosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpMovimientosProveedores.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMovimientosProveedores.ImagenHover")));
            this._ComprasTlpMovimientosProveedores.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMovimientosProveedores.ImagenNormal")));
            this._ComprasTlpMovimientosProveedores.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMovimientosProveedores.ImagenSeleccionado")));
            this._ComprasTlpMovimientosProveedores.Location = new System.Drawing.Point(6, 110);
            this._ComprasTlpMovimientosProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpMovimientosProveedores.Name = "_ComprasTlpMovimientosProveedores";
            this._ComprasTlpMovimientosProveedores.RowCount = 1;
            this._ComprasTlpMovimientosProveedores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMovimientosProveedores.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpMovimientosProveedores.TabIndex = 1;
            this._ComprasTlpMovimientosProveedores.Click += new System.EventHandler(this.ComprasMetAbrirMovimientosProveedores);
            this._ComprasBtnIconoMovimientosProveedores.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoMovimientosProveedores
            // 
            this._ComprasBtnIconoMovimientosProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnIconoMovimientosProveedores.AplicarColoresEstado = false;
            this._ComprasBtnIconoMovimientosProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoMovimientosProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoMovimientosProveedores.BackgroundImage")));
            this._ComprasBtnIconoMovimientosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoMovimientosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoMovimientosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoMovimientosProveedores.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnIconoMovimientosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMovimientosProveedores.Location = new System.Drawing.Point(2, 7);
            this._ComprasBtnIconoMovimientosProveedores.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoMovimientosProveedores.Name = "_ComprasBtnIconoMovimientosProveedores";
            this._ComprasBtnIconoMovimientosProveedores.Size = new System.Drawing.Size(60, 49);
            this._ComprasBtnIconoMovimientosProveedores.TabIndex = 0;
            this._ComprasBtnIconoMovimientosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoMovimientosProveedores.Click += new System.EventHandler(this.ComprasMetAbrirMovimientosProveedores);
            // 
            // _ComprasLblMovimientosProveedores
            // 
            this._ComprasLblMovimientosProveedores.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblMovimientosProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblMovimientosProveedores.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblMovimientosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblMovimientosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblMovimientosProveedores.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblMovimientosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblMovimientosProveedores.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblMovimientosProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblMovimientosProveedores.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblMovimientosProveedores.MostrarAsterisco = false;
            this._ComprasLblMovimientosProveedores.Name = "_ComprasLblMovimientosProveedores";
            this._ComprasLblMovimientosProveedores.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblMovimientosProveedores.TabIndex = 1;
            this._ComprasLblMovimientosProveedores.TabStop = false;
            this._ComprasLblMovimientosProveedores.TamanoTipografia = 10F;
            this._ComprasLblMovimientosProveedores.Text = "Movimientos de Proveedores";
            this._ComprasLblMovimientosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblMovimientosProveedores.Texto = "Movimientos de Proveedores";
            this._ComprasLblMovimientosProveedores.Click += new System.EventHandler(this.ComprasMetAbrirMovimientosProveedores);
            // 
            // _ComprasTlpPolizas
            // 
            this._ComprasTlpPolizas.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpPolizas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPolizas.BackgroundImage")));
            this._ComprasTlpPolizas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpPolizas.ColumnCount = 2;
            this._ComprasTlpPolizas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpPolizas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPolizas.Controls.Add(this._ComprasBtnIconoPolizas, 0, 0);
            this._ComprasTlpPolizas.Controls.Add(this._ComprasLblPolizas, 1, 0);
            this._ComprasTlpPolizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpPolizas.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPolizas.ImagenHover")));
            this._ComprasTlpPolizas.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPolizas.ImagenNormal")));
            this._ComprasTlpPolizas.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPolizas.ImagenSeleccionado")));
            this._ComprasTlpPolizas.Location = new System.Drawing.Point(6, 178);
            this._ComprasTlpPolizas.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpPolizas.Name = "_ComprasTlpPolizas";
            this._ComprasTlpPolizas.RowCount = 1;
            this._ComprasTlpPolizas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPolizas.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpPolizas.TabIndex = 2;
            this._ComprasTlpPolizas.Click += new System.EventHandler(this.ComprasMetAbrirPolizas);
            this._ComprasBtnIconoPolizas.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoPolizas
            // 
            this._ComprasBtnIconoPolizas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoPolizas.AplicarColoresEstado = false;
            this._ComprasBtnIconoPolizas.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoPolizas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoPolizas.BackgroundImage")));
            this._ComprasBtnIconoPolizas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoPolizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoPolizas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoPolizas.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoPolizas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoPolizas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoPolizas.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnIconoPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoPolizas.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoPolizas.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoPolizas.Name = "_ComprasBtnIconoPolizas";
            this._ComprasBtnIconoPolizas.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoPolizas.TabIndex = 0;
            this._ComprasBtnIconoPolizas.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoPolizas.Click += new System.EventHandler(this.ComprasMetAbrirPolizas);
            // 
            // _ComprasLblPolizas
            // 
            this._ComprasLblPolizas.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblPolizas.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblPolizas.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblPolizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblPolizas.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblPolizas.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblPolizas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblPolizas.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblPolizas.MostrarAsterisco = false;
            this._ComprasLblPolizas.Name = "_ComprasLblPolizas";
            this._ComprasLblPolizas.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblPolizas.TabIndex = 1;
            this._ComprasLblPolizas.TabStop = false;
            this._ComprasLblPolizas.TamanoTipografia = 10F;
            this._ComprasLblPolizas.Text = "Pólizas";
            this._ComprasLblPolizas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblPolizas.Texto = "Pólizas";
            this._ComprasLblPolizas.Click += new System.EventHandler(this.ComprasMetAbrirPolizas);
            // 
            // _ComprasTlpProveedores
            // 
            this._ComprasTlpProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpProveedores.BackgroundImage")));
            this._ComprasTlpProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpProveedores.ColumnCount = 2;
            this._ComprasTlpProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpProveedores.Controls.Add(this._ComprasBtnIconoProveedores, 0, 0);
            this._ComprasTlpProveedores.Controls.Add(this._ComprasLblProveedores, 1, 0);
            this._ComprasTlpProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpProveedores.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpProveedores.ImagenHover")));
            this._ComprasTlpProveedores.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpProveedores.ImagenNormal")));
            this._ComprasTlpProveedores.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpProveedores.ImagenSeleccionado")));
            this._ComprasTlpProveedores.Location = new System.Drawing.Point(6, 246);
            this._ComprasTlpProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpProveedores.Name = "_ComprasTlpProveedores";
            this._ComprasTlpProveedores.RowCount = 1;
            this._ComprasTlpProveedores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpProveedores.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpProveedores.TabIndex = 3;
            this._ComprasTlpProveedores.Click += new System.EventHandler(this.ComprasMetAbrirProveedores);
            this._ComprasBtnIconoProveedores.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoProveedores
            // 
            this._ComprasBtnIconoProveedores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoProveedores.AplicarColoresEstado = false;
            this._ComprasBtnIconoProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoProveedores.BackgroundImage")));
            this._ComprasBtnIconoProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoProveedores.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoProveedores.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoProveedores.Name = "_ComprasBtnIconoProveedores";
            this._ComprasBtnIconoProveedores.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoProveedores.TabIndex = 0;
            this._ComprasBtnIconoProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoProveedores.Click += new System.EventHandler(this.ComprasMetAbrirProveedores);
            // 
            // _ComprasLblProveedores
            // 
            this._ComprasLblProveedores.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblProveedores.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblProveedores.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblProveedores.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblProveedores.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblProveedores.MostrarAsterisco = false;
            this._ComprasLblProveedores.Name = "_ComprasLblProveedores";
            this._ComprasLblProveedores.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblProveedores.TabIndex = 1;
            this._ComprasLblProveedores.TabStop = false;
            this._ComprasLblProveedores.TamanoTipografia = 10F;
            this._ComprasLblProveedores.Text = "Proveedores";
            this._ComprasLblProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblProveedores.Texto = "Proveedores";
            this._ComprasLblProveedores.Click += new System.EventHandler(this.ComprasMetAbrirProveedores);
            // 
            // _ComprasTlpMetodosPago
            // 
            this._ComprasTlpMetodosPago.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpMetodosPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMetodosPago.BackgroundImage")));
            this._ComprasTlpMetodosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpMetodosPago.ColumnCount = 2;
            this._ComprasTlpMetodosPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpMetodosPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMetodosPago.Controls.Add(this._ComprasBtnIconoMetodosPago, 0, 0);
            this._ComprasTlpMetodosPago.Controls.Add(this._ComprasLblMetodosPago, 1, 0);
            this._ComprasTlpMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpMetodosPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpMetodosPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpMetodosPago.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMetodosPago.ImagenHover")));
            this._ComprasTlpMetodosPago.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMetodosPago.ImagenNormal")));
            this._ComprasTlpMetodosPago.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpMetodosPago.ImagenSeleccionado")));
            this._ComprasTlpMetodosPago.Location = new System.Drawing.Point(6, 314);
            this._ComprasTlpMetodosPago.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpMetodosPago.Name = "_ComprasTlpMetodosPago";
            this._ComprasTlpMetodosPago.RowCount = 1;
            this._ComprasTlpMetodosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMetodosPago.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpMetodosPago.TabIndex = 4;
            this._ComprasTlpMetodosPago.Click += new System.EventHandler(this.ComprasMetAbrirMetodosPago);
            this._ComprasBtnIconoMetodosPago.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoMetodosPago
            // 
            this._ComprasBtnIconoMetodosPago.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoMetodosPago.AplicarColoresEstado = false;
            this._ComprasBtnIconoMetodosPago.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoMetodosPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoMetodosPago.BackgroundImage")));
            this._ComprasBtnIconoMetodosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoMetodosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoMetodosPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMetodosPago.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoMetodosPago.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoMetodosPago.Name = "_ComprasBtnIconoMetodosPago";
            this._ComprasBtnIconoMetodosPago.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoMetodosPago.TabIndex = 0;
            this._ComprasBtnIconoMetodosPago.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoMetodosPago.Click += new System.EventHandler(this.ComprasMetAbrirMetodosPago);
            // 
            // _ComprasLblMetodosPago
            // 
            this._ComprasLblMetodosPago.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblMetodosPago.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblMetodosPago.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblMetodosPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblMetodosPago.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblMetodosPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblMetodosPago.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblMetodosPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblMetodosPago.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblMetodosPago.MostrarAsterisco = false;
            this._ComprasLblMetodosPago.Name = "_ComprasLblMetodosPago";
            this._ComprasLblMetodosPago.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblMetodosPago.TabIndex = 1;
            this._ComprasLblMetodosPago.TabStop = false;
            this._ComprasLblMetodosPago.TamanoTipografia = 10F;
            this._ComprasLblMetodosPago.Text = "Métodos de Pago";
            this._ComprasLblMetodosPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblMetodosPago.Texto = "Métodos de Pago";
            this._ComprasLblMetodosPago.Click += new System.EventHandler(this.ComprasMetAbrirMetodosPago);
            // 
            // _ComprasTlpOrdenesCompra
            // 
            this._ComprasTlpOrdenesCompra.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpOrdenesCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpOrdenesCompra.BackgroundImage")));
            this._ComprasTlpOrdenesCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpOrdenesCompra.ColumnCount = 2;
            this._ComprasTlpOrdenesCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpOrdenesCompra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpOrdenesCompra.Controls.Add(this._ComprasBtnIconoOrdenesCompra, 0, 0);
            this._ComprasTlpOrdenesCompra.Controls.Add(this._ComprasLblOrdenesCompra, 1, 0);
            this._ComprasTlpOrdenesCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpOrdenesCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpOrdenesCompra.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpOrdenesCompra.ImagenHover")));
            this._ComprasTlpOrdenesCompra.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpOrdenesCompra.ImagenNormal")));
            this._ComprasTlpOrdenesCompra.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpOrdenesCompra.ImagenSeleccionado")));
            this._ComprasTlpOrdenesCompra.Location = new System.Drawing.Point(6, 382);
            this._ComprasTlpOrdenesCompra.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpOrdenesCompra.Name = "_ComprasTlpOrdenesCompra";
            this._ComprasTlpOrdenesCompra.RowCount = 1;
            this._ComprasTlpOrdenesCompra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpOrdenesCompra.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpOrdenesCompra.TabIndex = 5;
            this._ComprasTlpOrdenesCompra.Click += new System.EventHandler(this.ComprasMetAbrirOrdenesCompra);
            this._ComprasBtnIconoOrdenesCompra.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoOrdenesCompra
            // 
            this._ComprasBtnIconoOrdenesCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoOrdenesCompra.AplicarColoresEstado = false;
            this._ComprasBtnIconoOrdenesCompra.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoOrdenesCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoOrdenesCompra.BackgroundImage")));
            this._ComprasBtnIconoOrdenesCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoOrdenesCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoOrdenesCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoOrdenesCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoOrdenesCompra.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoOrdenesCompra.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoOrdenesCompra.Name = "_ComprasBtnIconoOrdenesCompra";
            this._ComprasBtnIconoOrdenesCompra.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoOrdenesCompra.TabIndex = 0;
            this._ComprasBtnIconoOrdenesCompra.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoOrdenesCompra.Click += new System.EventHandler(this.ComprasMetAbrirOrdenesCompra);
            // 
            // _ComprasLblOrdenesCompra
            // 
            this._ComprasLblOrdenesCompra.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblOrdenesCompra.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblOrdenesCompra.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblOrdenesCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblOrdenesCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblOrdenesCompra.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblOrdenesCompra.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblOrdenesCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblOrdenesCompra.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblOrdenesCompra.MostrarAsterisco = false;
            this._ComprasLblOrdenesCompra.Name = "_ComprasLblOrdenesCompra";
            this._ComprasLblOrdenesCompra.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblOrdenesCompra.TabIndex = 1;
            this._ComprasLblOrdenesCompra.TabStop = false;
            this._ComprasLblOrdenesCompra.TamanoTipografia = 10F;
            this._ComprasLblOrdenesCompra.Text = "Órdenes de Compra";
            this._ComprasLblOrdenesCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblOrdenesCompra.Texto = "Órdenes de Compra";
            this._ComprasLblOrdenesCompra.Click += new System.EventHandler(this.ComprasMetAbrirOrdenesCompra);
            // 
            // _ComprasTlpPagosProveedores
            // 
            this._ComprasTlpPagosProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpPagosProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPagosProveedores.BackgroundImage")));
            this._ComprasTlpPagosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpPagosProveedores.ColumnCount = 2;
            this._ComprasTlpPagosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpPagosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPagosProveedores.Controls.Add(this._ComprasBtnIconoPagosProveedores, 0, 0);
            this._ComprasTlpPagosProveedores.Controls.Add(this._ComprasLblPagosProveedores, 1, 0);
            this._ComprasTlpPagosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpPagosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpPagosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpPagosProveedores.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPagosProveedores.ImagenHover")));
            this._ComprasTlpPagosProveedores.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPagosProveedores.ImagenNormal")));
            this._ComprasTlpPagosProveedores.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpPagosProveedores.ImagenSeleccionado")));
            this._ComprasTlpPagosProveedores.Location = new System.Drawing.Point(6, 450);
            this._ComprasTlpPagosProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpPagosProveedores.Name = "_ComprasTlpPagosProveedores";
            this._ComprasTlpPagosProveedores.RowCount = 1;
            this._ComprasTlpPagosProveedores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPagosProveedores.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpPagosProveedores.TabIndex = 6;
            this._ComprasTlpPagosProveedores.Click += new System.EventHandler(this.ComprasMetAbrirPagosProveedores);
            this._ComprasBtnIconoPagosProveedores.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoPagosProveedores
            // 
            this._ComprasBtnIconoPagosProveedores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoPagosProveedores.AplicarColoresEstado = false;
            this._ComprasBtnIconoPagosProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoPagosProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoPagosProveedores.BackgroundImage")));
            this._ComprasBtnIconoPagosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoPagosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoPagosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoPagosProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoPagosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoPagosProveedores.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoPagosProveedores.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoPagosProveedores.Name = "_ComprasBtnIconoPagosProveedores";
            this._ComprasBtnIconoPagosProveedores.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoPagosProveedores.TabIndex = 0;
            this._ComprasBtnIconoPagosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoPagosProveedores.Click += new System.EventHandler(this.ComprasMetAbrirPagosProveedores);
            // 
            // _ComprasLblPagosProveedores
            // 
            this._ComprasLblPagosProveedores.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblPagosProveedores.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblPagosProveedores.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblPagosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblPagosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblPagosProveedores.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblPagosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblPagosProveedores.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblPagosProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblPagosProveedores.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblPagosProveedores.MostrarAsterisco = false;
            this._ComprasLblPagosProveedores.Name = "_ComprasLblPagosProveedores";
            this._ComprasLblPagosProveedores.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblPagosProveedores.TabIndex = 1;
            this._ComprasLblPagosProveedores.TabStop = false;
            this._ComprasLblPagosProveedores.TamanoTipografia = 10F;
            this._ComprasLblPagosProveedores.Text = "Pagos a Proveedores";
            this._ComprasLblPagosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblPagosProveedores.Texto = "Pagos a Proveedores";
            this._ComprasLblPagosProveedores.Click += new System.EventHandler(this.ComprasMetAbrirPagosProveedores);
            // 
            // _ComprasTlpAprobacionFinanciera
            // 
            this._ComprasTlpAprobacionFinanciera.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpAprobacionFinanciera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpAprobacionFinanciera.BackgroundImage")));
            this._ComprasTlpAprobacionFinanciera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpAprobacionFinanciera.ColumnCount = 2;
            this._ComprasTlpAprobacionFinanciera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpAprobacionFinanciera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpAprobacionFinanciera.Controls.Add(this._ComprasBtnIconoAprobacionFinanciera, 0, 0);
            this._ComprasTlpAprobacionFinanciera.Controls.Add(this._ComprasLblAprobacionFinanciera, 1, 0);
            this._ComprasTlpAprobacionFinanciera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpAprobacionFinanciera.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpAprobacionFinanciera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpAprobacionFinanciera.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpAprobacionFinanciera.ImagenHover")));
            this._ComprasTlpAprobacionFinanciera.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpAprobacionFinanciera.ImagenNormal")));
            this._ComprasTlpAprobacionFinanciera.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpAprobacionFinanciera.ImagenSeleccionado")));
            this._ComprasTlpAprobacionFinanciera.Location = new System.Drawing.Point(6, 518);
            this._ComprasTlpAprobacionFinanciera.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpAprobacionFinanciera.Name = "_ComprasTlpAprobacionFinanciera";
            this._ComprasTlpAprobacionFinanciera.RowCount = 1;
            this._ComprasTlpAprobacionFinanciera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpAprobacionFinanciera.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpAprobacionFinanciera.TabIndex = 7;
            this._ComprasTlpAprobacionFinanciera.Click += new System.EventHandler(this.ComprasMetAbrirAprobacionFinanciera);
            this._ComprasBtnIconoAprobacionFinanciera.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoAprobacionFinanciera
            // 
            this._ComprasBtnIconoAprobacionFinanciera.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoAprobacionFinanciera.AplicarColoresEstado = false;
            this._ComprasBtnIconoAprobacionFinanciera.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoAprobacionFinanciera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoAprobacionFinanciera.BackgroundImage")));
            this._ComprasBtnIconoAprobacionFinanciera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoAprobacionFinanciera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoAprobacionFinanciera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoAprobacionFinanciera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoAprobacionFinanciera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoAprobacionFinanciera.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoAprobacionFinanciera.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoAprobacionFinanciera.Name = "_ComprasBtnIconoAprobacionFinanciera";
            this._ComprasBtnIconoAprobacionFinanciera.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoAprobacionFinanciera.TabIndex = 0;
            this._ComprasBtnIconoAprobacionFinanciera.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoAprobacionFinanciera.Click += new System.EventHandler(this.ComprasMetAbrirAprobacionFinanciera);
            // 
            // _ComprasLblAprobacionFinanciera
            // 
            this._ComprasLblAprobacionFinanciera.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblAprobacionFinanciera.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblAprobacionFinanciera.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblAprobacionFinanciera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblAprobacionFinanciera.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblAprobacionFinanciera.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblAprobacionFinanciera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblAprobacionFinanciera.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblAprobacionFinanciera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblAprobacionFinanciera.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblAprobacionFinanciera.MostrarAsterisco = false;
            this._ComprasLblAprobacionFinanciera.Name = "_ComprasLblAprobacionFinanciera";
            this._ComprasLblAprobacionFinanciera.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblAprobacionFinanciera.TabIndex = 1;
            this._ComprasLblAprobacionFinanciera.TabStop = false;
            this._ComprasLblAprobacionFinanciera.TamanoTipografia = 10F;
            this._ComprasLblAprobacionFinanciera.Text = "Aprobación Financiera";
            this._ComprasLblAprobacionFinanciera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblAprobacionFinanciera.Texto = "Aprobación Financiera";
            this._ComprasLblAprobacionFinanciera.Click += new System.EventHandler(this.ComprasMetAbrirAprobacionFinanciera);
            // 
            // _ComprasTlpCierreMovimientos
            // 
            this._ComprasTlpCierreMovimientos.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpCierreMovimientos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpCierreMovimientos.BackgroundImage")));
            this._ComprasTlpCierreMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpCierreMovimientos.ColumnCount = 2;
            this._ComprasTlpCierreMovimientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpCierreMovimientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpCierreMovimientos.Controls.Add(this._ComprasBtnIconoCierreMovimientos, 0, 0);
            this._ComprasTlpCierreMovimientos.Controls.Add(this._ComprasLblCierreMovimientos, 1, 0);
            this._ComprasTlpCierreMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpCierreMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpCierreMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpCierreMovimientos.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpCierreMovimientos.ImagenHover")));
            this._ComprasTlpCierreMovimientos.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpCierreMovimientos.ImagenNormal")));
            this._ComprasTlpCierreMovimientos.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpCierreMovimientos.ImagenSeleccionado")));
            this._ComprasTlpCierreMovimientos.Location = new System.Drawing.Point(6, 586);
            this._ComprasTlpCierreMovimientos.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpCierreMovimientos.Name = "_ComprasTlpCierreMovimientos";
            this._ComprasTlpCierreMovimientos.RowCount = 1;
            this._ComprasTlpCierreMovimientos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpCierreMovimientos.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpCierreMovimientos.TabIndex = 8;
            this._ComprasTlpCierreMovimientos.Click += new System.EventHandler(this.ComprasMetAbrirCierreMovimientos);
            this._ComprasBtnIconoCierreMovimientos.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoCierreMovimientos
            // 
            this._ComprasBtnIconoCierreMovimientos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoCierreMovimientos.AplicarColoresEstado = false;
            this._ComprasBtnIconoCierreMovimientos.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoCierreMovimientos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoCierreMovimientos.BackgroundImage")));
            this._ComprasBtnIconoCierreMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoCierreMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoCierreMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoCierreMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoCierreMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoCierreMovimientos.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoCierreMovimientos.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoCierreMovimientos.Name = "_ComprasBtnIconoCierreMovimientos";
            this._ComprasBtnIconoCierreMovimientos.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoCierreMovimientos.TabIndex = 0;
            this._ComprasBtnIconoCierreMovimientos.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoCierreMovimientos.Click += new System.EventHandler(this.ComprasMetAbrirCierreMovimientos);
            // 
            // _ComprasLblCierreMovimientos
            // 
            this._ComprasLblCierreMovimientos.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblCierreMovimientos.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblCierreMovimientos.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblCierreMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblCierreMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblCierreMovimientos.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblCierreMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblCierreMovimientos.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblCierreMovimientos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblCierreMovimientos.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblCierreMovimientos.MostrarAsterisco = false;
            this._ComprasLblCierreMovimientos.Name = "_ComprasLblCierreMovimientos";
            this._ComprasLblCierreMovimientos.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblCierreMovimientos.TabIndex = 1;
            this._ComprasLblCierreMovimientos.TabStop = false;
            this._ComprasLblCierreMovimientos.TamanoTipografia = 10F;
            this._ComprasLblCierreMovimientos.Text = "Cierre de Movimientos";
            this._ComprasLblCierreMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblCierreMovimientos.Texto = "Cierre de Movimientos";
            this._ComprasLblCierreMovimientos.Click += new System.EventHandler(this.ComprasMetAbrirCierreMovimientos);
            // 
            // _ComprasTlpBitacora
            // 
            this._ComprasTlpBitacora.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpBitacora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpBitacora.BackgroundImage")));
            this._ComprasTlpBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpBitacora.ColumnCount = 2;
            this._ComprasTlpBitacora.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpBitacora.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpBitacora.Controls.Add(this._ComprasBtnIconoBitacora, 0, 0);
            this._ComprasTlpBitacora.Controls.Add(this._ComprasLblBitacora, 1, 0);
            this._ComprasTlpBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpBitacora.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpBitacora.ImagenHover")));
            this._ComprasTlpBitacora.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpBitacora.ImagenNormal")));
            this._ComprasTlpBitacora.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpBitacora.ImagenSeleccionado")));
            this._ComprasTlpBitacora.Location = new System.Drawing.Point(6, 654);
            this._ComprasTlpBitacora.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpBitacora.Name = "_ComprasTlpBitacora";
            this._ComprasTlpBitacora.RowCount = 1;
            this._ComprasTlpBitacora.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpBitacora.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpBitacora.TabIndex = 9;
            this._ComprasTlpBitacora.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoBitacora.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoBitacora
            // 
            this._ComprasBtnIconoBitacora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoBitacora.AplicarColoresEstado = false;
            this._ComprasBtnIconoBitacora.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoBitacora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoBitacora.BackgroundImage")));
            this._ComprasBtnIconoBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoBitacora.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoBitacora.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoBitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoBitacora.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoBitacora.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoBitacora.Name = "_ComprasBtnIconoBitacora";
            this._ComprasBtnIconoBitacora.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoBitacora.TabIndex = 0;
            this._ComprasBtnIconoBitacora.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoBitacora.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            // 
            // _ComprasLblBitacora
            // 
            this._ComprasLblBitacora.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblBitacora.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblBitacora.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblBitacora.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblBitacora.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblBitacora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblBitacora.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblBitacora.MostrarAsterisco = false;
            this._ComprasLblBitacora.Name = "_ComprasLblBitacora";
            this._ComprasLblBitacora.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblBitacora.TabIndex = 1;
            this._ComprasLblBitacora.TabStop = false;
            this._ComprasLblBitacora.TamanoTipografia = 10F;
            this._ComprasLblBitacora.Text = "Bitácora";
            this._ComprasLblBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblBitacora.Texto = "Bitácora";
            this._ComprasLblBitacora.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            // 
            // _ComprasTlpSalir
            // 
            this._ComprasTlpSalir.BackColor = System.Drawing.Color.Transparent;
            this._ComprasTlpSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpSalir.BackgroundImage")));
            this._ComprasTlpSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpSalir.ColumnCount = 2;
            this._ComprasTlpSalir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this._ComprasTlpSalir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpSalir.Controls.Add(this._ComprasBtnIconoSalir, 0, 0);
            this._ComprasTlpSalir.Controls.Add(this._ComprasLblSalir, 1, 0);
            this._ComprasTlpSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasTlpSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpSalir.ImagenHover = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpSalir.ImagenHover")));
            this._ComprasTlpSalir.ImagenNormal = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpSalir.ImagenNormal")));
            this._ComprasTlpSalir.ImagenSeleccionado = ((System.Drawing.Image)(resources.GetObject("_ComprasTlpSalir.ImagenSeleccionado")));
            this._ComprasTlpSalir.Location = new System.Drawing.Point(6, 722);
            this._ComprasTlpSalir.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasTlpSalir.Name = "_ComprasTlpSalir";
            this._ComprasTlpSalir.RowCount = 1;
            this._ComprasTlpSalir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpSalir.Size = new System.Drawing.Size(258, 64);
            this._ComprasTlpSalir.TabIndex = 10;
            this._ComprasTlpSalir.Click += new System.EventHandler(this.ComprasBtnSalir_Click);
            this._ComprasBtnIconoSalir.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoSalir
            // 
            this._ComprasBtnIconoSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ComprasBtnIconoSalir.AplicarColoresEstado = false;
            this._ComprasBtnIconoSalir.BackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoSalir.BackgroundImage")));
            this._ComprasBtnIconoSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnIconoSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._ComprasBtnIconoSalir.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._ComprasBtnIconoSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoSalir.Location = new System.Drawing.Point(5, 7);
            this._ComprasBtnIconoSalir.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._ComprasBtnIconoSalir.Name = "_ComprasBtnIconoSalir";
            this._ComprasBtnIconoSalir.Size = new System.Drawing.Size(54, 49);
            this._ComprasBtnIconoSalir.TabIndex = 0;
            this._ComprasBtnIconoSalir.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoSalir.Click += new System.EventHandler(this.ComprasBtnSalir_Click);
            // 
            // _ComprasLblSalir
            // 
            this._ComprasLblSalir.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblSalir.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblSalir.ColorTexto = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasLblSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblSalir.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasLblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasLblSalir.Location = new System.Drawing.Point(67, 4);
            this._ComprasLblSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._ComprasLblSalir.MaximumSize = new System.Drawing.Size(1125, 0);
            this._ComprasLblSalir.MostrarAsterisco = false;
            this._ComprasLblSalir.Name = "_ComprasLblSalir";
            this._ComprasLblSalir.Size = new System.Drawing.Size(188, 56);
            this._ComprasLblSalir.TabIndex = 1;
            this._ComprasLblSalir.TabStop = false;
            this._ComprasLblSalir.TamanoTipografia = 10F;
            this._ComprasLblSalir.Text = "Salir";
            this._ComprasLblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasLblSalir.Texto = "Salir";
            this._ComprasLblSalir.Click += new System.EventHandler(this.ComprasBtnSalir_Click);
            // 
            // _ComprasTlpEncabezado
            // 
            this._ComprasTlpEncabezado.ColumnCount = 2;
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasLblUsuarioRol, 1, 0);
            this._ComprasTlpEncabezado.Controls.Add(this._ComprasBtnAlternarNavegador, 0, 0);
            this._ComprasTlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpEncabezado.Location = new System.Drawing.Point(303, 17);
            this._ComprasTlpEncabezado.Name = "_ComprasTlpEncabezado";
            this._ComprasTlpEncabezado.RowCount = 1;
            this._ComprasTlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpEncabezado.Size = new System.Drawing.Size(1234, 40);
            this._ComprasTlpEncabezado.TabIndex = 1;
            // 
            // ComprasLblUsuarioRol
            // 
            this.ComprasLblUsuarioRol.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblUsuarioRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblUsuarioRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblUsuarioRol.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ComprasLblUsuarioRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblUsuarioRol.Location = new System.Drawing.Point(62, 4);
            this.ComprasLblUsuarioRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComprasLblUsuarioRol.MaximumSize = new System.Drawing.Size(1375, 0);
            this.ComprasLblUsuarioRol.MostrarAsterisco = false;
            this.ComprasLblUsuarioRol.Name = "ComprasLblUsuarioRol";
            this.ComprasLblUsuarioRol.Size = new System.Drawing.Size(1168, 32);
            this.ComprasLblUsuarioRol.TabIndex = 4;
            this.ComprasLblUsuarioRol.TabStop = false;
            this.ComprasLblUsuarioRol.TamanoTipografia = 12F;
            this.ComprasLblUsuarioRol.Text = "Usuario: Rol:";
            this.ComprasLblUsuarioRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblUsuarioRol.Texto = "Usuario: Rol:";
            this._ComprasBtnAlternarNavegador.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnAlternarNavegador
            // 
            this._ComprasBtnAlternarNavegador.AccessibleName = "Contraer menú";
            this._ComprasBtnAlternarNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnAlternarNavegador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnAlternarNavegador.BackgroundImage")));
            this._ComprasBtnAlternarNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._ComprasBtnAlternarNavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnAlternarNavegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnAlternarNavegador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAlternarNavegador.FlatAppearance.BorderSize = 0;
            this._ComprasBtnAlternarNavegador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnAlternarNavegador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnAlternarNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnAlternarNavegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnAlternarNavegador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAlternarNavegador.Location = new System.Drawing.Point(0, 0);
            this._ComprasBtnAlternarNavegador.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnAlternarNavegador.Name = "_ComprasBtnAlternarNavegador";
            this._ComprasBtnAlternarNavegador.Size = new System.Drawing.Size(58, 40);
            this._ComprasBtnAlternarNavegador.TabIndex = 0;
            this._ComprasBtnAlternarNavegador.UseVisualStyleBackColor = false;
            this._ComprasBtnAlternarNavegador.Click += new System.EventHandler(this.ComprasBtnBurger_Click);
            // 
            // _ComprasPnlMain
            // 
            this._ComprasPnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasPnlMain.Controls.Add(this.ComprasPnlDashboard);
            this._ComprasPnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasPnlMain.Location = new System.Drawing.Point(300, 65);
            this._ComprasPnlMain.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._ComprasPnlMain.Name = "_ComprasPnlMain";
            this._ComprasPnlMain.Size = new System.Drawing.Size(1240, 774);
            this._ComprasPnlMain.TabIndex = 2;
            // 
            // ComprasPnlDashboard
            // 
            this.ComprasPnlDashboard.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPnlDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPnlDashboard.BackgroundImage")));
            this.ComprasPnlDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlDashboard.Controls.Add(this.ComprasTlpDashboard);
            this.ComprasPnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.ComprasPnlDashboard.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ComprasPnlDashboard.Name = "ComprasPnlDashboard";
            this.ComprasPnlDashboard.Padding = new System.Windows.Forms.Padding(24, 0, 24, 26);
            this.ComprasPnlDashboard.Size = new System.Drawing.Size(1240, 774);
            this.ComprasPnlDashboard.TabIndex = 3;
            // 
            // ComprasTlpDashboard
            // 
            this.ComprasTlpDashboard.BackColor = System.Drawing.Color.Transparent;
            this.ComprasTlpDashboard.ColumnCount = 1;
            this.ComprasTlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpDashboard.Controls.Add(this.ComprasTlpHero, 0, 0);
            this.ComprasTlpDashboard.Controls.Add(this.ComprasLblResumen, 0, 1);
            this.ComprasTlpDashboard.Controls.Add(this.ComprasTlpKpis, 0, 2);
            this.ComprasTlpDashboard.Controls.Add(this.ComprasPnlInformacion, 0, 3);
            this.ComprasTlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpDashboard.Location = new System.Drawing.Point(24, 0);
            this.ComprasTlpDashboard.Name = "ComprasTlpDashboard";
            this.ComprasTlpDashboard.RowCount = 4;
            this.ComprasTlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.ComprasTlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.ComprasTlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.ComprasTlpDashboard.Size = new System.Drawing.Size(1192, 748);
            this.ComprasTlpDashboard.TabIndex = 0;
            // 
            // ComprasTlpHero
            // 
            this.ComprasTlpHero.BackColor = System.Drawing.Color.Transparent;
            this.ComprasTlpHero.ColumnCount = 3;
            this.ComprasTlpHero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.ComprasTlpHero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.ComprasTlpHero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComprasTlpHero.Controls.Add(this.ComprasTlpPresentacion, 0, 0);
            this.ComprasTlpHero.Controls.Add(this.ComprasPbMascota, 1, 0);
            this.ComprasTlpHero.Controls.Add(this.ComprasPbIcono, 2, 0);
            this.ComprasTlpHero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpHero.Location = new System.Drawing.Point(3, 3);
            this.ComprasTlpHero.Name = "ComprasTlpHero";
            this.ComprasTlpHero.RowCount = 1;
            this.ComprasTlpHero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpHero.Size = new System.Drawing.Size(1186, 449);
            this.ComprasTlpHero.TabIndex = 0;
            // 
            // ComprasTlpPresentacion
            // 
            this.ComprasTlpPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.ComprasTlpPresentacion.ColumnCount = 1;
            this.ComprasTlpPresentacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpPresentacion.Controls.Add(this.ComprasLblBienvenido, 0, 0);
            this.ComprasTlpPresentacion.Controls.Add(this.ComprasLblModulo, 0, 1);
            this.ComprasTlpPresentacion.Controls.Add(this.ComprasLblParrafo, 0, 2);
            this.ComprasTlpPresentacion.Controls.Add(this.ComprasBtnAyuda, 0, 3);
            this.ComprasTlpPresentacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpPresentacion.Location = new System.Drawing.Point(3, 3);
            this.ComprasTlpPresentacion.Name = "ComprasTlpPresentacion";
            this.ComprasTlpPresentacion.RowCount = 4;
            this.ComprasTlpPresentacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ComprasTlpPresentacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.ComprasTlpPresentacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ComprasTlpPresentacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.ComprasTlpPresentacion.Size = new System.Drawing.Size(681, 443);
            this.ComprasTlpPresentacion.TabIndex = 0;
            // 
            // ComprasLblBienvenido
            // 
            this.ComprasLblBienvenido.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblBienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblBienvenido.Font = new System.Drawing.Font("Tahoma", 40F);
            this.ComprasLblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblBienvenido.Location = new System.Drawing.Point(0, 15);
            this.ComprasLblBienvenido.Margin = new System.Windows.Forms.Padding(0, 15, 12, 15);
            this.ComprasLblBienvenido.MaximumSize = new System.Drawing.Size(4625, 0);
            this.ComprasLblBienvenido.MostrarAsterisco = false;
            this.ComprasLblBienvenido.Name = "ComprasLblBienvenido";
            this.ComprasLblBienvenido.Size = new System.Drawing.Size(669, 128);
            this.ComprasLblBienvenido.TabIndex = 0;
            this.ComprasLblBienvenido.TabStop = false;
            this.ComprasLblBienvenido.TamanoTipografia = 40F;
            this.ComprasLblBienvenido.Text = "¡Bienvenido!";
            this.ComprasLblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblBienvenido.Texto = "¡Bienvenido!";
            // 
            // ComprasLblModulo
            // 
            this.ComprasLblModulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblModulo.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblModulo.Font = new System.Drawing.Font("Tahoma", 19F);
            this.ComprasLblModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblModulo.Location = new System.Drawing.Point(18, 165);
            this.ComprasLblModulo.Margin = new System.Windows.Forms.Padding(18, 7, 6, 7);
            this.ComprasLblModulo.MaximumSize = new System.Drawing.Size(2250, 0);
            this.ComprasLblModulo.MostrarAsterisco = false;
            this.ComprasLblModulo.Name = "ComprasLblModulo";
            this.ComprasLblModulo.Size = new System.Drawing.Size(657, 85);
            this.ComprasLblModulo.TabIndex = 1;
            this.ComprasLblModulo.TabStop = false;
            this.ComprasLblModulo.TamanoTipografia = 19F;
            this.ComprasLblModulo.Text = "Compras y cuentas\npor pagar";
            this.ComprasLblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblModulo.Texto = "Compras y cuentas\npor pagar";
            // 
            // ComprasLblParrafo
            // 
            this.ComprasLblParrafo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblParrafo.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblParrafo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblParrafo.Font = new System.Drawing.Font("Tahoma", 11.5F);
            this.ComprasLblParrafo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblParrafo.Location = new System.Drawing.Point(24, 261);
            this.ComprasLblParrafo.Margin = new System.Windows.Forms.Padding(24, 4, 3, 4);
            this.ComprasLblParrafo.MaximumSize = new System.Drawing.Size(1250, 0);
            this.ComprasLblParrafo.MostrarAsterisco = false;
            this.ComprasLblParrafo.Name = "ComprasLblParrafo";
            this.ComprasLblParrafo.Size = new System.Drawing.Size(654, 105);
            this.ComprasLblParrafo.TabIndex = 2;
            this.ComprasLblParrafo.TabStop = false;
            this.ComprasLblParrafo.TamanoTipografia = 11.5F;
            this.ComprasLblParrafo.Text = "Gestiona proveedores y órdenes de compra.\nControla pagos y cuentas por pagar en u" +
    "n solo lugar.";
            this.ComprasLblParrafo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblParrafo.Texto = "Gestiona proveedores y órdenes de compra.\nControla pagos y cuentas por pagar en u" +
    "n solo lugar.";
            this.ComprasBtnAyuda.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // ComprasBtnAyuda
            // 
            this.ComprasBtnAyuda.AccessibleDescription = "Ayuda";
            this.ComprasBtnAyuda.AccessibleName = "Ayuda";
            this.ComprasBtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComprasBtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this.ComprasBtnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnAyuda.BackgroundImage")));
            this.ComprasBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnAyuda.FlatAppearance.BorderSize = 0;
            this.ComprasBtnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComprasBtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasBtnAyuda.Location = new System.Drawing.Point(30, 374);
            this.ComprasBtnAyuda.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ComprasBtnAyuda.Name = "ComprasBtnAyuda";
            this.ComprasBtnAyuda.Size = new System.Drawing.Size(64, 64);
            this.ComprasBtnAyuda.TabIndex = 3;
            this.ComprasBtnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ComprasBtnAyuda.UseVisualStyleBackColor = false;
            // 
            // ComprasPbMascota
            // 
            this.ComprasPbMascota.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbMascota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbMascota.BackgroundImage")));
            this.ComprasPbMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbMascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPbMascota.Location = new System.Drawing.Point(687, 4);
            this.ComprasPbMascota.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ComprasPbMascota.Name = "ComprasPbMascota";
            this.ComprasPbMascota.Size = new System.Drawing.Size(379, 441);
            this.ComprasPbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbMascota.TabIndex = 1;
            this.ComprasPbMascota.TabStop = false;
            // 
            // ComprasPbIcono
            // 
            this.ComprasPbIcono.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbIcono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbIcono.BackgroundImage")));
            this.ComprasPbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbIcono.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasPbIcono.Location = new System.Drawing.Point(1069, 3);
            this.ComprasPbIcono.Name = "ComprasPbIcono";
            this.ComprasPbIcono.Size = new System.Drawing.Size(114, 85);
            this.ComprasPbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbIcono.TabIndex = 2;
            this.ComprasPbIcono.TabStop = false;
            // 
            // ComprasLblResumen
            // 
            this.ComprasLblResumen.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblResumen.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblResumen.Font = new System.Drawing.Font("Tahoma", 19F);
            this.ComprasLblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblResumen.Location = new System.Drawing.Point(6, 462);
            this.ComprasLblResumen.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ComprasLblResumen.MaximumSize = new System.Drawing.Size(2250, 0);
            this.ComprasLblResumen.MostrarAsterisco = false;
            this.ComprasLblResumen.Name = "ComprasLblResumen";
            this.ComprasLblResumen.Size = new System.Drawing.Size(1180, 31);
            this.ComprasLblResumen.TabIndex = 1;
            this.ComprasLblResumen.TabStop = false;
            this.ComprasLblResumen.TamanoTipografia = 19F;
            this.ComprasLblResumen.Text = "Resumen de Compras";
            this.ComprasLblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblResumen.Texto = "Resumen de Compras";
            // 
            // ComprasTlpKpis
            // 
            this.ComprasTlpKpis.BackColor = System.Drawing.Color.Transparent;
            this.ComprasTlpKpis.ColumnCount = 6;
            this.ComprasTlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ComprasTlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ComprasTlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ComprasTlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ComprasTlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ComprasTlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ComprasTlpKpis.Controls.Add(this.ComprasPnlKpi1, 0, 0);
            this.ComprasTlpKpis.Controls.Add(this.ComprasPnlKpi2, 1, 0);
            this.ComprasTlpKpis.Controls.Add(this.ComprasPnlKpi3, 2, 0);
            this.ComprasTlpKpis.Controls.Add(this.ComprasPnlKpi4, 3, 0);
            this.ComprasTlpKpis.Controls.Add(this.ComprasPnlKpi5, 4, 0);
            this.ComprasTlpKpis.Controls.Add(this.ComprasPnlKpi6, 5, 0);
            this.ComprasTlpKpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpKpis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpKpis.Location = new System.Drawing.Point(3, 503);
            this.ComprasTlpKpis.Name = "ComprasTlpKpis";
            this.ComprasTlpKpis.RowCount = 1;
            this.ComprasTlpKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpKpis.Size = new System.Drawing.Size(1186, 170);
            this.ComprasTlpKpis.TabIndex = 2;
            // 
            // ComprasPnlKpi1
            // 
            this.ComprasPnlKpi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasPnlKpi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlKpi1.Controls.Add(this.ComprasTlpKpi1);
            this.ComprasPnlKpi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlKpi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlKpi1.Location = new System.Drawing.Point(3, 0);
            this.ComprasPnlKpi1.Margin = new System.Windows.Forms.Padding(3, 0, 6, 8);
            this.ComprasPnlKpi1.Name = "ComprasPnlKpi1";
            this.ComprasPnlKpi1.Padding = new System.Windows.Forms.Padding(6);
            this.ComprasPnlKpi1.Size = new System.Drawing.Size(188, 162);
            this.ComprasPnlKpi1.TabIndex = 0;
            // 
            // ComprasTlpKpi1
            // 
            this.ComprasTlpKpi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasTlpKpi1.ColumnCount = 1;
            this.ComprasTlpKpi1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi1.Controls.Add(this.ComprasPbKpi1, 0, 0);
            this.ComprasTlpKpi1.Controls.Add(this.ComprasLblValorKpi1, 0, 1);
            this.ComprasTlpKpi1.Controls.Add(this.ComprasLblKpi1, 0, 2);
            this.ComprasTlpKpi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpKpi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpKpi1.Location = new System.Drawing.Point(6, 6);
            this.ComprasTlpKpi1.Name = "ComprasTlpKpi1";
            this.ComprasTlpKpi1.RowCount = 3;
            this.ComprasTlpKpi1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.ComprasTlpKpi1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ComprasTlpKpi1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi1.Size = new System.Drawing.Size(176, 150);
            this.ComprasTlpKpi1.TabIndex = 0;
            // 
            // ComprasPbKpi1
            // 
            this.ComprasPbKpi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasPbKpi1.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbKpi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbKpi1.BackgroundImage")));
            this.ComprasPbKpi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbKpi1.Location = new System.Drawing.Point(3, 3);
            this.ComprasPbKpi1.Name = "ComprasPbKpi1";
            this.ComprasPbKpi1.Size = new System.Drawing.Size(170, 61);
            this.ComprasPbKpi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbKpi1.TabIndex = 0;
            this.ComprasPbKpi1.TabStop = false;
            // 
            // ComprasLblValorKpi1
            // 
            this.ComprasLblValorKpi1.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi1.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblValorKpi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblValorKpi1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ComprasLblValorKpi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblValorKpi1.Location = new System.Drawing.Point(5, 73);
            this.ComprasLblValorKpi1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasLblValorKpi1.MaximumSize = new System.Drawing.Size(1875, 0);
            this.ComprasLblValorKpi1.MostrarAsterisco = false;
            this.ComprasLblValorKpi1.Name = "ComprasLblValorKpi1";
            this.ComprasLblValorKpi1.Size = new System.Drawing.Size(166, 24);
            this.ComprasLblValorKpi1.TabIndex = 1;
            this.ComprasLblValorKpi1.TabStop = false;
            this.ComprasLblValorKpi1.TamanoTipografia = 16F;
            this.ComprasLblValorKpi1.Text = "—";
            this.ComprasLblValorKpi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi1.Texto = "—";
            // 
            // ComprasLblKpi1
            // 
            this.ComprasLblKpi1.AlineacionTexto = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi1.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblKpi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblKpi1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComprasLblKpi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblKpi1.Location = new System.Drawing.Point(3, 107);
            this.ComprasLblKpi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblKpi1.MaximumSize = new System.Drawing.Size(1125, 0);
            this.ComprasLblKpi1.MostrarAsterisco = false;
            this.ComprasLblKpi1.Name = "ComprasLblKpi1";
            this.ComprasLblKpi1.Size = new System.Drawing.Size(170, 39);
            this.ComprasLblKpi1.TabIndex = 2;
            this.ComprasLblKpi1.TabStop = false;
            this.ComprasLblKpi1.TamanoTipografia = 11F;
            this.ComprasLblKpi1.Text = "Compras del mes";
            this.ComprasLblKpi1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi1.Texto = "Compras del mes";
            // 
            // ComprasPnlKpi2
            // 
            this.ComprasPnlKpi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasPnlKpi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlKpi2.Controls.Add(this.ComprasTlpKpi2);
            this.ComprasPnlKpi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlKpi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlKpi2.Location = new System.Drawing.Point(200, 0);
            this.ComprasPnlKpi2.Margin = new System.Windows.Forms.Padding(3, 0, 6, 8);
            this.ComprasPnlKpi2.Name = "ComprasPnlKpi2";
            this.ComprasPnlKpi2.Padding = new System.Windows.Forms.Padding(6);
            this.ComprasPnlKpi2.Size = new System.Drawing.Size(188, 162);
            this.ComprasPnlKpi2.TabIndex = 1;
            // 
            // ComprasTlpKpi2
            // 
            this.ComprasTlpKpi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasTlpKpi2.ColumnCount = 1;
            this.ComprasTlpKpi2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi2.Controls.Add(this.ComprasPbKpi2, 0, 0);
            this.ComprasTlpKpi2.Controls.Add(this.ComprasLblValorKpi2, 0, 1);
            this.ComprasTlpKpi2.Controls.Add(this.ComprasLblKpi2, 0, 2);
            this.ComprasTlpKpi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpKpi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpKpi2.Location = new System.Drawing.Point(6, 6);
            this.ComprasTlpKpi2.Name = "ComprasTlpKpi2";
            this.ComprasTlpKpi2.RowCount = 3;
            this.ComprasTlpKpi2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.ComprasTlpKpi2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ComprasTlpKpi2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi2.Size = new System.Drawing.Size(176, 150);
            this.ComprasTlpKpi2.TabIndex = 0;
            // 
            // ComprasPbKpi2
            // 
            this.ComprasPbKpi2.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbKpi2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbKpi2.BackgroundImage")));
            this.ComprasPbKpi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbKpi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPbKpi2.Location = new System.Drawing.Point(3, 3);
            this.ComprasPbKpi2.Name = "ComprasPbKpi2";
            this.ComprasPbKpi2.Size = new System.Drawing.Size(170, 61);
            this.ComprasPbKpi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbKpi2.TabIndex = 0;
            this.ComprasPbKpi2.TabStop = false;
            // 
            // ComprasLblValorKpi2
            // 
            this.ComprasLblValorKpi2.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi2.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblValorKpi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblValorKpi2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ComprasLblValorKpi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblValorKpi2.Location = new System.Drawing.Point(5, 73);
            this.ComprasLblValorKpi2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasLblValorKpi2.MaximumSize = new System.Drawing.Size(1875, 0);
            this.ComprasLblValorKpi2.MostrarAsterisco = false;
            this.ComprasLblValorKpi2.Name = "ComprasLblValorKpi2";
            this.ComprasLblValorKpi2.Size = new System.Drawing.Size(166, 24);
            this.ComprasLblValorKpi2.TabIndex = 1;
            this.ComprasLblValorKpi2.TabStop = false;
            this.ComprasLblValorKpi2.TamanoTipografia = 16F;
            this.ComprasLblValorKpi2.Text = "—";
            this.ComprasLblValorKpi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi2.Texto = "—";
            // 
            // ComprasLblKpi2
            // 
            this.ComprasLblKpi2.AlineacionTexto = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi2.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblKpi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblKpi2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComprasLblKpi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblKpi2.Location = new System.Drawing.Point(3, 107);
            this.ComprasLblKpi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblKpi2.MaximumSize = new System.Drawing.Size(1125, 0);
            this.ComprasLblKpi2.MostrarAsterisco = false;
            this.ComprasLblKpi2.Name = "ComprasLblKpi2";
            this.ComprasLblKpi2.Size = new System.Drawing.Size(170, 39);
            this.ComprasLblKpi2.TabIndex = 2;
            this.ComprasLblKpi2.TabStop = false;
            this.ComprasLblKpi2.TamanoTipografia = 11F;
            this.ComprasLblKpi2.Text = "Órdenes pendientes de aprobación";
            this.ComprasLblKpi2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi2.Texto = "Órdenes pendientes de aprobación";
            // 
            // ComprasPnlKpi3
            // 
            this.ComprasPnlKpi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasPnlKpi3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlKpi3.Controls.Add(this.ComprasTlpKpi3);
            this.ComprasPnlKpi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlKpi3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlKpi3.Location = new System.Drawing.Point(397, 0);
            this.ComprasPnlKpi3.Margin = new System.Windows.Forms.Padding(3, 0, 6, 8);
            this.ComprasPnlKpi3.Name = "ComprasPnlKpi3";
            this.ComprasPnlKpi3.Padding = new System.Windows.Forms.Padding(6);
            this.ComprasPnlKpi3.Size = new System.Drawing.Size(188, 162);
            this.ComprasPnlKpi3.TabIndex = 2;
            // 
            // ComprasTlpKpi3
            // 
            this.ComprasTlpKpi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasTlpKpi3.ColumnCount = 1;
            this.ComprasTlpKpi3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi3.Controls.Add(this.ComprasPbKpi3, 0, 0);
            this.ComprasTlpKpi3.Controls.Add(this.ComprasLblValorKpi3, 0, 1);
            this.ComprasTlpKpi3.Controls.Add(this.ComprasLblKpi3, 0, 2);
            this.ComprasTlpKpi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpKpi3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpKpi3.Location = new System.Drawing.Point(6, 6);
            this.ComprasTlpKpi3.Name = "ComprasTlpKpi3";
            this.ComprasTlpKpi3.RowCount = 3;
            this.ComprasTlpKpi3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.ComprasTlpKpi3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ComprasTlpKpi3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi3.Size = new System.Drawing.Size(176, 150);
            this.ComprasTlpKpi3.TabIndex = 0;
            // 
            // ComprasPbKpi3
            // 
            this.ComprasPbKpi3.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbKpi3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbKpi3.BackgroundImage")));
            this.ComprasPbKpi3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbKpi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPbKpi3.Location = new System.Drawing.Point(3, 3);
            this.ComprasPbKpi3.Name = "ComprasPbKpi3";
            this.ComprasPbKpi3.Size = new System.Drawing.Size(170, 61);
            this.ComprasPbKpi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbKpi3.TabIndex = 0;
            this.ComprasPbKpi3.TabStop = false;
            // 
            // ComprasLblValorKpi3
            // 
            this.ComprasLblValorKpi3.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi3.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblValorKpi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblValorKpi3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ComprasLblValorKpi3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblValorKpi3.Location = new System.Drawing.Point(5, 73);
            this.ComprasLblValorKpi3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasLblValorKpi3.MaximumSize = new System.Drawing.Size(1875, 0);
            this.ComprasLblValorKpi3.MostrarAsterisco = false;
            this.ComprasLblValorKpi3.Name = "ComprasLblValorKpi3";
            this.ComprasLblValorKpi3.Size = new System.Drawing.Size(166, 24);
            this.ComprasLblValorKpi3.TabIndex = 1;
            this.ComprasLblValorKpi3.TabStop = false;
            this.ComprasLblValorKpi3.TamanoTipografia = 16F;
            this.ComprasLblValorKpi3.Text = "—";
            this.ComprasLblValorKpi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi3.Texto = "—";
            // 
            // ComprasLblKpi3
            // 
            this.ComprasLblKpi3.AlineacionTexto = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi3.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblKpi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblKpi3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComprasLblKpi3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblKpi3.Location = new System.Drawing.Point(3, 107);
            this.ComprasLblKpi3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblKpi3.MaximumSize = new System.Drawing.Size(1125, 0);
            this.ComprasLblKpi3.MostrarAsterisco = false;
            this.ComprasLblKpi3.Name = "ComprasLblKpi3";
            this.ComprasLblKpi3.Size = new System.Drawing.Size(170, 39);
            this.ComprasLblKpi3.TabIndex = 2;
            this.ComprasLblKpi3.TabStop = false;
            this.ComprasLblKpi3.TamanoTipografia = 11F;
            this.ComprasLblKpi3.Text = "Órdenes pendientes de recepción";
            this.ComprasLblKpi3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi3.Texto = "Órdenes pendientes de recepción";
            // 
            // ComprasPnlKpi4
            // 
            this.ComprasPnlKpi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasPnlKpi4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlKpi4.Controls.Add(this.ComprasTlpKpi4);
            this.ComprasPnlKpi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlKpi4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlKpi4.Location = new System.Drawing.Point(594, 0);
            this.ComprasPnlKpi4.Margin = new System.Windows.Forms.Padding(3, 0, 6, 8);
            this.ComprasPnlKpi4.Name = "ComprasPnlKpi4";
            this.ComprasPnlKpi4.Padding = new System.Windows.Forms.Padding(6);
            this.ComprasPnlKpi4.Size = new System.Drawing.Size(188, 162);
            this.ComprasPnlKpi4.TabIndex = 3;
            // 
            // ComprasTlpKpi4
            // 
            this.ComprasTlpKpi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasTlpKpi4.ColumnCount = 1;
            this.ComprasTlpKpi4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi4.Controls.Add(this.ComprasPbKpi4, 0, 0);
            this.ComprasTlpKpi4.Controls.Add(this.ComprasLblValorKpi4, 0, 1);
            this.ComprasTlpKpi4.Controls.Add(this.ComprasLblKpi4, 0, 2);
            this.ComprasTlpKpi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpKpi4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpKpi4.Location = new System.Drawing.Point(6, 6);
            this.ComprasTlpKpi4.Name = "ComprasTlpKpi4";
            this.ComprasTlpKpi4.RowCount = 3;
            this.ComprasTlpKpi4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.ComprasTlpKpi4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ComprasTlpKpi4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi4.Size = new System.Drawing.Size(176, 150);
            this.ComprasTlpKpi4.TabIndex = 0;
            // 
            // ComprasPbKpi4
            // 
            this.ComprasPbKpi4.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbKpi4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbKpi4.BackgroundImage")));
            this.ComprasPbKpi4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbKpi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPbKpi4.Location = new System.Drawing.Point(3, 3);
            this.ComprasPbKpi4.Name = "ComprasPbKpi4";
            this.ComprasPbKpi4.Size = new System.Drawing.Size(170, 61);
            this.ComprasPbKpi4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbKpi4.TabIndex = 0;
            this.ComprasPbKpi4.TabStop = false;
            // 
            // ComprasLblValorKpi4
            // 
            this.ComprasLblValorKpi4.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi4.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblValorKpi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblValorKpi4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ComprasLblValorKpi4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblValorKpi4.Location = new System.Drawing.Point(5, 73);
            this.ComprasLblValorKpi4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasLblValorKpi4.MaximumSize = new System.Drawing.Size(1875, 0);
            this.ComprasLblValorKpi4.MostrarAsterisco = false;
            this.ComprasLblValorKpi4.Name = "ComprasLblValorKpi4";
            this.ComprasLblValorKpi4.Size = new System.Drawing.Size(166, 24);
            this.ComprasLblValorKpi4.TabIndex = 1;
            this.ComprasLblValorKpi4.TabStop = false;
            this.ComprasLblValorKpi4.TamanoTipografia = 16F;
            this.ComprasLblValorKpi4.Text = "—";
            this.ComprasLblValorKpi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi4.Texto = "—";
            // 
            // ComprasLblKpi4
            // 
            this.ComprasLblKpi4.AlineacionTexto = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi4.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblKpi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblKpi4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComprasLblKpi4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblKpi4.Location = new System.Drawing.Point(3, 107);
            this.ComprasLblKpi4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblKpi4.MaximumSize = new System.Drawing.Size(1125, 0);
            this.ComprasLblKpi4.MostrarAsterisco = false;
            this.ComprasLblKpi4.Name = "ComprasLblKpi4";
            this.ComprasLblKpi4.Size = new System.Drawing.Size(170, 39);
            this.ComprasLblKpi4.TabIndex = 2;
            this.ComprasLblKpi4.TabStop = false;
            this.ComprasLblKpi4.TamanoTipografia = 11F;
            this.ComprasLblKpi4.Text = "Saldo por pagar";
            this.ComprasLblKpi4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi4.Texto = "Saldo por pagar";
            // 
            // ComprasPnlKpi5
            // 
            this.ComprasPnlKpi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasPnlKpi5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlKpi5.Controls.Add(this.ComprasTlpKpi5);
            this.ComprasPnlKpi5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlKpi5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlKpi5.Location = new System.Drawing.Point(791, 0);
            this.ComprasPnlKpi5.Margin = new System.Windows.Forms.Padding(3, 0, 6, 8);
            this.ComprasPnlKpi5.Name = "ComprasPnlKpi5";
            this.ComprasPnlKpi5.Padding = new System.Windows.Forms.Padding(6);
            this.ComprasPnlKpi5.Size = new System.Drawing.Size(188, 162);
            this.ComprasPnlKpi5.TabIndex = 4;
            // 
            // ComprasTlpKpi5
            // 
            this.ComprasTlpKpi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasTlpKpi5.ColumnCount = 1;
            this.ComprasTlpKpi5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi5.Controls.Add(this.ComprasPbKpi5, 0, 0);
            this.ComprasTlpKpi5.Controls.Add(this.ComprasLblValorKpi5, 0, 1);
            this.ComprasTlpKpi5.Controls.Add(this.ComprasLblKpi5, 0, 2);
            this.ComprasTlpKpi5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpKpi5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpKpi5.Location = new System.Drawing.Point(6, 6);
            this.ComprasTlpKpi5.Name = "ComprasTlpKpi5";
            this.ComprasTlpKpi5.RowCount = 3;
            this.ComprasTlpKpi5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.ComprasTlpKpi5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ComprasTlpKpi5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi5.Size = new System.Drawing.Size(176, 150);
            this.ComprasTlpKpi5.TabIndex = 0;
            // 
            // ComprasPbKpi5
            // 
            this.ComprasPbKpi5.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbKpi5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbKpi5.BackgroundImage")));
            this.ComprasPbKpi5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbKpi5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPbKpi5.Location = new System.Drawing.Point(3, 3);
            this.ComprasPbKpi5.Name = "ComprasPbKpi5";
            this.ComprasPbKpi5.Size = new System.Drawing.Size(170, 61);
            this.ComprasPbKpi5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbKpi5.TabIndex = 0;
            this.ComprasPbKpi5.TabStop = false;
            // 
            // ComprasLblValorKpi5
            // 
            this.ComprasLblValorKpi5.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi5.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblValorKpi5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblValorKpi5.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ComprasLblValorKpi5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblValorKpi5.Location = new System.Drawing.Point(5, 73);
            this.ComprasLblValorKpi5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasLblValorKpi5.MaximumSize = new System.Drawing.Size(1875, 0);
            this.ComprasLblValorKpi5.MostrarAsterisco = false;
            this.ComprasLblValorKpi5.Name = "ComprasLblValorKpi5";
            this.ComprasLblValorKpi5.Size = new System.Drawing.Size(166, 24);
            this.ComprasLblValorKpi5.TabIndex = 1;
            this.ComprasLblValorKpi5.TabStop = false;
            this.ComprasLblValorKpi5.TamanoTipografia = 16F;
            this.ComprasLblValorKpi5.Text = "—";
            this.ComprasLblValorKpi5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi5.Texto = "—";
            // 
            // ComprasLblKpi5
            // 
            this.ComprasLblKpi5.AlineacionTexto = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi5.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblKpi5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblKpi5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComprasLblKpi5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblKpi5.Location = new System.Drawing.Point(3, 107);
            this.ComprasLblKpi5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblKpi5.MaximumSize = new System.Drawing.Size(1125, 0);
            this.ComprasLblKpi5.MostrarAsterisco = false;
            this.ComprasLblKpi5.Name = "ComprasLblKpi5";
            this.ComprasLblKpi5.Size = new System.Drawing.Size(170, 39);
            this.ComprasLblKpi5.TabIndex = 2;
            this.ComprasLblKpi5.TabStop = false;
            this.ComprasLblKpi5.TamanoTipografia = 11F;
            this.ComprasLblKpi5.Text = "Saldo vencido";
            this.ComprasLblKpi5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi5.Texto = "Saldo vencido";
            // 
            // ComprasPnlKpi6
            // 
            this.ComprasPnlKpi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasPnlKpi6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlKpi6.Controls.Add(this.ComprasTlpKpi6);
            this.ComprasPnlKpi6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlKpi6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlKpi6.Location = new System.Drawing.Point(988, 0);
            this.ComprasPnlKpi6.Margin = new System.Windows.Forms.Padding(3, 0, 6, 8);
            this.ComprasPnlKpi6.Name = "ComprasPnlKpi6";
            this.ComprasPnlKpi6.Padding = new System.Windows.Forms.Padding(6);
            this.ComprasPnlKpi6.Size = new System.Drawing.Size(192, 162);
            this.ComprasPnlKpi6.TabIndex = 5;
            // 
            // ComprasTlpKpi6
            // 
            this.ComprasTlpKpi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasTlpKpi6.ColumnCount = 1;
            this.ComprasTlpKpi6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi6.Controls.Add(this.ComprasPbKpi6, 0, 0);
            this.ComprasTlpKpi6.Controls.Add(this.ComprasLblValorKpi6, 0, 1);
            this.ComprasTlpKpi6.Controls.Add(this.ComprasLblKpi6, 0, 2);
            this.ComprasTlpKpi6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpKpi6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpKpi6.Location = new System.Drawing.Point(6, 6);
            this.ComprasTlpKpi6.Name = "ComprasTlpKpi6";
            this.ComprasTlpKpi6.RowCount = 3;
            this.ComprasTlpKpi6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.ComprasTlpKpi6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ComprasTlpKpi6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpKpi6.Size = new System.Drawing.Size(180, 150);
            this.ComprasTlpKpi6.TabIndex = 0;
            // 
            // ComprasPbKpi6
            // 
            this.ComprasPbKpi6.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPbKpi6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbKpi6.BackgroundImage")));
            this.ComprasPbKpi6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComprasPbKpi6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPbKpi6.Location = new System.Drawing.Point(3, 3);
            this.ComprasPbKpi6.Name = "ComprasPbKpi6";
            this.ComprasPbKpi6.Size = new System.Drawing.Size(174, 61);
            this.ComprasPbKpi6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComprasPbKpi6.TabIndex = 0;
            this.ComprasPbKpi6.TabStop = false;
            // 
            // ComprasLblValorKpi6
            // 
            this.ComprasLblValorKpi6.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi6.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblValorKpi6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblValorKpi6.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ComprasLblValorKpi6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblValorKpi6.Location = new System.Drawing.Point(5, 73);
            this.ComprasLblValorKpi6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasLblValorKpi6.MaximumSize = new System.Drawing.Size(1875, 0);
            this.ComprasLblValorKpi6.MostrarAsterisco = false;
            this.ComprasLblValorKpi6.Name = "ComprasLblValorKpi6";
            this.ComprasLblValorKpi6.Size = new System.Drawing.Size(170, 24);
            this.ComprasLblValorKpi6.TabIndex = 1;
            this.ComprasLblValorKpi6.TabStop = false;
            this.ComprasLblValorKpi6.TamanoTipografia = 16F;
            this.ComprasLblValorKpi6.Text = "—";
            this.ComprasLblValorKpi6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComprasLblValorKpi6.Texto = "—";
            // 
            // ComprasLblKpi6
            // 
            this.ComprasLblKpi6.AlineacionTexto = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi6.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblKpi6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblKpi6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComprasLblKpi6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblKpi6.Location = new System.Drawing.Point(3, 107);
            this.ComprasLblKpi6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblKpi6.MaximumSize = new System.Drawing.Size(1125, 0);
            this.ComprasLblKpi6.MostrarAsterisco = false;
            this.ComprasLblKpi6.Name = "ComprasLblKpi6";
            this.ComprasLblKpi6.Size = new System.Drawing.Size(174, 39);
            this.ComprasLblKpi6.TabIndex = 2;
            this.ComprasLblKpi6.TabStop = false;
            this.ComprasLblKpi6.TamanoTipografia = 11F;
            this.ComprasLblKpi6.Text = "Pagos próximos a vencer - 7 días";
            this.ComprasLblKpi6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComprasLblKpi6.Texto = "Pagos próximos a vencer - 7 días";
            // 
            // ComprasPnlInformacion
            // 
            this.ComprasPnlInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasPnlInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasPnlInformacion.Controls.Add(this.ComprasTlpInformacion);
            this.ComprasPnlInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlInformacion.Location = new System.Drawing.Point(3, 679);
            this.ComprasPnlInformacion.Name = "ComprasPnlInformacion";
            this.ComprasPnlInformacion.Padding = new System.Windows.Forms.Padding(14, 9, 14, 9);
            this.ComprasPnlInformacion.Size = new System.Drawing.Size(1186, 66);
            this.ComprasPnlInformacion.TabIndex = 3;
            // 
            // ComprasTlpInformacion
            // 
            this.ComprasTlpInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasTlpInformacion.ColumnCount = 2;
            this.ComprasTlpInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ComprasTlpInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ComprasTlpInformacion.Controls.Add(this.ComprasLblInformacion, 0, 0);
            this.ComprasTlpInformacion.Controls.Add(this.ComprasLblIntegracion, 1, 0);
            this.ComprasTlpInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpInformacion.Location = new System.Drawing.Point(14, 9);
            this.ComprasTlpInformacion.Name = "ComprasTlpInformacion";
            this.ComprasTlpInformacion.RowCount = 1;
            this.ComprasTlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpInformacion.Size = new System.Drawing.Size(1158, 48);
            this.ComprasTlpInformacion.TabIndex = 0;
            // 
            // ComprasLblInformacion
            // 
            this.ComprasLblInformacion.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblInformacion.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblInformacion.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComprasLblInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblInformacion.Location = new System.Drawing.Point(3, 4);
            this.ComprasLblInformacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblInformacion.MaximumSize = new System.Drawing.Size(1250, 0);
            this.ComprasLblInformacion.MostrarAsterisco = false;
            this.ComprasLblInformacion.Name = "ComprasLblInformacion";
            this.ComprasLblInformacion.Size = new System.Drawing.Size(688, 40);
            this.ComprasLblInformacion.TabIndex = 0;
            this.ComprasLblInformacion.TabStop = false;
            this.ComprasLblInformacion.TamanoTipografia = 11F;
            this.ComprasLblInformacion.Text = "Información de Compras\nProveedores, órdenes de compra y cuentas por pagar.";
            this.ComprasLblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblInformacion.Texto = "Información de Compras\nProveedores, órdenes de compra y cuentas por pagar.";
            // 
            // ComprasLblIntegracion
            // 
            this.ComprasLblIntegracion.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblIntegracion.BackColor = System.Drawing.Color.Transparent;
            this.ComprasLblIntegracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblIntegracion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ComprasLblIntegracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblIntegracion.Location = new System.Drawing.Point(697, 4);
            this.ComprasLblIntegracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblIntegracion.MaximumSize = new System.Drawing.Size(1125, 0);
            this.ComprasLblIntegracion.MostrarAsterisco = false;
            this.ComprasLblIntegracion.Name = "ComprasLblIntegracion";
            this.ComprasLblIntegracion.Size = new System.Drawing.Size(458, 40);
            this.ComprasLblIntegracion.TabIndex = 1;
            this.ComprasLblIntegracion.TabStop = false;
            this.ComprasLblIntegracion.TamanoTipografia = 10F;
            this.ComprasLblIntegracion.Text = "Integración\nIndicadores pendientes de datos del controlador.";
            this.ComprasLblIntegracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblIntegracion.Texto = "Integración\nIndicadores pendientes de datos del controlador.";
            // 
            // FrmMDICompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1554, 853);
            this.Controls.Add(this._ComprasTlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FrmMDICompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6000 – Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._ComprasTlpPrincipal.ResumeLayout(false);
            this._ComprasTlpNavegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).EndInit();
            this._ComprasTlpMovimientosProveedores.ResumeLayout(false);
            this._ComprasTlpPolizas.ResumeLayout(false);
            this._ComprasTlpProveedores.ResumeLayout(false);
            this._ComprasTlpMetodosPago.ResumeLayout(false);
            this._ComprasTlpOrdenesCompra.ResumeLayout(false);
            this._ComprasTlpPagosProveedores.ResumeLayout(false);
            this._ComprasTlpAprobacionFinanciera.ResumeLayout(false);
            this._ComprasTlpCierreMovimientos.ResumeLayout(false);
            this._ComprasTlpBitacora.ResumeLayout(false);
            this._ComprasTlpSalir.ResumeLayout(false);
            this._ComprasTlpEncabezado.ResumeLayout(false);
            this._ComprasPnlMain.ResumeLayout(false);
            this.ComprasPnlDashboard.ResumeLayout(false);
            this.ComprasTlpDashboard.ResumeLayout(false);
            this.ComprasTlpHero.ResumeLayout(false);
            this.ComprasTlpPresentacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbIcono)).EndInit();
            this.ComprasTlpKpis.ResumeLayout(false);
            this.ComprasPnlKpi1.ResumeLayout(false);
            this.ComprasTlpKpi1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi1)).EndInit();
            this.ComprasPnlKpi2.ResumeLayout(false);
            this.ComprasTlpKpi2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi2)).EndInit();
            this.ComprasPnlKpi3.ResumeLayout(false);
            this.ComprasTlpKpi3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi3)).EndInit();
            this.ComprasPnlKpi4.ResumeLayout(false);
            this.ComprasTlpKpi4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi4)).EndInit();
            this.ComprasPnlKpi5.ResumeLayout(false);
            this.ComprasTlpKpi5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi5)).EndInit();
            this.ComprasPnlKpi6.ResumeLayout(false);
            this.ComprasTlpKpi6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasPbKpi6)).EndInit();
            this.ComprasPnlInformacion.ResumeLayout(false);
            this.ComprasTlpInformacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TableLayoutPanel _ComprasTlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel _ComprasTlpNavegador;
        private System.Windows.Forms.TableLayoutPanel _ComprasTlpEncabezado;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnAlternarNavegador;
        private CapaVista_Componentes.Componentes.ClsPanelCompras _ComprasPnlMain;
        private System.Windows.Forms.PictureBox _ComprasPbMarca;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpMovimientosProveedores;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoMovimientosProveedores;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblMovimientosProveedores;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpPolizas;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoPolizas;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblPolizas;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpProveedores;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoProveedores;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblProveedores;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpMetodosPago;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoMetodosPago;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblMetodosPago;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpOrdenesCompra;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoOrdenesCompra;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblOrdenesCompra;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpPagosProveedores;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoPagosProveedores;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblPagosProveedores;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpAprobacionFinanciera;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoAprobacionFinanciera;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblAprobacionFinanciera;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpCierreMovimientos;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoCierreMovimientos;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblCierreMovimientos;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpBitacora;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoBitacora;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblBitacora;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras _ComprasTlpSalir;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnIconoSalir;
        private CapaVista_Componentes.Componentes.UsrLabelCompras _ComprasLblSalir;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblUsuarioRol;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlDashboard;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpDashboard;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpHero;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpPresentacion;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblBienvenido;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblModulo;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblParrafo;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnAyuda;
        private System.Windows.Forms.PictureBox ComprasPbMascota;
        private System.Windows.Forms.PictureBox ComprasPbIcono;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblResumen;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpKpis;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlKpi1;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpKpi1;
        private System.Windows.Forms.PictureBox ComprasPbKpi1;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblValorKpi1;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblKpi1;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlKpi2;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpKpi2;
        private System.Windows.Forms.PictureBox ComprasPbKpi2;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblValorKpi2;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblKpi2;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlKpi3;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpKpi3;
        private System.Windows.Forms.PictureBox ComprasPbKpi3;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblValorKpi3;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblKpi3;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlKpi4;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpKpi4;
        private System.Windows.Forms.PictureBox ComprasPbKpi4;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblValorKpi4;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblKpi4;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlKpi5;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpKpi5;
        private System.Windows.Forms.PictureBox ComprasPbKpi5;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblValorKpi5;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblKpi5;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlKpi6;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpKpi6;
        private System.Windows.Forms.PictureBox ComprasPbKpi6;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblValorKpi6;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblKpi6;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlInformacion;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpInformacion;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblInformacion;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblIntegracion;
    }
}
