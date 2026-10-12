/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Definir las propiedades estandarizadas de la ventana vacía de cotizaciones, pedidos y facturas.
 */
namespace CapaVista_Ventas
{
    partial class FrmCotizacionesPedidosFacturasVentas
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
            this.VentasPnlEncabezado = new System.Windows.Forms.Panel();
            this.VentasLblTitulo = new System.Windows.Forms.Label();
            this.VentasLblSubtitulo = new System.Windows.Forms.Label();
            this.VentasLblAyudaPedidos = new System.Windows.Forms.Label();
            this.VentasBtnAbrirPedidos = new System.Windows.Forms.Button();
            this.VentasPnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // Encabezado estandarizado del módulo.
            this.VentasPnlEncabezado.BackColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasPnlEncabezado.Controls.Add(this.VentasLblTitulo);
            this.VentasPnlEncabezado.Controls.Add(this.VentasLblSubtitulo);
            this.VentasPnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.VentasPnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.VentasPnlEncabezado.Name = "VentasPnlEncabezado";
            this.VentasPnlEncabezado.Padding = new System.Windows.Forms.Padding(28, 18, 28, 18);
            this.VentasPnlEncabezado.Size = new System.Drawing.Size(1000, 104);
            this.VentasPnlEncabezado.TabIndex = 0;
            // Título del formulario.
            this.VentasLblTitulo.AutoSize = true;
            this.VentasLblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.VentasLblTitulo.ForeColor = System.Drawing.Color.White;
            this.VentasLblTitulo.Location = new System.Drawing.Point(28, 19);
            this.VentasLblTitulo.Name = "VentasLblTitulo";
            this.VentasLblTitulo.Size = new System.Drawing.Size(446, 37);
            this.VentasLblTitulo.TabIndex = 0;
            this.VentasLblTitulo.Text = "Cotizaciones, pedidos y facturas";
            // Subtítulo del formulario.
            this.VentasLblSubtitulo.AutoSize = true;
            this.VentasLblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VentasLblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(228, 212, 234);
            this.VentasLblSubtitulo.Location = new System.Drawing.Point(32, 66);
            this.VentasLblSubtitulo.Name = "VentasLblSubtitulo";
            this.VentasLblSubtitulo.Size = new System.Drawing.Size(261, 15);
            this.VentasLblSubtitulo.TabIndex = 1;
            this.VentasLblSubtitulo.Text = "VENTAS Y CUENTAS POR COBRAR  /  7007";
            // Acceso al prototipo de pedidos.
            this.VentasBtnAbrirPedidos.BackColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasBtnAbrirPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(201, 162, 74);
            this.VentasBtnAbrirPedidos.FlatAppearance.BorderSize = 2;
            this.VentasBtnAbrirPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnAbrirPedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.VentasBtnAbrirPedidos.ForeColor = System.Drawing.Color.White;
            this.VentasBtnAbrirPedidos.Location = new System.Drawing.Point(340, 246);
            this.VentasBtnAbrirPedidos.Name = "VentasBtnAbrirPedidos";
            this.VentasBtnAbrirPedidos.Size = new System.Drawing.Size(320, 64);
            this.VentasBtnAbrirPedidos.TabIndex = 0;
            this.VentasBtnAbrirPedidos.Text = "Abrir formulario de pedidos";
            this.VentasBtnAbrirPedidos.UseVisualStyleBackColor = false;
            this.VentasBtnAbrirPedidos.Click += new System.EventHandler(this.VentasBtnAbrirPedidos_Click);
            // Descripción del acceso al prototipo de pedidos.
            this.VentasLblAyudaPedidos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.VentasLblAyudaPedidos.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblAyudaPedidos.Location = new System.Drawing.Point(190, 184);
            this.VentasLblAyudaPedidos.Name = "VentasLblAyudaPedidos";
            this.VentasLblAyudaPedidos.Size = new System.Drawing.Size(620, 42);
            this.VentasLblAyudaPedidos.TabIndex = 1;
            this.VentasLblAyudaPedidos.Text = "Consulta el prototipo visual para pedidos por cotización y pedidos independientes.";
            this.VentasLblAyudaPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(248, 245, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.VentasLblAyudaPedidos);
            this.Controls.Add(this.VentasBtnAbrirPedidos);
            this.Controls.Add(this.VentasPnlEncabezado);
            this.ControlBox = true;
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::CapaVista_Ventas.Properties.Resources.IconoVentas;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmCotizacionesPedidosFacturasVentas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "7007 – Cotizaciones, pedidos y facturas";
            this.VentasPnlEncabezado.ResumeLayout(false);
            this.VentasPnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel VentasPnlEncabezado;
        private System.Windows.Forms.Label VentasLblTitulo;
        private System.Windows.Forms.Label VentasLblSubtitulo;
        private System.Windows.Forms.Label VentasLblAyudaPedidos;
        private System.Windows.Forms.Button VentasBtnAbrirPedidos;
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
