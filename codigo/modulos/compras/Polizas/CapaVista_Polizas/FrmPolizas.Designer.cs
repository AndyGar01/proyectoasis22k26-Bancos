namespace CapaVista_Polizas
{
    partial class FrmPolizas
    {
        private System.ComponentModel.IContainer _Componentes = null;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras _ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel _ComprasPnlContenido;

        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && _Componentes != null) _Componentes.Dispose();
            base.Dispose(LiberarRecursos);
        }

        private void InitializeComponent()
        {
            this._ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this._ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.usrLabelCompras1 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.clsGroupBoxCompras1 = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.usrComboBoxCompras1 = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.usrComboBoxCompras2 = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.usrLabelCompras2 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.usrLabelCompras3 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.usrTextBoxCompras1 = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.usrLabelCompras4 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.usrComboBoxCompras3 = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.usrLabelCompras5 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.usrLabelCompras6 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.usrTextBoxCompras2 = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.clsGroupBoxCompras2 = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.usrLabelCompras9 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.usrComboBoxCompras4 = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.clsButtonCompras1 = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.clsButtonCompras2 = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.clsButtonCompras3 = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.clsButtonCompras4 = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.usrLabelCompras7 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasPnlDesplazamiento.SuspendLayout();
            this._ComprasPnlContenido.SuspendLayout();
            this.clsGroupBoxCompras1.SuspendLayout();
            this.clsGroupBoxCompras2.SuspendLayout();
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
            this._ComprasPnlContenido.Controls.Add(this.clsGroupBoxCompras2);
            this._ComprasPnlContenido.Controls.Add(this.clsGroupBoxCompras1);
            this._ComprasPnlContenido.Controls.Add(this.usrLabelCompras1);
            this._ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlContenido.Name = "_ComprasPnlContenido";
            this._ComprasPnlContenido.Size = new System.Drawing.Size(1279, 723);
            this._ComprasPnlContenido.TabIndex = 0;
            // 
            // usrLabelCompras1
            // 
            this.usrLabelCompras1.AlineacionTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrLabelCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras1.Font = new System.Drawing.Font("Lucida Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.usrLabelCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras1.Location = new System.Drawing.Point(346, 33);
            this.usrLabelCompras1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usrLabelCompras1.MaximumSize = new System.Drawing.Size(2375, 0);
            this.usrLabelCompras1.MostrarAsterisco = false;
            this.usrLabelCompras1.Name = "usrLabelCompras1";
            this.usrLabelCompras1.Size = new System.Drawing.Size(494, 36);
            this.usrLabelCompras1.TabIndex = 0;
            this.usrLabelCompras1.TabStop = false;
            this.usrLabelCompras1.Text = "Póliza de compras";
            this.usrLabelCompras1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrLabelCompras1.Texto = "Póliza de compras";
            this.usrLabelCompras1.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.TituloFormulario;
            // 
            // clsGroupBoxCompras1
            // 
            this.clsGroupBoxCompras1.BackColor = System.Drawing.Color.Transparent;
            this.clsGroupBoxCompras1.Controls.Add(this.usrLabelCompras6);
            this.clsGroupBoxCompras1.Controls.Add(this.usrTextBoxCompras2);
            this.clsGroupBoxCompras1.Controls.Add(this.usrLabelCompras5);
            this.clsGroupBoxCompras1.Controls.Add(this.usrComboBoxCompras3);
            this.clsGroupBoxCompras1.Controls.Add(this.usrLabelCompras4);
            this.clsGroupBoxCompras1.Controls.Add(this.usrTextBoxCompras1);
            this.clsGroupBoxCompras1.Controls.Add(this.usrLabelCompras3);
            this.clsGroupBoxCompras1.Controls.Add(this.usrLabelCompras2);
            this.clsGroupBoxCompras1.Controls.Add(this.usrComboBoxCompras2);
            this.clsGroupBoxCompras1.Controls.Add(this.usrComboBoxCompras1);
            this.clsGroupBoxCompras1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsGroupBoxCompras1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.clsGroupBoxCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsGroupBoxCompras1.Location = new System.Drawing.Point(21, 92);
            this.clsGroupBoxCompras1.Name = "clsGroupBoxCompras1";
            this.clsGroupBoxCompras1.Size = new System.Drawing.Size(1255, 296);
            this.clsGroupBoxCompras1.TabIndex = 1;
            this.clsGroupBoxCompras1.TabStop = false;
            // 
            // usrComboBoxCompras1
            // 
            this.usrComboBoxCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrComboBoxCompras1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usrComboBoxCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrComboBoxCompras1.Location = new System.Drawing.Point(541, 73);
            this.usrComboBoxCompras1.Margin = new System.Windows.Forms.Padding(0);
            this.usrComboBoxCompras1.MaxLength = 0;
            this.usrComboBoxCompras1.MostrarEtiquetaError = false;
            this.usrComboBoxCompras1.Name = "usrComboBoxCompras1";
            this.usrComboBoxCompras1.Size = new System.Drawing.Size(289, 45);
            this.usrComboBoxCompras1.TabIndex = 2;
            // 
            // usrComboBoxCompras2
            // 
            this.usrComboBoxCompras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrComboBoxCompras2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usrComboBoxCompras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrComboBoxCompras2.Location = new System.Drawing.Point(876, 74);
            this.usrComboBoxCompras2.Margin = new System.Windows.Forms.Padding(0);
            this.usrComboBoxCompras2.MaxLength = 0;
            this.usrComboBoxCompras2.MostrarEtiquetaError = false;
            this.usrComboBoxCompras2.Name = "usrComboBoxCompras2";
            this.usrComboBoxCompras2.Size = new System.Drawing.Size(289, 44);
            this.usrComboBoxCompras2.TabIndex = 3;
            // 
            // usrLabelCompras2
            // 
            this.usrLabelCompras2.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usrLabelCompras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras2.Location = new System.Drawing.Point(541, 30);
            this.usrLabelCompras2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usrLabelCompras2.MaximumSize = new System.Drawing.Size(1625, 0);
            this.usrLabelCompras2.MostrarAsterisco = false;
            this.usrLabelCompras2.Name = "usrLabelCompras2";
            this.usrLabelCompras2.Size = new System.Drawing.Size(278, 32);
            this.usrLabelCompras2.TabIndex = 4;
            this.usrLabelCompras2.TabStop = false;
            this.usrLabelCompras2.Text = "Estado";
            this.usrLabelCompras2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras2.Texto = "Estado";
            this.usrLabelCompras2.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.Campo;
            // 
            // usrLabelCompras3
            // 
            this.usrLabelCompras3.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usrLabelCompras3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras3.Location = new System.Drawing.Point(850, 30);
            this.usrLabelCompras3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usrLabelCompras3.MaximumSize = new System.Drawing.Size(1625, 0);
            this.usrLabelCompras3.MostrarAsterisco = false;
            this.usrLabelCompras3.Name = "usrLabelCompras3";
            this.usrLabelCompras3.Size = new System.Drawing.Size(338, 32);
            this.usrLabelCompras3.TabIndex = 5;
            this.usrLabelCompras3.TabStop = false;
            this.usrLabelCompras3.Text = "Origen";
            this.usrLabelCompras3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras3.Texto = "Origen";
            this.usrLabelCompras3.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.Campo;
            // 
            // usrTextBoxCompras1
            // 
            this.usrTextBoxCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrTextBoxCompras1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usrTextBoxCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrTextBoxCompras1.Location = new System.Drawing.Point(275, 73);
            this.usrTextBoxCompras1.Margin = new System.Windows.Forms.Padding(0);
            this.usrTextBoxCompras1.MaxLength = 2147483647;
            this.usrTextBoxCompras1.MostrarEtiquetaError = false;
            this.usrTextBoxCompras1.Multiline = true;
            this.usrTextBoxCompras1.Name = "usrTextBoxCompras1";
            this.usrTextBoxCompras1.SelectedText = "";
            this.usrTextBoxCompras1.SelectionLength = 0;
            this.usrTextBoxCompras1.SelectionStart = 0;
            this.usrTextBoxCompras1.Size = new System.Drawing.Size(236, 36);
            this.usrTextBoxCompras1.TabIndex = 6;
            // 
            // usrLabelCompras4
            // 
            this.usrLabelCompras4.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usrLabelCompras4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras4.Location = new System.Drawing.Point(260, 36);
            this.usrLabelCompras4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usrLabelCompras4.MaximumSize = new System.Drawing.Size(1625, 0);
            this.usrLabelCompras4.MostrarAsterisco = false;
            this.usrLabelCompras4.Name = "usrLabelCompras4";
            this.usrLabelCompras4.Size = new System.Drawing.Size(236, 32);
            this.usrLabelCompras4.TabIndex = 5;
            this.usrLabelCompras4.TabStop = false;
            this.usrLabelCompras4.Text = "Periodo";
            this.usrLabelCompras4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras4.Texto = "Periodo";
            this.usrLabelCompras4.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.Campo;
            // 
            // usrComboBoxCompras3
            // 
            this.usrComboBoxCompras3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrComboBoxCompras3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usrComboBoxCompras3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrComboBoxCompras3.Location = new System.Drawing.Point(22, 73);
            this.usrComboBoxCompras3.Margin = new System.Windows.Forms.Padding(0);
            this.usrComboBoxCompras3.MaxLength = 0;
            this.usrComboBoxCompras3.MostrarEtiquetaError = false;
            this.usrComboBoxCompras3.Name = "usrComboBoxCompras3";
            this.usrComboBoxCompras3.Size = new System.Drawing.Size(224, 45);
            this.usrComboBoxCompras3.TabIndex = 3;
            // 
            // usrLabelCompras5
            // 
            this.usrLabelCompras5.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usrLabelCompras5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras5.Location = new System.Drawing.Point(22, 36);
            this.usrLabelCompras5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usrLabelCompras5.MaximumSize = new System.Drawing.Size(1625, 0);
            this.usrLabelCompras5.MostrarAsterisco = false;
            this.usrLabelCompras5.Name = "usrLabelCompras5";
            this.usrLabelCompras5.Size = new System.Drawing.Size(224, 32);
            this.usrLabelCompras5.TabIndex = 5;
            this.usrLabelCompras5.TabStop = false;
            this.usrLabelCompras5.Text = "Fecha";
            this.usrLabelCompras5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras5.Texto = "Fecha";
            this.usrLabelCompras5.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.Campo;
            // 
            // usrLabelCompras6
            // 
            this.usrLabelCompras6.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usrLabelCompras6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras6.Location = new System.Drawing.Point(7, 136);
            this.usrLabelCompras6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usrLabelCompras6.MaximumSize = new System.Drawing.Size(1625, 0);
            this.usrLabelCompras6.MostrarAsterisco = false;
            this.usrLabelCompras6.Name = "usrLabelCompras6";
            this.usrLabelCompras6.Size = new System.Drawing.Size(236, 32);
            this.usrLabelCompras6.TabIndex = 7;
            this.usrLabelCompras6.TabStop = false;
            this.usrLabelCompras6.Text = "Descripcion";
            this.usrLabelCompras6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras6.Texto = "Descripcion";
            this.usrLabelCompras6.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.Campo;
            // 
            // usrTextBoxCompras2
            // 
            this.usrTextBoxCompras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrTextBoxCompras2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usrTextBoxCompras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrTextBoxCompras2.Location = new System.Drawing.Point(10, 174);
            this.usrTextBoxCompras2.Margin = new System.Windows.Forms.Padding(0);
            this.usrTextBoxCompras2.MaxLength = 2147483647;
            this.usrTextBoxCompras2.MostrarEtiquetaError = false;
            this.usrTextBoxCompras2.Multiline = true;
            this.usrTextBoxCompras2.Name = "usrTextBoxCompras2";
            this.usrTextBoxCompras2.SelectedText = "";
            this.usrTextBoxCompras2.SelectionLength = 0;
            this.usrTextBoxCompras2.SelectionStart = 0;
            this.usrTextBoxCompras2.Size = new System.Drawing.Size(1216, 85);
            this.usrTextBoxCompras2.TabIndex = 8;
            // 
            // clsGroupBoxCompras2
            // 
            this.clsGroupBoxCompras2.BackColor = System.Drawing.Color.Transparent;
            this.clsGroupBoxCompras2.Controls.Add(this.usrLabelCompras7);
            this.clsGroupBoxCompras2.Controls.Add(this.clsButtonCompras4);
            this.clsGroupBoxCompras2.Controls.Add(this.clsButtonCompras3);
            this.clsGroupBoxCompras2.Controls.Add(this.clsButtonCompras2);
            this.clsGroupBoxCompras2.Controls.Add(this.clsButtonCompras1);
            this.clsGroupBoxCompras2.Controls.Add(this.usrComboBoxCompras4);
            this.clsGroupBoxCompras2.Controls.Add(this.usrLabelCompras9);
            this.clsGroupBoxCompras2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsGroupBoxCompras2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.clsGroupBoxCompras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsGroupBoxCompras2.Location = new System.Drawing.Point(21, 392);
            this.clsGroupBoxCompras2.Name = "clsGroupBoxCompras2";
            this.clsGroupBoxCompras2.Size = new System.Drawing.Size(1255, 296);
            this.clsGroupBoxCompras2.TabIndex = 9;
            this.clsGroupBoxCompras2.TabStop = false;
            // 
            // usrLabelCompras9
            // 
            this.usrLabelCompras9.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usrLabelCompras9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras9.Location = new System.Drawing.Point(7, 30);
            this.usrLabelCompras9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usrLabelCompras9.MaximumSize = new System.Drawing.Size(1625, 0);
            this.usrLabelCompras9.MostrarAsterisco = false;
            this.usrLabelCompras9.Name = "usrLabelCompras9";
            this.usrLabelCompras9.Size = new System.Drawing.Size(236, 32);
            this.usrLabelCompras9.TabIndex = 5;
            this.usrLabelCompras9.TabStop = false;
            this.usrLabelCompras9.Text = "Agregar Cuenta";
            this.usrLabelCompras9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras9.Texto = "Agregar Cuenta";
            this.usrLabelCompras9.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.Campo;
            // 
            // usrComboBoxCompras4
            // 
            this.usrComboBoxCompras4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrComboBoxCompras4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usrComboBoxCompras4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrComboBoxCompras4.Location = new System.Drawing.Point(10, 68);
            this.usrComboBoxCompras4.Margin = new System.Windows.Forms.Padding(0);
            this.usrComboBoxCompras4.MaxLength = 0;
            this.usrComboBoxCompras4.MostrarEtiquetaError = false;
            this.usrComboBoxCompras4.Name = "usrComboBoxCompras4";
            this.usrComboBoxCompras4.Size = new System.Drawing.Size(289, 45);
            this.usrComboBoxCompras4.TabIndex = 9;
            // 
            // clsButtonCompras1
            // 
            this.clsButtonCompras1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clsButtonCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.clsButtonCompras1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clsButtonCompras1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clsButtonCompras1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras1.FlatAppearance.BorderSize = 0;
            this.clsButtonCompras1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.clsButtonCompras1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.clsButtonCompras1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsButtonCompras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsButtonCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras1.Location = new System.Drawing.Point(338, 45);
            this.clsButtonCompras1.Margin = new System.Windows.Forms.Padding(0);
            this.clsButtonCompras1.MaximumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras1.MinimumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras1.Name = "clsButtonCompras1";
            this.clsButtonCompras1.Size = new System.Drawing.Size(80, 80);
            this.clsButtonCompras1.TabIndex = 10;
            this.clsButtonCompras1.Text = "Agregar";
            this.clsButtonCompras1.UseVisualStyleBackColor = false;
            // 
            // clsButtonCompras2
            // 
            this.clsButtonCompras2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clsButtonCompras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.clsButtonCompras2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clsButtonCompras2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clsButtonCompras2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras2.FlatAppearance.BorderSize = 0;
            this.clsButtonCompras2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.clsButtonCompras2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.clsButtonCompras2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsButtonCompras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsButtonCompras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras2.Location = new System.Drawing.Point(942, 213);
            this.clsButtonCompras2.Margin = new System.Windows.Forms.Padding(0);
            this.clsButtonCompras2.MaximumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras2.MinimumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras2.Name = "clsButtonCompras2";
            this.clsButtonCompras2.Size = new System.Drawing.Size(80, 80);
            this.clsButtonCompras2.TabIndex = 11;
            this.clsButtonCompras2.Text = "Nuevo";
            this.clsButtonCompras2.UseVisualStyleBackColor = false;
            // 
            // clsButtonCompras3
            // 
            this.clsButtonCompras3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clsButtonCompras3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.clsButtonCompras3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clsButtonCompras3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clsButtonCompras3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras3.FlatAppearance.BorderSize = 0;
            this.clsButtonCompras3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.clsButtonCompras3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.clsButtonCompras3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsButtonCompras3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsButtonCompras3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras3.Location = new System.Drawing.Point(1045, 213);
            this.clsButtonCompras3.Margin = new System.Windows.Forms.Padding(0);
            this.clsButtonCompras3.MaximumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras3.MinimumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras3.Name = "clsButtonCompras3";
            this.clsButtonCompras3.Size = new System.Drawing.Size(80, 80);
            this.clsButtonCompras3.TabIndex = 12;
            this.clsButtonCompras3.Text = "Guardar";
            this.clsButtonCompras3.UseVisualStyleBackColor = false;
            // 
            // clsButtonCompras4
            // 
            this.clsButtonCompras4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clsButtonCompras4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.clsButtonCompras4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clsButtonCompras4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clsButtonCompras4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras4.FlatAppearance.BorderSize = 0;
            this.clsButtonCompras4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.clsButtonCompras4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.clsButtonCompras4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsButtonCompras4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsButtonCompras4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras4.Location = new System.Drawing.Point(1146, 213);
            this.clsButtonCompras4.Margin = new System.Windows.Forms.Padding(0);
            this.clsButtonCompras4.MaximumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras4.MinimumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras4.Name = "clsButtonCompras4";
            this.clsButtonCompras4.Size = new System.Drawing.Size(80, 80);
            this.clsButtonCompras4.TabIndex = 13;
            this.clsButtonCompras4.Text = "Enviar";
            this.clsButtonCompras4.UseVisualStyleBackColor = false;
            // 
            // usrLabelCompras7
            // 
            this.usrLabelCompras7.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usrLabelCompras7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras7.Location = new System.Drawing.Point(10, 245);
            this.usrLabelCompras7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usrLabelCompras7.MaximumSize = new System.Drawing.Size(1625, 0);
            this.usrLabelCompras7.MostrarAsterisco = false;
            this.usrLabelCompras7.Name = "usrLabelCompras7";
            this.usrLabelCompras7.Size = new System.Drawing.Size(368, 32);
            this.usrLabelCompras7.TabIndex = 14;
            this.usrLabelCompras7.TabStop = false;
            this.usrLabelCompras7.Text = "Descuadra- Diferencia Q 00.00";
            this.usrLabelCompras7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrLabelCompras7.Texto = "Descuadra- Diferencia Q 00.00";
            this.usrLabelCompras7.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.Campo;
            // 
            // FrmPolizas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this._ComprasPnlDesplazamiento);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPolizas";
            this.Text = "6002 – Polizas";
            this._ComprasPnlDesplazamiento.ResumeLayout(false);
            this._ComprasPnlContenido.ResumeLayout(false);
            this.clsGroupBoxCompras1.ResumeLayout(false);
            this.clsGroupBoxCompras2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras clsGroupBoxCompras1;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras1;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras usrTextBoxCompras1;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras3;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras2;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras usrComboBoxCompras2;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras usrComboBoxCompras1;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras6;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras usrTextBoxCompras2;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras5;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras usrComboBoxCompras3;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras4;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras clsGroupBoxCompras2;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras7;
        private CapaVista_Componentes.Componentes.ClsButtonCompras clsButtonCompras4;
        private CapaVista_Componentes.Componentes.ClsButtonCompras clsButtonCompras3;
        private CapaVista_Componentes.Componentes.ClsButtonCompras clsButtonCompras2;
        private CapaVista_Componentes.Componentes.ClsButtonCompras clsButtonCompras1;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras usrComboBoxCompras4;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras9;
    }
}
