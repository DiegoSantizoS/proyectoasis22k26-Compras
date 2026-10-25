using System;
using System.Data;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo_OrdenesCompra;
using CapaControlador_OrdenesCompra;
using CapaVista_OrdenesCompra;
using CapaVista_Componentes.Componentes;

public sealed class RepositorioEncabezadosPrueba : IRepositorioComprasPorPagar
{
    public readonly DataTable Datos = new DataTable();
    public int Creaciones;
    public RepositorioEncabezadosPrueba()
    {
        foreach (string Campo in new[] { "idCuentaPorPagar", "idProveedor" }) Datos.Columns.Add(Campo, typeof(int));
        foreach (string Campo in new[] { "numeroFacturaCuentaPorPagar", "estadoCuentaPorPagar", "nombreProveedor",
            "nitProveedor", "telefonoProveedor", "correoProveedor", "direccionProveedor" }) Datos.Columns.Add(Campo);
        Datos.Columns.Add("fechaEmisionCuentaPorPagar", typeof(DateTime));
        Datos.Columns.Add("fechaVencimientoCuentaPorPagar", typeof(DateTime));
        Datos.Columns.Add("montoTotalCuentaPorPagar", typeof(decimal));
        Datos.Columns.Add("saldoCuentaPorPagar", typeof(decimal));
        Datos.Columns.Add("estadoProveedor", typeof(bool));
        var Fila = Datos.NewRow();
        Fila["idCuentaPorPagar"] = 1; Fila["idProveedor"] = 3;
        Fila["numeroFacturaCuentaPorPagar"] = "FAC-001"; Fila["estadoCuentaPorPagar"] = "Pendiente";
        Fila["nombreProveedor"] = "Carnes Álvarez"; Fila["nitProveedor"] = "9900000001";
        Fila["telefonoProveedor"] = "5550-0101"; Fila["correoProveedor"] = "prueba@example.com";
        Fila["direccionProveedor"] = "Zona 1"; Fila["estadoProveedor"] = false;
        Fila["fechaEmisionCuentaPorPagar"] = new DateTime(2026, 10, 1);
        Fila["fechaVencimientoCuentaPorPagar"] = new DateTime(2026, 10, 31);
        Fila["montoTotalCuentaPorPagar"] = 1250.1234M; Fila["saldoCuentaPorPagar"] = 500.1234M;
        Datos.Rows.Add(Fila);
    }
    public DataTable Listar() { return Datos.Copy(); }
    public DataTable Obtener(int Id) { return Id == 1 ? Datos.Copy() : Datos.Clone(); }
    public DataTable ListarProveedores() { return Datos.Clone(); }
    public void Anular(int Id) { Datos.Rows[0]["estadoCuentaPorPagar"] = "Anulada"; }
    public void ActualizarVencimiento(int Id, DateTime Fecha) { Datos.Rows[0]["fechaVencimientoCuentaPorPagar"] = Fecha; }
    public int Crear(int Id, string Factura, DateTime Emision, DateTime Vencimiento, decimal Monto) { Creaciones++; return 2; }
}

