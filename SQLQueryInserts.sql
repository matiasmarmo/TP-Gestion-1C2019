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

----

"declare  @comienzoSemestre datetime2(3);
declare  @finSemestre datetime2(3);
set @comienzoSemestre='2018-01-01 00:00:00.000'; 
set @finSemestre='2018-12-31 00:00:00.000';
SELECT top 5 est.CRUCERO_ID Crucero, SUM(DATEDIFF(DAY, case when est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' and est.FECHA_ANTERIOR < @comienzoSemestre then @comienzoSemestre 
                                              when est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' then est.FECHA_ANTERIOR
											  when est.ESTADO_ACTUAL = 'FUERA DE SERVICIO' then est.FECHA_ACTUAL
											  end, 
										 case when est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' then est.FECHA_ACTUAL
										      when est.ESTADO_ACTUAL = 'FUERA DE SERVICIO' then  @finSemestre
											  end
										      )) DiasFueraDeServicio
FROM ZAFFA_TEAM.Auditoria_estado_cruceros est
left join  ZAFFA_TEAM.Auditoria_estado_cruceros estSig on estSig.CRUCERO_ID = est.CRUCERO_ID and estSig.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' and est.FECHA_ACTUAL = estSig.FECHA_ANTERIOR
WHERE (est.ESTADO_ACTUAL = 'REINICIO DE SERVICIO' and est.FECHA_ACTUAL >= @comienzoSemestre and est.FECHA_ACTUAL <= @finSemestre) or 
(est.ESTADO_ACTUAL = 'FUERA DE SERVICIO' and est.FECHA_ACTUAL >= @comienzoSemestre  and est.FECHA_ACTUAL <= @finSemestre AND (estSig.FECHA_ACTUAL is null or estSig.FECHA_ACTUAL > @finSemestre))
group by est.CRUCERO_ID"

----

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('PRUEBA-72879', '2017-07-09 00:00:00.000' ,'FUERA DE SERVICIO', '2017-06-19 00:00:00.000', 'ALTA')

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('PRUEBA-72879', '2018-01-05 00:00:00.000' ,'REINICIO DE SERVICIO', '2017-07-09 00:00:00.000', 'FUERA DE SERVICIO')
-- 4 dias fuera de servicio SEMESTRE 2018
INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('PRUEBA-72879', '2018-02-05 00:00:00.000' ,'FUERA DE SERVICIO', '2018-08-19 00:00:00.000', 'REINICIO DE SERVICIO')

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('PRUEBA-72879', '2018-03-05 00:00:00.000' ,'REINICIO DE SERVICIO', '2018-02-05 00:00:00.000', 'FUERA DE SERVICIO')
-- 28 DIAS FUERA DE SERVICIO + 4 -- SELECT DATEDIFF(DAY, '2018-02-05 00:00:00.000', '2018-03-05 00:00:00.000') = 28
-- 32 TOTAL

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('PRUEBA-72879', '2018-06-20 00:00:00.000' ,'FUERA DE SERVICIO', '2018-03-05 00:00:00.000', 'REINICIO DE SERVICIO')

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('PRUEBA-72879', '2018-07-20 00:00:00.000' ,'REINICIO DE SERVICIO', '2018-06-20 00:00:00.000', 'FUERA DE SERVICIO')
-- + 10 dias fuera de servicio EN EL PRIMER SEMESTRE
-- TOTAL 42 dias fuera de servicio EN EL PRIMER SEMESTRE 
-- 19 dias dias fuera de servicio EN EL SEGUNDO SEMESTRE -- SELECT DATEDIFF(DAY, '2018-07-01 00:00:00.000', '2018-07-20 00:00:00.000') = 19


INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('ILELMR-72879', '2018-07-09 00:00:00.000' ,'FUERA DE SERVICIO', '2018-06-19 00:00:00.000', 'ALTA')

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('ILELMR-72879', '2018-08-19 00:00:00.000' ,'REINICIO DE SERVICIO', '2018-07-09 00:00:00.000', 'FUERA DE SERVICIO')
-- 41 dias fuera de servicio -- SELECT DATEDIFF(DAY, '2018-07-09 00:00:00.000', '2018-08-19 00:00:00.000') = 41

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('ILELMR-72879', '2018-10-19 00:00:00.000' ,'FUERA DE SERVICIO', '2018-08-19 00:00:00.000', 'REINICIO DE SERVICIO')

