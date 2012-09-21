INTERFACES DE USUARIO
=====================
En muchas ocasiones, un usuario va con ansiedad al manejo de una aplicación ya 
que el ordenador es un elemento extraño para él. Para éste tipo de usuarios novatos,
el manejo de una aplicación puede ser frustrante y por tanto, ocasionar un rechazo
de la misma. Para ésto surge la necesidad de estudiar cómo realizar un interfaz 
que evite esa frustración. 

Entendemos por interfaz el "envoltorio" con el que se encuentra el usuario de 
nuestra aplicación y que le va a permitir manejarla. Ese envoltorio es fundamental
para que nuestra aplicación sea aceptada de manera amigable por cualquier tipo de
usuario.

Existen una serie de factores que condicionan el diseño de una interface:
1. __tipo de usuario__
Existen 3 tipos de usuarios:
	1.1 _Novatos_
	Se caracterizan por 
	* No tienen conocimientos de informática
	* No conocen la semántica ni la sintáctica de la informática
	* Llegan a la máquina con ansiedad.
	* Tienen ganas de termiar
	
	Una aplicación para este tipo de usuarios debe ser:
	* Ayuda completa
	* Restringir el vocabulario
	* Pocas opciones
	* Conducir las tareas
	* Evitar respuestas rápidas del sistema
	* Mensajes de error constructivos y amables
	* Confirmaciones de acciones
	* texto legible (contraste)


	1.2 _Intermedios u ocasionales_
	Son usuarios con algunos conocimientos de informática, dominan algo la semántica
	y la sintáxis aunque la inmensa mayoría no conocen el desarrollode una aplicacion.
	Suelen aprender con cierta rapidez y pueden recordar dónde están las acciones.

	Una aplicación para estos usuarios ha de ser:
	* Más fluida
	* Respuestas inmediatas
	* Poca retroalimentación
	* Uso de macros
	* Entornos no excesivamente cargados
	* Ayuda más amplica que para los novatos
	* "Perdonar los errores" permitiendo que cuando el usuario lo joda, pueda recuperarlo

	1.3 _Expertos_
	Sí tienen conocimientos de informática. Dominan semántica y sintáxis. Pueden
	aprender rápidamente. Suelen ser profesionales y, por tanto, el entorno ha
	de ser profesional.

	Una aplicación para estos usuarios ha de ser:
	* El entorno ha de ser progesional
	* No gifs.
	* información directa.
	* Acciones en pocos pasos.
	* Uso de macros.

Una aplicación de propósito general ha de estar diseñada para un público general,
por lo que será necesario que el programador sea aceptado de forma general.

2. __Área de trabajo__
No todas las aplicaciones son iguales y, aparte del usuario al que va dirigido y
relacionado con él, es necesario que el programador tenga en cuenta en qué área de 
trabajo va a ser explotada la aplicación.

Existen 3 áreas de trabajo:
	2.1 _Sistemas críticos:_
	son aplicaciones pensadas para expertos y que tienen un carácter de profesionalidad
	muy alto, como por ejemplo el control aéreo, centrales nucleares... Se caracterizan
	por requerir muchos cálculos

	Se caracterizan por:
	* Tener un alto coste.
	* Entrenamiento previo.
	* Requieren motivación.

	2.2 _Industrial y comercial_
	Se trata de aplicaciones no críticas que se basan en el manejo de bases de 
	datos fundamentalmente en el ámbito de los negocios. Están pensadas para 
	usuarios intermedios y expertos formados para su uso
	tipos:
	* Reserva de plazas de avion
	* Aplicaciones bancarias
	* Aplicaciones de gestión de negocios
	* Inventarios
	* Control de costes.
	* ...

	Estas aplicaciones deben ser:
	* No necesitan motivación
	* fáciles de aprender
	* entorno amigable
	* ...

	2.3 _Oficinas, hogares y entretenimiento_
	Se trata de un área de trabajo enfocada a todos los tipos de usuarios. Se 
	caracterizan por ser aplicaciones de bajo coste, ser fáciles de entender,
	tener gran fiabilidad, atractivos para la venta y no requieren entrenamiento.


3. __Factores humanos__
El ser humano es limitado en factores como el tiempo de concentración, percepción
visual, memorizar acciones...

Éstos factores hay que tenerlos en cuenta a la hora de diseñar nuestro proyecto. 
Para ello el programador debe ser capaz de usar una serie de mecanismos que los
entornos visuales ponen a su disposición para evitar ese rechazo.
Factores auditivos como pequeños sonidos.
Factores táctiles como el manejo del ratón, teclado o manejo de pantallas táctiles 
pueden hacer que los usuarios no sufran cansancio .

Será necesario que el programador encuentre el punto en que los factores humanos 
sean tratados de tal forma que se evite que los usuarios se cansen de nuestra 
aplicacion sin abusar de sus contenidos.


PRINCIPALES CRITERIOS PARA EL DISEÑO DE INTERFACES
--------------------------------------------------
Una aplicación etá basada generalmente en 3 categorías o vistas que el usuario
va a trabajar. Cada una de ellas tiene unos criterios de desarrollo diferentes.
Estas vistas son:
1. Interacción general de nuestro proyecto
2. Interacción de entrada de datos
3. Interacción de salida de datos
