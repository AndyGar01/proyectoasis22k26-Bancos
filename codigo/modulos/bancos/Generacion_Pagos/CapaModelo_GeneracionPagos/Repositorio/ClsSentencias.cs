using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_GeneracionPagos.Repositorio
{
    public class ClsSentencias : ClsConexion
    {
        public int BancosMetEjecucionNonQuery(string ComandoTexto, List<OdbcParameter> Parametros, CommandType ComandoTipo)
        {
            using (var ConexionActiva = BancosMetObtenerConexion())
            {
                ConexionActiva.Open();
                using (var Comando = new OdbcCommand())
                {
                    Comando.Connection = ConexionActiva;
                    Comando.CommandText = ComandoTexto;
                    Comando.CommandType = ComandoTipo;
                    Comando.Parameters.AddRange(Parametros.ToArray());
                    return Comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable BancosMetEjecucionConsulta(string ComandoTexto, CommandType ComandoTipo)
        {
            var TablaDatos = new DataTable();
            using (var ConexionActiva = BancosMetObtenerConexion())
            {
                ConexionActiva.Open();
                using (var Comando = new OdbcCommand())
                {
                    Comando.Connection = ConexionActiva;
                    Comando.CommandText = ComandoTexto;
                    Comando.CommandType = ComandoTipo;
                    using (var LectorDatos = Comando.ExecuteReader())
                        TablaDatos.Load(LectorDatos);
                }
            }
            return TablaDatos;
        }

        public DataTable BancosMetEjecucionConsulta(string ComandoTexto, CommandType ComandoTipo, List<OdbcParameter> Parametros)
        {
            var TablaDatos = new DataTable();
            using (var ConexionActiva = BancosMetObtenerConexion())
            {
                ConexionActiva.Open();
                using (var Comando = new OdbcCommand())
                {
                    Comando.Connection = ConexionActiva;
                    Comando.CommandText = ComandoTexto;
                    Comando.CommandType = ComandoTipo;
                    Comando.Parameters.AddRange(Parametros.ToArray());
                    using (var LectorDatos = Comando.ExecuteReader())
                        TablaDatos.Load(LectorDatos);
                }
            }
            return TablaDatos;
        }
    }
}