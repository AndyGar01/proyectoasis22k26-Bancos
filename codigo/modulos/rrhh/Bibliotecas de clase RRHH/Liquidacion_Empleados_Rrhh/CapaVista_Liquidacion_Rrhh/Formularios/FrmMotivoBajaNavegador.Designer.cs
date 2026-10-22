namespace CapaVista_Liquidacion_Rrhh.Formularios
{
    partial class FrmMotivoBajaNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMotivoBajaNavegador));
            this.RrhhNavMotivoBaja = new CapaVista_Navegador.Navegador();
            this.RrhhBtnReporteLiqui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavMotivoBaja
            // 
            this.RrhhNavMotivoBaja.Location = new System.Drawing.Point(8, 88);
            this.RrhhNavMotivoBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RrhhNavMotivoBaja.Name = "RrhhNavMotivoBaja";
            this.RrhhNavMotivoBaja.Size = new System.Drawing.Size(1078, 90);
            this.RrhhNavMotivoBaja.TabIndex = 0;
            // 
            // RrhhBtnReporteLiqui
            // 
            this.RrhhBtnReporteLiqui.BackgroundImage = global::CapaVista_Liquidacion_Rrhh.Properties.Resources.boton_reporte_sin_bordes;
            this.RrhhBtnReporteLiqui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnReporteLiqui.Location = new System.Drawing.Point(688, 0);
            this.RrhhBtnReporteLiqui.Margin = new System.Windows.Forms.Padding(2);
            this.RrhhBtnReporteLiqui.Name = "RrhhBtnReporteLiqui";
            this.RrhhBtnReporteLiqui.Size = new System.Drawing.Size(70, 70);
            this.RrhhBtnReporteLiqui.TabIndex = 5;
            this.RrhhBtnReporteLiqui.UseVisualStyleBackColor = true;
            this.RrhhBtnReporteLiqui.Click += new System.EventHandler(this.RrhhBtnReporteLiqui_Click);
            // 
            // FrmMotivoBajaNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 625);
            this.Controls.Add(this.RrhhBtnReporteLiqui);
            this.Controls.Add(this.RrhhNavMotivoBaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMotivoBajaNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9702 - FrmMotivoBajaNavegador";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavMotivoBaja;
        private System.Windows.Forms.Button RrhhBtnReporteLiqui;
    }
}