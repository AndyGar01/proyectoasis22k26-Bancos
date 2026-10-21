namespace CapaVista_AutorizacionOrdenes.Formularios
{
    partial class FrmTipoCuentaBancariaNavegador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoCuentaBancariaNavegador));
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.BancosBtnAyuda = new System.Windows.Forms.Button();
            this.BancosBtnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 108);
            this.navegador1.TabIndex = 0;
            // 
            // BancosBtnAyuda
            // 
            this.BancosBtnAyuda.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_ayuda;
            this.BancosBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnAyuda.Location = new System.Drawing.Point(833, 28);
            this.BancosBtnAyuda.Name = "BancosBtnAyuda";
            this.BancosBtnAyuda.Size = new System.Drawing.Size(98, 77);
            this.BancosBtnAyuda.TabIndex = 1;
            this.BancosBtnAyuda.UseVisualStyleBackColor = true;
            // 
            // BancosBtnReporte
            // 
            this.BancosBtnReporte.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_reporteB;
            this.BancosBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnReporte.Location = new System.Drawing.Point(733, 28);
            this.BancosBtnReporte.Name = "BancosBtnReporte";
            this.BancosBtnReporte.Size = new System.Drawing.Size(94, 77);
            this.BancosBtnReporte.TabIndex = 2;
            this.BancosBtnReporte.UseVisualStyleBackColor = true;
            this.BancosBtnReporte.Click += new System.EventHandler(this.BancosBtnReporte_Click);
            // 
            // FrmTipoCuentaBancariaNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 799);
            this.Controls.Add(this.BancosBtnReporte);
            this.Controls.Add(this.BancosBtnAyuda);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoCuentaBancariaNavegador";
            this.Text = "8003-FrmTipoCuentaBancaria";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button BancosBtnAyuda;
        private System.Windows.Forms.Button BancosBtnReporte;
    }
}