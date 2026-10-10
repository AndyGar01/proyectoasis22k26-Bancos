/*
 * INICIO DEL CÓDIGO — Jose Torres
 * Carné: 0901-23-1091 | Fecha: 10/10/2026
 * Área: Ventas y cuentas por cobrar
 * Propósito: Iniciar el ejecutable de Ventas desde el login estandarizado.
 */
using System;
using System.Windows.Forms;

namespace Ejecutable_Ventas
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            // El login es la ventana principal de la aplicación; autentica antes de mostrar splash y MDI.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CapaVista_Ventas.FrmLoginVentas());
        }
    }
}

// FIN DEL CÓDIGO — Jose Torres | Carné: 0901-23-1091 | Fecha: 10/10/2026
