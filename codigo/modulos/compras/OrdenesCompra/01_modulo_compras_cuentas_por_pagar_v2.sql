
CREATE DATABASE IF NOT EXISTS `dbsistemaembutidos` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `dbsistemaembutidos`;

-- =====================================================================
-- MAESTROS
-- =====================================================================

CREATE TABLE tblPlazo(
    idPlazo INT AUTO_INCREMENT,
    nombrePlazo VARCHAR(100) NOT NULL,
    diasPlazo INT NOT NULL DEFAULT 0,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Plazos PRIMARY KEY (idPlazo),
    CONSTRAINT uqnombrePlazo UNIQUE (nombrePlazo),
    CONSTRAINT ckDiasPlazo CHECK (diasPlazo >= 0)
) ENGINE=InnoDB;

CREATE TABLE tblConceptoProveedor (
    idConceptoProveedor         INT          NOT NULL AUTO_INCREMENT,
    nombreConceptoProveedor     VARCHAR(100) NOT NULL,
    -- el CHECK compara con 'Cargo'/'Abono'
    naturalezaConceptoProveedor VARCHAR(10)  NOT NULL,
    created_at                  TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                  TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_ConceptoProveedor PRIMARY KEY (idConceptoProveedor),
    CONSTRAINT uqConceptoProveedorNombre UNIQUE (nombreConceptoProveedor),
    -- Cargo = aumenta lo que se debe; Abono = lo disminuye.
    CONSTRAINT ckNaturalezaConceptoProveedor CHECK (naturalezaConceptoProveedor IN ('Cargo','Abono'))
) ENGINE=InnoDB;

CREATE TABLE tblProveedor(
    idProveedor INT AUTO_INCREMENT,
    nombreProveedor VARCHAR(100) NOT NULL,
    nitProveedor CHAR(10) NOT NULL,
    correoProveedor VARCHAR(150) NOT NULL,
    telefonoProveedor VARCHAR(30) NOT NULL,
    direccionProveedor VARCHAR(500) NOT NULL,
    estadoProveedor BOOLEAN NOT NULL DEFAULT 1,
    -- [NUEVO] resumen de cuenta del proveedor 
    -- Relacion: saldoActual = saldoAnterior + cargosMes - abonosMes
    saldoActualProveedor     DECIMAL(12,4) NOT NULL DEFAULT 0,
    saldoAnteriorProveedor   DECIMAL(12,4) NOT NULL DEFAULT 0,
    cargosMesProveedor       DECIMAL(12,4) NOT NULL DEFAULT 0,
    abonosMesProveedor       DECIMAL(12,4) NOT NULL DEFAULT 0,
    cargosAsignadosProveedor DECIMAL(12,4) NOT NULL DEFAULT 0,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Proveedores PRIMARY KEY(idProveedor),
    CONSTRAINT uqProveedorNit UNIQUE (nitProveedor),
    -- [NUEVO]
    CONSTRAINT ckSaldosProveedor CHECK (saldoActualProveedor >= 0 AND saldoAnteriorProveedor >= 0),
    CONSTRAINT ckMovimientosProveedor CHECK (cargosMesProveedor >= 0 AND abonosMesProveedor >= 0 AND cargosAsignadosProveedor >= 0)
) ENGINE=InnoDB;

-- =====================================================================
-- ORDEN DE COMPRA
-- =====================================================================

