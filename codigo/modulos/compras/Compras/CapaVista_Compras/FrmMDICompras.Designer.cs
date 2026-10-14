namespace CapaVista_Compras
{
    partial class FrmMDICompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDICompras));
            this._ComprasTlpPrincipal = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasPnlMain = new CapaVista_Compras.Componentes.ClsPanelCompras();
            this.ComprasUsrInicio = new CapaVista_Compras.UsrDashboardCompras();
            this._ComprasTlpEncabezado = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrRol = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrRolTexto = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrUsuario = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasBtnAlternarNavegador = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this.ComprasUsrUsuarioTexto = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasTlpNavegador = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasBtnIconoInicio = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoSalir = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoBitacora = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoCierreMovimientos = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoAprobacionFinanciera = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoPagosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoOrdenesCompra = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoMetodosPago = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnCierreMovimientos = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnAprobacionFinanciera = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnPagosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnOrdenesCompra = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnMetodosPago = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnMovimientosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasPbMarca = new System.Windows.Forms.PictureBox();
            this._ComprasBtnBitacora = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnIconoMovimientosProveedores = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnSalir = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnInicio = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasTlpPrincipal.SuspendLayout();
            this._ComprasPnlMain.SuspendLayout();
            this._ComprasTlpEncabezado.SuspendLayout();
            this._ComprasTlpNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // _ComprasTlpPrincipal
            // 
            this._ComprasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpPrincipal.ColumnCount = 2;
            this._ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this._ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasPnlMain, 1, 1);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasTlpEncabezado, 1, 0);
            this._ComprasTlpPrincipal.Controls.Add(this._ComprasTlpNavegador, 0, 0);
            this._ComprasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpPrincipal.Name = "_ComprasTlpPrincipal";
            this._ComprasTlpPrincipal.RowCount = 3;
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._ComprasTlpPrincipal.Size = new System.Drawing.Size(1902, 853);
            this._ComprasTlpPrincipal.TabIndex = 0;
            // 
            // _ComprasPnlMain
            // 
            this._ComprasPnlMain.AutoScroll = true;
            this._ComprasPnlMain.AutoSize = true;
            this._ComprasPnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasPnlMain.Controls.Add(this.ComprasUsrInicio);
            this._ComprasPnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasPnlMain.Location = new System.Drawing.Point(262, 60);
            this._ComprasPnlMain.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlMain.Name = "_ComprasPnlMain";
            this._ComprasPnlMain.Padding = new System.Windows.Forms.Padding(15);
            this._ComprasPnlMain.Size = new System.Drawing.Size(1640, 753);
            this._ComprasPnlMain.TabIndex = 2;
            // 
            // ComprasUsrInicio
            // 
            this.ComprasUsrInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComprasUsrInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrInicio.Location = new System.Drawing.Point(15, 15);
            this.ComprasUsrInicio.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrInicio.Name = "ComprasUsrInicio";
            this.ComprasUsrInicio.Size = new System.Drawing.Size(1610, 723);
            this.ComprasUsrInicio.TabIndex = 0;
            // 
            // _ComprasTlpEncabezado
            // 
            this._ComprasTlpEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpEncabezado.ColumnCount = 5;
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrRol, 4, 0);
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrRolTexto, 3, 0);
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrUsuario, 2, 0);
            this._ComprasTlpEncabezado.Controls.Add(this._ComprasBtnAlternarNavegador, 0, 0);
            this._ComprasTlpEncabezado.Controls.Add(this.ComprasUsrUsuarioTexto, 1, 0);
            this._ComprasTlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpEncabezado.Location = new System.Drawing.Point(262, 0);
            this._ComprasTlpEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpEncabezado.Name = "_ComprasTlpEncabezado";
            this._ComprasTlpEncabezado.RowCount = 1;
            this._ComprasTlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpEncabezado.Size = new System.Drawing.Size(1640, 60);
            this._ComprasTlpEncabezado.TabIndex = 3;
            // 
            // ComprasUsrRol
            // 
            this.ComprasUsrRol.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrRol.AutoSize = true;
            this.ComprasUsrRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrRol.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ComprasUsrRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrRol.Location = new System.Drawing.Point(524, 5);
            this.ComprasUsrRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComprasUsrRol.MaximumSize = new System.Drawing.Size(1500, 0);
            this.ComprasUsrRol.MostrarAsterisco = false;
            this.ComprasUsrRol.Name = "ComprasUsrRol";
            this.ComprasUsrRol.Size = new System.Drawing.Size(1112, 50);
            this.ComprasUsrRol.TabIndex = 25;
            this.ComprasUsrRol.TabStop = false;
            this.ComprasUsrRol.Text = "";
            this.ComprasUsrRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrRol.Texto = "";
            // 
            // ComprasUsrRolTexto
            // 
            this.ComprasUsrRolTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrRolTexto.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComprasUsrRolTexto.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ComprasUsrRolTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrRolTexto.Location = new System.Drawing.Point(449, 5);
            this.ComprasUsrRolTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComprasUsrRolTexto.MaximumSize = new System.Drawing.Size(1500, 0);
            this.ComprasUsrRolTexto.MostrarAsterisco = false;
            this.ComprasUsrRolTexto.Name = "ComprasUsrRolTexto";
            this.ComprasUsrRolTexto.Size = new System.Drawing.Size(67, 50);
            this.ComprasUsrRolTexto.TabIndex = 24;
            this.ComprasUsrRolTexto.TabStop = false;
            this.ComprasUsrRolTexto.Text = "Rol:";
            this.ComprasUsrRolTexto.Texto = "Rol:";
            // 
            // ComprasUsrUsuario
            // 
            this.ComprasUsrUsuario.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrUsuario.AutoSize = true;
            this.ComprasUsrUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrUsuario.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ComprasUsrUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrUsuario.Location = new System.Drawing.Point(199, 5);
            this.ComprasUsrUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComprasUsrUsuario.MaximumSize = new System.Drawing.Size(1500, 0);
            this.ComprasUsrUsuario.MostrarAsterisco = false;
            this.ComprasUsrUsuario.Name = "ComprasUsrUsuario";
            this.ComprasUsrUsuario.Size = new System.Drawing.Size(242, 50);
            this.ComprasUsrUsuario.TabIndex = 23;
            this.ComprasUsrUsuario.TabStop = false;
            this.ComprasUsrUsuario.Text = "";
            this.ComprasUsrUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrUsuario.Texto = "";
            this._ComprasBtnAlternarNavegador.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnAlternarNavegador
            // 
            this._ComprasBtnAlternarNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnAlternarNavegador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnAlternarNavegador.BackgroundImage")));
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
            this._ComprasBtnAlternarNavegador.Size = new System.Drawing.Size(90, 60);
            this._ComprasBtnAlternarNavegador.TabIndex = 21;
            this._ComprasBtnAlternarNavegador.UseVisualStyleBackColor = true;
            this._ComprasBtnAlternarNavegador.Click += new System.EventHandler(this.ComprasBtnBurger_Click);
            // 
            // ComprasUsrUsuarioTexto
            // 
            this.ComprasUsrUsuarioTexto.AutoSize = true;
            this.ComprasUsrUsuarioTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrUsuarioTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrUsuarioTexto.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ComprasUsrUsuarioTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrUsuarioTexto.Location = new System.Drawing.Point(94, 5);
            this.ComprasUsrUsuarioTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComprasUsrUsuarioTexto.MaximumSize = new System.Drawing.Size(1500, 0);
            this.ComprasUsrUsuarioTexto.MostrarAsterisco = false;
            this.ComprasUsrUsuarioTexto.Name = "ComprasUsrUsuarioTexto";
            this.ComprasUsrUsuarioTexto.Size = new System.Drawing.Size(97, 50);
            this.ComprasUsrUsuarioTexto.TabIndex = 22;
            this.ComprasUsrUsuarioTexto.TabStop = false;
            this.ComprasUsrUsuarioTexto.Text = "Usuario:";
            this.ComprasUsrUsuarioTexto.Texto = "Usuario:";
            // 
            // _ComprasTlpNavegador
            // 
            this._ComprasTlpNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasTlpNavegador.ColumnCount = 2;
            this._ComprasTlpNavegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this._ComprasTlpNavegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoInicio, 0, 1);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoSalir, 0, 10);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoBitacora, 0, 9);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoCierreMovimientos, 0, 8);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoAprobacionFinanciera, 0, 7);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoPagosProveedores, 0, 6);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoOrdenesCompra, 0, 5);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoMetodosPago, 0, 4);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoProveedores, 0, 3);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnCierreMovimientos, 1, 8);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnAprobacionFinanciera, 1, 7);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnPagosProveedores, 1, 6);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnOrdenesCompra, 1, 5);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnMetodosPago, 1, 4);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnProveedores, 1, 3);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnMovimientosProveedores, 1, 2);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasPbMarca, 1, 0);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnBitacora, 1, 9);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnIconoMovimientosProveedores, 0, 2);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnSalir, 1, 10);
            this._ComprasTlpNavegador.Controls.Add(this._ComprasBtnInicio, 1, 1);
            this._ComprasTlpNavegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpNavegador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpNavegador.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this._ComprasTlpNavegador.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpNavegador.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpNavegador.Name = "_ComprasTlpNavegador";
            this._ComprasTlpNavegador.RowCount = 12;
            this._ComprasTlpPrincipal.SetRowSpan(this._ComprasTlpNavegador, 3);
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._ComprasTlpNavegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this._ComprasTlpNavegador.Size = new System.Drawing.Size(262, 853);
            this._ComprasTlpNavegador.TabIndex = 1;
            this._ComprasBtnIconoInicio.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoInicio
            // 
            this._ComprasBtnIconoInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoInicio.BackgroundImage")));
            this._ComprasBtnIconoInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoInicio.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoInicio.Location = new System.Drawing.Point(0, 171);
            this._ComprasBtnIconoInicio.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoInicio.Name = "_ComprasBtnIconoInicio";
            this._ComprasBtnIconoInicio.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoInicio.TabIndex = 31;
            this._ComprasBtnIconoInicio.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoSalir.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoSalir
            // 
            this._ComprasBtnIconoSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoSalir.BackgroundImage")));
            this._ComprasBtnIconoSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoSalir.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoSalir.Location = new System.Drawing.Point(0, 711);
            this._ComprasBtnIconoSalir.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoSalir.Name = "_ComprasBtnIconoSalir";
            this._ComprasBtnIconoSalir.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoSalir.TabIndex = 29;
            this._ComprasBtnIconoSalir.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoBitacora.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoBitacora
            // 
            this._ComprasBtnIconoBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoBitacora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoBitacora.BackgroundImage")));
            this._ComprasBtnIconoBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoBitacora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoBitacora.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoBitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoBitacora.Location = new System.Drawing.Point(0, 651);
            this._ComprasBtnIconoBitacora.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoBitacora.Name = "_ComprasBtnIconoBitacora";
            this._ComprasBtnIconoBitacora.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoBitacora.TabIndex = 27;
            this._ComprasBtnIconoBitacora.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoCierreMovimientos.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoCierreMovimientos
            // 
            this._ComprasBtnIconoCierreMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoCierreMovimientos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoCierreMovimientos.BackgroundImage")));
            this._ComprasBtnIconoCierreMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoCierreMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoCierreMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoCierreMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoCierreMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoCierreMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoCierreMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoCierreMovimientos.Location = new System.Drawing.Point(0, 591);
            this._ComprasBtnIconoCierreMovimientos.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoCierreMovimientos.Name = "_ComprasBtnIconoCierreMovimientos";
            this._ComprasBtnIconoCierreMovimientos.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoCierreMovimientos.TabIndex = 26;
            this._ComprasBtnIconoCierreMovimientos.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoAprobacionFinanciera.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoAprobacionFinanciera
            // 
            this._ComprasBtnIconoAprobacionFinanciera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoAprobacionFinanciera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoAprobacionFinanciera.BackgroundImage")));
            this._ComprasBtnIconoAprobacionFinanciera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoAprobacionFinanciera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoAprobacionFinanciera.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoAprobacionFinanciera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoAprobacionFinanciera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoAprobacionFinanciera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoAprobacionFinanciera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoAprobacionFinanciera.Location = new System.Drawing.Point(0, 531);
            this._ComprasBtnIconoAprobacionFinanciera.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoAprobacionFinanciera.Name = "_ComprasBtnIconoAprobacionFinanciera";
            this._ComprasBtnIconoAprobacionFinanciera.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoAprobacionFinanciera.TabIndex = 25;
            this._ComprasBtnIconoAprobacionFinanciera.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoPagosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoPagosProveedores
            // 
            this._ComprasBtnIconoPagosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoPagosProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoPagosProveedores.BackgroundImage")));
            this._ComprasBtnIconoPagosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoPagosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoPagosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoPagosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoPagosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoPagosProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoPagosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoPagosProveedores.Location = new System.Drawing.Point(0, 471);
            this._ComprasBtnIconoPagosProveedores.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoPagosProveedores.Name = "_ComprasBtnIconoPagosProveedores";
            this._ComprasBtnIconoPagosProveedores.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoPagosProveedores.TabIndex = 24;
            this._ComprasBtnIconoPagosProveedores.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoOrdenesCompra.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoOrdenesCompra
            // 
            this._ComprasBtnIconoOrdenesCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoOrdenesCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoOrdenesCompra.BackgroundImage")));
            this._ComprasBtnIconoOrdenesCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoOrdenesCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoOrdenesCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoOrdenesCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoOrdenesCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoOrdenesCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoOrdenesCompra.Location = new System.Drawing.Point(0, 411);
            this._ComprasBtnIconoOrdenesCompra.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoOrdenesCompra.Name = "_ComprasBtnIconoOrdenesCompra";
            this._ComprasBtnIconoOrdenesCompra.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoOrdenesCompra.TabIndex = 23;
            this._ComprasBtnIconoOrdenesCompra.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoMetodosPago.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoMetodosPago
            // 
            this._ComprasBtnIconoMetodosPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoMetodosPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoMetodosPago.BackgroundImage")));
            this._ComprasBtnIconoMetodosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoMetodosPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMetodosPago.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoMetodosPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoMetodosPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoMetodosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoMetodosPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMetodosPago.Location = new System.Drawing.Point(0, 351);
            this._ComprasBtnIconoMetodosPago.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoMetodosPago.Name = "_ComprasBtnIconoMetodosPago";
            this._ComprasBtnIconoMetodosPago.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoMetodosPago.TabIndex = 22;
            this._ComprasBtnIconoMetodosPago.UseVisualStyleBackColor = true;
            this._ComprasBtnIconoProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoProveedores
            // 
            this._ComprasBtnIconoProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoProveedores.BackgroundImage")));
            this._ComprasBtnIconoProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoProveedores.Location = new System.Drawing.Point(0, 291);
            this._ComprasBtnIconoProveedores.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoProveedores.Name = "_ComprasBtnIconoProveedores";
            this._ComprasBtnIconoProveedores.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoProveedores.TabIndex = 21;
            this._ComprasBtnIconoProveedores.UseVisualStyleBackColor = true;
            this._ComprasBtnCierreMovimientos.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnCierreMovimientos
            // 
            this._ComprasBtnCierreMovimientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnCierreMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnCierreMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnCierreMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnCierreMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnCierreMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnCierreMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnCierreMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnCierreMovimientos.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnCierreMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnCierreMovimientos.Location = new System.Drawing.Point(67, 595);
            this._ComprasBtnCierreMovimientos.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnCierreMovimientos.Name = "_ComprasBtnCierreMovimientos";
            this._ComprasBtnCierreMovimientos.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnCierreMovimientos.TabIndex = 7;
            this._ComprasBtnCierreMovimientos.Text = "Cierre de Movimientos";
            this._ComprasBtnCierreMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnCierreMovimientos.UseVisualStyleBackColor = false;
            this._ComprasBtnCierreMovimientos.Click += new System.EventHandler(this.ComprasMetBtnCierreMovimientosClick);
            this._ComprasBtnAprobacionFinanciera.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnAprobacionFinanciera
            // 
            this._ComprasBtnAprobacionFinanciera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnAprobacionFinanciera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnAprobacionFinanciera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnAprobacionFinanciera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnAprobacionFinanciera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAprobacionFinanciera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnAprobacionFinanciera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnAprobacionFinanciera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnAprobacionFinanciera.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnAprobacionFinanciera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAprobacionFinanciera.Location = new System.Drawing.Point(67, 535);
            this._ComprasBtnAprobacionFinanciera.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnAprobacionFinanciera.Name = "_ComprasBtnAprobacionFinanciera";
            this._ComprasBtnAprobacionFinanciera.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnAprobacionFinanciera.TabIndex = 6;
            this._ComprasBtnAprobacionFinanciera.Text = "Aprobación Financiera";
            this._ComprasBtnAprobacionFinanciera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnAprobacionFinanciera.UseVisualStyleBackColor = false;
            this._ComprasBtnAprobacionFinanciera.Click += new System.EventHandler(this.ComprasMetBtnAprobacionFinancieraClick);
            this._ComprasBtnPagosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnPagosProveedores
            // 
            this._ComprasBtnPagosProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnPagosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnPagosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnPagosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnPagosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnPagosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnPagosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnPagosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnPagosProveedores.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnPagosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnPagosProveedores.Location = new System.Drawing.Point(67, 475);
            this._ComprasBtnPagosProveedores.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnPagosProveedores.Name = "_ComprasBtnPagosProveedores";
            this._ComprasBtnPagosProveedores.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnPagosProveedores.TabIndex = 5;
            this._ComprasBtnPagosProveedores.Text = "Pagos a Proveedores";
            this._ComprasBtnPagosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnPagosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnPagosProveedores.Click += new System.EventHandler(this.ComprasMetBtnPagosProveedoresClick);
            this._ComprasBtnOrdenesCompra.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnOrdenesCompra
            // 
            this._ComprasBtnOrdenesCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnOrdenesCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnOrdenesCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnOrdenesCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnOrdenesCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnOrdenesCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnOrdenesCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnOrdenesCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnOrdenesCompra.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnOrdenesCompra.Location = new System.Drawing.Point(67, 415);
            this._ComprasBtnOrdenesCompra.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnOrdenesCompra.Name = "_ComprasBtnOrdenesCompra";
            this._ComprasBtnOrdenesCompra.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnOrdenesCompra.TabIndex = 4;
            this._ComprasBtnOrdenesCompra.Text = "Ordenes de Compras";
            this._ComprasBtnOrdenesCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnOrdenesCompra.UseVisualStyleBackColor = false;
            this._ComprasBtnOrdenesCompra.Click += new System.EventHandler(this.ComprasMetBtnOrdenesCompraClick);
            this._ComprasBtnMetodosPago.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnMetodosPago
            // 
            this._ComprasBtnMetodosPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnMetodosPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnMetodosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnMetodosPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnMetodosPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnMetodosPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnMetodosPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnMetodosPago.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnMetodosPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnMetodosPago.Location = new System.Drawing.Point(67, 355);
            this._ComprasBtnMetodosPago.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnMetodosPago.Name = "_ComprasBtnMetodosPago";
            this._ComprasBtnMetodosPago.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnMetodosPago.TabIndex = 3;
            this._ComprasBtnMetodosPago.Text = "Mantenimiento de Métodos de Pago";
            this._ComprasBtnMetodosPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnMetodosPago.UseVisualStyleBackColor = false;
            this._ComprasBtnMetodosPago.Click += new System.EventHandler(this.ComprasMetBtnMetodosPagoClick);
            this._ComprasBtnProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnProveedores
            // 
            this._ComprasBtnProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnProveedores.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnProveedores.Location = new System.Drawing.Point(67, 295);
            this._ComprasBtnProveedores.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnProveedores.Name = "_ComprasBtnProveedores";
            this._ComprasBtnProveedores.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnProveedores.TabIndex = 2;
            this._ComprasBtnProveedores.Text = "Mantenimiento de Proveedores";
            this._ComprasBtnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnProveedores.Click += new System.EventHandler(this.ComprasMetBtnProveedoresClick);
            this._ComprasBtnMovimientosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnMovimientosProveedores
            // 
            this._ComprasBtnMovimientosProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnMovimientosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnMovimientosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnMovimientosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnMovimientosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnMovimientosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnMovimientosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnMovimientosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnMovimientosProveedores.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnMovimientosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnMovimientosProveedores.Location = new System.Drawing.Point(67, 235);
            this._ComprasBtnMovimientosProveedores.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnMovimientosProveedores.Name = "_ComprasBtnMovimientosProveedores";
            this._ComprasBtnMovimientosProveedores.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnMovimientosProveedores.TabIndex = 1;
            this._ComprasBtnMovimientosProveedores.Text = "Movimientos de Proveedores";
            this._ComprasBtnMovimientosProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnMovimientosProveedores.UseVisualStyleBackColor = false;
            this._ComprasBtnMovimientosProveedores.Click += new System.EventHandler(this.ComprasMetBtnMovimientosProveedoresClick);
            // 
            // _ComprasPbMarca
            // 
            this._ComprasPbMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasPbMarca.BackColor = System.Drawing.Color.Transparent;
            this._ComprasPbMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasPbMarca.BackgroundImage")));
            this._ComprasPbMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasPbMarca.Location = new System.Drawing.Point(88, 10);
            this._ComprasPbMarca.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this._ComprasPbMarca.Name = "_ComprasPbMarca";
            this._ComprasPbMarca.Size = new System.Drawing.Size(150, 150);
            this._ComprasPbMarca.TabIndex = 0;
            this._ComprasPbMarca.TabStop = false;
            this._ComprasBtnBitacora.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnBitacora
            // 
            this._ComprasBtnBitacora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnBitacora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnBitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnBitacora.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnBitacora.Location = new System.Drawing.Point(67, 655);
            this._ComprasBtnBitacora.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnBitacora.Name = "_ComprasBtnBitacora";
            this._ComprasBtnBitacora.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnBitacora.TabIndex = 18;
            this._ComprasBtnBitacora.Text = "Bitácora";
            this._ComprasBtnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnBitacora.UseVisualStyleBackColor = false;
            this._ComprasBtnIconoMovimientosProveedores.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.Libre;
            // 
            // _ComprasBtnIconoMovimientosProveedores
            // 
            this._ComprasBtnIconoMovimientosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnIconoMovimientosProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnIconoMovimientosProveedores.BackgroundImage")));
            this._ComprasBtnIconoMovimientosProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnIconoMovimientosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnIconoMovimientosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.BorderSize = 0;
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnIconoMovimientosProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnIconoMovimientosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnIconoMovimientosProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnIconoMovimientosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnIconoMovimientosProveedores.Location = new System.Drawing.Point(0, 231);
            this._ComprasBtnIconoMovimientosProveedores.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnIconoMovimientosProveedores.Name = "_ComprasBtnIconoMovimientosProveedores";
            this._ComprasBtnIconoMovimientosProveedores.Size = new System.Drawing.Size(65, 60);
            this._ComprasBtnIconoMovimientosProveedores.TabIndex = 20;
            this._ComprasBtnIconoMovimientosProveedores.UseVisualStyleBackColor = true;
            this._ComprasBtnSalir.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnSalir
            // 
            this._ComprasBtnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnSalir.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSalir.Location = new System.Drawing.Point(67, 715);
            this._ComprasBtnSalir.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnSalir.Name = "_ComprasBtnSalir";
            this._ComprasBtnSalir.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnSalir.TabIndex = 28;
            this._ComprasBtnSalir.Text = "Salir";
            this._ComprasBtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnSalir.UseVisualStyleBackColor = false;
            this._ComprasBtnSalir.Click += new System.EventHandler(this.ComprasBtnSalir_Click);
            this._ComprasBtnInicio.TipoBoton = CapaVista_Compras.Componentes.ComprasTipoBoton.MDI;
            // 
            // _ComprasBtnInicio
            // 
            this._ComprasBtnInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ComprasBtnInicio.Font = new System.Drawing.Font("Tahoma", 10F);
            this._ComprasBtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnInicio.Location = new System.Drawing.Point(67, 175);
            this._ComprasBtnInicio.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnInicio.Name = "_ComprasBtnInicio";
            this._ComprasBtnInicio.Size = new System.Drawing.Size(193, 52);
            this._ComprasBtnInicio.TabIndex = 30;
            this._ComprasBtnInicio.Text = "Dashboard";
            this._ComprasBtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ComprasBtnInicio.UseVisualStyleBackColor = false;
            this._ComprasBtnInicio.Click += new System.EventHandler(this.ComprasBtnDashboard_Click);
            // 
            // FrmMDICompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1902, 853);
            this.Controls.Add(this._ComprasTlpPrincipal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMDICompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMDICompras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._ComprasTlpPrincipal.ResumeLayout(false);
            this._ComprasTlpPrincipal.PerformLayout();
            this._ComprasPnlMain.ResumeLayout(false);
            this._ComprasTlpEncabezado.ResumeLayout(false);
            this._ComprasTlpEncabezado.PerformLayout();
            this._ComprasTlpNavegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.ClsTableLayoutPanelCompras _ComprasTlpPrincipal;
        private CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras _ComprasTlpNavegador;
        private System.Windows.Forms.PictureBox _ComprasPbMarca;
        private Componentes.ClsButtonCompras _ComprasBtnCierreMovimientos;
        private Componentes.ClsButtonCompras _ComprasBtnAprobacionFinanciera;
        private Componentes.ClsButtonCompras _ComprasBtnPagosProveedores;
        private Componentes.ClsButtonCompras _ComprasBtnOrdenesCompra;
        private Componentes.ClsButtonCompras _ComprasBtnMetodosPago;
        private Componentes.ClsButtonCompras _ComprasBtnProveedores;
        private Componentes.ClsButtonCompras _ComprasBtnMovimientosProveedores;
        private Componentes.ClsPanelCompras _ComprasPnlMain;
        private Componentes.ClsTableLayoutPanelCompras _ComprasTlpEncabezado;
        private Componentes.ClsButtonCompras _ComprasBtnBitacora;
        private Componentes.ClsButtonCompras _ComprasBtnIconoMovimientosProveedores;
        private Componentes.ClsButtonCompras _ComprasBtnIconoBitacora;
        private Componentes.ClsButtonCompras _ComprasBtnIconoCierreMovimientos;
        private Componentes.ClsButtonCompras _ComprasBtnIconoAprobacionFinanciera;
        private Componentes.ClsButtonCompras _ComprasBtnIconoPagosProveedores;
        private Componentes.ClsButtonCompras _ComprasBtnIconoOrdenesCompra;
        private Componentes.ClsButtonCompras _ComprasBtnIconoMetodosPago;
        private Componentes.ClsButtonCompras _ComprasBtnIconoProveedores;
        private Componentes.ClsButtonCompras _ComprasBtnAlternarNavegador;
        private Componentes.ClsButtonCompras _ComprasBtnIconoSalir;
        private Componentes.ClsButtonCompras _ComprasBtnSalir;
        private Componentes.ClsButtonCompras _ComprasBtnIconoInicio;
        private Componentes.ClsButtonCompras _ComprasBtnInicio;
        private Componentes.UsrLabelCompras ComprasUsrUsuarioTexto;
        private Componentes.UsrLabelCompras ComprasUsrRol;
        private Componentes.UsrLabelCompras ComprasUsrRolTexto;
        private Componentes.UsrLabelCompras ComprasUsrUsuario;
        private UsrDashboardCompras ComprasUsrInicio;
    }
}
