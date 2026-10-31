# Órdenes de Compra desde Bancos

1. **Prepara el proyecto.** Usa .NET Framework 4.8 y agrega referencia a `CapaControlador_OrdenesCompra.dll`. Distribuye juntas las DLL de controlador, modelo y Seguridad de la misma compilación, y configura el DSN utilizado por Seguridad.

2. **Crea el controlador.**

   ```csharp
   using CapaControlador_OrdenesCompra;

   var ComprasControlador = new ClsOrdenesCompra();
   ```

3. **Consulta las órdenes para tu DGV.**

   | Necesidad | Llamada |
   | --- | --- |
   | Pendientes de revisión | `ComprasControlador.ComprasFuncListar("Pendiente")` |
   | Todas las órdenes | `ComprasControlador.ComprasFuncListar()` |
   | Otro estado | `ComprasControlador.ComprasFuncListar("Autorizada")` |
   | Una orden por PK | `ComprasControlador.ComprasFuncObtener(IdOrden)` |
   | Productos de una orden | `ComprasControlador.ComprasFuncListarDetalles(IdOrden)` |

   Las listas devuelven `DataTable`, que puedes asignar al `DataSource` de tu DGV. Estados disponibles: **Pendiente, Autorizada, Rechazada, Anulada, Recibida**. `"Todos"` también consulta todas.

4. **Aprueba o anula la orden seleccionada.** Obtén `IdOrden` de la columna `idOrdenCompra` de su fila; muestra `codigoOrdenCompra` como código visible.

   | Acción en Bancos | Llamada |
   | --- | --- |
   | Aprobar | `ComprasControlador.ComprasProcCambiarEstado(IdOrden, "Autorizada")` |
   | Anular | `ComprasControlador.ComprasFuncAnular(IdOrden)` |

   En la API, **aprobar corresponde a `Autorizada`**, no a `Aprobada`. La anulación devuelve la orden actualizada y rechaza órdenes recibidas, ya anuladas o con una compra registrada.

5. **Recarga el listado después de la acción**, conservando el filtro elegido. Si estabas mostrando pendientes, la orden aprobada o anulada dejará de aparecer. Captura las excepciones para mostrar el motivo de un fallo y libera las tablas cuando reemplaces los datos o cierres la pantalla. Las llamadas son síncronas: ejecútalas fuera del hilo de interfaz cuando corresponda.

El cambio de estado solo actualiza la orden: no genera pagos, inventario ni cuentas por pagar. Los botones Aprobar y Anular corresponden a la pantalla de Bancos; el DGV de consulta de Compras sigue siendo de solo lectura.
