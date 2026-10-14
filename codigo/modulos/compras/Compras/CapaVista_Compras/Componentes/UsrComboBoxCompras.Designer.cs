
namespace CapaVista_Compras.Componentes
{
    partial class UsrComboBoxCompras
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
            this._ComprasTlpMain = new CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras();
            this._ComprasPnlBorde = new System.Windows.Forms.Panel();
            this._ComprasCboEntrada = new CapaVista_Compras.Componentes.ClsSelectorCompras();
            this.ComprasUsrError = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this._ComprasTlpMain.SuspendLayout();
            this._ComprasPnlBorde.SuspendLayout();
            this.SuspendLayout();
            //
            // ComprasTlpMain
            //
            this._ComprasTlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasTlpMain.ColumnCount = 1;
            this._ComprasTlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMain.Controls.Add(this._ComprasPnlBorde, 0, 0);
            this._ComprasTlpMain.Controls.Add(this.ComprasUsrError, 0, 1);
            this._ComprasTlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasTlpMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasTlpMain.Location = new System.Drawing.Point(0, 0);
            this._ComprasTlpMain.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasTlpMain.Name = "ComprasTlpMain";
            this._ComprasTlpMain.Padding = new System.Windows.Forms.Padding(3);
            this._ComprasTlpMain.RowCount = 2;
            this._ComprasTlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._ComprasTlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._ComprasTlpMain.Size = new System.Drawing.Size(174, 66);
            this._ComprasTlpMain.TabIndex = 0;
            //
            // ComprasPnlBorde
            //
            this._ComprasPnlBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasPnlBorde.Controls.Add(this._ComprasCboEntrada);
            this._ComprasPnlBorde.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlBorde.Location = new System.Drawing.Point(3, 3);
            this._ComprasPnlBorde.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlBorde.Name = "ComprasPnlBorde";
            this._ComprasPnlBorde.Padding = new System.Windows.Forms.Padding(1);
            this._ComprasPnlBorde.Size = new System.Drawing.Size(168, 30);
            this._ComprasPnlBorde.TabIndex = 2;
            //
            // ComprasCboEntrada
            //
            this._ComprasCboEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this._ComprasCboEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasCboEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComprasCboEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasCboEntrada.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._ComprasCboEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasCboEntrada.Location = new System.Drawing.Point(1, 1);
            this._ComprasCboEntrada.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasCboEntrada.Name = "ComprasCboEntrada";
            this._ComprasCboEntrada.Size = new System.Drawing.Size(166, 31);
            this._ComprasCboEntrada.TabIndex = 0;
            //
            // ComprasUsrError
            //
            this.ComprasUsrError.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrError.ColorTexto = System.Drawing.Color.Red;
            this.ComprasUsrError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrError.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrError.ForeColor = System.Drawing.Color.Red;
            this.ComprasUsrError.Location = new System.Drawing.Point(6, 37);
            this.ComprasUsrError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasUsrError.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrError.MostrarAsterisco = false;
            this.ComprasUsrError.Name = "ComprasUsrError";
            this.ComprasUsrError.Size = new System.Drawing.Size(162, 22);
            this.ComprasUsrError.TabIndex = 0;
            this.ComprasUsrError.TabStop = false;
            this.ComprasUsrError.Text = "";
            this.ComprasUsrError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrError.Texto = "";
            //
            // UsrComboBoxCompras
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this._ComprasTlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UsrComboBoxCompras";
            this.Size = new System.Drawing.Size(174, 66);
            this._ComprasTlpMain.ResumeLayout(false);
            this._ComprasPnlBorde.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Compras.Componentes.ClsTableLayoutPanelCompras _ComprasTlpMain;
        private System.Windows.Forms.Panel _ComprasPnlBorde;
        private UsrLabelCompras ComprasUsrError;
        private CapaVista_Compras.Componentes.ClsSelectorCompras _ComprasCboEntrada;
    }
}
