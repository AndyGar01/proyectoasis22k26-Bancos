namespace CapaVista_DisponibilidadDiaria.Formularios
{
    partial class FrmCuentaBancariaNavegador
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.BancosBtnFooterReporte = new System.Windows.Forms.Button();
            this.BancosBtnFooterAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(3, 23);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1441, 108);
            this.navegador1.TabIndex = 0;
            // 
            // BancosBtnFooterReporte
            // 
            this.BancosBtnFooterReporte.BackColor = System.Drawing.Color.Transparent;
            this.BancosBtnFooterReporte.BackgroundImage = global::CapaVista_DisponibilidadDiaria.Properties.Resources.btn_reporteB;
            this.BancosBtnFooterReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BancosBtnFooterReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BancosBtnFooterReporte.FlatAppearance.BorderSize = 0;
            this.BancosBtnFooterReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BancosBtnFooterReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BancosBtnFooterReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BancosBtnFooterReporte.Location = new System.Drawing.Point(116, 738);
            this.BancosBtnFooterReporte.Margin = new System.Windows.Forms.Padding(4);
            this.BancosBtnFooterReporte.Name = "BancosBtnFooterReporte";
            this.BancosBtnFooterReporte.Size = new System.Drawing.Size(69, 64);
            this.BancosBtnFooterReporte.TabIndex = 3;
            this.BancosBtnFooterReporte.UseVisualStyleBackColor = false;
            this.BancosBtnFooterReporte.Click += new System.EventHandler(this.BancosBtnFooterReporte_Click);
            // 
            // BancosBtnFooterAyuda
            // 
            this.BancosBtnFooterAyuda.BackColor = System.Drawing.Color.Transparent;
            this.BancosBtnFooterAyuda.BackgroundImage = global::CapaVista_DisponibilidadDiaria.Properties.Resources.btn_ayuda;
            this.BancosBtnFooterAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BancosBtnFooterAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BancosBtnFooterAyuda.FlatAppearance.BorderSize = 0;
            this.BancosBtnFooterAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BancosBtnFooterAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BancosBtnFooterAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BancosBtnFooterAyuda.Location = new System.Drawing.Point(33, 738);
            this.BancosBtnFooterAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.BancosBtnFooterAyuda.Name = "BancosBtnFooterAyuda";
            this.BancosBtnFooterAyuda.Size = new System.Drawing.Size(69, 64);
            this.BancosBtnFooterAyuda.TabIndex = 2;
            this.BancosBtnFooterAyuda.UseVisualStyleBackColor = false;
            this.BancosBtnFooterAyuda.Click += new System.EventHandler(this.BancosBtnFooterAyuda_Click);
            // 
            // FrmCuentaBancariaNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 834);
            this.Controls.Add(this.BancosBtnFooterReporte);
            this.Controls.Add(this.BancosBtnFooterAyuda);
            this.Controls.Add(this.navegador1);
            this.Name = "FrmCuentaBancariaNavegador";
            this.Text = "FrmCuentaBancariaNavegador";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button BancosBtnFooterReporte;
        private System.Windows.Forms.Button BancosBtnFooterAyuda;
    }
}