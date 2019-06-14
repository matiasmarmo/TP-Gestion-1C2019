INSERT INTO ZAFFA_TEAM.Rol (NOMBRE_ROL, ESTADO_ROL)
VALUES ('Cliente', 'A')

--INSERT INTO ZAFFA_TEAM.Rol (NOMBRE_ROL, ESTADO_ROL)
--VALUES ('Administrativo', 'A')

INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('AbmRol');
INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('AbmCrucero');
INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('AbmPuerto');
INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('AbmRecorrido');
INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('CompraReservaPasaje');
INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('GeneracionViaje');
INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('ListadoEstadistico');
INSERT INTO ZAFFA_TEAM.Funcionalidad (DESCRIPCION_FUNC) VALUES ('PagoReserva');

--INSERT INTO ZAFFA_TEAM.[Funcionalidad x Rol] 

--INSERT INTO ZAFFA_TEAM.Administrativo (USERNAME, PASSWORD, INTENTOS_FALLIDOS, NOMBRE_ROL, ESTADO_ADMIN) 

INSERT ZAFFA_TEAM.Cliente (CLI_NOMBRE, CLI_APELLIDO, CLI_DNI, CLI_FECHA_NAC, CLI_DIRECCION, CLI_MAIL, CLI_TELEFONO, NOMBRE_ROL)
SELECT DISTINCT CLI_NOMBRE, CLI_APELLIDO, CLI_DNI, CLI_FECHA_NAC, CLI_DIRECCION, CLI_MAIL, CLI_TELEFONO, 'Cliente'
FROM gd_esquema.Maestra


----------- .: PUERTO :. ----------------
INSERT ZAFFA_TEAM.Puerto (NOMBRE_PUERTO, ESTADO_PUERTO)
SELECT DISTINCT PUERTO_DESDE, 'A'
FROM gd_esquema.Maestra 

----------- .: MARCA :. ----------------
INSERT ZAFFA_TEAM.Marca (CRUCERO_FABRICANTE)
SELECT DISTINCT CRU_FABRICANTE
FROM gd_esquema.Maestra

----------- .: TIPO CABINA :. ----------------
INSERT ZAFFA_TEAM.Tipo_Cabina (CABINA_TIPO_DESCRIPCION, CABINA_TIPO_RECARGO)
SELECT DISTINCT CABINA_TIPO, CABINA_TIPO_PORC_RECARGO
FROM gd_esquema.Maestra

----------- .: CABINA :. ----------------
INSERT ZAFFA_TEAM.Cabina(CRUCERO_ID,CABINA_NRO,CABINA_PISO,CABINA_TIPO_ID)
SELECT DISTINCT CRUCERO_IDENTIFICADOR,
				CABINA_NRO,
				CABINA_PISO,
				(SELECT DISTINCT CABINA_TIPO_ID 
					FROM ZAFFA_TEAM.Tipo_Cabina
					WHERE CABINA_TIPO_DESCRIPCION = CABINA_TIPO)
FROM gd_esquema.Maestra

----------- .: CRUCERO :. ----------------
INSERT ZAFFA_TEAM.Crucero (CRUCERO_ID, CRUCERO_MODELO, CRUCERO_MARCA_ID, ESTADO_CRUCERO, CANTIDAD_CABINAS)
SELECT DISTINCT CRUCERO_IDENTIFICADOR, 
				CRUCERO_MODELO,
				(SELECT DISTINCT CRUCERO_MARCA_ID
			       FROM ZAFFA_TEAM.Marca mar
		           WHERE mar.CRUCERO_FABRICANTE = mae.CRU_FABRICANTE ),
				'Alta',
				(SELECT count(*)
					FROM ZAFFA_TEAM.Cabina cab
					WHERE cab.CRUCERO_ID = mae.CRUCERO_IDENTIFICADOR)
FROM gd_esquema.Maestra mae

----------- .: RECORRIDO :. ----------------
INSERT ZAFFA_TEAM.Recorrido_Unico (RECORRIDO_CODIGO)
SELECT DISTINCT RECORRIDO_CODIGO
FROM gd_esquema.Maestra

