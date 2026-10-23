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
            this.SuspendLayout();
            // 
            // RrhhNavCapacitaciones
            // 
            this.RrhhNavCapacitaciones.Location = new System.Drawing.Point(3, 12);
            this.RrhhNavCapacitaciones.Name = "RrhhNavCapacitaciones";
            this.RrhhNavCapacitaciones.Size = new System.Drawing.Size(1435, 107);
            this.RrhhNavCapacitaciones.TabIndex = 1;
            // 
            // FrmEvaluacionNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 450);
            this.Controls.Add(this.RrhhNavCapacitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEvaluacionNavegador";
            this.Text = "FrmEvaluacion";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavCapacitaciones;
    }
}