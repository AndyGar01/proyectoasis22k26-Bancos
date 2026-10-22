namespace CapaVista_Empleado.Formularios
{
    partial class FrmCapacitacionesNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapacitacionesNavegador));
            this.RrhhNavCapacitaciones = new CapaVista_Navegador.Navegador();
            this.RrhhBtnReporteCapacitacion = new System.Windows.Forms.Button();
            this.RrhhBtnAyudaCapacitacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavCapacitaciones
            // 
            this.RrhhNavCapacitaciones.Location = new System.Drawing.Point(12, 35);
            this.RrhhNavCapacitaciones.Name = "RrhhNavCapacitaciones";
            this.RrhhNavCapacitaciones.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavCapacitaciones.TabIndex = 0;
            // 
            // RrhhBtnReporteCapacitacion
            // 
            this.RrhhBtnReporteCapacitacion.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReporteCapacitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnReporteCapacitacion.Location = new System.Drawing.Point(1442, 52);
            this.RrhhBtnReporteCapacitacion.Name = "RrhhBtnReporteCapacitacion";
            this.RrhhBtnReporteCapacitacion.Size = new System.Drawing.Size(97, 77);
            this.RrhhBtnReporteCapacitacion.TabIndex = 2;
            this.RrhhBtnReporteCapacitacion.UseVisualStyleBackColor = true;
            this.RrhhBtnReporteCapacitacion.Click += new System.EventHandler(this.RrhhBtnReporteCapacitacion_Click);
            // 
            // RrhhBtnAyudaCapacitacion
            // 
            this.RrhhBtnAyudaCapacitacion.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaCapacitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnAyudaCapacitacion.Location = new System.Drawing.Point(837, 56);
            this.RrhhBtnAyudaCapacitacion.Name = "RrhhBtnAyudaCapacitacion";
            this.RrhhBtnAyudaCapacitacion.Size = new System.Drawing.Size(89, 73);
            this.RrhhBtnAyudaCapacitacion.TabIndex = 1;
            this.RrhhBtnAyudaCapacitacion.UseVisualStyleBackColor = true;
            // 
            // FrmCapacitacionesNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 562);
            this.Controls.Add(this.RrhhBtnReporteCapacitacion);
            this.Controls.Add(this.RrhhBtnAyudaCapacitacion);
            this.Controls.Add(this.RrhhNavCapacitaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCapacitacionesNavegador";
            this.Text = "9302 - FrmCapacitacionesNavegador";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavCapacitaciones;
        private System.Windows.Forms.Button RrhhBtnAyudaCapacitacion;
        private System.Windows.Forms.Button RrhhBtnReporteCapacitacion;
    }
}