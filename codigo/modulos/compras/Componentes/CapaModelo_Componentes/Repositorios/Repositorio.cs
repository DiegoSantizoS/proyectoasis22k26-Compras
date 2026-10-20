using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Cbo_Compras.Repositorios
{
    public abstract class Repositorio
    {
        public readonly string connectionString;
        public Repositorio()
        {
            connectionString = "Dsn=EmbutidosS.A";
        }
        protected OdbcConnection ObtenerConexion()
        {
            return new OdbcConnection(connectionString);
        }
    }

}
