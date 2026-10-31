using System.Data;
using CapaModelo_OrdenesCompra.Entidades;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diego Fernando Santizo Samayoa
 * Carné : 0901-22-15950
 * Fecha : 24/10/2026
 * ==================================================================
 * Propósito :
 *  Define el contrato de persistencia de órdenes de compra.
 * ===================================================================
*/


namespace CapaModelo_OrdenesCompra.Contratos
{
    public interface IRepositorioOrdenesCompra
    {
        
        
        
        
        DataTable ComprasFuncListar();
        
        
        
        
        DataTable ComprasFuncListar(string Estado);
        
        
        
        
        void ComprasProcCambiarEstado(int Id, string Estado);
        
        
        
        
        DataTable ComprasFuncListarDetalles(int Id);
        
        
        
        
        ClsOrdenCompra ComprasFuncObtener(int Id);
        
        
        
        
        DataTable ComprasFuncListarProveedores();
        
        
        
        
        void ComprasProcAnular(int Id);
        
        
        
        
        void ComprasProcActualizarVencimiento(int Id, System.DateTime Fecha);
        
        
        
        
        int ComprasFuncCrear(string CodigoOrdenCompra, int IdProveedor, int IdPlazo, int IdMoneda, System.DateTime Emision,
            System.DateTime Vencimiento, decimal TipoCambio, decimal Subtotal, decimal Descuento, string Comentario);
    }
}
