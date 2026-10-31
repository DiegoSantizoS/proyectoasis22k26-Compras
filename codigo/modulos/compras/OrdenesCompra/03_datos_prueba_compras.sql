USE `dbsistemaembutidos`;
SET NAMES utf8mb4;

SET @ComprasIdMoneda = COALESCE(@ComprasIdMoneda, 1);
SET @ComprasIdMetodoPago = COALESCE(@ComprasIdMetodoPago, 1);
SET @ComprasIdProducto1 = COALESCE(@ComprasIdProducto1, 1);
SET @ComprasIdProducto2 = COALESCE(@ComprasIdProducto2, 2);
SET @ComprasFechaPrueba = CURDATE();

DROP TEMPORARY TABLE IF EXISTS tmpComprasParametrosPrueba;
CREATE TEMPORARY TABLE tmpComprasParametrosPrueba (
    idMoneda INT NOT NULL CHECK (idMoneda > 0),
    idMetodoPago INT NOT NULL CHECK (idMetodoPago > 0),
    idProducto1 INT NOT NULL CHECK (idProducto1 > 0),
    idProducto2 INT NOT NULL CHECK (idProducto2 > 0),
    CHECK (idProducto1 <> idProducto2)
);
INSERT INTO tmpComprasParametrosPrueba VALUES
(@ComprasIdMoneda, @ComprasIdMetodoPago, @ComprasIdProducto1, @ComprasIdProducto2);

DROP TEMPORARY TABLE IF EXISTS tmpComprasProveedoresPrueba;
DROP TEMPORARY TABLE IF EXISTS tmpComprasOrdenesPrueba;

CREATE TEMPORARY TABLE tmpComprasProveedoresPrueba (
    nit CHAR(10) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    activo BOOLEAN NOT NULL,
    cargos DECIMAL(12,4) NOT NULL,
    abonos DECIMAL(12,4) NOT NULL
);

INSERT INTO tmpComprasProveedoresPrueba (nit, nombre, activo, cargos, abonos) VALUES
('9900000001', '[PRUEBA] Distribuidora Cárnica', 1, 1200.0000, 0.0000),
('9900000002', '[PRUEBA] Empaques del Valle', 1, 1000.0000, 500.0000),
('9900000003', '[PRUEBA] Insumos del Centro', 1, 1000.0000, 1000.0000),
('9900000004', '[PRUEBA] Proveedor Inactivo', 0, 0.0000, 0.0000);

CREATE TEMPORARY TABLE tmpComprasOrdenesPrueba (
    codigo VARCHAR(30) PRIMARY KEY,
    nit CHAR(10) NOT NULL,
    plazo VARCHAR(100) NOT NULL,
    diasEmision INT NOT NULL,
    diasCredito INT NOT NULL,
    cantidad1 DECIMAL(12,4) NOT NULL,
    costo1 DECIMAL(12,4) NOT NULL,
    cantidad2 DECIMAL(12,4) NOT NULL,
    costo2 DECIMAL(12,4) NOT NULL,
    descuento2 DECIMAL(5,2) NOT NULL,
    descuentoOrden DECIMAL(12,4) NOT NULL,
    estado VARCHAR(30) NOT NULL
);

INSERT INTO tmpComprasOrdenesPrueba
(codigo, nit, plazo, diasEmision, diasCredito, cantidad1, costo1,
 cantidad2, costo2, descuento2, descuentoOrden, estado) VALUES