public static class ValidarEncabezados
{
    static int Comprobaciones;
    static void Verificar(bool Condicion, string Mensaje)
    {
        if (!Condicion) throw new Exception(Mensaje);
        Comprobaciones++;
    }
    static T Campo<T>(object Objeto, string Nombre)
    {
        return (T)Objeto.GetType().GetField(Nombre, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(Objeto);
    }
    static object Invocar(object Objeto, string Nombre, params object[] Argumentos)
    {
        return Objeto.GetType().GetMethod(Nombre, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Objeto, Argumentos);
    }
    static void Esperar(Task Tarea)
    {
        var Limite = DateTime.UtcNow.AddSeconds(10);
        while (!Tarea.IsCompleted && DateTime.UtcNow < Limite) Application.DoEvents();
        if (!Tarea.IsCompleted) throw new TimeoutException();
        Tarea.GetAwaiter().GetResult();
    }
    [STAThread]
    public static void Main()
    {
        var Repositorio = new RepositorioEncabezadosPrueba();
        var Controlador = new ClsComprasPorPagar(Repositorio);
        using (var Nueva = new FrmOrdenesCompra(null, Controlador))
        {
            var Emision = Campo<ClsDatePickerCompras>(Nueva, "clsDatePickerCompras1");
            var Vencimiento = Campo<ClsDatePickerCompras>(Nueva, "clsDatePickerCompras2");
            Verificar(Emision.Value.Date == DateTime.Today, "Emision nueva incorrecta.");
            Verificar(Vencimiento.Value.Date == DateTime.Today.AddMonths(3), "Vencimiento inicial incorrecto.");
            Emision.Value = new DateTime(2026, 11, 30);
            Verificar(Vencimiento.Value.Date == new DateTime(2027, 2, 28), "Vencimiento al cambiar emision incorrecto.");
            Emision.Value = new DateTime(2027, 11, 30);
            Verificar(Vencimiento.Value.Date == new DateTime(2028, 2, 29), "Vencimiento en anio bisiesto incorrecto.");
            Verificar(!Campo<Button>(Nueva, "clsButtonCompras2").Enabled, "La orden nueva permite guardar.");
            Verificar(Campo<UsrDataGridViewCompras>(Nueva, "ComprasUsrProductos").Rows.Count == 0, "Hay productos de ejemplo.");
            Verificar(Campo<UsrTextBoxCompras>(Nueva, "ComprasTxtNumeroDeFacturaValor").Text == "", "La factura nueva no está vacía.");
            Verificar(!Campo<Control>(Nueva, "ComprasTlpMantenimientoProductos").Enabled, "Productos habilitados.");
        }
        foreach (string Estado in new[] { "Pendiente", "Parcial", "Pagada", "Anulada" })
        {
            Repositorio.Datos.Rows[0]["estadoCuentaPorPagar"] = Estado;
            using (var Orden = new FrmOrdenesCompra(Controlador.Obtener(1), Controlador))
            {
                Verificar(Campo<Button>(Orden, "ComprasBtnDescartar").Enabled, "No permite anular " + Estado);
                Verificar(Campo<UsrLabelCompras>(Orden, "ComprasLblEstadoValor").Texto == Estado, "Estado incorrecto.");
                Verificar(Campo<UsrComboBoxCompras>(Orden, "ComprasCboNombreProveedor").Text == "Carnes Álvarez", "Proveedor inactivo oculto.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtNitProveedor").Text == "9900000001", "NIT incorrecto.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtEstadoProveedor").Text == "Inactivo", "Estado del proveedor incorrecto.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtNumeroDeFacturaValor").Text == "FAC-001", "Factura incorrecta.");
                Verificar(Campo<ClsDatePickerCompras>(Orden, "clsDatePickerCompras1").Value.Date == new DateTime(2026, 10, 1), "Emision incorrecta.");
                Verificar(Campo<ClsDatePickerCompras>(Orden, "clsDatePickerCompras2").Value.Date == new DateTime(2026, 10, 31), "Vencimiento incorrecto.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtSaldoPendienteValor").Text == 500.1234M.ToString("N4"), "Saldo incorrecto.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtTelefonoProveedor").Text == "5550-0101", "Telefono incorrecto.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtCorreoProveedor").Text == "prueba@example.com", "Correo incorrecto.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtDireccionProveedor").Text == "Zona 1", "Direccion incorrecta.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtTotalDeLaOrden").Text == 1250.1234M.ToString("N4"), "Monto incorrecto.");
                Verificar(!Campo<Button>(Orden, "clsButtonCompras2").Enabled, "Permite guardar sin productos.");
            }
            Verificar(Controlador.Anular(1).Estado == "Anulada", "Falló la anulación desde " + Estado);
        }
        Repositorio.Datos.Rows[0]["estadoCuentaPorPagar"] = "Parcial";
        using (var Encabezados = new FrmEncabezados(Controlador))
        {
            Esperar((Task)Invocar(Encabezados, "ComprasProcCargarDatosAsync"));
            Verificar(Campo<UsrDataGridViewCompras>(Encabezados, "ComprasDgvEncabezados").Rows.Count == 1, "No carga lista.");
            var Buscar = Campo<UsrTextBoxCompras>(Encabezados, "ComprasTxtBuscar");
            Buscar.Text = "factura inexistente";
            Verificar(Campo<bool>(Buscar, "_ErrorVisible"), "No muestra error sin coincidencias.");
            Buscar.Text = "FAC-001";
            Verificar(!Campo<bool>(Buscar, "_ErrorVisible"), "No limpia error con coincidencias.");
            Buscar.Text = "factura inexistente";
            Buscar.Text = string.Empty;
            Verificar(!Campo<bool>(Buscar, "_ErrorVisible"), "No limpia error al borrar busqueda.");
            Campo<UsrTextBoxCompras>(Encabezados, "ComprasTxtBuscar").Text = "alvarez";
            Verificar(Campo<UsrDataGridViewCompras>(Encabezados, "ComprasDgvEncabezados").Rows.Count == 1, "Búsqueda sin acentos.");
            Campo<UsrComboBoxCompras>(Encabezados, "ComprasCboEstado").Text = "Pagada";
            Verificar(Campo<UsrDataGridViewCompras>(Encabezados, "ComprasDgvEncabezados").Rows.Count == 0, "Filtro por estado.");
            Campo<UsrComboBoxCompras>(Encabezados, "ComprasCboEstado").Text = "Todos";
            Repositorio.Datos.Rows[0]["nombreProveedor"] = "Proveedor actualizado";
            Repositorio.Datos.Rows[0]["saldoCuentaPorPagar"] = 10M;
            Invocar(Encabezados, "ComprasProcAbrirCompra", null, new DataGridViewCellEventArgs(0, 0));
            var Limite = DateTime.UtcNow.AddSeconds(10);
            while (!Encabezados.AbrirOrden && DateTime.UtcNow < Limite) Application.DoEvents();
            Verificar(Encabezados.AbrirOrden, "No solicita abrir orden.");
            using (var Orden = Encabezados.CrearOrdenSeleccionada())
            {
                Verificar(Campo<UsrComboBoxCompras>(Orden, "ComprasCboNombreProveedor").Text == "Proveedor actualizado", "Abre datos obsoletos.");
                Verificar(Campo<UsrTextBoxCompras>(Orden, "ComprasTxtSaldoPendienteValor").Text == 10M.ToString("N4"), "Saldo obsoleto.");
            }
        }
        using (var Encabezados = new FrmEncabezados(Controlador))
        {
            Invocar(Encabezados, "ComprasProcNuevaOrden", null, EventArgs.Empty);
            Verificar(Encabezados.AbrirOrden, "Nueva orden no navega.");
            using (var Nueva = Encabezados.CrearOrdenSeleccionada())
                Verificar(Campo<UsrTextBoxCompras>(Nueva, "ComprasTxtNumeroDeFacturaValor").Text == "", "Nueva orden reutiliza datos.");
        }
        Verificar(Controlador.Filtrar(Repositorio.Listar(), "", "Todos", new DateTime(2026, 10, 2), new DateTime(2026, 10, 31)).Rows.Count == 0, "Filtro de fechas.");
        Verificar(Repositorio.Creaciones == 0, "Se guardó una orden sin productos.");
        Console.WriteLine(Comprobaciones + " comprobaciones correctas.");
    }
}
