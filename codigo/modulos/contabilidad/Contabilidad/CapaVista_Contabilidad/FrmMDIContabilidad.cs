/*
 * ==================================================================
 * Área : Contabilidad
 * Autor : Gabriel André Guillén Pocón
 * Carné : 0901-23-1998
 * Fecha : 22/10/2026
 * ==================================================================
 * Propósito :
 *  MDI del prototipo no funcional de Contabilidad. Solo diseño: los botones
 *  del menú abren las cinco pantallas y no hacen nada más.
 * ===================================================================
*/

using System;
using System.Windows.Forms;

namespace CapaVista_Contabilidad
{
    // Ventana principal del módulo.
    public partial class FrmMDIContabilidad : Form
    {
        // Crea los controles del diseño.
        public FrmMDIContabilidad()
        {
            InitializeComponent();
        }

        // Abre Pólizas locales.
        private void ContabilidadMetAbrirPolizasLocales(object Remitente, EventArgs Evento)
        {
            using (FrmPolizasLocales Formulario = new FrmPolizasLocales())
            {
                Formulario.ShowDialog(this);
            }
        }

        // Abre Presupuestos.
        private void ContabilidadMetAbrirPresupuestos(object Remitente, EventArgs Evento)
        {
            using (FrmPresupuestos Formulario = new FrmPresupuestos())
            {
                Formulario.ShowDialog(this);
            }
        }

        // Abre Activos fijos.
        private void ContabilidadMetAbrirActivosFijos(object Remitente, EventArgs Evento)
        {
            using (FrmActivosFijos Formulario = new FrmActivosFijos())
            {
                Formulario.ShowDialog(this);
            }
        }

        // Abre Cierre contable.
        private void ContabilidadMetAbrirCierreContable(object Remitente, EventArgs Evento)
        {
            using (FrmCierreContable Formulario = new FrmCierreContable())
            {
                Formulario.ShowDialog(this);
            }
        }

        // Abre Estados financieros.
        private void ContabilidadMetAbrirEstadosFinancieros(object Remitente, EventArgs Evento)
        {
            using (FrmEstadosFinancieros Formulario = new FrmEstadosFinancieros())
            {
                Formulario.ShowDialog(this);
            }
        }
    }
}