CREATE TABLE tblOrdenCompra (
    idOrdenCompra                 INT            NOT NULL AUTO_INCREMENT,
    codigoOrdenCompra             VARCHAR(30)    NOT NULL,
    idProveedor                   INT            NOT NULL,
    idPlazo                       INT            NOT NULL,                 -- [NUEVO] el plazo vive solo en la orden
    fechaEmisionOrdenCompra       DATE           NOT NULL,
    fechaVencimientoOrdenCompra   DATE           NOT NULL,
    idMoneda                      INT            NOT NULL,                 -- Bancos
    tipoCambioOrdenCompra         DECIMAL(12,6)  NOT NULL DEFAULT 1,
    subtotalOrdenCompra           DECIMAL(12,4)  NOT NULL,
    descuentoOrdenCompra          DECIMAL(12,4)  NOT NULL DEFAULT 0,
    totalOrdenCompra              DECIMAL(12,4)  NOT NULL,
    comentarioOrdenCompra         VARCHAR(500)   NULL,
    -- pendiente: preguntar sobre impuestos de compras y sobre el descuento
    estadoOrdenCompra             VARCHAR(30)    NOT NULL DEFAULT 'Pendiente',
    created_at                    TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                    TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_OrdenCompra PRIMARY KEY (idOrdenCompra),
    CONSTRAINT uqCodigoOrdenCompra UNIQUE (codigoOrdenCompra),
    CONSTRAINT Fk_OrdenCompra_Proveedor FOREIGN KEY (idProveedor) REFERENCES tblProveedor (idProveedor),
    CONSTRAINT Fk_OrdenCompra_Plazo FOREIGN KEY (idPlazo) REFERENCES tblPlazo (idPlazo),
    INDEX idxOrdenCompraProveedor (idProveedor),
    INDEX idxOrdenCompraFecha (fechaEmisionOrdenCompra),
    CONSTRAINT ckTipoCambioOrdenCompra CHECK (tipoCambioOrdenCompra > 0),
    CONSTRAINT ckSubtotalOrdenCompra CHECK (subtotalOrdenCompra >= 0),
    CONSTRAINT ckDescuentoOrdenCompra CHECK (descuentoOrdenCompra >= 0),
    CONSTRAINT ckTotalOrdenCompra CHECK (totalOrdenCompra >= 0),
    CONSTRAINT ckFechasOrdenCompra CHECK (fechaVencimientoOrdenCompra >= fechaEmisionOrdenCompra),
    CONSTRAINT ckEstadoOrdenCompra CHECK (estadoOrdenCompra IN ('Pendiente','Autorizada','Rechazada','Anulada','Recibida'))
) ENGINE=InnoDB;

CREATE TABLE tblDetalleOrdenCompra (
    idOrdenCompra              INT            NOT NULL,
    idProducto                 INT            NOT NULL,                  -- Logistica
    cantidadDetalleOrdenCompra DECIMAL(12,4)  NOT NULL,
    costoUnitarioDetalleOrdenCompra DECIMAL(12,4) NOT NULL,
    -- descuentoAbsolutoDetalleOrdenCompra DECIMAL(12,4) NOT NULL DEFAULT 0,  -- si se activa, descomentar tambien su CHECK
    descuentoPorcentajeDetalleOrdenCompra DECIMAL(5,2)  NOT NULL DEFAULT 0,
    subtotalDetalleOrdenCompra DECIMAL(12,4)  NOT NULL,
    created_at                 TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                 TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_DetalleOrdenCompra PRIMARY KEY (idOrdenCompra, idProducto),
    CONSTRAINT Fk_DetalleOrdenCompra_Orden FOREIGN KEY (idOrdenCompra) REFERENCES tblOrdenCompra (idOrdenCompra),
    INDEX idxDetalleOrdenCompraProducto (idProducto),
    CONSTRAINT ckCantidadDetalleOrdenCompra CHECK (cantidadDetalleOrdenCompra > 0),
    CONSTRAINT ckCostoDetalleOrdenCompra CHECK (costoUnitarioDetalleOrdenCompra >= 0),
    -- [CORREGIDO] CHECK comentado porque la columna descuentoAbsoluto... esta comentada
    -- CONSTRAINT ckDescAbsDetalleOrdenCompra CHECK (descuentoAbsolutoDetalleOrdenCompra >= 0),
    CONSTRAINT ckDescPorcDetalleOrdenCompra CHECK (descuentoPorcentajeDetalleOrdenCompra BETWEEN 0 AND 100),
    CONSTRAINT ckSubtotalDetalleOrdenCompra CHECK (subtotalDetalleOrdenCompra >= 0)
) ENGINE=InnoDB;

-- =====================================================================
-- COMPRA
-- =====================================================================

