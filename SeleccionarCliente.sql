CREATE PROCEDURE BuscarClientePorDistrito (
    @DistritoBusqueda varchar(50)
)
AS
BEGIN
    SELECT 
        C.Nombres AS NombreCliente,
        C.Apellido AS ApellidoCliente,
        C.Celular AS CelularCliente,
        L.Distrito AS DistritoViaje,
        L.Departamento AS DepartamentoViaje
    FROM 
        Cliente C
    INNER JOIN Recervaciones R ON C.ID = R.IDCliente
    INNER JOIN Cronograma_viajes CV ON R.IDCronograma = CV.ID
    INNER JOIN Ruta RUTA ON CV.IDRuta = RUTA.ID
    INNER JOIN Lugar L ON RUTA.IDDestino = L.ID
    WHERE L.Distrito = @DistritoBusqueda;
END;

CREATE PROCEDURE MostrarCliente
AS
BEGIN
    SELECT
        C.Nombres AS NombreCliente,
        C.Apellido AS ApellidoCliente,
        C.Celular AS CelularCliente,
        L.Distrito AS DistritoViaje,
        L.Departamento AS DepartamentoViaje
    FROM
        Cliente C
    INNER JOIN Recervaciones R ON C.ID = R.IDCliente
    INNER JOIN Cronograma_viajes CV ON R.IDCronograma = CV.ID
    INNER JOIN Ruta RUTA ON CV.IDRuta = RUTA.ID
    INNER JOIN Lugar L ON RUTA.IDDestino = L.ID;
END;

