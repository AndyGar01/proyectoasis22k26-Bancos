namespace CapaVista_Ventas
{
    partial class FrmListadoPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPrecios));
            this.VentasPnlEncabezado = new System.Windows.Forms.Panel();
            this.VentasPbMarca = new System.Windows.Forms.PictureBox();
            this.VentasLblTitulo = new System.Windows.Forms.Label();
            this.VentasLblSubtitulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VentasLblTipCliente = new System.Windows.Forms.Label();
            this.VentasLblPorDescuento = new System.Windows.Forms.Label();
            this.VentasNudPorDescuento = new System.Windows.Forms.NumericUpDown();
            this.VentasLblPor = new System.Windows.Forms.Label();
            this.VentaLblPreBase = new System.Windows.Forms.Label();
            this.VentasTxtPreBase = new System.Windows.Forms.TextBox();
            this.VentaLblPreFinal = new System.Windows.Forms.Label();
            this.VentasTxtPreFinal = new System.Windows.Forms.TextBox();
            this.VentasLblLstCliente = new System.Windows.Forms.Label();
            this.VentasDgvLstCliente = new System.Windows.Forms.DataGridView();
            this.VentasClmTipCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasClmPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasClmPreBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasClmPreFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasClmAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasBtnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VentasPnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasNudPorDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDgvLstCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // VentasPnlEncabezado
            // 
            this.VentasPnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasPnlEncabezado.Controls.Add(this.VentasPbMarca);
            this.VentasPnlEncabezado.Controls.Add(this.VentasLblTitulo);
            this.VentasPnlEncabezado.Controls.Add(this.VentasLblSubtitulo);
            this.VentasPnlEncabezado.Location = new System.Drawing.Point(2, 0);
            this.VentasPnlEncabezado.Name = "VentasPnlEncabezado";
            this.VentasPnlEncabezado.Size = new System.Drawing.Size(952, 78);
            this.VentasPnlEncabezado.TabIndex = 1;
            // 
            // VentasPbMarca
            // 
            this.VentasPbMarca.Image = global::CapaVista_Ventas.Properties.Resources.IconoVentasImagen;
            this.VentasPbMarca.Location = new System.Drawing.Point(20, 13);
            this.VentasPbMarca.Name = "VentasPbMarca";
            this.VentasPbMarca.Size = new System.Drawing.Size(52, 52);
            this.VentasPbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasPbMarca.TabIndex = 1;
            this.VentasPbMarca.TabStop = false;
            // 
            // VentasLblTitulo
            // 
            this.VentasLblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTitulo.Font = new System.Drawing.Font("Lucida Fax", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.VentasLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.VentasLblTitulo.Location = new System.Drawing.Point(87, 13);
            this.VentasLblTitulo.Name = "VentasLblTitulo";
            this.VentasLblTitulo.Size = new System.Drawing.Size(570, 35);
            this.VentasLblTitulo.TabIndex = 2;
            this.VentasLblTitulo.Text = "Listado de Precios";
            // 
            // VentasLblSubtitulo
            // 
            this.VentasLblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblSubtitulo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.VentasLblSubtitulo.Location = new System.Drawing.Point(89, 48);
            this.VentasLblSubtitulo.Name = "VentasLblSubtitulo";
            this.VentasLblSubtitulo.Size = new System.Drawing.Size(575, 22);
            this.VentasLblSubtitulo.TabIndex = 3;
            this.VentasLblSubtitulo.Text = "Clasifica los tipo de cliente y su porcentaje de precio";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mayorista",
            "Minorista",
            "Publico",
            "Canal 1",
            "Canal 2",
            "Canal 3",
            "Otros"});
            this.comboBox1.Location = new System.Drawing.Point(37, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // VentasLblTipCliente
            // 
            this.VentasLblTipCliente.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblTipCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblTipCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblTipCliente.Location = new System.Drawing.Point(33, 121);
            this.VentasLblTipCliente.Name = "VentasLblTipCliente";
            this.VentasLblTipCliente.Size = new System.Drawing.Size(180, 30);
            this.VentasLblTipCliente.TabIndex = 7;
            this.VentasLblTipCliente.Text = "Tipo de cliente";
            this.VentasLblTipCliente.Click += new System.EventHandler(this.VentasLblCotNumero_Click);
            // 
            // VentasLblPorDescuento
            // 
            this.VentasLblPorDescuento.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblPorDescuento.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblPorDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblPorDescuento.Location = new System.Drawing.Point(323, 121);
            this.VentasLblPorDescuento.Name = "VentasLblPorDescuento";
            this.VentasLblPorDescuento.Size = new System.Drawing.Size(237, 30);
            this.VentasLblPorDescuento.TabIndex = 8;
            this.VentasLblPorDescuento.Text = "Porcentaje de Descuento";
            // 
            // VentasNudPorDescuento
            // 
            this.VentasNudPorDescuento.Location = new System.Drawing.Point(342, 154);
            this.VentasNudPorDescuento.Name = "VentasNudPorDescuento";
            this.VentasNudPorDescuento.Size = new System.Drawing.Size(126, 26);
            this.VentasNudPorDescuento.TabIndex = 9;
            // 
            // VentasLblPor
            // 
            this.VentasLblPor.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblPor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblPor.Location = new System.Drawing.Point(474, 152);
            this.VentasLblPor.Name = "VentasLblPor";
            this.VentasLblPor.Size = new System.Drawing.Size(34, 30);
            this.VentasLblPor.TabIndex = 10;
            this.VentasLblPor.Text = "%";
            this.VentasLblPor.Click += new System.EventHandler(this.label1_Click);
            // 
            // VentaLblPreBase
            // 
            this.VentaLblPreBase.BackColor = System.Drawing.Color.Transparent;
            this.VentaLblPreBase.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentaLblPreBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentaLblPreBase.Location = new System.Drawing.Point(588, 120);
            this.VentaLblPreBase.Name = "VentaLblPreBase";
            this.VentaLblPreBase.Size = new System.Drawing.Size(114, 30);
            this.VentaLblPreBase.TabIndex = 11;
            this.VentaLblPreBase.Text = "Precio Base";
            // 
            // VentasTxtPreBase
            // 
            this.VentasTxtPreBase.Location = new System.Drawing.Point(617, 153);
            this.VentasTxtPreBase.Name = "VentasTxtPreBase";
            this.VentasTxtPreBase.Size = new System.Drawing.Size(110, 26);
            this.VentasTxtPreBase.TabIndex = 12;
            // 
            // VentaLblPreFinal
            // 
            this.VentaLblPreFinal.BackColor = System.Drawing.Color.Transparent;
            this.VentaLblPreFinal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentaLblPreFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentaLblPreFinal.Location = new System.Drawing.Point(775, 120);
            this.VentaLblPreFinal.Name = "VentaLblPreFinal";
            this.VentaLblPreFinal.Size = new System.Drawing.Size(114, 30);
            this.VentaLblPreFinal.TabIndex = 13;
            this.VentaLblPreFinal.Text = "Precio Final";
            // 
            // VentasTxtPreFinal
            // 
            this.VentasTxtPreFinal.Location = new System.Drawing.Point(806, 154);
            this.VentasTxtPreFinal.Name = "VentasTxtPreFinal";
            this.VentasTxtPreFinal.Size = new System.Drawing.Size(110, 26);
            this.VentasTxtPreFinal.TabIndex = 14;
            // 
            // VentasLblLstCliente
            // 
            this.VentasLblLstCliente.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblLstCliente.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VentasLblLstCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasLblLstCliente.Location = new System.Drawing.Point(305, 255);
            this.VentasLblLstCliente.Name = "VentasLblLstCliente";
            this.VentasLblLstCliente.Size = new System.Drawing.Size(361, 30);
            this.VentasLblLstCliente.TabIndex = 15;
            this.VentasLblLstCliente.Text = "Listado de Precios por Tipo de Cliente";
            // 
            // VentasDgvLstCliente
            // 
            this.VentasDgvLstCliente.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.VentasDgvLstCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasDgvLstCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VentasClmTipCliente,
            this.VentasClmPor,
            this.VentasClmPreBase,
            this.VentasClmPreFinal,
            this.VentasClmAct});
            this.VentasDgvLstCliente.GridColor = System.Drawing.Color.Black;
            this.VentasDgvLstCliente.Location = new System.Drawing.Point(160, 291);
            this.VentasDgvLstCliente.Name = "VentasDgvLstCliente";
            this.VentasDgvLstCliente.RowHeadersWidth = 62;
            this.VentasDgvLstCliente.RowTemplate.Height = 28;
            this.VentasDgvLstCliente.Size = new System.Drawing.Size(776, 134);
            this.VentasDgvLstCliente.TabIndex = 16;
            this.VentasDgvLstCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VentasDgvLstCliente_CellContentClick);
            // 
            // VentasClmTipCliente
            // 
            this.VentasClmTipCliente.HeaderText = "Tipo de cliente";
            this.VentasClmTipCliente.MinimumWidth = 8;
            this.VentasClmTipCliente.Name = "VentasClmTipCliente";
            this.VentasClmTipCliente.Width = 150;
            // 
            // VentasClmPor
            // 
            this.VentasClmPor.HeaderText = "Porcentaje(%)";
            this.VentasClmPor.MinimumWidth = 8;
            this.VentasClmPor.Name = "VentasClmPor";
            this.VentasClmPor.Width = 150;
            // 
            // VentasClmPreBase
            // 
            this.VentasClmPreBase.HeaderText = "Precio Base (Q)";
            this.VentasClmPreBase.MinimumWidth = 8;
            this.VentasClmPreBase.Name = "VentasClmPreBase";
            this.VentasClmPreBase.Width = 150;
            // 
            // VentasClmPreFinal
            // 
            this.VentasClmPreFinal.HeaderText = "Precio Final (Q)";
            this.VentasClmPreFinal.MinimumWidth = 8;
            this.VentasClmPreFinal.Name = "VentasClmPreFinal";
            this.VentasClmPreFinal.Width = 150;
            // 
            // VentasClmAct
            // 
            this.VentasClmAct.HeaderText = "Acciones";
            this.VentasClmAct.MinimumWidth = 8;
            this.VentasClmAct.Name = "VentasClmAct";
            this.VentasClmAct.Width = 150;
            // 
            // VentasBtnGuardar
            // 
            this.VentasBtnGuardar.AccessibleName = "Guardar pedido (prototipo visual)";
            this.VentasBtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VentasBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.VentasBtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VentasBtnGuardar.BackgroundImage")));
            this.VentasBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VentasBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VentasBtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(74)))));
            this.VentasBtnGuardar.FlatAppearance.BorderSize = 2;
            this.VentasBtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(74)))));
            this.VentasBtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(147)))));
            this.VentasBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnGuardar.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.VentasBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.VentasBtnGuardar.Location = new System.Drawing.Point(22, 225);
            this.VentasBtnGuardar.Name = "VentasBtnGuardar";
            this.VentasBtnGuardar.Size = new System.Drawing.Size(86, 84);
            this.VentasBtnGuardar.TabIndex = 17;
            this.VentasBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AccessibleName = "Cancelar pedido (prototipo visual)";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(212)))), ((int)(((byte)(234)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.button1.Location = new System.Drawing.Point(22, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 80);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(775, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Q";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(577, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Q";
            // 
            // FrmListadoPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VentasBtnGuardar);
            this.Controls.Add(this.VentasDgvLstCliente);
            this.Controls.Add(this.VentasLblLstCliente);
            this.Controls.Add(this.VentasTxtPreFinal);
            this.Controls.Add(this.VentaLblPreFinal);
            this.Controls.Add(this.VentasTxtPreBase);
            this.Controls.Add(this.VentaLblPreBase);
            this.Controls.Add(this.VentasLblPor);
            this.Controls.Add(this.VentasNudPorDescuento);
            this.Controls.Add(this.VentasLblPorDescuento);
            this.Controls.Add(this.VentasLblTipCliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VentasPnlEncabezado);
            this.Name = "FrmListadoPrecios";
            this.Text = "FrmListadoPrecios";
            this.Load += new System.EventHandler(this.FrmListadoPrecios_Load);
            this.VentasPnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasNudPorDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasDgvLstCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel VentasPnlEncabezado;
        private System.Windows.Forms.PictureBox VentasPbMarca;
        private System.Windows.Forms.Label VentasLblTitulo;
        private System.Windows.Forms.Label VentasLblSubtitulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label VentasLblTipCliente;
        private System.Windows.Forms.Label VentasLblPorDescuento;
        private System.Windows.Forms.NumericUpDown VentasNudPorDescuento;
        private System.Windows.Forms.Label VentasLblPor;
        private System.Windows.Forms.Label VentaLblPreBase;
        private System.Windows.Forms.TextBox VentasTxtPreBase;
        private System.Windows.Forms.Label VentaLblPreFinal;
        private System.Windows.Forms.TextBox VentasTxtPreFinal;
        private System.Windows.Forms.Label VentasLblLstCliente;
        private System.Windows.Forms.DataGridView VentasDgvLstCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasClmTipCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasClmPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasClmPreBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasClmPreFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasClmAct;
        private System.Windows.Forms.Button VentasBtnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}