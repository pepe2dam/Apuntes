FUNDAMENTOS DE VISUAL BASIC
===========================
Visual Basic (En adelante VB) puede manejar una serie de datos. Podemos destacar
los siguientes

|  __TIPO__      |     __CLS__    |    __RANGO__        |        __TAMAÑO__     |
|----------------|----------------|---------------------|-----------------------|
|   Boolean      |System.boolean  |      true/false     |       2 byte          |
|   Byte         |System.byte     |    8 bit (0 - 255)  |       1 byte          |
|   Char         |System.char     |      0 - 65535      |       2 byte          |
|   Date         |System.DateTime |  1/1/1 - 31-12-1999 |       8 byte          |
|   Decimal      |System.Decimal  |     28 digitos      |       16 byte         |  Entero muy largo
|   Double       |System.double   | coma flotante 64bit |       8 byte          |
|   Integer      |System.Int32    |                     |       4 byte          |  Entero
|   Long         |System.int64    |                     |       8 byte          |  Entero
|   Object       |System.Object   |                     |       4 byte          |
|   Short        |System.int16    |                     |       2 byte          |
|   Single       |System.single   |  Numeros decimales  |       4 byte          |
|   String       |System.string   |   0 - 2000000000    |    Según longitud     |
|Definidas por usruario|system.valuetype|segun definicion                       |
|-------------------------------------------------------------------------------|


DEFINICION DE VARIABLES Y CONSTANTES EN VB.NET
----------------------------------------------
1. __Variable__
Una variable es una zona de memoria en la que se almacena un valor.
.Net tiene variables explícitas e implícitas:
	1.1. _Explícitas_ Variables que, de forma deliverada, es definida por el usuario
	para ser utilizada. La síntáxis para definir una variable explícita es:
	
	> Dim
	> Private
	> Public
	> ReadOnly         _nombre_       as      tipo          [ = valor_inicial]
	> Static
	> Friend
	> Protected

	donde el ámbito puede ser:
		* Dim: Se utiliza para definir variables locales a un procedimiento o 
		función
		* Private: Define variables locales a nivel bloque, es decir, a nivel 
		estructura repetitiva o condicional 
		* Public: variables globales. Su Ámbito global estará determinado por el
		lugar donde se defina
		* Readonly: variables que solo pueden ser leídas
		* Static: Permite definir una variable que conserva valores anteriores
		* Friend: variables de ámbito global sólo accesibles en el ensamblado
		propio de nuestro programa, evitando ser usada por otros programas ajenos
		al nuestro
		* Protected: variable protegida diseñada para ser usada en una clase
		concreta o en las clases que heredan de ella.
	nombre es el nombre que se le dará a la variable.
	As tipo se refiere al tipo de dato que vamos a definir
	valor inicial
	
	1.2. _Implícitas_ VB.NET no obliga a declarar explícitamente las variables.
	Cuando VB define variables automáticamente del tipo valor que se le asigna a 
	la variable, es una variable implícita. Para obligar a realizar definición de
	las variables de forma explícita, será necesario acceder a las propiedades del 
	proyecto y jugar con on u off "OPTION EXPLICIT".

2. __Contantes__
Hay 2 tipos de constantes:
	2.1. _Simbólicas_
	Aquellas constantes definidas por el usuario y que llevan la palabra reservada
	const
	2.2. _Intrínsecas_
	Son una serie de constantes internas de VB.


AMBITO DE LAS VARIABLES
-----------------------
1. Ámbito de bloque.
	1.1. Dim
	1.2. Private
	1.3. Static
2. Ámbito de procedimiento.
	2.1. Dim
	2.2. Static
3. A nivel Namespace.
	3.1. Public. Accesibles a cada procedimiento del formulario.
4. A nivel de módulo. 
Consiste en definir una variable global sólo con public cuyo ámbito será TODA
la apliciación.


OPERADORES
----------
1. Aritméticos
	"^", "
2. Relacionales:
	=, >, <, <=, >=, <>, like
