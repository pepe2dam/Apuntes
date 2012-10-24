# DISPARADORES DE SUSTITUCIÓN
Están asociados a vistas. Se disparan cuando se intenta ejecutar un comando de 
manipulación que afecta a la vista, como es un insert, delete o update.

# DISPARADORES DE SISTEMA
Se disparan cuando ocurre un evento en el sistema, como es un arranque o parada
de la base de datos, entrada o salida de un usuario. También se conoce como dis
paradores de sistema cuando se refieren a creacion, modificacion de tablas

## WHEN
Ésta cláusula, seguida de una condición, restringe la ejecución del trigger al
cumplimiento de la condición. Tiene algunas limitaciones:


## ORDEN DE LOS DISPARADORES
1. BEFORE ... FOR EACH STATEMENT
2. BEFORE ... FOR EACH ROW
3. ACTUALIZACIÓN DE FILA. (Se bloquea la fila hasta que la transaccion se confirme)
4. AFTER ... FOR EACH ROW
5. AFTER ... FOR EACH STATEMENT


# TRIGGER CON MÚLTIPLES EVENTOS

Puede ser disparado por múltiples eventos. En estos casos, para facilitar su 
control, Oracle permite el uso de "predicados condicionales". Estos predicados
son:
### INSERTING
Devuelve TRUE si el evento que disparó el trigger fue un insert.
### DELETING
Devuelve TRUE si el evento que disparó el trigger fue un delete
### UPDATING
Devuelve TRUE si el evento que disparó el trigger fue un update
### UPDATING (nombre_de_columna)
Devuelve TRUE si el evento que disparó el trigger fue una instrucción update y la
columna especificada ha sido actualizada

Formato de trigger con múltiples eventos.

	IF INSERTING THEN
	...
	ELSIF DELETING THEN
	...
	ELSIF UPDATING THEN
	...
	ELSIF UPDATING('nombre_de_columna') THEN
	...
	END IF

Un trigger no puede contener instrucciones que actualizen tablas mutantes. Las
tablas mutantes son las que estan siendo modificadas por una sentencia UPDATE,
DELETE o INSERT

Ejercicio:
	Hacer un trigger que permita auditar las operaciones de inserción o borrado
	de datos que se realicen en la tabla emple, según las siguientes 
	especificaciones:
	* Cuando se produzca cualquier modificación se insertará una fila en dicha
	tabla que contendrá fecha y hora, emp_no, apellido y el nombre del DML 
	operation


DISPARADORES DE ACTUALIZACIÓN
=============================
Son asociados a vistas.- Sólo se lanzan con instead of, en vez de after o before.
Por éste motivo se denominan disparadores de sustitución. El formato es el siguiene:

	CREATE OR REPLACE
	TRIGGER nombre_de_trigger
		INSTEAD OF 
		{DELETE|INSERT|UPDATE [OF <lista, de, columnas>]}
		ON nombre_vista
	[FOR EACH ROW] [WHEN (CONDICION)]
	<CUERPO DEL TRIGGER.>

Características de éstos disparadores:
1. Sólo se usan en triggers asociados a vista.
2. Son especialmente útiles para realizar operaciones de actualizacion
3. Actúan siempre a nivel de fila, en vez de a nivel de orden.

Ejemplo:

	CREATE OR REPLACE VIEW emplead
	AS
	SELECT emp_no,
	        apellido,
	        oficio,
	        dnombre,
	        loc
	FROM EMPLE,
	    DEPART
	WHERE emple.dept_no = depart.dept_no;

Inserción en la vista:

	INSERT INTO emplead VALUES (7819,'Martinez', 'Vendedor', 'Contabilidad', 'Sevilla');

