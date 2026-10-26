using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;



namespace CapaModelo_PagosProveedores
{
    public abstract class ClsSentenciasCompras : ClsConexionCompras
    {
        public int ComprasMetEjecucionNonQuery(string ComandoTexto, List<OdbcParameter> Parametros, CommandType ComandoTipo)
        {
            return ComprasFuncEjecucionNonQuery(ComandoTexto, Parametros, ComandoTipo);
        }

        // Devuelve el primer valor del resultado (se usa para obtener el idPago
        // que regresa spInsertarPagoProveedor con un SELECT).
        public object ComprasMetEjecucionEscalar(string ComandoTexto, List<OdbcParameter> Parametros, CommandType ComandoTipo)
        {
            return ComprasFuncEjecucionEscalar(ComandoTexto, Parametros, ComandoTipo);
        }

        public DataTable ComprasMetEjecucionConsulta(string ComandoTexto, CommandType ComandoTipo)
        {
            return ComprasFuncEjecucionConsulta(ComandoTexto, ComandoTipo);
        }

        public DataTable ComprasMetEjecucionConsulta(string ComandoTexto, CommandType ComandoTipo, List<OdbcParameter> Parametros)
        {
            return ComprasFuncEjecucionConsulta(ComandoTexto, ComandoTipo, Parametros);
        }
    }
}
