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
	donde: 
	* Ámbito:
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
	* nombre es el nombre que se le dará a la variable.
	* As tipo se refiere al tipo de dato que vamos a definir
	* valor inicial
	
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
	4.1
	4.2
	4.3
	4.4
