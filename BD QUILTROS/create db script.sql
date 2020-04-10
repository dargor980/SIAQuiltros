CREATE DATABASE QUILTROS
GO
USE QUILTROS;

CREATE TABLE CARGO(
	cod_cargo VARCHAR(10) PRIMARY KEY,
	descripcion VARCHAR(100)
	);

CREATE TABLE CREDENCIAL(
	cod_credencial INT IDENTITY PRIMARY KEY,
	usuario VARCHAR(90),
	contraseña VARCHAR(90)
);

CREATE TABLE ACTIVIDAD(
	cod_actividad VARCHAR(10) PRIMARY KEY,
	nombre VARCHAR(100),
	lugar VARCHAR(100),
	descripcion varchar(100)
);

CREATE TABLE VOLUNTARIO(
	rut VARCHAR(9) PRIMARY KEY,
	cod_credencial INT,
	nombre VARCHAR(100),
	telefono VARCHAR(10),
	direccion VARCHAR(100),
	correo VARCHAR(100)
	FOREIGN KEY(cod_credencial) REFERENCES CREDENCIAL(cod_credencial)
);

CREATE TABLE REALIZA(
	cod_voluntario VARCHAR(9),
	cod_actividad VARCHAR(10),
	FOREIGN KEY(cod_voluntario) REFERENCES VOLUNTARIO(rut),
	FOREIGN KEY(cod_actividad) REFERENCES ACTIVIDAD(cod_actividad)
);

CREATE TABLE POSEE(
	cod_cargo VARCHAR(10),
	cod_voluntario VARCHAR(9),
	fecha DATETIME,
	FOREIGN KEY(cod_cargo) REFERENCES CARGO(cod_cargo),
	FOREIGN KEY(cod_voluntario) REFERENCES VOLUNTARIO(rut)
);

CREATE TABLE ADOPTANTE(
	rut VARCHAR(9) PRIMARY KEY,
	cod_voluntario VARCHAR(9),
	nombre VARCHAR(100),
	direccion VARCHAR(100),
	telefono VARCHAR(10),
	comuna VARCHAR(100),
	FOREIGN KEY(cod_voluntario) REFERENCES VOLUNTARIO(rut)
	);

CREATE TABLE MASCOTA(
	cod_chip VARCHAR(10) PRIMARY KEY,
	cod_actividad VARCHAR(10),
	cod_adoptante VARCHAR(9),
	nombre VARCHAR(100),
	edad INT,
	especie VARCHAR(100),
	sexo VARCHAR(100),
	raza VARCHAR (100),
	tamaño VARCHAR(100),
	color VARCHAR(100),
	descripcion VARCHAR(MAX),
	estado VARCHAR(100),
	imagen varbinary(MAX),
	FOREIGN KEY (cod_actividad) REFERENCES ACTIVIDAD(cod_actividad),
	FOREIGN KEY (cod_adoptante) REFERENCES ADOPTANTE(rut)
	);

CREATE TABLE SOCIO(
	rut VARCHAR(9) PRIMARY KEY,
	nombre VARCHAR(100),
	direccion VARCHAR(100),
	Telefono VARCHAR(10),
	cuenta_bancaria VARCHAR(20),
	banco VARCHAR(100)
	);

CREATE TABLE HOGAR_TEMPORAL(
	cod_hogar_temporal INT IDENTITY PRIMARY KEY,
	cod_socio VARCHAR(9),
	cod_mascota VARCHAR(10),
	direccion VARCHAR(100),
	comuna VARCHAR(100),
	fecha_llegada DATETIME,
	fecha_salida DATETIME,
	FOREIGN KEY(cod_socio) REFERENCES SOCIO(rut),
	FOREIGN KEY(cod_mascota) REFERENCES MASCOTA(cod_chip)
);

CREATE TABLE CUIDA(
	cod_voluntario VARCHAR(9),
	cod_mascota VARCHAR(10),
	fecha DATETIME,
	FOREIGN KEY(cod_voluntario) REFERENCES VOLUNTARIO(rut),
	FOREIGN KEY(cod_mascota) REFERENCES MASCOTA(cod_chip)
	);
CREATE TABLE DONACION(
	cod_donacion INT IDENTITY PRIMARY KEY,
	cod_socio VARCHAR(9),
	monto INT,
	fecha DATETIME,
	FOREIGN KEY(cod_socio) REFERENCES SOCIO(rut)
	);




