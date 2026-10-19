namespace CapaVista_MuestreoAuditoria_Logistica
{
    partial class FrmAuditoriaInventario
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
            this.MuestreoLblTitulo = new System.Windows.Forms.Label();
            this.MuestreoLblDescripcion = new System.Windows.Forms.Label();
            this.MuestreoPnlOpciones = new System.Windows.Forms.Panel();
            this.MuestreoGpbNuevaAuditoria = new System.Windows.Forms.GroupBox();
            this.MuestreoBtnIndividual = new System.Windows.Forms.Button();
            this.MuestreoBtnMultiple = new System.Windows.Forms.Button();
            this.MuestreoGpbConsulta = new System.Windows.Forms.GroupBox();
            this.MuestreoLblBodega = new System.Windows.Forms.Label();
            this.MuestreoLblEstado = new System.Windows.Forms.Label();
            this.MuestreoLblBuscar = new System.Windows.Forms.Label();
            this.MuestreoCboBodega = new System.Windows.Forms.ComboBox();
            this.MuestreoCboEstado = new System.Windows.Forms.ComboBox();
            this.MuestreoTxtBuscar = new System.Windows.Forms.TextBox();
            this.MuestreoBtnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MuestreoPnlOpciones.SuspendLayout();
            this.MuestreoGpbNuevaAuditoria.SuspendLayout();
            this.MuestreoGpbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // MuestreoLblTitulo
            // 
            this.MuestreoLblTitulo.AutoSize = true;
            this.MuestreoLblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.MuestreoLblTitulo.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestreoLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(44)))), ((int)(((byte)(18)))));
            this.MuestreoLblTitulo.Location = new System.Drawing.Point(145, 25);
            this.MuestreoLblTitulo.Name = "MuestreoLblTitulo";
            this.MuestreoLblTitulo.Size = new System.Drawing.Size(624, 39);
            this.MuestreoLblTitulo.TabIndex = 0;
            this.MuestreoLblTitulo.Text = "Muestreo y Auditoría de Inventario";
            this.MuestreoLblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // MuestreoLblDescripcion
            // 
            this.MuestreoLblDescripcion.AutoSize = true;
            this.MuestreoLblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.MuestreoLblDescripcion.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestreoLblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(56)))));
            this.MuestreoLblDescripcion.Location = new System.Drawing.Point(148, 72);
            this.MuestreoLblDescripcion.Name = "MuestreoLblDescripcion";
            this.MuestreoLblDescripcion.Size = new System.Drawing.Size(399, 22);
            this.MuestreoLblDescripcion.TabIndex = 1;
            this.MuestreoLblDescripcion.Text = "Control y verificación de existencias de productos";
            // 
            // MuestreoPnlOpciones
            // 
            this.MuestreoPnlOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MuestreoPnlOpciones.BackColor = System.Drawing.Color.White;
            this.MuestreoPnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MuestreoPnlOpciones.Controls.Add(this.MuestreoGpbConsulta);
            this.MuestreoPnlOpciones.Controls.Add(this.MuestreoGpbNuevaAuditoria);
            this.MuestreoPnlOpciones.Location = new System.Drawing.Point(70, 124);
            this.MuestreoPnlOpciones.Name = "MuestreoPnlOpciones";
            this.MuestreoPnlOpciones.Size = new System.Drawing.Size(1150, 195);
            this.MuestreoPnlOpciones.TabIndex = 2;
            // 
            // MuestreoGpbNuevaAuditoria
            // 
            this.MuestreoGpbNuevaAuditoria.Controls.Add(this.MuestreoBtnMultiple);
            this.MuestreoGpbNuevaAuditoria.Controls.Add(this.MuestreoBtnIndividual);
            this.MuestreoGpbNuevaAuditoria.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestreoGpbNuevaAuditoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(44)))), ((int)(((byte)(18)))));
            this.MuestreoGpbNuevaAuditoria.Location = new System.Drawing.Point(15, 10);
            this.MuestreoGpbNuevaAuditoria.Name = "MuestreoGpbNuevaAuditoria";
            this.MuestreoGpbNuevaAuditoria.Size = new System.Drawing.Size(540, 170);
            this.MuestreoGpbNuevaAuditoria.TabIndex = 3;
            this.MuestreoGpbNuevaAuditoria.TabStop = false;
            this.MuestreoGpbNuevaAuditoria.Text = "Nueva auditoría";
            // 
            // MuestreoBtnIndividual
            // 
            this.MuestreoBtnIndividual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(197)))));
            this.MuestreoBtnIndividual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuestreoBtnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuestreoBtnIndividual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestreoBtnIndividual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(44)))), ((int)(((byte)(18)))));
            this.MuestreoBtnIndividual.Location = new System.Drawing.Point(20, 45);
            this.MuestreoBtnIndividual.Name = "MuestreoBtnIndividual";
            this.MuestreoBtnIndividual.Size = new System.Drawing.Size(240, 75);
            this.MuestreoBtnIndividual.TabIndex = 0;
            this.MuestreoBtnIndividual.Text = "Iniciar auditoría individual";
            this.MuestreoBtnIndividual.UseVisualStyleBackColor = false;
            // 
            // MuestreoBtnMultiple
            // 
            this.MuestreoBtnMultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(197)))));
            this.MuestreoBtnMultiple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuestreoBtnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuestreoBtnMultiple.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestreoBtnMultiple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(44)))), ((int)(((byte)(18)))));
            this.MuestreoBtnMultiple.Location = new System.Drawing.Point(275, 45);
            this.MuestreoBtnMultiple.Name = "MuestreoBtnMultiple";
            this.MuestreoBtnMultiple.Size = new System.Drawing.Size(240, 75);
            this.MuestreoBtnMultiple.TabIndex = 1;
            this.MuestreoBtnMultiple.Text = "Iniciar auditoría múltiple";
            this.MuestreoBtnMultiple.UseVisualStyleBackColor = false;
            // 
            // MuestreoGpbConsulta
            // 
            this.MuestreoGpbConsulta.Controls.Add(this.MuestreoBtnBuscar);
            this.MuestreoGpbConsulta.Controls.Add(this.MuestreoTxtBuscar);
            this.MuestreoGpbConsulta.Controls.Add(this.MuestreoCboEstado);
            this.MuestreoGpbConsulta.Controls.Add(this.MuestreoCboBodega);
            this.MuestreoGpbConsulta.Controls.Add(this.MuestreoLblBuscar);
            this.MuestreoGpbConsulta.Controls.Add(this.MuestreoLblEstado);
            this.MuestreoGpbConsulta.Controls.Add(this.MuestreoLblBodega);
            this.MuestreoGpbConsulta.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestreoGpbConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(44)))), ((int)(((byte)(18)))));
            this.MuestreoGpbConsulta.Location = new System.Drawing.Point(575, 10);
            this.MuestreoGpbConsulta.Name = "MuestreoGpbConsulta";
            this.MuestreoGpbConsulta.Size = new System.Drawing.Size(560, 170);
            this.MuestreoGpbConsulta.TabIndex = 4;
            this.MuestreoGpbConsulta.TabStop = false;
            this.MuestreoGpbConsulta.Text = "Consulta rápida";
            // 
            // MuestreoLblBodega
            // 
            this.MuestreoLblBodega.AutoSize = true;
            this.MuestreoLblBodega.Location = new System.Drawing.Point(15, 33);
            this.MuestreoLblBodega.Name = "MuestreoLblBodega";
            this.MuestreoLblBodega.Size = new System.Drawing.Size(77, 22);
            this.MuestreoLblBodega.TabIndex = 0;
            this.MuestreoLblBodega.Text = "Bodega";
            // 
            // MuestreoLblEstado
            // 
            this.MuestreoLblEstado.AutoSize = true;
            this.MuestreoLblEstado.Location = new System.Drawing.Point(200, 33);
            this.MuestreoLblEstado.Name = "MuestreoLblEstado";
            this.MuestreoLblEstado.Size = new System.Drawing.Size(70, 22);
            this.MuestreoLblEstado.TabIndex = 1;
            this.MuestreoLblEstado.Text = "Estado";
            // 
            // MuestreoLblBuscar
            // 
            this.MuestreoLblBuscar.AutoSize = true;
            this.MuestreoLblBuscar.Location = new System.Drawing.Point(15, 196);
            this.MuestreoLblBuscar.Name = "MuestreoLblBuscar";
            this.MuestreoLblBuscar.Size = new System.Drawing.Size(171, 22);
            this.MuestreoLblBuscar.TabIndex = 2;
            this.MuestreoLblBuscar.Text = "Buscar por código";
            // 
            // MuestreoCboBodega
            // 
            this.MuestreoCboBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MuestreoCboBodega.FormattingEnabled = true;
            this.MuestreoCboBodega.Location = new System.Drawing.Point(15, 57);
            this.MuestreoCboBodega.Name = "MuestreoCboBodega";
            this.MuestreoCboBodega.Size = new System.Drawing.Size(170, 30);
            this.MuestreoCboBodega.TabIndex = 3;
            // 
            // MuestreoCboEstado
            // 
            this.MuestreoCboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MuestreoCboEstado.FormattingEnabled = true;
            this.MuestreoCboEstado.Location = new System.Drawing.Point(200, 57);
            this.MuestreoCboEstado.Name = "MuestreoCboEstado";
            this.MuestreoCboEstado.Size = new System.Drawing.Size(150, 30);
            this.MuestreoCboEstado.TabIndex = 4;
            // 
            // MuestreoTxtBuscar
            // 
            this.MuestreoTxtBuscar.Location = new System.Drawing.Point(15, 120);
            this.MuestreoTxtBuscar.Name = "MuestreoTxtBuscar";
            this.MuestreoTxtBuscar.Size = new System.Drawing.Size(335, 29);
            this.MuestreoTxtBuscar.TabIndex = 5;
            // 
            // MuestreoBtnBuscar
            // 
            this.MuestreoBtnBuscar.Location = new System.Drawing.Point(370, 115);
            this.MuestreoBtnBuscar.Name = "MuestreoBtnBuscar";
            this.MuestreoBtnBuscar.Size = new System.Drawing.Size(160, 38);
            this.MuestreoBtnBuscar.TabIndex = 6;
            this.MuestreoBtnBuscar.Text = "Buscar";
            this.MuestreoBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(70, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 340);
            this.panel1.TabIndex = 3;
            // 
            // FrmAuditoriaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista_MuestreoAuditoria_Logistica.Properties.Resources.FondoLogistica;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1525, 912);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MuestreoPnlOpciones);
            this.Controls.Add(this.MuestreoLblDescripcion);
            this.Controls.Add(this.MuestreoLblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAuditoriaInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestreo y Auditoría de Inventario";
            this.UseWaitCursor = true;
            this.MuestreoPnlOpciones.ResumeLayout(false);
            this.MuestreoGpbNuevaAuditoria.ResumeLayout(false);
            this.MuestreoGpbConsulta.ResumeLayout(false);
            this.MuestreoGpbConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MuestreoLblTitulo;
        private System.Windows.Forms.Label MuestreoLblDescripcion;
        private System.Windows.Forms.Panel MuestreoPnlOpciones;
        private System.Windows.Forms.GroupBox MuestreoGpbNuevaAuditoria;
        private System.Windows.Forms.Button MuestreoBtnMultiple;
        private System.Windows.Forms.Button MuestreoBtnIndividual;
        private System.Windows.Forms.GroupBox MuestreoGpbConsulta;
        private System.Windows.Forms.ComboBox MuestreoCboEstado;
        private System.Windows.Forms.ComboBox MuestreoCboBodega;
        private System.Windows.Forms.Label MuestreoLblBuscar;
        private System.Windows.Forms.Label MuestreoLblEstado;
        private System.Windows.Forms.Label MuestreoLblBodega;
        private System.Windows.Forms.Button MuestreoBtnBuscar;
        private System.Windows.Forms.TextBox MuestreoTxtBuscar;
        private System.Windows.Forms.Panel panel1;
    }
}