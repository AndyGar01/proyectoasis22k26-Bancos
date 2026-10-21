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
            this.RrhhNavInstructores = new CapaVista_Navegador.Navegador();
            this.SuspendLayout();
            // 
            // RrhhNavInstructores
            // 
            this.RrhhNavInstructores.Location = new System.Drawing.Point(-1, 12);
            this.RrhhNavInstructores.Name = "RrhhNavInstructores";
            this.RrhhNavInstructores.Size = new System.Drawing.Size(1438, 111);
            this.RrhhNavInstructores.TabIndex = 0;
            // 
            // FrmInstructoresNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 562);
            this.Controls.Add(this.RrhhNavInstructores);
            this.Name = "FrmInstructoresNavegador";
            this.Text = "FrmInstructoresNavegador";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador RrhhNavInstructores;
    }
}