/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Conectar el login de Ventas con el controlador de autenticación existente de Seguridad.
 */
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace CapaControlador_Ventas
{
    public class ClsAutenticacionVentas
    {
        public string NombreUsuario { get; protected set; }
        public string RolUsuario { get; protected set; }

        // Reutiliza la validación de usuario, contraseña BCrypt, estado y roles de Seguridad.
        // La Vista no consulta SQL ni guarda contraseñas; utiliza el DSN ya configurado en el Modelo.
        public virtual bool VentasMetIniciarSesion(string Usuario, string Contrasena)
        {
            VentasMetCerrarSesion();
            try
            {
                var UsuarioSeguridad = new ClsModeloUsuario();
                if (!UsuarioSeguridad.SeguridadMetIniciarSesion(Usuario, Contrasena)) return false;
                NombreUsuario = string.IsNullOrWhiteSpace(ClsSesionSeguridad.NombreEmpleado)
                    ? ClsSesionSeguridad.NombreUsuario : ClsSesionSeguridad.NombreEmpleado;
                RolUsuario = ClsSesionSeguridad.SeguridadMetRolesComoTexto();
                return true;
            }
            catch
            {
                // Si falla la consulta o la bitácora, descarta cualquier sesión parcial.
                VentasMetCerrarSesion();
                throw;
            }
        }

        // Limpia los datos compartidos cuando termina el MDI o se cierra la aplicación.
        public virtual void VentasMetCerrarSesion()
        {
            ClsSesionSeguridad.SeguridadMetCerrarSesion();
            NombreUsuario = null;
            RolUsuario = null;
        }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
