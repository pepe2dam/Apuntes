Registros y colecciones:
========================

Registro sin limitaciones: 

1. Se define el tipo generico del registro:

1.- Se define el tipo genérico del registro


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

2.- Se declaran las variables que se necesiten de ese tipo según el formato:
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
	
