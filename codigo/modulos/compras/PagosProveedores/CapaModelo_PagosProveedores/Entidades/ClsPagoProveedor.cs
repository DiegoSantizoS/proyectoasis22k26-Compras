using System;



namespace CapaModelo_PagosProveedores.Entidades
{
    public class ClsPagoProveedor
    {
        public int IdPagoProveedor { get; set; }
        public string NoPagoProveedor { get; set; }        // PG-0041 (solo lectura, viene de la consulta)
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }        // solo lectura
        public int IdCuentaPorPagar { get; set; }
        public string FacturaCuentaPorPagar { get; set; }  // numero de factura (solo lectura)
        public DateTime FechaPagoProveedor { get; set; }
        public decimal MontoPagoProveedor { get; set; }
        public string MetodoPagoProveedor { get; set; }
        public string ReferenciaPagoProveedor { get; set; }
        public string EstadoPagoProveedor { get; set; }
    }
}
