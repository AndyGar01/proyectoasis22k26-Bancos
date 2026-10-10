/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Transportar el identificador de la opción elegida hacia el controlador.
 */
using System;

namespace CapaVista_Ventas
{
    public sealed class ClsOpcionVentasEventArgs : EventArgs
    {
        public string Opcion { get; private set; }
        public ClsOpcionVentasEventArgs(string Nombre) { Opcion = Nombre; }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
