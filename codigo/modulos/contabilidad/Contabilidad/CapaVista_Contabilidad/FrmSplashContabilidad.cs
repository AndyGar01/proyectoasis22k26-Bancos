/*
 * Área : Contabilidad
 * Autor : Gabriel André Guillén Pocón
 * Carné : 0901-23-1998
 * Fecha : 14/10/2026
 * Propósito : Mostrar el progreso de carga, abrir el MDI y cerrar la sesión al regresar.
 */

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaVista_Contabilidad
{
    // Pantalla de carga.
    public partial class FrmSplashContabilidad : Form
    {
        // Permite colorear la barra de progreso.
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr Ventana, string NombreAplicacion, string ListaIdentificadores);

        // Porcentaje de avance.
        private int _Progreso;

        // Prepara la pantalla e inicia la carga.
        public FrmSplashContabilidad()
        {
            InitializeComponent();
            ContabilidadMetAplicarColorBarra();
            ContabilidadMetIniciarCarga();
        }

        // Pinta la barra de progreso.
        private void ContabilidadMetAplicarColorBarra()
        {
            SetWindowTheme(ContabilidadPgbCarga.Handle, "", "");
            ContabilidadPgbCarga.ForeColor = Color.FromArgb(197, 143, 62);
        }

        // Inicia el temporizador.
        private void ContabilidadMetIniciarCarga()
        {
            _Progreso = 0;
            _TimerCarga.Start();
        }

        // Avanza la barra y abre el MDI al terminar.
        private void ContabilidadMetActualizarCarga(object Remitente, EventArgs Evento)
        {
            _Progreso += 1;
            if (_Progreso < 100) ContabilidadPgbCarga.Value = _Progreso + 1;
            ContabilidadPgbCarga.Value = _Progreso;
            ContabilidadLblPorcentaje.Text = _Progreso + "%";

            if (_Progreso >= 100)
            {
                _TimerCarga.Stop();
                Hide();
                using (FrmMDIContabilidad Principal = new FrmMDIContabilidad())
                {
                    Principal.ShowDialog();
                }
                new CapaControlador_Contabilidad.ClsControladorLoginContabilidad().ContabilidadMetCerrarSesion();
                Close();
            }
        }
    }
}
