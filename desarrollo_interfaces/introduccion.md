Estilos de programaci�n
=======================

* __Programacion secuencial__
* __programacion estructurada__
* __POO__

Esta evolucion viene por el objetivo de que el usuario pueda usar una aplicacion para obtener
determinado objetivo.

Podemos entender estilos de programaci�n los m�todos que existen para mejorar la calidad de los
programas de software.

Para que un programa pueda ser considerada como bueno debe cumplir una serie de requisitos. Si no
los cumple es un mal programa:

1. __Que funcione.__
2. __No debe tener dificultades.__
3. __Debe estar bien documentado.__
	La documentaci�n de una aplicaci�n es uno de los elementos m�s impor
	tantes del producto, ya que permite realizar futuras actualizaciones de forma c�moda y r�pida.
	Existen dos tipos de documentaci�n:

	2.1. Externas. Generalmente, de forma impresa se adjunta al propio proyecto.
		� Cuaderno de carga: Dirigida al programador, es un documento que contendr� todo lo relacionado con la aplicaci�n.
		� Manual de usuario: De forma did�ctica, el usuario debe entender el manejo de la aplicaci�n.
	2.2. Interna. Hace referencia a comentar c�digo.
4. __Debe ser eficiente.__

La creaci�n de la documentaci�n exige de un programador la necesidad de tener una  estructura planificada que 
permita realizar una serie de fases que facilite la comprensi�n de c�mo se ha hecho la aplicaci�n.

Las fases de construcci�n de un programa pueden contener los siguientes elementos.


1. Introducci�n. 
----------------

Se produce una descripci�n de la empresa y de los estamentos que han intervenido. En un
Cuaderno de carga, la introducci�n puede contener elementos como:
	* Con qu� SW se ha hecho la aplicaci�n
	* Programas y versiones de estos.
	* Guia de instalaci�n y desinstalaci�n.


2. Definici�n o planteamiento del problema. 
------------------------------------------

Se trata de qu� es lo que hace nuestra aplicaci�n explicando
Qu� es lo que queremos obtener. Si es necesario, debemos indicar de qu� datos vamos a partir y qu� datos
queremos obtener. En definitiva, qu� es lo que hace esa aplicaci�n.


3. An�lisis del problema.
-------------------------

Una vez planteado qu� es lo que se quiere hacer, el programador tiene que indicar c�mo lo ha de hacer.
Para ello es necesario realizar un estudio exhaustivo de todos los elementos que van a intervenir. Estos
elementos se pueden dividir en 3 categor�as:

* __Diagramas de proceso__. 
Hacen referencia al an�lisis de todos los elementos que intervienen en el
Proyecto de forma gr�fica, utilizando para ello todas las herramientas existentes.
		
* __Dise�o de registros y mensajes__. 
Consiste en analizar, si los hubiera, todos los ficheros utilizados,
indicando sus registros, nombre de campos, etc. Tambi�n hay que inc�uir los mensajes utilizados.
	
* __Condici�n/es para la soluci�n__. 
Cuando tenemos claro qu� es lo que hay que hacer, cuando analizamos qu�
herramientas o estructuras vamos a necesitar para resolver el problema, es imprescindible redactar c�mo
vamos a solucionar el problema. Si el problema tiene m�s de una soluci�n se deber�n plantear todas ellas, 
optando por cu�l es la soluci�n m�s �ptima.


4. Programaci�n a la soluci�n del problema
------------------------------------------

* __Organigrama__
Esquema de lo que vamos a hacer

* __Codificaci�n__
Plasmar en c�digo el organigrama


5. __Fase de edici�n, Puesta a punto y pruebas__
--------------------------------------------

Entendemos por edici�n la posibilidad de editar mi c�digo fuente con la intenci�n de linkarlo y obtener as�
el c�digo objeto, que es lo que entiende el ordenador.

El paso siguiente es realizar la puesta a punto junto con un juego de pruebas, que recibe el nombre de juego
de ensayo, y que consiste en someter a nuestro programa fuente a una serie de situaciones con la intenci�n de
buscar posibles errores.

�ste juego de ensayo ha de quedar perfectamente preparado para buscar, en todos los aspectos, errores. Existe
una serie de t�cnicas que pueden ayudar al juego de ensayos, controlando todos los aspectos de la programaci�n.
�stas t�cnicas o conjunto de pruebas reciben dos nombres:

1. __T�cnica de la caja blanca.__
Se basa en un minucioso examen de los procedimientos para verificar:
	1.1. funciones y procedimientos funcionan correctamente.
	1.2. que la entrada de datos es adecuada. 
	1.3. salida de datos adecuada.

	Tiene una serie de pruebas:
	* __Prueba de camino b�sico.__
	Se garantiza que la presente aplicaci�n se ha ejecutado totalmente al menos una vez.

	* __Prueba de estructura de control__
	consiste en realizar pruebas que garanticen el buen uso de las estructuras condicionales, bucles y flujo de datos.
	
	Consiste en hacer un examen exhaustivo de todas las estructuras de control. Para ello habr� que distinguir entre
	bucles simples y bucles anidados.
		* __Bucles simples__
		Analizamos todos los bucles simples tomando nota de todos los resultados.
			* Ejecutamos salt�ndonos la estructura repetitiva.
			* Ejecutar s�lo 1 vez la estructura repetitiva.
			* Ejecutar pasando 2 veces por el bucle.
			* Ejecutar pasando n-1 veces por el bucle, siendo n el l�mite superior.
			* Ejecutar completamente el bucle.

		* __Bucles anidados__
			* Comenzar con el bucle m�s interno y con el valor m�nimo de los dem�s, analizando el resultado.
			* Progresar hacia fuera en los bucles.
			* Probar todos los bucles para observar si se obtiene el rendimiento adecuado.


2. __T�cnica de la caja negra.__

	Se encarga de buscar errores en:
	2.1. __Errores de interfaz__
	2.2. __Errores en las estructuras__
	2.3. __Errores de acceso a la db__
	2.4. __Errores de rendimiento__
	2.5. __Errores al iniciar y terminar el programa__

	La caja negra tiene una serie de t�cnicas:

	* __Partici�n equivalente__:
		Consiste en hacer un estudio detallado de todos los valores l�mite de todos los datos que intervienen en la aplicaci�n.

	* __An�lisis de valores l�mite__:
		Consiste en analizar todos los valores l�mite de todas las estructuras utilizadas.

	* __Prueba de comparaci�n__:
		Ejecutar nuestra aplicaci�n en diferentes ordenadores con diferentes caracter�sticas con la intenci�n de quie los resultados
		sean los mismos. Se denomina tambi�n software redundante.


6. Fase de documentaci�n
------------------------
	Consiste en recopilar toda la informaci�n del proyecto prepar�ndola para ser archivada.
