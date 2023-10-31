create database sistemaviajes
go
use sistemaviajes
go
CREATE TABLE Boletos (
  ID         int IDENTITY NOT NULL, 
  IDPasajero int NOT NULL, 
  IDClase    int NOT NULL, 
  IDFactura  int NOT NULL, 
  Precio     float(10) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Buses (
  ID         int IDENTITY NOT NULL, 
  IDModelo   int NOT NULL, 
  Placa      int NOT NULL, 
  Lugar      varchar(50) NOT NULL, 
  Disponible datetime NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Cargo (
  ID          int IDENTITY NOT NULL, 
  Cargo       varchar(50) NOT NULL, 
  Descripcion varchar(255) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Clase (
  ID             int IDENTITY NOT NULL, 
  IDProgramacion int NOT NULL UNIQUE, 
  nombre         varchar(50) NOT NULL, 
  Precio         float(10) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Cliente (
  ID         int IDENTITY NOT NULL, 
  Nombres    varchar(50) NOT NULL, 
  Apellido   varchar(50) NOT NULL, 
  DNI        char(8) NOT NULL UNIQUE, 
  Correo     varchar(200) NOT NULL, 
  Celular    int NOT NULL, 
  nacimiento datetime NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Empleado (
  ID       int IDENTITY NOT NULL, 
  IDCargo  int NOT NULL, 
  Dni      char(8) NOT NULL UNIQUE, 
  Nombres  varchar(100) NOT NULL, 
  Apellido varchar(100) NOT NULL, 
  EdadEmpl int NOT NULL, 
  SexoEmpl char(1) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Factura (
  ID             int IDENTITY NOT NULL, 
  IDCliente      int NOT NULL, 
  IDProgramacion int NOT NULL, 
  IDEmpleado     int NOT NULL, 
  Fecha          datetime NOT NULL, 
  Precio_total   float(10) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE ModeloBus (
  ID       int IDENTITY NOT NULL, 
  Modelo   char(10) NOT NULL, 
  Asientos int NOT NULL, 
  Tamaño   varchar(50) NOT NULL, 
  pisos    int NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE pasajero (
  ID        int IDENTITY NOT NULL, 
  Nombres   varchar(50) NOT NULL, 
  Apellidos varchar(50) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Programacion (
  ID            int IDENTITY NOT NULL, 
  IDBuses       int NOT NULL, 
  Origen        varchar(50) NOT NULL, 
  Fecha_salida  datetime NOT NULL, 
  Fecha_llegada datetime NOT NULL, 
  Destino       varchar(50) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Recervaciones (
  ID           int IDENTITY NOT NULL, 
  IDClase      int NOT NULL, 
  IDCliente    int NOT NULL, 
  IDPasajero   int NOT NULL, 
  Fecha_limite datetime NOT NULL, 
  Estado       varchar(50) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Turnos_definidos (
  ID   int IDENTITY NOT NULL, 
  Hora datetime NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Usuario (
  Usuario    varchar(50) NOT NULL, 
  IDEmpleado int NOT NULL UNIQUE, 
  Contrasena varchar(50) NOT NULL, 
  Tipocuenta varchar(50) NOT NULL, 
  PRIMARY KEY (Usuario));
CREATE TABLE Viajes_definidos (
  ID      int IDENTITY NOT NULL, 
  Origen  varchar(50) NOT NULL, 
  Destino varchar(50) NOT NULL, 
  Demora  datetime NOT NULL, 
  PRIMARY KEY (ID));
ALTER TABLE Recervaciones ADD CONSTRAINT FKRecervacio144249 FOREIGN KEY (IDPasajero) REFERENCES pasajero (ID);
ALTER TABLE Boletos ADD CONSTRAINT FKBoletos575112 FOREIGN KEY (IDPasajero) REFERENCES pasajero (ID);
ALTER TABLE Factura ADD CONSTRAINT FKFactura40088 FOREIGN KEY (IDEmpleado) REFERENCES Empleado (ID);
ALTER TABLE Recervaciones ADD CONSTRAINT FKRecervacio861723 FOREIGN KEY (IDClase) REFERENCES Clase (ID);
ALTER TABLE Clase ADD CONSTRAINT FKClase422916 FOREIGN KEY (IDProgramacion) REFERENCES Programacion (ID);
ALTER TABLE Boletos ADD CONSTRAINT FKBoletos142362 FOREIGN KEY (IDClase) REFERENCES Clase (ID);
ALTER TABLE Boletos ADD CONSTRAINT FKBoletos184753 FOREIGN KEY (IDFactura) REFERENCES Factura (ID);
ALTER TABLE Factura ADD CONSTRAINT FKFactura962104 FOREIGN KEY (IDProgramacion) REFERENCES Programacion (ID);
ALTER TABLE Factura ADD CONSTRAINT FKFactura122552 FOREIGN KEY (IDCliente) REFERENCES Cliente (ID);
ALTER TABLE Recervaciones ADD CONSTRAINT FKRecervacio28818 FOREIGN KEY (IDCliente) REFERENCES Cliente (ID);
ALTER TABLE Empleado ADD CONSTRAINT FKEmpleado374290 FOREIGN KEY (IDCargo) REFERENCES Cargo (ID);
ALTER TABLE Usuario ADD CONSTRAINT FKUsuario6883 FOREIGN KEY (IDEmpleado) REFERENCES Empleado (ID);
ALTER TABLE Buses ADD CONSTRAINT FKBuses525865 FOREIGN KEY (IDModelo) REFERENCES ModeloBus (ID);
ALTER TABLE Programacion ADD CONSTRAINT FKProgramaci901602 FOREIGN KEY (IDBuses) REFERENCES Buses (ID);