3. Lógicos:
	NOT, AND, OR
4. Cadena:
	+, &


CLASE CONSOLE
-------------
Contiene una serie de métodos que permiten relacionarse con la pantalla. De todos
los métodos existentes, destacaremos los siguientes:
* Console.write().
No produce retorno de carro
* Console. writeLine()
Sí produce retorno de carro. No se usa para visualizar literales.
* Console.read()
Detiene la ejecución de un programa y espera a que el usuario introduzca datos, 
que serán introducidos en una variable.
* Console.readLine()
Como read() pero necesita retorno de carro para finalizar.

Para visualizar el contenido de una variable, una de las formas que se puede 
utilizar es lo que se denomina marGcadores de posición, que consiste en hacer
una numeración entre llaves y empezando por 0 de las variables que se quieren 
visualizar. Como printF()

	dim a as string = "a"
	dim b as integer = 4
	dim c as long = 444222333.112344444112341234
	console.writeLine("{0}{1}{2}", a, b, c)

ejercicio:
1. Programa que introduzca por teclado nombre y edad y lo visualize.
2. Introducir 2 numeros, visualizando suma, resta, multiplicación y division


ESTRUCTURAS DE CONTROL
----------------------
Permite tomar decisiones y repetir acciones en un programa. Para ello existen 
distintas estructuras de control.

	if condicion then
	end if

	if condicion then
	-
	-
	-
	else
	-
	-
	end if

	if condicion then
	-
	-
	-
	-
	else
		if condicion else
		end if
	end if

	select case variable
		case 1,4
		case 2 to 5
		case 3
		case else


Ejercicio
>	Realizar un proyecto que, creando un menu de 4 opciones, visualice la opcion
>	pulsada

>	realizar un proyecto que introduciendo por teclado una nota entera, me
>	visualice en letra la calificacion.

ESTRUCTURAS REPETITIVAS
-----------------------

## for...next
Es una estructura repetitiva en la que de antemano se conoce el número de veces
que se va a repetir. Sintáxis:
	for variable_control = valor inicias to valor_final step salto
	
	next variable_control

Para salir de un for antes de que se cumpla la condición de salida, utilizamos
"exit for"

## while
consiste en repetir una o un grupo de acciones mientras la condición sea verdadera
	while condicion
	---
	end while

## Do loop
Tiene 4 posibles sintaxis:
1. Como while
	do while condicion
	---
	loop
2. Siempre entra en la primera iteraación
	do
	---
	loop while condicion
3. Realiza acciones hasta que la condición sea cierta.
	do until condicion
	---
	loop
4. Como la anterior pero siempre entra a la primera iteración
	do
	---
	loop until condicion


## Excepciones
	Try
		accion sospechosa
	catch (Exception)
		accion a realizar en caso de error "excepcion"
	catch (Exception2)
		accion a relizar en caso de "excepcion2"
	finally
		Accion que se relaiza SIEMPRE

Se usa para "capturar" excepciones o controlar posibles errores.


## Estructuras de datos
En muchas ocasiones es necesario asignar más de un valor a una variable por lo
que es necesario el uso de estructuras internas que permitan guardar esos datos
y poder gestionarlos.

Existen 2 estructuras internas:
* Arrays
Un array es una estructura interna que permite guardar datos del mismo tipo en
una única variable. Para hacer referencia a esos datos se usa uno o varios índices.
.NET acepta hasta 32 dimensiones en los arrays. Para definir un array se utiliza 
la siguiente sintáxis:
	* Vectores o tablas unidimensionales:
		Dim nombreDelVector(longitud) as integer

		nombreDelVector(0) = 1
		nombdeDelVector(6) = 6
		...
		nombreDelVector(longitud) = 44
	Tiene (longitud + 1) posiciones. Existe una forma de inicializar directamente:
		dim nombre() as integer = {1,2,3,4,5,6,7,8,9}
	
	* Matrices o Arrays bidimensionales
	Se declara de la siguiente manera:
	Dim nombre(9,8) as integer.
	No se puede inicializar al declarar.

	* Arrays paralelos
	En muchas ocasiones tenemos la necesidad de usar arrays con diferentes tipos
	de datos. Esto es imposible en una matriz al uso, por lo que se aconseja usar
	arrays paralelos. Consiste en utilizar varios vectores gestionados a la vez,
	Es decir, gestionando siempre el mismo indice de ambos arrays

