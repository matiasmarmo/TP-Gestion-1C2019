GO
CREATE FUNCTION zaffa_team.Hashear_Password (@password CHAR(32))
RETURNS CHAR(32)
BEGIN
  RETURN CONVERT(CHAR(32), HASHBYTES('SHA2_256', @password), 2)  
END
GO
drop procedure zaffa_team.sp_login 
EXECUTE zaffa_team.sp_login 'mati', 'abc';
SELECT * from ZAFFA_TEAM.Administrativo
UPDATE ZAFFA_TEAM.Administrativo
			SET INTENTOS_FALLIDOS = 0,ESTADO_ADMIN='A'
			
GO
CREATE PROCEDURE zaffa_team.sp_login(@usuario VARCHAR(64), @password CHAR(64))
AS
	BEGIN
		DECLARE @pass_encriptada CHAR(64),@USER NVARCHAR(50);
		SET @pass_encriptada = zaffa_team.Hashear_Password(@password);
		SET @USER = (SELECT USERNAME FROM zaffa_team.Administrativo
						WHERE USERNAME = @usuario)
		IF((SELECT PASSWORD FROM zaffa_team.Administrativo
				WHERE USERNAME = @USER) = @pass_encriptada)
		BEGIN
			UPDATE ZAFFA_TEAM.Administrativo
			SET INTENTOS_FALLIDOS = 0
			WHERE USERNAME = @USER
		END
		ELSE IF((SELECT PASSWORD FROM zaffa_team.Administrativo WHERE USERNAME = @USER) != @pass_encriptada 
			AND (SELECT INTENTOS_FALLIDOS FROM zaffa_team.Administrativo WHERE USERNAME = @USER) < 2)
		BEGIN
			UPDATE ZAFFA_TEAM.Administrativo
			SET INTENTOS_FALLIDOS = INTENTOS_FALLIDOS + 1
			WHERE USERNAME = @USER
		END
		ELSE  
		BEGIN
			UPDATE ZAFFA_TEAM.Administrativo
			SET ESTADO_ADMIN = 'I', INTENTOS_FALLIDOS = 3
			WHERE USERNAME = @USER
		END
	END	
GO
-- Trigger para encriptar pass al registrar un nuevo usuario
CREATE TRIGGER ZAFFA_TEAM.Encriptar_Password
ON ZAFFA_TEAM.Administrativo
INSTEAD OF INSERT
AS 
BEGIN    
	DECLARE @password VARCHAR(64)
	DECLARE @username VARCHAR(64)

	SELECT @username = USERNAME, @password = PASSWORD FROM inserted

	INSERT INTO ZAFFA_TEAM.Administrativo(USERNAME, PASSWORD,INTENTOS_FALLIDOS,NOMBRE_ROL,ESTADO_ADMIN) 
		VALUES ( @username, ZAFFA_TEAM.Hashear_Password(@password),0,'Administrativo','A') 
END 
GO

SELECT USERNAME FROM ZAFFA_TEAM.Administrativo WHERE USERNAME = 'ADMIN'

INSERT INTO ZAFFA_TEAM.Administrativo
	(USERNAME, PASSWORD,INTENTOS_FALLIDOS,NOMBRE_ROL,ESTADO_ADMIN) VALUES ('admin', 'w23e',0,'Administrativo','A')

INSERT INTO ZAFFA_TEAM.Administrativo
	(USERNAME, PASSWORD,INTENTOS_FALLIDOS,NOMBRE_ROL,ESTADO_ADMIN) VALUES ('mati', 'abc',0,'Administrativo','A')
