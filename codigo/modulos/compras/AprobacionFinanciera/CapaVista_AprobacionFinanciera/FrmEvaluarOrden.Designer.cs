namespace CapaVista_AprobacionFinanciera
{
    partial class FrmEvaluarOrden
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
            this._ComprasBtnRechazar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnAprobar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasLblEvaluacion = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this.ComprasUsrDetalleOrden = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
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
            this._ComprasPnlContenido.Controls.Add(this._ComprasBtnRechazar);
            this._ComprasPnlContenido.Controls.Add(this._ComprasBtnAprobar);
            this._ComprasPnlContenido.Controls.Add(this._ComprasLblEvaluacion);
            this._ComprasPnlContenido.Controls.Add(this.ComprasUsrDetalleOrden);
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
            this._ComprasBtnRegresar.Location = new System.Drawing.Point(731, 540);
            this._ComprasBtnRegresar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnRegresar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnRegresar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnRegresar.Name = "_ComprasBtnRegresar";
            this._ComprasBtnRegresar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnRegresar.TabIndex = 9;
            this._ComprasBtnRegresar.Text = "Regresar";
            this._ComprasBtnRegresar.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnRechazar
            // 
            this._ComprasBtnRechazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnRechazar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnRechazar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnRechazar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnRechazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnRechazar.Location = new System.Drawing.Point(595, 540);
            this._ComprasBtnRechazar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnRechazar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnRechazar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnRechazar.Name = "_ComprasBtnRechazar";
            this._ComprasBtnRechazar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnRechazar.TabIndex = 8;
            this._ComprasBtnRechazar.Text = "Rechazar";
            this._ComprasBtnRechazar.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnAprobar
            // 
            this._ComprasBtnAprobar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnAprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnAprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAprobar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnAprobar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnAprobar.Location = new System.Drawing.Point(449, 540);
            this._ComprasBtnAprobar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnAprobar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnAprobar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnAprobar.Name = "_ComprasBtnAprobar";
            this._ComprasBtnAprobar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnAprobar.TabIndex = 7;
            this._ComprasBtnAprobar.Text = "Aprobar";
            this._ComprasBtnAprobar.UseVisualStyleBackColor = false;
            // 
            // _ComprasLblEvaluacion
            // 
            this._ComprasLblEvaluacion.AutoSize = true;
            this._ComprasLblEvaluacion.Font = new System.Drawing.Font("Lucida Fax", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasLblEvaluacion.Location = new System.Drawing.Point(36, 20);
            this._ComprasLblEvaluacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._ComprasLblEvaluacion.Name = "_ComprasLblEvaluacion";
            this._ComprasLblEvaluacion.Size = new System.Drawing.Size(355, 34);
            this._ComprasLblEvaluacion.TabIndex = 6;
            this._ComprasLblEvaluacion.Text = "6009 – Evaluar orden";
            // 
            // ComprasUsrDetalleOrden
            // 
            this.ComprasUsrDetalleOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrDetalleOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrDetalleOrden.Location = new System.Drawing.Point(32, 79);
            this.ComprasUsrDetalleOrden.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrDetalleOrden.Name = "ComprasUsrDetalleOrden";
            this.ComprasUsrDetalleOrden.Size = new System.Drawing.Size(1234, 413);
            this.ComprasUsrDetalleOrden.TabIndex = 5;
            // 
            // FrmEvaluarOrden
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
            this.Name = "FrmEvaluarOrden";
            this.Text = "6009 – Evaluar orden";
            this._ComprasPnlDesplazamiento.ResumeLayout(false);
            this._ComprasPnlContenido.ResumeLayout(false);
            this._ComprasPnlContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnRegresar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnRechazar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnAprobar;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras _ComprasLblEvaluacion;
        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasUsrDetalleOrden;
    }
}
