using CapaModelo_AutorizacionOrdenes.Entidades;
using CapaModelo_AutorizacionOrdenes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CapaControlador_AutorizacionOrdenes.ClsModeloTipoCuentaBancaria.cs
{
    public class ClsModeloTipoCuentaBancaria
    {
        private long _IdTipoCuentaBancaria;
        private string _CodigoTipoCuentaBancaria;
        private string _NombreTipoCuentaBancaria;
        private bool _IsActive;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioTipoCuentaBancaria _RepositorioTipoCuentaBancaria;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloTipoCuentaBancaria> _ListaTipoCuentaBancaria;

        public long IdTipoCuentaBancaria { get => _IdTipoCuentaBancaria; set => _IdTipoCuentaBancaria = value; }

        [Required(ErrorMessage = "El campo Código es requerido")]
        public string CodigoTipoCuentaBancaria { get => _CodigoTipoCuentaBancaria; set => _CodigoTipoCuentaBancaria = value; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string NombreTipoCuentaBancaria { get => _NombreTipoCuentaBancaria; set => _NombreTipoCuentaBancaria = value; }

        [Required(ErrorMessage = "El campo Estado es requerido")]
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }

        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloTipoCuentaBancaria()
        {
            _RepositorioTipoCuentaBancaria = new ClsRepositorioTipoCuentaBancaria();
        }

        public string BancosMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var DatosTipoCuenta = new ClsTipoCuentaBancaria();
                DatosTipoCuenta.IdTipoCuentaBancaria = _IdTipoCuentaBancaria;
                DatosTipoCuenta.CodigoTipoCuentaBancaria = _CodigoTipoCuentaBancaria;
                DatosTipoCuenta.NombreTipoCuentaBancaria = _NombreTipoCuentaBancaria;
                DatosTipoCuenta.IsActive = _IsActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioTipoCuentaBancaria.BancosMetAgregar(DatosTipoCuenta);
                        Mensaje = "Grabacion exitosa";
                        break;

                    case EstadoEntidad.Modified:
                        _RepositorioTipoCuentaBancaria.BancosMetEditar(DatosTipoCuenta);
                        Mensaje = "Actualizacion exitosa";
                        break;

                    case EstadoEntidad.Deleted:
                        _RepositorioTipoCuentaBancaria.BancosMetRemover(DatosTipoCuenta);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception Ex)
            {
                Mensaje = Ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloTipoCuentaBancaria> BancosMetObtenerTodos()
        {
            var DatosTipoCuenta = _RepositorioTipoCuentaBancaria.BancosMetObtenerTodos();
            _ListaTipoCuentaBancaria = new List<ClsModeloTipoCuentaBancaria>();
            foreach (ClsTipoCuentaBancaria Item in DatosTipoCuenta)
            {
                _ListaTipoCuentaBancaria.Add(new ClsModeloTipoCuentaBancaria
                {
                    _IdTipoCuentaBancaria = Item.IdTipoCuentaBancaria,
                    _CodigoTipoCuentaBancaria = Item.CodigoTipoCuentaBancaria,
                    _NombreTipoCuentaBancaria = Item.NombreTipoCuentaBancaria,
                    _IsActive = Item.IsActive,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaTipoCuentaBancaria;
        }

        public ClsModeloTipoCuentaBancaria BancosMetBuscarPorId(long IdTipoCuentaBancaria)
        {
            return _ListaTipoCuentaBancaria.Find(e => e._IdTipoCuentaBancaria == IdTipoCuentaBancaria);
        }
    }
}
