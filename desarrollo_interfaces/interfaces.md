INTERFACES DE USUARIO
=====================
En muchas ocasiones, un usuario va con ansiedad al manejo de una aplicaci�n ya 
que el ordenador es un elemento extra�o para �l. Para �ste tipo de usuarios novatos,
el manejo de una aplicaci�n puede ser frustrante y por tanto, ocasionar un rechazo
de la misma. Para �sto surge la necesidad de estudiar c�mo realizar un interfaz 
que evite esa frustraci�n. 

Entendemos por interfaz el "envoltorio" con el que se encuentra el usuario de 
nuestra aplicaci�n y que le va a permitir manejarla. Ese envoltorio es fundamental
para que nuestra aplicaci�n sea aceptada de manera amigable por cualquier tipo de
usuario.

Existen una serie de factores que condicionan el dise�o de una interface:
1. __tipo de usuario__
Existen 3 tipos de usuarios:
	1.1 _Novatos_
	Se caracterizan por 
	* No tienen conocimientos de inform�tica
	* No conocen la sem�ntica ni la sint�ctica de la inform�tica
	* Llegan a la m�quina con ansiedad.
	* Tienen ganas de termiar
	
	Una aplicaci�n para este tipo de usuarios debe ser:
	* Ayuda completa
	* Restringir el vocabulario
	* Pocas opciones
	* Conducir las tareas
	* Evitar respuestas r�pidas del sistema
	* Mensajes de error constructivos y amables
	* Confirmaciones de acciones
	* texto legible (contraste)


	1.2 _Intermedios u ocasionales_
	Son usuarios con algunos conocimientos de inform�tica, dominan algo la sem�ntica
	y la sint�xis aunque la inmensa mayor�a no conocen el desarrollode una aplicacion.
	Suelen aprender con cierta rapidez y pueden recordar d�nde est�n las acciones.

	Una aplicaci�n para estos usuarios ha de ser:
	* M�s fluida
	* Respuestas inmediatas
	* Poca retroalimentaci�n
	* Uso de macros
	* Entornos no excesivamente cargados
	* Ayuda m�s amplica que para los novatos
	* "Perdonar los errores" permitiendo que cuando el usuario lo joda, pueda recuperarlo

	1.3 _Expertos_
	S� tienen conocimientos de inform�tica. Dominan sem�ntica y sint�xis. Pueden
	aprender r�pidamente. Suelen ser profesionales y, por tanto, el entorno ha
	de ser profesional.

	Una aplicaci�n para estos usuarios ha de ser:
	* El entorno ha de ser progesional
	* No gifs.
	* informaci�n directa.
	* Acciones en pocos pasos.
	* Uso de macros.

Una aplicaci�n de prop�sito general ha de estar dise�ada para un p�blico general,
por lo que ser� necesario que el programador sea aceptado de forma general.

2. __�rea de trabajo__
No todas las aplicaciones son iguales y, aparte del usuario al que va dirigido y
relacionado con �l, es necesario que el programador tenga en cuenta en qu� �rea de 
trabajo va a ser explotada la aplicaci�n.

Existen 3 �reas de trabajo:
	2.1 _Sistemas cr�ticos:_
	son aplicaciones pensadas para expertos y que tienen un car�cter de profesionalidad
	muy alto, como por ejemplo el control a�reo, centrales nucleares... Se caracterizan
	por requerir muchos c�lculos

	Se caracterizan por:
	* Tener un alto coste.
	* Entrenamiento previo.
	* Requieren motivaci�n.

	2.2 _Industrial y comercial_
	Se trata de aplicaciones no cr�ticas que se basan en el manejo de bases de 
	datos fundamentalmente en el �mbito de los negocios. Est�n pensadas para 
	usuarios intermedios y expertos formados para su uso
	tipos:
	* Reserva de plazas de avion
	* Aplicaciones bancarias
	* Aplicaciones de gesti�n de negocios
	* Inventarios
	* Control de costes.
	* ...

	Estas aplicaciones deben ser:
	* No necesitan motivaci�n
	* f�ciles de aprender
	* entorno amigable
	* ...

	2.3 _Oficinas, hogares y entretenimiento_
	Se trata de un �rea de trabajo enfocada a todos los tipos de usuarios. Se 
	caracterizan por ser aplicaciones de bajo coste, ser f�ciles de entender,
	tener gran fiabilidad, atractivos para la venta y no requieren entrenamiento.


3. __Factores humanos__
El ser humano es limitado en factores como el tiempo de concentraci�n, percepci�n
visual, memorizar acciones...

�stos factores hay que tenerlos en cuenta a la hora de dise�ar nuestro proyecto. 
Para ello el programador debe ser capaz de usar una serie de mecanismos que los
entornos visuales ponen a su disposici�n para evitar ese rechazo.
Factores auditivos como peque�os sonidos.
Factores t�ctiles como el manejo del rat�n, teclado o manejo de pantallas t�ctiles 
pueden hacer que los usuarios no sufran cansancio .

Ser� necesario que el programador encuentre el punto en que los factores humanos 
sean tratados de tal forma que se evite que los usuarios se cansen de nuestra 
aplicacion sin abusar de sus contenidos.


PRINCIPALES CRITERIOS PARA EL DISE�O DE INTERFACES
--------------------------------------------------
Una aplicaci�n et� basada generalmente en 3 categor�as o vistas que el usuario
va a trabajar. Cada una de ellas tiene unos criterios de desarrollo diferentes.
Estas vistas son:
1. Interacci�n general de nuestro proyecto
2. Interacci�n de entrada de datos
3. Interacci�n de salida de datos
