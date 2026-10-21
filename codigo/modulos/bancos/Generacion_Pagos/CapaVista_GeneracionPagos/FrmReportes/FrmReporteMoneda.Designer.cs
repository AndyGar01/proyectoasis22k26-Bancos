namespace CapaVista_GeneracionPagos.FrmReportes
{
    partial class FrmReporteMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteMoneda));
            this.BancosRvMoneda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BancosRvMoneda
            // 
            this.BancosRvMoneda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BancosRvMoneda.Location = new System.Drawing.Point(0, 0);
            this.BancosRvMoneda.Name = "BancosRvMoneda";
            this.BancosRvMoneda.ServerReport.BearerToken = null;
            this.BancosRvMoneda.Size = new System.Drawing.Size(800, 450);
            this.BancosRvMoneda.TabIndex = 0;
            // 
            // FrmReporteMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BancosRvMoneda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8001 – ReporteMoneda";
            this.Load += new System.EventHandler(this.FrmReporteMoneda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BancosRvMoneda;
    }
}