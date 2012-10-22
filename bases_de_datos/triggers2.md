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
