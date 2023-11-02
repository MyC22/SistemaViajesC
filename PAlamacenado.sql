CREATE PROCEDURE guardarEmpleado
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @Dni char(8),
    @Edad int,
    @sexo char(1),
	@idcargo int,
	@usuario varchar(50),
	@contrasena varchar(50),
	@tipo varchar(50)
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @Idempleado INT;

    INSERT INTO Empleado (Nombres, Apellido, EdadEmpl, SexoEmpl, Dni, IDCargo) 
    VALUES (@nombre, @apellido, @Edad,@sexo,@Dni,@idcargo);

    SET @Idempleado = SCOPE_IDENTITY();

    INSERT INTO Usuario (IDEmpleado, Usuario, Contrasena, Tipocuenta) 
    VALUES (@Idempleado,@usuario, @contrasena, @tipo);

    COMMIT TRANSACTION;
END;