----------- .: TRAMO :. ----------------
INSERT ZAFFA_TEAM.Tramo (RECORRIDO_CODIGO, ORDEN_TRAMOS, PUERTO_DESDE_ID, PUERTO_HASTA_ID, RECORRIDO_PRECIO_BASE) 
SELECT DISTINCT RECORRIDO_CODIGO, 
				(CASE 
					WHEN ((SELECT DISTINCT mae1.PUERTO_DESDE 
							FROM gd_esquema.Maestra mae1
							WHERE mae.RECORRIDO_CODIGO = mae1.RECORRIDO_CODIGO AND mae1.PUERTO_DESDE = mae.PUERTO_HASTA) IS NOT NULL )
						OR
						((SELECT COUNT (*)
						FROM gd_esquema.Maestra mae2
						WHERE MAE.RECORRIDO_CODIGO = MAE2.RECORRIDO_CODIGO AND MAE.PUERTO_DESDE <> MAE2.PUERTO_DESDE) = 0)
					THEN 1
					ELSE 2 
				END), 
				(SELECT PUERTO_ID 
					FROM ZAFFA_TEAM.Puerto
					WHERE mae.PUERTO_DESDE = NOMBRE_PUERTO),
				(SELECT PUERTO_ID 
					FROM ZAFFA_TEAM.Puerto
					WHERE mae.PUERTO_HASTA = NOMBRE_PUERTO),
				RECORRIDO_PRECIO_BASE
FROM gd_esquema.Maestra mae

----------- .: VIAJE :. ----------------
INSERT ZAFFA_TEAM.Viaje (RECORRIDO_CODIGO, FECHA_SALIDA, FECHA_LLEGADA, FECHA_LLEGADA_ESTIMADA, CRUCERO_ID)
SELECT DISTINCT RECORRIDO_CODIGO, FECHA_SALIDA, FECHA_LLEGADA, FECHA_LLEGADA_ESTIMADA, CRUCERO_IDENTIFICADOR
FROM gd_esquema.Maestra


----------- .: PASAJE :. ----------------
INSERT INTO ZAFFA_TEAM.Pasaje (PASAJE_CODIGO, PASAJE_PRECIO, PASAJE_FECHA_COMPRA, CLI_ID, VIAJE_ID, CRUCERO_ID, CABINA_NRO, CABINA_PISO, MEDIO_DE_PAGO)
SELECT  mae.PASAJE_CODIGO, 
		mae.PASAJE_PRECIO, 
		mae.PASAJE_FECHA_COMPRA,
		(SELECT cli.CLI_ID 
					FROM ZAFFA_TEAM.Cliente cli
					WHERE mae.CLI_DNI = cli.CLI_DNI and
						mae.CLI_NOMBRE = cli.CLI_NOMBRE),
		(SELECT via.VIAJE_ID 
					FROM ZAFFA_TEAM.Viaje via
					WHERE mae.RECORRIDO_CODIGO = via.RECORRIDO_CODIGO and 
						mae.FECHA_SALIDA = via.FECHA_SALIDA and 
						mae.FECHA_LLEGADA = via.FECHA_LLEGADA and
						mae.CRUCERO_IDENTIFICADOR = via.CRUCERO_ID),
		mae.CRUCERO_IDENTIFICADOR, 
		mae.CABINA_NRO, 
		mae.CABINA_PISO, 
		''
FROM gd_esquema.Maestra mae
WHERE mae.PASAJE_CODIGO is not null




----------- .: FUNCIONALIDAD X ROL :. ----------------

INSERT ZAFFA_TEAM.[Funcionalidad x Rol] (NOMBRE_ROL,FUNCIONALIDAD)
SELECT 'Administrativo',Funcionalidad
FROM ZAFFA_TEAM.Funcionalidad

INSERT INTO ZAFFA_TEAM.[Funcionalidad x Rol] (NOMBRE_ROL,FUNCIONALIDAD) 
VALUES ('Cliente',(select Funcionalidad 
from ZAFFA_TEAM.Funcionalidad 
where DESCRIPCION_FUNC = 'CompraReservaPasaje'));

