# Cargar datos de prueba de Compras

1. Usa el esquema `01_modulo_compras_cuentas_por_pagar_v2.sql`. Si tu base existente todavía no tiene `codigoOrdenCompra`, aplica antes `02_agregar_codigo_orden_compra.sql`.
2. Configura los IDs de moneda, método de pago y dos productos distintos que existan en Bancos y Logística. El esquema de Compras no contiene esos catálogos; por defecto el script utiliza moneda 1, método 1 y productos 1 y 2. Puedes asignar `@ComprasIdMoneda`, `@ComprasIdMetodoPago`, `@ComprasIdProducto1` y `@ComprasIdProducto2` en la misma sesión antes de ejecutarlo.
3. Ejecuta `03_datos_prueba_compras.sql` deteniendo la ejecución ante errores. Los registros usan códigos `PRUEBA-OC-*` y NIT `9900000001` a `9900000004`. No borra ni sobrescribe registros existentes; al repetirlo agrega únicamente los que falten. No restablece los cambios realizados durante tus pruebas. Si ocurre un error antes del `COMMIT`, ejecuta `ROLLBACK`.
4. Para Bancos, las órdenes `PRUEBA-OC-001`, `002`, `003` y `012` son pendientes con proveedores activos: sirven para probar aprobación y anulación. La `011` pertenece a un proveedor inactivo; las `008` a `010` están recibidas y tienen compras registradas, por lo que no pueden anularse.
5. Revisa las consultas finales y prueba la API con los PK devueltos, no con los números del código visible.

| Datos | Cantidad inicial |
| --- | ---: |
| Proveedores, uno inactivo | 4 |
| Órdenes: 5 pendientes, 2 autorizadas, 1 rechazada, 1 anulada y 3 recibidas | 12 |
| Detalles de órdenes | 24 |
| Compras / detalles de compras | 3 / 6 |
| Cuentas por pagar: 2 pendientes, 1 parcial y 1 pagada | 4 |
| Devolución / detalle | 1 / 1 |
| Pagos: 2 pagados, 1 programado, 1 rechazado y 1 anulado | 5 |
| Aplicaciones de pagos / solicitudes a Bancos | 2 / 5 |

Los importes de prueba están expresados en una sola moneda, con tipo de cambio 1. La orden 001 combina descuento por producto y descuento del encabezado; la 012 utiliza cuatro decimales. Para el proveedor 2, la cuenta de 1000 queda con saldo 500 después de un pago de 400 y una devolución de 100. Los resúmenes de proveedor se inicializan para estos datos; una nueva ejecución no recalcula saldos modificados por otros procesos.
