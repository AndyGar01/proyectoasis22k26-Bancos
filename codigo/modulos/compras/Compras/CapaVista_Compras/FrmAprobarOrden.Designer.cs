namespace CapaVista_Compras
{
    partial class FrmAprobarOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;

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
            this._ComprasBtnNoAprobar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnSiAprobar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this.ComprasUsrComentario = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaComentario = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.SuspendLayout();
            //
            // ComprasBtnNoAprobar
            //
            this._ComprasBtnNoAprobar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnNoAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnNoAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnNoAprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnNoAprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnNoAprobar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnNoAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnNoAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnNoAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnNoAprobar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnNoAprobar.Location = new System.Drawing.Point(364, 186);
            this._ComprasBtnNoAprobar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnNoAprobar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnNoAprobar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnNoAprobar.Name = "ComprasBtnNoAprobar";
            this._ComprasBtnNoAprobar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnNoAprobar.TabIndex = 10;
            this._ComprasBtnNoAprobar.Text = "Cancelar";
            this._ComprasBtnNoAprobar.UseVisualStyleBackColor = false;
            //
            // ComprasBtnSiAprobar
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
            this._ComprasBtnSiAprobar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSiAprobar.Location = new System.Drawing.Point(175, 186);
            this._ComprasBtnSiAprobar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnSiAprobar.MaximumSize = new System.Drawing.Size(107, 98);
            this._ComprasBtnSiAprobar.MinimumSize = new System.Drawing.Size(107, 25);
            this._ComprasBtnSiAprobar.Name = "ComprasBtnSiAprobar";
            this._ComprasBtnSiAprobar.Size = new System.Drawing.Size(107, 49);
            this._ComprasBtnSiAprobar.TabIndex = 9;
            this._ComprasBtnSiAprobar.Text = "Aprobar";
            this._ComprasBtnSiAprobar.UseVisualStyleBackColor = false;
            //
            // ComprasTxtComentario
            //
            this.ComprasUsrComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrComentario.Location = new System.Drawing.Point(132, 11);
            this.ComprasUsrComentario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrComentario.MaxLength = 2147483647;
            this.ComprasUsrComentario.Name = "ComprasUsrComentario";
            this.ComprasUsrComentario.SelectedText = "";
            this.ComprasUsrComentario.SelectionLength = 0;
            this.ComprasUsrComentario.SelectionStart = 0;
            this.ComprasUsrComentario.Size = new System.Drawing.Size(381, 175);
            this.ComprasUsrComentario.TabIndex = 8;
            //
            // ComprasLblComentario
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 246);
            this.Controls.Add(this._ComprasBtnNoAprobar);
            this.Controls.Add(this._ComprasBtnSiAprobar);
            this.Controls.Add(this.ComprasUsrComentario);
            this.Controls.Add(this.ComprasUsrComentario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAprobarOrden";
            this.Text = "FrmAprobarOrden";
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.ClsButtonCompras _ComprasBtnNoAprobar;
        private Componentes.ClsButtonCompras _ComprasBtnSiAprobar;
        private Componentes.UsrTextBoxCompras ComprasUsrComentario;
        private Componentes.UsrLabelCompras ComprasUsrEtiquetaComentario;
    }
}