Ejercicio:
	Realizar un programa que permita introducir las calificaciones de 5 participantes
	en un concurso de cocina. De tal manera que deberá aparecer cuál es la puntuación
	más alta y a qué participante pertenece, la más baja y el participante y la nota
	media de los participantes. Todos los datos se calcularán de la tabla.
	Deberá existir una opción de salir, preguntando si o no.
	Los datos de entrada han de estar validados.

* Estructuras (structs)
Una estructura es un array especial, en el sentido de que permite diferentes tipos
de datos a la hora de almacenarlos, a diferencia de los arrays tradicionales, que
solo permiten el tipo de dato con el que se ha definido. Las estructuras se 
definen con la sentencia:
	structure
	...
	end structure
Una estructura está formada por dos partes:
	* definición: Se realiza antes del sub main(), fuera de él.
		Structure trololol
			dim a as integer
			dim b as string
		end strucure
	* Será necesario definir una variable especial del tipo "nombredelaestructura"
	con la que podremos acceder a todos los elementos de la estructura para poder
	leer y escribir en ellos
		public lol as trololol
	Para poder introducir varios registros en una sola variable de este tipo,
	hemos de dimensionar la variable.
		public lol(44) as trololol

	Dentro de una estructura podemos meter otra estructura


## Subprogramas, procedimientos y funciones.
### Subprogramas (Sub nombre() ... end sub):
	Es una forma a de organización de código por bloques qye tiene la caracteristica
	de que no puede devolcver valores al terminar su ejecución.

Ejercicio:
>	realizar un programa que me calcule el área de un triángulo usando un procedimiento
>	denominado triángulo, y terminando con un saludo final diseñado en otro procedimiento.

### Funciones (function):
Son procedimientos "especiales". El propio nombre de la funcion actúa como el
nombre de una variable, mientras que los procedimientos no. 
>	function nombrefuncion([byval/byref] param1, param2) as tipo_de_devolucion
>	end function

Para poder devolver un valor, basta con poner el nombre de la funcion y opcionalmente

## Parámetros.
Son datos que se pueden transmitir a los procedimientos o funciones llamados.
Hay dos tipos:
* Actuales:
Son los parámetros que tiene la funcion al definirla
Pueden ser de dos tipos, dependiendo de la posibilidad de que los valores originales
puedan ser modificados en la función llamada. Existen por tanto dos tipos de
parámetros actuales.
	* Paso por valor (byval).
	Los parámetros originales no cambian. Es el valor por defecto
	* Paso por referencia (byref).
	Permite modificar el valor del parámetro formal
* Formales:
Son los parámetros que se le pasan a la función al llamarla.

Ejemplo.
>	module module1
>		sub cua(byval a as integer)
>			a = 8
>			console.writeline("Valor inicial " & a)
>		end sub
>
>		sub main()
>			Dim a as integer = 55
>			console.writeline("Valor antes de la llamada " & a)
>			cua(a)
>			console.writeline("Valor despues de la llamada " & a)
>			console.readline
>		end sub
>	end module

Ejercicio:
>	Realizar un ejercicio, que mediante un menu me permita calcular el área del
>	triángulo, del cuadrado, de la circunferencia y salir. Utilizando únicamente
>	procedimientos o funciones con parámetros.


CLASES
======
Para definir una clase en VB necesitamos tener claro varios apartados. 
1. Creación de la clase
	class xxxx
		atributos
		métodos
	end class

