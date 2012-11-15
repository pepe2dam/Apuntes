FICHEROS
========

Para poder utilizar ficheros de cualquier organización en VB es necesario usar
una serie de clases de las que no disponemos por defecto. Para usarlas es necesario
importar el espacio de nombres:

	Imports System.io

Hay tres operaciones a tener en cuenta al trabajar con ficheros. Abrir, leer, escribir.+


FileStream
----------
Permite dar las características al fichero para leer y/o escribir en él. La sintáxis
es la siguiente.

	Dim fich As New FileStream("path", modoDeApertura, modoDeAcceso, compartir, tamañoDeBuffer, sincronización)

Donde.
* __Nombre__: path del archivo (String).
* __ModoDeApertura__: Permite indicar de qué modo vamos a abrir el fichero. Para ello
Se usa la clase FileMode.ModoDeApertura.
	* FileMode.Append: Permite añadir datos al final del fichero. Si no existe se crea.
	* FileMode.Create: Crea un fichero nuevo. Si el archivo ya existe, se sobreescribe
	* FileMode.CreateNew: permite crear un archivo y, si existe, se produce error
	* FileMode.Open: Abre un fichero existente.
	* FileMode.OpenOrCreate: Abre un fichero existente, si no existe lo crea
	* FileMode.Truncate: Abre un fichero y, una vez abierto, verifica que tenga contenido
* __modoDeAcceso__: consiste en determinar qué se quiere hacer con ese fichero.
Se usa el método FileAccess.
	* FileAccess.Read
	* FileAccess.Write
	* FileAccess.ReadWrite
* __Compartir__: Significa que se puede usar en diferentes "Assambly". Se usa la clase
_FileShare_
	* FileShare.Inheritable
	* FileShare.None
	* FileShare.Read
	* FileShare.Write
	* FileShare.ReadWrite
* __TamañoDeBuffer__: Tamaño que se reserva de buffer.
* __Sincronización__: Especifica si va a haber comunicación síncrona o asíncrona entre
dos ordenadores. Por defecto es síncrona. Para decirle que es asíncrona se escribe
"useasync"


LEER FICHERO
------------
Para poder leer de un fichero, existe la superclase TextReader, de la que heredan
otras dos. A la hora de leer de un fichero podemos leer de 2 formas: 

### Tratando los caracteres como bytes: StreamReader
Implica tratar los caracteres a modo de flujo de bytes. La sintáxis sería la siguiente.

	Dim sr As New StreamReader(new FileStream("path",...))

StreamReader proporciona una serie de métodos que permiten trabajar con el texto.
Son los siguientes:
* Close()    :: Cierra el fichero
* Peek()     :: Permite tratar el fichero a modo de EOF.
* Read()     :: Lee el siguiente caracter del flujo
* ReadLine() :: Lee hasta EOL
* ReadToEnd():: Lee hasta EOF

### Tratando los caracteres como texto: StringReader