CREATE TABLE tblCompra (
    idCompra              INT            NOT NULL AUTO_INCREMENT,
    idOrdenCompra         INT            NOT NULL,
    idProveedor           INT            NOT NULL,
    serieFacturaCompra    VARCHAR(30)    NOT NULL,
    numeroFacturaCompra   VARCHAR(30)    NOT NULL,
    fechaCompra           DATE           NOT NULL,
    idMetodoPago          INT            NOT NULL,                        -- Bancos
    tipoCambioCompra      DECIMAL(12,6)  NOT NULL DEFAULT 1,
    subtotalCompra        DECIMAL(12,4)  NOT NULL,
    descuentoCompra       DECIMAL(12,4)  NOT NULL DEFAULT 0,
    totalCompra           DECIMAL(12,4)  NOT NULL,
    estadoCompra          VARCHAR(30)    NOT NULL DEFAULT 'Registrada',
    created_at            TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at            TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    -- pendiente: preguntar si dejar moneda y tipo de cambio aqui
    CONSTRAINT Pk_Compra PRIMARY KEY (idCompra),
    CONSTRAINT Fk_Compra_OrdenCompra FOREIGN KEY (idOrdenCompra) REFERENCES tblOrdenCompra (idOrdenCompra),
    CONSTRAINT Fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES tblProveedor (idProveedor),
    INDEX idxCompraOrden (idOrdenCompra),
    INDEX idxCompraProveedor (idProveedor),
    CONSTRAINT uqFacturaProveedorCompra UNIQUE (idProveedor, serieFacturaCompra, numeroFacturaCompra),
    CONSTRAINT ckTipoCambioCompra CHECK (tipoCambioCompra > 0),
    CONSTRAINT ckSubtotalCompra CHECK (subtotalCompra >= 0),
    CONSTRAINT ckDescuentoCompra CHECK (descuentoCompra >= 0),
    CONSTRAINT ckTotalCompra CHECK (totalCompra >= 0),
    CONSTRAINT ckEstadoCompra CHECK (estadoCompra IN ('Registrada','Anulada'))
) ENGINE=InnoDB;

CREATE TABLE tblDetalleCompra (
    idCompra                        INT            NOT NULL,
    idProducto                      INT            NOT NULL,              -- Logistica
    cantidadDetalleCompra           DECIMAL(12,4)  NOT NULL,
    costoUnitarioDetalleCompra      DECIMAL(12,4)  NOT NULL,
    descuentoAbsolutoDetalleCompra  DECIMAL(12,4)  NOT NULL DEFAULT 0,
    subtotalDetalleCompra           DECIMAL(12,4)  NOT NULL,
    created_at                      TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                      TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_DetalleCompra PRIMARY KEY (idCompra, idProducto),
    CONSTRAINT Fk_DetalleCompra_Compra FOREIGN KEY (idCompra) REFERENCES tblCompra (idCompra),
    INDEX idxDetalleCompraProducto (idProducto),
    CONSTRAINT ckCantidadDetalleCompra CHECK (cantidadDetalleCompra > 0),
    CONSTRAINT ckCostoDetalleCompra CHECK (costoUnitarioDetalleCompra >= 0),
    CONSTRAINT ckDescuentoDetalleCompra CHECK (descuentoAbsolutoDetalleCompra >= 0),
    CONSTRAINT ckSubtotalDetalleCompra CHECK (subtotalDetalleCompra >= 0)
) ENGINE=InnoDB;

-- =====================================================================
-- CUENTA POR PAGAR
-- =====================================================================

CREATE TABLE tblCuentaPorPagar(
    idCuentaPorPagar INT AUTO_INCREMENT,
    idCompra INT NULL,
    idProveedor INT NOT NULL,
    idConceptoProveedor INT NOT NULL,           -- Factura de compra, Nota de debito o Factura de transporte
    serieDocumentoCuentaPorPagar VARCHAR(20) NOT NULL,
    numeroDocumentoCuentaPorPagar VARCHAR(30) NOT NULL,
    fechaEmisionCuentaPorPagar DATE NOT NULL,
    fechaVencimientoCuentaPorPagar DATE NOT NULL,
    idMoneda INT NOT NULL,                      -- Bancos
    tipoCambioCuentaPorPagar DECIMAL(12,6) NOT NULL DEFAULT 1,
    montoTotalCuentaPorPagar DECIMAL(12,4) NOT NULL,
    saldoActualCuentaPorPagar DECIMAL(12,4) NOT NULL,
    estadoCuentaPorPagar VARCHAR(30) NOT NULL DEFAULT 'Pendiente',
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_CuentaPorPagar PRIMARY KEY(idCuentaPorPagar),
    CONSTRAINT Fk_Proveedor_idProveedor FOREIGN KEY (idProveedor) REFERENCES tblProveedor(idProveedor),
    CONSTRAINT Fk_Compra_idCompra FOREIGN KEY (idCompra) REFERENCES tblCompra(idCompra),
    CONSTRAINT Fk_CuentaPorPagar_Concepto FOREIGN KEY (idConceptoProveedor) REFERENCES tblConceptoProveedor (idConceptoProveedor),
    INDEX idxCuentaPorPagarVencimiento (fechaVencimientoCuentaPorPagar),
    CONSTRAINT uqCuentaPorPagarCompra UNIQUE (idCompra),
    CONSTRAINT uqDocumentoCuentaPorPagar UNIQUE (idProveedor, idConceptoProveedor, serieDocumentoCuentaPorPagar, numeroDocumentoCuentaPorPagar),
    CONSTRAINT ckTipoCambioCuentaPorPagar CHECK (tipoCambioCuentaPorPagar > 0),
    CONSTRAINT ckMontoTotalCuentaPorPagar CHECK (montoTotalCuentaPorPagar > 0),
    CONSTRAINT ckSaldoCuentaPorPagar CHECK (saldoActualCuentaPorPagar >= 0 AND saldoActualCuentaPorPagar <= montoTotalCuentaPorPagar),
    CONSTRAINT ckFechasCuentaPorPagar CHECK (fechaVencimientoCuentaPorPagar >= fechaEmisionCuentaPorPagar),
    CONSTRAINT ckEstadoCuentaPorPagar CHECK (estadoCuentaPorPagar IN ('Pendiente','Parcial','Pagada','Anulada'))
) ENGINE=InnoDB;

