Eventos de ratón y teclado
==========================
En Windows se puede utilizar tanto el teclado como el ratón para manejar una
aplicación. Para ello, VB.NET incorpora una serie de __eventos de comportamiento__.

## Eventos de ratón
Existen una serie de eventos que hacen que el ratón se comporte de diferentes
formas. Podemos destacar las siguientes:

### MouseDown
Se lanza al pincharse sobre un determinado control. Necesita que se le indique
qué botón del ratón se va a utilizar. 
* Left
* Right
* None
* Middle
* XButton1
* XButton2

### MouseUp
### MouseMove
Sucede el evento en el momento en que el ratón invade el área del objeto.

### MouseWheel
### MouseEnter
Sucede el evento al invadir el área del objeto. (como MouseMove)

### MouseLeave
Se produce el evento cuando se abandona el objeto

### MouseHover 

Éstos son los eventos más importantes.

## Eventos de teclado.
Podemos destacar:
### KeyPress
Escanea el teclado esperando a que se pulse una tecla. para controlar que tecla 
se pulsa se hace usando la propiedad Keychar.

### KeyDown
Este evento consiste en la posibilidad de pulsar una o una combinacion de teclas.
Para poder controlar el que se pulse una tecla, se usa la propiedad keycode.

Para poder combinar más de una tecla será necesario indicar cuáles, aunque generalmente
las combinaciones de teclas se hacen con las teclas de control, alt y shift.

### KeyUp
