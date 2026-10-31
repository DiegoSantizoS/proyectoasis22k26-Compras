using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_OrdenesCompra;
using CapaVista_OrdenesCompra;
using CapaVista_Componentes.Componentes;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diego Fernando Santizo Samayoa
 * Carné : 0901-22-15950
 * Fecha : 30/10/2026
 * ==================================================================
 * Propósito :
 *  Verifica el listado de órdenes mediante una vista oculta con datos en memoria.
 * ===================================================================
*/

/*
 * EXPLICACION TEMPORAL DE LA CLASE
 * Ejecuta un formulario oculto en un hilo STA y lo conecta al repositorio en memoria. Verifica las columnas
 * de solo lectura, el filtro por estado, el código visible, el manejo de errores, el ajuste de filas y la
 * liberacion de eventos. Espera las tareas mediante un limite de tiempo, registra fallos con un código de
 * salida y genera una captura con datos de prueba. No inicia sesion contra Seguridad ni modifica la base
 * real.
 */
internal static class ValidarVistaOrdenesCompra
{
    private static int _Pruebas;

    /// <summary>
    /// Recupera por reflexion un campo privado de un objeto y lo convierte al tipo pedido para inspeccionar la
    /// vista durante las pruebas.
    /// </summary>
    private static T ComprasFuncCampo<T>(object Vista, string Nombre)
    {
        return (T)Vista.GetType().GetField(Nombre, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(Vista);
    }

    /// <summary>
    /// Incrementa el contador si la condición se cumple; si falla, detiene la prueba con una excepción.
    /// </summary>
    private static void ComprasProcVerificar(bool Condicion)
    {
        if (!Condicion) throw new Exception("Fallo de vista en prueba " + (_Pruebas + 1));
        _Pruebas++;
    }

    /// <summary>
    /// Espera con pausas asíncronas hasta que se cumpla la condición; falla despues de diez segundos para evitar
    /// pruebas bloqueadas.
    /// </summary>
    private static async Task ComprasProcEsperarAsync(Func<bool> Listo)
    {
        DateTime Limite = DateTime.UtcNow.AddSeconds(10);
        while (!Listo())
        {
            if (DateTime.UtcNow > Limite) throw new TimeoutException("La vista no termino la operacion.");
            await Task.Delay(20);
        }
    }

    [STAThread]
    /// <summary>
    /// Inicia WinForms en STA, muestra una ventana invisible con datos simulados y verifica consulta, controles
    /// y diseño; genera una captura, comunica errores por el código de salida y cierra la ventana.
    /// </summary>
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        using (DataTable Datos = ValidarOrdenesCompra.ComprasFuncDatos())
        using (var Vista = new FrmEncabezados(new ClsOrdenesCompra(new ValidarOrdenesCompra.RepositorioPrueba(Datos))))
        {
            var Controlador = ComprasFuncCampo<ClsOrdenesCompra>(Vista, "_Controlador");
            var Repositorio = (ValidarOrdenesCompra.RepositorioPrueba)typeof(ClsOrdenesCompra)
                .GetField("_Repositorio", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(Controlador);
            Vista.Opacity = 0;
            Vista.ShowInTaskbar = false;
            Vista.Shown += async (Remitente, Evento) =>
            {
                try
                {
                    var Dgv = ComprasFuncCampo<ComprasUsrDataGridView>(Vista, "ComprasDgvEncabezados");
                    var Tabla = Dgv.Tabla;
                    var Estado = ComprasFuncCampo<ComprasUsrComboBox>(Vista, "ComprasCboEstado");
                    var Resultado = ComprasFuncCampo<ComprasUsrLabel>(Vista, "ComprasLblResultado");
                    await ComprasProcEsperarAsync(() => !ComprasFuncCampo<bool>(Vista, "_Cargando"));
                    ComprasProcVerificar(Tabla.Rows.Count == 5);
                    ComprasProcVerificar(!Tabla.Columns.Contains("ComprasColNuevoEstado"));
                    ComprasProcVerificar(!Tabla.Columns.Contains("ComprasColCambiarEstado"));
                    ComprasProcVerificar(Tabla.ReadOnly);
                    ComprasProcVerificar(Tabla.Columns["ComprasColcodigoOrdenCompra"].DataPropertyName == "codigoOrdenCompra");
                    ComprasProcVerificar(Convert.ToString(Tabla.Rows[0].Cells["ComprasColcodigoOrdenCompra"].Value) == "OC-2026-001");
                    object DisenoDetalles;
                    using (var Detalle = new FrmOrdenesCompra(Controlador.ComprasFuncObtener(1), Controlador))
                    {
                        var Codigo = ComprasFuncCampo<ComprasUsrTextBox>(Detalle, "ComprasTxtCodigoOrden");
                        ComprasProcVerificar(Codigo.Text == "OC-2026-001" && !Codigo.Enabled && Codigo.MaxLength == 30);
                        DisenoDetalles = ComprasFuncCampo<object>(Detalle, "_DisenoDetalles");
                        var Productos = ComprasFuncCampo<ComprasUsrDataGridView>(Detalle, "ComprasDgvProductos").Tabla;
                        var Distribucion = ComprasFuncCampo<TableLayoutPanel>(Detalle, "ComprasTlpDetalles");
                        ComprasProcVerificar(Productos.Columns.Count == 5 && Productos.ReadOnly);
                        Productos.Rows.Add(3);
                        float AlturaConFilas = Distribucion.RowStyles[1].Height;
                        ComprasProcVerificar(Productos.Rows.Count == 3 && Productos.Rows[0].MinimumHeight == 40);
                        Productos.Rows.Clear();
                        ComprasProcVerificar(Distribucion.RowStyles[1].Height < AlturaConFilas);
                    }
                    ComprasProcVerificar(ComprasFuncCampo<bool>(DisenoDetalles, "_Liberado"));
                    Estado.SelectedIndex = 1;
                    await ComprasProcEsperarAsync(() => !ComprasFuncCampo<bool>(Vista, "_Cargando"));
                    ComprasProcVerificar(Repositorio.EstadoConsultado == "Pendiente" && Tabla.Rows.Count == 1);
                    Estado.SelectedIndex = 2;
                    await ComprasProcEsperarAsync(() => !ComprasFuncCampo<bool>(Vista, "_Cargando"));
                    ComprasProcVerificar(Tabla.Rows.Count == 1 && Repositorio.EstadoConsultado == "Autorizada");
                    Repositorio.RechazarConsulta = true;
                    Estado.SelectedIndex = 3;
                    await ComprasProcEsperarAsync(() => !ComprasFuncCampo<bool>(Vista, "_Cargando"));
                    ComprasProcVerificar(Tabla.Rows.Count == 0 && Resultado.Texto.Contains("Consulta rechazada"));
                    Repositorio.RechazarConsulta = false;
                    Estado.SelectedIndex = 0;
                    await ComprasProcEsperarAsync(() => !ComprasFuncCampo<bool>(Vista, "_Cargando"));
                    ComprasProcVerificar(Tabla.Rows.Count == 5);
                    var Contenido = ComprasFuncCampo<Panel>(Vista, "ComprasPnlContenido");
                    using (var Captura = new Bitmap(Contenido.Width, Contenido.Height))
                    {
                        Contenido.DrawToBitmap(Captura, new Rectangle(Point.Empty, Contenido.Size));
                        Captura.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VistaOrdenesCompra.png"), ImageFormat.Png);
                    }
                    Console.WriteLine(_Pruebas + " pruebas de vista correctas.");
                }
                catch (Exception Error)
                {
                    Console.Error.WriteLine(Error);
                    Environment.ExitCode = 1;
                }
                finally { Vista.Close(); }
            };
            Application.Run(Vista);
        }
    }
}

