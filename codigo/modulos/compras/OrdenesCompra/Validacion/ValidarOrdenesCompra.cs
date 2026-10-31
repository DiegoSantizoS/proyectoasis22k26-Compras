using System;
using System.Data;
using CapaControlador_OrdenesCompra;
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
 *  Verifica la API del controlador mediante un repositorio en memoria.
 * ===================================================================
*/

/*
 * EXPLICACION TEMPORAL DE LA CLASE
 * Ejecuta comprobaciones del controlador con datos en memoria para verificar consultas, estados, filtros,
 * fechas, importes y código identificador. Cada condición o excepción esperada incrementa un contador; una
 * diferencia produce una excepción y hace fallar la ejecucion. El repositorio anidado simula la
 * persistencia para no depender de un DSN. Estas pruebas no demuestran la conexión, las transacciones ni
 * las restricciones reales del servidor SQL.
 */

internal static class ValidarOrdenesCompra
{
    private static int _Pruebas;

    /// <summary>
    /// Incrementa el contador si la condición se cumple; si falla, detiene la prueba con una excepción.
    /// </summary>
    private static void ComprasProcVerificar(bool Condicion)
    {
        if (!Condicion) throw new Exception("Falló la prueba " + (_Pruebas + 1));
        _Pruebas++;
    }

    /// <summary>
    /// Ejecuta una acción y comprueba que lance el tipo de excepción esperado; cuenta el acierto o falla si no
    /// se lanza.
    /// </summary>
    private static void ComprasProcRechazar<T>(Action Operacion) where T : Exception
    {
        try { Operacion(); }
        catch (T) { _Pruebas++; return; }
        throw new Exception("Se esperaba " + typeof(T).Name);
    }

    /// <summary>
    /// Crea una tabla de prueba con las columnas del encabezado y cinco órdenes en los cinco estados válidos; no
    /// consulta la base real.
    /// </summary>
    internal static DataTable ComprasFuncDatos()
    {
        var Datos = new DataTable();
        Datos.Columns.Add("idOrdenCompra", typeof(int));
        Datos.Columns.Add("codigoOrdenCompra", typeof(string));
        Datos.Columns.Add("idProveedor", typeof(int));
        Datos.Columns.Add("idPlazo", typeof(int));
        Datos.Columns.Add("idMoneda", typeof(int));
        Datos.Columns.Add("fechaEmisionOrdenCompra", typeof(DateTime));
        Datos.Columns.Add("fechaVencimientoOrdenCompra", typeof(DateTime));
        Datos.Columns.Add("tipoCambioOrdenCompra", typeof(decimal));
        Datos.Columns.Add("subtotalOrdenCompra", typeof(decimal));
        Datos.Columns.Add("descuentoOrdenCompra", typeof(decimal));
        Datos.Columns.Add("totalOrdenCompra", typeof(decimal));
        foreach (string Campo in new[] { "comentarioOrdenCompra", "estadoOrdenCompra", "nombreProveedor",
            "nitProveedor", "telefonoProveedor", "correoProveedor", "direccionProveedor", "nombrePlazo" })
            Datos.Columns.Add(Campo, typeof(string));
        Datos.Columns.Add("estadoProveedor", typeof(bool));
        Datos.Columns.Add("diasPlazo", typeof(int));
        foreach (string Estado in new[] { "Pendiente", "Autorizada", "Rechazada", "Anulada", "Recibida" })
        {
            Datos.Rows.Add(Datos.Rows.Count + 1, "OC-2026-" + (Datos.Rows.Count + 1).ToString("D3"), 3, 2, 1, new DateTime(2026, 10, 1), new DateTime(2026, 10, 31),
                1.234567M, 100.1234M, 10M, 90.1234M, "Prueba", Estado, "José", "123", "456", "a@b.c", "Dirección", "30 días", true, 30);
        }
        return Datos;
    }

