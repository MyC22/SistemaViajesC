
--------------------------- Empleado-----------------------------
use sistemaviajes
go
CREATE PROCEDURE guardarEmpleado
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @Dni char(8),
    @nacimiento date,
    @sexo char(1),
	@idcargo int,
	@usuario varchar(50),
	@contrasena varchar(50),
	@tipo varchar(50)
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @Idempleado INT;

    INSERT INTO Empleado (Nombres, Apellido, Nacimiento, SexoEmpl, Dni, IDCargo) 
    VALUES (@nombre, @apellido, @nacimiento,@sexo,@Dni,@idcargo);

    SET @Idempleado = SCOPE_IDENTITY();

    INSERT INTO Usuario (IDEmpleado, Usuario, Contrasena, Tipocuenta) 
    VALUES (@Idempleado,@usuario, @contrasena, @tipo);

    COMMIT TRANSACTION;
END;

go
create procedure listarEmpleadoId @id int
as begin
select * from Empleado as e inner join Usuario as u on u.IDEmpleado = e.ID inner join Cargo as c on c.ID = e.IDCargo where @id = e.ID order by e.ID;
end
go
CREATE PROCEDURE editarEmpleado
	@idempleado int,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @Dni char(8),
    @nacimiento date,
    @sexo char(1),
	@idcargo int,
	@usuario varchar(50),
	@contrasena varchar(50),
	@tipo varchar(50)
AS
BEGIN
update  Empleado
    set Nombres = @nombre, Apellido=@apellido, Nacimiento=@nacimiento,SexoEmpl=@sexo,Dni=@Dni,IDCargo=@idcargo where ID=@idempleado;
update Usuario set Usuario= @usuario, Contrasena=@contrasena, Tipocuenta=@tipo where IDEmpleado=@idempleado;
end
go
CREATE PROCEDURE buscarEmpleado
    @filtro varchar(50),
	@nombre varchar(50)
AS
BEGIN
if @filtro = 'Cargo'
   Select e.ID,e.Nombres,e.Apellido,e.Dni,c.Cargo from Empleado as e  inner join Cargo as c on e.IDCargo = c.ID where c.Cargo LIKe '%' + @nombre + '%';
else if @filtro = 'Nombres'
   Select e.ID,e.Nombres,e.Apellido,e.Dni,c.Cargo from Empleado as e  inner join Cargo as c on e.IDCargo = c.ID where e.Nombres LIKe '%' + @nombre + '%';
else if @filtro = 'Dni'
   Select e.ID,e.Nombres,e.Apellido,e.Dni,c.Cargo from Empleado as e  inner join Cargo as c on e.IDCargo = c.ID where e.Dni LIKe '%' + @nombre + '%';
END;
go

create procedure eliminarEmpleado @id int  as
begin
delete from Usuario where IDEmpleado = @id;
delete from Empleado where ID = @id;
end;

go
--------------------------- Lugares-----------------------------
/*Buscar Lugar*/
CREATE PROCEDURE BuscarLugar
    @ID INT = NULL,
    @Distrito VARCHAR(50) = NULL,
    @Departamento VARCHAR(50) = NULL
AS
BEGIN
    SELECT *
    FROM Lugar
    WHERE (@ID IS NULL OR ID = @ID)
      AND (@Distrito IS NULL OR Distrito = @Distrito)
      AND (@Departamento IS NULL OR Departamento = @Departamento)
END
go
/*Mostrar Lugares*/
CREATE PROCEDURE MostrarTodosLosLugares
AS
BEGIN
    SELECT *
    FROM Lugar
END
go
/*Agregar Lugares*/
CREATE PROCEDURE AgregarLugar
    @Distrito VARCHAR(50),
    @Direccion VARCHAR(100),
    @Terminal VARCHAR(50),
    @Departamento VARCHAR(50),
    @Estado VARCHAR(50)
AS
BEGIN
    INSERT INTO Lugar (Distrito, Direccion, Terminal, Departamento, Estado)
    VALUES (@Distrito, @Direccion, @Terminal, @Departamento, @Estado)
END
go
/*Editar Lugares*/
CREATE PROCEDURE EditarLugar
    @ID INT,
    @Distrito VARCHAR(50),
    @Direccion VARCHAR(100),
    @Terminal VARCHAR(50),
    @Departamento VARCHAR(50),
    @Estado VARCHAR(50)
AS
BEGIN
    UPDATE Lugar
    SET Distrito = @Distrito,
        Direccion = @Direccion,
        Terminal = @Terminal,
        Departamento = @Departamento,
        Estado = @Estado
    WHERE ID = @ID
END
go
/*Eliminar Lugares*/
CREATE PROCEDURE [dbo].[EliminarLugar]
    @ID INT
AS
BEGIN
    DELETE FROM Lugar
    WHERE ID = @ID
END
go
------------------cliente ------------------------
CREATE PROCEDURE MostrarClientePersona
AS
BEGIN
   select ID,Nombres,Apellido,DNI from Cliente where Tipo = 'Persona'
END;
go
CREATE PROCEDURE MostrarClienteEmpresa
AS
BEGIN
   select ID,Nombres,Ruc,Correo from Cliente where Tipo = 'Empresa'