('PRUEBA-OC-001', '9900000001', '30 dias', 0, 30, 10, 80, 4, 50, 10, 30, 'Pendiente'),
('PRUEBA-OC-002', '9900000002', '30 dias', -40, 30, 10, 80, 4, 50, 0, 0, 'Pendiente'),
('PRUEBA-OC-003', '9900000003', '15 dias', -10, 15, 10, 80, 4, 50, 0, 0, 'Pendiente'),
('PRUEBA-OC-004', '9900000001', '30 dias', -2, 30, 10, 80, 4, 50, 0, 0, 'Autorizada'),
('PRUEBA-OC-005', '9900000002', '30 dias', -8, 30, 10, 80, 4, 50, 0, 0, 'Autorizada'),
('PRUEBA-OC-006', '9900000003', '30 dias', -4, 30, 10, 80, 4, 50, 0, 0, 'Rechazada'),
('PRUEBA-OC-007', '9900000001', '30 dias', -6, 30, 10, 80, 4, 50, 0, 0, 'Anulada'),
('PRUEBA-OC-008', '9900000001', '30 dias', 0, 30, 10, 80, 4, 50, 0, 0, 'Recibida'),
('PRUEBA-OC-009', '9900000002', '30 dias', 0, 30, 10, 80, 4, 50, 0, 0, 'Recibida'),
('PRUEBA-OC-010', '9900000003', '30 dias', 0, 30, 10, 80, 4, 50, 0, 0, 'Recibida'),
('PRUEBA-OC-011', '9900000004', '30 dias', -90, 30, 10, 80, 4, 50, 0, 0, 'Pendiente'),
('PRUEBA-OC-012', '9900000001', '30 dias', -1, 30, 1, 1000.1234, 4, 50, 0, 0, 'Pendiente');

START TRANSACTION;

INSERT INTO tblPlazo (nombrePlazo, diasPlazo)
SELECT Datos.nombre, Datos.dias
FROM (SELECT '15 dias' AS nombre, 15 AS dias UNION ALL SELECT '30 dias', 30) Datos
WHERE NOT EXISTS (SELECT 1 FROM tblPlazo p WHERE p.nombrePlazo = Datos.nombre);

INSERT INTO tblConceptoProveedor (nombreConceptoProveedor, naturalezaConceptoProveedor)
SELECT Datos.nombre, Datos.naturaleza
FROM (
    SELECT 'Factura de compra' AS nombre, 'Cargo' AS naturaleza
    UNION ALL SELECT 'Nota de debito', 'Cargo'
    UNION ALL SELECT 'Pago a proveedor', 'Abono'
    UNION ALL SELECT 'Nota de credito', 'Abono'
    UNION ALL SELECT 'Factura de transporte', 'Cargo'
) Datos
WHERE NOT EXISTS (
    SELECT 1 FROM tblConceptoProveedor c WHERE c.nombreConceptoProveedor = Datos.nombre
);

INSERT INTO tblProveedor
(nombreProveedor, nitProveedor, correoProveedor, telefonoProveedor, direccionProveedor,
 estadoProveedor, saldoActualProveedor, saldoAnteriorProveedor, cargosMesProveedor,
 abonosMesProveedor, cargosAsignadosProveedor)
SELECT Datos.nombre, Datos.nit,
       CONCAT('compras-', RIGHT(Datos.nit, 1), '@example.com'),
       CONCAT('5555-000', RIGHT(Datos.nit, 1)),
       CONCAT('Dirección ficticia de prueba ', RIGHT(Datos.nit, 1), ', Guatemala'),
       Datos.activo, Datos.cargos - Datos.abonos, 0, Datos.cargos, Datos.abonos, 0
FROM tmpComprasProveedoresPrueba Datos
WHERE NOT EXISTS (SELECT 1 FROM tblProveedor p WHERE p.nitProveedor = Datos.nit);

INSERT INTO tblOrdenCompra
(codigoOrdenCompra, idProveedor, idPlazo, fechaEmisionOrdenCompra,
 fechaVencimientoOrdenCompra, idMoneda, tipoCambioOrdenCompra,
 subtotalOrdenCompra, descuentoOrdenCompra, totalOrdenCompra,
 comentarioOrdenCompra, estadoOrdenCompra)
