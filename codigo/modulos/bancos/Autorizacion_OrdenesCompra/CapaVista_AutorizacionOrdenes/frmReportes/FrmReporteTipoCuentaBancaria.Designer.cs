namespace CapaVista_AutorizacionOrdenes.frmReportes
{
    partial class FrmReporteTipoCuentaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteTipoCuentaBancaria));
            this.BancosRvTipoCuentaBancaria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BancosRvTipoCuentaBancaria
            // 
            this.BancosRvTipoCuentaBancaria.Location = new System.Drawing.Point(1, 3);
            this.BancosRvTipoCuentaBancaria.Name = "BancosRvTipoCuentaBancaria";
            this.BancosRvTipoCuentaBancaria.ServerReport.BearerToken = null;
            this.BancosRvTipoCuentaBancaria.Size = new System.Drawing.Size(1256, 686);
            this.BancosRvTipoCuentaBancaria.TabIndex = 0;
            // 
            // FrmReporteTipoCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 688);
            this.Controls.Add(this.BancosRvTipoCuentaBancaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReporteTipoCuentaBancaria";
            this.Text = "8003-FrmReporteTipoCuentaBancaria";
            this.Load += new System.EventHandler(this.FrmReporteTipoCuentaBancaria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BancosRvTipoCuentaBancaria;
    }
}