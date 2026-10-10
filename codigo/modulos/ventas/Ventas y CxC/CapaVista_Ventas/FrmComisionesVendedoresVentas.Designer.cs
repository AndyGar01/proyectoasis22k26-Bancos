/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Definir las propiedades estandarizadas de la ventana vacía de comisiones de vendedores.
 */
namespace CapaVista_Ventas
{
    partial class FrmComisionesVendedoresVentas
    {
        private System.ComponentModel.IContainer components = null;

        // Libera los componentes que el equipo incorpore desde el diseñador.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();
            // Propiedades comunes de las ventanas secundarias de Ventas; no se agregan controles.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(248, 245, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = true;
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::CapaVista_Ventas.Properties.Resources.IconoVentas;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmComisionesVendedoresVentas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "7008 – Comisiones de vendedores";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
