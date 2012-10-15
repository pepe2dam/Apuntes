TRIGGERS
========
Son bloques almacenados que se disparan directamente cuando se producen ciertos 
eventos:

hay 3 tipos de disparadores:

DISPARADORES DE TABLAS
----------------------
Están asociados a una tabla. Se disparan al efectuarse cierto suceso en una tabla
como puede ser insert, update, delete...

DISPARADORES DE SUSTITUCIÓN
---------------------------
Están asociados a vistas. Se disparan cuando se intenta ejecutar un comando de 
manipulación que afecta a la vista, como es un insert, delete o update.

DISPARADORES DE SISTEMA
-----------------------
Se disparan cuando ocurre un evento en el sistema, como es un arranque o parada
de la base de datos, entrada o salida de un usuario. También se conoce como dis
paradores de sistema cuando se refieren a creacion, modificacion de tablas...

Se utilizan para implementar restricciones complejas de seguridad o integridad,
para prevenir transacciones erroneas, auditar actualizaciones, e incluso para
enviar alertas.

SINTÁXIS
========

	CREATE OR REPLACE 
	TRIGGER nombre_de_trigger 
		BEFORE|AFTER|INSTEAD OF
		evento_de_disparo
		[WHEN condicion_de_disparo]
	[DECLARE
	<declaraciones>]
	BEGIN
	END;

###Cabecera###
Se define el nombre, evento del disparo 

###evento_de_disparo:### 
Suceso que provoca la ejecución del disparador. Puede ser una órden DML o una 
orden de creación de datos. Puede ser tanto en una tabla como en una vista.

###Condición del disparo###
