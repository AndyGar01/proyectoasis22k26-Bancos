/* ============================================================================
   ESTÁNDAR EST-01 V1.1 - BASE DE DATOS PARA MYSQL WORKBENCH
   ============================================================================ */

CREATE DATABASE IF NOT EXISTS dbsistemaembutidos_transporte;
USE dbsistemaembutidos_transporte;

/* ============================================================================
   1. CATÁLOGOS BASE
   ============================================================================ */

CREATE TABLE tbl_region (
    fld_idRegion INT AUTO_INCREMENT NOT NULL,
    fld_nombreRegion VARCHAR(80) NOT NULL,
    CONSTRAINT PK_tbl_region PRIMARY KEY (fld_idRegion),
    CONSTRAINT UQ_tbl_region_nombreRegion UNIQUE (fld_nombreRegion)
) ENGINE=InnoDB;

CREATE TABLE tbl_pais (
    fld_idPais INT AUTO_INCREMENT NOT NULL,
    fld_isoPais CHAR(3) NOT NULL,
    fld_nombrePais VARCHAR(200) NOT NULL,
    CONSTRAINT PK_tbl_pais PRIMARY KEY (fld_idPais),
    CONSTRAINT UQ_tbl_pais_isoPais UNIQUE (fld_isoPais)
) ENGINE=InnoDB;

CREATE TABLE tbl_estado (
    fld_idEstado INT AUTO_INCREMENT NOT NULL,
    fld_tipoEstado VARCHAR(100) NOT NULL,
    CONSTRAINT PK_tbl_estado PRIMARY KEY (fld_idEstado)
) ENGINE=InnoDB;

CREATE TABLE tbl_tipoTransporte (
    fld_idTipoTransporte INT AUTO_INCREMENT NOT NULL,
    fld_tipo VARCHAR(80) NOT NULL,
    CONSTRAINT PK_tbl_tipoTransporte PRIMARY KEY (fld_idTipoTransporte)
) ENGINE=InnoDB;

/* ============================================================================
   2. ENTIDADES DE FLOTA Y CONDUCTORES
   ============================================================================ */

CREATE TABLE tbl_transporte (
    fld_idTransporte INT AUTO_INCREMENT NOT NULL,
    fld_idPais INT NOT NULL,
    fld_nroPlaca VARCHAR(30) NOT NULL,
    fld_marca VARCHAR(100) NULL,
    fld_modelo VARCHAR(100) NULL,
    fld_anio SMALLINT NULL,
    fld_esRefrigerado BOOLEAN NOT NULL DEFAULT 0,
    fld_idEstado INT NOT NULL,
    fld_idTipoTransporte INT NOT NULL,
    fld_fechaCreacionUtc DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_tbl_transporte PRIMARY KEY (fld_idTransporte),
    CONSTRAINT UQ_tbl_transporte_nroPlaca UNIQUE (fld_nroPlaca),
    CONSTRAINT FK_tbl_transporte_tbl_pais FOREIGN KEY (fld_idPais) REFERENCES tbl_pais(fld_idPais),
    CONSTRAINT FK_tbl_transporte_tbl_estado FOREIGN KEY (fld_idEstado) REFERENCES tbl_estado(fld_idEstado),
    CONSTRAINT FK_tbl_transporte_tbl_tipoTransporte FOREIGN KEY (fld_idTipoTransporte) REFERENCES tbl_tipoTransporte(fld_idTipoTransporte)
) ENGINE=InnoDB;

CREATE TABLE tbl_camaraRefrigeracion (
    fld_idCamara INT AUTO_INCREMENT NOT NULL,
    fld_idTransporte INT NOT NULL,
    fld_marcaEquipo VARCHAR(100) NOT NULL,
    fld_tempMinimaCelsius DECIMAL(5,2) NOT NULL,
    fld_tempMaximaCelsius DECIMAL(5,2) NOT NULL,
    fld_estadoOperativo VARCHAR(50) NOT NULL DEFAULT 'OPERATIVO',
    CONSTRAINT PK_tbl_camaraRefrigeracion PRIMARY KEY (fld_idCamara),
    CONSTRAINT UQ_tbl_camaraRefrigeracion_idTransporte UNIQUE (fld_idTransporte),
    CONSTRAINT FK_tbl_camaraRefrigeracion_tbl_transporte FOREIGN KEY (fld_idTransporte) REFERENCES tbl_transporte(fld_idTransporte)
) ENGINE=InnoDB;