END;
go
create procedure guardarEmpresa
@nombre varchar(200),
@ruc char(11),
@correo Varchar(200),
@celular int,
@tipo varchar(50),
@direccion varchar(100) = null
as begin
insert into Cliente (Nombres, Ruc, Correo,Celular,Direccion,Tipo) 
Values (@nombre,@ruc,@correo,@celular,@direccion,@tipo)
end
go
create procedure guardarPersona 
@nombre varchar(200),
@dni char(8),
@correo Varchar(200),
@celular int,
@tipo varchar(50),
@Apellido varchar(50),
@nacimiento date = null
as begin
insert into Cliente (Nombres,Apellido, DNI, Correo,Celular,Tipo,nacimiento) 
Values (@nombre,@Apellido,@dni,@correo,@celular,@tipo, isnull(@nacimiento,null))
end
go

create procedure editarCliente 
@id int,
@nombre varchar(200),
@dni char(8) = null,
@correo Varchar(200),
@celular int,
@tipo varchar(50),
@Apellido varchar(50) = null,
@nacimiento date = null,
@ruc char(11)=null,
@direccion varchar(100)=null 
as begin
if @tipo = 'Persona'
		update Cliente set Nombres = @nombre, DNI=@dni, Correo = @correo,Celular = @celular ,Apellido= @Apellido,nacimiento = @nacimiento where ID = @id;
else if @tipo = 'Empresa'
		update Cliente set Nombres = @nombre, Ruc=@ruc, Correo = @correo,Celular = @celular ,Direccion= @direccion where ID = @id;
end;
go


------------------Ruta ------------------------
/*Mostrar Rutas*/
CREATE PROCEDURE MostrarRutas
AS
BEGIN
    SELECT R.ID, R.Nombre, L1.Distrito AS Origen, L2.Distrito AS Destino, R.Demora
    FROM Ruta R
    INNER JOIN Lugar L1 ON R.IDOrigen = L1.ID
    INNER JOIN Lugar L2 ON R.IDDestino = L2.ID;
END
go
/*Buscar Ruta*/
CREATE PROCEDURE BuscarRuta
    @ID INT = NULL,
    @NombreRuta VARCHAR(50) = NULL
AS
BEGIN
    SELECT R.ID, R.Nombre, L1.Distrito AS Origen, L2.Distrito AS Destino, R.Demora
    FROM Ruta R
    INNER JOIN Lugar L1 ON R.IDOrigen = L1.ID
    INNER JOIN Lugar L2 ON R.IDDestino = L2.ID
    WHERE (@ID IS NULL OR R.ID = @ID)
      AND (@NombreRuta IS NULL OR R.Nombre LIKE '%' + @NombreRuta + '%');
END
go
/*Elimar Ruta*/
CREATE PROCEDURE EliminarRutaPorID
@RutaID INT
AS
BEGIN
    DELETE FROM Ruta
    WHERE ID = @RutaID;
END
go
/*Editar Ruta*/
CREATE PROCEDURE EditarRuta
@RutaID INT,
@IDOrigen INT,
@IDDestino INT,
@NombreRuta VARCHAR(50),
@Demora TIME
AS
BEGIN
    UPDATE Ruta
    SET IDOrigen = @IDOrigen,
        IDDestino = @IDDestino,
        Nombre = @NombreRuta,
        Demora = @Demora
    WHERE ID = @RutaID;
END
go
/*Agregar Ruta*/
CREATE PROCEDURE AgregarRuta
    @IDOrigen INT,
    @IDDestino INT,
    @NombreRuta VARCHAR(50),
    @Demora TIME
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Lugar WHERE ID = @IDOrigen) AND EXISTS (SELECT 1 FROM Lugar WHERE ID = @IDDestino)
    BEGIN
        INSERT INTO Ruta (IDOrigen, IDDestino, Nombre, Demora)
        VALUES (@IDOrigen, @IDDestino, @NombreRuta, @Demora);
    END
    ELSE
    BEGIN
        THROW 51000, 'Uno o ambos lugares especificados no existen. No se pudo agregar la ruta.', 1;
    END
END
go

----------------------Cronograma--------------------------------------
create procedure MostrarCronograma	
as begin 
select c.ID,r.Nombre as Ruta,l1.Departamento as Origen,l2.Departamento as Destino,c.Placa,s.nombre as Servicio,s.Precio_piso1,s.Precio_piso2,c.Fecha_salida from 
Cronograma_viajes as c 
inner join ruta as r on c.IDRuta = r.ID 
inner join Lugar as l1 on r.IDOrigen = l1.ID 
inner join Lugar as l2 on r.IDDestino = l2.ID
inner join Buses as b on c.Placa = b.Placa
inner join Servicio as s on s.IDCronograma = c.ID where c.Fecha_salida >= GETDATE()
end
go
create procedure crearcronograma
@idruta int,
@placa char(6),
@fecha datetime,
@Idcronograma int,
@nombre varchar(50),
@precio1 real,
@precio2 real

as begin
INSERT INTO Cronograma_viajes(IDRuta, Placa, Fecha_salida) 
    VALUES (@idruta, @placa, @fecha);

    SET @Idcronograma = SCOPE_IDENTITY();

    INSERT INTO Servicio(IDCronograma, nombre, Precio_piso1, Precio_piso2) 
    VALUES (@Idcronograma,@nombre, @precio1, @precio2);

end
