create database sistemaviajes
go
use sistemaviajes
go
CREATE TABLE Boletos (
  ID            int IDENTITY NOT NULL, 
  IDPasajero    int NOT NULL UNIQUE, 
  IDServicio    int NOT NULL, 
  IDComprobante int NOT NULL, 
  Precio        float(10) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Buses (
  Placa      char(6) NOT NULL, 
  IDModelo   int NOT NULL, 
  Lugar      varchar(50) NOT NULL, 
  Disponible datetime NOT NULL, 
  PRIMARY KEY (Placa));
CREATE TABLE Cargo (
  ID          int IDENTITY NOT NULL, 
  Cargo       varchar(50) NOT NULL, 
  Descripcion varchar(255) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Cliente (
  ID         int IDENTITY NOT NULL, 
  Nombres    varchar(200) NOT NULL, 
  Apellido   varchar(50) NULL, 
  DNI        char(8) NULL , 
  Ruc        char(11) NULL , 
  Correo     varchar(200) NOT NULL, 
  Celular    int NOT NULL, 
  nacimiento date NULL, 
  Tipo       varchar(50) NOT NULL, 
  Direccion  varchar(100) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Comprobante (
  ID              int IDENTITY NOT NULL, 
  IDCliente       int NOT NULL, 
  Fecha           datetime NOT NULL, 
  Precio_total    float(10) NOT NULL, 
  Costo_igv       float(10) NOT NULL, 
  Precio          float(10) NOT NULL, 
  TipoComprobante varchar(50) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Cronograma_viajes (
  ID           int IDENTITY NOT NULL, 
  Placa        char(6) NOT NULL, 
  IDRuta       int NOT NULL, 
  IDusuario    varchar(50) NOT NULL, 
  Fecha_salida datetime NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Empleado (
  ID         int IDENTITY NOT NULL, 
  IDCargo    int NULL, 
  Dni        char(8) NOT NULL UNIQUE, 
  Nombres    varchar(100) NOT NULL, 
  Apellido   varchar(100) NOT NULL, 
  SexoEmpl   char(1) NOT NULL, 
  Nacimiento date NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Lugar (
  ID           int IDENTITY NOT NULL, 
  Distrito     varchar(50) NOT NULL, 
  Direccion    varchar(100) NOT NULL, 
  Terminal     varchar(50) NOT NULL, 
  Departamento varchar(50) NOT NULL, 
  Estado       varchar(50) NOT NULL, 
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
CREATE TABLE Recervaciones (
  ID            int IDENTITY NOT NULL, 
  IDCronograma  int NOT NULL, 
  IDCliente     int NOT NULL, 
  Fecha_limite  datetime NOT NULL, 
  Estado        varchar(50) NOT NULL, 
  Cantidad      int NOT NULL, 
  Fecha_recerva datetime NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Ruta (
  ID        int IDENTITY NOT NULL, 
  IDOrigen  int NOT NULL, 
  IDDestino int NOT NULL, 
  Nombre    varchar(50) NOT NULL, 
  Demora    time(7) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Servicio (
  ID           int IDENTITY NOT NULL, 
  IDCronograma int NOT NULL UNIQUE, 
  nombre       varchar(50) NOT NULL, 
  Precio_piso1 float(10) NOT NULL, 
  Precio_piso2 float(10) NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Turnos_definidos (
  ID   int IDENTITY NOT NULL, 
  Hora time(7) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Usuario (
  Usuario    varchar(50) NOT NULL, 
  IDEmpleado int NOT NULL UNIQUE, 
  Contrasena varchar(50) NOT NULL, 
  Tipocuenta varchar(50) NOT NULL, 
  PRIMARY KEY (Usuario));
ALTER TABLE Cronograma_viajes ADD CONSTRAINT FKCronograma605734 FOREIGN KEY (IDusuario) REFERENCES Usuario (Usuario);
ALTER TABLE Recervaciones ADD CONSTRAINT FKRecervacio330165 FOREIGN KEY (IDCronograma) REFERENCES Cronograma_viajes (ID);
ALTER TABLE Cronograma_viajes ADD CONSTRAINT FKCronograma54920 FOREIGN KEY (Placa) REFERENCES Buses (Placa);
ALTER TABLE Cronograma_viajes ADD CONSTRAINT FKCronograma852108 FOREIGN KEY (IDRuta) REFERENCES Ruta (ID);
ALTER TABLE Ruta ADD CONSTRAINT FKRuta785889 FOREIGN KEY (IDDestino) REFERENCES Lugar (ID);
ALTER TABLE Ruta ADD CONSTRAINT FKRuta395954 FOREIGN KEY (IDOrigen) REFERENCES Lugar (ID);
ALTER TABLE Empleado ADD CONSTRAINT FKEmpleado374290 FOREIGN KEY (IDCargo) REFERENCES Cargo (ID);
ALTER TABLE Usuario ADD CONSTRAINT FKUsuario6883 FOREIGN KEY (IDEmpleado) REFERENCES Empleado (ID);
ALTER TABLE Boletos ADD CONSTRAINT FKBoletos575112 FOREIGN KEY (IDPasajero) REFERENCES pasajero (ID);
ALTER TABLE Servicio ADD CONSTRAINT FKServicio502048 FOREIGN KEY (IDCronograma) REFERENCES Cronograma_viajes (ID);
ALTER TABLE Boletos ADD CONSTRAINT FKBoletos707533 FOREIGN KEY (IDServicio) REFERENCES Servicio (ID);
ALTER TABLE Boletos ADD CONSTRAINT FKBoletos402866 FOREIGN KEY (IDComprobante) REFERENCES Comprobante (ID);
ALTER TABLE Comprobante ADD CONSTRAINT FKComprobant709029 FOREIGN KEY (IDCliente) REFERENCES Cliente (ID);
ALTER TABLE Recervaciones ADD CONSTRAINT FKRecervacio28818 FOREIGN KEY (IDCliente) REFERENCES Cliente (ID);
ALTER TABLE Buses ADD CONSTRAINT FKBuses525865 FOREIGN KEY (IDModelo) REFERENCES ModeloBus (ID);
go
insert into Cargo (Cargo, Descripcion) values ('Administrador','Administrador')
go
insert into Cargo (Cargo, Descripcion) values ('Gerente general','Encargado general de la empresa')
go