CREATE TABLE tbl_conductor (
    fld_idConductor INT AUTO_INCREMENT NOT NULL,
    fld_codigoConductor VARCHAR(40) NOT NULL,
    fld_nombreCompleto VARCHAR(200) NOT NULL,
    fld_numeroLicencia VARCHAR(100) NOT NULL,
    fld_fechaVencimientoDoc DATE NOT NULL,
    fld_idEstado INT NOT NULL,
    CONSTRAINT PK_tbl_conductor PRIMARY KEY (fld_idConductor),
    CONSTRAINT UQ_tbl_conductor_codigoConductor UNIQUE (fld_codigoConductor),
    CONSTRAINT FK_tbl_conductor_tbl_estado FOREIGN KEY (fld_idEstado) REFERENCES tbl_estado(fld_idEstado)
) ENGINE=InnoDB;

/* ============================================================================
   3. MÓDULO DE INOCUIDAD Y HACCP (INSPECCIÓN SANITARIA)
   ============================================================================ */

CREATE TABLE tbl_inspeccionSanitaria (
    fld_idInspeccion BIGINT AUTO_INCREMENT NOT NULL,
    fld_idTransporte INT NOT NULL,
    fld_fechaInspeccionUtc DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fld_sanitizadoCorrecto BOOLEAN NOT NULL,
    fld_libreOloresContam BOOLEAN NOT NULL,
    fld_aprobadoParaCarga BOOLEAN NOT NULL,
    fld_observaciones VARCHAR(500) NULL,
    CONSTRAINT PK_tbl_inspeccionSanitaria PRIMARY KEY (fld_idInspeccion),
    CONSTRAINT FK_tbl_inspeccionSanitaria_tbl_transporte FOREIGN KEY (fld_idTransporte) REFERENCES tbl_transporte(fld_idTransporte)
) ENGINE=InnoDB;

/* ============================================================================
   4. SOLICITUDES, VIAJES Y LOTES DE PRODUCTO
   ============================================================================ */

CREATE TABLE tbl_loteProducto (
    fld_idLote BIGINT AUTO_INCREMENT NOT NULL,
    fld_codigoLote VARCHAR(60) NOT NULL,
    fld_descripcionProducto VARCHAR(200) NOT NULL,
    fld_requiereFrio BOOLEAN NOT NULL DEFAULT 1,
    fld_fechaFabricacion DATE NOT NULL,
    fld_fechaVencimiento DATE NOT NULL,
    fld_tempRequeridaMin DECIMAL(5,2) NULL,
    fld_tempRequeridaMax DECIMAL(5,2) NULL,
    CONSTRAINT PK_tbl_loteProducto PRIMARY KEY (fld_idLote),
    CONSTRAINT UQ_tbl_loteProducto_codigoLote UNIQUE (fld_codigoLote)
) ENGINE=InnoDB;

CREATE TABLE tbl_encabezadoViaje (
    fld_correlativo BIGINT AUTO_INCREMENT NOT NULL,
    fld_fechaDocumento DATETIME NOT NULL,
    fld_horaSalidaUtc DATETIME NULL,
    fld_horaLlegadaUtc DATETIME NULL,
    fld_requiereCadenaFrio BOOLEAN NOT NULL DEFAULT 1,
    fld_estadoViaje VARCHAR(30) NOT NULL DEFAULT 'EN_CURSO',
    fld_pesoTotal DECIMAL(18,3) NULL,
    fld_idTransporte INT NOT NULL,
    fld_idConductor INT NOT NULL,
    fld_fechaCreacionUtc DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_tbl_encabezadoViaje PRIMARY KEY (fld_correlativo),
    CONSTRAINT FK_tbl_encabezadoViaje_tbl_transporte FOREIGN KEY (fld_idTransporte) REFERENCES tbl_transporte(fld_idTransporte),
    CONSTRAINT FK_tbl_encabezadoViaje_tbl_conductor FOREIGN KEY (fld_idConductor) REFERENCES tbl_conductor(fld_idConductor)
) ENGINE=InnoDB;

CREATE TABLE tbl_detalleViaje (
    fld_idDetalle BIGINT AUTO_INCREMENT NOT NULL,
    fld_correlativo BIGINT NOT NULL,
    fld_orden INT NOT NULL,
    fld_descripcion VARCHAR(300) NOT NULL,
    fld_cantidad DECIMAL(18,3) NOT NULL,
    fld_peso DECIMAL(18,3) NOT NULL,
    CONSTRAINT PK_tbl_detalleViaje PRIMARY KEY (fld_idDetalle),
    CONSTRAINT UQ_tbl_detalleViaje_orden UNIQUE (fld_correlativo, fld_orden),
    CONSTRAINT FK_tbl_detalleViaje_tbl_encabezadoViaje FOREIGN KEY (fld_correlativo) REFERENCES tbl_encabezadoViaje(fld_correlativo)
) ENGINE=InnoDB;

