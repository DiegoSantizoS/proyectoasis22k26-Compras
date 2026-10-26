using System.Data;

namespace CapaModelo_OrdenesCompra
{
    public interface IRepositorioComprasPorPagar
    {
        DataTable ComprasFuncListar();
        DataTable ComprasFuncObtener(int Id);
        DataTable ComprasFuncListarProveedores();
        void ComprasProcAnular(int Id);
        void ComprasProcActualizarVencimiento(int Id, System.DateTime Fecha);
        int ComprasFuncCrear(int IdProveedor, string Factura, System.DateTime Emision, System.DateTime Vencimiento, decimal Monto);
    }
}
