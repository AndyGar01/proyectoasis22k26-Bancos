namespace CapaVista_AprobacionFinanciera
{
    partial class FrmAprobacionFinanciera
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
            this._ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this._ComprasPnlContenido = new System.Windows.Forms.Panel();
            this._ComprasBtnRegresar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnEvaluar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnVer = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblTitulo = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this.ComprasUsrOrdenesDisponibles = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this._ComprasPnlDesplazamiento.SuspendLayout();
            this._ComprasPnlContenido.SuspendLayout();
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
            this._ComprasPnlContenido.Controls.Add(this._ComprasBtnRegresar);
            this._ComprasPnlContenido.Controls.Add(this._ComprasBtnEvaluar);
            this._ComprasPnlContenido.Controls.Add(this._ComprasBtnVer);
            this._ComprasPnlContenido.Controls.Add(this._ComprasLblTitulo);
            this._ComprasPnlContenido.Controls.Add(this.ComprasUsrOrdenesDisponibles);
            this._ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlContenido.Name = "_ComprasPnlContenido";
            this._ComprasPnlContenido.Size = new System.Drawing.Size(1279, 723);
            this._ComprasPnlContenido.TabIndex = 0;
            // 
            // _ComprasBtnRegresar
            // 
            this._ComprasBtnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnRegresar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnRegresar.Location = new System.Drawing.Point(1136, 542);
            this._ComprasBtnRegresar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnRegresar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnRegresar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnRegresar.Name = "_ComprasBtnRegresar";
            this._ComprasBtnRegresar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnRegresar.TabIndex = 4;
            this._ComprasBtnRegresar.Text = "Regresar";
            this._ComprasBtnRegresar.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnEvaluar
            // 
            this._ComprasBtnEvaluar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnEvaluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnEvaluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnEvaluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnEvaluar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnEvaluar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnEvaluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnEvaluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnEvaluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnEvaluar.Location = new System.Drawing.Point(935, 542);
            this._ComprasBtnEvaluar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnEvaluar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnEvaluar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnEvaluar.Name = "_ComprasBtnEvaluar";
            this._ComprasBtnEvaluar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnEvaluar.TabIndex = 3;
            this._ComprasBtnEvaluar.Text = "Evaluar";
            this._ComprasBtnEvaluar.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnVer
            // 
            this._ComprasBtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnVer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnVer.FlatAppearance.BorderSize = 0;
            this._ComprasBtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnVer.Location = new System.Drawing.Point(736, 542);
            this._ComprasBtnVer.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnVer.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnVer.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnVer.Name = "_ComprasBtnVer";
            this._ComprasBtnVer.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnVer.TabIndex = 2;
            this._ComprasBtnVer.Text = "Ver";
            this._ComprasBtnVer.UseVisualStyleBackColor = false;
            // 
            // _ComprasLblTitulo
            // 
            this._ComprasLblTitulo.AutoSize = true;
            this._ComprasLblTitulo.Font = new System.Drawing.Font("Lucida Fax", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasLblTitulo.Location = new System.Drawing.Point(35, 26);
            this._ComprasLblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._ComprasLblTitulo.Name = "_ComprasLblTitulo";
            this._ComprasLblTitulo.Size = new System.Drawing.Size(479, 34);
            this._ComprasLblTitulo.TabIndex = 1;
            this._ComprasLblTitulo.Text = "6005 – AprobacionFinanciera";
            // 
            // ComprasUsrOrdenesDisponibles
            // 
            this.ComprasUsrOrdenesDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrOrdenesDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrOrdenesDisponibles.Location = new System.Drawing.Point(21, 73);
            this.ComprasUsrOrdenesDisponibles.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrOrdenesDisponibles.Name = "ComprasUsrOrdenesDisponibles";
            this.ComprasUsrOrdenesDisponibles.Size = new System.Drawing.Size(1223, 428);
            this.ComprasUsrOrdenesDisponibles.TabIndex = 0;
            // 
            // FrmAprobacionFinanciera
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this._ComprasPnlDesplazamiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAprobacionFinanciera";
            this.Text = "6005 – AprobacionFinanciera";
            this._ComprasPnlDesplazamiento.ResumeLayout(false);
            this._ComprasPnlContenido.ResumeLayout(false);
            this._ComprasPnlContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasUsrOrdenesDisponibles;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblTitulo;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnVer;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnEvaluar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnRegresar;
    }
}
