
using System.Data.Odbc;

namespace CapaModelo_Componentes.Repositorios
{
    public abstract class ClsRepositorioCompras
    {
        private readonly string _CadenaConexion;

        protected ClsRepositorioCompras()
        {
            _CadenaConexion = "Dsn=EmbutidosS.A";
        }
        protected OdbcConnection ComprasFuncObtenerConexion()
        {
            return new OdbcConnection(_CadenaConexion);
        }
    }

}
