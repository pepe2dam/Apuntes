INTRODUCCIÓN
============

Cursores implícitos
-------------------
>select lol into nombre_cursor from tabla;

Cursores explícitos
-------------------
Hay 4 operaciones para trabajar con cursores explícitos. 
1. Declaración del cursor:
En la zona de declaraciones y según el siguiente formato. 
> CURSOR nombre_del_cursor 
> IS SELECT * FROM lololol;

2. Apertura del cursor
en la zona en la zona de instrucciones:
> OPEN nombre_del_cursor
La instrucción open ejecuta automáticamente la sentencia SELECT y sus resultados
se almacenan en las estructuras internas de memoria manejadas por el cursor.

3. Recogida de información almacenada en el cursor.
Para ello se utiliza el comando "fetch" con el siguiente formato:
> FETCH nombre_del_cursor INTO var1, var2, var3, var4;
Cada FETCH recupera una fila y el cursor avanza automáticamente a la fila siguen-
te.

4. Cierre del cursor.
> CLOSE nombre_del_cursor;

Hay 4 atributos para consultar el resultado del cursor:
* %FOUND:
devuelve TRUE si el último "fetch" ha recuperado algún valor. En caso contrario
devuelve FALSE

* %NOTFOUND:
Hace lo contrario que FOUND

* %ROWCOUNT:
Devuelve el numero de filas recuperadas hasta el momento por el cursor. (número
de fetch realizados satisfactoriamente)

* %ISOPEN:
Devuelve verdadero si el cursor está abierto


Bloques anónimos.
-----------------
> DECLARE
> 	variable tipo
> BEGIN
> 	...
>
> 	DBMS_OUTPUT.PUT_LINE(...)
> END;
> /

Ejercicio:
Visualizar el nombre y la localidad de los departamentos de la tabla depart.

	declare
		cursor d_loc is select dnombre, loc from depart;
		d_nombre varchar(14);
		d_localidad varchar(14);
	begin
		open d_loc;
		loop
			fetch d_loc into d_nombre, d_localidad;
			exit when d_loc%NOTFOUND;
			DBMS_OUTPUT.PUT_LINE(d_nombre || ' -> ' || d_localidad);
		end loop;
		close d_loc;
	end;


Ejercicio:
Visualizar el nombre y localidad de todos los departamentos de la tabla 
depart utilizando found en vez de nofound.

	DECLARE
		CURSOR d IS SELECT dnombre, loc FROM depart;
		d_dnombre VARCHAR(14);
		d_loc VARCHAR(14);
	BEGIN
		OPEN d;
		FETCH d into d_dnombre, d_loc;
		WHILE d%FOUND LOOP
			DBMS_OUTPUT.PUT_LINE(d_dnombre || '  ' || d_loc);
		END LOOP;
	END;



ejercicio:
Visualizar los apellidos de los empleados pertenecientes al departamento
20 numerandolos secuencialmente.

	DECLARE
		CURSOR e IS SELECT apellido FROM emple WHERE dept_no = 20;
		nombre VARCHAR(14);
	BEGIN
		OPEN e;
		loop
			fetch e into nombre;
			exit when e%notfound;
			dbms_output.put_line(nombre || ' -> ' || to_char(e%rowcount));
		end loop;
	end;


Procedimientos
--------------

CREATE [OR REPLACE] 
PROCEDURE <procedure_name> [(<param1> [IN|OUT|IN OUT] <type>, 
                             <param2> [IN|OUT|IN OUT] <type>, ...)] 
>IS
>  -- Declaracion de variables locales
>BEGIN
>  -- Sentencias
>[EXCEPTION]
>  -- Sentencias control de excepcion
> END [<procedure_name>];


Funciones
---------
>CREATE [OR REPLACE]
>FUNCTION <fn_name>[(<param1> IN <type>, <param2> IN <type>, ...)] 
>RETURN <return_type> 
>IS
>  result <return_type>;
>BEGIN
> 
>  return(result);
>[EXCEPTION]
>  -- Sentencias control de excepcion
>END [<fn_name>];


Variables de acoplamiento en el manejo de cursores:
---------------------------------------------------
la cláusula SELECT del cursor deberá seleccionar las filas de acuerdo con una
condición. Cuando se trabaja con SQL interactivo se introducen los términos exactos
de la condición

Por ejemplo:
> SELECT apellido
> FROM emple
> WHERE dept_no = 20

