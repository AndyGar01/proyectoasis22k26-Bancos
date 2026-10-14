namespace CapaVista_Compras
{
    partial class UsrMantenimientoProveedor
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
            // UsrMantenimientoProveedor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComprasUsrMantenimiento);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.Name = "UsrMantenimientoProveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador ComprasUsrMantenimiento;
    }
}
