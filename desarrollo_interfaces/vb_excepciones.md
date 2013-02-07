EXCEPCIONES
===========

El objeto Err
-------------

Es un objeto especial de Visual Studio que permite de forma detallada poder informar
al usuario de cuál ha sido el error producido, evitando mensajes de error absurdos.

El objeto Err tiene una serie de propiedades:

* __Number__: Una forma de controlar las excepciones es mediante un número entero,
es decir, cada excepción tiene un número entero.
* __Description__: Muestra una descripción detallada, en castellano del error.
* __Clear__: Borra los valores del objeto ERR.
* __Raise(byval num as integer)__: Provoca el error

Tratamiento avanzado de errores.
-------------------------------

	Try
		Err.raise(6)
	catch when err.number = 1
	catch when err.number = 6
	catch when err.number = 666
	end try

Existe una forma más profesional de tratamiento de excepciones que es tratando
el nombre de la excepción. Para ello se usa la sintáxis que aparece por defecto
al escribir Try.

	try
	
	catch ex as exception

	end try

Los atributos importantes de la clase exception son:

* __Message__
* __Source__
