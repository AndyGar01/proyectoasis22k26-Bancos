namespace CapaVista_Inventario_Logistica.Formas
{
    partial class FrmMantenimientoSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoSucursales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogisticaNavSucursales = new CapaVista_Navegador.Navegador();
            this.LogisticaLblDescripcionTitulo = new System.Windows.Forms.Label();
            this.LogisticaLblTituloSucursalesBodegas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.LogisticaNavSucursales);
            this.panel1.Controls.Add(this.LogisticaLblDescripcionTitulo);
            this.panel1.Controls.Add(this.LogisticaLblTituloSucursalesBodegas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 711);
            this.panel1.TabIndex = 0;
            // 
            // LogisticaNavSucursales
            // 
            this.LogisticaNavSucursales.Location = new System.Drawing.Point(2, 110);
            this.LogisticaNavSucursales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogisticaNavSucursales.Name = "LogisticaNavSucursales";
            this.LogisticaNavSucursales.Size = new System.Drawing.Size(1078, 90);
            this.LogisticaNavSucursales.TabIndex = 4;
            // 
            // LogisticaLblDescripcionTitulo
            // 
            this.LogisticaLblDescripcionTitulo.AutoSize = true;
            this.LogisticaLblDescripcionTitulo.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaLblDescripcionTitulo.Location = new System.Drawing.Point(37, 66);
            this.LogisticaLblDescripcionTitulo.Name = "LogisticaLblDescripcionTitulo";
            this.LogisticaLblDescripcionTitulo.Size = new System.Drawing.Size(346, 21);
            this.LogisticaLblDescripcionTitulo.TabIndex = 3;
            this.LogisticaLblDescripcionTitulo.Text = "Administra y asigna bodegas a las sucursales";
            // 
            // LogisticaLblTituloSucursalesBodegas
            // 
            this.LogisticaLblTituloSucursalesBodegas.AutoSize = true;
            this.LogisticaLblTituloSucursalesBodegas.BackColor = System.Drawing.Color.Transparent;
            this.LogisticaLblTituloSucursalesBodegas.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaLblTituloSucursalesBodegas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblTituloSucursalesBodegas.Location = new System.Drawing.Point(36, 24);
            this.LogisticaLblTituloSucursalesBodegas.Name = "LogisticaLblTituloSucursalesBodegas";
            this.LogisticaLblTituloSucursalesBodegas.Size = new System.Drawing.Size(167, 32);
            this.LogisticaLblTituloSucursalesBodegas.TabIndex = 2;
            this.LogisticaLblTituloSucursalesBodegas.Text = "Sucursales";
            // 
            // FrmMantenimientoSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 711);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimientoSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantenimientoSucursales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogisticaLblDescripcionTitulo;
        private System.Windows.Forms.Label LogisticaLblTituloSucursalesBodegas;
        private CapaVista_Navegador.Navegador LogisticaNavSucursales;
    }
}