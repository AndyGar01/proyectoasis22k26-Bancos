namespace CapaVista_Compras.Componentes
{
    partial class UsrLabelCompras
    {
        private System.ComponentModel.IContainer _Componentes = null;

        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && _ComprasLblAsterisco != null && _ComprasLblAsterisco.Parent == null)
                _ComprasLblAsterisco.Dispose();
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this._ComprasTlpMain = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasLblTexto = new ClsEtiquetaCompras();
            this._ComprasLblAsterisco = new System.Windows.Forms.Label();
            this._ComprasTlpMain.SuspendLayout();
            this.SuspendLayout();
            this._ComprasTlpMain.ColumnCount = 2;
            this._ComprasTlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._ComprasTlpMain.Controls.Add(this._ComprasLblTexto, 0, 0);
            this._ComprasTlpMain.Controls.Add(this._ComprasLblAsterisco, 1, 0);
            this._ComprasTlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasTlpMain.ForeColor = ClsTemaCompras.PrincipalNavegador;
            this._ComprasTlpMain.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpMain.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpMain.Name = "ComprasTlpMain";
            this._ComprasTlpMain.RowCount = 1;
            this._ComprasTlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMain.Size = new System.Drawing.Size(208, 20);
            this._ComprasTlpMain.TabIndex = 0;
            this._ComprasLblTexto.AutoSize = true;
            this._ComprasLblTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasLblTexto.Location = new System.Drawing.Point(3, 0);
            this._ComprasLblTexto.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this._ComprasLblTexto.Name = "ComprasLblTexto";
            this._ComprasLblTexto.Size = new System.Drawing.Size(189, 20);
            this._ComprasLblTexto.TabIndex = 0;
            this._ComprasLblTexto.Text = "Label de Compras";
            this._ComprasLblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._ComprasLblAsterisco.AutoSize = true;
            this._ComprasLblAsterisco.Dock = System.Windows.Forms.DockStyle.Left;
            this._ComprasLblAsterisco.ForeColor = System.Drawing.Color.Red;
            this._ComprasLblAsterisco.Location = new System.Drawing.Point(192, 0);
            this._ComprasLblAsterisco.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasLblAsterisco.Name = "ComprasLblAsterisco";
            this._ComprasLblAsterisco.Size = new System.Drawing.Size(16, 20);
            this._ComprasLblAsterisco.TabIndex = 1;
            this._ComprasLblAsterisco.Text = "*";
            this._ComprasLblAsterisco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = ClsTemaCompras.FondoGeneral;
            this.ForeColor = ClsTemaCompras.PrincipalNavegador;
            this.Controls.Add(this._ComprasTlpMain);
            this.MaximumSize = new System.Drawing.Size(1000, 0);
            this.Name = "UsrLabelCompras";
            this.Size = new System.Drawing.Size(208, 20);
            this._ComprasTlpMain.ResumeLayout(false);
            this._ComprasTlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras _ComprasTlpMain;
        private System.Windows.Forms.Label _ComprasLblTexto;
        private System.Windows.Forms.Label _ComprasLblAsterisco;
    }
}