SELECT Datos.codigo, p.idProveedor, z.idPlazo,
       DATE_ADD(@ComprasFechaPrueba, INTERVAL Datos.diasEmision DAY),
       DATE_ADD(DATE_ADD(@ComprasFechaPrueba, INTERVAL Datos.diasEmision DAY), INTERVAL Datos.diasCredito DAY),
       @ComprasIdMoneda, 1,
       ROUND(Datos.cantidad1 * Datos.costo1 + Datos.cantidad2 * Datos.costo2 * (1 - Datos.descuento2 / 100), 4),
       Datos.descuentoOrden,
       ROUND(Datos.cantidad1 * Datos.costo1 + Datos.cantidad2 * Datos.costo2 * (1 - Datos.descuento2 / 100) - Datos.descuentoOrden, 4),
       CONCAT('[PRUEBA] Escenario ', Datos.codigo), Datos.estado
FROM tmpComprasOrdenesPrueba Datos
INNER JOIN tblProveedor p ON p.nitProveedor = Datos.nit
INNER JOIN tblPlazo z ON z.nombrePlazo = Datos.plazo
WHERE NOT EXISTS (SELECT 1 FROM tblOrdenCompra o WHERE o.codigoOrdenCompra = Datos.codigo);

INSERT INTO tblDetalleOrdenCompra
(idOrdenCompra, idProducto, cantidadDetalleOrdenCompra,
 costoUnitarioDetalleOrdenCompra, descuentoPorcentajeDetalleOrdenCompra, subtotalDetalleOrdenCompra)
SELECT o.idOrdenCompra, @ComprasIdProducto1, Datos.cantidad1, Datos.costo1, 0,
       ROUND(Datos.cantidad1 * Datos.costo1, 4)
FROM tmpComprasOrdenesPrueba Datos
INNER JOIN tblOrdenCompra o ON o.codigoOrdenCompra = Datos.codigo
WHERE NOT EXISTS (
    SELECT 1 FROM tblDetalleOrdenCompra d
    WHERE d.idOrdenCompra = o.idOrdenCompra AND d.idProducto = @ComprasIdProducto1
);

INSERT INTO tblDetalleOrdenCompra
(idOrdenCompra, idProducto, cantidadDetalleOrdenCompra,
 costoUnitarioDetalleOrdenCompra, descuentoPorcentajeDetalleOrdenCompra, subtotalDetalleOrdenCompra)
SELECT o.idOrdenCompra, @ComprasIdProducto2, Datos.cantidad2, Datos.costo2, Datos.descuento2,
       ROUND(Datos.cantidad2 * Datos.costo2 * (1 - Datos.descuento2 / 100), 4)
FROM tmpComprasOrdenesPrueba Datos
INNER JOIN tblOrdenCompra o ON o.codigoOrdenCompra = Datos.codigo
WHERE NOT EXISTS (
    SELECT 1 FROM tblDetalleOrdenCompra d
    WHERE d.idOrdenCompra = o.idOrdenCompra AND d.idProducto = @ComprasIdProducto2
);

INSERT INTO tblCompra
(idOrdenCompra, idProveedor, serieFacturaCompra, numeroFacturaCompra, fechaCompra,
 idMetodoPago, tipoCambioCompra, subtotalCompra, descuentoCompra, totalCompra, estadoCompra)
SELECT o.idOrdenCompra, o.idProveedor, 'PRUEBA-COMP', CONCAT('F-', RIGHT(o.codigoOrdenCompra, 3)),
       @ComprasFechaPrueba, @ComprasIdMetodoPago, o.tipoCambioOrdenCompra,
       o.subtotalOrdenCompra, o.descuentoOrdenCompra, o.totalOrdenCompra, 'Registrada'
FROM tblOrdenCompra o
WHERE o.codigoOrdenCompra IN ('PRUEBA-OC-008', 'PRUEBA-OC-009', 'PRUEBA-OC-010')
  AND NOT EXISTS (
      SELECT 1 FROM tblCompra c WHERE c.idProveedor = o.idProveedor
      AND c.serieFacturaCompra = 'PRUEBA-COMP' AND c.numeroFacturaCompra = CONCAT('F-', RIGHT(o.codigoOrdenCompra, 3))
  );

