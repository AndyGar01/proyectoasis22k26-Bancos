namespace CapaVista_Empleado.Formularios
{
    partial class FrmAsigPuestosNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsigPuestosNavegador));
            this.RrhhNavAsigPuestos = new CapaVista_Navegador.Navegador();
            this.RrhhBtnReporteAsigPuestos = new System.Windows.Forms.Button();
            this.RrhhBtnAyudaAsigPuestos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavAsigPuestos
            // 
            this.RrhhNavAsigPuestos.Location = new System.Drawing.Point(12, 92);
            this.RrhhNavAsigPuestos.Name = "RrhhNavAsigPuestos";
            this.RrhhNavAsigPuestos.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavAsigPuestos.TabIndex = 0;
            // 
            // RrhhBtnReporteAsigPuestos
            // 
            this.RrhhBtnReporteAsigPuestos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReporteAsigPuestos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteAsigPuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnReporteAsigPuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnReporteAsigPuestos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnReporteAsigPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteAsigPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteAsigPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnReporteAsigPuestos.Location = new System.Drawing.Point(1374, 8);
            this.RrhhBtnReporteAsigPuestos.Name = "RrhhBtnReporteAsigPuestos";
            this.RrhhBtnReporteAsigPuestos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnReporteAsigPuestos.TabIndex = 2;
            this.RrhhBtnReporteAsigPuestos.UseVisualStyleBackColor = false;
            this.RrhhBtnReporteAsigPuestos.Click += new System.EventHandler(this.RrhhBtnReporteAsigPuestos_Click);
            // 
            // RrhhBtnAyudaAsigPuestos
            // 
            this.RrhhBtnAyudaAsigPuestos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaAsigPuestos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaAsigPuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnAyudaAsigPuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnAyudaAsigPuestos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnAyudaAsigPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaAsigPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaAsigPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnAyudaAsigPuestos.Location = new System.Drawing.Point(1290, 8);
            this.RrhhBtnAyudaAsigPuestos.Name = "RrhhBtnAyudaAsigPuestos";
            this.RrhhBtnAyudaAsigPuestos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnAyudaAsigPuestos.TabIndex = 1;
            this.RrhhBtnAyudaAsigPuestos.UseVisualStyleBackColor = false;
            // 
            // FrmAsigPuestosNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 640);
            this.Controls.Add(this.RrhhBtnReporteAsigPuestos);
            this.Controls.Add(this.RrhhBtnAyudaAsigPuestos);
            this.Controls.Add(this.RrhhNavAsigPuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAsigPuestosNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "9006 – AsignacionPuestos";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavAsigPuestos;
        private System.Windows.Forms.Button RrhhBtnReporteAsigPuestos;
        private System.Windows.Forms.Button RrhhBtnAyudaAsigPuestos;
    }
}
