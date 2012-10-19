TRIGGERS
========
Son bloques almacenados que se disparan directamente cuando se producen ciertos 
eventos:

hay 3 tipos de disparadores:

* DISPARADORES DE TABLAS.
Están asociados a una tabla. Se disparan al efectuarse cierto suceso en una tabla
como puede ser insert, update, delete...

* DISPARADORES DE SUSTITUCIÓN.
Están asociados a vistas. Se disparan cuando se intenta ejecutar un comando de 
manipulación que afecta a la vista, como es un insert, delete o update.

* DISPARADORES DE SISTEMA.
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
	<declaraciones>
		{EXCEPTION 
		---}
	]
	BEGIN
	END;

###Cabecera###
Se define el nombre, evento del disparo 

###evento_de_disparo:### 
Suceso que provoca la ejecución del disparador. Puede ser una órden DML(insert, 
update) o una orden de creación de datos (create, alter...) o un suceso de 
sistema. Puede ser tanto en una tabla como en una vista.

###Condición del disparo###
Condiciona la ejecución al cumplimiento de condicion_de_disparo. Es opcional.

###Cuerpo del Trigger###
Es el código que se ejecutará cuando se produzca el evento y se cumplan las 
condiciones especificadas en la cabecera. Es un bloque PL/SQl.

###Excepciones###
Son opcionales también. Van dentro del declare.

TIPOS DE DISPARADORES
=====================

Tenemos 3 tipos de Trigger.

DISPARADORES DE TABLAS
----------------------
Están asociados a una tabla. Se disparan al efectuarse cierto suceso en una tabla
como puede ser insert, update, delete...

Formato para creación de disparadores de tablas.

	CREATE [OR REPLACE] 
	TRIGGER nombre_de_trigger
		{BEFORE|AFTER|INSTEAD}
		{DELETE|INSERT|UPDATE}
		[OF <lista, de, columnas>]
		ON nombre_de_tabla
	[FOR EACH 
		{STATEMENT|ROW 
		[WHEN (condicion)]
		}
	]		

Ejercicio:
Crear trigger que se dispare al modificar datos de la columna salario en la tabla
emple.

	CREATE OR REPLACE TRIGGER
		audit_subida_salario
	AFTER UPDATE OF salario
	ON emple
	FOR EACH ROW
	BEGIN
		INSERT INTO auditaremple
		values ('Subida salario empleado' || OLD.emp_no);
	END;

Ejercicio:
Crear un disparador que inserte en la tabla auditaremple cualquier cambio en el
salario que supere el 5% del salario del empleado, indicando fecha y hora, salario
anterior y posterior

	create or replace
	trigger 
	audita_salario_empleado
	after update of salario
	on emple
	for each row
	when ((new.salario - old.salario) > 5 * (old.salario / 100))
	begin
		insert into auditaremple (col1) 
		values(
			'subida salario emp:' || 
			:OLD.emp_no || 
			'; nuevo: ' || 
			:new.salario || 
			'; antiguo: ' || 
			:old.salario || 
			'; fecha:' || 
			sysdate
		);
	end;
	
	

DISPARADORES DE SUSTITUCIÓN
---------------------------
Están asociados a vistas. Se disparan cuando se intenta ejecutar un comando de 
manipulación que afecta a la vista, como es un insert, delete o update.

DISPARADORES DE SISTEMA
-----------------------
Se disparan cuando ocurre un evento en el sistema, como es un arranque o parada
de la base de datos, entrada o salida de un usuario. También se conoce como dis
paradores de sistema cuando se refieren a creacion, modificacion de tablas...


WHEN
----
Ésta cláusula, seguida de una condición, restringe la ejecución del trigger al
cumplimiento de la condición. Tiene algunas limitaciones:
1. Sólo con trigger a nivel de fila (For each row)
2. Se trata de una condición SQL
3. No puede incluir una consulta a las mismas tablas o vistas.
