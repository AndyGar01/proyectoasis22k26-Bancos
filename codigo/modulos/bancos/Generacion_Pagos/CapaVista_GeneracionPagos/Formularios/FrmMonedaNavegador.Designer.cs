namespace CapaVista_GeneracionPagos.Formularios
{
    partial class FrmMonedaNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedaNavegador));
            this.BancosNavMoneda = new CapaVista_Navegador.Navegador();
            this.BancosBtnReporte = new System.Windows.Forms.Button();
            this.BancosBtnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BancosNavMoneda
            // 
            this.BancosNavMoneda.Location = new System.Drawing.Point(-1, -1);
            this.BancosNavMoneda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BancosNavMoneda.Name = "BancosNavMoneda";
            this.BancosNavMoneda.Size = new System.Drawing.Size(1078, 90);
            this.BancosNavMoneda.TabIndex = 0;
            // 
            // BancosBtnReporte
            // 
            this.BancosBtnReporte.BackgroundImage = global::CapaVista_GeneracionPagos.Properties.Resources.btn_reporteB;
            this.BancosBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnReporte.Location = new System.Drawing.Point(541, 12);
            this.BancosBtnReporte.Name = "BancosBtnReporte";
            this.BancosBtnReporte.Size = new System.Drawing.Size(77, 69);
            this.BancosBtnReporte.TabIndex = 1;
            this.BancosBtnReporte.UseVisualStyleBackColor = true;
            this.BancosBtnReporte.Click += new System.EventHandler(this.BancosBtnReporte_Click_1);
            // 
            // BancosBtnAyuda
            // 
            this.BancosBtnAyuda.BackgroundImage = global::CapaVista_GeneracionPagos.Properties.Resources.btn_ayudaB;
            this.BancosBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnAyuda.Location = new System.Drawing.Point(12, 555);
            this.BancosBtnAyuda.Name = "BancosBtnAyuda";
            this.BancosBtnAyuda.Size = new System.Drawing.Size(71, 69);
            this.BancosBtnAyuda.TabIndex = 2;
            this.BancosBtnAyuda.UseVisualStyleBackColor = true;
            // 
            // FrmMonedaNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 626);
            this.Controls.Add(this.BancosBtnAyuda);
            this.Controls.Add(this.BancosBtnReporte);
            this.Controls.Add(this.BancosNavMoneda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMonedaNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\t8001 – MantenimientoMoneda";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador BancosNavMoneda;
        private System.Windows.Forms.Button BancosBtnReporte;
        private System.Windows.Forms.Button BancosBtnAyuda;
    }
}