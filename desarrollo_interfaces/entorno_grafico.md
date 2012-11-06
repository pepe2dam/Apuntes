ENTORNO GRÁFICO
===============
Propiedades específicas del Form:
---------------------------------

+ FormBorderStyle: Tipo de borde para el formulario.
+ StartPosition: Determina la posición del formulario cuando aparece por primera
vez.
+ Minimize/Minimize Box: Determina si un fomrulario tiene cuadros para maximizar
o minimizar la aplicación.
+ BackColor: Color de fondo.
+ ForeColor: Color de las letras.
+ ShowInTaskBar: Determina si el formulario aparece en la barra de tareas de 
Windows.
+ Icon: Cambia el Icono del programa.
+ WindowState: Determina el estado visual inicial del formulario.


###Funciones de conversión:

+ Val: Convierte de cadena a número (Val [textbox1.text).
+ Str: Convierte de número a cadena.

Validación:
-----------

Hay dos opciones:

+ Try Catch

+ Isnumeric / Not Isnumeric

Esto sirve para validar las opciones.

En el código:

+ BackColor: Poner el fondo del textbox del color que quier quieras.

+ ForeColor: Poner la fuente del textbox del color que quieras.

Cuadros de diálogo:
-------------------

Entendemos por cuadro de diálogo a la utilización de unos formularios, que vienen 
definidos, y que personalizamos. Se utilizan para ponernos en comunicación con 
el usuario. Podemos destacar tres formas de cajas de cuadro de diálogo:

+ Método Show.

+ Función MsgBox.

+ Función ImputBox.

Clase MessageBox: Permite llamar a un cuadro de diálogo, utilizando el método
show, permite llamar a la caja de diálogo y mediante su sintaxis poder personalizarla.
La sintaxis básica es:
	MessageBox.Show("Texto contenido","Texto barra título")
Por defecto viene el botón de Aceptar, pero el método show tiene una serie de 
enumeraciones, que son:

+ MessageBoxButton -> Se utiliza para indicar que botones quiero que aparezcan 
  en el cuadro de diálogo. 
+ MessageBoxIcon: Para poner icono a la caja.
+ MessageBoxDefaultButton: Indica que boton va a tener el foco.
+ MessageBoxOption: Se utiliza para alinear el texto.
Ya no se suele usar, pero se puede encontrar escrito en documentaciones.

	Function MsgBox: Es una función que devuelve un valor entero y su sintaxis es:
		MsgBox("Texto",[Enumeraciones],"BarraTitulo")
	Para personalizar el cuado de dialogo se utiliza la enumeración. Ejemplo:

	Private Sub boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton.Click
        Dim a As Integer
        a = MsgBox("¿Desea Salir?", 4420, "Confirmación.")
        If a = 6 Then
            MsgBox("Ha pulsado Sí.")
        ElseIf a = 7 Then
            MsgBox("Ha pulsado No.")
        End If
    End Sub

Funcion ImputBox: Es una función que devuelve un valor de tipo cadena (String), 
que se utiliza para solicitar al usuario algún tipo de información escrita. 
La sintaxis es:

	InputBox("Pregunta","Texto barra titulo")

Ejemplo:

	Public Class Form1
   		Dim a As String
    	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        	a = InputBox("¿Que desea?", "Ejemplo", "- Escribe aquí -")
    	End Sub

    	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        	MsgBox(a, 0, "Ejemplo")
    	End Sub
	End Class


VALIDACIÓN DE FORMULARIOS
=========================
Entendemos por validar, la acción que evita que un campo se quede sin rellenar o
que un dato esté mal escrito dependiendo del tipo de dato deseado. Validar no es
controlar datos indeseados. Visual Basic tiene varios mecanismos para validar, 
generalmente aquellos objetos destinados a introducir datos, que vamos a reunir
en tres grupos:
1. Cajas de texto
2. Input Box
3. Masked Textbox

El primer tipo de validación es mediante eventos. Se trata de una validación interna
que se basa en los eventos Validated y Validating. El primero ocurre cuando el 
objeto cambia de foco, mientras que el segundo ocurre cuando el objeto aún tiene 
el foco. CausesValidation debe estar a TRUE.

Existe una forma más completa de validación, que se basa en el uso de la función
GetChar() con el evento TextChanged.

La última forma de validar es usando MaskedTextBox. Éste es un objeto especial 
que mejora el TextBox. Sus propiedades principales son:
* mask. Especifica las entradads que el usuario desea y especifica. Existen 2 formas
de hacerlo, de forma predeterminada y de forma personalizada, donde usaremos
0 para numeros y ? para cadenas.
* PasswordChar


### Ejercicio (Para el lunes)
Juego del ahorcado, de encontrar un número que decide la máquina. 
Tiene que tener lo siguiente:

Randomize() // limpia el buffer de aleatorios
numero secreto = int(Rnd * 10) + 1


* Permitir jugar 1 ó 2 jugadores
* Como consiste en adivinar un numero entre un rango, cada vez que se produzca 
un error se contabilizará de forma gráfica.
