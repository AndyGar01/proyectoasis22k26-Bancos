using CapaModelo_TipoCuentaBancaria.Contratos;
using CapaModelo_TipoCuentaBancaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_TipoCuentaBancaria.Repositorios
{
    public class ClsRepositorioTipoCuentaBancaria : ClsSentencias, IRepositorioTipoCuentaBancaria
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioTipoCuentaBancaria()
        {
            _SelectAll = "SELECT Pk_TipoCuentaBancaria, codigoTipoCuentaBancaria, nombreTipoCuentaBancaria, " +
            "is_active, created_at, updated_at FROM tblTipoCuentaBancaria";
            _Insert = "INSERT INTO tblTipoCuentaBancaria (codigoTipoCuentaBancaria, nombreTipoCuentaBancaria, is_active) VALUES (?, ?, ?)";
            _Update = "UPDATE tblTipoCuentaBancaria SET codigoTipoCuentaBancaria=?, nombreTipoCuentaBancaria=?, is_active=? WHERE Pk_TipoCuentaBancaria=?";
            _Delete = "DELETE FROM tblTipoCuentaBancaria WHERE Pk_TipoCuentaBancaria=?";
        }
        public int BancosMetAgregar(ClsTipoCuentaBancaria Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_codigo", Entidad.CodigoTipoCuentaBancaria));
            Parametros.Add(new OdbcParameter("p_nombre", Entidad.NombreTipoCuentaBancaria));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));
            return BancosMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int BancosMetEditar(ClsTipoCuentaBancaria Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_codigo", Entidad.CodigoTipoCuentaBancaria));
            Parametros.Add(new OdbcParameter("p_nombre", Entidad.NombreTipoCuentaBancaria));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));
            Parametros.Add(new OdbcParameter("p_id", Entidad.IdTipoCuentaBancaria));
            return BancosMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int BancosMetRemover(ClsTipoCuentaBancaria Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_id", Entidad.IdTipoCuentaBancaria));
            return BancosMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsTipoCuentaBancaria> BancosMetObtenerTodos()
        {
            var Lista = new List<ClsTipoCuentaBancaria>();
            var TablaDatos = BancosMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Row in TablaDatos.Rows)
            {
                var Tipo = new ClsTipoCuentaBancaria();
                Tipo.IdTipoCuentaBancaria = Convert.ToInt64(Row[0]);
                Tipo.CodigoTipoCuentaBancaria = Convert.ToString(Row[1]);
                Tipo.NombreTipoCuentaBancaria = Convert.ToString(Row[2]);
                Tipo.IsActive = Convert.ToBoolean(Row[3]);
                Tipo.CreatedAt = Convert.ToDateTime(Row[4]);
                Tipo.UpdatedAt = Convert.ToDateTime(Row[5]);
                Lista.Add(Tipo);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return Lista;
        }
    }
}
