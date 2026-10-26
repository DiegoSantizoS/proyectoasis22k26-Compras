using System;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diego Fernando Santizo Samayoa
 * Carné : 0901-22-15950
 * Fecha : 24/10/2026
 * ==================================================================
 * Propósito :
 *  Calcula el subtotal, impuesto y total de los artículos de una orden
 *  de compra y representa los importes resultantes del cálculo.
 * ===================================================================
*/

namespace CapaControlador_OrdenesCompra
{
    public sealed class ClsTotalesArticulo
    {
        public decimal Subtotal { get; internal set; }
        public decimal Impuesto { get; internal set; }
        public decimal Total { get; internal set; }
    }

    public static class ClsCalculoOrdenCompra
    {
        public static ClsTotalesArticulo ComprasFuncCalcularArticulo(decimal Cantidad, decimal PrecioUnitario,
            decimal Descuento, decimal PorcentajeImpuesto)
        {
            decimal Subtotal = Math.Round(Cantidad * PrecioUnitario, 2);
            decimal Impuesto = Math.Round((Subtotal - Descuento) * PorcentajeImpuesto, 2);
            return new ClsTotalesArticulo
            {
                Subtotal = Subtotal,
                Impuesto = Impuesto,
                Total = Subtotal - Descuento + Impuesto
            };
        }
    }
}
