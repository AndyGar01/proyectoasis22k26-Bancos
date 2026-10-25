namespace CapaVista_Seguridad
{
    partial class FrmPerfilesNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilesNavegador));
            this.navegador3 = new CapaVista_Navegador.Navegador();
            this.SuspendLayout();
            // 
            // navegador3
            // 
            this.navegador3.Location = new System.Drawing.Point(-1, 2);
            this.navegador3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navegador3.Name = "navegador3";
            this.navegador3.Size = new System.Drawing.Size(1437, 111);
            this.navegador3.TabIndex = 0;
            // 
            // FrmPerfilesNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 578);
            this.Controls.Add(this.navegador3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPerfilesNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2008 - FrmPerfilesNavegador";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador3;
    }
}