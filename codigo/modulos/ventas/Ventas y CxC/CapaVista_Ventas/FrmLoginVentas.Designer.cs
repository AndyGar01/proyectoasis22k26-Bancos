/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Definir el login con controles de la caja de herramientas y la paleta de Ventas.
 */
namespace CapaVista_Ventas
{
    partial class FrmLoginVentas
    {
        private System.ComponentModel.IContainer components = null;

        // Libera imágenes y componentes de herramientas cuando termina el formulario.
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VentasPnlAcceso = new System.Windows.Forms.Panel();
            this.VentasPbMascotaLogin = new System.Windows.Forms.PictureBox();
            this.VentasPbLogoLogin = new System.Windows.Forms.PictureBox();
            this.VentasLblInicioSesion = new System.Windows.Forms.Label();
            this.VentasPnlUsuario = new System.Windows.Forms.Panel();
            this.VentasTxtUsuario = new System.Windows.Forms.TextBox();
            this.VentasLblUsuarioLogin = new System.Windows.Forms.Label();
            this.VentasPnlContrasena = new System.Windows.Forms.Panel();
            this.VentasTxtContrasena = new System.Windows.Forms.TextBox();
            this.VentasLblContrasena = new System.Windows.Forms.Label();
            this.VentasChkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.VentasBtnLogin = new System.Windows.Forms.Button();
            this.VentasLnkRecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.VentasLblEstado = new System.Windows.Forms.Label();
            this.VentasErrCampos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VentasErrCampos)).BeginInit();
            this.VentasPnlAcceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMascotaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbLogoLogin)).BeginInit();
            this.VentasPnlUsuario.SuspendLayout();
            this.VentasPnlContrasena.SuspendLayout();
            this.SuspendLayout();
            // VentasPnlAcceso — Contenedor del diseñador.
            this.VentasPnlAcceso.Name = "VentasPnlAcceso";
            this.VentasPnlAcceso.TabIndex = 0;
            // VentasPbMascotaLogin — Imagen independiente del texto.
            this.VentasPbMascotaLogin.Name = "VentasPbMascotaLogin";
            this.VentasPbMascotaLogin.TabIndex = 1;
            // VentasPbLogoLogin — Imagen independiente del texto.
            this.VentasPbLogoLogin.Name = "VentasPbLogoLogin";
            this.VentasPbLogoLogin.TabIndex = 2;
            // VentasLblInicioSesion — Información para el usuario.
            this.VentasLblInicioSesion.Name = "VentasLblInicioSesion";
            this.VentasLblInicioSesion.TabIndex = 3;
            this.VentasLblInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblInicioSesion.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblInicioSesion.Font = new System.Drawing.Font("Tahoma", 9F);
            // VentasPnlUsuario — Contenedor del diseñador.
            this.VentasPnlUsuario.Name = "VentasPnlUsuario";
            this.VentasPnlUsuario.TabIndex = 4;
            // VentasTxtUsuario — Campo de captura.
            this.VentasTxtUsuario.Name = "VentasTxtUsuario";
            this.VentasTxtUsuario.TabIndex = 5;
            // VentasLblUsuarioLogin — Información para el usuario.
            this.VentasLblUsuarioLogin.Name = "VentasLblUsuarioLogin";
            this.VentasLblUsuarioLogin.TabIndex = 6;
            this.VentasLblUsuarioLogin.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblUsuarioLogin.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblUsuarioLogin.Font = new System.Drawing.Font("Tahoma", 9F);
            // VentasPnlContrasena — Contenedor del diseñador.
            this.VentasPnlContrasena.Name = "VentasPnlContrasena";
            this.VentasPnlContrasena.TabIndex = 7;
            // VentasTxtContrasena — Campo de captura.
            this.VentasTxtContrasena.Name = "VentasTxtContrasena";
            this.VentasTxtContrasena.TabIndex = 8;
            // VentasLblContrasena — Información para el usuario.
            this.VentasLblContrasena.Name = "VentasLblContrasena";
            this.VentasLblContrasena.TabIndex = 9;
            this.VentasLblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblContrasena.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblContrasena.Font = new System.Drawing.Font("Tahoma", 9F);
            // VentasChkMostrarContrasena — Visibilidad de contraseña.
            this.VentasChkMostrarContrasena.Name = "VentasChkMostrarContrasena";
            this.VentasChkMostrarContrasena.TabIndex = 10;
            this.VentasChkMostrarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.VentasChkMostrarContrasena.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasChkMostrarContrasena.Font = new System.Drawing.Font("Tahoma", 9F);
            // VentasBtnLogin — Acción de autenticación.
            this.VentasBtnLogin.Name = "VentasBtnLogin";
            this.VentasBtnLogin.TabIndex = 11;
            // VentasLnkRecuperarContrasena — Acceso a ayuda de recuperación.
            this.VentasLnkRecuperarContrasena.Name = "VentasLnkRecuperarContrasena";
            this.VentasLnkRecuperarContrasena.TabIndex = 12;
            this.VentasLnkRecuperarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.VentasLnkRecuperarContrasena.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLnkRecuperarContrasena.Font = new System.Drawing.Font("Tahoma", 9F);
            // VentasLblEstado — Información para el usuario.
            this.VentasLblEstado.Name = "VentasLblEstado";
            this.VentasLblEstado.TabIndex = 13;
            this.VentasLblEstado.BackColor = System.Drawing.Color.Transparent;
            this.VentasLblEstado.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasLblEstado.Font = new System.Drawing.Font("Tahoma", 9F);
            this.VentasPnlAcceso.Location = new System.Drawing.Point(525, 96);
            this.VentasPnlAcceso.Size = new System.Drawing.Size(351, 495);
            this.VentasPnlAcceso.BackColor = System.Drawing.Color.FromArgb(248, 245, 249);
            this.VentasPnlAcceso.Controls.Add(this.VentasPbMascotaLogin);
            this.VentasPnlAcceso.Controls.Add(this.VentasLblInicioSesion);
            this.VentasPnlAcceso.Controls.Add(this.VentasPnlUsuario);
            this.VentasPnlAcceso.Controls.Add(this.VentasLblUsuarioLogin);
            this.VentasPnlAcceso.Controls.Add(this.VentasPnlContrasena);
            this.VentasPnlAcceso.Controls.Add(this.VentasLblContrasena);
            this.VentasPnlAcceso.Controls.Add(this.VentasChkMostrarContrasena);
            this.VentasPnlAcceso.Controls.Add(this.VentasBtnLogin);
            this.VentasPnlAcceso.Controls.Add(this.VentasLnkRecuperarContrasena);
            this.VentasPnlAcceso.Controls.Add(this.VentasLblEstado);
            this.VentasPbLogoLogin.Location = new System.Drawing.Point(77, 82);
            this.VentasPbLogoLogin.Size = new System.Drawing.Size(225, 222);
            this.VentasPbLogoLogin.Image = global::CapaVista_Ventas.Properties.Resources.LogoEmpresa;
            this.VentasPbLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasPbLogoLogin.BackColor = System.Drawing.Color.Transparent;
            this.VentasPbLogoLogin.TabStop = false;
            this.VentasPbMascotaLogin.Location = new System.Drawing.Point(121, 25);
            this.VentasPbMascotaLogin.Size = new System.Drawing.Size(116, 129);
            this.VentasPbMascotaLogin.Image = global::CapaVista_Ventas.Properties.Resources.MascotaLoginVentas;
            this.VentasPbMascotaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VentasPbMascotaLogin.BackColor = System.Drawing.Color.Transparent;
            this.VentasPbMascotaLogin.TabStop = false;
            this.VentasLblInicioSesion.Location = new System.Drawing.Point(30, 172);
            this.VentasLblInicioSesion.Size = new System.Drawing.Size(291, 30);
            this.VentasLblInicioSesion.Text = "INICIAR SESIÓN";
            this.VentasLblInicioSesion.Font = new System.Drawing.Font("Lucida Fax", 13F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.VentasLblInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasPnlUsuario.Location = new System.Drawing.Point(43, 224);
            this.VentasPnlUsuario.Size = new System.Drawing.Size(275, 32);
            this.VentasPnlUsuario.BackColor = System.Drawing.Color.FromArgb(228, 212, 234);
            this.VentasPnlUsuario.Controls.Add(this.VentasTxtUsuario);
            this.VentasTxtUsuario.Location = new System.Drawing.Point(5, 5);
            this.VentasTxtUsuario.Size = new System.Drawing.Size(265, 22);
            this.VentasTxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VentasTxtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.VentasTxtUsuario.BackColor = System.Drawing.Color.FromArgb(248, 245, 249);
            this.VentasTxtUsuario.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasTxtUsuario.MaxLength = 100;
            this.VentasTxtUsuario.TabIndex = 0;
            this.VentasTxtUsuario.AccessibleName = "Usuario";
            this.VentasLblUsuarioLogin.Location = new System.Drawing.Point(55, 260);
            this.VentasLblUsuarioLogin.Size = new System.Drawing.Size(170, 23);
            this.VentasLblUsuarioLogin.Text = "Usuario";
            this.VentasLblUsuarioLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasPnlContrasena.Location = new System.Drawing.Point(43, 290);
            this.VentasPnlContrasena.Size = new System.Drawing.Size(275, 32);
            this.VentasPnlContrasena.BackColor = System.Drawing.Color.FromArgb(228, 212, 234);
            this.VentasPnlContrasena.Controls.Add(this.VentasTxtContrasena);
            this.VentasTxtContrasena.Location = new System.Drawing.Point(5, 5);
            this.VentasTxtContrasena.Size = new System.Drawing.Size(265, 22);
            this.VentasTxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VentasTxtContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.VentasTxtContrasena.BackColor = System.Drawing.Color.FromArgb(248, 245, 249);
            this.VentasTxtContrasena.ForeColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasTxtContrasena.MaxLength = 100;
            this.VentasTxtContrasena.TabIndex = 1;
            this.VentasTxtContrasena.AccessibleName = "Contraseña";
            this.VentasLblContrasena.Location = new System.Drawing.Point(55, 326);
            this.VentasLblContrasena.Size = new System.Drawing.Size(170, 23);
            this.VentasLblContrasena.Text = "Contraseña";
            this.VentasLblContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasTxtContrasena.UseSystemPasswordChar = true;
            this.VentasChkMostrarContrasena.Location = new System.Drawing.Point(236, 326);
            this.VentasChkMostrarContrasena.Size = new System.Drawing.Size(90, 25);
            this.VentasChkMostrarContrasena.Text = "Mostrar";
            this.VentasChkMostrarContrasena.TabIndex = 2;
            this.VentasChkMostrarContrasena.CheckedChanged += new System.EventHandler(this.VentasChkMostrarContrasena_CheckedChanged);
            this.VentasBtnLogin.Location = new System.Drawing.Point(117, 366);
            this.VentasBtnLogin.Size = new System.Drawing.Size(120, 36);
            this.VentasBtnLogin.Text = "LOGIN";
            this.VentasBtnLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VentasBtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(201, 162, 74);
            this.VentasBtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(123, 63, 147);
            this.VentasBtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasBtnLogin.BackColor = System.Drawing.Color.FromArgb(59, 29, 74);
            this.VentasBtnLogin.ForeColor = System.Drawing.Color.FromArgb(248, 245, 249);
            this.VentasBtnLogin.UseVisualStyleBackColor = false;
            this.VentasBtnLogin.TabIndex = 3;
            this.VentasBtnLogin.Click += new System.EventHandler(this.VentasBtnLogin_Click);
            this.VentasLnkRecuperarContrasena.Location = new System.Drawing.Point(43, 414);
            this.VentasLnkRecuperarContrasena.Size = new System.Drawing.Size(275, 25);
            this.VentasLnkRecuperarContrasena.Text = "¿Olvidaste tu contraseña?";
            this.VentasLnkRecuperarContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasLnkRecuperarContrasena.LinkColor = System.Drawing.Color.FromArgb(123, 63, 147);
            this.VentasLnkRecuperarContrasena.ActiveLinkColor = System.Drawing.Color.FromArgb(201, 162, 74);
            this.VentasLnkRecuperarContrasena.TabIndex = 4;
            this.VentasLnkRecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VentasLnkRecuperarContrasena_LinkClicked);
            this.VentasLblEstado.Location = new System.Drawing.Point(20, 447);
            this.VentasLblEstado.Size = new System.Drawing.Size(311, 40);
            this.VentasLblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VentasLblEstado.ForeColor = System.Drawing.Color.FromArgb(123, 63, 147);
            this.VentasErrCampos.ContainerControl = this;
            this.VentasErrCampos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.VentasPnlUsuario.TabIndex = 0;
            this.VentasPnlContrasena.TabIndex = 1;
            this.VentasPnlAcceso.TabIndex = 0;
            this.AcceptButton = this.VentasBtnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::CapaVista_Ventas.Properties.Resources.FondoLoginVentas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackColor = System.Drawing.Color.FromArgb(248, 245, 249);
            this.ClientSize = new System.Drawing.Size(916, 646);
            this.Controls.Add(this.VentasPnlAcceso);
            this.Controls.Add(this.VentasPbLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::CapaVista_Ventas.Properties.Resources.IconoVentas;
            this.MaximizeBox = false;
            this.Name = "FrmLoginVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2000 - Login de Ventas y cuentas por cobrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLoginVentas_FormClosing);
            this.VentasPnlAcceso.ResumeLayout(false);
            this.VentasPnlAcceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbMascotaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPbLogoLogin)).EndInit();
            this.VentasPnlUsuario.ResumeLayout(false);
            this.VentasPnlUsuario.PerformLayout();
            this.VentasPnlContrasena.ResumeLayout(false);
            this.VentasPnlContrasena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasErrCampos)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel VentasPnlAcceso;
        private System.Windows.Forms.PictureBox VentasPbMascotaLogin;
        private System.Windows.Forms.PictureBox VentasPbLogoLogin;
        private System.Windows.Forms.Label VentasLblInicioSesion;
        private System.Windows.Forms.Panel VentasPnlUsuario;
        private System.Windows.Forms.TextBox VentasTxtUsuario;
        private System.Windows.Forms.Label VentasLblUsuarioLogin;
        private System.Windows.Forms.Panel VentasPnlContrasena;
        private System.Windows.Forms.TextBox VentasTxtContrasena;
        private System.Windows.Forms.Label VentasLblContrasena;
        private System.Windows.Forms.CheckBox VentasChkMostrarContrasena;
        private System.Windows.Forms.Button VentasBtnLogin;
        private System.Windows.Forms.LinkLabel VentasLnkRecuperarContrasena;
        private System.Windows.Forms.Label VentasLblEstado;
        private System.Windows.Forms.ErrorProvider VentasErrCampos;
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
