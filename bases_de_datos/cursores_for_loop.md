CURSORES FOR...LOOP:
====================

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

TABLAS ANIDADAS:
================

Son estructuras similares a los VARRAYS ,  pero con la diferencia de que no tienen longitud fija.
Para crearlas:
1.	Se define el tipo en la sección declarativa según el formato:

	TYPE nombre_tipotablaanidada IS TABLE OF tipoelementos [NOTNUL];
2.	Declaramos e inicializamos las variables, igual que en el caso de los VARRAY , pero en este caso las tablas anidadas permiten inicializar la variable con una lista incompleta o vacía:
Nombre_variable   := nombre_tipovarray();
                Y añadir filas nuevas a la variable ya inicializada usando el métodoEXTEND  según el formato:
Nombre_variable_de-tabla_anidada.EXTEND;

Ejemplo de tabla anidada usando el método EXTEND. Declarar  una variable del tipo t_meses incluyendo los meses.


	DECLARE
        	TYPE t_meses IS TABLE (10) OF VARCHAR2(10);
	Va_mesest_meses;
	BEGIN
		Va_meses := t_meses ('Enero', 'Febrero','Marzo','Abril','Mayo','Junio','Julio','Agosto','Septiembre','Octubre');
		Va_meses.EXTEND;
		Va_meses(11):= 'Noviembre';
		Va_meses.EXTEND;
		Va_meses(12):= 'Diciembre';

		FOR i IN 1..12 LOOP
			DBMS_OUTPUT.PUT_LINE(TO_CHAR(i) || '_'|| va_meses(i));
		END LOOP;

	END;
	
TABLAS INDEXADAS:
=================
