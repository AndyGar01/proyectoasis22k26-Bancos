using System.Collections.Generic;

namespace CapaModelo_GeneracionPagos.Contratos
{
    public interface IRepositorioGenerico<Entidad> where Entidad : class
    {
        int BancosMetAgregar(Entidad Entidad);
        int BancosMetEditar(Entidad Entidad);
        int BancosMetRemover(Entidad Entidad);
        IEnumerable<Entidad> BancosMetObtenerTodos();
    }
}