namespace CapaVista_Empleado.Formularios
{
    partial class FrmEvaluacionNavegador
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
            this.RrhhNavCapacitaciones = new CapaVista_Navegador.Navegador();
            this.RrhhBtnAyudaEvaluacion = new System.Windows.Forms.Button();
            this.RrhhBtnReporteEvaluacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavCapacitaciones
            // 
            this.RrhhNavCapacitaciones.Location = new System.Drawing.Point(3, 12);
            this.RrhhNavCapacitaciones.Name = "RrhhNavCapacitaciones";
            this.RrhhNavCapacitaciones.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavCapacitaciones.TabIndex = 1;
            // 
            // RrhhBtnAyudaEvaluacion
            // 
            this.RrhhBtnAyudaEvaluacion.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaEvaluacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnAyudaEvaluacion.Location = new System.Drawing.Point(831, 31);
            this.RrhhBtnAyudaEvaluacion.Name = "RrhhBtnAyudaEvaluacion";
            this.RrhhBtnAyudaEvaluacion.Size = new System.Drawing.Size(89, 73);
            this.RrhhBtnAyudaEvaluacion.TabIndex = 2;
            this.RrhhBtnAyudaEvaluacion.UseVisualStyleBackColor = true;
            this.RrhhBtnAyudaEvaluacion.Click += new System.EventHandler(this.RrhhBtnAyudaEvaluacion_Click);
            // 
            // RrhhBtnReporteEvaluacion
            // 
            this.RrhhBtnReporteEvaluacion.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReporteEvaluacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnReporteEvaluacion.Location = new System.Drawing.Point(1444, 27);
            this.RrhhBtnReporteEvaluacion.Name = "RrhhBtnReporteEvaluacion";
            this.RrhhBtnReporteEvaluacion.Size = new System.Drawing.Size(97, 77);
            this.RrhhBtnReporteEvaluacion.TabIndex = 3;
            this.RrhhBtnReporteEvaluacion.UseVisualStyleBackColor = true;
            this.RrhhBtnReporteEvaluacion.Click += new System.EventHandler(this.RrhhBtnReporteEvaluacion_Click);
            // 
            // FrmEvaluacionNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 450);
            this.Controls.Add(this.RrhhBtnReporteEvaluacion);
            this.Controls.Add(this.RrhhBtnAyudaEvaluacion);
            this.Controls.Add(this.RrhhNavCapacitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEvaluacionNavegador";
            this.Text = "FrmEvaluacion";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavCapacitaciones;
        private System.Windows.Forms.Button RrhhBtnAyudaEvaluacion;
        private System.Windows.Forms.Button RrhhBtnReporteEvaluacion;
    }
}