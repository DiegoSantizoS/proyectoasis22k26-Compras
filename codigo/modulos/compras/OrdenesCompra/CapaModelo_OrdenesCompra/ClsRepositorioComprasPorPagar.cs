using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_OrdenesCompra
{
    public sealed class ClsRepositorioComprasPorPagar : IRepositorioComprasPorPagar
    {
        private const string Consulta = "SELECT c.idCuentaPorPagar, c.idProveedor, c.numeroFacturaCuentaPorPagar, "
            + "c.fechaEmisionCuentaPorPagar, c.fechaVencimientoCuentaPorPagar, c.montoTotalCuentaPorPagar, "
            + "c.saldoCuentaPorPagar, c.estadoCuentaPorPagar, p.nombreProveedor, p.nitProveedor, "
            + "p.telefonoProveedor, p.correoProveedor, p.direccionProveedor, p.estadoProveedor "
            + "FROM tblCuentaPorPagar c LEFT JOIN tblProveedor p ON p.idProveedor = c.idProveedor ";

        public DataTable Listar()
        {
            return Consultar(Consulta + "ORDER BY c.fechaEmisionCuentaPorPagar DESC, c.idCuentaPorPagar DESC", null);
        }

        public DataTable Obtener(int Id)
        {
            if (Id <= 0) throw new ArgumentOutOfRangeException(nameof(Id));
            return Consultar(Consulta + "WHERE c.idCuentaPorPagar = ?", Id);
        }

        public DataTable ListarProveedores()
        {
            return Consultar("SELECT * FROM tblProveedor WHERE estadoProveedor = 1 ORDER BY nombreProveedor", null);
        }

        public void Anular(int Id)
        {
            using (var Conexion = new OdbcConnection("Dsn=EmbutidosS.A"))
            using (var Comando = new OdbcCommand("UPDATE tblCuentaPorPagar SET estadoCuentaPorPagar = 'Anulada' WHERE idCuentaPorPagar = ? AND estadoCuentaPorPagar <> 'Anulada'", Conexion))
            {
                Comando.CommandTimeout = 20;
                Comando.Parameters.Add("Id", OdbcType.Int).Value = Id;
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
        }

        public void ActualizarVencimiento(int Id, DateTime Fecha)
        {
            using (var Conexion = new OdbcConnection("Dsn=EmbutidosS.A"))
            using (var Comando = new OdbcCommand("UPDATE tblCuentaPorPagar SET fechaVencimientoCuentaPorPagar = ? WHERE idCuentaPorPagar = ? AND fechaEmisionCuentaPorPagar <= ?", Conexion))
            {
                Comando.CommandTimeout = 20;
                Comando.Parameters.Add("Fecha", OdbcType.Date).Value = Fecha.Date;
                Comando.Parameters.Add("Id", OdbcType.Int).Value = Id;
                Comando.Parameters.Add("Emision", OdbcType.Date).Value = Fecha.Date;
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
        }

        public int Crear(int IdProveedor, string Factura, DateTime Emision, DateTime Vencimiento, decimal Monto)
        {
            const string Sql = "INSERT INTO tblCuentaPorPagar (idProveedor, numeroFacturaCuentaPorPagar, "
                + "fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar, montoTotalCuentaPorPagar, "
                + "saldoCuentaPorPagar, estadoCuentaPorPagar) "
                + "SELECT idProveedor, ?, ?, ?, ?, ?, 'Pendiente' FROM tblProveedor "
                + "WHERE idProveedor = ? AND estadoProveedor = 1";
            using (var Conexion = new OdbcConnection("Dsn=EmbutidosS.A"))
            using (var Comando = new OdbcCommand(Sql, Conexion))
            {
                Comando.CommandTimeout = 20;
                Comando.Parameters.Add("Factura", OdbcType.VarChar, 30).Value = Factura;
                Comando.Parameters.Add("Emision", OdbcType.Date).Value = Emision.Date;
                Comando.Parameters.Add("Vencimiento", OdbcType.Date).Value = Vencimiento.Date;
                foreach (string Campo in new[] { "Monto", "Saldo" })
                {
                    var Parametro = Comando.Parameters.Add(Campo, OdbcType.Decimal);
                    Parametro.Precision = 12;
                    Parametro.Scale = 4;
                    Parametro.Value = Monto;
                }
                Comando.Parameters.Add("IdProveedor", OdbcType.Int).Value = IdProveedor;
                Conexion.Open();
                if (Comando.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("El proveedor no esta disponible o esta inactivo.");
                Comando.Parameters.Clear();
                Comando.CommandText = "SELECT LAST_INSERT_ID()";
                return Convert.ToInt32(Comando.ExecuteScalar());
            }
        }

        private static DataTable Consultar(string Sql, int? Id)
        {
            using (var Conexion = new OdbcConnection("Dsn=EmbutidosS.A"))
            using (var Comando = new OdbcCommand(Sql, Conexion))
            using (var Adaptador = new OdbcDataAdapter(Comando))
            {
                Comando.CommandTimeout = 20;
                if (Id.HasValue) Comando.Parameters.Add("IdCuentaPorPagar", OdbcType.Int).Value = Id.Value;
                var Datos = new DataTable();
                Adaptador.Fill(Datos);
                return Datos;
            }
        }
    }
}
