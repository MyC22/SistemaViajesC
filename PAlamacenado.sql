
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
create procedure guardarEmpresa @nombre varchar(200), @ruc int, @correo Varchar(200), @celular int, @tipo varchar(50), @direccion varchar(100) 
as begin
insert into Cliente (Nombres, Ruc, Correo,Celular,Direccion,Tipo) Values (@nombre,@ruc,@correo,@celular,@direccion,@tipo)
end
go
create procedure guardarPersona @nombre varchar(200), @dni char(8), @correo Varchar(200), @celular int, @tipo varchar(50), @Apellido varchar(50), @nacimiento date = null
as begin
insert into Cliente (Nombres, DNI, Correo,Celular,Apellido,Tipo,nacimiento) Values (@nombre,@Apellido,@dni,@correo,@celular,@tipo, isnull(@nacimiento,null))
end
go

