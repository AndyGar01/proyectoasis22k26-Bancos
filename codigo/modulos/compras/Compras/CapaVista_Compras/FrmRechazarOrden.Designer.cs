namespace CapaVista_Compras
{
    partial class FrmRechazarOrden
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
            this.ComprasUsrEtiquetaComentario = new CapaVista_Compras.Componentes.UsrLabelCompras();
            this.ComprasUsrComentario = new CapaVista_Compras.Componentes.UsrTextBoxCompras();
            this._ComprasBtnSiRechazar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this._ComprasBtnNoRechazar = new CapaVista_Compras.Componentes.ClsButtonCompras();
            this.SuspendLayout();
            //
            // ComprasLblComentario
            //
            this.ComprasUsrEtiquetaComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaComentario.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaComentario.Location = new System.Drawing.Point(11, 11);
            this.ComprasUsrEtiquetaComentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComprasUsrEtiquetaComentario.MaximumSize = new System.Drawing.Size(875, 17);
            this.ComprasUsrEtiquetaComentario.Name = "ComprasUsrEtiquetaComentario";
            this.ComprasUsrEtiquetaComentario.Size = new System.Drawing.Size(87, 17);
            this.ComprasUsrEtiquetaComentario.TabIndex = 0;
            this.ComprasUsrEtiquetaComentario.TabStop = false;
            this.ComprasUsrEtiquetaComentario.Text = "Comentario";
            this.ComprasUsrEtiquetaComentario.Texto = "Comentario";
            //
            // ComprasTxtComentario
            //
            this.ComprasUsrComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrComentario.Location = new System.Drawing.Point(100, 9);
            this.ComprasUsrComentario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrComentario.MaxLength = 2147483647;
            this.ComprasUsrComentario.Name = "ComprasUsrComentario";
            this.ComprasUsrComentario.SelectedText = "";
            this.ComprasUsrComentario.SelectionLength = 0;
            this.ComprasUsrComentario.SelectionStart = 0;
            this.ComprasUsrComentario.Size = new System.Drawing.Size(286, 142);
            this.ComprasUsrComentario.TabIndex = 1;
            //
            // ComprasBtnSiRechazar
            //
            this._ComprasBtnSiRechazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnSiRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnSiRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnSiRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnSiRechazar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSiRechazar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnSiRechazar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnSiRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnSiRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnSiRechazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnSiRechazar.Location = new System.Drawing.Point(132, 151);
            this._ComprasBtnSiRechazar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnSiRechazar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnSiRechazar.MinimumSize = new System.Drawing.Size(80, 20);
            this._ComprasBtnSiRechazar.Name = "ComprasBtnSiRechazar";
            this._ComprasBtnSiRechazar.Size = new System.Drawing.Size(80, 40);
            this._ComprasBtnSiRechazar.TabIndex = 5;
            this._ComprasBtnSiRechazar.Text = "Rechazar";
            this._ComprasBtnSiRechazar.UseVisualStyleBackColor = false;
            //
            // ComprasBtnNoRechazar
            //
            this._ComprasBtnNoRechazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._ComprasBtnNoRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this._ComprasBtnNoRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._ComprasBtnNoRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ComprasBtnNoRechazar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnNoRechazar.FlatAppearance.BorderSize = 0;
            this._ComprasBtnNoRechazar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this._ComprasBtnNoRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this._ComprasBtnNoRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ComprasBtnNoRechazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this._ComprasBtnNoRechazar.Location = new System.Drawing.Point(274, 151);
            this._ComprasBtnNoRechazar.Margin = new System.Windows.Forms.Padding(0);
            this._ComprasBtnNoRechazar.MaximumSize = new System.Drawing.Size(80, 80);
            this._ComprasBtnNoRechazar.MinimumSize = new System.Drawing.Size(80, 20);
            this._ComprasBtnNoRechazar.Name = "ComprasBtnNoRechazar";
            this._ComprasBtnNoRechazar.Size = new System.Drawing.Size(80, 40);
            this._ComprasBtnNoRechazar.TabIndex = 6;
            this._ComprasBtnNoRechazar.Text = "Cancelar";
            this._ComprasBtnNoRechazar.UseVisualStyleBackColor = false;
            //
            // FrmRechazarOrden
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 200);
            this.Controls.Add(this._ComprasBtnNoRechazar);
            this.Controls.Add(this._ComprasBtnSiRechazar);
            this.Controls.Add(this.ComprasUsrComentario);
            this.Controls.Add(this.ComprasUsrComentario);
            this.Name = "FrmRechazarOrden";
            this.Text = "FrmRechazarOrden";
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.UsrLabelCompras ComprasUsrEtiquetaComentario;
        private Componentes.UsrTextBoxCompras ComprasUsrComentario;
        private Componentes.ClsButtonCompras _ComprasBtnSiRechazar;
        private Componentes.ClsButtonCompras _ComprasBtnNoRechazar;
    }
}