using System.Data;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace CapaVista_DisponibilidadDiaria.Reportes
{
    // El navegador obtiene las columnas del esquema instalado. El RDLC usa ese mismo
    // esquema para no asumir nombres de campos que pueden variar entre instalaciones.
    internal static class ClsReporteCuentaBancaria
    {
        private static readonly XNamespace Ns = "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition";
        private static XElement E(string nombre, params object[] contenido)
        {
            return new XElement(Ns + nombre, contenido);
        }

        private static XElement Texto(string nombre, string valor, bool encabezado)
        {
            return E("Textbox", new XAttribute("Name", nombre), E("CanGrow", "true"),
                E("Paragraphs", E("Paragraph", E("TextRuns", E("TextRun", E("Value", valor),
                    E("Style", E("FontFamily", "Arial"), E("FontSize", "9pt"),
                        E("FontWeight", encabezado ? "Bold" : "Normal"),
                        E("Color", encabezado ? "White" : "Black")))))),
                E("Style", E("BackgroundColor", encabezado ? "#1C4A30" : "White"),
                    E("Border", E("Color", "LightGrey"), E("Style", "Solid")),
                    E("PaddingLeft", "3pt"), E("PaddingRight", "3pt"),
                    E("PaddingTop", "3pt"), E("PaddingBottom", "3pt")));
        }

        internal static string CrearDefinicion(DataTable datos)
        {
            var columnas = datos.Columns.Cast<DataColumn>().ToArray();
            string ancho = (27m / columnas.Length).ToString("0.######", CultureInfo.InvariantCulture) + "cm";
            var tabla = E("Tablix", new XAttribute("Name", "TablaCuentas"),
                E("TablixBody",
                    E("TablixColumns", columnas.Select(c => E("TablixColumn", E("Width", ancho)))),
                    E("TablixRows",
                        E("TablixRow", E("Height", "0.8cm"), E("TablixCells", columnas.Select((c, i) =>
                            E("TablixCell", E("CellContents", Texto("Cabecera" + i, c.Caption, true)))))),
                        E("TablixRow", E("Height", "0.7cm"), E("TablixCells", columnas.Select((c, i) =>
                            E("TablixCell", E("CellContents", Texto("Dato" + i, "=Fields!Campo" + i + ".Value", false)))))))),
                E("TablixColumnHierarchy", E("TablixMembers", columnas.Select(c => E("TablixMember")))),
                E("TablixRowHierarchy", E("TablixMembers",
                    E("TablixMember", E("KeepWithGroup", "After"), E("RepeatOnNewPage", "true")),
                    E("TablixMember", E("Group", new XAttribute("Name", "Detalle"))))),
                E("DataSetName", "CuentasBancarias"), E("NoRowsMessage", "No hay cuentas bancarias registradas."),
                E("Top", "2.4cm"), E("Left", "0cm"), E("Height", "1.5cm"), E("Width", "27cm"));
            var titulo = Texto("Titulo", "Bancos - Reporte de cuentas bancarias", true);
            titulo.Add(E("Top", "0cm"), E("Left", "0cm"), E("Height", "0.9cm"), E("Width", "27cm"));
            var resumen = Texto("Resumen", "=\"Listado completo | Generado: \" & Format(Globals!ExecutionTime, \"dd/MM/yyyy HH:mm\") & \" | Registros: \" & CountRows(\"CuentasBancarias\")", false);
            resumen.Add(E("Top", "1.1cm"), E("Left", "0cm"), E("Height", "0.9cm"), E("Width", "27cm"));
            var pagina = Texto("Pagina", "=\"Página \" & Globals!PageNumber & \" de \" & Globals!TotalPages", false);
            pagina.Add(E("Top", "0cm"), E("Left", "0cm"), E("Height", "0.7cm"), E("Width", "27cm"));
            return new XDocument(E("Report",
                E("Body", E("ReportItems", titulo, resumen, tabla), E("Height", "4cm")),
                E("Width", "27cm"),
                E("Page", E("PageFooter", E("Height", "0.8cm"), E("PrintOnFirstPage", "true"),
                    E("PrintOnLastPage", "true"), E("ReportItems", pagina)),
                    E("PageHeight", "21cm"), E("PageWidth", "29.7cm"),
                    E("LeftMargin", "1cm"), E("RightMargin", "1cm"), E("TopMargin", "1cm"), E("BottomMargin", "1cm")),
                E("DataSources", E("DataSource", new XAttribute("Name", "OrigenCuentas"),
                    E("ConnectionProperties", E("DataProvider", "System.Data.DataSet"), E("ConnectString", "/* Local */")))),
                E("DataSets", E("DataSet", new XAttribute("Name", "CuentasBancarias"),
                    E("Query", E("DataSourceName", "OrigenCuentas"), E("CommandText", "/* Local */")),
                    E("Fields", columnas.Select((c, i) => E("Field", new XAttribute("Name", "Campo" + i), E("DataField", c.ColumnName)))))),
                E("Language", "es-GT"))).ToString();
        }
    }
}