-- =====================================================================
-- DEVOLUCION SOBRE COMPRA
-- =====================================================================

CREATE TABLE tblDevolucionCompra (
    idDevolucionCompra        INT            NOT NULL AUTO_INCREMENT,
    idCompra                  INT            NOT NULL,  --  el proveedor se obtiene por tblCompra
    fechaDevolucionCompra     DATE           NOT NULL,
    motivoDevolucionCompra    VARCHAR(500)   NOT NULL,
    serieNotaCreditoDevolucionCompra  VARCHAR(20) NULL,
    numeroNotaCreditoDevolucionCompra VARCHAR(30) NULL,
    totalDevolucionCompra     DECIMAL(12,4)  NOT NULL,
    estadoDevolucionCompra    VARCHAR(30)    NOT NULL DEFAULT 'Registrada',
    created_at                TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_DevolucionCompra PRIMARY KEY (idDevolucionCompra),
    CONSTRAINT Fk_DevolucionCompra_Compra FOREIGN KEY (idCompra) REFERENCES tblCompra (idCompra),
    INDEX idxDevolucionCompraCompra (idCompra),
    CONSTRAINT uqNotaCreditoDevolucionCompra UNIQUE (idCompra, serieNotaCreditoDevolucionCompra, numeroNotaCreditoDevolucionCompra),
    CONSTRAINT ckTotalDevolucionCompra CHECK (totalDevolucionCompra > 0),
    CONSTRAINT ckEstadoDevolucionCompra CHECK (estadoDevolucionCompra IN ('Registrada','Anulada'))
) ENGINE=InnoDB;

CREATE TABLE tblDetalleDevolucionCompra (
    idDevolucionCompra                   INT            NOT NULL,
    idProducto                           INT            NOT NULL,         -- Logistica
    cantidadDetalleDevolucionCompra      DECIMAL(12,4)  NOT NULL,
    costoUnitarioDetalleDevolucionCompra DECIMAL(12,4)  NOT NULL,
    subtotalDetalleDevolucionCompra      DECIMAL(12,4)  NOT NULL,
    created_at                           TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                           TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_DetalleDevolucionCompra PRIMARY KEY (idDevolucionCompra, idProducto),
    CONSTRAINT Fk_DetalleDevolucionCompra_Devolucion FOREIGN KEY (idDevolucionCompra) REFERENCES tblDevolucionCompra (idDevolucionCompra),
    INDEX idxDetalleDevolucionCompraProducto (idProducto),
    CONSTRAINT ckCantidadDetalleDevolucionCompra CHECK (cantidadDetalleDevolucionCompra > 0),
    CONSTRAINT ckCostoDetalleDevolucionCompra CHECK (costoUnitarioDetalleDevolucionCompra >= 0),
    CONSTRAINT ckSubtotalDetalleDevolucionCompra CHECK (subtotalDetalleDevolucionCompra >= 0)
) ENGINE=InnoDB;

-- =====================================================================
-- PAGO A PROVEEDOR
-- =====================================================================

