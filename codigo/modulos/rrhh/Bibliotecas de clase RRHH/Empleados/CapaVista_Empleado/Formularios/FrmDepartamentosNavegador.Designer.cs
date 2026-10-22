namespace CapaVista_Empleado.Formularios
{
    partial class FrmDepartamentosNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamentosNavegador));
            this.RrhhNavDepartamentos = new CapaVista_Navegador.Navegador();
            this.RrhhBtnReporteDepartamentos = new System.Windows.Forms.Button();
            this.RrhhBtnAyudaDepartamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavDepartamentos
            // 
            this.RrhhNavDepartamentos.Location = new System.Drawing.Point(12, 92);
            this.RrhhNavDepartamentos.Name = "RrhhNavDepartamentos";
            this.RrhhNavDepartamentos.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavDepartamentos.TabIndex = 0;
            // 
            // RrhhBtnReporteDepartamentos
            // 
            this.RrhhBtnReporteDepartamentos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReporteDepartamentos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnReporteDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnReporteDepartamentos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnReporteDepartamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnReporteDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnReporteDepartamentos.Location = new System.Drawing.Point(1374, 8);
            this.RrhhBtnReporteDepartamentos.Name = "RrhhBtnReporteDepartamentos";
            this.RrhhBtnReporteDepartamentos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnReporteDepartamentos.TabIndex = 2;
            this.RrhhBtnReporteDepartamentos.UseVisualStyleBackColor = false;
            this.RrhhBtnReporteDepartamentos.Click += new System.EventHandler(this.RrhhBtnReporteDepartamentos_Click);
            // 
            // RrhhBtnAyudaDepartamentos
            // 
            this.RrhhBtnAyudaDepartamentos.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaDepartamentos.BackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RrhhBtnAyudaDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnAyudaDepartamentos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnAyudaDepartamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RrhhBtnAyudaDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnAyudaDepartamentos.Location = new System.Drawing.Point(1290, 8);
            this.RrhhBtnAyudaDepartamentos.Name = "RrhhBtnAyudaDepartamentos";
            this.RrhhBtnAyudaDepartamentos.Size = new System.Drawing.Size(76, 76);
            this.RrhhBtnAyudaDepartamentos.TabIndex = 1;
            this.RrhhBtnAyudaDepartamentos.UseVisualStyleBackColor = false;
            // 
            // FrmDepartamentosNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 640);
            this.Controls.Add(this.RrhhBtnReporteDepartamentos);
            this.Controls.Add(this.RrhhBtnAyudaDepartamentos);
            this.Controls.Add(this.RrhhNavDepartamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDepartamentosNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "9002 – Departamentos";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavDepartamentos;
        private System.Windows.Forms.Button RrhhBtnReporteDepartamentos;
        private System.Windows.Forms.Button RrhhBtnAyudaDepartamentos;
    }
}
