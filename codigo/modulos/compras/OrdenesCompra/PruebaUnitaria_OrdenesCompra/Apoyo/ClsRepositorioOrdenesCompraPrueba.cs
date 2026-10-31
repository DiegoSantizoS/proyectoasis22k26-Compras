using System;
using System.Data;
using CapaModelo_OrdenesCompra.Contratos;
using CapaModelo_OrdenesCompra.Entidades;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diego Fernando Santizo Samayoa
 * Carné : 0901-22-15950
 * Fecha : 30/10/2026
 * ==================================================================
 * Propósito :
 *  Sustituye el acceso a datos de órdenes de compra durante las pruebas unitarias.
 * ===================================================================
*/

namespace PruebaUnitaria_OrdenesCompra.Apoyo
{
    internal sealed class ClsRepositorioOrdenesCompraPrueba : IRepositorioOrdenesCompra, IDisposable
    {
        internal DataTable Datos { get; }
        internal string EstadoSolicitado { get; private set; }
        internal string CodigoCreado { get; private set; }
        internal string ComentarioCreado { get; private set; }
        internal DateTime EmisionCreada { get; private set; }
        internal DateTime VencimientoCreado { get; private set; }
        internal DateTime VencimientoActualizado { get; private set; }
        internal bool OmitirAnulacion { get; set; }

        internal ClsRepositorioOrdenesCompraPrueba()
        {
            Datos = ComprasFuncCrearDatos();
        }

        public DataTable ComprasFuncListar() => Datos.Copy();

        public DataTable ComprasFuncListar(string Estado)
        {
            EstadoSolicitado = Estado;
            var Resultado = Datos.Clone();
            foreach (DataRow Fila in Datos.Rows)
                if (Convert.ToString(Fila["estadoOrdenCompra"]) == Estado)
                    Resultado.ImportRow(Fila);
            return Resultado;
        }

        public ClsOrdenCompra ComprasFuncObtener(int Id)
        {
            DataRow Fila = Datos.Rows.Find(Id);
            return Fila == null ? null : new ClsOrdenCompra(Fila);
        }

        public DataTable ComprasFuncListarDetalles(int Id)
        {
            var Resultado = new DataTable();
            Resultado.Columns.Add("idProducto", typeof(int));
            Resultado.Columns.Add("cantidadDetalleOrdenCompra", typeof(decimal));
            if (Datos.Rows.Find(Id) != null)
                Resultado.Rows.Add(11, 2M);
            return Resultado;
        }

        public DataTable ComprasFuncListarProveedores()
        {
            using (var Vista = new DataView(Datos, "estadoProveedor = true", "nombreProveedor", DataViewRowState.CurrentRows))
                return Vista.ToTable(true, "idProveedor", "nombreProveedor");
        }

        public void ComprasProcCambiarEstado(int Id, string Estado)
        {
            DataRow Fila = Datos.Rows.Find(Id);
            if (Fila == null)
                throw new InvalidOperationException("La orden de compra no existe.");
            Fila["estadoOrdenCompra"] = Estado;
        }

        public void ComprasProcAnular(int Id)
        {
            if (!OmitirAnulacion)
                ComprasProcCambiarEstado(Id, "Anulada");
        }

        public void ComprasProcActualizarVencimiento(int Id, DateTime Fecha)
        {
            VencimientoActualizado = Fecha;
        }

        public int ComprasFuncCrear(string CodigoOrdenCompra, int IdProveedor, int IdPlazo, int IdMoneda,
            DateTime Emision, DateTime Vencimiento, decimal TipoCambio, decimal Subtotal, decimal Descuento, string Comentario)
        {
            CodigoCreado = CodigoOrdenCompra;
            ComentarioCreado = Comentario;
            EmisionCreada = Emision;
            VencimientoCreado = Vencimiento;
            return 900;
        }

        public void Dispose()
        {
            Datos.Dispose();
        }

        private static DataTable ComprasFuncCrearDatos()
        {
            var Tabla = new DataTable();
            foreach (string Campo in new[] { "idOrdenCompra", "idProveedor", "idPlazo", "idMoneda", "diasPlazo" })
                Tabla.Columns.Add(Campo, typeof(int));
            foreach (string Campo in new[] { "codigoOrdenCompra", "estadoOrdenCompra", "comentarioOrdenCompra",
                "nombreProveedor", "nitProveedor", "telefonoProveedor", "correoProveedor", "direccionProveedor", "nombrePlazo" })
                Tabla.Columns.Add(Campo, typeof(string));
            Tabla.Columns.Add("fechaEmisionOrdenCompra", typeof(DateTime));
            Tabla.Columns.Add("fechaVencimientoOrdenCompra", typeof(DateTime));
            foreach (string Campo in new[] { "tipoCambioOrdenCompra", "subtotalOrdenCompra", "descuentoOrdenCompra", "totalOrdenCompra" })
                Tabla.Columns.Add(Campo, typeof(decimal));
            Tabla.Columns.Add("estadoProveedor", typeof(bool));
            Tabla.PrimaryKey = new[] { Tabla.Columns["idOrdenCompra"] };
            string[] Estados = { "Pendiente", "Autorizada", "Rechazada", "Anulada", "Recibida" };
            string[] Proveedores = { "José Cárnicos", "Empaques", "José Cárnicos", "Insumos", "Empaques" };
            int[] Dias = { 1, 5, 10, 15, 1 };
            for (int Indice = 0; Indice < Estados.Length; Indice++)
            {
                DataRow Fila = Tabla.NewRow();
                Fila["idOrdenCompra"] = 101 + Indice;
                Fila["codigoOrdenCompra"] = "OC-" + (Indice + 1).ToString("D3");
                Fila["idProveedor"] = Proveedores[Indice] == "José Cárnicos" ? 3 : Proveedores[Indice] == "Empaques" ? 4 : 5;
                Fila["idPlazo"] = 2;
                Fila["idMoneda"] = 1;
                Fila["diasPlazo"] = 30;
                Fila["estadoOrdenCompra"] = Estados[Indice];
                Fila["comentarioOrdenCompra"] = "Insumos de prueba";
                Fila["nombreProveedor"] = Proveedores[Indice];
                Fila["nitProveedor"] = "NIT-" + Convert.ToString(Fila["idProveedor"]);
                Fila["telefonoProveedor"] = "5555-0101";
                Fila["correoProveedor"] = "prueba@example.com";
                Fila["direccionProveedor"] = "Dirección ficticia";
                Fila["nombrePlazo"] = "30 dias";
                Fila["fechaEmisionOrdenCompra"] = new DateTime(2026, Indice == 4 ? 11 : 10, Dias[Indice]);
                Fila["fechaVencimientoOrdenCompra"] = ((DateTime)Fila["fechaEmisionOrdenCompra"]).AddDays(30);
                Fila["tipoCambioOrdenCompra"] = 1.234567M;
                Fila["subtotalOrdenCompra"] = 100.1234M;
                Fila["descuentoOrdenCompra"] = 10M;
                Fila["totalOrdenCompra"] = 90.1234M;
                Fila["estadoProveedor"] = Indice != 4;
                Tabla.Rows.Add(Fila);
            }
            Tabla.AcceptChanges();
            return Tabla;
        }
    }
}
