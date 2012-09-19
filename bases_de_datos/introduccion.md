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

