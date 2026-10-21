using System.Collections.Generic;

namespace CapaModelo_PagosProveedores.Contratos
{
   
    public interface IRepositorioGenerico<Entidad> where Entidad : class
    {
        int ComprasMetAgregar(Entidad Entidad);
        int ComprasMetEditar(Entidad Entidad);
        int ComprasMetRemover(Entidad Entidad);
        IEnumerable<Entidad> ComprasMetObtenerTodos();
    }
}