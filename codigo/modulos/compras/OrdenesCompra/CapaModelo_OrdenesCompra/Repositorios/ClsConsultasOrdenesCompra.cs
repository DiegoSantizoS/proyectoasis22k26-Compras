using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using CapaModelo_OrdenesCompra.Entidades;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diego Fernando Santizo Samayoa
 * Carné : 0901-22-15950
 * Fecha : 24/10/2026
 * ==================================================================
 * Propósito :
 *  Consulta los datos de órdenes de compra y sus catálogos.
 * ===================================================================
*/










namespace CapaModelo_OrdenesCompra.Repositorios
{
    internal sealed class ClsConsultasOrdenesCompra : ClsRepositorioBaseOrdenesCompra
    {
        private const string _Consulta = "SELECT o.idOrdenCompra, o.codigoOrdenCompra, o.idProveedor, o.idPlazo, o.idMoneda, "
            + "o.fechaEmisionOrdenCompra, o.fechaVencimientoOrdenCompra, o.tipoCambioOrdenCompra, "
            + "o.subtotalOrdenCompra, o.descuentoOrdenCompra, o.totalOrdenCompra, "
            + "o.comentarioOrdenCompra, o.estadoOrdenCompra, p.nombreProveedor, p.nitProveedor, "
            + "p.telefonoProveedor, p.correoProveedor, p.direccionProveedor, p.estadoProveedor, "
            + "z.nombrePlazo, z.diasPlazo FROM tblOrdenCompra o "
            + "INNER JOIN tblProveedor p ON p.idProveedor = o.idProveedor "
            + "INNER JOIN tblPlazo z ON z.idPlazo = o.idPlazo ";

        
        
        
        internal DataTable ComprasFuncListar()
        {
            return ComprasFuncConsultar(_Consulta + "ORDER BY o.fechaEmisionOrdenCompra DESC, o.idOrdenCompra DESC");
        }

        
        
        
        internal DataTable ComprasFuncListar(string Estado)
        {
            return ComprasFuncEjecucionConsulta(_Consulta + "WHERE o.estadoOrdenCompra = ? "
                + "ORDER BY o.fechaEmisionOrdenCompra DESC, o.idOrdenCompra DESC", CommandType.Text,
                new List<OdbcParameter> { new OdbcParameter("Estado", OdbcType.VarChar, 30) { Value = Estado } });
        }

        
        
        
        
        internal ClsOrdenCompra ComprasFuncObtener(int Id)
        {
            ComprasProcValidarId(Id);
            using (DataTable Datos = ComprasFuncConsultar(_Consulta + "WHERE o.idOrdenCompra = ?", Id))
            {
                return Datos.Rows.Count == 0 ? null : new ClsOrdenCompra(Datos.Rows[0]);
            }
        }

        
        
        
        
        internal DataTable ComprasFuncListarDetalles(int Id)
        {
            ComprasProcValidarId(Id);
            return ComprasFuncConsultar("SELECT idProducto, cantidadDetalleOrdenCompra, "
                + "costoUnitarioDetalleOrdenCompra, descuentoPorcentajeDetalleOrdenCompra, "
                + "subtotalDetalleOrdenCompra FROM tblDetalleOrdenCompra WHERE idOrdenCompra = ? ORDER BY idProducto", Id);
        }

        
        
        
        
        internal DataTable ComprasFuncListarProveedores()
        {
            return ComprasFuncConsultar("SELECT idProveedor, nombreProveedor, nitProveedor, telefonoProveedor, "
                + "correoProveedor, direccionProveedor, estadoProveedor FROM tblProveedor "
                + "WHERE estadoProveedor = 1 ORDER BY nombreProveedor");
        }

        
        
        
        
        private DataTable ComprasFuncConsultar(string Sql, int? Id = null)
        {
            var Parametros = new List<OdbcParameter>();
            if (Id.HasValue)
                Parametros.Add(new OdbcParameter("Id", OdbcType.Int) { Value = Id.Value });
            return ComprasFuncEjecucionConsulta(Sql, CommandType.Text, Parametros);
        }

        
        
        
        private static void ComprasProcValidarId(int Id)
        {
            if (Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(Id));
        }
    }
}
