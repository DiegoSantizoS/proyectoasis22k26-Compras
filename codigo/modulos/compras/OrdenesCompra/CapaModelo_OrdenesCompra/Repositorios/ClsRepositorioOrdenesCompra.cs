using System;
using System.Data;
using CapaModelo_OrdenesCompra.Contratos;
using CapaModelo_OrdenesCompra.Entidades;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diego Fernando Santizo Samayoa
 * Carné : 0901-22-15950
 * Fecha : 24/10/2026
 * ==================================================================
 * Propósito :
 *  Implementa el contrato de persistencia de órdenes de compra.
 * ===================================================================
*/










namespace CapaModelo_OrdenesCompra.Repositorios
{
    public sealed class ClsRepositorioOrdenesCompra : IRepositorioOrdenesCompra
    {
        private readonly ClsConsultasOrdenesCompra _Consultas = new ClsConsultasOrdenesCompra();
        private readonly ClsComandosOrdenesCompra _Comandos = new ClsComandosOrdenesCompra();

        
        
        
        public DataTable ComprasFuncListar() => _Consultas.ComprasFuncListar();
        
        
        
        public DataTable ComprasFuncListar(string Estado) => _Consultas.ComprasFuncListar(Estado);
        
        
        
        public ClsOrdenCompra ComprasFuncObtener(int Id) => _Consultas.ComprasFuncObtener(Id);
        
        
        
        public DataTable ComprasFuncListarDetalles(int Id) => _Consultas.ComprasFuncListarDetalles(Id);
        
        
        
        public DataTable ComprasFuncListarProveedores() => _Consultas.ComprasFuncListarProveedores();
        
        
        
        public void ComprasProcAnular(int Id) => _Comandos.ComprasProcAnular(Id);
        
        
        
        public void ComprasProcCambiarEstado(int Id, string Estado) => _Comandos.ComprasProcCambiarEstado(Id, Estado);
        
        
        
        public void ComprasProcActualizarVencimiento(int Id, DateTime Fecha) => _Comandos.ComprasProcActualizarVencimiento(Id, Fecha);

        
        
        
        public int ComprasFuncCrear(string CodigoOrdenCompra, int IdProveedor, int IdPlazo, int IdMoneda, DateTime Emision,
            DateTime Vencimiento, decimal TipoCambio, decimal Subtotal, decimal Descuento, string Comentario)
        {
            return _Comandos.ComprasFuncCrear(CodigoOrdenCompra, IdProveedor, IdPlazo, IdMoneda,
                Emision, Vencimiento, TipoCambio, Subtotal, Descuento, Comentario);
        }
    }
}
