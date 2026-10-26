
using System.Data.Odbc;
using CapaModelo_Componentes.Repositorios;



namespace CapaModelo_PagosProveedores
{
    public abstract class ClsConexionCompras : ClsRepositorioMaestroCompras
    {
        protected OdbcConnection ComprasMetObtenerConexion()
        {
            return ComprasFuncObtenerConexion();
        }

        public void ComprasMetDesconexion(OdbcConnection ConexionOdbc)
        {
            ConexionOdbc?.Dispose();
        }
    }
}
