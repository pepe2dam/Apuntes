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



ESCRIBIR FICHERO
----------------
Para guardar se usa la superclase textWritem que permite guardar recorriendo 
secuencialmente todos los caracteres, guardándolos en el fichero.

Tiene dos clases derivadas:
### StreamWriter
Trata los caracteres como bytes y tiene los siguientes métodos:
* StreamWriter.Close
* StreamWriter.Write
* StreamWriter.WriteLine
* StreamWriter.Encoding
* StreamWriter.flush

Su sintáxis es la siguiente:

	dim fich as new filestream(...)
	dim sw as new streamwriter(fich, .., ..)

### StringWriter


FICHEROS SECUENCIALES
=====================
Para abrir un fichero se usa FileOpen. Su sintáxis es:

	FileOpen(nº fichero, path, modo)

* Número: 
Hace referencia al numero de fichero. Admite datos de 1 a 255. .NET permite abrir 
hasta 255 ficheros a la vez.
Puede darse el caso de que no se lleve un control del numero del siguiente fichero
a tratar. Para controlar esta situación existe FreeFile, que asigna un número de
fichero libre.

* Path:
Se usa de modo tradicional, pero teniendo en cuenta que a partir de ahora que el
nombre que se da al ficheo no se va a usar para gestionarlo, sino que se le hará
referencia con el número asignado.

* Modo:
Se usa la clase OpenMode.
	* OpenMode.Append: Añade
	* OpenMode.Input: Lee
	* OpenMode.Output: Escribe
	* OpenMode.Random:
	* OpenMode.Binary:


## Leer
Para leer de un fichero podemos usar 
* LineInput:

	LineInput(numFichero)

* Input: Permite leer una cadena o registro.

	Input(numFich, nombre_de_campo)

## Escribir
* WriteLine. Permite almacenar lineas de texto

	WriteLine(1, "asdf")

* Write. guarda en el fichero que se quiera el nombre de campo que se desee

	Write(numFich, valor)



## Cerrar
FileClose(numFich)


ACCIONES IMPORTANTES FICHEROS
=============================

## EOF
Es el finale de fichero. Permite recorrer secuencialmente el fichero hasta que 
aparezca __EOF__. Para ello será necesario una estructura repetitiva que verifique
si aparece o no. La sintáxis es:

	While Not EOF(numFich)
		acciones
	End While

## KILL
Elimina fichero. La sintaxis es:

	Kill(path)

## FILECOPY

	FileCopy(pathOrigen, pathDestino)



Ficheros con Organización directa, Relativa o Aleatoria:
--------------------------------------------------------

###Ficheros directos con direccionamiento directo:

Para abrir un fichero se utiliza FileOpen, con la siguiente sintaxis:

	FileOpen(
		numfich,
		"ruta/nombre",
		modoapertura[OpenMode.Random-Es unico, ningun otro],
		modoacceso[OpenAcces.Read/Write/ReadWrite],
		nivelcompartir[OpenShare.//],
		longitudregistro-obligatorio[num caract que suman todos los campos en la structure corresp.]
	)

+ Para calcular la longitud de un registro sera necesario indicar la longitud
de la variable utilizaca como instandia a la estructura, haciendose como en el 
ejemplo. OpenMode.Random es obligatorio para decir que es directo.


Ejemplo:

	FileOpen(1,"agenda.txt",OpenMode.Random,OpenAccess.Read, ,len(reg))

+ Siempre hay que cerrar el fichero con _FileClose()_.

_Grabar:_

Para grabar en un fichero directo se utiliza _FilePut()_, cuya sintaxis es:

	FilePut(1[donde],registro[informacion],posicion[posicion de grabacion])

Ejemplo:

	FilePut(1,reg,reg.cod)

	Dim a As Long
	a = Val(TextBox1.Text)
	FilePut(1,reg,a)

_Alternativa:_

Seek: Me coloca a modo de puntero en una posicion concreta del fichero.

	Seek(numfichero,posicion)

Ej:

	Seek(1,51)
	FilePut(1,reg,)

_Leer:_

Se utiliza FileGet. Sintaxis:

	FileGet(numfich,datos,posicion)

Ejemplo:

	FileGet(1,reg,reg.cod)


IMPRESIÓN
=========
Antes de la impresión se requieren operaciones previas. La primera d ellas es
importar una clase:

	Imports System.Drawing.Printing

En segundo lugar, hemos de arrastrar todas las herramientas necesarias para imprimir.
para ello arrastramos a la bandeja de componentes "printdocument". 

Las principales propiedades de printdocument son:
* PrinterSettings
* PageSettings
* PrintPageEvenArgs

Para imprimr

	private sub imprimir()
		addhandler pri
	end sub
