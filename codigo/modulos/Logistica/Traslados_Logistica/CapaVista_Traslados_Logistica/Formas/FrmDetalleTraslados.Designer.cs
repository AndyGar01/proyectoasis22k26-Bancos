namespace CapaVista_Traslados_Logistica.Formas
{
    partial class FrmDetalleTraslados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleTraslados));
            this.LogisticaPnlDetalleTraslados = new System.Windows.Forms.Panel();
            this.LogisticaDgvDetalleTraslados = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogisticaPnlDatosTraslados = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LogisticaLblFechaRecibido = new System.Windows.Forms.Label();
            this.LogisticaLblFechaSalida = new System.Windows.Forms.Label();
            this.LogisticaTxtEstadoTraslado = new System.Windows.Forms.TextBox();
            this.LogisticaLblEstadoTraslado = new System.Windows.Forms.Label();
            this.LogisticaLblCodigoTransporte = new System.Windows.Forms.Label();
            this.LogisticaTxtCodigoTraslado = new System.Windows.Forms.TextBox();
            this.LogisticaLblCodigoTraslado = new System.Windows.Forms.Label();
            this.LogisticaLblBodegaDestino = new System.Windows.Forms.Label();
            this.LogisticaLblBodegaOrigen = new System.Windows.Forms.Label();
            this.LogisticaPnlEncabezadoDetalleTraslado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogisticaPbMascota = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LogisticaTxtCodigoTransporte = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LogisticaPnlDetalleTraslados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogisticaDgvDetalleTraslados)).BeginInit();
            this.LogisticaPnlDatosTraslados.SuspendLayout();
            this.LogisticaPnlEncabezadoDetalleTraslado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogisticaPbMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // LogisticaPnlDetalleTraslados
            // 
            this.LogisticaPnlDetalleTraslados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.LogisticaPnlDetalleTraslados.Controls.Add(this.LogisticaDgvDetalleTraslados);
            this.LogisticaPnlDetalleTraslados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogisticaPnlDetalleTraslados.Location = new System.Drawing.Point(0, 434);
            this.LogisticaPnlDetalleTraslados.Margin = new System.Windows.Forms.Padding(2);
            this.LogisticaPnlDetalleTraslados.Name = "LogisticaPnlDetalleTraslados";
            this.LogisticaPnlDetalleTraslados.Size = new System.Drawing.Size(1154, 252);
            this.LogisticaPnlDetalleTraslados.TabIndex = 5;
            // 
            // LogisticaDgvDetalleTraslados
            // 
            this.LogisticaDgvDetalleTraslados.AllowUserToAddRows = false;
            this.LogisticaDgvDetalleTraslados.AllowUserToDeleteRows = false;
            this.LogisticaDgvDetalleTraslados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LogisticaDgvDetalleTraslados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogisticaDgvDetalleTraslados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.nombreProducto,
            this.descripcionProducto,
            this.cantidadProducto,
            this.pesoUnidad,
            this.pesoProducto,
            this.precioProductoUnidad,
            this.precioProductoTotal});
            this.LogisticaDgvDetalleTraslados.Location = new System.Drawing.Point(3, 3);
            this.LogisticaDgvDetalleTraslados.Name = "LogisticaDgvDetalleTraslados";
            this.LogisticaDgvDetalleTraslados.ReadOnly = true;
            this.LogisticaDgvDetalleTraslados.RowHeadersWidth = 51;
            this.LogisticaDgvDetalleTraslados.RowTemplate.Height = 24;
            this.LogisticaDgvDetalleTraslados.Size = new System.Drawing.Size(1148, 246);
            this.LogisticaDgvDetalleTraslados.TabIndex = 0;
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Codigo Producto";
            this.codigoProducto.MinimumWidth = 6;
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre Producto";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.HeaderText = "Descripcion Producto";
            this.descripcionProducto.MinimumWidth = 6;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad Total";
            this.cantidadProducto.MinimumWidth = 6;
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            // 
            // pesoUnidad
            // 
            this.pesoUnidad.HeaderText = "Peso Unidad";
            this.pesoUnidad.MinimumWidth = 6;
            this.pesoUnidad.Name = "pesoUnidad";
            this.pesoUnidad.ReadOnly = true;
            // 
            // pesoProducto
            // 
            this.pesoProducto.HeaderText = "Peso Total";
            this.pesoProducto.MinimumWidth = 6;
            this.pesoProducto.Name = "pesoProducto";
            this.pesoProducto.ReadOnly = true;
            // 
            // precioProductoUnidad
            // 
            this.precioProductoUnidad.HeaderText = "Precio Unidad";
            this.precioProductoUnidad.MinimumWidth = 6;
            this.precioProductoUnidad.Name = "precioProductoUnidad";
            this.precioProductoUnidad.ReadOnly = true;
            // 
            // precioProductoTotal
            // 
            this.precioProductoTotal.HeaderText = "Precio Total";
            this.precioProductoTotal.MinimumWidth = 6;
            this.precioProductoTotal.Name = "precioProductoTotal";
            this.precioProductoTotal.ReadOnly = true;
            // 
            // LogisticaPnlDatosTraslados
            // 
            this.LogisticaPnlDatosTraslados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.LogisticaPnlDatosTraslados.Controls.Add(this.textBox5);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.textBox4);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaTxtCodigoTransporte);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.textBox3);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.textBox2);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.textBox1);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.label3);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaLblFechaRecibido);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaLblFechaSalida);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaTxtEstadoTraslado);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaLblEstadoTraslado);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaLblCodigoTransporte);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaTxtCodigoTraslado);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaLblCodigoTraslado);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaLblBodegaDestino);
            this.LogisticaPnlDatosTraslados.Controls.Add(this.LogisticaLblBodegaOrigen);
            this.LogisticaPnlDatosTraslados.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogisticaPnlDatosTraslados.Location = new System.Drawing.Point(0, 181);
            this.LogisticaPnlDatosTraslados.Margin = new System.Windows.Forms.Padding(2);
            this.LogisticaPnlDatosTraslados.Name = "LogisticaPnlDatosTraslados";
            this.LogisticaPnlDatosTraslados.Size = new System.Drawing.Size(1154, 253);
            this.LogisticaPnlDatosTraslados.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(28, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha Recibido:";
            // 
            // LogisticaLblFechaRecibido
            // 
            this.LogisticaLblFechaRecibido.AutoSize = true;
            this.LogisticaLblFechaRecibido.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaLblFechaRecibido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblFechaRecibido.Location = new System.Drawing.Point(608, 133);
            this.LogisticaLblFechaRecibido.Name = "LogisticaLblFechaRecibido";
            this.LogisticaLblFechaRecibido.Size = new System.Drawing.Size(142, 27);
            this.LogisticaLblFechaRecibido.TabIndex = 23;
            this.LogisticaLblFechaRecibido.Text = "Fecha Salida:";
            // 
            // LogisticaLblFechaSalida
            // 
            this.LogisticaLblFechaSalida.AutoSize = true;
            this.LogisticaLblFechaSalida.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaLblFechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblFechaSalida.Location = new System.Drawing.Point(26, 133);
            this.LogisticaLblFechaSalida.Name = "LogisticaLblFechaSalida";
            this.LogisticaLblFechaSalida.Size = new System.Drawing.Size(164, 27);
            this.LogisticaLblFechaSalida.TabIndex = 22;
            this.LogisticaLblFechaSalida.Text = "Fecha Solicitud:";
            // 
            // LogisticaTxtEstadoTraslado
            // 
            this.LogisticaTxtEstadoTraslado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogisticaTxtEstadoTraslado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaTxtEstadoTraslado.Location = new System.Drawing.Point(819, 6);
            this.LogisticaTxtEstadoTraslado.Name = "LogisticaTxtEstadoTraslado";
            this.LogisticaTxtEstadoTraslado.Size = new System.Drawing.Size(300, 38);
            this.LogisticaTxtEstadoTraslado.TabIndex = 21;
            // 
            // LogisticaLblEstadoTraslado
            // 
            this.LogisticaLblEstadoTraslado.AutoSize = true;
            this.LogisticaLblEstadoTraslado.Font = new System.Drawing.Font("Tahoma", 13.2F);
            this.LogisticaLblEstadoTraslado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblEstadoTraslado.Location = new System.Drawing.Point(608, 11);
            this.LogisticaLblEstadoTraslado.Name = "LogisticaLblEstadoTraslado";
            this.LogisticaLblEstadoTraslado.Size = new System.Drawing.Size(176, 27);
            this.LogisticaLblEstadoTraslado.TabIndex = 20;
            this.LogisticaLblEstadoTraslado.Text = "Estado Traslado:";
            // 
            // LogisticaLblCodigoTransporte
            // 
            this.LogisticaLblCodigoTransporte.AutoSize = true;
            this.LogisticaLblCodigoTransporte.Font = new System.Drawing.Font("Tahoma", 13.2F);
            this.LogisticaLblCodigoTransporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblCodigoTransporte.Location = new System.Drawing.Point(608, 193);
            this.LogisticaLblCodigoTransporte.Name = "LogisticaLblCodigoTransporte";
            this.LogisticaLblCodigoTransporte.Size = new System.Drawing.Size(199, 27);
            this.LogisticaLblCodigoTransporte.TabIndex = 18;
            this.LogisticaLblCodigoTransporte.Text = "Código Transporte:";
            // 
            // LogisticaTxtCodigoTraslado
            // 
            this.LogisticaTxtCodigoTraslado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogisticaTxtCodigoTraslado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaTxtCodigoTraslado.Location = new System.Drawing.Point(223, 6);
            this.LogisticaTxtCodigoTraslado.Name = "LogisticaTxtCodigoTraslado";
            this.LogisticaTxtCodigoTraslado.Size = new System.Drawing.Size(300, 38);
            this.LogisticaTxtCodigoTraslado.TabIndex = 17;
            // 
            // LogisticaLblCodigoTraslado
            // 
            this.LogisticaLblCodigoTraslado.AutoSize = true;
            this.LogisticaLblCodigoTraslado.Font = new System.Drawing.Font("Tahoma", 13.2F);
            this.LogisticaLblCodigoTraslado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblCodigoTraslado.Location = new System.Drawing.Point(28, 11);
            this.LogisticaLblCodigoTraslado.Name = "LogisticaLblCodigoTraslado";
            this.LogisticaLblCodigoTraslado.Size = new System.Drawing.Size(177, 27);
            this.LogisticaLblCodigoTraslado.TabIndex = 16;
            this.LogisticaLblCodigoTraslado.Text = "Código Traslado:";
            // 
            // LogisticaLblBodegaDestino
            // 
            this.LogisticaLblBodegaDestino.AutoSize = true;
            this.LogisticaLblBodegaDestino.Font = new System.Drawing.Font("Tahoma", 13.2F);
            this.LogisticaLblBodegaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblBodegaDestino.Location = new System.Drawing.Point(608, 72);
            this.LogisticaLblBodegaDestino.Name = "LogisticaLblBodegaDestino";
            this.LogisticaLblBodegaDestino.Size = new System.Drawing.Size(173, 27);
            this.LogisticaLblBodegaDestino.TabIndex = 9;
            this.LogisticaLblBodegaDestino.Text = "Bodega Destino:";
            // 
            // LogisticaLblBodegaOrigen
            // 
            this.LogisticaLblBodegaOrigen.AutoSize = true;
            this.LogisticaLblBodegaOrigen.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaLblBodegaOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.LogisticaLblBodegaOrigen.Location = new System.Drawing.Point(26, 72);
            this.LogisticaLblBodegaOrigen.Name = "LogisticaLblBodegaOrigen";
            this.LogisticaLblBodegaOrigen.Size = new System.Drawing.Size(165, 27);
            this.LogisticaLblBodegaOrigen.TabIndex = 8;
            this.LogisticaLblBodegaOrigen.Text = "Bodega Origen:";
            // 
            // LogisticaPnlEncabezadoDetalleTraslado
            // 
            this.LogisticaPnlEncabezadoDetalleTraslado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.LogisticaPnlEncabezadoDetalleTraslado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogisticaPnlEncabezadoDetalleTraslado.Controls.Add(this.label2);
            this.LogisticaPnlEncabezadoDetalleTraslado.Controls.Add(this.label1);
            this.LogisticaPnlEncabezadoDetalleTraslado.Controls.Add(this.LogisticaPbMascota);
            this.LogisticaPnlEncabezadoDetalleTraslado.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogisticaPnlEncabezadoDetalleTraslado.Location = new System.Drawing.Point(0, 0);
            this.LogisticaPnlEncabezadoDetalleTraslado.Margin = new System.Windows.Forms.Padding(2);
            this.LogisticaPnlEncabezadoDetalleTraslado.Name = "LogisticaPnlEncabezadoDetalleTraslado";
            this.LogisticaPnlEncabezadoDetalleTraslado.Size = new System.Drawing.Size(1154, 181);
            this.LogisticaPnlEncabezadoDetalleTraslado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(135, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Llegamos a Nuestro Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(77, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "DETALLE TRASLADOS";
            // 
            // LogisticaPbMascota
            // 
            this.LogisticaPbMascota.Location = new System.Drawing.Point(658, 15);
            this.LogisticaPbMascota.Name = "LogisticaPbMascota";
            this.LogisticaPbMascota.Size = new System.Drawing.Size(202, 153);
            this.LogisticaPbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogisticaPbMascota.TabIndex = 1;
            this.LogisticaPbMascota.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(223, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 38);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(223, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 38);
            this.textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(223, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 38);
            this.textBox3.TabIndex = 31;
            // 
            // LogisticaTxtCodigoTransporte
            // 
            this.LogisticaTxtCodigoTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogisticaTxtCodigoTransporte.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticaTxtCodigoTransporte.Location = new System.Drawing.Point(819, 72);
            this.LogisticaTxtCodigoTransporte.Name = "LogisticaTxtCodigoTransporte";
            this.LogisticaTxtCodigoTransporte.Size = new System.Drawing.Size(300, 38);
            this.LogisticaTxtCodigoTransporte.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(819, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 38);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(819, 193);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 38);
            this.textBox5.TabIndex = 34;
            // 
            // FrmDetalleTraslados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1154, 686);
            this.Controls.Add(this.LogisticaPnlDetalleTraslados);
            this.Controls.Add(this.LogisticaPnlDatosTraslados);
            this.Controls.Add(this.LogisticaPnlEncabezadoDetalleTraslado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDetalleTraslados";
            this.Text = "xxxx - FrmDetalleTraslados";
            this.LogisticaPnlDetalleTraslados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogisticaDgvDetalleTraslados)).EndInit();
            this.LogisticaPnlDatosTraslados.ResumeLayout(false);
            this.LogisticaPnlDatosTraslados.PerformLayout();
            this.LogisticaPnlEncabezadoDetalleTraslado.ResumeLayout(false);
            this.LogisticaPnlEncabezadoDetalleTraslado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogisticaPbMascota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogisticaPnlDetalleTraslados;
        private System.Windows.Forms.DataGridView LogisticaDgvDetalleTraslados;
        private System.Windows.Forms.Panel LogisticaPnlDatosTraslados;
        private System.Windows.Forms.Panel LogisticaPnlEncabezadoDetalleTraslado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogisticaPbMascota;
        private System.Windows.Forms.Label LogisticaLblBodegaDestino;
        private System.Windows.Forms.Label LogisticaLblBodegaOrigen;
        private System.Windows.Forms.Label LogisticaLblCodigoTransporte;
        private System.Windows.Forms.TextBox LogisticaTxtCodigoTraslado;
        private System.Windows.Forms.Label LogisticaLblCodigoTraslado;
        private System.Windows.Forms.TextBox LogisticaTxtEstadoTraslado;
        private System.Windows.Forms.Label LogisticaLblEstadoTraslado;
        private System.Windows.Forms.Label LogisticaLblFechaRecibido;
        private System.Windows.Forms.Label LogisticaLblFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox LogisticaTxtCodigoTransporte;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}