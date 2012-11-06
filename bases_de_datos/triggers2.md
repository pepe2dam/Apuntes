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
	create or replace
	trigger control_conn
	AFTER logon on database
	begin
		insert into control_conexiones(usuario, momento, evento) 
		values(ORA_LOGIN_USER, systimestamp, ORA_SYSEVENT);
	end;

Los disparadores son una herramienta útil pero su uso indiscriminado degrada el
uso de una base de datos.


ACTIVAR, DESACTIVAR DISPARADORES
================================
Cuando creamos un disparador, siempre está activado, pero se puede variar esta
situación mediante

	ALTER TRIGGER nombredeltrigger
	DISABLE;

Con ésta sentencia, desactivamos. Para volverlo a activar

	ALTER TRIGGER nombredeltrigger
	ENABLE;

Para volver a compilarlo

	ALTER TRIGGER nombredeltrigger
	COMPILE;

Para eliminar

	DROP TRIGGER nombredetrigger;


VISTAS IMPORTANTES CON INFORMACIÓN SOBRE LOS TRIGGER
====================================================

dba_trigger
user_trigger

Registros y colecciones:
-----------------------

Registro sin limitaciones: 

1. Se define el tipo genérico del registro


		TYPE nombre_tipo IS RECORD
		(nombre_campo1  Tipo_campo1 [ [NOT NULL]  { := |DEFAULT} valorinicial1],
		nombre_campo2  Tipo_campo2[ [NOT NULL]  { := |DEFAULT} valorinicial1],
		);

Al definir el tipo podemos usar el especificador NOT NULL. En este caso los campos
deben ser inicializados:

	TYPE nombre_tipo  IS RECORD
	(nombre_campo1  Tipo_campo1 NOT NULL]   :=  valor1,
	nombre_2Tipo_campo2 NOT NULL   := valor2,
	);

2. Se declaran las variables que se necesiten de ese tipo según el formato:
Nombre_variablenombre_tipo;

Ejemplo:

Definir el tipo t_domicilio y posteriormente declara la variable v_domici de ese 
tipo:

	TYPE t_domicilio IS RECORD
   		(calle VARCHAR2(30),
     	Numero SMALLINT, /*SMALLING: tipo de datos*/
    	Localidad  VARCHAR2(25) );
		V_domici.t_domicilio;

Para referirnos a la variable de registro completa, indicaremos su nombre. Para 
referenciar solamente un campo, lo haremos utilizando la notación de punto según 
el formato:

	Nombre_variable_registro.nombre_campo

Un campo de un registro puede ser, a su vez, un registro. En este caso se les 
llama registros anidados. 

Ejemplo:

Crear un registro llamado t_domicilio con los campos calle varchar2(30), numero 
smalling y localidad varchar2(25) y crear también un registro llamado t_domicilio
con los campos nombre VARCHAR2(35), domicilio t_domicilio y fecha de nacimiento
DATE.

	DECLARE
	TYPE t_domicilio
	IS
  		RECORD
  		(
    	calle     VARCHAR2(30),
   		numero    SMALLINT,
    	localidad VARCHAR2(25) );
	TYPE t_datospersona
	IS
  		RECORD
  		(
    	nombre VARCHAR2(35),
    	domicilio t_domicilio,
    	fecha_nacimiento DATE 
  		);
  		v_persona t_datospersona;
	BEGIN
  		v_persona.nombre          :='ALONSO FERNÁNDEZ, JOAQUÍN';
  		v_persona.domicilio.calle :='C/ALBUFERA';
  		v_persona.domicilio.numero:=14;
	END;


Los registros se pueden usar como parámetros y como retorno de funciones, para 
lo cual hay que definir el tipo base del registro externamente, y asi pueda estar
accesible a todos los datos.

Las colecciones son estructuras compuestas por listas de elementos, se usan para
guardar datos, en formato de multiples filas, similar a las tablas de las bases
de datos.
Oracle dispone de tres tipos de conexiones, los varray, otra son las tablas anidadadas
y la ultima tablas indexadas o arrays asociativos.

