INTRODUCCI�N A VISUAL STUDIO.NET
================================
Los lenguajes de programaci�n evolucionan. la POO gana la partida. Surgen en el
mercado herramientas que permiten esos procedimientos. Se tiende a programar al
modo Windows.

Todas las herramientas que aparecen van enfocadas a tres aspectos del mundo de
la programaci�n:
1. Manejo de bases de datos
2. Manejo y dise�o web
3. Manejo y dise�o de telefon�a m�vil

MICROSOFT
---------
Aporta al mercado una plataforma de programaci�n (.NET) que aborda esos tres 
aspectos. 
1. DB (ADO.NET)
2. Web (ASP.NET)
3. M�viles (.NET CF)

ESQUEMA Y DESARROLLO DE EJECUCI�N
---------------------------------
La plataforma .NET se basa en la utilizaci�n de m�dulos que permiten transformar
nuestro c�digo fuente en c�digo objeto que, almacenado en la memoria, puede ser
ejecutado.

Cada uno de �stos m�dulos tiene una funci�n espec�fica, que es la siguiente:
1. __MSIL__ Cuando escribimos c�digo, �ste no se puede ejecutar sin m�s, sino que para que
sea v�lido tiene que ser validado para su compilaci�n. Se denomina MSIL (MS 
Intermediate Language).
2. __JIT__Hace referencia a un motor de compilaci�n denominado JIT (Just In Time)
3. __ASSEMBLY__ Unidad m�nima ya compilada que se almacena en la memoria.

Existen elementos intermedios que unen los 3 bloques.
1. __CTS__ _Common Type System_. Tiene como finalidad el control y definici�n de
todos los datos y operaciones existentes del MSIL. Si el MSIL no tiene errores 
translada el c�digo al compilador. Para poder realizar esta acci�n existe otro
bloque denominado __CLS__ _Common Language Especification_que tiene como finalidad aportar una serie de normas o
elementos de programaci�n a todos los lenguajes que forman la plataforma .NET
2. __CLR__ _Common Language Runtime_Permite que, una vez compilado el MSIL, sea 
almacenado en la memoria. Adem�s se encarga de preparar d�nde se aloja, tipo de
memoria necesaria, liberar objetos err�neos/no utilizados... En definitiva, se
encarga de amoldar el resultado de la compilaci�n en la memoria.
3.
