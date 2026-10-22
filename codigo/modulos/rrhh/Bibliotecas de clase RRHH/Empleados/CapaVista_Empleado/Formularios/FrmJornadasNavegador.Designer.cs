namespace CapaVista_Empleado.Formularios
{
    partial class FrmJornadasNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJornadasNavegador));
            this.RrhhNavJornadas = new CapaVista_Navegador.Navegador();
            this.RrhhBtnReporteJornadas = new System.Windows.Forms.Button();
            this.RrhhBtnAyudaJornadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavJornadas
            // 
            this.RrhhNavJornadas.Location = new System.Drawing.Point(12, 92);
            this.RrhhNavJornadas.Name = "RrhhNavJornadas";
            this.RrhhNavJornadas.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavJornadas.TabIndex = 0;
            // 
            // RrhhBtnReporteJornadas
            // 
            this.RrhhBtnReporteJornadas.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReporteJornadas.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteJornadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnReporteJornadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnReporteJornadas.FlatAppearance.BorderSize = 0;
            this.RrhhBtnReporteJornadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteJornadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteJornadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnReporteJornadas.Location = new System.Drawing.Point(1374, 8);
            this.RrhhBtnReporteJornadas.Name = "RrhhBtnReporteJornadas";
            this.RrhhBtnReporteJornadas.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnReporteJornadas.TabIndex = 2;
            this.RrhhBtnReporteJornadas.UseVisualStyleBackColor = false;
            this.RrhhBtnReporteJornadas.Click += new System.EventHandler(this.RrhhBtnReporteJornadas_Click);
            // 
            // RrhhBtnAyudaJornadas
            // 
            this.RrhhBtnAyudaJornadas.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaJornadas.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaJornadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnAyudaJornadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnAyudaJornadas.FlatAppearance.BorderSize = 0;
            this.RrhhBtnAyudaJornadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaJornadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaJornadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnAyudaJornadas.Location = new System.Drawing.Point(1290, 8);
            this.RrhhBtnAyudaJornadas.Name = "RrhhBtnAyudaJornadas";
            this.RrhhBtnAyudaJornadas.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnAyudaJornadas.TabIndex = 1;
            this.RrhhBtnAyudaJornadas.UseVisualStyleBackColor = false;
            // 
            // FrmJornadasNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 640);
            this.Controls.Add(this.RrhhBtnReporteJornadas);
            this.Controls.Add(this.RrhhBtnAyudaJornadas);
            this.Controls.Add(this.RrhhNavJornadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmJornadasNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "9005 – Jornadas";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavJornadas;
        private System.Windows.Forms.Button RrhhBtnReporteJornadas;
        private System.Windows.Forms.Button RrhhBtnAyudaJornadas;
    }
}