INSERT INTO tblDetalleCompra
(idCompra, idProducto, cantidadDetalleCompra, costoUnitarioDetalleCompra,
 descuentoAbsolutoDetalleCompra, subtotalDetalleCompra)
SELECT c.idCompra, d.idProducto, d.cantidadDetalleOrdenCompra, d.costoUnitarioDetalleOrdenCompra,
       ROUND(d.cantidadDetalleOrdenCompra * d.costoUnitarioDetalleOrdenCompra * d.descuentoPorcentajeDetalleOrdenCompra / 100, 4),
       d.subtotalDetalleOrdenCompra
FROM tblCompra c
INNER JOIN tblOrdenCompra o ON o.idOrdenCompra = c.idOrdenCompra
INNER JOIN tblDetalleOrdenCompra d ON d.idOrdenCompra = o.idOrdenCompra
WHERE c.serieFacturaCompra = 'PRUEBA-COMP'
  AND o.codigoOrdenCompra IN ('PRUEBA-OC-008', 'PRUEBA-OC-009', 'PRUEBA-OC-010')
  AND NOT EXISTS (SELECT 1 FROM tblDetalleCompra dc WHERE dc.idCompra = c.idCompra AND dc.idProducto = d.idProducto);

INSERT INTO tblCuentaPorPagar
(idCompra, idProveedor, idConceptoProveedor, serieDocumentoCuentaPorPagar,
 numeroDocumentoCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
 idMoneda, tipoCambioCuentaPorPagar, montoTotalCuentaPorPagar, saldoActualCuentaPorPagar, estadoCuentaPorPagar)
SELECT c.idCompra, c.idProveedor, concepto.idConceptoProveedor, 'PRUEBA-CXP',
       CONCAT('CXP-', RIGHT(o.codigoOrdenCompra, 3)), @ComprasFechaPrueba,
       DATE_ADD(@ComprasFechaPrueba, INTERVAL 30 DAY), o.idMoneda, c.tipoCambioCompra, c.totalCompra,
       CASE o.codigoOrdenCompra WHEN 'PRUEBA-OC-009' THEN 500 WHEN 'PRUEBA-OC-010' THEN 0 ELSE c.totalCompra END,
       CASE o.codigoOrdenCompra WHEN 'PRUEBA-OC-009' THEN 'Parcial' WHEN 'PRUEBA-OC-010' THEN 'Pagada' ELSE 'Pendiente' END
FROM tblCompra c
INNER JOIN tblOrdenCompra o ON o.idOrdenCompra = c.idOrdenCompra
INNER JOIN tblConceptoProveedor concepto ON concepto.nombreConceptoProveedor = 'Factura de compra'
WHERE c.serieFacturaCompra = 'PRUEBA-COMP'
  AND o.codigoOrdenCompra IN ('PRUEBA-OC-008', 'PRUEBA-OC-009', 'PRUEBA-OC-010')
  AND NOT EXISTS (SELECT 1 FROM tblCuentaPorPagar cxp WHERE cxp.idCompra = c.idCompra);

INSERT INTO tblCuentaPorPagar
(idCompra, idProveedor, idConceptoProveedor, serieDocumentoCuentaPorPagar,
 numeroDocumentoCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
 idMoneda, tipoCambioCuentaPorPagar, montoTotalCuentaPorPagar, saldoActualCuentaPorPagar, estadoCuentaPorPagar)
SELECT NULL, p.idProveedor, concepto.idConceptoProveedor, 'PRUEBA-TRANSP', 'TRANSP-001',
       @ComprasFechaPrueba, DATE_ADD(@ComprasFechaPrueba, INTERVAL 15 DAY), @ComprasIdMoneda, 1, 200, 200, 'Pendiente'
