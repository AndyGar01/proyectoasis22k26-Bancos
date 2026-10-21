namespace CapaVista_MovimientosBancarios.Formularios
{
    partial class FrmTipoTransaccionNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoTransaccionNavegador));
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.BancosbtnAyudas = new System.Windows.Forms.Button();
            this.BancosbtnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(15, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1437, 111);
            this.navegador1.TabIndex = 0;
            // 
            // BancosbtnAyudas
            // 
            this.BancosbtnAyudas.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.btn_ayudaB1;
            this.BancosbtnAyudas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosbtnAyudas.Location = new System.Drawing.Point(834, 33);
            this.BancosbtnAyudas.Name = "BancosbtnAyudas";
            this.BancosbtnAyudas.Size = new System.Drawing.Size(100, 75);
            this.BancosbtnAyudas.TabIndex = 2;
            this.BancosbtnAyudas.UseVisualStyleBackColor = true;
            this.BancosbtnAyudas.Click += new System.EventHandler(this.BancosbtnAyudas_Click);
            // 
            // BancosbtnReportes
            // 
            this.BancosbtnReportes.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.btn_reporteB;
            this.BancosbtnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosbtnReportes.Location = new System.Drawing.Point(735, 33);
            this.BancosbtnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.BancosbtnReportes.Name = "BancosbtnReportes";
            this.BancosbtnReportes.Size = new System.Drawing.Size(100, 75);
            this.BancosbtnReportes.TabIndex = 1;
            this.BancosbtnReportes.UseVisualStyleBackColor = true;
            this.BancosbtnReportes.Click += new System.EventHandler(this.BancosbtnReportes_Click);
            // 
            // FrmTipoTransaccionNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 875);
            this.Controls.Add(this.BancosbtnAyudas);
            this.Controls.Add(this.BancosbtnReportes);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTipoTransaccionNavegador";
            this.Text = "8004-MantenimientoTipoTransacción";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button BancosbtnReportes;
        private System.Windows.Forms.Button BancosbtnAyudas;
    }
}