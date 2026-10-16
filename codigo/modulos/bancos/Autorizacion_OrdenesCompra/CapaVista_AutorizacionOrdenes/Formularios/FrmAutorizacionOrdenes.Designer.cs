namespace CapaVista_AutorizacionOrdenes.Formularios
{
    partial class FrmAutorizacionOrdenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutorizacionOrdenes));
            this.BancosPnlOrdenesPendientes = new System.Windows.Forms.Panel();
            this.BancosDgvOrdenesPendientes = new System.Windows.Forms.DataGridView();
            this.BancosColNumeroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosPnlDisponibilidadAsignacion = new System.Windows.Forms.Panel();
            this.BancosLblMotivoAsterisco = new System.Windows.Forms.Label();
            this.BancosTxtMotivoRechazo = new System.Windows.Forms.TextBox();
            this.BancosLblMotivoRechazo = new System.Windows.Forms.Label();
            this.BancosLblBancoAsterisco = new System.Windows.Forms.Label();
            this.BancosLblTipoCambioValor = new System.Windows.Forms.Label();
            this.BancosLblMonedaValor = new System.Windows.Forms.Label();
            this.BancosLblSaldoValor = new System.Windows.Forms.Label();
            this.BancosLblBanco = new System.Windows.Forms.Label();
            this.BancosLblSaldoDisponible = new System.Windows.Forms.Label();
            this.BancosLblMoneda = new System.Windows.Forms.Label();
            this.BancosLblTipoCambio = new System.Windows.Forms.Label();
            this.BancosLblMontoAsignado = new System.Windows.Forms.Label();
            this.BancosLblResultadoFondos = new System.Windows.Forms.Label();
            this.BancosTxtMontoAsignado = new System.Windows.Forms.TextBox();
            this.BancosCboBanco = new System.Windows.Forms.ComboBox();
            this.BancosLblDisponibilidadAsignacion = new System.Windows.Forms.Label();
            this.BancosLblOrdenesPendientes = new System.Windows.Forms.Label();
            this.BancosLblTitulo = new System.Windows.Forms.Label();
            this.BancosLblSubtitulo = new System.Windows.Forms.Label();
            this.BancosPnlEncabezado = new System.Windows.Forms.Panel();
            this.BancosPbMascota = new System.Windows.Forms.PictureBox();
            this.BancosPbLogo = new System.Windows.Forms.PictureBox();
            this.BancosBtnAyuda = new System.Windows.Forms.Button();
            this.BancosBtnRechazar = new System.Windows.Forms.Button();
            this.BancosBtnSalir = new System.Windows.Forms.Button();
            this.BancosBtnAutorizar = new System.Windows.Forms.Button();
            this.BancosBtnReporte = new System.Windows.Forms.Button();
            this.BancosPnlBotones = new System.Windows.Forms.Panel();
            this.BancosBtnLimpiar = new System.Windows.Forms.Button();
            this.BancosPnlOrdenesPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BancosDgvOrdenesPendientes)).BeginInit();
            this.BancosPnlDisponibilidadAsignacion.SuspendLayout();
            this.BancosPnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbLogo)).BeginInit();
            this.BancosPnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // BancosPnlOrdenesPendientes
            // 
            this.BancosPnlOrdenesPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.BancosPnlOrdenesPendientes.Controls.Add(this.BancosDgvOrdenesPendientes);
            this.BancosPnlOrdenesPendientes.Location = new System.Drawing.Point(31, 200);
            this.BancosPnlOrdenesPendientes.Name = "BancosPnlOrdenesPendientes";
            this.BancosPnlOrdenesPendientes.Size = new System.Drawing.Size(695, 530);
            this.BancosPnlOrdenesPendientes.TabIndex = 0;
            // 
            // BancosDgvOrdenesPendientes
            // 
            this.BancosDgvOrdenesPendientes.AllowUserToAddRows = false;
            this.BancosDgvOrdenesPendientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancosDgvOrdenesPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BancosDgvOrdenesPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BancosDgvOrdenesPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BancosDgvOrdenesPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BancosDgvOrdenesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BancosDgvOrdenesPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BancosColNumeroOrden,
            this.BancosColEmpresa,
            this.BancosColMonto,
            this.BancosColMoneda,
            this.BancosColEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BancosDgvOrdenesPendientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.BancosDgvOrdenesPendientes.EnableHeadersVisualStyles = false;
            this.BancosDgvOrdenesPendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosDgvOrdenesPendientes.Location = new System.Drawing.Point(18, 30);
            this.BancosDgvOrdenesPendientes.Name = "BancosDgvOrdenesPendientes";
            this.BancosDgvOrdenesPendientes.RowHeadersWidth = 51;
            this.BancosDgvOrdenesPendientes.RowTemplate.Height = 24;
            this.BancosDgvOrdenesPendientes.Size = new System.Drawing.Size(660, 482);
            this.BancosDgvOrdenesPendientes.TabIndex = 0;
            // 
            // BancosColNumeroOrden
            // 
            this.BancosColNumeroOrden.FillWeight = 120.3209F;
            this.BancosColNumeroOrden.HeaderText = "N.º de orden";
            this.BancosColNumeroOrden.MinimumWidth = 6;
            this.BancosColNumeroOrden.Name = "BancosColNumeroOrden";
            // 
            // BancosColEmpresa
            // 
            this.BancosColEmpresa.FillWeight = 94.91979F;
            this.BancosColEmpresa.HeaderText = "Empresa";
            this.BancosColEmpresa.MinimumWidth = 6;
            this.BancosColEmpresa.Name = "BancosColEmpresa";
            // 
            // BancosColMonto
            // 
            this.BancosColMonto.FillWeight = 94.91979F;
            this.BancosColMonto.HeaderText = "Monto";
            this.BancosColMonto.MinimumWidth = 6;
            this.BancosColMonto.Name = "BancosColMonto";
            // 
            // BancosColMoneda
            // 
            this.BancosColMoneda.FillWeight = 94.91979F;
            this.BancosColMoneda.HeaderText = "Moneda";
            this.BancosColMoneda.MinimumWidth = 6;
            this.BancosColMoneda.Name = "BancosColMoneda";
            // 
            // BancosColEstado
            // 
            this.BancosColEstado.FillWeight = 94.91979F;
            this.BancosColEstado.HeaderText = "Estado";
            this.BancosColEstado.MinimumWidth = 6;
            this.BancosColEstado.Name = "BancosColEstado";
            // 
            // BancosPnlDisponibilidadAsignacion
            // 
            this.BancosPnlDisponibilidadAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblMotivoAsterisco);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosTxtMotivoRechazo);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblMotivoRechazo);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblBancoAsterisco);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblTipoCambioValor);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblMonedaValor);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblSaldoValor);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblBanco);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblSaldoDisponible);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblMoneda);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblTipoCambio);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblMontoAsignado);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosLblResultadoFondos);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosTxtMontoAsignado);
            this.BancosPnlDisponibilidadAsignacion.Controls.Add(this.BancosCboBanco);
            this.BancosPnlDisponibilidadAsignacion.Location = new System.Drawing.Point(741, 200);
            this.BancosPnlDisponibilidadAsignacion.Name = "BancosPnlDisponibilidadAsignacion";
            this.BancosPnlDisponibilidadAsignacion.Size = new System.Drawing.Size(412, 530);
            this.BancosPnlDisponibilidadAsignacion.TabIndex = 1;
            // 
            // BancosLblMotivoAsterisco
            // 
            this.BancosLblMotivoAsterisco.AutoSize = true;
            this.BancosLblMotivoAsterisco.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMotivoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.BancosLblMotivoAsterisco.Location = new System.Drawing.Point(230, 365);
            this.BancosLblMotivoAsterisco.Name = "BancosLblMotivoAsterisco";
            this.BancosLblMotivoAsterisco.Size = new System.Drawing.Size(24, 27);
            this.BancosLblMotivoAsterisco.TabIndex = 15;
            this.BancosLblMotivoAsterisco.Text = "*";
            // 
            // BancosTxtMotivoRechazo
            // 
            this.BancosTxtMotivoRechazo.BackColor = System.Drawing.Color.White;
            this.BancosTxtMotivoRechazo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BancosTxtMotivoRechazo.Location = new System.Drawing.Point(29, 395);
            this.BancosTxtMotivoRechazo.Multiline = true;
            this.BancosTxtMotivoRechazo.Name = "BancosTxtMotivoRechazo";
            this.BancosTxtMotivoRechazo.Size = new System.Drawing.Size(350, 73);
            this.BancosTxtMotivoRechazo.TabIndex = 14;
            // 
            // BancosLblMotivoRechazo
            // 
            this.BancosLblMotivoRechazo.AutoSize = true;
            this.BancosLblMotivoRechazo.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMotivoRechazo.Location = new System.Drawing.Point(24, 365);
            this.BancosLblMotivoRechazo.Name = "BancosLblMotivoRechazo";
            this.BancosLblMotivoRechazo.Size = new System.Drawing.Size(190, 27);
            this.BancosLblMotivoRechazo.TabIndex = 13;
            this.BancosLblMotivoRechazo.Text = "Motivo de rechazo";
            // 
            // BancosLblBancoAsterisco
            // 
            this.BancosLblBancoAsterisco.AutoSize = true;
            this.BancosLblBancoAsterisco.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblBancoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.BancosLblBancoAsterisco.Location = new System.Drawing.Point(177, 27);
            this.BancosLblBancoAsterisco.Name = "BancosLblBancoAsterisco";
            this.BancosLblBancoAsterisco.Size = new System.Drawing.Size(24, 27);
            this.BancosLblBancoAsterisco.TabIndex = 11;
            this.BancosLblBancoAsterisco.Text = "*";
            // 
            // BancosLblTipoCambioValor
            // 
            this.BancosLblTipoCambioValor.AutoSize = true;
            this.BancosLblTipoCambioValor.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblTipoCambioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.BancosLblTipoCambioValor.Location = new System.Drawing.Point(278, 212);
            this.BancosLblTipoCambioValor.Name = "BancosLblTipoCambioValor";
            this.BancosLblTipoCambioValor.Size = new System.Drawing.Size(55, 27);
            this.BancosLblTipoCambioValor.TabIndex = 10;
            this.BancosLblTipoCambioValor.Text = "1.00";
            // 
            // BancosLblMonedaValor
            // 
            this.BancosLblMonedaValor.AutoSize = true;
            this.BancosLblMonedaValor.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMonedaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.BancosLblMonedaValor.Location = new System.Drawing.Point(278, 168);
            this.BancosLblMonedaValor.Name = "BancosLblMonedaValor";
            this.BancosLblMonedaValor.Size = new System.Drawing.Size(56, 27);
            this.BancosLblMonedaValor.TabIndex = 9;
            this.BancosLblMonedaValor.Text = "GTQ";
            // 
            // BancosLblSaldoValor
            // 
            this.BancosLblSaldoValor.AutoSize = true;
            this.BancosLblSaldoValor.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblSaldoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.BancosLblSaldoValor.Location = new System.Drawing.Point(278, 122);
            this.BancosLblSaldoValor.Name = "BancosLblSaldoValor";
            this.BancosLblSaldoValor.Size = new System.Drawing.Size(78, 27);
            this.BancosLblSaldoValor.TabIndex = 8;
            this.BancosLblSaldoValor.Text = "Q 0.00";
            // 
            // BancosLblBanco
            // 
            this.BancosLblBanco.AutoSize = true;
            this.BancosLblBanco.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblBanco.Location = new System.Drawing.Point(14, 27);
            this.BancosLblBanco.Name = "BancosLblBanco";
            this.BancosLblBanco.Size = new System.Drawing.Size(157, 27);
            this.BancosLblBanco.TabIndex = 7;
            this.BancosLblBanco.Text = "Banco de pago";
            // 
            // BancosLblSaldoDisponible
            // 
            this.BancosLblSaldoDisponible.AutoSize = true;
            this.BancosLblSaldoDisponible.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblSaldoDisponible.Location = new System.Drawing.Point(24, 122);
            this.BancosLblSaldoDisponible.Name = "BancosLblSaldoDisponible";
            this.BancosLblSaldoDisponible.Size = new System.Drawing.Size(177, 27);
            this.BancosLblSaldoDisponible.TabIndex = 6;
            this.BancosLblSaldoDisponible.Text = "Saldo disponible:";
            // 
            // BancosLblMoneda
            // 
            this.BancosLblMoneda.AutoSize = true;
            this.BancosLblMoneda.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMoneda.Location = new System.Drawing.Point(24, 168);
            this.BancosLblMoneda.Name = "BancosLblMoneda";
            this.BancosLblMoneda.Size = new System.Drawing.Size(97, 27);
            this.BancosLblMoneda.TabIndex = 5;
            this.BancosLblMoneda.Text = "Moneda:";
            // 
            // BancosLblTipoCambio
            // 
            this.BancosLblTipoCambio.AutoSize = true;
            this.BancosLblTipoCambio.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblTipoCambio.Location = new System.Drawing.Point(24, 212);
            this.BancosLblTipoCambio.Name = "BancosLblTipoCambio";
            this.BancosLblTipoCambio.Size = new System.Drawing.Size(169, 27);
            this.BancosLblTipoCambio.TabIndex = 4;
            this.BancosLblTipoCambio.Text = "Tipo de cambio:";
            // 
            // BancosLblMontoAsignado
            // 
            this.BancosLblMontoAsignado.AutoSize = true;
            this.BancosLblMontoAsignado.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMontoAsignado.Location = new System.Drawing.Point(24, 280);
            this.BancosLblMontoAsignado.Name = "BancosLblMontoAsignado";
            this.BancosLblMontoAsignado.Size = new System.Drawing.Size(173, 27);
            this.BancosLblMontoAsignado.TabIndex = 3;
            this.BancosLblMontoAsignado.Text = "\tMonto asignado ";
            // 
            // BancosLblResultadoFondos
            // 
            this.BancosLblResultadoFondos.AutoSize = true;
            this.BancosLblResultadoFondos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosLblResultadoFondos.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblResultadoFondos.Location = new System.Drawing.Point(24, 485);
            this.BancosLblResultadoFondos.Name = "BancosLblResultadoFondos";
            this.BancosLblResultadoFondos.Size = new System.Drawing.Size(301, 27);
            this.BancosLblResultadoFondos.TabIndex = 2;
            this.BancosLblResultadoFondos.Text = "Resultado: Fondos suficientes";
            // 
            // BancosTxtMontoAsignado
            // 
            this.BancosTxtMontoAsignado.BackColor = System.Drawing.Color.White;
            this.BancosTxtMontoAsignado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BancosTxtMontoAsignado.Location = new System.Drawing.Point(29, 310);
            this.BancosTxtMontoAsignado.Name = "BancosTxtMontoAsignado";
            this.BancosTxtMontoAsignado.Size = new System.Drawing.Size(354, 30);
            this.BancosTxtMontoAsignado.TabIndex = 1;
            // 
            // BancosCboBanco
            // 
            this.BancosCboBanco.BackColor = System.Drawing.Color.White;
            this.BancosCboBanco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BancosCboBanco.FormattingEnabled = true;
            this.BancosCboBanco.Location = new System.Drawing.Point(19, 57);
            this.BancosCboBanco.Name = "BancosCboBanco";
            this.BancosCboBanco.Size = new System.Drawing.Size(360, 31);
            this.BancosCboBanco.TabIndex = 0;
            // 
            // BancosLblDisponibilidadAsignacion
            // 
            this.BancosLblDisponibilidadAsignacion.AutoSize = true;
            this.BancosLblDisponibilidadAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
            this.BancosLblDisponibilidadAsignacion.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblDisponibilidadAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosLblDisponibilidadAsignacion.Location = new System.Drawing.Point(755, 183);
            this.BancosLblDisponibilidadAsignacion.Name = "BancosLblDisponibilidadAsignacion";
            this.BancosLblDisponibilidadAsignacion.Size = new System.Drawing.Size(359, 27);
            this.BancosLblDisponibilidadAsignacion.TabIndex = 8;
            this.BancosLblDisponibilidadAsignacion.Text = "Disponibilidad y asignación de pago";
            // 
            // BancosLblOrdenesPendientes
            // 
            this.BancosLblOrdenesPendientes.AutoSize = true;
            this.BancosLblOrdenesPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
            this.BancosLblOrdenesPendientes.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancosLblOrdenesPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosLblOrdenesPendientes.Location = new System.Drawing.Point(44, 183);
            this.BancosLblOrdenesPendientes.Name = "BancosLblOrdenesPendientes";
            this.BancosLblOrdenesPendientes.Size = new System.Drawing.Size(207, 27);
            this.BancosLblOrdenesPendientes.TabIndex = 9;
            this.BancosLblOrdenesPendientes.Text = "Órdenes pendientes";
            // 
            // BancosLblTitulo
            // 
            this.BancosLblTitulo.AutoSize = true;
            this.BancosLblTitulo.Font = new System.Drawing.Font("Lucida Fax", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancosLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.BancosLblTitulo.Location = new System.Drawing.Point(201, 26);
            this.BancosLblTitulo.Name = "BancosLblTitulo";
            this.BancosLblTitulo.Size = new System.Drawing.Size(650, 40);
            this.BancosLblTitulo.TabIndex = 10;
            this.BancosLblTitulo.Text = "Autorización de órdenes de compra";
            // 
            // BancosLblSubtitulo
            // 
            this.BancosLblSubtitulo.AutoSize = true;
            this.BancosLblSubtitulo.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancosLblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.BancosLblSubtitulo.Location = new System.Drawing.Point(203, 92);
            this.BancosLblSubtitulo.Name = "BancosLblSubtitulo";
            this.BancosLblSubtitulo.Size = new System.Drawing.Size(281, 27);
            this.BancosLblSubtitulo.TabIndex = 11;
            this.BancosLblSubtitulo.Text = "Área de Tesorería y Bancos";
            // 
            // BancosPnlEncabezado
            // 
            this.BancosPnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosPnlEncabezado.Controls.Add(this.BancosPbMascota);
            this.BancosPnlEncabezado.Controls.Add(this.BancosPbLogo);
            this.BancosPnlEncabezado.Controls.Add(this.BancosLblSubtitulo);
            this.BancosPnlEncabezado.Controls.Add(this.BancosLblTitulo);
            this.BancosPnlEncabezado.Location = new System.Drawing.Point(-2, -1);
            this.BancosPnlEncabezado.Name = "BancosPnlEncabezado";
            this.BancosPnlEncabezado.Size = new System.Drawing.Size(1336, 152);
            this.BancosPnlEncabezado.TabIndex = 14;
            // 
            // BancosPbMascota
            // 
            this.BancosPbMascota.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources._10;
            this.BancosPbMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosPbMascota.Location = new System.Drawing.Point(1202, -1);
            this.BancosPbMascota.Name = "BancosPbMascota";
            this.BancosPbMascota.Size = new System.Drawing.Size(131, 150);
            this.BancosPbMascota.TabIndex = 13;
            this.BancosPbMascota.TabStop = false;
            // 
            // BancosPbLogo
            // 
            this.BancosPbLogo.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.bancos_logo;
            this.BancosPbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosPbLogo.Location = new System.Drawing.Point(16, 3);
            this.BancosPbLogo.Name = "BancosPbLogo";
            this.BancosPbLogo.Size = new System.Drawing.Size(150, 150);
            this.BancosPbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BancosPbLogo.TabIndex = 12;
            this.BancosPbLogo.TabStop = false;
            // 
            // BancosBtnAyuda
            // 
            this.BancosBtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnAyuda.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_ayuda;
            this.BancosBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnAyuda.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnAyuda.Location = new System.Drawing.Point(28, 406);
            this.BancosBtnAyuda.Name = "BancosBtnAyuda";
            this.BancosBtnAyuda.Size = new System.Drawing.Size(80, 80);
            this.BancosBtnAyuda.TabIndex = 4;
            this.BancosBtnAyuda.UseVisualStyleBackColor = false;
            // 
            // BancosBtnRechazar
            // 
            this.BancosBtnRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnRechazar.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_rechazar;
            this.BancosBtnRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnRechazar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnRechazar.Location = new System.Drawing.Point(28, 107);
            this.BancosBtnRechazar.Name = "BancosBtnRechazar";
            this.BancosBtnRechazar.Size = new System.Drawing.Size(80, 80);
            this.BancosBtnRechazar.TabIndex = 1;
            this.BancosBtnRechazar.UseVisualStyleBackColor = false;
            // 
            // BancosBtnSalir
            // 
            this.BancosBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnSalir.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_salir;
            this.BancosBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnSalir.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnSalir.Location = new System.Drawing.Point(28, 505);
            this.BancosBtnSalir.Name = "BancosBtnSalir";
            this.BancosBtnSalir.Size = new System.Drawing.Size(80, 80);
            this.BancosBtnSalir.TabIndex = 2;
            this.BancosBtnSalir.UseVisualStyleBackColor = false;
            // 
            // BancosBtnAutorizar
            // 
            this.BancosBtnAutorizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnAutorizar.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_autorizar;
            this.BancosBtnAutorizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnAutorizar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnAutorizar.Location = new System.Drawing.Point(28, 9);
            this.BancosBtnAutorizar.Name = "BancosBtnAutorizar";
            this.BancosBtnAutorizar.Size = new System.Drawing.Size(80, 80);
            this.BancosBtnAutorizar.TabIndex = 0;
            this.BancosBtnAutorizar.UseVisualStyleBackColor = false;
            // 
            // BancosBtnReporte
            // 
            this.BancosBtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnReporte.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_reporteB;
            this.BancosBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnReporte.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnReporte.Location = new System.Drawing.Point(28, 205);
            this.BancosBtnReporte.Name = "BancosBtnReporte";
            this.BancosBtnReporte.Size = new System.Drawing.Size(80, 80);
            this.BancosBtnReporte.TabIndex = 3;
            this.BancosBtnReporte.UseVisualStyleBackColor = false;
            // 
            // BancosPnlBotones
            // 
            this.BancosPnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosPnlBotones.Controls.Add(this.BancosBtnLimpiar);
            this.BancosPnlBotones.Controls.Add(this.BancosBtnReporte);
            this.BancosPnlBotones.Controls.Add(this.BancosBtnAutorizar);
            this.BancosPnlBotones.Controls.Add(this.BancosBtnSalir);
            this.BancosPnlBotones.Controls.Add(this.BancosBtnRechazar);
            this.BancosPnlBotones.Controls.Add(this.BancosBtnAyuda);
            this.BancosPnlBotones.Location = new System.Drawing.Point(1197, 148);
            this.BancosPnlBotones.Name = "BancosPnlBotones";
            this.BancosPnlBotones.Size = new System.Drawing.Size(137, 610);
            this.BancosPnlBotones.TabIndex = 15;
            // 
            // BancosBtnLimpiar
            // 
            this.BancosBtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnLimpiar.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.btn_limpiarB;
            this.BancosBtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnLimpiar.Location = new System.Drawing.Point(28, 306);
            this.BancosBtnLimpiar.Name = "BancosBtnLimpiar";
            this.BancosBtnLimpiar.Size = new System.Drawing.Size(80, 80);
            this.BancosBtnLimpiar.TabIndex = 5;
            this.BancosBtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmAutorizacionOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.BackgroundImage = global::CapaVista_AutorizacionOrdenes.Properties.Resources.FondoAutorizacionModulo;
            this.ClientSize = new System.Drawing.Size(1330, 757);
            this.Controls.Add(this.BancosPnlBotones);
            this.Controls.Add(this.BancosPnlEncabezado);
            this.Controls.Add(this.BancosLblOrdenesPendientes);
            this.Controls.Add(this.BancosLblDisponibilidadAsignacion);
            this.Controls.Add(this.BancosPnlDisponibilidadAsignacion);
            this.Controls.Add(this.BancosPnlOrdenesPendientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutorizacionOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8003 – Autorización de órdenes de compra";
            this.Load += new System.EventHandler(this.FrmAutorizacionOrdenes_Load);
            this.BancosPnlOrdenesPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BancosDgvOrdenesPendientes)).EndInit();
            this.BancosPnlDisponibilidadAsignacion.ResumeLayout(false);
            this.BancosPnlDisponibilidadAsignacion.PerformLayout();
            this.BancosPnlEncabezado.ResumeLayout(false);
            this.BancosPnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbLogo)).EndInit();
            this.BancosPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BancosPnlOrdenesPendientes;
        private System.Windows.Forms.DataGridView BancosDgvOrdenesPendientes;
        private System.Windows.Forms.Panel BancosPnlDisponibilidadAsignacion;
        private System.Windows.Forms.Label BancosLblMontoAsignado;
        private System.Windows.Forms.Label BancosLblResultadoFondos;
        private System.Windows.Forms.TextBox BancosTxtMontoAsignado;
        private System.Windows.Forms.ComboBox BancosCboBanco;
        private System.Windows.Forms.Label BancosLblTipoCambioValor;
        private System.Windows.Forms.Label BancosLblMonedaValor;
        private System.Windows.Forms.Label BancosLblSaldoValor;
        private System.Windows.Forms.Label BancosLblBanco;
        private System.Windows.Forms.Label BancosLblSaldoDisponible;
        private System.Windows.Forms.Label BancosLblMoneda;
        private System.Windows.Forms.Label BancosLblTipoCambio;
        private System.Windows.Forms.Label BancosLblDisponibilidadAsignacion;
        private System.Windows.Forms.Label BancosLblOrdenesPendientes;
        private System.Windows.Forms.Label BancosLblTitulo;
        private System.Windows.Forms.Label BancosLblSubtitulo;
        private System.Windows.Forms.PictureBox BancosPbLogo;
        private System.Windows.Forms.Label BancosLblBancoAsterisco;
        private System.Windows.Forms.TextBox BancosTxtMotivoRechazo;
        private System.Windows.Forms.Label BancosLblMotivoRechazo;
        private System.Windows.Forms.Label BancosLblMotivoAsterisco;
        private System.Windows.Forms.Panel BancosPnlEncabezado;
        private System.Windows.Forms.Button BancosBtnAyuda;
        private System.Windows.Forms.Button BancosBtnRechazar;
        private System.Windows.Forms.Button BancosBtnSalir;
        private System.Windows.Forms.Button BancosBtnAutorizar;
        private System.Windows.Forms.Panel BancosPnlBotones;
        private System.Windows.Forms.PictureBox BancosPbMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColNumeroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColEstado;
        private System.Windows.Forms.Button BancosBtnReporte;
        private System.Windows.Forms.Button BancosBtnLimpiar;
    }
}