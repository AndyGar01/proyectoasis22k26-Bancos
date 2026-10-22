namespace CapaVista_Empleado.Formularios
{
    partial class FrmPuestosNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuestosNavegador));
            this.RrhhNavPuestos = new CapaVista_Navegador.Navegador();
            this.RrhhBtnReportePuestos = new System.Windows.Forms.Button();
            this.RrhhBtnAyudaPuestos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavPuestos
            // 
            this.RrhhNavPuestos.Location = new System.Drawing.Point(12, 92);
            this.RrhhNavPuestos.Name = "RrhhNavPuestos";
            this.RrhhNavPuestos.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavPuestos.TabIndex = 0;
            // 
            // RrhhBtnReportePuestos
            // 
            this.RrhhBtnReportePuestos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReportePuestos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReportePuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnReportePuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnReportePuestos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnReportePuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReportePuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReportePuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnReportePuestos.Location = new System.Drawing.Point(1374, 8);
            this.RrhhBtnReportePuestos.Name = "RrhhBtnReportePuestos";
            this.RrhhBtnReportePuestos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnReportePuestos.TabIndex = 2;
            this.RrhhBtnReportePuestos.UseVisualStyleBackColor = false;
            this.RrhhBtnReportePuestos.Click += new System.EventHandler(this.RrhhBtnReportePuestos_Click);
            // 
            // RrhhBtnAyudaPuestos
            // 
            this.RrhhBtnAyudaPuestos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaPuestos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaPuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnAyudaPuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnAyudaPuestos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnAyudaPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnAyudaPuestos.Location = new System.Drawing.Point(1290, 8);
            this.RrhhBtnAyudaPuestos.Name = "RrhhBtnAyudaPuestos";
            this.RrhhBtnAyudaPuestos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnAyudaPuestos.TabIndex = 1;
            this.RrhhBtnAyudaPuestos.UseVisualStyleBackColor = false;
            // 
            // FrmPuestosNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 640);
            this.Controls.Add(this.RrhhBtnReportePuestos);
            this.Controls.Add(this.RrhhBtnAyudaPuestos);
            this.Controls.Add(this.RrhhNavPuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPuestosNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "9004 – Puestos";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavPuestos;
        private System.Windows.Forms.Button RrhhBtnReportePuestos;
        private System.Windows.Forms.Button RrhhBtnAyudaPuestos;
    }
}
