USE `dbsistemaembutidos`;

ALTER TABLE tblOrdenCompra
    ADD COLUMN codigoOrdenCompra VARCHAR(30) NULL AFTER idOrdenCompra;

UPDATE tblOrdenCompra
SET codigoOrdenCompra = CONCAT('OC-', idOrdenCompra)
WHERE codigoOrdenCompra IS NULL;

ALTER TABLE tblOrdenCompra
    MODIFY COLUMN codigoOrdenCompra VARCHAR(30) NOT NULL,
    ADD CONSTRAINT uqCodigoOrdenCompra UNIQUE (codigoOrdenCompra);
