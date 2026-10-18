/*
 * Área: Contabilidad
 * Autor: Gabriel André Guillén Pocón
 * Carné: 0901-23-1998
 * Fecha: 10/10/2026
 * Propósito: resultado de presentación de la sesión y el acceso al menú.
 */
using System.Collections.Generic;

namespace CapaControlador_Contabilidad
{
    // Datos de la sesión y los accesos para el MDI.
    public sealed class ClsEstadoSeguridadContabilidad
    {
        // Indica si hay sesión.
        public bool HaySesion { get; internal set; }
        // Nombre que se muestra.
        public string NombreUsuario { get; internal set; }
        // Roles como texto.
        public string Roles { get; internal set; }
        // Aviso para el usuario.
        public string Mensaje { get; internal set; }
        // Módulo de cada código de ventana.
        public Dictionary<int, int> Modulos { get; } = new Dictionary<int, int>();
        // Aplicación de cada código de ventana.
        public Dictionary<int, int> Aplicaciones { get; } = new Dictionary<int, int>();
        // Acceso de cada código de ventana.
        public Dictionary<int, bool> Accesos { get; } = new Dictionary<int, bool>
        {
            { 10001, false }, { 10002, false }, { 10003, false },
            { 10004, false }, { 10005, false }
        };
    }
}