CREATE TABLE tblPagoProveedor (
    idPagoProveedor          INT            NOT NULL AUTO_INCREMENT,
    idProveedor              INT            NOT NULL,
    fechaPagoProveedor       DATE           NOT NULL,
    montoPagoProveedor       DECIMAL(12,4)  NOT NULL,
    idMetodoPago             INT            NOT NULL,                     -- Bancos
    idMoneda                 INT            NOT NULL,                     -- Bancos
    tipoCambioPagoProveedor  DECIMAL(12,6)  NOT NULL DEFAULT 1,
    referenciaPagoProveedor  VARCHAR(30)    NULL,
    estadoPagoProveedor      VARCHAR(30)    NOT NULL DEFAULT 'Programado',
    created_at               TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at               TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_PagoProveedor PRIMARY KEY (idPagoProveedor),
    CONSTRAINT Fk_PagoProveedor_Proveedor FOREIGN KEY (idProveedor) REFERENCES tblProveedor (idProveedor),
    INDEX idxPagoProveedorProveedor (idProveedor),
    INDEX idxPagoProveedorFecha (fechaPagoProveedor),
    CONSTRAINT ckMontoPagoProveedor CHECK (montoPagoProveedor > 0),
    CONSTRAINT ckTipoCambioPagoProveedor CHECK (tipoCambioPagoProveedor > 0),
    CONSTRAINT ckEstadoPagoProveedor CHECK (estadoPagoProveedor IN ('Pagado','Programado','Rechazado','Anulado'))
) ENGINE=InnoDB;

CREATE TABLE tblDetallePagoProveedor (
    idPagoProveedor              INT            NOT NULL,
    idCuentaPorPagar             INT            NOT NULL,
    montoAplicadoDetallePago     DECIMAL(12,4)  NOT NULL,
    created_at                   TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                   TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_DetallePagoProveedor PRIMARY KEY (idPagoProveedor, idCuentaPorPagar),
    CONSTRAINT Fk_DetallePago_Pago FOREIGN KEY (idPagoProveedor) REFERENCES tblPagoProveedor (idPagoProveedor),
    CONSTRAINT Fk_DetallePago_CuentaPorPagar FOREIGN KEY (idCuentaPorPagar) REFERENCES tblCuentaPorPagar (idCuentaPorPagar),
    INDEX idxDetallePagoCuenta (idCuentaPorPagar),
    CONSTRAINT ckMontoAplicadoDetallePago CHECK (montoAplicadoDetallePago > 0)
) ENGINE=InnoDB;

-- MOVIMIENTOS DE PROVEEDOR: sin tabla propia (consulta en la capa modelo que
-- une tblCuentaPorPagar, tblPagoProveedor/tblDetallePagoProveedor y tblDevolucionCompra).


-- =====================================================================
-- SOLICITUD DE PAGO (temporal para el enlace con Bancos)
-- =====================================================================

CREATE TABLE tblSolicitudPago (
    idSolicitudPago                INT            NOT NULL AUTO_INCREMENT,
    moduloOrigenSolicitudPago      VARCHAR(30)    NOT NULL,
    idOrigenSolicitudPago          INT            NOT NULL,
    beneficiarioSolicitudPago      VARCHAR(100)   NOT NULL,
    montoSolicitudPago             DECIMAL(12,4)  NOT NULL,
    metodoSolicitudPago            VARCHAR(30)    NOT NULL,
    estadoSolicitudPago            VARCHAR(30)    NOT NULL DEFAULT 'Pendiente',
    created_at                     TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at                     TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_SolicitudPago PRIMARY KEY (idSolicitudPago),
    INDEX idxSolicitudPagoOrigen (moduloOrigenSolicitudPago, idOrigenSolicitudPago),
    CONSTRAINT ckMontoSolicitudPago CHECK (montoSolicitudPago > 0),
    CONSTRAINT ckEstadoSolicitudPago CHECK (estadoSolicitudPago IN ('Pendiente','Procesada','Rechazada'))
) ENGINE=InnoDB;

-- =====================================================================
-- DATOS INICIALES DE LOS MAESTROS
-- =====================================================================

-- [CORREGIDO] se quito estadoPlazo, que no existe en la tabla
INSERT INTO tblPlazo (nombrePlazo, diasPlazo) VALUES
    ('Contado', 0),
    ('Pago contra entrega', 0),
    ('Cheque contra entrega', 0),
    ('15 dias', 15),
    ('30 dias', 30),
    ('60 dias', 60),
    ('90 dias', 90);

INSERT INTO tblConceptoProveedor (nombreConceptoProveedor, naturalezaConceptoProveedor) VALUES
    ('Factura de compra', 'Cargo'),
    ('Nota de debito', 'Cargo'),
    ('Pago a proveedor', 'Abono'),
    ('Nota de credito', 'Abono'),
    ('Factura de transporte', 'Cargo');   -- [NUEVO] para el enlace con Transporte Externo
