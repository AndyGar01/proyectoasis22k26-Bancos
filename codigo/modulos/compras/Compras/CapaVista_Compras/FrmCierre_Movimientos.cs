using System;
using System.Windows.Forms;
using CapaControlador_Compras;

namespace CapaVista_Compras
{
    // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "11/10/26"
    // Formulario 3.8 Cierre de Movimientos (prototipo).
    // El formulario solo captura y muestra datos; toda validación y cálculo vive en ClsCierreMovimientos.
    
    public partial class FrmCierre_Movimientos : Form
    {
        private readonly ClsCierreMovimientos _Controlador = new ClsCierreMovimientos();

        public FrmCierre_Movimientos()
        {
            InitializeComponent();
            ComprasProcConfigurarTablas();
            Load += ComprasMetCargar;
            ComprasBtnValidar.Click += ComprasMetValidar;
            ComprasBtnEjecutarCierre.Click += ComprasMetEjecutarCierre;
            ComprasBtnImprimir.Click += ComprasMetImprimir;
            ComprasBtnAyuda.Click += ComprasMetAyuda;
            ComprasBtnSalir.Click += (Remitente, Evento) => Close();
        }

        private void ComprasProcConfigurarTablas()
        {
            ComprasDgvValidaciones.AutoGenerateColumns = false;
            ComprasProcAgregarColumna(ComprasDgvValidaciones, "cmp_estado", "Estado", 25, false);
            ComprasProcAgregarColumna(ComprasDgvValidaciones, "cmp_validacion", "Validación", 45, false);
            ComprasProcAgregarColumna(ComprasDgvValidaciones, "cmp_origen", "Origen", 30, false);

            ComprasDgvSaldos.AutoGenerateColumns = false;
            ComprasProcAgregarColumna(ComprasDgvSaldos, "cmp_proveedor", "Proveedor", 32, false);
            ComprasProcAgregarColumna(ComprasDgvSaldos, "cmp_saldo_inicial", "Saldo inicial", 17, true);
            ComprasProcAgregarColumna(ComprasDgvSaldos, "cmp_total_cargos", "Cargos", 17, true);
            ComprasProcAgregarColumna(ComprasDgvSaldos, "cmp_total_abonos", "Abonos", 17, true);
            ComprasProcAgregarColumna(ComprasDgvSaldos, "cmp_saldo_final", "Saldo final", 17, true);
        }

        private void ComprasProcAgregarColumna(Componentes.UsrDataGridViewCompras Tabla, string Campo,
            string Encabezado, int Peso, bool EsMonto)
        {
            DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn
            {
                Name = "ComprasCol" + Campo,
                DataPropertyName = Campo,
                HeaderText = Encabezado,
                FillWeight = Peso
            };

            if (EsMonto)
            {
                Columna.DefaultCellStyle.Format = "N2";
                Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            Tabla.Columns.Add(Columna);
        }

        private void ComprasMetCargar(object Remitente, EventArgs Evento)
        {
            ComprasCboPeriodo.DisplayMember = "cmp_descripcion";
            ComprasCboPeriodo.ValueMember = "cmp_id_periodo";
            ComprasCboPeriodo.DataSource = _Controlador.ComprasFuncObtenerPeriodosCerrables();

            ComprasBtnEjecutarCierre.Enabled = false;
            ComprasBtnImprimir.Enabled = false;
        }

        private void ComprasMetValidar(object Remitente, EventArgs Evento)
        {
            if (ComprasCboPeriodo.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el período a cerrar.", "Cierre de Movimientos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int IdPeriodo = Convert.ToInt32(ComprasCboPeriodo.SelectedValue);
            ClsResumenCierre Resumen = _Controlador.ComprasFuncPrepararCierre(IdPeriodo);

            ComprasDgvValidaciones.DataSource = Resumen.Validaciones;
            ComprasDgvSaldos.DataSource = Resumen.SaldosProveedor;
            ComprasTxtTotalCargos.Text = Resumen.TotalCargos.ToString("N2");
            ComprasTxtTotalAbonos.Text = Resumen.TotalAbonos.ToString("N2");
            ComprasTxtSaldoFinal.Text = Resumen.SaldoFinal.ToString("N2");

            ComprasBtnEjecutarCierre.Enabled = Resumen.PuedeCerrar;
            ComprasBtnImprimir.Enabled = true;

            ComprasTxtTotalAbonos.Entrada.SelectAll();
            ComprasTxtTotalAbonos.Entrada.SelectionAlignment = HorizontalAlignment.Right;

            ComprasTxtTotalCargos.Entrada.SelectAll();
            ComprasTxtTotalCargos.Entrada.SelectionAlignment = HorizontalAlignment.Right;

            ComprasTxtSaldoFinal.Entrada.SelectAll();
            ComprasTxtSaldoFinal.Entrada.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ComprasMetEjecutarCierre(object Remitente, EventArgs Evento)
        {
            DialogResult Respuesta = MessageBox.Show(
                "El cierre es definitivo: los movimientos del período quedarán bloqueados.\n¿Desea continuar?",
                "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Respuesta != DialogResult.Yes) return;

            int IdPeriodo = Convert.ToInt32(ComprasCboPeriodo.SelectedValue);
            string Mensaje = _Controlador.ComprasFuncEjecutarCierre(IdPeriodo);
            MessageBox.Show(Mensaje, "Cierre de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ComprasBtnEjecutarCierre.Enabled = false;
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

        private void FrmCierre_Movimientos_Load(object sender, EventArgs e)
        {

        }

        private void ComprasGbxSaldos_Enter(object sender, EventArgs e)
        {

        }
    }
    // Fin del código de "José Pablo Cano Cóbar" - Carné: "0901-23-1727" - Fecha: "11/10/26"
}