FROM tblProveedor p
INNER JOIN tblConceptoProveedor concepto ON concepto.nombreConceptoProveedor = 'Factura de transporte'
WHERE p.nitProveedor = '9900000001'
  AND NOT EXISTS (
      SELECT 1 FROM tblCuentaPorPagar cxp WHERE cxp.idProveedor = p.idProveedor
      AND cxp.idConceptoProveedor = concepto.idConceptoProveedor
      AND cxp.serieDocumentoCuentaPorPagar = 'PRUEBA-TRANSP' AND cxp.numeroDocumentoCuentaPorPagar = 'TRANSP-001'
  );

INSERT INTO tblDevolucionCompra
(idCompra, fechaDevolucionCompra, motivoDevolucionCompra,
 serieNotaCreditoDevolucionCompra, numeroNotaCreditoDevolucionCompra, totalDevolucionCompra, estadoDevolucionCompra)
SELECT c.idCompra, @ComprasFechaPrueba, '[PRUEBA] Devolución de dos unidades del segundo producto',
       'PRUEBA-NC', 'NC-009', 100, 'Registrada'
FROM tblCompra c
INNER JOIN tblOrdenCompra o ON o.idOrdenCompra = c.idOrdenCompra
WHERE c.serieFacturaCompra = 'PRUEBA-COMP' AND o.codigoOrdenCompra = 'PRUEBA-OC-009'
  AND NOT EXISTS (
      SELECT 1 FROM tblDevolucionCompra d WHERE d.idCompra = c.idCompra
      AND d.serieNotaCreditoDevolucionCompra = 'PRUEBA-NC' AND d.numeroNotaCreditoDevolucionCompra = 'NC-009'
  );

INSERT INTO tblDetalleDevolucionCompra
(idDevolucionCompra, idProducto, cantidadDetalleDevolucionCompra,
 costoUnitarioDetalleDevolucionCompra, subtotalDetalleDevolucionCompra)
SELECT d.idDevolucionCompra, @ComprasIdProducto2, 2, 50, 100
FROM tblDevolucionCompra d
INNER JOIN tblCompra c ON c.idCompra = d.idCompra
INNER JOIN tblOrdenCompra o ON o.idOrdenCompra = c.idOrdenCompra
WHERE d.serieNotaCreditoDevolucionCompra = 'PRUEBA-NC' AND d.numeroNotaCreditoDevolucionCompra = 'NC-009'
  AND o.codigoOrdenCompra = 'PRUEBA-OC-009'
  AND NOT EXISTS (
      SELECT 1 FROM tblDetalleDevolucionCompra dd
      WHERE dd.idDevolucionCompra = d.idDevolucionCompra AND dd.idProducto = @ComprasIdProducto2
  );

INSERT INTO tblPagoProveedor
(idProveedor, fechaPagoProveedor, montoPagoProveedor, idMetodoPago, idMoneda,
 tipoCambioPagoProveedor, referenciaPagoProveedor, estadoPagoProveedor)
SELECT p.idProveedor, @ComprasFechaPrueba, Datos.monto, @ComprasIdMetodoPago, @ComprasIdMoneda, 1,
       Datos.referencia, Datos.estado
FROM (
    SELECT '9900000002' AS nit, 400.0000 AS monto, 'PRUEBA-PAGO-009' AS referencia, 'Pagado' AS estado
    UNION ALL SELECT '9900000003', 1000.0000, 'PRUEBA-PAGO-010', 'Pagado'
    UNION ALL SELECT '9900000002', 100.0000, 'PRUEBA-PAGO-PROG', 'Programado'
    UNION ALL SELECT '9900000003', 75.0000, 'PRUEBA-PAGO-RECH', 'Rechazado'
    UNION ALL SELECT '9900000001', 50.0000, 'PRUEBA-PAGO-ANUL', 'Anulado'
) Datos
INNER JOIN tblProveedor p ON p.nitProveedor = Datos.nit
WHERE NOT EXISTS (
    SELECT 1 FROM tblPagoProveedor pago WHERE pago.idProveedor = p.idProveedor
    AND pago.referenciaPagoProveedor = Datos.referencia
);

