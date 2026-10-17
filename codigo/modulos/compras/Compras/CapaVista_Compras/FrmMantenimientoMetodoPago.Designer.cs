namespace CapaVista_Compras
{
    partial class FrmMantenimientoMetodoPago
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;

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
            this.ComprasUsrMantenimiento = new CapaVista_Navegador.Navegador();
            this._ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this._ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            //
            // navegador1
            //
            this.ComprasUsrMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.ComprasUsrMantenimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasUsrMantenimiento.Name = "ComprasUsrMantenimiento";
            this.ComprasUsrMantenimiento.Size = new System.Drawing.Size(1150, 750);
            this.ComprasUsrMantenimiento.TabIndex = 0;
            //
            // FrmMantenimientoMetodoPago
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this._ComprasPnlContenido.Controls.Add(this.ComprasUsrMantenimiento);
            this._ComprasPnlContenido.Size = new System.Drawing.Size(1300, CapaVista_Componentes.Componentes.ClsPresentacionCompras.AlturaContenido);
            this._ComprasPnlContenido.Name = "_ComprasPnlContenido";
            this._ComprasPnlDesplazamiento.Controls.Add(this._ComprasPnlContenido);
            this._ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlDesplazamiento.Name = "_ComprasPnlDesplazamiento";
            this.Controls.Add(this._ComprasPnlDesplazamiento);
            this.ClientSize = CapaVista_Componentes.Componentes.ClsPresentacionCompras.TamanoFormulario;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "6011 – Métodos de pago";
            this.Name = "FrmMantenimientoMetodoPago";
            this.Load += new System.EventHandler(this.ComprasMetFrmMantenimientoMetodoPago_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras _ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel _ComprasPnlContenido;
        private CapaVista_Navegador.Navegador ComprasUsrMantenimiento;
    }
}