CREATE TABLE tbl_detalleLoteViaje (
    fld_idDetalle BIGINT NOT NULL,
    fld_idLote BIGINT NOT NULL,
    fld_cantidadCajas INT NOT NULL,
    fld_pesoKg DECIMAL(18,3) NOT NULL,
    CONSTRAINT PK_tbl_detalleLoteViaje PRIMARY KEY (fld_idDetalle, fld_idLote),
    CONSTRAINT FK_tbl_detalleLote_tbl_detalleViaje FOREIGN KEY (fld_idDetalle) REFERENCES tbl_detalleViaje(fld_idDetalle),
    CONSTRAINT FK_tbl_detalleLote_tbl_loteProducto FOREIGN KEY (fld_idLote) REFERENCES tbl_loteProducto(fld_idLote)
) ENGINE=InnoDB;

/* ============================================================================
   5. MÓDULO DE TELEMETRÍA IOT Y ALERTAS EN TIEMPO REAL
   ============================================================================ */

CREATE TABLE tbl_telemetriaTemperatura (
    fld_idTelemetria BIGINT AUTO_INCREMENT NOT NULL,
    fld_correlativo BIGINT NOT NULL,
    fld_fechaHoraUtc DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fld_temperaturaCelsius DECIMAL(5,2) NOT NULL,
    fld_humedadRelativa DECIMAL(5,2) NULL,
    fld_puertaAbierta BOOLEAN NOT NULL DEFAULT 0,
    fld_ubicacionGps VARCHAR(100) NULL,
    CONSTRAINT PK_tbl_telemetriaTemperatura PRIMARY KEY (fld_idTelemetria),
    CONSTRAINT FK_tbl_telemetria_tbl_encabezadoViaje FOREIGN KEY (fld_correlativo) REFERENCES tbl_encabezadoViaje(fld_correlativo)
) ENGINE=InnoDB;

CREATE TABLE tbl_alertaCadenaFrio (
    fld_idAlerta BIGINT AUTO_INCREMENT NOT NULL,
    fld_correlativo BIGINT NOT NULL,
    fld_idTelemetria BIGINT NOT NULL,
    fld_tipoAlerta VARCHAR(60) NOT NULL,
    fld_temperaturaRegistrada DECIMAL(5,2) NOT NULL,
    fld_atendida BOOLEAN NOT NULL DEFAULT 0,
    fld_observacionCalidad VARCHAR(500) NULL,
    CONSTRAINT PK_tbl_alertaCadenaFrio PRIMARY KEY (fld_idAlerta),
    CONSTRAINT FK_tbl_alerta_tbl_encabezadoViaje FOREIGN KEY (fld_correlativo) REFERENCES tbl_encabezadoViaje(fld_correlativo),
    CONSTRAINT FK_tbl_alerta_tbl_telemetria FOREIGN KEY (fld_idTelemetria) REFERENCES tbl_telemetriaTemperatura(fld_idTelemetria)
) ENGINE=InnoDB;

/* ============================================================================
   6. COSTOS OPERATIVOS Y AUDITORÍA
   ============================================================================ */

CREATE TABLE tbl_costoViaje (
    fld_idCosto BIGINT AUTO_INCREMENT NOT NULL,
    fld_correlativo BIGINT NOT NULL,
    fld_fechaUtc DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fld_monto DECIMAL(18,2) NOT NULL,
    fld_descripcion VARCHAR(250) NOT NULL,
    CONSTRAINT PK_tbl_costoViaje PRIMARY KEY (fld_idCosto),
    CONSTRAINT FK_tbl_costoViaje_tbl_encabezadoViaje FOREIGN KEY (fld_correlativo) REFERENCES tbl_encabezadoViaje(fld_correlativo)
) ENGINE=InnoDB;

CREATE TABLE tbl_bitacoraEncabezado (
    fld_idBitacora BIGINT AUTO_INCREMENT NOT NULL,
    fld_correlativo BIGINT NOT NULL,
    fld_operacion CHAR(1) NOT NULL,
    fld_fechaEventoUtc DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fld_usuarioSql VARCHAR(128) NULL,
    fld_afterJson TEXT NULL,
    CONSTRAINT PK_tbl_bitacoraEncabezado PRIMARY KEY (fld_idBitacora)
) ENGINE=InnoDB;

/* ============================================================================
   7. TRIGGER DE AUDITORÍA AUTOMÁTICA EN MYSQL
   ============================================================================ */

DELIMITER //

CREATE TRIGGER TR_Bitacora_EncabezadoViaje_Insert
AFTER INSERT ON tbl_encabezadoViaje
FOR EACH ROW
BEGIN
    INSERT INTO tbl_bitacoraEncabezado (fld_correlativo, fld_operacion, fld_usuarioSql, fld_afterJson)
    VALUES (
        NEW.fld_correlativo, 
        'I', 
        USER(), 
        JSON_OBJECT(
            'correlativo', NEW.fld_correlativo,
            'estadoViaje', NEW.fld_estadoViaje,
            'idTransporte', NEW.fld_idTransporte,
            'idConductor', NEW.fld_idConductor
        )
    );
END //

DELIMITER ;