namespace CapaVista_TransporteInterno_Logistica.Formas
{
    partial class FrmControlTransporte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogisticaLblTituloTransporteInterno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogisticaNavTransporteInterno = new CapaVista_Navegador.Navegador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CapaVista_TransporteInterno_Logistica.Properties.Resources.FondoLogistica;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LogisticaNavTransporteInterno);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LogisticaLblTituloTransporteInterno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1525, 912);
            this.panel1.TabIndex = 0;
            // 
            // LogisticaLblTituloTransporteInterno
            // 
            this.LogisticaLblTituloTransporteInterno.AutoSize = true;
            this.LogisticaLblTituloTransporteInterno.BackColor = System.Drawing.Color.Transparent;
            this.LogisticaLblTituloTransporteInterno.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold);
            this.LogisticaLblTituloTransporteInterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblTituloTransporteInterno.Location = new System.Drawing.Point(41, 53);
            this.LogisticaLblTituloTransporteInterno.Name = "LogisticaLblTituloTransporteInterno";
            this.LogisticaLblTituloTransporteInterno.Size = new System.Drawing.Size(681, 40);
            this.LogisticaLblTituloTransporteInterno.TabIndex = 2;
            this.LogisticaLblTituloTransporteInterno.Text = "Control y Seguimiento de Transporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(942, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verifica la condición del vehiculo, registra la salida, monitorea el viaje y docu" +
    "menta incidencias.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CapaVista_TransporteInterno_Logistica.Properties.Resources._7;
            this.pictureBox1.Location = new System.Drawing.Point(1242, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 322);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LogisticaNavTransporteInterno
            // 
            this.LogisticaNavTransporteInterno.BackColor = System.Drawing.Color.Transparent;
            this.LogisticaNavTransporteInterno.Location = new System.Drawing.Point(48, 318);
            this.LogisticaNavTransporteInterno.Name = "LogisticaNavTransporteInterno";
            this.LogisticaNavTransporteInterno.Size = new System.Drawing.Size(1438, 111);
            this.LogisticaNavTransporteInterno.TabIndex = 6;
            // 
            // FrmControlTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FrmControlTransporte";
            this.Text = "FrmAsignarTransporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LogisticaLblTituloTransporteInterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CapaVista_Navegador.Navegador LogisticaNavTransporteInterno;
    }
}