INTRODUCCIÓN A VISUAL STUDIO.NET
================================
Los lenguajes de programación evolucionan. la POO gana la partida. Surgen en el
mercado herramientas que permiten esos procedimientos. Se tiende a programar al
modo Windows.

Todas las herramientas que aparecen van enfocadas a tres aspectos del mundo de
la programación:
1. Manejo de bases de datos
2. Manejo y diseño web
3. Manejo y diseño de telefonía móvil

MICROSOFT
---------
Aporta al mercado una plataforma de programación (.NET) que aborda esos tres 
aspectos. 
1. DB (ADO.NET)
2. Web (ASP.NET)
3. Móviles (.NET CF)

ESQUEMA Y DESARROLLO DE EJECUCIÓN
---------------------------------
La plataforma .NET se basa en la utilización de módulos que permiten transformar
nuestro código fuente en código objeto que, almacenado en la memoria, puede ser
ejecutado.

Cada uno de éstos módulos tiene una función específica, que es la siguiente:
1. __MSIL__ Cuando escribimos código, éste no se puede ejecutar sin más, sino que para que
sea válido tiene que ser validado para su compilación. Se denomina MSIL (MS 
Intermediate Language).
2. __JIT__Hace referencia a un motor de compilación denominado JIT (Just In Time)
3. __ASSEMBLY__ Unidad mínima ya compilada que se almacena en la memoria.

Existen elementos intermedios que unen los 3 bloques.
1. __CTS__ _Common Type System_. Tiene como finalidad el control y definición de
todos los datos y operaciones existentes del MSIL. Si el MSIL no tiene errores 
translada el código al compilador. Para poder realizar esta acción existe otro
bloque denominado __CLS__ _Common Language Especification_que tiene como finalidad aportar una serie de normas o
elementos de programación a todos los lenguajes que forman la plataforma .NET
2. __CLR__ _Common Language Runtime_Permite que, una vez compilado el MSIL, sea 
almacenado en la memoria. Además se encarga de preparar dónde se aloja, tipo de
memoria necesaria, liberar objetos erróneos/no utilizados... En definitiva, se
encarga de amoldar el resultado de la compilación en la memoria.
3.