    /// <summary>
    /// Construye el controlador con el repositorio en memoria y ejecuta las comprobaciones de API, código,
    /// filtros, importes y fechas; imprime el número de pruebas aprobadas.
    /// </summary>
    private static void Main()
    {
        using (var Datos = ComprasFuncDatos())
        {
            var Repositorio = new RepositorioPrueba(Datos);
            var Controlador = new ClsOrdenesCompra(Repositorio);
            using (var Todas = Controlador.ComprasFuncListar())
                ComprasProcVerificar(Todas.Rows.Count == 5);
            using (var Todas = Controlador.ComprasFuncListar(" Todos "))
                ComprasProcVerificar(Todas.Rows.Count == 5);
            using (var Todas = Controlador.ComprasFuncListar(null))
                ComprasProcVerificar(Todas.Rows.Count == 5);
            using (var Pendientes = Controlador.ComprasFuncListar(" pendiente "))
                ComprasProcVerificar(Pendientes.Rows.Count == 1);
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncListar("Pagada"));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasProcCambiarEstado(1, "Todos"));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasProcCambiarEstado(1, null));
            ComprasProcRechazar<ArgumentOutOfRangeException>(() => Controlador.ComprasProcCambiarEstado(0, "Autorizada"));
            ComprasProcRechazar<InvalidOperationException>(() => Controlador.ComprasProcCambiarEstado(99, "Autorizada"));
            Controlador.ComprasProcCambiarEstado(1, " autorizada ");
            ComprasProcVerificar(Controlador.ComprasFuncObtener(1).Estado == "Autorizada");
            Controlador.ComprasProcCambiarEstado(1, "Autorizada");
            ComprasProcVerificar(Controlador.ComprasFuncObtener(1).Estado == "Autorizada");
            Controlador.ComprasProcCambiarEstado(1, "Pendiente");
            foreach (string Estado in new[] { "Pendiente", "Autorizada", "Rechazada", "Anulada", "Recibida" })
            {
                using (var Resultado = Controlador.ComprasFuncFiltrar(Datos, "jose", Estado, null, null))
                    ComprasProcVerificar(Resultado.Rows.Count == 1);
            }
            using (var Resultado = Controlador.ComprasFuncFiltrar(Datos, "2", "Todos", null, null))
                ComprasProcVerificar(Resultado.Rows.Count == 5);
            using (var Resultado = Controlador.ComprasFuncFiltrar(Datos, "", "Todos", new DateTime(2026, 10, 2), new DateTime(2026, 10, 30)))
                ComprasProcVerificar(Resultado.Rows.Count == 0);
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncFiltrar(Datos, "", "Pagada", null, null));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncFiltrar(Datos, "", "Todos", DateTime.Today, null));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncFiltrar(Datos, "", "Todos", DateTime.Today, DateTime.Today.AddDays(-1)));
            ComprasProcRechazar<ArgumentOutOfRangeException>(() => Controlador.ComprasFuncObtener(0));
            using (var Resultado = Controlador.ComprasFuncFiltrar(Datos, "oc-2026-003", "Todos", null, null))
                ComprasProcVerificar(Resultado.Rows.Count == 1 && Convert.ToInt32(Resultado.Rows[0]["idOrdenCompra"]) == 3);
            var Orden = Controlador.ComprasFuncObtener(1);
            ComprasProcVerificar(Orden.CodigoOrdenCompra == "OC-2026-001" && Orden.NumeroOrden == Orden.CodigoOrdenCompra);
            ComprasProcVerificar(Orden.IdOrdenCompra == 1 && Orden.Subtotal == 100.1234M && Orden.Descuento == 10M);
            ComprasProcVerificar(Orden.NombrePlazo == "30 días" && Orden.TipoCambio == 1.234567M && Orden.Comentario == "Prueba");
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasProcActualizarVencimiento(1, new DateTime(2026, 9, 30)));
            Controlador.ComprasProcActualizarVencimiento(1, new DateTime(2026, 11, 1));
            ComprasProcVerificar(Repositorio.Vencimiento == new DateTime(2026, 11, 1));
            Datos.Rows[0]["estadoOrdenCompra"] = "Recibida";
            ComprasProcRechazar<InvalidOperationException>(() => Controlador.ComprasProcActualizarVencimiento(1, DateTime.Today));
            ComprasProcRechazar<ArgumentOutOfRangeException>(() => Controlador.ComprasFuncCrear("OC-2026-001", 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100M, 101M, ""));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncCrear("OC-2026-001", 1, 1, 1, DateTime.Today, DateTime.Today, 0M, 100M, 0M, ""));
            ComprasProcRechazar<ArgumentOutOfRangeException>(() => Controlador.ComprasFuncCrear("OC-2026-001", 1, 1, 1, DateTime.Today, DateTime.Today, 1.0000001M, 100M, 0M, ""));
            ComprasProcRechazar<ArgumentOutOfRangeException>(() => Controlador.ComprasFuncCrear("OC-2026-001", 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100.00001M, 0M, ""));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncCrear("OC-2026-001", 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100M, 0M, new string('x', 501)));
            ComprasProcVerificar(Controlador.ComprasFuncCrear("OC-2026-001", 1, 1, 1, DateTime.Today, DateTime.Today, 1.123456M, 99999999.9999M, 0M, " prueba ") == 42);
            ComprasProcVerificar(Repositorio.Comentario == "prueba");
            ComprasProcVerificar(Repositorio.CodigoCreado == "OC-2026-001");
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncCrear(null, 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100M, 0M, ""));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncCrear("   ", 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100M, 0M, ""));
            ComprasProcRechazar<ArgumentException>(() => Controlador.ComprasFuncCrear(new string('A', 31), 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100M, 0M, ""));
            Controlador.ComprasFuncCrear("  000-OC-001  ", 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100M, 0M, "");
            ComprasProcVerificar(Repositorio.CodigoCreado == "000-OC-001");
            Controlador.ComprasFuncCrear(new string('A', 30), 1, 1, 1, DateTime.Today, DateTime.Today, 1M, 100M, 0M, "");
            ComprasProcVerificar(Repositorio.CodigoCreado.Length == 30);
            Datos.Rows[0]["estadoOrdenCompra"] = "Pendiente";
            ComprasProcVerificar(Controlador.ComprasFuncAnular(1).Estado == "Anulada");
        }
        Console.WriteLine(_Pruebas + " pruebas correctas.");
    }

    /*
     * ==================================================================
     * Área : Compras
     * Autor : Diego Fernando Santizo Samayoa
     * Carné : 0901-22-15950
     * Fecha : 24/10/2026
     * ==================================================================
     * Propósito :
     *  Simula el contrato de persistencia para las pruebas del controlador.
     * ===================================================================
    */

    /*
     * EXPLICACION TEMPORAL DE LA CLASE
     * Conserva las filas de prueba y simula consultas y escrituras del contrato IRepositorioOrdenesCompra.
     * Expone indicadores para provocar errores y propiedades para inspeccionar los argumentos recibidos. No
     * reproduce bloqueos, transacciones ni todas las reglas SQL; su objetivo es aislar el comportamiento del
     * controlador.
     */
    internal sealed class RepositorioPrueba : IRepositorioOrdenesCompra
    {
        private readonly DataTable _Datos;
        public string EstadoConsultado { get; private set; }
        public bool RechazarCambio { get; set; }
        public bool RechazarConsulta { get; set; }
        public DateTime Vencimiento { get; private set; }
        public string Comentario { get; private set; }
        public string CodigoCreado { get; private set; }
        /// <summary>
        /// Guarda la tabla recibida para simular el repositorio; no abre ninguna conexión.
        /// </summary>
        public RepositorioPrueba(DataTable Datos) { _Datos = Datos; }
        /// <summary>
        /// Devuelve una copia de todas las filas en memoria para que la prueba pueda liberarla sin afectar el
        /// origen.
        /// </summary>
        public DataTable ComprasFuncListar() => _Datos.Copy();
        /// <summary>
        /// Registra el estado solicitado y copia solo las filas coincidentes; permite simular un fallo de consulta.
        /// </summary>
        public DataTable ComprasFuncListar(string Estado)
        {
            EstadoConsultado = Estado;
            if (RechazarConsulta)
                throw new InvalidOperationException("Consulta rechazada para la prueba.");
            var Resultado = _Datos.Clone();
            foreach (DataRow Fila in _Datos.Rows)
                if (Convert.ToString(Fila["estadoOrdenCompra"]) == Estado)
                    Resultado.ImportRow(Fila);
            return Resultado;
        }
        /// <summary>
        /// Modifica el estado en la tabla de prueba o lanza el error simulado; no comprueba todas las restricciones
        /// de la base real.
        /// </summary>
        public void ComprasProcCambiarEstado(int Id, string Estado)
        {
            if (RechazarCambio)
                throw new InvalidOperationException("Cambio rechazado para la prueba.");
            if (Id > _Datos.Rows.Count)
                throw new InvalidOperationException("La orden de compra no existe.");
            _Datos.Rows[Id - 1]["estadoOrdenCompra"] = Estado;
        }
        /// <summary>
        /// Devuelve una tabla vacía como sustituto de la consulta de productos en estas pruebas.
        /// </summary>
        public DataTable ComprasFuncListarDetalles(int Id) => new DataTable();
        /// <summary>
        /// Devuelve una tabla vacía como sustituto de la consulta de proveedores en estas pruebas.
        /// </summary>
        public DataTable ComprasFuncListarProveedores() => new DataTable();
        /// <summary>
        /// Materializa la entidad desde la fila de prueba cuya posición corresponde al ID recibido.
        /// </summary>
        public ClsOrdenCompra ComprasFuncObtener(int Id) => new ClsOrdenCompra(_Datos.Rows[Id - 1]);
        /// <summary>
        /// Asigna Anulada a la fila en memoria para simular la operación del repositorio.
        /// </summary>
        public void ComprasProcAnular(int Id) { _Datos.Rows[Id - 1]["estadoOrdenCompra"] = "Anulada"; }
        /// <summary>
        /// Guarda la fecha recibida en la propiedad de prueba para comprobar la llamada del controlador.
        /// </summary>
        public void ComprasProcActualizarVencimiento(int Id, DateTime Fecha) { Vencimiento = Fecha; }
        /// <summary>
        /// Registra el código y comentario recibidos para verificar su normalización y devuelve el PK simulado 42;
        /// no inserta una orden real.
        /// </summary>
        public int ComprasFuncCrear(string CodigoOrdenCompra, int IdProveedor, int IdPlazo, int IdMoneda, DateTime Emision,
            DateTime Vencimiento, decimal TipoCambio, decimal Subtotal, decimal Descuento, string Comentario)
        {
            CodigoCreado = CodigoOrdenCompra;
            this.Comentario = Comentario;
            return 42;
        }
    }
}
