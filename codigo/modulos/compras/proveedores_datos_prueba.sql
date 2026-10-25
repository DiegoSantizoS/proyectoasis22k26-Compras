USE `dbsistemaembutidos`;

SET NAMES utf8mb4;

START TRANSACTION;

INSERT INTO tblProveedor
    (nombreProveedor, nitProveedor, correoProveedor, telefonoProveedor, direccionProveedor, estadoProveedor)
VALUES
    ('Proveedor Prueba - Carnes del Norte', '9900000001', 'carnes.norte@example.com', '5550-0101', 'Zona 1, Ciudad de Guatemala', 1),
    ('Proveedor Prueba - Carnes del Sur', '9900000002', 'carnes.sur@example.com', '5550-0102', 'Zona 12, Ciudad de Guatemala', 1),
    ('Proveedor Prueba - Especias del Valle', '9900000003', 'especias.valle@example.com', '5550-0103', 'Zona 3, Mixco', 1),
    ('Proveedor Prueba - Empaques del Centro', '9900000004', 'empaques.centro@example.com', '5550-0104', 'Zona 4, Villa Nueva', 1),
    ('Proveedor Prueba - Insumos del Oriente', '9900000005', 'insumos.oriente@example.com', '5550-0105', 'Zona 1, Zacapa', 1),
    ('Proveedor Prueba - Refrigeracion del Oeste', '9900000006', 'refrigeracion.oeste@example.com', '5550-0106', 'Zona 2, Quetzaltenango', 1),
    ('Proveedor Prueba - Transporte del Pacifico', '9900000007', 'transporte.pacifico@example.com', '5550-0107', 'Zona 1, Escuintla', 1),
    ('Proveedor Prueba - Limpieza Industrial', '9900000008', 'limpieza.industrial@example.com', '5550-0108', 'Zona 6, Ciudad de Guatemala', 1),
    ('Proveedor Prueba - Equipo de Seguridad', '9900000009', 'equipo.seguridad@example.com', '5550-0109', 'Zona 7, Ciudad de Guatemala', 1),
    ('Proveedor Prueba - Distribuidora Central', '9900000010', 'distribuidora.central@example.com', '5550-0110', 'Zona 5, Villa Nueva', 1),
    ('Proveedor Prueba - Empaques Inactivo', '9900000011', 'empaques.inactivo@example.com', '5550-0111', 'Zona 2, Mixco', 0),
    ('Proveedor Prueba - Insumos Inactivo', '9900000012', 'insumos.inactivo@example.com', '5550-0112', 'Zona 1, Chimaltenango', 0)
ON DUPLICATE KEY UPDATE idProveedor = tblProveedor.idProveedor;

COMMIT;
