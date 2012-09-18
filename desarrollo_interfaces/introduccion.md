Estilos de programación
=======================

* Programacion secuencial
* programacion estructurada
* POO

Esta evolucion viene por el objetivo de que el usuario pueda usar una aplicacion para obtener
determinado objetivo.

Podemos entender estilos de programación los métodos que existen para mejorar la calidad de los
programas de software.

Para que un programa pueda ser considerada como bueno debe cumplir una serie de requisitos. Si no
los cumple es un mal programa:

1. Que funcione.
2. No debe tener dificultades.
3. Debe estar bien documentado. 
	La documentación de una aplicación es uno de los elementos más impor
	tantes del producto, ya que permite realizar futuras actualizaciones de forma cómoda y rápida.
	Existen dos tipos de documentación:

	2.1. Externas. Generalmente, de forma impresa se adjunta al propio proyecto.
		· Cuaderno de carga: Dirigida al programador, es un documento que contendrá todo lo relacionado con la aplicación.
		· Manual de usuario: De forma didáctica, el usuario debe entender el manejo de la aplicación.
	2.2. Interna. Hace referencia a comentar código.
4. Debe ser eficiente.	

La creación de la documentación exige de un programador la necesidad de tener una  estructura planificada que 
permita realizar una serie de fases que facilite la comprensión de cómo se ha hecho la aplicación.

Las fases de construcción de un programa pueden contener los siguientes elementos.


1. Introducción. 
----------------

Se produce una descripción de la empresa y de los estamentos que han intervenido. En un
Cuaderno de carga, la introducción puede contener elementos como:
	* Con qué SW se ha hecho la aplicación
	* Programas y versiones de estos.
	* Guia de instalación y desinstalación.


2. Definición o planteamiento del problema. 
------------------------------------------

Se trata de qué es lo que hace nuestra aplicación explicando
Qué es lo que queremos obtener. Si es necesario, debemos indicar de qué datos vamos a partir y qué datos
queremos obtener. En definitiva, qué es lo que hace esa aplicación.


3. Análisis del problema.
-------------------------

Una vez planteado qué es lo que se quiere hacer, el programador tiene que indicar cómo lo ha de hacer.
Para ello es necesario realizar un estudio exhaustivo de todos los elementos que van a intervenir. Estos
elementos se pueden dividir en 3 categorías:
	* Diagramas de proceso. Hacen referencia al análisis de todos los elementos que intervienen en el
	Proyecto de forma gráfica, utilizando para ello todas las herramientas existentes.
	* Diseño de registros y mensajes. Consiste en analizar, si los hubiera, todos los ficheros utilizados,
	indicando sus registros, nombre de campos, etc. También hay que incñuir los mensajes utilizados.
	* Condición/es para la solución. Cuando tenemos claro qué es lo que hay que hacer, cuando analizamos qué
	herramientas o estructuras vamos a necesitar para resolver el problema, es imprescindible redactar cómo
	vamos a solucionar el problema. Si el problema tiene más de una solución se deberán plantear todas ellas, 
	optando por cuál es la solución más óptima.


4. Programación a la solución del problema
------------------------------------------

* Organigrama
Esquema de lo que vamos a hacer

* Codificación
Plasmar en código el organigrama


5. Fase de edición, Puesta a punto y pruebas
--------------------------------------------

Entendemos por edición la posibilidad de editar mi código fuente con la intención de linkarlo y obtener así
el código objeto, que es lo que entiende el ordenador.

El paso siguiente es realizar la puesta a punto junto con un juego de pruebas, que recibe el nombre de juego
de ensayo, y que consiste en someter a nuestro programa fuente a una serie de situaciones con la intención de
buscar posibles errores.

Éste juego de ensayo ha de quedar perfectamente preparado para buscar, en todos los aspectos, errores. Existe
una serie de técnicas que pueden ayudar al juego de ensayos, controlando todos los aspectos de la programación.
Éstas técnicas o conjunto de pruebas reciben dos nombres:

1. Técnica de la caja blanca.
Se basa en un minucioso examen de los procedimientos para verificar:
	1. funciones y procedimientos funcionan correctamente.
	2. que la entrada de datos es adecuada. 
	3. salida de datos adecuada.

	Tiene una serie de pruebas:
	* Prueba de camino básico.
		Se garantiza que la presente aplicación se ha ejecutado totalmente al menos una vez.

	* Prueba de estructura de control.
		consiste en realizar pruebas que garanticen el buen uso de las estructuras condicionales, bucles y flujo de datos.
	
		Consiste en hacer un examen exhaustivo de todas las estructuras de control. Para ello habrá que distinguir entre
		bucles simples y bucles anidados.
			* Bucles simples:
			Analizamos todos los bucles simples tomando nota de todos los resultados.
				1. Ejecutamos saltándonos la estructura repetitiva.
				2. Ejecutar sólo 1 vez la estructura repetitiva.
				3. Ejecutar pasando 2 veces por el bucle.
				4. Ejecutar pasando n-1 veces por el bucle, siendo n el límite superior.
				5. Ejecutar completamente el bucle.

			* Bucles anidados.
				1. Comenzar con el bucle más interno y con el valor mínimo de los demás, analizando el resultado.
				2. Progresar hacia fuera en los bucles.
				3. Probar todos los bucles para observar si se obtiene el rendimiento adecuado.


2. Técnica de la caja negra.

Se encarga de buscar errores en:
* errores de interfaz
* Errores en las estructuras
* Errores de acceso a la db
* Errores de rendimiento

