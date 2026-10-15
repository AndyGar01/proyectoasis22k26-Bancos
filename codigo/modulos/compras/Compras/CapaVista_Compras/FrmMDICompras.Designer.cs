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
            this._ComprasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this._ComprasTlpNavegador = new System.Windows.Forms.TableLayoutPanel();
            this._ComprasPbMarca = new System.Windows.Forms.PictureBox();
            this._ComprasBtnIconoCierreMovimientos = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnCierreMovimientos = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoAprobacionFinanciera = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnAprobacionFinanciera = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoPagosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnPagosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoOrdenesCompra = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnOrdenesCompra = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoMetodosPago = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnMetodosPago = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoMovimientosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnMovimientosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoPolizas = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnPolizas = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoBitacora = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnBitacora = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoSalir = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnSalir = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasTlpEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this._ComprasBtnAlternarNavegador = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this.ComprasUsrUsuarioTexto = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrUsuario = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrRolTexto = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrRol = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasPnlMain = new CapaVista_Compras.Componentes.ClsPanelCompras();
            this.usrDashboardCompras1 = new CapaVista_Compras.UsrDashboardCompras();
            this._ComprasTlpPrincipal.SuspendLayout();
            this._ComprasTlpNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).BeginInit();
            this._ComprasTlpEncabezado.SuspendLayout();
            this._ComprasPnlMain.SuspendLayout();
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
            this._ComprasTlpPrincipal.Size = new System.Drawing.Size(1554, 1055);
            this._ComprasTlpPrincipal.TabIndex = 0;
            // 
            // _ComprasTlpNavegador
            // 
            this._ComprasTlpNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpNavegador.ColumnCount = 2;
            this._ComprasTlpNavegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this._ComprasTlpNavegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this._ComprasTlpNavegador.Controls.Add(this._ComprasPbMarca, 0, 0);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoCierreMovimientos, 0, 8);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnCierreMovimientos, 1, 8);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoAprobacionFinanciera, 0, 7);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnAprobacionFinanciera, 1, 7);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoPagosProveedores, 0, 6);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnPagosProveedores, 1, 6);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoOrdenesCompra, 0, 5);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnOrdenesCompra, 1, 5);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoMetodosPago, 0, 4);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnMetodosPago, 1, 4);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoProveedores, 0, 3);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnProveedores, 1, 3);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoMovimientosProveedores, 0, 1);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnMovimientosProveedores, 1, 1);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoPolizas, 0, 2);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnPolizas, 1, 2);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoBitacora, 0, 9);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnBitacora, 1, 9);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoSalir, 0, 10);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnSalir, 1, 10);
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
            this._ComprasTlpNavegador.Size = new System.Drawing.Size(270, 1027);
            this._ComprasTlpNavegador.TabIndex = 0;
            // 
            // _ComprasPbMarca
            // 
            this._ComprasTlpNavegador.SetColumnSpan(this._ComprasPbMarca, 2);
            this._ComprasPbMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPbMarca.Location = new System.Drawing.Point(70, 8);
            this._ComprasPbMarca.Margin = new System.Windows.Forms.Padding(64, 0, 64, 10);
            this._ComprasPbMarca.Name = "_ComprasPbMarca";
            this._ComprasPbMarca.Size = new System.Drawing.Size(130, 90);
            this._ComprasPbMarca.TabIndex = 0;
            this._ComprasPbMarca.TabStop = false;
            this._ComprasBtnIconoCierreMovimientos.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoCierreMovimientos
            // 
            this._ComprasBtnIconoCierreMovimientos.AccessibleName = "Cierre de Movimientos";
            this._ComprasBtnIconoCierreMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoCierreMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoCierreMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoCierreMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoCierreMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoCierreMovimientos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoCierreMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoCierreMovimientos.Location = new System.Drawing.Point(6, 726);
            this._ComprasBtnIconoCierreMovimientos.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoCierreMovimientos.Name = "_ComprasBtnIconoCierreMovimientos";
            this._ComprasBtnIconoCierreMovimientos.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoCierreMovimientos.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoCierreMovimientos.TabIndex = 1;
            this._ComprasBtnIconoCierreMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoCierreMovimientos.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoCierreMovimientos.UseVisualStyleBackColor = false;
            this._ComprasBtnCierreMovimientos.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnCierreMovimientos
            // 
            this._ComprasBtnCierreMovimientos.AccessibleName = "Cierre de Movimientos";
            this._ComprasBtnCierreMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnCierreMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnCierreMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnCierreMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnCierreMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnCierreMovimientos.FlatAppearance.BorderSize = 0;
            this._ComprasBtnCierreMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnCierreMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnCierreMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnCierreMovimientos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnCierreMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnCierreMovimientos.Location = new System.Drawing.Point(64, 726);
            this._ComprasBtnCierreMovimientos.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnCierreMovimientos.Name = "_ComprasBtnCierreMovimientos";
            this._ComprasBtnCierreMovimientos.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnCierreMovimientos.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnCierreMovimientos.TabIndex = 2;
            this._ComprasBtnCierreMovimientos.Text = "Cierre de Movimientos";
            this._ComprasBtnCierreMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnCierreMovimientos.UseCompatibleTextRendering = true;
            this._ComprasBtnCierreMovimientos.UseVisualStyleBackColor = false;
            this._ComprasBtnCierreMovimientos.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoAprobacionFinanciera.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoAprobacionFinanciera
            // 
            this._ComprasBtnIconoAprobacionFinanciera.AccessibleName = "Aprobación Financiera";
            this._ComprasBtnIconoAprobacionFinanciera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoAprobacionFinanciera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoAprobacionFinanciera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoAprobacionFinanciera.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoAprobacionFinanciera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoAprobacionFinanciera.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoAprobacionFinanciera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoAprobacionFinanciera.Location = new System.Drawing.Point(6, 638);
            this._ComprasBtnIconoAprobacionFinanciera.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoAprobacionFinanciera.Name = "_ComprasBtnIconoAprobacionFinanciera";
            this._ComprasBtnIconoAprobacionFinanciera.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoAprobacionFinanciera.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoAprobacionFinanciera.TabIndex = 3;
            this._ComprasBtnIconoAprobacionFinanciera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoAprobacionFinanciera.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoAprobacionFinanciera.UseVisualStyleBackColor = false;
            this._ComprasBtnAprobacionFinanciera.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnAprobacionFinanciera
            // 
            this._ComprasBtnAprobacionFinanciera.AccessibleName = "Aprobación Financiera";
            this._ComprasBtnAprobacionFinanciera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnAprobacionFinanciera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnAprobacionFinanciera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnAprobacionFinanciera.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnAprobacionFinanciera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAprobacionFinanciera.FlatAppearance.BorderSize = 0;
            this._ComprasBtnAprobacionFinanciera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnAprobacionFinanciera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnAprobacionFinanciera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnAprobacionFinanciera.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnAprobacionFinanciera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnAprobacionFinanciera.Location = new System.Drawing.Point(64, 638);
            this._ComprasBtnAprobacionFinanciera.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnAprobacionFinanciera.Name = "_ComprasBtnAprobacionFinanciera";
            this._ComprasBtnAprobacionFinanciera.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnAprobacionFinanciera.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnAprobacionFinanciera.TabIndex = 4;
            this._ComprasBtnAprobacionFinanciera.Text = "Aprobación Financiera";
            this._ComprasBtnAprobacionFinanciera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnAprobacionFinanciera.UseCompatibleTextRendering = true;
            this._ComprasBtnAprobacionFinanciera.UseVisualStyleBackColor = false;
            this._ComprasBtnAprobacionFinanciera.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoPagosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoPagosProveedores
            // 
            this._ComprasBtnIconoPagosProveedores.AccessibleName = "Pagos a Proveedores";
            this._ComprasBtnIconoPagosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoPagosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoPagosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoPagosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoPagosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoPagosProveedores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoPagosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoPagosProveedores.Location = new System.Drawing.Point(6, 550);
            this._ComprasBtnIconoPagosProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoPagosProveedores.Name = "_ComprasBtnIconoPagosProveedores";
            this._ComprasBtnIconoPagosProveedores.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoPagosProveedores.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoPagosProveedores.TabIndex = 5;
            this._ComprasBtnIconoPagosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoPagosProveedores.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoPagosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnPagosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnPagosProveedores
            // 
            this._ComprasBtnPagosProveedores.AccessibleName = "Pagos a Proveedores";
            this._ComprasBtnPagosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnPagosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnPagosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnPagosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnPagosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnPagosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnPagosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnPagosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnPagosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnPagosProveedores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnPagosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnPagosProveedores.Location = new System.Drawing.Point(64, 550);
            this._ComprasBtnPagosProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnPagosProveedores.Name = "_ComprasBtnPagosProveedores";
            this._ComprasBtnPagosProveedores.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnPagosProveedores.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnPagosProveedores.TabIndex = 6;
            this._ComprasBtnPagosProveedores.Text = "Pagos a Proveedores";
            this._ComprasBtnPagosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnPagosProveedores.UseCompatibleTextRendering = true;
            this._ComprasBtnPagosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnPagosProveedores.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoOrdenesCompra.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoOrdenesCompra
            // 
            this._ComprasBtnIconoOrdenesCompra.AccessibleName = "Ordenes de Compras";
            this._ComprasBtnIconoOrdenesCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoOrdenesCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoOrdenesCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoOrdenesCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoOrdenesCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoOrdenesCompra.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoOrdenesCompra.Location = new System.Drawing.Point(6, 462);
            this._ComprasBtnIconoOrdenesCompra.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoOrdenesCompra.Name = "_ComprasBtnIconoOrdenesCompra";
            this._ComprasBtnIconoOrdenesCompra.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoOrdenesCompra.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoOrdenesCompra.TabIndex = 7;
            this._ComprasBtnIconoOrdenesCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoOrdenesCompra.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoOrdenesCompra.UseVisualStyleBackColor = false;
            this._ComprasBtnOrdenesCompra.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnOrdenesCompra
            // 
            this._ComprasBtnOrdenesCompra.AccessibleName = "Ordenes de Compras";
            this._ComprasBtnOrdenesCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnOrdenesCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnOrdenesCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnOrdenesCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnOrdenesCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnOrdenesCompra.FlatAppearance.BorderSize = 0;
            this._ComprasBtnOrdenesCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnOrdenesCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnOrdenesCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnOrdenesCompra.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnOrdenesCompra.Location = new System.Drawing.Point(64, 462);
            this._ComprasBtnOrdenesCompra.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnOrdenesCompra.Name = "_ComprasBtnOrdenesCompra";
            this._ComprasBtnOrdenesCompra.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnOrdenesCompra.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnOrdenesCompra.TabIndex = 8;
            this._ComprasBtnOrdenesCompra.Text = "Ordenes de Compras";
            this._ComprasBtnOrdenesCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnOrdenesCompra.UseCompatibleTextRendering = true;
            this._ComprasBtnOrdenesCompra.UseVisualStyleBackColor = false;
            this._ComprasBtnOrdenesCompra.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoMetodosPago.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoMetodosPago
            // 
            this._ComprasBtnIconoMetodosPago.AccessibleName = "Mantenimiento de Métodos de Pago";
            this._ComprasBtnIconoMetodosPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoMetodosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoMetodosPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMetodosPago.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoMetodosPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoMetodosPago.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoMetodosPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoMetodosPago.Location = new System.Drawing.Point(6, 374);
            this._ComprasBtnIconoMetodosPago.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoMetodosPago.Name = "_ComprasBtnIconoMetodosPago";
            this._ComprasBtnIconoMetodosPago.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoMetodosPago.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoMetodosPago.TabIndex = 9;
            this._ComprasBtnIconoMetodosPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoMetodosPago.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoMetodosPago.UseVisualStyleBackColor = false;
            this._ComprasBtnMetodosPago.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnMetodosPago
            // 
            this._ComprasBtnMetodosPago.AccessibleName = "Mantenimiento de Métodos de Pago";
            this._ComprasBtnMetodosPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnMetodosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnMetodosPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnMetodosPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnMetodosPago.FlatAppearance.BorderSize = 0;
            this._ComprasBtnMetodosPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnMetodosPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnMetodosPago.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnMetodosPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnMetodosPago.Location = new System.Drawing.Point(64, 374);
            this._ComprasBtnMetodosPago.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnMetodosPago.Name = "_ComprasBtnMetodosPago";
            this._ComprasBtnMetodosPago.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnMetodosPago.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnMetodosPago.TabIndex = 10;
            this._ComprasBtnMetodosPago.Text = "Mantenimiento de Métodos de Pago";
            this._ComprasBtnMetodosPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnMetodosPago.UseCompatibleTextRendering = true;
            this._ComprasBtnMetodosPago.UseVisualStyleBackColor = false;
            this._ComprasBtnMetodosPago.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoProveedores
            // 
            this._ComprasBtnIconoProveedores.AccessibleName = "Mantenimiento de Proveedores";
            this._ComprasBtnIconoProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoProveedores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoProveedores.Location = new System.Drawing.Point(6, 286);
            this._ComprasBtnIconoProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoProveedores.Name = "_ComprasBtnIconoProveedores";
            this._ComprasBtnIconoProveedores.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoProveedores.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoProveedores.TabIndex = 11;
            this._ComprasBtnIconoProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoProveedores.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnProveedores
            // 
            this._ComprasBtnProveedores.AccessibleName = "Mantenimiento de Proveedores";
            this._ComprasBtnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnProveedores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnProveedores.Location = new System.Drawing.Point(64, 286);
            this._ComprasBtnProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnProveedores.Name = "_ComprasBtnProveedores";
            this._ComprasBtnProveedores.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnProveedores.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnProveedores.TabIndex = 12;
            this._ComprasBtnProveedores.Text = "Mantenimiento de Proveedores";
            this._ComprasBtnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnProveedores.UseCompatibleTextRendering = true;
            this._ComprasBtnProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnProveedores.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoMovimientosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoMovimientosProveedores
            // 
            this._ComprasBtnIconoMovimientosProveedores.AccessibleName = "Movimientos de Proveedores";
            this._ComprasBtnIconoMovimientosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoMovimientosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoMovimientosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoMovimientosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoMovimientosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoMovimientosProveedores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoMovimientosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoMovimientosProveedores.Location = new System.Drawing.Point(6, 110);
            this._ComprasBtnIconoMovimientosProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoMovimientosProveedores.Name = "_ComprasBtnIconoMovimientosProveedores";
            this._ComprasBtnIconoMovimientosProveedores.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoMovimientosProveedores.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoMovimientosProveedores.TabIndex = 13;
            this._ComprasBtnIconoMovimientosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoMovimientosProveedores.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoMovimientosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnMovimientosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnMovimientosProveedores
            // 
            this._ComprasBtnMovimientosProveedores.AccessibleName = "Movimientos de Proveedores";
            this._ComprasBtnMovimientosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnMovimientosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnMovimientosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnMovimientosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnMovimientosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnMovimientosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnMovimientosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnMovimientosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnMovimientosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnMovimientosProveedores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnMovimientosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnMovimientosProveedores.Location = new System.Drawing.Point(64, 110);
            this._ComprasBtnMovimientosProveedores.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnMovimientosProveedores.Name = "_ComprasBtnMovimientosProveedores";
            this._ComprasBtnMovimientosProveedores.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnMovimientosProveedores.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnMovimientosProveedores.TabIndex = 14;
            this._ComprasBtnMovimientosProveedores.Text = "Movimientos de Proveedores";
            this._ComprasBtnMovimientosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnMovimientosProveedores.UseCompatibleTextRendering = true;
            this._ComprasBtnMovimientosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnMovimientosProveedores.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoPolizas.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoPolizas
            // 
            this._ComprasBtnIconoPolizas.AccessibleName = "Pólizas";
            this._ComprasBtnIconoPolizas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoPolizas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoPolizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoPolizas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoPolizas.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoPolizas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoPolizas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoPolizas.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoPolizas.Location = new System.Drawing.Point(6, 198);
            this._ComprasBtnIconoPolizas.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoPolizas.Name = "_ComprasBtnIconoPolizas";
            this._ComprasBtnIconoPolizas.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoPolizas.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoPolizas.TabIndex = 15;
            this._ComprasBtnIconoPolizas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoPolizas.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoPolizas.UseVisualStyleBackColor = false;
            this._ComprasBtnPolizas.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnPolizas
            // 
            this._ComprasBtnPolizas.AccessibleName = "Pólizas";
            this._ComprasBtnPolizas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnPolizas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnPolizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnPolizas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnPolizas.FlatAppearance.BorderSize = 0;
            this._ComprasBtnPolizas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnPolizas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnPolizas.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnPolizas.Location = new System.Drawing.Point(64, 198);
            this._ComprasBtnPolizas.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnPolizas.Name = "_ComprasBtnPolizas";
            this._ComprasBtnPolizas.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnPolizas.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnPolizas.TabIndex = 16;
            this._ComprasBtnPolizas.Text = "Pólizas";
            this._ComprasBtnPolizas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnPolizas.UseCompatibleTextRendering = true;
            this._ComprasBtnPolizas.UseVisualStyleBackColor = false;
            this._ComprasBtnPolizas.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoBitacora.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoBitacora
            // 
            this._ComprasBtnIconoBitacora.AccessibleName = "Bitácora";
            this._ComprasBtnIconoBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoBitacora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoBitacora.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoBitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoBitacora.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoBitacora.Location = new System.Drawing.Point(6, 814);
            this._ComprasBtnIconoBitacora.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoBitacora.Name = "_ComprasBtnIconoBitacora";
            this._ComprasBtnIconoBitacora.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoBitacora.Size = new System.Drawing.Size(58, 84);
            this._ComprasBtnIconoBitacora.TabIndex = 17;
            this._ComprasBtnIconoBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoBitacora.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoBitacora.UseVisualStyleBackColor = false;
            this._ComprasBtnBitacora.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnBitacora
            // 
            this._ComprasBtnBitacora.AccessibleName = "Bitácora";
            this._ComprasBtnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnBitacora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnBitacora.FlatAppearance.BorderSize = 0;
            this._ComprasBtnBitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnBitacora.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnBitacora.Location = new System.Drawing.Point(64, 814);
            this._ComprasBtnBitacora.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnBitacora.Name = "_ComprasBtnBitacora";
            this._ComprasBtnBitacora.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnBitacora.Size = new System.Drawing.Size(200, 84);
            this._ComprasBtnBitacora.TabIndex = 18;
            this._ComprasBtnBitacora.Text = "Bitácora";
            this._ComprasBtnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnBitacora.UseCompatibleTextRendering = true;
            this._ComprasBtnBitacora.UseVisualStyleBackColor = false;
            this._ComprasBtnBitacora.Click += new System.EventHandler(this.ComprasMetOpcionPendienteClick);
            this._ComprasBtnIconoSalir.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoSalir
            // 
            this._ComprasBtnIconoSalir.AccessibleName = "Salir";
            this._ComprasBtnIconoSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnIconoSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoSalir.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoSalir.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnIconoSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnIconoSalir.Location = new System.Drawing.Point(6, 902);
            this._ComprasBtnIconoSalir.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnIconoSalir.Name = "_ComprasBtnIconoSalir";
            this._ComprasBtnIconoSalir.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnIconoSalir.Size = new System.Drawing.Size(58, 86);
            this._ComprasBtnIconoSalir.TabIndex = 19;
            this._ComprasBtnIconoSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnIconoSalir.UseCompatibleTextRendering = true;
            this._ComprasBtnIconoSalir.UseVisualStyleBackColor = false;
            this._ComprasBtnSalir.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnSalir
            // 
            this._ComprasBtnSalir.AccessibleName = "Salir";
            this._ComprasBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSalir.FlatAppearance.BorderSize = 0;
            this._ComprasBtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnSalir.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._ComprasBtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnSalir.Location = new System.Drawing.Point(64, 902);
            this._ComprasBtnSalir.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this._ComprasBtnSalir.Name = "_ComprasBtnSalir";
            this._ComprasBtnSalir.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._ComprasBtnSalir.Size = new System.Drawing.Size(200, 86);
            this._ComprasBtnSalir.TabIndex = 20;
            this._ComprasBtnSalir.Text = "Salir";
            this._ComprasBtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnSalir.UseCompatibleTextRendering = true;
            this._ComprasBtnSalir.UseVisualStyleBackColor = false;
            this._ComprasBtnSalir.Click += new System.EventHandler(this.ComprasBtnSalir_Click);
            // 
            // _ComprasTlpEncabezado
            // 
            this._ComprasTlpEncabezado.ColumnCount = 5;
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this._ComprasTlpEncabezado.Controls.Add(this._ComprasBtnAlternarNavegador, 0, 0);
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrUsuarioTexto, 1, 0);
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrUsuario, 2, 0);
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrRolTexto, 3, 0);
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrRol, 4, 0);
            this._ComprasTlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpEncabezado.Location = new System.Drawing.Point(303, 17);
            this._ComprasTlpEncabezado.Name = "_ComprasTlpEncabezado";
            this._ComprasTlpEncabezado.RowCount = 1;
            this._ComprasTlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpEncabezado.Size = new System.Drawing.Size(1234, 40);
            this._ComprasTlpEncabezado.TabIndex = 1;
            this._ComprasBtnAlternarNavegador.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnAlternarNavegador
            // 
            this._ComprasBtnAlternarNavegador.AccessibleName = "Contraer menú";
            this._ComprasBtnAlternarNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasBtnAlternarNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // ComprasUsrUsuarioTexto
            // 
            this.ComprasUsrUsuarioTexto.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrUsuarioTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrUsuarioTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrUsuarioTexto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ComprasUsrUsuarioTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrUsuarioTexto.Location = new System.Drawing.Point(58, 0);
            this.ComprasUsrUsuarioTexto.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrUsuarioTexto.MaximumSize = new System.Drawing.Size(1375, 0);
            this.ComprasUsrUsuarioTexto.MostrarAsterisco = false;
            this.ComprasUsrUsuarioTexto.Name = "ComprasUsrUsuarioTexto";
            this.ComprasUsrUsuarioTexto.Size = new System.Drawing.Size(85, 40);
            this.ComprasUsrUsuarioTexto.TabIndex = 1;
            this.ComprasUsrUsuarioTexto.TabStop = false;
            this.ComprasUsrUsuarioTexto.TamanoTipografia = 12F;
            this.ComprasUsrUsuarioTexto.Text = "Usuario:";
            this.ComprasUsrUsuarioTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrUsuarioTexto.Texto = "Usuario:";
            // 
            // ComprasUsrUsuario
            // 
            this.ComprasUsrUsuario.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrUsuario.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ComprasUsrUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrUsuario.Location = new System.Drawing.Point(143, 0);
            this.ComprasUsrUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrUsuario.MaximumSize = new System.Drawing.Size(1375, 0);
            this.ComprasUsrUsuario.MostrarAsterisco = false;
            this.ComprasUsrUsuario.Name = "ComprasUsrUsuario";
            this.ComprasUsrUsuario.Size = new System.Drawing.Size(650, 40);
            this.ComprasUsrUsuario.TabIndex = 2;
            this.ComprasUsrUsuario.TabStop = false;
            this.ComprasUsrUsuario.TamanoTipografia = 12F;
            this.ComprasUsrUsuario.Text = "";
            this.ComprasUsrUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrUsuario.Texto = "";
            // 
            // ComprasUsrRolTexto
            // 
            this.ComprasUsrRolTexto.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrRolTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrRolTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrRolTexto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ComprasUsrRolTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrRolTexto.Location = new System.Drawing.Point(793, 0);
            this.ComprasUsrRolTexto.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrRolTexto.MaximumSize = new System.Drawing.Size(1375, 0);
            this.ComprasUsrRolTexto.MostrarAsterisco = false;
            this.ComprasUsrRolTexto.Name = "ComprasUsrRolTexto";
            this.ComprasUsrRolTexto.Size = new System.Drawing.Size(42, 40);
            this.ComprasUsrRolTexto.TabIndex = 3;
            this.ComprasUsrRolTexto.TabStop = false;
            this.ComprasUsrRolTexto.TamanoTipografia = 12F;
            this.ComprasUsrRolTexto.Text = "Rol:";
            this.ComprasUsrRolTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrRolTexto.Texto = "Rol:";
            // 
            // ComprasUsrRol
            // 
            this.ComprasUsrRol.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrRol.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ComprasUsrRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrRol.Location = new System.Drawing.Point(835, 0);
            this.ComprasUsrRol.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrRol.MaximumSize = new System.Drawing.Size(1375, 0);
            this.ComprasUsrRol.MostrarAsterisco = false;
            this.ComprasUsrRol.Name = "ComprasUsrRol";
            this.ComprasUsrRol.Size = new System.Drawing.Size(399, 40);
            this.ComprasUsrRol.TabIndex = 4;
            this.ComprasUsrRol.TabStop = false;
            this.ComprasUsrRol.TamanoTipografia = 12F;
            this.ComprasUsrRol.Text = "";
            this.ComprasUsrRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrRol.Texto = "";
            // 
            // _ComprasPnlMain
            // 
            this._ComprasPnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasPnlMain.Controls.Add(this.usrDashboardCompras1);
            this._ComprasPnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasPnlMain.Location = new System.Drawing.Point(300, 65);
            this._ComprasPnlMain.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._ComprasPnlMain.Name = "_ComprasPnlMain";
            this._ComprasPnlMain.Size = new System.Drawing.Size(1240, 976);
            this._ComprasPnlMain.TabIndex = 2;
            // 
            // usrDashboardCompras1
            // 
            this.usrDashboardCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrDashboardCompras1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrDashboardCompras1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usrDashboardCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrDashboardCompras1.Location = new System.Drawing.Point(0, 0);
            this.usrDashboardCompras1.Margin = new System.Windows.Forms.Padding(0);
            this.usrDashboardCompras1.Name = "usrDashboardCompras1";
            this.usrDashboardCompras1.Size = new System.Drawing.Size(1240, 976);
            this.usrDashboardCompras1.TabIndex = 0;
            // 
            // FrmMDICompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1554, 1055);
            this.Controls.Add(this._ComprasTlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FrmMDICompras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMDICompras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._ComprasTlpPrincipal.ResumeLayout(false);
            this._ComprasTlpNavegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).EndInit();
            this._ComprasTlpEncabezado.ResumeLayout(false);
            this._ComprasPnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoPolizas;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnPolizas;
        private System.Windows.Forms.TableLayoutPanel _ComprasTlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel _ComprasTlpNavegador;
        private System.Windows.Forms.PictureBox _ComprasPbMarca;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoCierreMovimientos;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnCierreMovimientos;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoAprobacionFinanciera;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnAprobacionFinanciera;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoPagosProveedores;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnPagosProveedores;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoOrdenesCompra;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnOrdenesCompra;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoMetodosPago;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnMetodosPago;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoProveedores;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnProveedores;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoMovimientosProveedores;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnMovimientosProveedores;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoBitacora;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnBitacora;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnIconoSalir;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnSalir;
        private System.Windows.Forms.TableLayoutPanel _ComprasTlpEncabezado;
        private CapaVista_Compras.Componentes.ClsButtonCompras _ComprasBtnAlternarNavegador;
        private CapaVista_Compras.Componentes.UsrLabelCompras ComprasUsrUsuarioTexto;
        private CapaVista_Compras.Componentes.UsrLabelCompras ComprasUsrUsuario;
        private CapaVista_Compras.Componentes.UsrLabelCompras ComprasUsrRolTexto;
        private CapaVista_Compras.Componentes.UsrLabelCompras ComprasUsrRol;
        private Componentes.ClsPanelCompras _ComprasPnlMain;
        private UsrDashboardCompras usrDashboardCompras1;
    }
}
