using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_GeneracionPagos.Contratos;
using CapaModelo_GeneracionPagos.Entidades;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_GeneracionPagos.Repositorio
{
    public class ClsRepositorioMoneda : ClsSentencias, IRepositorioMoneda
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioMoneda()
        {
            _SelectAll = "SELECT Pk_Moneda, codigoMoneda, nombreMoneda, simboloMoneda, is_active, created_at, updated_at FROM tblMoneda ORDER BY codigoMoneda";
            _Insert = "INSERT INTO tblMoneda (codigoMoneda, nombreMoneda, simboloMoneda) VALUES (?, ?, ?)";
            _Update = "UPDATE tblMoneda SET codigoMoneda=?, nombreMoneda=?, simboloMoneda=? WHERE Pk_Moneda=?";
            _Delete = "DELETE FROM tblMoneda WHERE Pk_Moneda=?";
        }

        public int BancosMetAgregar(ClsMoneda Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_codigoMoneda", Entidad.CodigoMoneda));
            Parametros.Add(new OdbcParameter("p_nombreMoneda", Entidad.NombreMoneda));
            Parametros.Add(new OdbcParameter("p_simboloMoneda", Entidad.SimboloMoneda));

            return BancosMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int BancosMetEditar(ClsMoneda Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_codigoMoneda", Entidad.CodigoMoneda));
            Parametros.Add(new OdbcParameter("p_nombreMoneda", Entidad.NombreMoneda));
            Parametros.Add(new OdbcParameter("p_simboloMoneda", Entidad.SimboloMoneda));
            Parametros.Add(new OdbcParameter("p_Pk_Moneda", Entidad.PK_Moneda));

            return BancosMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int BancosMetRemover(ClsMoneda Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_Pk_Moneda", Entidad.PK_Moneda));

            return BancosMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsMoneda> BancosMetObtenerTodos()
        {
            var ListaMoneda = new List<ClsMoneda>();
            var TablaDatos = BancosMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Moneda = new ClsMoneda();
                Moneda.PK_Moneda = Convert.ToInt64(Fila[0]);
                Moneda.CodigoMoneda = Fila[1].ToString();
                Moneda.NombreMoneda = Fila[2].ToString();
                Moneda.SimboloMoneda = Fila[3].ToString();
                Moneda.IsActive = Convert.ToBoolean(Fila[4]);
                Moneda.CreatedAt = Convert.ToDateTime(Fila[5]);
                Moneda.UpdatedAt = Convert.ToDateTime(Fila[6]);
                ListaMoneda.Add(Moneda);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaMoneda;
        }
    }
}