INSERT INTO ZAFFA_TEAM.Auditoria_estado_cruceros (CRUCERO_ID, FECHA_ACTUAL, ESTADO_ACTUAL, FECHA_ANTERIOR, ESTADO_ANTERIOR)
VALUES('ILELMR-72879', '2018-11-19 00:00:00.000' ,'REINICIO DE SERVICIO', '2018-10-19 00:00:00.000', 'FUERA DE SERVICIO')
-- + 31 dias fuera de servicio 
-- total 72 dias fuera de servicio EN EL SEGUNDO SEMESTRE



UPDATE ZAFFA_TEAM.Crucero 
set ESTADO_CRUCERO = 'FUERA DE SERVICIO'
WHERE CRUCERO_ID = 'ILELMR-72879'


------------------------------- LA POSTA 
		SELECT TOP 5 via.RECORRIDO_CODIGO, 
		(( select CANTIDAD_CABINAS from ZAFFA_TEAM.Crucero where CRUCERO_ID = via.CRUCERO_ID ) -
		( select count(*) from ZAFFA_TEAM.Pasaje where VIAJE_ID = via.VIAJE_ID ) -
		( select count(*) from ZAFFA_TEAM.Reserva where VIAJE_ID = via.VIAJE_ID )) cabinasLibres
		FROM ZAFFA_TEAM.Pasaje pas  
		JOIN ZAFFA_TEAM.Viaje via ON pas.VIAJE_ID = via.VIAJE_ID
		JOIN ZAFFA_TEAM.Crucero cru ON cru.CRUCERO_ID = pas.CRUCERO_ID
		group by via.RECORRIDO_CODIGO, via.VIAJE_ID, via.CRUCERO_ID
		order by cabinasLibres desc

-----------------------------------------------------


declare  @cabinasLibres int;
		SELECT TOP 5 via.RECORRIDO_CODIGO, COUNT(*)  
		FROM ZAFFA_TEAM.Pasaje pas  
		JOIN ZAFFA_TEAM.Viaje via ON pas.VIAJE_ID = via.VIAJE_ID
		JOIN ZAFFA_TEAM.Crucero cru ON cru.CRUCERO_ID = pas.CRUCERO_ID
		WHERE cabinasLibres = 
( select count(*) from ZAFFA_TEAM.Pasaje where VIAJE_ID = via.VIAJE_ID ) +
( select count(*) from ZAFFA_TEAM.Reserva where VIAJE_ID = via.VIAJE_ID ) -
( select CANTIDAD_CABINAS from ZAFFA_TEAM.Crucero where CRUCERO_ID = CRUCERO_ID )
		group by via.RECORRIDO_CODIGO
		order by cabinasLibres desc
		
-- Top 5 de los recorridos con más cabinas libres en cada 
-- uno de los viajes realizados. 

		private int cabinas_Libres(string viaje_id, String crucero_id) 
        {
            int cabinasLibres = 0;
            string query1 = "select count(*) from ZAFFA_TEAM.Pasaje where VIAJE_ID = " + viaje_id;
            SqlDataReader reader1 = ClaseConexion.ResolverConsulta(query1);
            reader1.Read();
            cabinasLibres = reader1.GetInt32(0);
            reader1.Close();
            query1 = "select count(*) from ZAFFA_TEAM.Reserva where VIAJE_ID = " + viaje_id;
            reader1 = ClaseConexion.ResolverConsulta(query1);
            reader1.Read();
            cabinasLibres += reader1.GetInt32(0);
            reader1.Close();
            query1 = "select CANTIDAD_CABINAS from ZAFFA_TEAM.Crucero where CRUCERO_ID = '" + crucero_id + "'";
            reader1 = ClaseConexion.ResolverConsulta(query1);
            reader1.Read();
            cabinasLibres = reader1.GetInt32(0) - cabinasLibres;
            reader1.Close();
            return cabinasLibres;
        }