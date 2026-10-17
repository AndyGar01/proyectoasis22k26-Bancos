namespace CapaVista_AprobacionFinanciera
{
    partial class FrmAprobarOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras _ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel _ComprasPnlContenido;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAprobarOrden));
            this._ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this._ComprasPnlContenido = new System.Windows.Forms.Panel();
            this._ComprasBtnNoAprobar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this._ComprasBtnSiAprobar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasUsrComentario = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaComentario = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this._ComprasPnlDesplazamiento.SuspendLayout();
            this._ComprasPnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ComprasPnlDesplazamiento
            // 
            this._ComprasPnlDesplazamiento.AutoScroll = true;
            this._ComprasPnlDesplazamiento.Controls.Add(this._ComprasPnlContenido);
            this._ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ComprasPnlDesplazamiento.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlDesplazamiento.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlDesplazamiento.Name = "_ComprasPnlDesplazamiento";
            this._ComprasPnlDesplazamiento.Size = new System.Drawing.Size(1300, 700);
            this._ComprasPnlDesplazamiento.TabIndex = 0;
            // 
            // _ComprasPnlContenido
            // 
            this._ComprasPnlContenido.Controls.Add(this._ComprasBtnNoAprobar);
            this._ComprasPnlContenido.Controls.Add(this._ComprasBtnSiAprobar);
            this._ComprasPnlContenido.Controls.Add(this.ComprasUsrComentario);
            this._ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this._ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this._ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasPnlContenido.Name = "_ComprasPnlContenido";
            this._ComprasPnlContenido.Size = new System.Drawing.Size(1279, 723);
            this._ComprasPnlContenido.TabIndex = 0;
            // 
            // _ComprasBtnNoAprobar
            // 
            this._ComprasBtnNoAprobar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnNoAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnNoAprobar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ComprasBtnNoAprobar.BackgroundImage")));
            this._ComprasBtnNoAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnNoAprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnNoAprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnNoAprobar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnNoAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnNoAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnNoAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnNoAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnNoAprobar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnNoAprobar.Location = new System.Drawing.Point(619, 544);
            this._ComprasBtnNoAprobar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnNoAprobar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnNoAprobar.MinimumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnNoAprobar.Name = "_ComprasBtnNoAprobar";
            this._ComprasBtnNoAprobar.Size = new System.Drawing.Size(80, 80);
            this._ComprasBtnNoAprobar.TabIndex = 10;
            this._ComprasBtnNoAprobar.UseVisualStyleBackColor = false;
            // 
            // _ComprasBtnSiAprobar
            // 
            this._ComprasBtnSiAprobar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnSiAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnSiAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnSiAprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnSiAprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSiAprobar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnSiAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnSiAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnSiAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnSiAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComprasBtnSiAprobar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSiAprobar.Location = new System.Drawing.Point(410, 560);
            this._ComprasBtnSiAprobar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnSiAprobar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnSiAprobar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnSiAprobar.Name = "_ComprasBtnSiAprobar";
            this._ComprasBtnSiAprobar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnSiAprobar.TabIndex = 9;
            this._ComprasBtnSiAprobar.Text = "Aprobar";
            this._ComprasBtnSiAprobar.UseVisualStyleBackColor = false;
            // 
            // ComprasUsrComentario
            // 
            this.ComprasUsrComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrComentario.Location = new System.Drawing.Point(31, 21);
            this.ComprasUsrComentario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrComentario.MaxLength = 2147483647;
            this.ComprasUsrComentario.Name = "ComprasUsrComentario";
            this.ComprasUsrComentario.SelectedText = "";
            this.ComprasUsrComentario.SelectionLength = 0;
            this.ComprasUsrComentario.SelectionStart = 0;
            this.ComprasUsrComentario.Size = new System.Drawing.Size(1196, 495);
            this.ComprasUsrComentario.TabIndex = 8;
            // 
            // ComprasUsrEtiquetaComentario
            // 
            this.ComprasUsrEtiquetaComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaComentario.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaComentario.Location = new System.Drawing.Point(13, 14);
            this.ComprasUsrEtiquetaComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComprasUsrEtiquetaComentario.MaximumSize = new System.Drawing.Size(1167, 21);
            this.ComprasUsrEtiquetaComentario.Name = "ComprasUsrEtiquetaComentario";
            this.ComprasUsrEtiquetaComentario.Size = new System.Drawing.Size(116, 21);
            this.ComprasUsrEtiquetaComentario.TabIndex = 7;
            this.ComprasUsrEtiquetaComentario.TabStop = false;
            this.ComprasUsrEtiquetaComentario.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaComentario.Text = "Comentario";
            this.ComprasUsrEtiquetaComentario.Texto = "Comentario";
            // 
            // FrmAprobarOrden
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this._ComprasPnlDesplazamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAprobarOrden";
            this.Text = "6007 – Aprobar orden";
            this._ComprasPnlDesplazamiento.ResumeLayout(false);
            this._ComprasPnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnNoAprobar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras _ComprasBtnSiAprobar;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrComentario;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaComentario;
    }
}