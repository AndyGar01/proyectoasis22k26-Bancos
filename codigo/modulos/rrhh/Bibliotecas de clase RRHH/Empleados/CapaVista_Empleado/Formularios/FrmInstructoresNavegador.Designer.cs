namespace CapaVista_Empleado.Formularios
{
    partial class FrmInstructoresNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstructoresNavegador));
            this.RrhhNavInstructores = new CapaVista_Navegador.Navegador();
            this.RrhhBtnAyudaInstructor = new System.Windows.Forms.Button();
            this.RrhhBtnReporteInstructor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RrhhNavInstructores
            // 
            this.RrhhNavInstructores.Location = new System.Drawing.Point(-1, 12);
            this.RrhhNavInstructores.Name = "RrhhNavInstructores";
            this.RrhhNavInstructores.Size = new System.Drawing.Size(1438, 111);
            this.RrhhNavInstructores.TabIndex = 0;
            // 
            // RrhhBtnAyudaInstructor
            // 
            this.RrhhBtnAyudaInstructor.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyudaInstructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnAyudaInstructor.Location = new System.Drawing.Point(830, 32);
            this.RrhhBtnAyudaInstructor.Name = "RrhhBtnAyudaInstructor";
            this.RrhhBtnAyudaInstructor.Size = new System.Drawing.Size(89, 73);
            this.RrhhBtnAyudaInstructor.TabIndex = 2;
            this.RrhhBtnAyudaInstructor.UseVisualStyleBackColor = true;
            this.RrhhBtnAyudaInstructor.Click += new System.EventHandler(this.RrhhBtnAyudaInstructor_Click);
            // 
            // RrhhBtnReporteInstructor
            // 
            this.RrhhBtnReporteInstructor.BackgroundImage = global::CapaVista_Empleado.Properties.Resources.btn_reporte;
            this.RrhhBtnReporteInstructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnReporteInstructor.Location = new System.Drawing.Point(1429, 30);
            this.RrhhBtnReporteInstructor.Name = "RrhhBtnReporteInstructor";
            this.RrhhBtnReporteInstructor.Size = new System.Drawing.Size(97, 77);
            this.RrhhBtnReporteInstructor.TabIndex = 3;
            this.RrhhBtnReporteInstructor.UseVisualStyleBackColor = true;
            this.RrhhBtnReporteInstructor.Click += new System.EventHandler(this.RrhhBtnReporteInstructor_Click);
            // 
            // FrmInstructoresNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 562);
            this.Controls.Add(this.RrhhBtnReporteInstructor);
            this.Controls.Add(this.RrhhBtnAyudaInstructor);
            this.Controls.Add(this.RrhhNavInstructores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInstructoresNavegador";
            this.Text = "9303 - FrmInstructoresNavegador";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavInstructores;
        private System.Windows.Forms.Button RrhhBtnAyudaInstructor;
        private System.Windows.Forms.Button RrhhBtnReporteInstructor;
    }
}