using System;
using System.Windows.Forms;
using CapaControlador_Compras;

namespace CapaVista_Compras
{

    public partial class UsrCierreMovimientos : Componentes.UsrBaseCompras
    {
        private readonly CapaControlador_Compras.ClsCierreMovimientos _Controlador = new CapaControlador_Compras.ClsCierreMovimientos();

        public UsrCierreMovimientos()
        {
            InitializeComponent();
            ComprasProcConfigurarTablas();
            Load += ComprasMetCargar;
            _ComprasBtnValidar.Click += ComprasMetValidar;
            _ComprasBtnEjecutarCierre.Click += ComprasMetEjecutarCierre;
            _ComprasBtnImprimir.Click += ComprasMetImprimir;
            _ComprasBtnAyuda.Click += ComprasMetAyuda;
            _ComprasBtnSalir.Click += ComprasMetSalir;
        }

        private void ComprasProcConfigurarTablas()
        {
            ComprasProcAgregarColumna(ComprasUsrValidaciones, "cmp_estado", "Estado", 25, false);
            ComprasProcAgregarColumna(ComprasUsrValidaciones, "cmp_validacion", "Validación", 45, false);
            ComprasProcAgregarColumna(ComprasUsrValidaciones, "cmp_origen", "Origen", 30, false);

            ComprasProcAgregarColumna(ComprasUsrSaldos, "cmp_proveedor", "Proveedor", 32, false);
            ComprasProcAgregarColumna(ComprasUsrSaldos, "cmp_saldo_inicial", "Saldo inicial", 17, true);
            ComprasProcAgregarColumna(ComprasUsrSaldos, "cmp_total_cargos", "Cargos", 17, true);
            ComprasProcAgregarColumna(ComprasUsrSaldos, "cmp_total_abonos", "Abonos", 17, true);
            ComprasProcAgregarColumna(ComprasUsrSaldos, "cmp_saldo_final", "Saldo final", 17, true);
        }

        private void ComprasMetCargar(object Remitente, EventArgs Evento)
        {
            ComprasUsrPeriodo.DisplayMember = "cmp_descripcion";
            ComprasUsrPeriodo.ValueMember = "cmp_id_periodo";
            ComprasUsrPeriodo.DataSource = _Controlador.ComprasFuncObtenerPeriodosCerrables();

            _ComprasBtnEjecutarCierre.Enabled = false;
            _ComprasBtnImprimir.Enabled = false;
        }

        private void ComprasMetValidar(object Remitente, EventArgs Evento)
        {
            if (ComprasUsrPeriodo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el período a cerrar.", "Cierre de Movimientos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int IdPeriodo = Convert.ToInt32(ComprasUsrPeriodo.SelectedValue);
            ClsResumenCierre Resumen = _Controlador.ComprasFuncPrepararCierre(IdPeriodo);

            ComprasUsrValidaciones.DataSource = Resumen.Validaciones;
            ComprasUsrSaldos.DataSource = Resumen.SaldosProveedor;
            ComprasProcMostrarMonto(ComprasUsrTotalCargos, Resumen.TotalCargos);
            ComprasProcMostrarMonto(ComprasUsrTotalAbonos, Resumen.TotalAbonos);
            ComprasProcMostrarMonto(ComprasUsrSaldoFinal, Resumen.SaldoFinal);

            _ComprasBtnEjecutarCierre.Enabled = Resumen.PuedeCerrar;
            _ComprasBtnImprimir.Enabled = true;
        }

        private void ComprasMetEjecutarCierre(object Remitente, EventArgs Evento)
        {
            DialogResult Respuesta = MessageBox.Show(
                "El cierre es definitivo: los movimientos del período quedarán bloqueados.\n¿Desea continuar?",
                "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Respuesta != DialogResult.Yes) return;

            int IdPeriodo = Convert.ToInt32(ComprasUsrPeriodo.SelectedValue);
            string Mensaje = _Controlador.ComprasFuncEjecutarCierre(IdPeriodo);
            MessageBox.Show(Mensaje, "Cierre de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _ComprasBtnEjecutarCierre.Enabled = false;
        }

        private void ComprasMetImprimir(object Remitente, EventArgs Evento)
        {
            MessageBox.Show("El reporte de cierre se conectará con el componente Reporteador.",
                "Imprimir reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComprasMetAyuda(object Remitente, EventArgs Evento)
        {
            MessageBox.Show("La ayuda del módulo se integrará en la siguiente fase.",
                "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
}
}
