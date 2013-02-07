Cajas de Diálogo comunes
========================

Las cajas de Diálogo comunes son unas cajas que MS permite usar a los 
programadores poder utilizar y por tanto ahorrar tiempo en diseño y programación.
Estas cajas vienen vacías en cuanto a características, por lo que bastará con 
darles características.

Se destacan:
* FileDialog: Formada por:
	* OpenFileDialog: Abrir ficheros
	* SaveFileDialog: Guardar
* FontDialog: Cambio de fuente
* ColorDialog: Cambio de color de texto
* PrintDialog: Impresión
* PrintPreviewDialog: Vista previa
* FolderBrowserDialog: Busca una carpeta en el ordenador
* PageSetupDialog.

## OpenFileDialog
Se utiliza para abrir ficheros. Para utilizarla se arrastra a la bandeja de
componentes.

Las principales propiedades de openfiledialog son:
* ShowDialog(): 
Muestra la caja
* Filter:
Indica al usuario con qué tipo de fichero vamos a trabajar.
* FilterIndex: 
Indica el orden entre los elemento que aparecen. Empieza en "1".
* ShowReadOnly:
Aparece o no aparece la casilla de verificación de "solo lectura"
* InitialDirectory:
Directorio en que se posiciona el CommonDialog


## SaveFileDialog
Guarda ficheros.

Principales propiedades:
* CheckFileExists: 
Determina si el archivo existe o no. True si existe, false si no.
* CheckPathExists:
Determina si la ruta existe o no.


## FontDialog
Se usa para cambiar la fuente del texto. Destacan las siguientes propiedades:

* Color: Establece el color de lafuente
* Font: Determina la fuente
* ShowApply: Agrega el botón aplicar
* ShowColor: Agrega la opción de color
* ShowEffects: Añade tachado, subrayado, negrita...


## ColorDialog
Se usa para dar color al texto, como fontdialog pero con propiedades extras. las
principales propiedades son:

* AllowFullOpen: Agrega colores personalizados.
* FullOpen: Lo que hace es mostrar el área de personalizar colores.
* SolidColorOnly: Sólamente muestra colores sólidos.
* Color: Color seleccionado por el usuario en el texto.


## FolderBrowserDialog
Se usa para buscar y crear carpetas. Sus principales propiedades son:

* Description: Se usa para poner un mensaje en el diálogo.
* ShowNewFolderButton: Muestra el botón de crear carpeta.
* SelectedPath: Captura la ruta que hemos seleccionado en la caja de diálogo.


## PrintDialog
Permite generara o usar la caja de diálogo de impresión. Las propiedades principales
son las siguientes:

* AllowSelection: Si es true, aparece lo de "pagina desde... hasta"
* AllowSomePath: Habilita o no la opción de
* PrintToFile: Aparece o no la casilla de verificación de imprimir un fichero.


## PrintPreviewDialog
Muestra una vista previa de lo que se quiere imprimir.
