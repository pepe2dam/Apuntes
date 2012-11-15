BASES DE DATOS OBJETO RELACIONALES
==================================

## introducción
Las bases de datos constituyen una de las piezas fundamentales de muchos sistemas
de información, muchas de ellas, sobre todo las más tradicionales, son difíciles
de utilizar cuando las aplicaciones que acceden a los datos utilizan lenguajes de
programación orientado a objetos como C++ o Java.

Este fue uno de los motivos de la creación de las bases de datos orientadas a 
objetos, además de dar solución al surgimiento de aplicaciones más sofisticadas 
que necesitan tipos de datos y operaciones más complejas.

Los fabricantes de SGBD relaciónales han ido incorporando en las nuevas versiones
muchas de las propuestas para las bases de datos orientadas a objetos, un ejemplo 
son Informix, Oracle o PostgreSQL.

Esto ha dado lugar al modelo relacional extendido y a los sistemas que lo 
implementan que son los llamados sistemas objeto-relacionales.


## DB objeto-relacionales
Las Bases de Datos Objeto-Relacionales (BDOR) son una extensión de las bases de
datos relacionales tradicionales a las que se les ha añadido conceptos del modelo
orientado a objetos, por tanto un Sistema de Gestión de Base de Datos
Objeto-Relacional (SGBDOR) contiene características del modelo relacional y del
orientado a objetos; es decir, es un sistema relacional que permite almacenar
objetos en las tablas.

Las características más importantes de los SGBDOR son las siguientes:

* Soporte de tipos de datos básicos y complejos. El usuario puede crear sus propios
tipos de datos.
* Soporte para crear métodos para esos tipos de datos. Se pueden crear funciones 
miembro usando tipos de datos definidos por el usuario.
* Gestión de tipos de datos complejos con un esfuerzo mínimo.
* Herencia.
* Se pueden almacenar múltiples valores en una columna de una misma fila.
* Relaciones (tablas) anidadas.
* Compatibilidad con las bases de datos relaciónales tradicionales. Es decir, se
pueden pasar las aplicaciones sobre bases de datos relaciónales al nuevo modelo
sin tener que rescribirlas.
* El inconveniente de las BDOR es que aumenta la complejidad del sistema, esto
ocasiona un aumento del coste asociado.


## Tipos de colección
Los atributos multivaluados, rompen directamente la primera formal normal. Con
este tipo de atributo básicamente se expresa todo lo contrario a la 1FN. Se dice,
que un atributo puede tener más de un valor, pero son del mismo tipo. Codd, que
habla de la primera forma normal solo como atomicidad para evitar que el valor no
se pueda dividir conceptualmente, por tanto se enfoca más no en que se pueda
tener varios valores del mismo tipo, sino que ese valor en sí sea indivisible
conceptualmente.

En todo caso, este tipo de atributo amplia enormemente el modelo de cara a
modelar en mundo real. Con los gestores BBDDO-R se puede lograr obtener atributos
con múltiples valores.

Las bases de datos relaciónales orientadas a objetos pueden permitir el
almacenamiento de colecciones de elementos en una única columna. Tal es el caso
de los VARRAYS en Oracle, que son similares a los arrays de C, que permiten
almacenar un conjunto de elementos, todos del mismo tipo, y cada elemento tiene
un índice asociado; y de las tablas anidadas que permiten almacenar en una
columna de una tabla otra tabla.

### VARRAYS
Podemos representar los atributos multivaluados en la BBDD a través de las
colecciones. Una colección es un grupo de elementos del mismo tipo. En Oracle se
usan los tipos para crear colecciones. Supóngase que se desea guardar los nombres
de los hijos de los empleados. Para esto se puede usar una colección. La relación
puede tener las siguientes ocurrencias:

Para crear una colección de elementos varrays se usa la orden CRÉATE TYPE. El 
siguiente ejemplo crea un tipo VARRAY de nombre TELEFONO de tres elementos donde
cada elemento es del tipo VARCHAR2:

	CREATE TYPE TELEFONO AS VARRAY(3) OF VARCHAR2(9);

Cuando se declara un tipo VARRAY no se produce ninguna reserva de espacio. Para
obtener información de un VARRAY usamos la orden DESC (DESC TELEFONO). La vista
USER_VARRAYS obtiene información de las tablas que tienen columnas varrays.

Ejercicio:
Hacer un bucle que muestre los nombres y teléfonos de la tabla agenda y devuelve
el número de elementos del VARRAY


Ejercicio:
Crear un tipo con nombre t_alumnos con 4 atributos. 1 del tipo persona y 3 que 
indican las notas de la 1ª, 2ª y 3ª evaluación. Después crea un bloque PLSQL e 
inicializa un objeto de ese tipo

### MÉTODOS
Se declaran de la siguiente manera:
	
	member procedure set_atributo (c varchar2(2));
	member procedure get_atributo return varchar2;

Para el constructor:
	
	member procedure constructor return self as result;

Ejemplo:
Definir un tipo rectángulo con 3 atributos y un constructor.


