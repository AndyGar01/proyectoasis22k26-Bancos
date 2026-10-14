/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 13/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Autenticar Ventas mediante la DLL local del controlador de Seguridad.
 */
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace CapaControlador_Ventas
{
    public class ClsAutenticacionVentas
    {
        public string NombreUsuario { get; protected set; }
        public string RolUsuario { get; protected set; }

        // Delega usuario, contraseña y roles al controlador existente, referenciado como DLL.
        // La Vista utiliza este controlador y no consulta directamente la base de datos.
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
                VentasMetCerrarSesion();
                throw;
            }
        }

        // Cierra la sesión compartida y limpia los datos de Ventas al terminar el MDI.
        public virtual void VentasMetCerrarSesion()
        {
            ClsSesionSeguridad.SeguridadMetCerrarSesion();
            NombreUsuario = null;
            RolUsuario = null;
        }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 13/10/2026
