namespace CapaVista_Componentes.Componentes
{
    partial class UsrMDITabCompras
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.clsTableLayoutPanelCompras1 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.SuspendLayout();
            // 
            // clsTableLayoutPanelCompras1
            // 
            this.clsTableLayoutPanelCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsTableLayoutPanelCompras1.ColumnCount = 2;
            this.clsTableLayoutPanelCompras1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.clsTableLayoutPanelCompras1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsTableLayoutPanelCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsTableLayoutPanelCompras1.Location = new System.Drawing.Point(0, 0);
            this.clsTableLayoutPanelCompras1.Margin = new System.Windows.Forms.Padding(0);
            this.clsTableLayoutPanelCompras1.Name = "clsTableLayoutPanelCompras1";
            this.clsTableLayoutPanelCompras1.RowCount = 1;
            this.clsTableLayoutPanelCompras1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clsTableLayoutPanelCompras1.Size = new System.Drawing.Size(252, 82);
            this.clsTableLayoutPanelCompras1.TabIndex = 0;
            // 
            // UsrMDITabCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.clsTableLayoutPanelCompras1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UsrMDITabCompras";
            this.Size = new System.Drawing.Size(252, 82);
            this.ResumeLayout(false);

        }

        private ClsTableLayoutPanelCompras clsTableLayoutPanelCompras1;
    }
}
