EXCEPCIONES
===========
Sirven para tratar errores en tiempo de ejecución, así como errores y situaciones
definidas por el usuario. Cuando aparece un error en PLSQL lanza un mesaje de error
y lo manda a Exception donde lo tratará un handler when order y dará por finalizado
el bloque actual.

El formato de la excepcion EXCEPTION es el siguiente:
	EXCEPTION 
		WHEN nombreExcepcion1 THEN
			instrucciones1;
		WHEN nombreExcepcion2 THEN
			instrucciones2;
		WHEN nombreExcepcion3 THEN
			instrucciones3;
		...
		[WHEN OTHERS THEN
			instruccionesDefault]
	END nombreDePrograma.

Excepciones predefinidas
------------------------
Están definidas por Oracle y se disparan automáticamente al producirse determinados
errores. El nombre de los errores internos de Oracle tiene la siguiente forma:
	ORA-06539 ACCESS_INTO_NULL Intenta acceder a un objeto no inicializado

para contrastar, mirar en www.ora-code.com

ORA-0056 ---> ORA-36804

Todas estas excepciones no hay que declararlas en la sección DECLARE. Lo único
que hemos de hacer es añadir los handler WHEN o WHEN OTHER.

Hemos de crear la seccion EXCEPTION
	EXCEPTION
		WHEN no_data_found THEN
			dmbs_output.put_line('Datos no encontrados')
		WHEN too_many_rows THEN
			dmbs_output.put_line('Demasiadas filas.')
		WHEN OTHERS THEN
			dmbs_output.put_line('Error indeterminado')


Excepciones definidas por el usuario
------------------------------------
Éstas excepciones se usan para tratar condiciones de error definidas por el
programador. Para su utilización hay que seguir 3 pasos.

1. Se declaran en la sección DECLARE de nuestro programa de la siguiente manera:
	nombreExcepcion EXCEPTION;

2. Se disparan en la sección ejecutable del programa por la orden RAISE
	RAISE nombreExcepcion;

3. Se tratan en la sección EXCEPTION según el formato ya conocido.


	DECLARE
		...
		importeErroneo EXCEPTION;
		precioMin number;
		precioMax number
		...
	BEGIN
		IF precio NOT BETWEEN precioMin AND precioMax THEN
			RAISE importeErroneo;
		END IF;
		...

		EXCEPTION
			WHEN importeErroneo THEN
				dbms_output.put_line('El importe es erróneo, venta cancelada.');
			WHEN OTHERS THEN
				dbms_output.put_line('Fallo desconocido');
	END

Ejercicio:
Crear un procedimiento en el que se reciba numero de empleado y cantidad, de tal
forma que al pasar al procedimiento el numero de empleado, se incremente en esa 
cantidad al salario. Vamos a usar 2 excepciones:
	- salario_nulo
	- no_data_found
