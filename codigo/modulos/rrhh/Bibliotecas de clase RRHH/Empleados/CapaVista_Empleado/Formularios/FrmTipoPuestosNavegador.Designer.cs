namespace CapaVista_Empleado.Formularios
{
    partial class FrmTipoPuestosNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoPuestosNavegador));
            this.RrhhNavTipoPuestos = new CapaVista_Navegador.Navegador();
            this.RrhhBtnReporteTipoPuestos = new System.Windows.Forms.Button();
            this.RrhhBtnAyudaTipoPuestos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavTipoPuestos
            // 
            this.RrhhNavTipoPuestos.Location = new System.Drawing.Point(12, 92);
            this.RrhhNavTipoPuestos.Name = "RrhhNavTipoPuestos";
            this.RrhhNavTipoPuestos.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavTipoPuestos.TabIndex = 0;
            // 
            // RrhhBtnReporteTipoPuestos
            // 
            this.RrhhBtnReporteTipoPuestos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReporteTipoPuestos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteTipoPuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnReporteTipoPuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnReporteTipoPuestos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnReporteTipoPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteTipoPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteTipoPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnReporteTipoPuestos.Location = new System.Drawing.Point(1374, 8);
            this.RrhhBtnReporteTipoPuestos.Name = "RrhhBtnReporteTipoPuestos";
            this.RrhhBtnReporteTipoPuestos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnReporteTipoPuestos.TabIndex = 2;
            this.RrhhBtnReporteTipoPuestos.UseVisualStyleBackColor = false;
            this.RrhhBtnReporteTipoPuestos.Click += new System.EventHandler(this.RrhhBtnReporteTipoPuestos_Click);
            // 
            // RrhhBtnAyudaTipoPuestos
            // 
            this.RrhhBtnAyudaTipoPuestos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaTipoPuestos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaTipoPuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnAyudaTipoPuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnAyudaTipoPuestos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnAyudaTipoPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaTipoPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaTipoPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnAyudaTipoPuestos.Location = new System.Drawing.Point(1290, 8);
            this.RrhhBtnAyudaTipoPuestos.Name = "RrhhBtnAyudaTipoPuestos";
            this.RrhhBtnAyudaTipoPuestos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnAyudaTipoPuestos.TabIndex = 1;
            this.RrhhBtnAyudaTipoPuestos.UseVisualStyleBackColor = false;
            // 
            // FrmTipoPuestosNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 640);
            this.Controls.Add(this.RrhhBtnReporteTipoPuestos);
            this.Controls.Add(this.RrhhBtnAyudaTipoPuestos);
            this.Controls.Add(this.RrhhNavTipoPuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTipoPuestosNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "9003 – TipoPuestos";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavTipoPuestos;
        private System.Windows.Forms.Button RrhhBtnReporteTipoPuestos;
        private System.Windows.Forms.Button RrhhBtnAyudaTipoPuestos;
    }
}
