using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_GeneracionPagos.Entidades;
using CapaModelo_GeneracionPagos.Repositorio;

namespace CapaControlador_GeneracionPagos
{
    public class ClsModeloMoneda
    {
        private long _PK_Moneda;
        private string _CodigoMoneda;
        private string _NombreMoneda;
        private string _SimboloMoneda;
        private bool _IsActive;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioMoneda _RepositorioMoneda;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloMoneda> _ListaMoneda;

        public long PK_Moneda { get => _PK_Moneda; set => _PK_Moneda = value; }
        public string CodigoMoneda { get => _CodigoMoneda; set => _CodigoMoneda = value; }
        public string NombreMoneda { get => _NombreMoneda; set => _NombreMoneda = value; }
        public string SimboloMoneda { get => _SimboloMoneda; set => _SimboloMoneda = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloMoneda()
        {
            _RepositorioMoneda = new ClsRepositorioMoneda();
        }

        public string BancosFuncValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(_CodigoMoneda) || _CodigoMoneda.Trim().Length != 3)
                return "El código de la moneda debe tener 3 letras (por ejemplo GTQ).";
            if (string.IsNullOrWhiteSpace(_NombreMoneda))
                return "El nombre de la moneda es obligatorio.";
            if (string.IsNullOrWhiteSpace(_SimboloMoneda))
                return "El símbolo de la moneda es obligatorio.";
            return null;
        }

        public string BancosMetGrabarCambios()
        {
            string Mensaje = null;

            if (Estado != EstadoEntidad.Deleted)
            {
                string Error = BancosFuncValidarDatos();
                if (Error != null)
                    return Error;
            }

            var ModeloDatos = new ClsMoneda();
            ModeloDatos.PK_Moneda = _PK_Moneda;
            ModeloDatos.CodigoMoneda = _CodigoMoneda == null ? null : _CodigoMoneda.Trim().ToUpperInvariant();
            ModeloDatos.NombreMoneda = _NombreMoneda == null ? null : _NombreMoneda.Trim();
            ModeloDatos.SimboloMoneda = _SimboloMoneda == null ? null : _SimboloMoneda.Trim();

            switch (Estado)
            {
                case EstadoEntidad.Added:
                    _RepositorioMoneda.BancosMetAgregar(ModeloDatos);
                    Mensaje = "Grabación exitosa";
                    break;
                case EstadoEntidad.Modified:
                    _RepositorioMoneda.BancosMetEditar(ModeloDatos);
                    Mensaje = "Actualización exitosa";
                    break;
                case EstadoEntidad.Deleted:
                    _RepositorioMoneda.BancosMetRemover(ModeloDatos);
                    Mensaje = "Eliminación exitosa";
                    break;
            }
            return Mensaje;
        }

        public List<ClsModeloMoneda> BancosMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioMoneda.BancosMetObtenerTodos();
            _ListaMoneda = new List<ClsModeloMoneda>();
            foreach (ClsMoneda Item in ResultadoConsulta)
            {
                _ListaMoneda.Add(new ClsModeloMoneda
                {
                    _PK_Moneda = Item.PK_Moneda,
                    _CodigoMoneda = Item.CodigoMoneda,
                    _NombreMoneda = Item.NombreMoneda,
                    _SimboloMoneda = Item.SimboloMoneda,
                    _IsActive = Item.IsActive,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaMoneda;
        }

        public IEnumerable<ClsModeloMoneda> BancosMetBuscarPorCodigo(string CodigoMoneda)
        {
            if (_ListaMoneda == null)
                BancosMetObtenerTodos();

            return _ListaMoneda.FindAll(e => e._CodigoMoneda == CodigoMoneda);
        }
    }
}
