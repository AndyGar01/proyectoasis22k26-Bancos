/*
 * ==================================================================
 * Área : Contabilidad
 * Autor : Gabriel André Guillén Pocón
 * Carné : 0901-23-1998
 * Fecha : 14/10/2026
 * ==================================================================
 * Propósito :
 *  Valida las credenciales del inicio de sesión de Contabilidad: busca
 *  el usuario activo, verifica la contraseña contra su hash BCrypt y,
 *  si coincide, carga el usuario y sus roles en la sesión del módulo.
 * Reglas especificas:
 *  Ante usuario inexistente o contraseña incorrecta devuelve false sin
 *  distinguir el motivo; los errores de base de datos se propagan.
 * ===================================================================
*/

using System;
using System.Collections.Generic;
using System.Data;
using CapaModelo_Contabilidad.Repositorios;

namespace CapaControlador_Contabilidad
{
    // Controlador del inicio de sesión.
    public class ClsControladorLoginContabilidad
    {
        // Repositorio de usuarios.
        private readonly ClsRepositorioUsuariosContabilidad _Repositorio = new ClsRepositorioUsuariosContabilidad();

        // Valida usuario y contraseña y abre la sesión.
        public bool ContabilidadFuncIniciarSesion(string NombreUsuario, string Contrasena)
        {
            // Sin datos no hay sesión.
            if (string.IsNullOrWhiteSpace(NombreUsuario) || string.IsNullOrEmpty(Contrasena)) return false;

            // Busca el usuario activo.
            DataTable Usuario = _Repositorio.ContabilidadFuncObtenerUsuario(NombreUsuario.Trim());
            if (Usuario.Rows.Count == 0) return false;

            DataRow Fila = Usuario.Rows[0];
            // Compara la contraseña con su hash.
            if (!BCrypt.Net.BCrypt.Verify(Contrasena, Convert.ToString(Fila["contrasenaUsuario"]))) return false;

            int IdUsuario = Convert.ToInt32(Fila["idUsuario"]);
            // Carga los roles del usuario.
            Dictionary<int, string> Roles = new Dictionary<int, string>();
            foreach (DataRow FilaRol in _Repositorio.ContabilidadFuncObtenerRoles(IdUsuario).Rows)
                Roles[Convert.ToInt32(FilaRol["idRol"])] = Convert.ToString(FilaRol["nombreRol"]);

            // Guarda la sesión.
            ClsSesionContabilidad.ContabilidadMetIniciarSesion(IdUsuario,
                Convert.ToString(Fila["nombreUsuario"]), Convert.ToString(Fila["nombreEmpleado"]), Roles);
            return true;
        }

        // Cierra la sesión.
        public void ContabilidadMetCerrarSesion()
        {
            ClsSesionContabilidad.ContabilidadMetCerrarSesion();
        }
    }
}