INSERT INTO ZAFFA_TEAM.[Funcionalidad x Rol] (NOMBRE_ROL,FUNCIONALIDAD) 
VALUES ('Cliente',(select Funcionalidad 
from ZAFFA_TEAM.Funcionalidad 
where DESCRIPCION_FUNC = 'PagoReserva'));



----------- .: RESERVA :. ----------------
/*
INSERT INTO ZAFFA_TEAM.Reserva (RESERVA_CODIGO, RESERVA_FECHA, CLI_ID, VIAJE_ID, CRUCERO_ID, CABINA_NRO, CABINA_PISO, PASAJE_CODIGO)
SELECT	mae.RESERVA_CODIGO, 
		mae.RESERVA_FECHA, 
		(SELECT cli.CLI_ID 
					FROM ZAFFA_TEAM.Cliente cli
					WHERE mae.CLI_DNI = cli.CLI_DNI and
						mae.CLI_NOMBRE = cli.CLI_NOMBRE and
						mae.CLI_APELLIDO = cli.CLI_APELLIDO),
		(SELECT via.VIAJE_ID 
					FROM ZAFFA_TEAM.Viaje via
					WHERE mae.RECORRIDO_CODIGO = via.RECORRIDO_CODIGO and 
						mae.FECHA_SALIDA = via.FECHA_SALIDA and 
						mae.FECHA_LLEGADA = via.FECHA_LLEGADA and
						mae.CRUCERO_IDENTIFICADOR = via.CRUCERO_ID),
		mae.CRUCERO_IDENTIFICADOR, 
		mae.CABINA_NRO, 
		mae.CABINA_PISO, 
		(SELECT pas.PASAJE_CODIGO
			FROM ZAFFA_TEAM.Pasaje pas
			INNER JOIN ZAFFA_TEAM.Cliente cli on cli.CLI_ID = pas.CLI_ID
			INNER JOIN ZAFFA_TEAM.Viaje via on via.VIAJE_ID = pas.VIAJE_ID
			WHERE mae.CLI_DNI = cli.CLI_DNI and mae.CLI_APELLIDO = cli.CLI_APELLIDO and mae.CLI_NOMBRE = cli.CLI_NOMBRE and
				mae.CRUCERO_IDENTIFICADOR = pas.CRUCERO_ID and
				mae.CABINA_NRO = pas.CABINA_NRO and
				mae.CABINA_PISO = pas.CABINA_PISO and
				mae.RECORRIDO_CODIGO = via.RECORRIDO_CODIGO and
				mae.FECHA_SALIDA = via.FECHA_SALIDA and 
				mae.FECHA_LLEGADA = via.FECHA_LLEGADA)
FROM gd_esquema.Maestra mae
WHERE mae.RESERVA_CODIGO is not null
*/

----------- .: TRIGGER TABLA RESERVA :. ----------------
CREATE TRIGGER Borrar_Reservas_Mayores_A_Tres_Dias
ON ZAFFA_TEAM.Reserva
AFTER DELETE AS  
BEGIN
	DELETE FROM ZAFFA_TEAM.Reserva
	WHERE DATEDIFF(DAY, RESERVA_FECHA, GETDATE()) > 3;  
END


----------- .: TRIGGER TABLA CRUCERO :. ----------------
CREATE TRIGGER Auditoria_de_estado_cruceros
ON ZAFFA_TEAM.Crucero
AFTER UPDATE AS  
BEGIN
	if((SELECT ESTADO_CRUCERO FROM inserted) <> (SELECT ESTADO_CRUCERO FROM deleted))
		INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (FECHA, ID_CRUCERO, ESTADO_ANTERIOR, ESTADO_ACTUAL)
		(SELECT getDate(), i.CRUCERO_ID, d.ESTADO_CRUCERO, i.ESTADO_CRUCERO  
			FROM inserted i , deleted d)
END



-------------------------------------------------------------------
-------------------- TESTING --------------------------------------
-------------------------------------------------------------------

