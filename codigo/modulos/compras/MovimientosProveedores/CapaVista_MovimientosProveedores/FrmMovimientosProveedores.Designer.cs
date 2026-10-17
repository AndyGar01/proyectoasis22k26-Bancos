namespace CapaVista_MovimientosProveedores
{
    partial class FrmMovimientosProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientosProveedores));
            this._ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this._ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.ComprasUsrMovimientos = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this._ComprasPnlProveedor = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this._ComprasLblCorreo = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblSeparadorCorreo = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblSeparadorTelefono = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblTelefono = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblTituloTelefono = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblNit = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblTituloNit = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblNombreProveedor = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasPnlFiltros = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this._ComprasBtnConsultar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasDtpHasta = new System.Windows.Forms.DateTimePicker();
            this._ComprasDtpDesde = new System.Windows.Forms.DateTimePicker();
            this._ComprasLblHasta = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblDesde = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasCboEstado = new CapaVista_Componentes.Componentes.ClsSelectorCompras();
            this._ComprasLblEstado = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasCboTipoMovimiento = new CapaVista_Componentes.Componentes.ClsSelectorCompras();
            this._ComprasLblTipoDeMovimiento = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasLblProveedor = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this._ComprasCboProveedores = new CapaVista_Componentes.Componentes.ClsSelectorCompras();
            this.ComprasColFecha = new System.Windows.Forms.DataGridViewColumn();
            this.ComprasColTipoMovimiento = new System.Windows.Forms.DataGridViewColumn();
            this.ComprasColDocumento = new System.Windows.Forms.DataGridViewColumn();
            this.ComprasColDescripcion = new System.Windows.Forms.DataGridViewColumn();
            this.ComprasColDebe = new System.Windows.Forms.DataGridViewColumn();
            this.ComprasColHaber = new System.Windows.Forms.DataGridViewColumn();
            this.ComprasColSaldo = new System.Windows.Forms.DataGridViewColumn();
            this.ComprasColEstado = new System.Windows.Forms.DataGridViewColumn();
            this._ComprasPnlDesplazamiento.SuspendLayout();
            this._ComprasPnlContenido.SuspendLayout();
            this._ComprasPnlProveedor.SuspendLayout();
            this._ComprasPnlFiltros.SuspendLayout();
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
            this._ComprasPnlDesplazamiento.Size = new System.Drawing.Size(1300, 700);
            this._ComprasPnlDesplazamiento.TabIndex = 0;
            // 
            // _ComprasPnlContenido
            // 
            this._ComprasPnlContenido.Controls.Add(this.ComprasUsrMovimientos);
            this._ComprasPnlContenido.Controls.Add(this._ComprasPnlProveedor);
            this._ComprasPnlContenido.Controls.Add(this._ComprasPnlFiltros);
            this._ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlContenido.Name = "_ComprasPnlContenido";
            this._ComprasPnlContenido.Size = new System.Drawing.Size(1279, 723);
            this._ComprasPnlContenido.TabIndex = 0;
            // 
            // ComprasUsrMovimientos
            // 
            this.ComprasUsrMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrMovimientos.Location = new System.Drawing.Point(28, 400);
            this.ComprasUsrMovimientos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrMovimientos.Name = "ComprasUsrMovimientos";
            this.ComprasUsrMovimientos.Size = new System.Drawing.Size(1222, 275);
            this.ComprasUsrMovimientos.TabIndex = 4;
            // 
            // _ComprasPnlProveedor
            // 
            this._ComprasPnlProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblCorreo);
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblSeparadorCorreo);
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblSeparadorTelefono);
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblTelefono);
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblTituloTelefono);
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblNit);
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblTituloNit);
            this._ComprasPnlProveedor.Controls.Add(this._ComprasLblNombreProveedor);
            this._ComprasPnlProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasPnlProveedor.Location = new System.Drawing.Point(28, 273);
            this._ComprasPnlProveedor.Name = "_ComprasPnlProveedor";
            this._ComprasPnlProveedor.Size = new System.Drawing.Size(1222, 107);
            this._ComprasPnlProveedor.TabIndex = 3;
            // 
            // _ComprasLblCorreo
            // 
            this._ComprasLblCorreo.AutoSize = true;
            this._ComprasLblCorreo.Location = new System.Drawing.Point(382, 50);
            this._ComprasLblCorreo.Name = "_ComprasLblCorreo";
            this._ComprasLblCorreo.Size = new System.Drawing.Size(227, 20);
            this._ComprasLblCorreo.TabIndex = 7;
            this._ComprasLblCorreo.Text = "toledoalimentos@dipcmi.com.gt";
            // 
            // _ComprasLblSeparadorCorreo
            // 
            this._ComprasLblSeparadorCorreo.AutoSize = true;
            this._ComprasLblSeparadorCorreo.Location = new System.Drawing.Point(363, 50);
            this._ComprasLblSeparadorCorreo.Name = "_ComprasLblSeparadorCorreo";
            this._ComprasLblSeparadorCorreo.Size = new System.Drawing.Size(13, 20);
            this._ComprasLblSeparadorCorreo.TabIndex = 6;
            this._ComprasLblSeparadorCorreo.Text = "|";
            // 
            // _ComprasLblSeparadorTelefono
            // 
            this._ComprasLblSeparadorTelefono.AutoSize = true;
            this._ComprasLblSeparadorTelefono.Location = new System.Drawing.Point(200, 50);
            this._ComprasLblSeparadorTelefono.Name = "_ComprasLblSeparadorTelefono";
            this._ComprasLblSeparadorTelefono.Size = new System.Drawing.Size(13, 20);
            this._ComprasLblSeparadorTelefono.TabIndex = 5;
            this._ComprasLblSeparadorTelefono.Text = "|";
            // 
            // _ComprasLblTelefono
            // 
            this._ComprasLblTelefono.AutoSize = true;
            this._ComprasLblTelefono.Location = new System.Drawing.Point(285, 50);
            this._ComprasLblTelefono.Name = "_ComprasLblTelefono";
            this._ComprasLblTelefono.Size = new System.Drawing.Size(79, 20);
            this._ComprasLblTelefono.TabIndex = 4;
            this._ComprasLblTelefono.Text = "2477-5580";
            // 
            // _ComprasLblTituloTelefono
            // 
            this._ComprasLblTituloTelefono.AutoSize = true;
            this._ComprasLblTituloTelefono.Location = new System.Drawing.Point(209, 50);
            this._ComprasLblTituloTelefono.Name = "_ComprasLblTituloTelefono";
            this._ComprasLblTituloTelefono.Size = new System.Drawing.Size(70, 20);
            this._ComprasLblTituloTelefono.TabIndex = 3;
            this._ComprasLblTituloTelefono.Text = "Telefono:";
            // 
            // _ComprasLblNit
            // 
            this._ComprasLblNit.AutoSize = true;
            this._ComprasLblNit.Location = new System.Drawing.Point(131, 50);
            this._ComprasLblNit.Name = "_ComprasLblNit";
            this._ComprasLblNit.Size = new System.Drawing.Size(63, 20);
            this._ComprasLblNit.TabIndex = 2;
            this._ComprasLblNit.Text = "90493-7";
            // 
            // _ComprasLblTituloNit
            // 
            this._ComprasLblTituloNit.AutoSize = true;
            this._ComprasLblTituloNit.Location = new System.Drawing.Point(96, 50);
            this._ComprasLblTituloNit.Name = "_ComprasLblTituloNit";
            this._ComprasLblTituloNit.Size = new System.Drawing.Size(32, 20);
            this._ComprasLblTituloNit.TabIndex = 1;
            this._ComprasLblTituloNit.Text = "Nit:";
            // 
            // _ComprasLblNombreProveedor
            // 
            this._ComprasLblNombreProveedor.AutoSize = true;
            this._ComprasLblNombreProveedor.Location = new System.Drawing.Point(96, 13);
            this._ComprasLblNombreProveedor.Name = "_ComprasLblNombreProveedor";
            this._ComprasLblNombreProveedor.Size = new System.Drawing.Size(197, 20);
            this._ComprasLblNombreProveedor.TabIndex = 0;
            this._ComprasLblNombreProveedor.Text = "Empaquetadora Toledo, S.A.";
            // 
            // _ComprasPnlFiltros
            // 
            this._ComprasPnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasPnlFiltros.Controls.Add(this._ComprasBtnConsultar);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasDtpHasta);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasDtpDesde);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasLblHasta);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasLblDesde);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasCboEstado);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasLblEstado);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasCboTipoMovimiento);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasLblTipoDeMovimiento);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasLblProveedor);
            this._ComprasPnlFiltros.Controls.Add(this._ComprasCboProveedores);
            this._ComprasPnlFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasPnlFiltros.Location = new System.Drawing.Point(28, 45);
            this._ComprasPnlFiltros.Name = "_ComprasPnlFiltros";
            this._ComprasPnlFiltros.Size = new System.Drawing.Size(1222, 191);
            this._ComprasPnlFiltros.TabIndex = 2;
            // 
            // _ComprasBtnConsultar
            // 
            this._ComprasBtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnConsultar.BackgroundImage")));
            this._ComprasBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnConsultar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnConsultar.Location = new System.Drawing.Point(1025, 61);
            this._ComprasBtnConsultar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnConsultar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnConsultar.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnConsultar.Name = "_ComprasBtnConsultar";
            this._ComprasBtnConsultar.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnConsultar.TabIndex = 10;
            this._ComprasBtnConsultar.UseVisualStyleBackColor = false;
            // 
            // _ComprasDtpHasta
            // 
            this._ComprasDtpHasta.Location = new System.Drawing.Point(19, 144);
            this._ComprasDtpHasta.Name = "_ComprasDtpHasta";
            this._ComprasDtpHasta.Size = new System.Drawing.Size(200, 27);
            this._ComprasDtpHasta.TabIndex = 9;
            // 
            // _ComprasDtpDesde
            // 
            this._ComprasDtpDesde.Location = new System.Drawing.Point(314, 144);
            this._ComprasDtpDesde.Name = "_ComprasDtpDesde";
            this._ComprasDtpDesde.Size = new System.Drawing.Size(200, 27);
            this._ComprasDtpDesde.TabIndex = 8;
            // 
            // _ComprasLblHasta
            // 
            this._ComprasLblHasta.AutoSize = true;
            this._ComprasLblHasta.Location = new System.Drawing.Point(310, 121);
            this._ComprasLblHasta.Name = "_ComprasLblHasta";
            this._ComprasLblHasta.Size = new System.Drawing.Size(47, 20);
            this._ComprasLblHasta.TabIndex = 7;
            this._ComprasLblHasta.Text = "Hasta";
            // 
            // _ComprasLblDesde
            // 
            this._ComprasLblDesde.AutoSize = true;
            this._ComprasLblDesde.Location = new System.Drawing.Point(15, 121);
            this._ComprasLblDesde.Name = "_ComprasLblDesde";
            this._ComprasLblDesde.Size = new System.Drawing.Size(51, 20);
            this._ComprasLblDesde.TabIndex = 6;
            this._ComprasLblDesde.Text = "Desde";
            // 
            // _ComprasCboEstado
            // 
            this._ComprasCboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasCboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComprasCboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasCboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._ComprasCboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasCboEstado.FormattingEnabled = true;
            this._ComprasCboEstado.Location = new System.Drawing.Point(565, 61);
            this._ComprasCboEstado.Name = "_ComprasCboEstado";
            this._ComprasCboEstado.Size = new System.Drawing.Size(200, 31);
            this._ComprasCboEstado.TabIndex = 5;
            // 
            // _ComprasLblEstado
            // 
            this._ComprasLblEstado.AutoSize = true;
            this._ComprasLblEstado.Location = new System.Drawing.Point(561, 22);
            this._ComprasLblEstado.Name = "_ComprasLblEstado";
            this._ComprasLblEstado.Size = new System.Drawing.Size(135, 20);
            this._ComprasLblEstado.TabIndex = 4;
            this._ComprasLblEstado.Text = "ComprasColEstado";
            // 
            // _ComprasCboTipoMovimiento
            // 
            this._ComprasCboTipoMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasCboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComprasCboTipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasCboTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._ComprasCboTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasCboTipoMovimiento.FormattingEnabled = true;
            this._ComprasCboTipoMovimiento.Location = new System.Drawing.Point(314, 61);
            this._ComprasCboTipoMovimiento.Name = "_ComprasCboTipoMovimiento";
            this._ComprasCboTipoMovimiento.Size = new System.Drawing.Size(200, 31);
            this._ComprasCboTipoMovimiento.TabIndex = 3;
            // 
            // _ComprasLblTipoDeMovimiento
            // 
            this._ComprasLblTipoDeMovimiento.AutoSize = true;
            this._ComprasLblTipoDeMovimiento.Location = new System.Drawing.Point(310, 22);
            this._ComprasLblTipoDeMovimiento.Name = "_ComprasLblTipoDeMovimiento";
            this._ComprasLblTipoDeMovimiento.Size = new System.Drawing.Size(144, 20);
            this._ComprasLblTipoDeMovimiento.TabIndex = 2;
            this._ComprasLblTipoDeMovimiento.Text = "Tipo de movimiento";
            // 
            // _ComprasLblProveedor
            // 
            this._ComprasLblProveedor.AutoSize = true;
            this._ComprasLblProveedor.Location = new System.Drawing.Point(15, 22);
            this._ComprasLblProveedor.Name = "_ComprasLblProveedor";
            this._ComprasLblProveedor.Size = new System.Drawing.Size(77, 20);
            this._ComprasLblProveedor.TabIndex = 1;
            this._ComprasLblProveedor.Text = "Proveedor";
            // 
            // _ComprasCboProveedores
            // 
            this._ComprasCboProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasCboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComprasCboProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasCboProveedores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._ComprasCboProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasCboProveedores.FormattingEnabled = true;
            this._ComprasCboProveedores.Location = new System.Drawing.Point(19, 61);
            this._ComprasCboProveedores.Name = "_ComprasCboProveedores";
            this._ComprasCboProveedores.Size = new System.Drawing.Size(274, 31);
            this._ComprasCboProveedores.TabIndex = 0;
            // 
            // ComprasColFecha
            // 
            this.ComprasColFecha.MinimumWidth = 6;
            this.ComprasColFecha.Name = "ComprasColFecha";
            this.ComprasColFecha.ReadOnly = true;
            this.ComprasColFecha.Width = 125;
            // 
            // ComprasColTipoMovimiento
            // 
            this.ComprasColTipoMovimiento.MinimumWidth = 6;
            this.ComprasColTipoMovimiento.Name = "ComprasColTipoMovimiento";
            this.ComprasColTipoMovimiento.ReadOnly = true;
            this.ComprasColTipoMovimiento.Width = 125;
            // 
            // ComprasColDocumento
            // 
            this.ComprasColDocumento.MinimumWidth = 6;
            this.ComprasColDocumento.Name = "ComprasColDocumento";
            this.ComprasColDocumento.ReadOnly = true;
            this.ComprasColDocumento.Width = 125;
            // 
            // ComprasColDescripcion
            // 
            this.ComprasColDescripcion.MinimumWidth = 6;
            this.ComprasColDescripcion.Name = "ComprasColDescripcion";
            this.ComprasColDescripcion.ReadOnly = true;
            this.ComprasColDescripcion.Width = 125;
            // 
            // ComprasColDebe
            // 
            this.ComprasColDebe.MinimumWidth = 6;
            this.ComprasColDebe.Name = "ComprasColDebe";
            this.ComprasColDebe.ReadOnly = true;
            this.ComprasColDebe.Width = 125;
            // 
            // ComprasColHaber
            // 
            this.ComprasColHaber.MinimumWidth = 6;
            this.ComprasColHaber.Name = "ComprasColHaber";
            this.ComprasColHaber.ReadOnly = true;
            this.ComprasColHaber.Width = 125;
            // 
            // ComprasColSaldo
            // 
            this.ComprasColSaldo.MinimumWidth = 6;
            this.ComprasColSaldo.Name = "ComprasColSaldo";
            this.ComprasColSaldo.ReadOnly = true;
            this.ComprasColSaldo.Width = 125;
            // 
            // ComprasColEstado
            // 
            this.ComprasColEstado.MinimumWidth = 6;
            this.ComprasColEstado.Name = "ComprasColEstado";
            this.ComprasColEstado.ReadOnly = true;
            this.ComprasColEstado.Width = 125;
            // 
            // FrmMovimientosProveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this._ComprasPnlDesplazamiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "FrmMovimientosProveedores";
            this.Text = "6001 – MovimientosProveedores";
            this._ComprasPnlDesplazamiento.ResumeLayout(false);
            this._ComprasPnlContenido.ResumeLayout(false);
            this._ComprasPnlProveedor.ResumeLayout(false);
            this._ComprasPnlProveedor.PerformLayout();
            this._ComprasPnlFiltros.ResumeLayout(false);
            this._ComprasPnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.ClsSelectorCompras _ComprasCboProveedores;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblProveedor;
        private CapaVista_Componentes.Componentes.ClsPanelCompras _ComprasPnlFiltros;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnConsultar;
        private System.Windows.Forms.DateTimePicker _ComprasDtpHasta;
        private System.Windows.Forms.DateTimePicker _ComprasDtpDesde;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblHasta;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblDesde;
        private CapaVista_Componentes.Componentes.ClsSelectorCompras _ComprasCboEstado;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblEstado;
        private CapaVista_Componentes.Componentes.ClsSelectorCompras _ComprasCboTipoMovimiento;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblTipoDeMovimiento;
        private CapaVista_Componentes.Componentes.ClsPanelCompras _ComprasPnlProveedor;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblCorreo;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblSeparadorCorreo;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblSeparadorTelefono;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblTelefono;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblTituloTelefono;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblNit;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblTituloNit;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblNombreProveedor;
        private System.Windows.Forms.DataGridViewColumn _ComprasColFecha;
        private System.Windows.Forms.DataGridViewColumn _ComprasColTipoMovimiento;
        private System.Windows.Forms.DataGridViewColumn _ComprasColDocumento;
        private System.Windows.Forms.DataGridViewColumn _ComprasColDescripcion;
        private System.Windows.Forms.DataGridViewColumn _ComprasColDebe;
        private System.Windows.Forms.DataGridViewColumn _ComprasColHaber;
        private System.Windows.Forms.DataGridViewColumn _ComprasColSaldo;
        private System.Windows.Forms.DataGridViewColumn _ComprasColEstado;
        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasUsrMovimientos;
        private System.Windows.Forms.DataGridViewColumn ComprasColFecha;
        private System.Windows.Forms.DataGridViewColumn ComprasColTipoMovimiento;
        private System.Windows.Forms.DataGridViewColumn ComprasColDocumento;
        private System.Windows.Forms.DataGridViewColumn ComprasColDescripcion;
        private System.Windows.Forms.DataGridViewColumn ComprasColDebe;
        private System.Windows.Forms.DataGridViewColumn ComprasColHaber;
        private System.Windows.Forms.DataGridViewColumn ComprasColSaldo;
        private System.Windows.Forms.DataGridViewColumn ComprasColEstado;
    }
}
