# Responsabilidades de la solución

Cada clase tiene una responsabilidad descrita en una sola línea en su encabezado de autoría.

| Capa | Clase o contrato | Responsabilidad |
| --- | --- | --- |
| Controlador | `ClsOrdenesCompra` | Expone la API pública de operaciones sobre órdenes de compra. |
| Controlador | `ClsValidacionOrdenesCompra` | Valida los datos recibidos para operar sobre órdenes de compra. |
| Controlador | `ClsEstadosOrdenesCompra` | Define los estados válidos de una orden de compra. |
| Controlador | `ClsFiltroOrdenesCompra` | Filtra las filas de órdenes de compra por texto, estado y fechas. |
| Controlador | `Entidades.ClsOrdenCompra` | Expone los datos de una orden a los consumidores del controlador. |
| Modelo | `IRepositorioOrdenesCompra` | Define el contrato de persistencia de órdenes de compra. |
| Modelo | `ClsRepositorioOrdenesCompra` | Implementa el contrato de persistencia de órdenes de compra. |
| Modelo | `ClsConsultasOrdenesCompra` | Consulta los datos de órdenes de compra y sus catálogos. |
| Modelo | `ClsComandosOrdenesCompra` | Persiste los cambios de las órdenes de compra. |
| Modelo | `ClsRepositorioBaseOrdenesCompra` | Ejecuta operaciones ODBC con la conexión de la DLL de Seguridad. |
| Modelo | `ClsErroresDatosOrdenesCompra` | Traduce errores ODBC a mensajes de órdenes de compra. |
| Modelo | `Entidades.ClsOrdenCompra` | Representa los datos persistidos de una orden de compra. |
| Vista | `FrmEncabezados` | Coordina la consulta y apertura de órdenes desde su listado. |
| Vista | `FrmOrdenesCompra` | Coordina la visualización de una orden de compra seleccionada. |
| Vista | `ClsTablasOrdenesCompra` | Configura las columnas de los DGV de órdenes de compra. |
| Vista | `ClsDisenoDetallesOrdenCompra` | Ajusta la altura del bloque de detalles al contenido de su DGV. |

Los consumidores continúan usando `ClsOrdenesCompra` y sus métodos públicos existentes. Las clases auxiliares nuevas son internas a sus respectivos ensamblados. Los formularios conservan sus constructores y la interacción anterior, incluido el DGV de solo lectura.

La separación distingue las reglas de entrada, los filtros en memoria, las lecturas SQL, las escrituras SQL y la presentación de tablas. Las entidades de modelo y controlador conservan su separación entre capas. La conexión sigue proviniendo de la DLL de Seguridad.

`ClsDisenoDetallesOrdenCompra` libera sus suscripciones a eventos cuando se cierra o se dispone el formulario. Las transacciones y los parámetros SQL mantienen su comportamiento anterior.

Los archivos `.Designer.cs` siguen formando parte de sus formularios mediante clases parciales; separarlos en más archivos no representaría una responsabilidad adicional.