GO
CREATE PROCEDURE ZAFFA_TEAM.sp_guardarCrucero(@crucero_id nvarchar(50),@crucero_modelo NVARCHAR(50), @crucero_marca_id INT, @estado_crucero NVARCHAR(25), @cantidad_cabinas INT)
AS
	BEGIN TRANSACTION tr	

	BEGIN TRY

		INSERT INTO ZAFFA_TEAM.Crucero(CRUCERO_ID,CRUCERO_MODELO,CRUCERO_MARCA_ID,ESTADO_CRUCERO,CANTIDAD_CABINAS) 
		VALUES (@crucero_id,@crucero_modelo,@crucero_marca_id,@estado_crucero,@cantidad_cabinas)
		
		
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION tr
		DECLARE @mensaje VARCHAR(255) = ERROR_MESSAGE()
		RAISERROR(@mensaje,11,0)

		RETURN
	END CATCH

	COMMIT TRANSACTION tr
GO

CREATE PROCEDURE ZAFFA_TEAM.sp_guardarPuerto(@puerto_ID INT,@nombre_puerto nvarchar(255), @estado_puerto char(1))
AS
	BEGIN TRANSACTION tr	

	BEGIN TRY

		INSERT INTO ZAFFA_TEAM.Puerto(PUERTO_ID,NOMBRE_PUERTO,ESTADO_PUERTO) 
		VALUES (@puerto_ID,@nombre_puerto,@estado_puerto) 


	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION tr
		DECLARE @mensaje VARCHAR(255) = ERROR_MESSAGE()
		RAISERROR(@mensaje,11,0)

		RETURN
	END CATCH

	COMMIT TRANSACTION tr
GO



CREATE PROCEDURE ZAFFA_TEAM.sp_guardarRecorrido(@id_recorrido decimal(18,0),@orden_tramo int,@puerto_desde nvarchar(255),@puerto_hasta nvarchar(255),@precio_recorrido decimal(18,0))
AS

DECLARE @puerto_desde_id int
DECLARE @puerto_hasta_id int

SET @puerto_desde_id = (select PUERTO_ID from ZAFFA_TEAM.puerto where NOMBRE_PUERTO = @puerto_desde)
SET @puerto_hasta_id = (select PUERTO_ID from ZAFFA_TEAM.puerto where NOMBRE_PUERTO = @puerto_hasta)

	BEGIN TRANSACTION tr	

	BEGIN TRY

		INSERT INTO ZAFFA_TEAM.Recorrido_Unico(RECORRIDO_CODIGO)
		VALUES (@id_recorrido)

		INSERT INTO ZAFFA_TEAM.Tramo(RECORRIDO_CODIGO,ORDEN_TRAMOS,PUERTO_DESDE_ID,PUERTO_HASTA_ID,RECORRIDO_PRECIO_BASE) 
		VALUES (@id_recorrido,@orden_tramo,@puerto_desde_id,@puerto_hasta_id,@precio_recorrido) 

	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION tr
		DECLARE @mensaje VARCHAR(255) = ERROR_MESSAGE()
		RAISERROR(@mensaje,11,0)

		RETURN
	END CATCH

	COMMIT TRANSACTION tr
GO


CREATE PROCEDURE ZAFFA_TEAM.sp_guardarSoloTramo(@id_recorrido decimal(18,0),@orden_tramo int,@puerto_desde nvarchar(255),@puerto_hasta nvarchar(255),@precio_recorrido decimal(18,0))
AS

DECLARE @puerto_desde_id int
DECLARE @puerto_hasta_id int

SET @puerto_desde_id = (select PUERTO_ID from ZAFFA_TEAM.puerto where NOMBRE_PUERTO = @puerto_desde)
SET @puerto_hasta_id = (select PUERTO_ID from ZAFFA_TEAM.puerto where NOMBRE_PUERTO = @puerto_hasta)

	BEGIN TRANSACTION tr	

	BEGIN TRY

		INSERT INTO ZAFFA_TEAM.Tramo(RECORRIDO_CODIGO,ORDEN_TRAMOS,PUERTO_DESDE_ID,PUERTO_HASTA_ID,RECORRIDO_PRECIO_BASE) 
		VALUES (@id_recorrido,@orden_tramo,@puerto_desde_id,@puerto_hasta_id,@precio_recorrido) 

	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION tr
		DECLARE @mensaje VARCHAR(255) = ERROR_MESSAGE()
		RAISERROR(@mensaje,11,0)

		RETURN
	END CATCH

	COMMIT TRANSACTION tr
