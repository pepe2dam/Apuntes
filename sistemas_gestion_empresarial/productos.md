ALTA DE PRODUCTOS
=================
Antes de dar de alta un producto hemos de introducir datos intermedios. Para tener
una guía, el flujo de trabajo está en:

	Gestion de datos maestros > config prod > config prod

los pasos que tenemos en este flujo son:
## Gestión de almacén y huecos.
Una entidad puede tener uno o varios almacenes propios, que pueden estar separados
geográficamente y que van a servir para guardar los productos comprados a 
proveedores. 

### Almacenes
El por qué de los almacenes tiene un objetivo que OB se encarga de
cumplir. 
	* OB permite control y rotación de productos.
	* Facilidad de inventarios a la hora de conocer qué se tiene en el almacén.
	* Control de stock (mínimo, máximo...)
	* Control de productos obsoletos.
	* Gestionar huecos y ubicaciones de productos.
	* Lotes.
	* Productos peligrosos.
	* Productos pesados.
	* Estado de los productos

### Localización
Se trata de crear una nomenclatura que permita crear espacios huecos que posteriormente
indicaremos al dar de alta un producto. 

### Huecos
cuando damos de alta un hueco es necesario tener en cuenta:
* Cómo está organizado el producto en cuando a su traslado (Palés, bultos...)
* Si los productos se dejan en muelles de descarga, entradas...
* Hay empresas que usan robots para guardar los productos, por lo que el almacén
se hace mediante códigos.
* La caducidad de la mercancía.


## Unidades de medida
Nada...

## Categoría de producto
Permite crear categorías de productos, por lo que permite identificarlos de una 
forma rápida.

## Categoría de impuestos


## UPC/EAN
* __Universal Product code__
Tiene la siguiente forma:
1||12345||12345||1
Consta de 12 dígitos, y tiene la siguiente nomenclatura:
	* el 1º es un dígito de sistema
	* los 5 primeros a la empresa
	* los 5 siguientes se refieren al artículo
	* El último es de control.

* __European Article Number__
1||123412||123412||
Consta de 13 dígitos. Su nomenclatura es la siguiente.
	* los 2 primeros, son el país
	* los 5 siguientes, empresa
	* los 6 siguientes producto
