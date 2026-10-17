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
            this._ComprasPnlDesplazamiento.SuspendLayout();
            this._ComprasPnlContenido.SuspendLayout();
            this._ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlDesplazamiento.Name = "_ComprasPnlDesplazamiento";
            this._ComprasPnlDesplazamiento.Size = CapaVista_Componentes.Componentes.ClsPresentacionCompras.TamanoFormulario;
            this._ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasPnlContenido.Name = "_ComprasPnlContenido";
            this._ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlContenido.Size = new System.Drawing.Size(1183, CapaVista_Componentes.Componentes.ClsPresentacionCompras.AlturaContenido);

            this.SuspendLayout();

            this.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);


            this.Name = "FrmPolizas";
            this.Text = "6002 – Polizas";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = false;
            this.ClientSize = CapaVista_Componentes.Componentes.ClsPresentacionCompras.TamanoFormulario;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this._ComprasPnlDesplazamiento.Controls.Add(this._ComprasPnlContenido);
            this.Controls.Add(this._ComprasPnlDesplazamiento);
            this._ComprasPnlContenido.ResumeLayout(false);
            this._ComprasPnlContenido.PerformLayout();
            this._ComprasPnlDesplazamiento.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