Pero en un programa PL/SQL los términos exactos de esta condición sólamente se 
conocen en tiempo de ejecución. Ésta circunstancia obliga a utilizar un diseño
más abierto y las variables de acoplamiento cumplen esta función. Su forma de uso
es:
1. Se declara la variable como cualquier otra
2. Se utiliza la variable en la sentencia SELECT como parte de la expresión

> CURSOR <nombre_del_cursor> IS 
> SELECT trololo FROM troll WHERE var = mi_variable_acoplamiento.

Ejercicio:
Visualizar el apellido de los empleados del departamento 20
CREATE OR REPLACE
PROCEDURE emp_dep_20
IS
	departamento int(2) := 20;
	CURSOR emps is SELECT apellido FROM emple WHERE dept_no = departamento;
	apellido varchar(20);
BEGIN
	open emps;
	loop
		fetch emps into apellido;
		exit when emps%NOTFOUND;
		dbms_output.put_line(apellido);
	end loop;
END emp_dep_20;

Ejercicio
Mostrar nombre departamento y numero de empleados:

Ejercicio:
Escribe un procedimiento que reciba una cadena y visualize el apellido y el numero
de empleado de todos los empleados cuyo apellido contenga la cadena especificada.
Al finalizar visualiza el numero de empleados mostrados.

	CREATE OR REPLACE
	PROCEDURE subcadena_empleados(subcadena VARCHAR)
	IS
		CURSOR emp is SELECT apellido, emp_no FROM emple WHERE INSTR(apellido, subcadena) != 0;
		apellido varchar(20);
		numero int(4);
	BEGIN
		open emp;
		loop
			fetch emp into apellido, numero;
			exit when emp%NOTFOUND;
			dbms_output.put_line(apellido || ' -> ' || numero);
		end loop;
	END subcadena_empleados;

Ejercicio:
Mostrar departamento y numero de empleados.
	CREATE OR REPLACE
	PROCEDURE empleados_departamento
	IS
		CURSOR dept is select dnombre, count(*) from depart, emple where emple.dept_no = depart.dept_no group by dnombre;
		depart varchar(20);
		empleados int(4);
	BEGIN
		open dept;
		loop
			fetch dept into depart, empleados;
			exit when dept%NOTFOUND;
			dbms_output.put_line(depart || ' -> ' || empleados);
		end loop;
	END empleados_departamento;


Ejercicio:
Desarrollar procedimiento que visualice apellido y decha de alta de todos los empleados
ordenados por apellido
	CREATE OR REPLACE
	PROCEDURE apellido_fecha_alta
	IS
		CURSOR ap_fecha IS select apellido, fecha_alt from emple;
		apellido emple.apellido%TYPE;
		fecha emple.fecha_alt%TYPE;
	BEGIN
		open ap_fecha;
		loop 
			fetch ap_fecha INTO apellido, fecha;
			exit when ap_fecha%NOTFOUND;
			dbms_output.put_line(apellido || ' -> ' || fecha);
		end loop;
	END apellido_fecha_alta;

Ejercicio:
Realizar un procedimiento que muestre en formato similar a las rupturas de secuencia
los siguientes datos:
Para cada empleado, apellido y salario.
Para cada dept, el número de emopleados y la suma de salario de cada dept.
Número total de empleados y la suma total de todos los salarios.

CREATE OR REPLACE 
PROCEDURE departamentos_empleados
IS
	CURSOR empleados IS select apellido, salario, depart.dnombre from emple inner join depart on emple.dept_no = depart.dept_no ORDER BY depart.dnombre;
	apellido emple.apellido%TYPE;
	salario emple.salario%TYPE;
	departamento depart.dnombre%TYPE;
	num_empleados number(4) := 0;
	suma_salarios number(8) := 0;
	total_empleados number(4) := 0;
	total_salarios number(4) := 0;
	buf_departamento depart.dnombre%TYPE := 'a';
BEGIN
	open empleados;
		loop
			fetch empleados into apellido, salario, departamento;
			exit when empleados%NOTFOUND;
			IF departamento != buf_departamento THEN
				dbms_output.put_line('-----------');	
				dbms_output.put_line(departamento);
			ELSE
			dbms_output.put_line(apellido || ' -> ' || salario);
			END IF;
			buf_departamento := departamento;
			total_empleados := total_empleados + 1;
			dbms_output.put_line(total_empleados);
		end loop;
	close empleados;
END departamentos_empleados;
/

