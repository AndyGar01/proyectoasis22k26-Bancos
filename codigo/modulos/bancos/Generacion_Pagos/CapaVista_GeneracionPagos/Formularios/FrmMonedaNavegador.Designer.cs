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
            this.BancosbtnAyudas = new System.Windows.Forms.Button();
            this.BancosBtnAyuda = new System.Windows.Forms.Button();
            this.BancosBtnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BancosNavMoneda
            // 
            this.BancosNavMoneda.Location = new System.Drawing.Point(-1, -1);
            this.BancosNavMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BancosNavMoneda.Name = "BancosNavMoneda";
            this.BancosNavMoneda.Size = new System.Drawing.Size(1437, 111);
            this.BancosNavMoneda.TabIndex = 0;
            // 
            // BancosbtnAyudas
            // 
            this.BancosbtnAyudas.BackgroundImage = global::CapaVista_GeneracionPagos.Properties.Resources.btn_ayudaB1;
            this.BancosbtnAyudas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosbtnAyudas.Location = new System.Drawing.Point(821, 19);
            this.BancosbtnAyudas.Name = "BancosbtnAyudas";
            this.BancosbtnAyudas.Size = new System.Drawing.Size(103, 81);
            this.BancosbtnAyudas.TabIndex = 3;
            this.BancosbtnAyudas.UseVisualStyleBackColor = true;
            this.BancosbtnAyudas.Click += new System.EventHandler(this.BancosbtnAyudas_Click);
            // 
            // BancosBtnAyuda
            // 
            this.BancosBtnAyuda.BackgroundImage = global::CapaVista_GeneracionPagos.Properties.Resources.btn_ayudaB;
            this.BancosBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnAyuda.Location = new System.Drawing.Point(16, 683);
            this.BancosBtnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.BancosBtnAyuda.Name = "BancosBtnAyuda";
            this.BancosBtnAyuda.Size = new System.Drawing.Size(95, 85);
            this.BancosBtnAyuda.TabIndex = 2;
            this.BancosBtnAyuda.UseVisualStyleBackColor = true;
            // 
            // BancosBtnReporte
            // 
            this.BancosBtnReporte.BackgroundImage = global::CapaVista_GeneracionPagos.Properties.Resources.btn_reporteB;
            this.BancosBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnReporte.Location = new System.Drawing.Point(721, 15);
            this.BancosBtnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.BancosBtnReporte.Name = "BancosBtnReporte";
            this.BancosBtnReporte.Size = new System.Drawing.Size(103, 85);
            this.BancosBtnReporte.TabIndex = 1;
            this.BancosBtnReporte.UseVisualStyleBackColor = true;
            this.BancosBtnReporte.Click += new System.EventHandler(this.BancosBtnReporte_Click_1);
            // 
            // FrmMonedaNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 770);
            this.Controls.Add(this.BancosbtnAyudas);
            this.Controls.Add(this.BancosBtnAyuda);
            this.Controls.Add(this.BancosBtnReporte);
            this.Controls.Add(this.BancosNavMoneda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BancosbtnAyudas;
    }
}