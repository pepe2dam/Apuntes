PANEL Y GROUPBOX
----------------
Panel y groupbox son dos herramientas pensadas para organizar la geografía de un
formulario. Son objetos contenedores, es decir, pueden contener otros objetos.

CHECKBOX
--------
Permite seleccionar opciones seleccionando una casilla. La sintáxis par ver si se
ha marcado una casilla de verificación sería:

	CheckBox1.checked  ' True o false

RADIO BUTTON
------------
Se trata de un objeto de selección sí excluyente.


LIST BOX
--------
Se usa generalmente para visualizar datos a modo de lista con la posibilidad a modo
de lista con la posibilidad de poder seleccionarlos (en azul) y operar con ellos.

Tiene una serie de propiedades, donde podemos destacar las siguientes:
* Multicolumns(bool)
* Items. Se usa para añadir elementos a un listbox. Se puede hacer de 2 formas:
	* Añadirlos en modo diseño.
	* Añadirlos mediante programación. ListBox1.items.add("a")
* SelectedItem. Valor del elemento seleccionado
* SelectedIndex. Índice del elemento seleccionado.
* Sorted. Permite, mediante true o false, ordenar por órden alfabético.
* SelectionMode. Permite cambiar el modo de selección de los elementos de una lista

### Otros  de ListBox

* Count. Permite conocer el número total de elementos de un listbox. su sintaxis
es: ListBox1.count

Para __introducir__ elementos a un listbox:
	
	listbox.items.add("cadena")
	listbox.items.insert(indice, "valor")

Para __Eliminar__ un elemento de una lista:

	listbox.items.remove(listbox1.selecteditem)
	listbox.items.removeat(listbox.selectedindex)

Para __Limpiar__ un listbox de elementos:

	listbox.items.clear()

Para __seleccionar__ un elemento:

	listbox.setselected(indice, true/false)


COMBOBOX
--------
Es una herramienta que se usa para seleccionar datos de una lista o permitir que 
el usuario introduzca un valor. Una de las propiedades más importantes de este
elemento es dropdownstyle. Esta propiedad puede tomar varios valores:
* simple. 
Hace que el CB se parezca en apariencia al listbox
* dropdown

* dropdownlist



TOOLTIP
-------
Es una forma de ayuda al usuario. Consiste en insertar en cada uno de los objetos
un mensaje que aparecerá pasado un tiempo desde que el ratón está sobre el objeto.

	autotopdelay

TIMER
-----
Permite insertar un reloj en un formulario. Con ello podemos temporalizar código
o capurar datos como fecha y hora

PICTUREBOX
----------
Permite insertar una imagen en el formulario. Acepta los siguientes formatos:
* jpg
* gif
* bmp
* wms

La propiedad para ajustar una imagen es sizemode. Puede tomar 2 valores:
* stretchimage
* zoom


MENUSTRIP
=========
Main menu

Propiedades de los elementos:
* BackColor
* ForeColor
* Image


ContextMenuStrip
================
Es un menú emergente que aparece cuando se pulsa el botón derecho del ratón en un
objeto que, generalmente, es el formulario