varray: Se pueden usar en tablas de las BBDD, tienen un indice secuencial, que 
permite el acceso en sus elementos, con el comienzo en 1, no con el 0 y tienen
una condición fija determinada en el momento de su creación. Para poder utilizar 
un array, hay que hacer:

Definir el tipo.


	TYPE nombre_tipovarray IS VARRAY (numelementos) OF
	Tiposelementos [NOT NULL];


nombre_tipoarray: Especificador que da el tipo base de la tabla. 
numelementos: Número de elementos que va a contener el array.

EJEMPLO:

	SET SERVEROUTPUT ON

	DECLARE
	TYPE t_meses IS VARRAY (12) OF VARCHAR2(10);
		va_meses t_meses;
	BEGIN
  		va_meses:=t_meses('Enero','Febrero','Marzo','Abril','Mayo','Junio','Julio', 'Agosto','Septiembre','Octubre','Noviembre','Diciembre');
  		FOR i IN 1..12
  		LOOP
    		DBMS_OUTPUT.PUT_LINE(TO_CHAR(i)|| '-' ||va_meses(i));
  		END LOOP;
	END;
	
El tipo que define el varray puede ser a su vez un tipo definido por el usuario, 
frecuentemente como un registro, siendo la sintaxis:

	Nombrevariablearray(i)nombrecampo;

Ejercicio:

Escribir un bloque que realice:

- Declarar un cursor basado en una consulta.
- Definir un tipo de registro compatible con el cursor.
- Definir un varray cuyos elementos son del tipo registro previamente definidos.
- Declarar, inicializar y usar una variable de tipo varray cargando el contenido 
  del cursor 

CONSULTA:

- c_depart
- usar las tablas emple y depart
- sacar el dnombre, contar el numero de empleados y agrupar por número de departamento
  y nombre.


	SELECT dnombre, COUNT(emp_no) numemple
	FROM  depart,emple
	WHERE depart.dept_no = emple.dept_no
	GROUP BY dnombre,depart.dept_no;

REGISTRO:

	TYPE tr_depto IS RECORD
	(
		nombredept depar.dnombre%TYPE,
		numemple INTEGER
	);

VARRAY:

	TYPE tv_deptno IS VARRAY(3) OF tr_deptno;

DECLARACIÓN DE LA VARIABLE:

	va_departamentos tv_depto:= tv_depto(NULL,NULL,NULL);

	N Integer:= 0   
	
	* Variable a 0 para cargar los valores de las variables



Ejercicio:

	DECLARE

  		CURSOR c_depart
  		IS

    		SELECT dnombre,
      		COUNT(emp_no) numEmple
    		FROM depart,
     		emple
    		WHERE depart.dept_no=emple.dept_no(+)
    		GROUP BY depart.dept_no,
      		dnombre;

			type tr_dpto
			IS
			record
  			(
    			nombredp depart.dnombre%type,
    			num INTEGER
			);

			type tv_depto IS varray(4) OF tr_dpto;
			va_departs tv_depto:=tv_depto(NULL, NULL, NULL, NULL);

		BEGIN

  			OPEN c_depart;

 			FOR i IN va_departs.first .. va_departs.last LOOP
    			FETCH c_depart INTO va_departs(i);
    			EXIT WHEN c_depart%notfound;
    			dbms_output.put_line('El Dpto. ' || va_departs(i).nombredp || ' tiene ' || va_departs(i).num || ' empleados');
 			END LOOP;

		END;
	
CURSORES FOR...LOOP:

El formato y uso de esta estructura es:

1. Se declara el cursor en la sección declarativa, como cualquier otro cursor:

	CURSOR nombrecursor IS
	sentencia SELECT

2. Se procesa el cursor utilizando el siguiente formato: 

	FOR nombreVariableRegistro IN nombreCursor LOOP
		Acciones
	END LOOP;

Donde nombreVariableRegistro es el nombre de la variable de registro, que creara
el bucle, para recoger los datos del cursor, al entrar en el bucle se entra de 
manera automatica al cursor, declarandose implicitamente la variable, y se 
ejecuta un FETCH implicito, cuyo resultado quedara en nombreVariableReg.

