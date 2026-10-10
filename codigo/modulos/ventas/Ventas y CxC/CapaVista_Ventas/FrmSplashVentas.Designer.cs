/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Definir imágenes, etiquetas, barra de progreso y temporizador del splash.
 */
namespace CapaVista_Ventas
{
    partial class FrmSplashVentas
    {
        private System.ComponentModel.IContainer components = null;

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
            this.VentasPbLogo = new System.Windows.Forms.PictureBox();
            this.VentasPbMascota = new System.Windows.Forms.PictureBox();
            this.VentasPbIcono = new System.Windows.Forms.PictureBox();
            this.VentasLblModulo = new System.Windows.Forms.Label();
            this.VentasLblTitulo = new System.Windows.Forms.Label();
            this.VentasLblMensaje = new System.Windows.Forms.Label();
            this.VentasPgbCarga = new System.Windows.Forms.ProgressBar();
            this.VentasLblPorcentaje = new System.Windows.Forms.Label();
            this.VentasLblLema = new System.Windows.Forms.Label();
            this._TimerCarga = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbIcono)).BeginInit();
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None; this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false; this.MinimizeBox = false; this.Name = "FrmSplashVentas"; this.Text = "VentasYCuentasPorCobrar – Splash";
            this.Icon = global::CapaVista_Ventas.Properties.Resources.IconoVentas;
            this.BackColor = System.Drawing.Color.FromArgb(248, 245, 249); this.BackgroundImage = global::CapaVista_Ventas.Properties.Resources.FondoSplashVentas; this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VentasPbLogo.Name = "VentasPbLogo";
            this.VentasPbLogo.Image = global::CapaVista_Ventas.Properties.Resources.LogoEmpresa;
            this.VentasPbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasPbLogo.BackColor = System.Drawing.Color.Transparent;
            this.VentasPbLogo.Location = new System.Drawing.Point(273, 60);
            this.VentasPbLogo.Size = new System.Drawing.Size(130, 126);
            this.VentasPbMascota.Name = "VentasPbMascota";
            this.VentasPbMascota.Image = global::CapaVista_Ventas.Properties.Resources.MascotaVentas;
            this.VentasPbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasPbMascota.BackColor = System.Drawing.Color.Transparent;
            this.VentasPbMascota.Location = new System.Drawing.Point(406, 45);
            this.VentasPbMascota.Size = new System.Drawing.Size(117, 147);
            this.VentasPbIcono.Name = "VentasPbIcono";
            this.VentasPbIcono.Image = global::CapaVista_Ventas.Properties.Resources.IconoVentasImagen;
            this.VentasPbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasPbIcono.BackColor = System.Drawing.Color.Transparent;
            this.VentasPbIcono.Location = new System.Drawing.Point(713, 21);
            this.VentasPbIcono.Size = new System.Drawing.Size(64, 64);
            this.VentasLblModulo.Name = "VentasLblModulo";
            this.VentasLblModulo.Text = "Ventas y cuentas por cobrar";
            this.VentasLblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasLblModulo.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblModulo.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblModulo.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.VentasLblModulo.Location = new System.Drawing.Point(80, 188);
            this.VentasLblModulo.Size = new System.Drawing.Size(640, 37);
            this.VentasLblTitulo.Name = "VentasLblTitulo";
            this.VentasLblTitulo.Text = "Cargando";
            this.VentasLblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasLblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTitulo.ForeColor = System.Drawing.Color.FromArgb(123, 63, 147);
            this.VentasLblTitulo.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold);
            this.VentasLblTitulo.Location = new System.Drawing.Point(80, 226);
            this.VentasLblTitulo.Size = new System.Drawing.Size(640, 31);
            this.VentasLblMensaje.Name = "VentasLblMensaje";
            this.VentasLblMensaje.Text = "Por favor espere mientras preparamos la mejor experiencia para usted.";
            this.VentasLblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasLblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblMensaje.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblMensaje.Font = new System.Drawing.Font("Tahoma", 11F);
            this.VentasLblMensaje.Location = new System.Drawing.Point(60, 260);
            this.VentasLblMensaje.Size = new System.Drawing.Size(680, 29);
            this.VentasPgbCarga.Name = "VentasPgbCarga";
            this.VentasPgbCarga.Location = new System.Drawing.Point(163, 302);
            this.VentasPgbCarga.Size = new System.Drawing.Size(476, 22);
            this.VentasPgbCarga.Maximum = 100;
            this.VentasPgbCarga.Value = 0;
            this.VentasPgbCarga.AccessibleName = "Progreso de presentación de Ventas";
            this.VentasPgbCarga.ForeColor = System.Drawing.Color.FromArgb(123, 63, 147);
            this.VentasPgbCarga.BackColor = System.Drawing.Color.FromArgb(228, 212, 234);
            this.VentasPgbCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.VentasLblPorcentaje.Name = "VentasLblPorcentaje";
            this.VentasLblPorcentaje.Text = "0%";
            this.VentasLblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasLblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblPorcentaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.VentasLblPorcentaje.Location = new System.Drawing.Point(330, 328);
            this.VentasLblPorcentaje.Size = new System.Drawing.Size(140, 27);
            this.VentasLblLema.Name = "VentasLblLema";
            this.VentasLblLema.Text = "Embutidos de Calidad S.A. · Calidad en cada proceso";
            this.VentasLblLema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasLblLema.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblLema.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblLema.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblLema.Location = new System.Drawing.Point(80, 361);
            this.VentasLblLema.Size = new System.Drawing.Size(640, 24);
            this._TimerCarga.Interval = 35; this._TimerCarga.Tick += new System.EventHandler(this.VentasTimerCarga_Tick);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.VentasPbLogo, this.VentasPbMascota, this.VentasPbIcono, this.VentasLblModulo, this.VentasLblTitulo, this.VentasLblMensaje, this.VentasPgbCarga, this.VentasLblPorcentaje, this.VentasLblLema });
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbIcono)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox VentasPbLogo;
        private System.Windows.Forms.PictureBox VentasPbMascota;
        private System.Windows.Forms.PictureBox VentasPbIcono;
        private System.Windows.Forms.Label VentasLblModulo;
        private System.Windows.Forms.Label VentasLblTitulo;
        private System.Windows.Forms.Label VentasLblMensaje;
        private System.Windows.Forms.ProgressBar VentasPgbCarga;
        private System.Windows.Forms.Label VentasLblPorcentaje;
        private System.Windows.Forms.Label VentasLblLema;
        private System.Windows.Forms.Timer _TimerCarga;
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