2. Generar una variable especial que cuando se define, se crea una instancia que
permite usar los elementos de la clase. Ésta estancia usa la palabra reservada 
"new". Existen 3 formatos para definir un objeto:

	Dim objeto As nombreDeClase
	objetos = new nombreDeClase

	Dim objeto as nombreDeClase = new nombreDeClase

	Dim objeto as new nombreDeClase()

3. ya se puede acceder a los elementos de la clase. bastará con poner 
objeto.metodo() u objeto.propiedad

Ejercicio:
	Realizar un programa que, usando una clase, incorporará un menú con una serie
	de opciones como el area del triangulo, cuadrado, rombo y circunferencia,
	cuyos cáclulos deberán ser programados en otra clase.


AGREGAR UNA CLASE COMO FICHERO EN UN PROYECTO
---------------------------------------------
Consiste en seguir los siguientes pasos:
1. Ir a nombre del proyecto > boton derecho > agregar > clase
2. Poner nombre al fichero
3. insertar la o las clases en el nuevo editor
4. guardar

este fichero aparecerá en el explorador de soluciones y podrá ser usado (llamar 
a todas las clases y métodos de forma convencional) en el programa principal.


BIBLIOTECAS DE CLASES
=====================
Para definirlas será necesario realizar los siguientes pasos:
* abrir la opción de biblioteca de clases, donde se escribirá la o las clases que
se necesiten.
* Build
* Save all.

Una vez diseñada la biblioteca de clases será el momento de añadirlo a nuestro 
proyecto, ya que es un elemento externo a él, por lo que es necesario añadirla a
nuestro proyecto.

Para importar una DLL:
1. Sobre el nombre del proyecto: "Agregar referencia" (Add reference)
2. Examinar -> buscamos dll -> añadir (Browse)
3. importar a nuestro código los elementos necesarios para poder utilizarla. para 
ello utilizamos "import"


CONSTRUCTORES
=============
Un constructor es un método especial que pertenece a una clase y que es llamado
automáticamente al crear una instancia de la clase. Su sintáxis es

	Sub new()
	End Sub

Acepta parámetros y no devuelve datos.

Si no creamos el constructor, VB crea uno por defecto

DESTRUCTORES
============
Permiten liberar memoria en el momento en que un objeto deja de ser usado. Se 
crea un método especial por cada clase. Su sintáxis es.

	Protected override Sub finalize()
	end sub


HERENCIA
========
Es una de las características más importantes de la POO. consiste en que una clase
puede heredar atributos y métodos de otra. De ésta manera ahorramos código.

con la herencia aparece una clasificación de clases, existiendo en un nivel 
superior lo que se conoce como clase "base" o "superclase" y un nivel inferior 
llamado clase derivada o sub clase.

Para poder heredar en una clase se utiliza la palabra reservada "inherits". para
poder usar herencia, hay que tener en cuenta una serie de reglas.

* Una subclase puede heredar de una superclase todos los atributos y métodos
excepto constructores y destructores. Tampoco se pueden heredar los definidos como
private.
* Cuando una subclase hereda un método o atributo de una superclase y el nombre
coincide con el de algún método propìo, no se tendrá acceso a la clase heredada
a no ser que incorpore la expresión "shadow" delante de la derivada.
* Los atributos y métodos heredados de una superclase en una clase hija pueden ser
a su vez heredados por clases que hereden de la clase hija. 

Evitando la herencia
--------------------
Para evitar que una clase sea heredada, bastará con poner, delante de la palabra
"class" , la expresión NNotInheritable"

Obligando a heredar (Clases abstractas)
-------------------
Para obligar que una clase sea heredada, se pondrá, delante de la palabra
reservada class, "mustinherit"

NAMESPACES
==========
Se trata de un mecanismo que permite organizar, formando espacios independientes,
todas las clases que se pueden utilizar. Se trata, por tanto, de simplificar y
organizar a modo de paquetes, el acceso a clases. Su sintáxis es:

	NameSpace primero
		
		class uno
		end class

		class dos
		end class

	End NameSpace

	NameSpace segundo

		class tres
		end class

		class cuatro
		end class

	end NameSpace