INSERT INTO tblDetallePagoProveedor (idPagoProveedor, idCuentaPorPagar, montoAplicadoDetallePago)
SELECT pago.idPagoProveedor, cxp.idCuentaPorPagar, pago.montoPagoProveedor
FROM tblPagoProveedor pago
INNER JOIN tblCuentaPorPagar cxp ON cxp.idProveedor = pago.idProveedor
WHERE cxp.serieDocumentoCuentaPorPagar = 'PRUEBA-CXP'
  AND ((pago.referenciaPagoProveedor = 'PRUEBA-PAGO-009' AND cxp.numeroDocumentoCuentaPorPagar = 'CXP-009')
    OR (pago.referenciaPagoProveedor = 'PRUEBA-PAGO-010' AND cxp.numeroDocumentoCuentaPorPagar = 'CXP-010'))
  AND NOT EXISTS (
      SELECT 1 FROM tblDetallePagoProveedor d
      WHERE d.idPagoProveedor = pago.idPagoProveedor AND d.idCuentaPorPagar = cxp.idCuentaPorPagar
  );

INSERT INTO tblSolicitudPago
(moduloOrigenSolicitudPago, idOrigenSolicitudPago, beneficiarioSolicitudPago,
 montoSolicitudPago, metodoSolicitudPago, estadoSolicitudPago)
SELECT 'Compras', pago.idPagoProveedor, p.nombreProveedor, pago.montoPagoProveedor,
       CONCAT('Metodo ', pago.idMetodoPago),
       CASE pago.estadoPagoProveedor WHEN 'Pagado' THEN 'Procesada' WHEN 'Programado' THEN 'Pendiente' ELSE 'Rechazada' END
FROM tblPagoProveedor pago
INNER JOIN tblProveedor p ON p.idProveedor = pago.idProveedor
INNER JOIN tmpComprasProveedoresPrueba Datos ON Datos.nit = p.nitProveedor
WHERE pago.referenciaPagoProveedor IN ('PRUEBA-PAGO-009', 'PRUEBA-PAGO-010', 'PRUEBA-PAGO-PROG', 'PRUEBA-PAGO-RECH', 'PRUEBA-PAGO-ANUL')
  AND NOT EXISTS (
      SELECT 1 FROM tblSolicitudPago s
      WHERE s.moduloOrigenSolicitudPago = 'Compras' AND s.idOrigenSolicitudPago = pago.idPagoProveedor
  );

COMMIT;

SELECT o.estadoOrdenCompra AS estado, COUNT(*) AS cantidad
FROM tblOrdenCompra o
INNER JOIN tmpComprasOrdenesPrueba Datos ON Datos.codigo = o.codigoOrdenCompra
GROUP BY o.estadoOrdenCompra ORDER BY o.estadoOrdenCompra;

SELECT o.idOrdenCompra, o.codigoOrdenCompra, p.nombreProveedor,
       o.fechaEmisionOrdenCompra, o.fechaVencimientoOrdenCompra,
       o.totalOrdenCompra, o.estadoOrdenCompra
FROM tblOrdenCompra o
INNER JOIN tmpComprasOrdenesPrueba Datos ON Datos.codigo = o.codigoOrdenCompra
INNER JOIN tblProveedor p ON p.idProveedor = o.idProveedor
ORDER BY o.codigoOrdenCompra;

DROP TEMPORARY TABLE tmpComprasOrdenesPrueba;
DROP TEMPORARY TABLE tmpComprasProveedoresPrueba;

DROP TEMPORARY TABLE tmpComprasParametrosPrueba;
