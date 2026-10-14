namespace CapaVista_Compras.Componentes
{
    partial class UsrDataGridViewCompras
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

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle EstiloFilasAlternas = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle EstiloEncabezados = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle EstiloCeldas = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle EstiloFilas = new System.Windows.Forms.DataGridViewCellStyle();
            this._ComprasPnlBorde = new System.Windows.Forms.Panel();
            this._ComprasDgvMain = new System.Windows.Forms.DataGridView();
            this._ComprasPnlBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ComprasDgvMain)).BeginInit();
            this.SuspendLayout();
            this._ComprasPnlBorde.BackColor = ClsTemaCompras.PrincipalNavegador;
            this._ComprasPnlBorde.Controls.Add(this._ComprasDgvMain);
            this._ComprasPnlBorde.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlBorde.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlBorde.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlBorde.Name = "ComprasPnlBorde";
            this._ComprasPnlBorde.Padding = new System.Windows.Forms.Padding(1);
            this._ComprasPnlBorde.Size = new System.Drawing.Size(150, 150);
            this._ComprasPnlBorde.TabIndex = 0;
            this._ComprasDgvMain.AllowUserToAddRows = false;
            this._ComprasDgvMain.AllowUserToDeleteRows = false;
            this._ComprasDgvMain.AllowUserToResizeRows = false;
            EstiloFilasAlternas.BackColor = ClsTemaCompras.FondoGeneral;
            EstiloFilasAlternas.ForeColor = ClsTemaCompras.PrincipalNavegador;
            EstiloFilasAlternas.SelectionBackColor = ClsTemaCompras.AcentoNavegador;
            EstiloFilasAlternas.SelectionForeColor = System.Drawing.Color.White;
            this._ComprasDgvMain.AlternatingRowsDefaultCellStyle = EstiloFilasAlternas;
            this._ComprasDgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._ComprasDgvMain.BackgroundColor = ClsTemaCompras.FondoGeneral;
            this._ComprasDgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._ComprasDgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._ComprasDgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            EstiloEncabezados.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            EstiloEncabezados.BackColor = ClsTemaCompras.PrincipalNavegador;
            EstiloEncabezados.Font = new System.Drawing.Font("Segoe UI", 9F);
            EstiloEncabezados.ForeColor = System.Drawing.Color.White;
            EstiloEncabezados.SelectionBackColor = ClsTemaCompras.AcentoNavegador;
            EstiloEncabezados.SelectionForeColor = System.Drawing.Color.White;
            this._ComprasDgvMain.ColumnHeadersDefaultCellStyle = EstiloEncabezados;
            this._ComprasDgvMain.ColumnHeadersHeight = 32;
            this._ComprasDgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EstiloCeldas.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            EstiloCeldas.BackColor = ClsTemaCompras.FondoGeneral;
            EstiloCeldas.Font = new System.Drawing.Font("Segoe UI", 9F);
            EstiloCeldas.ForeColor = ClsTemaCompras.PrincipalNavegador;
            EstiloCeldas.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            EstiloCeldas.SelectionBackColor = ClsTemaCompras.AcentoNavegador;
            EstiloCeldas.SelectionForeColor = System.Drawing.Color.White;
            EstiloCeldas.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._ComprasDgvMain.DefaultCellStyle = EstiloCeldas;
            this._ComprasDgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasDgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._ComprasDgvMain.EnableHeadersVisualStyles = false;
            this._ComprasDgvMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._ComprasDgvMain.GridColor = ClsTemaCompras.FondoBotones;
            this._ComprasDgvMain.Location = new System.Drawing.Point(1, 1);
            this._ComprasDgvMain.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasDgvMain.MultiSelect = false;
            this._ComprasDgvMain.Name = "ComprasDgvMain";
            this._ComprasDgvMain.ReadOnly = true;
            this._ComprasDgvMain.RowHeadersVisible = false;
            this._ComprasDgvMain.RowHeadersWidth = 51;
            EstiloFilas.BackColor = ClsTemaCompras.FondoGeneral;
            EstiloFilas.ForeColor = ClsTemaCompras.PrincipalNavegador;
            EstiloFilas.SelectionBackColor = ClsTemaCompras.AcentoNavegador;
            EstiloFilas.SelectionForeColor = System.Drawing.Color.White;
            this._ComprasDgvMain.RowsDefaultCellStyle = EstiloFilas;
            this._ComprasDgvMain.RowTemplate.Height = 28;
            this._ComprasDgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ComprasDgvMain.Size = new System.Drawing.Size(148, 148);
            this._ComprasDgvMain.TabIndex = 0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = ClsTemaCompras.FondoGeneral;
            this.ForeColor = ClsTemaCompras.PrincipalNavegador;
            this.Controls.Add(this._ComprasPnlBorde);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UsrDataGridViewCompras";
            this._ComprasPnlBorde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ComprasDgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _ComprasPnlBorde;
        private System.Windows.Forms.DataGridView _ComprasDgvMain;
    }
}
