ARRAYS DINÁMICOS
================
Los arrays dinámicos se caracterizan en que se puede definir el nombre del array
sin saber exactamente el número de elementos que va a contener.

Para poder trabajar con un array dinámico serán necesarios los siguientes pasos:

1. Definir el array como una variable convencional sin indicar el numero de elementos.

2. Cuando, tras un cálculo sabemos el número de posiciones que se van a necesitar,
allí donde se necesite se indicará utilizando la instrucción Redim 
nombreDelArray(20). Redim modifica la longitud de la tabla, pero no la dimensión,
perdiendo los datos ya existentes.

Si lo que se desea es redimensionar más de una vez un array con Redim y deseamos
no perder los datos existentes, será necesario redimensionar utilizando 
"Redim Preserve nombreDelArray(20)"

Instrucciones: 

* Redim
* Redim Preserve
* Erase. Limpia un array.
* LBound. Permite saber cuáles son los límites de la tabla. Inferior.
* UBound. Permite saber cuáles son los límites de la tabla. Superior.

