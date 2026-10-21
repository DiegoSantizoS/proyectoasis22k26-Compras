using System;
using System.Collections.Generic;
using System.Data;
using CapaModelo_PagosProveedores.Entidades;

namespace CapaModelo_PagosProveedores.Contratos
{

    public interface IRepositorioPagoProveedor : IRepositorioGenerico<ClsPagoProveedor>
    {
        IEnumerable<ClsPagoProveedor> ComprasMetConsultar(int? IdProveedor, string Estado, DateTime? Desde, DateTime? Hasta);
        ClsPagoProveedor ComprasMetObtenerPorId(int IdPago);
        DataTable ComprasMetObtenerProveedores();
        DataTable ComprasMetObtenerCuentasPendientes(int IdProveedor);
    }
}
