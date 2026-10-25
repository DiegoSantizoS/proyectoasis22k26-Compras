using System.Data;

namespace CapaModelo_OrdenesCompra
{
    public interface IRepositorioComprasPorPagar
    {
        DataTable Listar();
        DataTable Obtener(int Id);
        DataTable ListarProveedores();
        void Anular(int Id);
        void ActualizarVencimiento(int Id, System.DateTime Fecha);
        int Crear(int IdProveedor, string Factura, System.DateTime Emision, System.DateTime Vencimiento, decimal Monto);
    }
}
