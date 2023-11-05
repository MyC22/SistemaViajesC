
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