GO

CREATE PROCEDURE ZAFFA_TEAM.sp_borrarTramo(@id_recorrido decimal(18,0))
AS

	BEGIN TRANSACTION tr	

	BEGIN TRY

		DELETE 
		FROM ZAFFA_TEAM.Tramo 
		WHERE RECORRIDO_CODIGO = @id_recorrido 

	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION tr
		DECLARE @mensaje VARCHAR(255) = ERROR_MESSAGE()
		RAISERROR(@mensaje,11,0)

		RETURN
	END CATCH

	COMMIT TRANSACTION tr
GO


CREATE PROCEDURE ZAFFA_TEAM.sp_updateTramo(@codRec Decimal(18,0),@ordenTramo int,@puertoD nvarchar(255),@puertoA nvarchar(255),@nuevoPrecio Decimal(18,0))
AS

DECLARE @puerto_desde_id int
DECLARE @puerto_hasta_id int

SET @puerto_desde_id = (select PUERTO_ID from ZAFFA_TEAM.puerto where NOMBRE_PUERTO = @puertoD)
SET @puerto_hasta_id = (select PUERTO_ID from ZAFFA_TEAM.puerto where NOMBRE_PUERTO = @puertoA)

	BEGIN TRANSACTION tr	

	BEGIN TRY

		UPDATE ZAFFA_TEAM.Tramo
		SET PUERTO_DESDE_ID = @puerto_desde_id
		WHERE RECORRIDO_CODIGO = @codRec AND ORDEN_TRAMOS = @ordenTramo

		UPDATE ZAFFA_TEAM.Tramo
		SET PUERTO_HASTA_ID = @puerto_hasta_id
		WHERE RECORRIDO_CODIGO = @codRec AND ORDEN_TRAMOS = @ordenTramo

		UPDATE ZAFFA_TEAM.Tramo
		SET RECORRIDO_PRECIO_BASE = @nuevoPrecio
		WHERE RECORRIDO_CODIGO = @codRec AND ORDEN_TRAMOS = @ordenTramo
		
		
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION tr
		DECLARE @mensaje VARCHAR(255) = ERROR_MESSAGE()
		RAISERROR(@mensaje,11,0)

		RETURN
	END CATCH

	COMMIT TRANSACTION tr
GO

----

SELECT * 
FROM ZAFFA_TEAM.Cliente

SELECT * 
FROM ZAFFA_TEAM.Crucero

SELECT * 
FROM ZAFFA_TEAM.Reserva

SELECT * 
FROM ZAFFA_TEAM.Tipo_Cabina

SELECT * 
FROM ZAFFA_TEAM.Cabina

SELECT DISTINCT CRUCERO_IDENTIFICADOR,CABINA_NRO,CABINA_PISO
FROM gd_esquema.Maestra
WHERE CRUCERO_IDENTIFICADOR = 'ZMYPZJ-55099'
ORDER BY CRUCERO_IDENTIFICADOR

SELECT *
FROM ZAFFA_TEAM.Auditoria_estado_cruceros

SELECT * 
FROM ZAFFA_TEAM.Tramo

SELECT *
FROM ZAFFA_TEAM.Viaje

SELECT *
FROM ZAFFA_TEAM.Pasaje

SELECT *
FROM ZAFFA_TEAM.Reserva



UPDATE zaffa_TEAM.Crucero
	set ESTADO_CRUCERO = 'BAJA DEFINITIVA'
	where CRUCERO_ID = 'ZMYPZJ-55099'

UPDATE zaffa_TEAM.Crucero
	set CANTIDAD_CABINAS = 23
	where CRUCERO_ID = 'ASHFLJ-66175'