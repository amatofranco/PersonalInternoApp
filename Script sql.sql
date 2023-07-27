
CREATE DATABASE VITTALDATABASE;

USE VITTALDATABASE;

CREATE TABLE Usuarios (

UsuarioID INT IDENTITY PRIMARY KEY,
Nombre VARCHAR (15),
Contraseña VARCHAR (15)
)

CREATE TABLE Empleados (

EmpleadoID INT IDENTITY PRIMARY KEY,
Apellido VARCHAR (15) NOT NULL,
Nombre VARCHAR (15) NOT NULL,
Dni INT NOT NULL,
Email  VARCHAR (30) NOT NULL,
Celular INT NOT NULL
)

INSERT INTO Usuarios (Nombre, Contraseña)
VALUES ('admin','admin')

INSERT INTO Empleados (Apellido,Nombre,Dni,Email,Celular)
VALUES ('Amato', 'Franco',35890890,'francoamato@hotmail.com',1150806789)


