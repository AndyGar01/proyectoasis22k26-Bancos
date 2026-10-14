namespace CapaVista_Compras
{
    partial class FrmSplash
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this._Componentes = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this._ComprasPgbCarga = new System.Windows.Forms.ProgressBar();
            this._ComprasTmrContenido = new System.Windows.Forms.Timer(this._Componentes);
            this._ComprasLblTitulo = new System.Windows.Forms.Label();
            this._ComprasLblMensaje = new System.Windows.Forms.Label();
            this._ComprasLblPorcentaje = new System.Windows.Forms.Label();
            this._ComprasPbMarca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).BeginInit();
            this.SuspendLayout();
            //
            // ComprasPgbCarga
            //
            this._ComprasPgbCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasPgbCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasPgbCarga.Location = new System.Drawing.Point(223, 410);
            this._ComprasPgbCarga.Margin = new System.Windows.Forms.Padding(4);
            this._ComprasPgbCarga.Name = "ComprasPgbCarga";
            this._ComprasPgbCarga.Size = new System.Drawing.Size(635, 31);
            this._ComprasPgbCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._ComprasPgbCarga.TabIndex = 2;
            //
            // _TimerCarga
            //
            this._ComprasTmrContenido.Interval = 35;
            this._ComprasTmrContenido.Tick += new System.EventHandler(this.ComprasMetActualizarProgreso);
            //
            // ComprasLblTitulo
            //
            this._ComprasLblTitulo.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasLblTitulo.Location = new System.Drawing.Point(74, 256);
            this._ComprasLblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._ComprasLblTitulo.Name = "ComprasLblTitulo";
            this._ComprasLblTitulo.Size = new System.Drawing.Size(933, 86);
            this._ComprasLblTitulo.TabIndex = 3;
            this._ComprasLblTitulo.Text = "COMPRAS";
            this._ComprasLblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ComprasLblMensaje
            //
            this._ComprasLblMensaje.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasLblMensaje.Location = new System.Drawing.Point(127, 345);
            this._ComprasLblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._ComprasLblMensaje.Name = "ComprasLblMensaje";
            this._ComprasLblMensaje.Size = new System.Drawing.Size(823, 62);
            this._ComprasLblMensaje.TabIndex = 5;
            this._ComprasLblMensaje.Text = "Iniciando el sistema de gestión de compras...";
            this._ComprasLblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ComprasLblPorcentaje
            //
            this._ComprasLblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this._ComprasLblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasLblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this._ComprasLblPorcentaje.Location = new System.Drawing.Point(139, 444);
            this._ComprasLblPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._ComprasLblPorcentaje.Name = "ComprasLblPorcentaje";
            this._ComprasLblPorcentaje.Size = new System.Drawing.Size(800, 43);
            this._ComprasLblPorcentaje.TabIndex = 6;
            this._ComprasLblPorcentaje.Text = "0%";
            this._ComprasLblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pictureBox2
            //
            this._ComprasPbMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasPbMarca.BackgroundImage")));
            this._ComprasPbMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasPbMarca.Location = new System.Drawing.Point(443, 72);
            this._ComprasPbMarca.Name = "ComprasPbMarca";
            this._ComprasPbMarca.Size = new System.Drawing.Size(184, 181);
            this._ComprasPbMarca.TabIndex = 8;
            this._ComprasPbMarca.TabStop = false;
            //
            // FrmSplash
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this._ComprasPbMarca);
            this.Controls.Add(this._ComprasLblPorcentaje);
            this.Controls.Add(this._ComprasLblMensaje);
            this.Controls.Add(this._ComprasLblTitulo);
            this.Controls.Add(this._ComprasPgbCarga);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this._ComprasPbMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar _ComprasPgbCarga;
        private System.Windows.Forms.Timer _ComprasTmrContenido;
        private System.Windows.Forms.Label _ComprasLblTitulo;
        private System.Windows.Forms.Label _ComprasLblMensaje;
        private System.Windows.Forms.Label _ComprasLblPorcentaje;
        private System.Windows.Forms.PictureBox _ComprasPbMarca;
    }
}
