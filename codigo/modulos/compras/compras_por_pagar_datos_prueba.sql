USE `dbsistemaembutidos`;

SET NAMES utf8mb4;

START TRANSACTION;

INSERT INTO tblProveedor
    (nombreProveedor, nitProveedor, correoProveedor, telefonoProveedor, direccionProveedor, estadoProveedor)
VALUES
    ('Proveedor Prueba - Carnes del Norte', '9900000001', 'carnes.norte@example.com', '5550-0101', 'Zona 1, Ciudad de Guatemala', 1),
    ('Proveedor Prueba - Especias del Valle', '9900000003', 'especias.valle@example.com', '5550-0103', 'Zona 3, Mixco', 1),
    ('Proveedor Prueba - Empaques del Centro', '9900000004', 'empaques.centro@example.com', '5550-0104', 'Zona 4, Villa Nueva', 1),
    ('Proveedor Prueba - Empaques Inactivo', '9900000011', 'empaques.inactivo@example.com', '5550-0111', 'Zona 2, Mixco', 0)
ON DUPLICATE KEY UPDATE idProveedor = tblProveedor.idProveedor;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-001', DATE_SUB(CURDATE(), INTERVAL 12 DAY), DATE_ADD(CURDATE(), INTERVAL 18 DAY), 1250.0000, 1250.0000, 'Pendiente'
FROM tblProveedor WHERE nitProveedor = '9900000001'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-002', DATE_SUB(CURDATE(), INTERVAL 8 DAY), DATE_ADD(CURDATE(), INTERVAL 22 DAY), 980.7500, 480.7500, 'Parcial'
FROM tblProveedor WHERE nitProveedor = '9900000003'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-003', DATE_SUB(CURDATE(), INTERVAL 40 DAY), DATE_SUB(CURDATE(), INTERVAL 10 DAY), 2300.0000, 0.0000, 'Pagada'
FROM tblProveedor WHERE nitProveedor = '9900000004'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-004', DATE_SUB(CURDATE(), INTERVAL 5 DAY), DATE_ADD(CURDATE(), INTERVAL 25 DAY), 500.0000, 0.0000, 'Anulada'
FROM tblProveedor WHERE nitProveedor = '9900000011'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-005', DATE_SUB(CURDATE(), INTERVAL 45 DAY), DATE_SUB(CURDATE(), INTERVAL 15 DAY), 875.5000, 875.5000, 'Pendiente'
FROM tblProveedor WHERE nitProveedor = '9900000001'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-006', DATE_SUB(CURDATE(), INTERVAL 60 DAY), DATE_SUB(CURDATE(), INTERVAL 30 DAY), 3600.0000, 1200.0000, 'Parcial'
FROM tblProveedor WHERE nitProveedor = '9900000003'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-007', CURDATE(), DATE_ADD(CURDATE(), INTERVAL 30 DAY), 120.9900, 120.9900, 'Pendiente'
FROM tblProveedor WHERE nitProveedor = '9900000004'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

INSERT INTO tblCuentaPorPagar
    (idProveedor, numeroFacturaCuentaPorPagar, fechaEmisionCuentaPorPagar, fechaVencimientoCuentaPorPagar,
     montoTotalCuentaPorPagar, saldoCuentaPorPagar, estadoCuentaPorPagar)
SELECT idProveedor, 'PRUEBA-CXP-008', DATE_SUB(CURDATE(), INTERVAL 90 DAY), DATE_SUB(CURDATE(), INTERVAL 60 DAY), 475.0000, 0.0000, 'Pagada'
FROM tblProveedor WHERE nitProveedor = '9900000001'
ON DUPLICATE KEY UPDATE idCuentaPorPagar = tblCuentaPorPagar.idCuentaPorPagar;

COMMIT;