Da error por lo que se crea el siguiente trigger:

	CREATE OR REPLACE TRIGGER t_ges_emplead INSTEAD OF
	  DELETE OR
	  INSERT OR
	  UPDATE ON emplead FOR EACH ROW DECLARE v_dept depart.dept_no%TYPE;
	BEGIN
	      IF deleting THEN
	        /*Si se pretende borrar una fila*/
	        DELETE FROM emple  WHERE emp_no= :old.emp_no;
	      ELSIF inserting THEN
	        /*Si se pretende insertar una fila*/
	        SELECT dept_no INTO v_dept FROM depart WHERE depart.dnombre= :new.dnombre AND loc = :new.loc;
	        INSERT  INTO emple (emp_no,apellido, oficio, dept_no)
	        VALUES(:new.emp_no,:new.apellido,:new.oficio,v_depart);
	      ELSIF updating('dnombre') THEN
	        SELECT dept_no INTO v_dept FROM depart WHERE dnombre = :new.dnombre;
	        UPDATE emple SET dept_no = v_dept WHERE emple_no = :old.emp_no;
	      ELSIF updating('oficio') THEN
	        /*Si se pretende actualizar alguna fila*/
	        UPDATE emple SET oficio = :new.oficio;
	      ELSE
	        RAISE_APPLICATION_ERROR(-20500,'Error en la actualización');
	      END IF;
	END;

Ejercicio:
Suponiendo que disponemos de la vista dep 

	create view dep
	as 
		select depart.dept_no, depart.dnombre, depart.loc, count(emp_no) tot_emple
		from emple, depart
		where depart.dept_no = emple.dept_no
		group by depart.dept_no, dnombre, loc

Crear un disparador que permita realizar actualizaciones en la tabla depart a 
partir de esta vista. 

DISPARADORES DE SITEMA
======================
Se disparan al ocurrir sucesos en el sistema o al ejecutarse sentencias DDL (data
definition language). Su sintáxis es la siguiente:

	CREATE OR REPLACE
	TRIGGER nombre_de_trigger
	{BEFORE|AFTER} OF
	<lista eventos definicion>
	<lista eventos sistema>
	ON {DATABASE|SCHEMA}
	[WHEN (condicion)]
	BEGIN
		<CUERPO DEL TRIGGER>
	END;

__ON DATABASE__ se disparará siempre que ocurra el evento de disparo, sea en nuestro
esquema o no.

__ON SCHEMA__ hace referencia a aquel al que pertenece el trigger, pero se 
puede determinar otro esquema conociendo el nombre de la siguiente manera:

	ON nombre_de_esquema.SCHEMA

<lista de eventos definicion> Puede incluir uno o más eventos DDL separados por
OR. <lista eventos sistema> puede coexistir con definicion.


Al asociar un disparador a un evento de sistema, debemos indicar el momento del 
disparo. Unos sólo pueden indicar antes, otros despues y otros admiten las dos 
posibilidades.

__EVENTOS__    |     __MOMENTO__    | __DESCRIPCION__             
---------------|--------------------|-----------------------------
STARTUP        |     AFTER          |  Arrancar la base de datos  
SHUTDOWN       |     BEFORE         |  Apagar la base de datos    
LOGON          |     AFTER          |  Usuario conecta a la db    
LOFOFF         |     BEFORE         | Usuario desconecta de la db 
SERVERERROR    |     AFTER          |  Error en el servidor       
CREATE         |    AFTER/BEFORE    |  Crear                      
DROP           |    AFTER/BEFORE    |  Eliminar objeto            

PL/SQL dispone de algunas funciones que permiten acceder a los atributos del evento
de disparo. Son:
ORA_SYSEVENT
ORA_LOGIN
ORA_LOGIN_USER

Ejercicio:
	Crear un disparador que controle las conexiones de los usuarios a la base de 
	datos. Vamos a introducir nombre de usuario, fecha y hora del evento y la 
	operación conexión que realiza el usuario.

	1º creamos la tabla.
	Create table control_conexiones(
		usuario varchar2(10), 
		momento timestamp,
		evento varchar2(15));

	2º Creamos el trigger
	
