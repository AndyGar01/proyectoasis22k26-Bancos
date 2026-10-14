/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Validar los campos del login y gestionar el ciclo de acceso, splash, MDI y cierre de sesión.
 */
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Ventas;

namespace CapaVista_Ventas
{
    public partial class FrmLoginVentas : Form
    {
        private readonly ClsAutenticacionVentas _Autenticacion;
        private bool _Validando;

        public FrmLoginVentas()
        {
            InitializeComponent();
            _Autenticacion = new ClsAutenticacionVentas();
        }

        // Permite verificar el flujo de ventanas con un controlador de prueba sin consultar la base de datos.
        public FrmLoginVentas(ClsAutenticacionVentas Autenticacion) : this()
        { _Autenticacion = Autenticacion ?? throw new ArgumentNullException(nameof(Autenticacion)); }

        private async void VentasBtnLogin_Click(object sender, EventArgs e)
        {
            if (_Validando) return;
            VentasErrCampos.Clear();
            VentasLblEstado.Text = string.Empty;
            string Usuario = VentasTxtUsuario.Text.Trim();
            string Contrasena = VentasTxtContrasena.Text;
            // Señala el campo obligatorio y devuelve el foco antes de llamar al controlador.
            if (string.IsNullOrWhiteSpace(Usuario))
            { VentasErrCampos.SetError(VentasTxtUsuario, "Ingrese su usuario."); VentasTxtUsuario.Focus(); return; }
            if (string.IsNullOrEmpty(Contrasena))
            { VentasErrCampos.SetError(VentasTxtContrasena, "Ingrese su contraseña."); VentasTxtContrasena.Focus(); return; }

            VentasMetEstadoValidacion(true);
            try
            {
                // La consulta se ejecuta en segundo plano para que el login siga repintándose.
                bool Autorizado;
                try
                {
                    Autorizado = await Task.Run(() => _Autenticacion.VentasMetIniciarSesion(Usuario, Contrasena));
                }
                catch (Exception)
                {
                    VentasTxtContrasena.Clear();
                    VentasLblEstado.Text = "No se pudo validar el acceso. Revise la conexión ODBC de Seguridad.";
                    return;
                }
                if (!Autorizado)
                {
                    VentasTxtContrasena.Clear();
                    VentasLblEstado.Text = "Usuario o contraseña incorrectos, o usuario inactivo.";
                    return;
                }

                // Después de autenticar: login -> splash -> MDI -> login.
                Hide();
                try
                {
                    using (var Carga = new FrmSplashVentas(_Autenticacion.NombreUsuario, _Autenticacion.RolUsuario))
                        Carga.ShowDialog(this);
                }
                finally
                {
                    _Autenticacion.VentasMetCerrarSesion();
                    VentasTxtContrasena.Clear();
                    VentasChkMostrarContrasena.Checked = false;
                    VentasLblEstado.Text = string.Empty;
                    Show();
                    Activate();
                }
            }
            finally
            {
                // Habilita un nuevo intento sólo después de actualizar el resultado y limpiar los campos.
                VentasMetEstadoValidacion(false);
                VentasTxtContrasena.Focus();
            }
        }

        // Deshabilita un segundo intento mientras se consulta la autenticación.
        private void VentasMetEstadoValidacion(bool Validando)
        {
            if (Validando) _Validando = true;
            VentasTxtUsuario.Enabled = !Validando;
            VentasTxtContrasena.Enabled = !Validando;
            VentasChkMostrarContrasena.Enabled = !Validando;
            VentasLnkRecuperarContrasena.Enabled = !Validando;
            VentasBtnLogin.Enabled = !Validando;
            VentasBtnLogin.Text = Validando ? "VALIDANDO…" : "LOGIN";
            UseWaitCursor = Validando;
            // La bandera se libera al final para impedir reentradas durante los cambios de controles.
            if (!Validando) _Validando = false;
        }

        private void VentasChkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        { VentasTxtContrasena.UseSystemPasswordChar = !VentasChkMostrarContrasena.Checked; }

        private void VentasLnkRecuperarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // La recuperación permanece a cargo de Seguridad; este módulo no modifica credenciales.
            MessageBox.Show(this, "Solicite la recuperación de su contraseña desde el módulo de Seguridad o con su administrador.",
                "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLoginVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Espera a que termine la validación para no dejar una sesión creada después de cerrar la ventana.
            if (_Validando) { e.Cancel = true; return; }
            _Autenticacion.VentasMetCerrarSesion();
        }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
