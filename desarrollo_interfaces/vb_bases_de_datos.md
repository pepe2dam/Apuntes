Bases de datos. El modelo ADO.NET
=================================

## Introducción

A lo largo de los años, MS ha desarrollado una serie de herramientas con la
intención de gestionar las bases de datos. El objetivo de MS no era el cómo sino
el de buscar una conexión entre una aplicación gestionada por el usuario y un
origen de datos.

En 1993 aparece la 1ª versión de Visual Basic(VB1) que permitía la conexión a
bases de datos de una forma muy elemental. VB2 y VB3 incorporan un modelo de 
organización y gestión de bases de datos denominao _DAO( Data Access Object)_.
Este modelo trabaja exclusivamente con las bases de datos Access e incorpora lo
que se conoce como motor de bases de datos denominado _JET_.

Con VB4, aparece un nuevo concepto denominado _VBSQL_, pensado para servidores.

En 1996 aparece otro método con una arquitectura especial, denominada _.COM_, de
Microsoft, que permite gestionar las bases de datos, no sólo Access sino otros
modelos. Se denomina OLEDB.

Con VB6 (1998) con la intención de sacar al mercado un lenguaje de programación
potente, se lanza al mercado ADO (ActiveX Data Object) que pretende se la
solución a la pluralidad de bases de datos existentes en el mercado. Su principal
característica es que está orientado a objetos. Es compatible con OLEDB y se basa
en el uso del objeto RecordSet. El modelo ADO fue muy aceptado en el mundo de la
programación hasta nuestros dias.

En 2002, dado el éxito del modelo ADO, MS pone en escena una nueva versión de
que, junto al desarrollo de aplicaciones, pone al servicio de los programadores
la __plataforma .NET__.


Características de ADO.NET
--------------------------

### 1. Conexión no contínua.
No existe una conexión constante y directa con el origne de datos sino que sólo
se ejecuta la conexión cuando se necesita.

### 2. Trabajo con copias
ADO.NET no trabaja con los datos originales del origen de datos. Trabaja con
copias almacenadas en la memoria cache, que han sido cogidas del origen de datos
gracias a un SELECT.

### 3. SQL
ADO.NET usa SQL


### 4. Uso de XML
Usa ficheros XMl para implementar los servicios de manipulación de datos. Esto
permite que esos XML sean aprovechados en todos los lenguajes de la __plataforma
.NET__.


Componentes de ADO.NET
----------------------
Nivel de presentación
|-----------------------|
|                       |
|  WinForm              |
|                       |
|                       |
|  WebForm              |
|                       |
|                       |
|-----------------------|
		|
		|
		|
		|
		|
		|
Nivel de negocio
|---------------------------------|
|                                 |
|  Conjunto de datos (DataSet)    |
|  |--------------------------|   |
|  |                          |   |
|  | Almacenado en cache      |   |
|  |                          |   |
|  |--------------------------|   |
|                                 |
|  Adaptador de datos             |
|  |--------------------------|   |
|  |                          |   |
|  |      SQL                 |   |
|  |                          |   |
|  |--------------------------|   |
|                                 |
|  Conexiones                     |
|  |--------------------------|   |
|  |                          |   |
|  | Permite selecicionar el  |   |
|  | Proveedor de DB          |   |
|  |                          |   |
|  |--------------------------|   |
|                                 |
|---------------------------------|
		|
		|
		|
		|
		|
		|
		|
Nivel de Datos
|-----------------------|
|                       |
|  Bases de datos       |
|                       |
|-----------------------|


para poder manipular una DB es necesario tener en cuenta:

## Conjunto de datos:
Es un trozo de la memoria cache donde se guardan los datos que se necesitan
cogidos de la DB. Pueden existir varios conjuntos de datos y todos deben
pertenecer a la clase DataSet.

## Adaptador de datos:
Variable que va a contener la instruccion SQL que va a permitir cojer los datos
deseados del origen de datos y meterlos en el origen de datos. Existen tantos
adaptadores como bases de datos se deseen utilizar, pudiendoi destacar los
siguientes:

### OledbDataAdapter
Se trata de un adaptador que pertenece al proveedor OLEDB. Está pensado
exclusivamente para Access.

### SQLDataAdapter
Se trata de un adaptador cuyo proveedor de datos es el SQLServer. Introducido en
la version 7.

### OdbcDataAdapter
Open Database Connectivity

### OracleDataAdapter
Oracle


## Conexión de datos:
Una conexión es una órden que permite identificar quién es el proveedor de datos
del origen de datos, además de indicar el servidor donde se encuentra el origen
de datos, si es necesario.

Podemos destacar los siguientes tipos de conexiones:
* OleDbConnection. Access
* SqlConnection. Sql Server
* OdbConnection. OpenDatabse
* OracleConnection. Oracle.

Para poder trabajar con cualquier proveedor de bases de datos será por tanto
necesario, porgramar cada uno de estos elementos, siendo necesario realizar los
siguientes pasos.

### Importar las bibliotecas necesarias.
Será necesario indicar al principio de cada formulario que se quiera usar el
origen de datos lo siguiente:
* OleDb: 


	Imports System.Data
	Imports System.Data.OleDb

Al importar estas bibliotecas, existe la posibilidad de poder trabajar con todos
los elementos necesarios.

* SqlServer:


	Imports System.Data
	Imports System.Data.SqlClient


### Conexiones
Establece una conexion a una base de datos indicando el proveedor. Conviene
hacerlo a nivel global del formulario o del proyecto, ya que será necesario
realizar una conexión en cada formulario en que se quiera usar una base de datos.

	Public conn as New OleDbConnection( _
	"Provider=MicroSoft.Jet.OleDb.4.0;DataSource=C:\NombreBaseDatos.mdb")

	Public conn as new SQLConnection(
	"DataSource=.\SqlExpress;InitialCatalog=NombreBaseDatos;IntegratedSecurity=true")


### Adaptador
* OleDb:


	Public adaptador as new OleDbDataAdapter("SELECT * FROM TABLA", conn)

* SqlServer: 



	Public adaptador as new SQLDataAdapter("SELECT * FROM TABLA", conn)


### Crear el conjunto de datos.
Consiste en acotar un espacio en la memoria cache donde se guardaran los datos
del adaptador de datos. Para ello se deberá asignarle un nombre de variable.

	Public miDataSet as new DataSet()

Cada dataset tendrá su propio adaptador, y sólo es necesaria una conexión.

## Otros elementos

### Fill
Se utiliza para cargar de datos el DataSet. La sintáxis es la siguiente:

	adaptador.Fill(miDataSet."nombreDeTabla")

## Binding
Se usa para vincular cada uno de los campos de la tabla con objetos del tipo
texto. Relaciona cajas de texto con las variables. Su sintáxis es:

	nombreCajaDeTexto.DataBindings.add("text", variableDataSet, "nombreTabla.Campo")
