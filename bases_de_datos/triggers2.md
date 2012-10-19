# DISPARADORES DE SUSTITUCIÓN
Están asociados a vistas. Se disparan cuando se intenta ejecutar un comando de 
manipulación que afecta a la vista, como es un insert, delete o update.

# DISPARADORES DE SISTEMA
Se disparan cuando ocurre un evento en el sistema, como es un arranque o parada
de la base de datos, entrada o salida de un usuario. También se conoce como dis
paradores de sistema cuando se refieren a creacion, modificacion de tablas

## WHEN
Ésta cláusula, seguida de una condición, restringe la ejecución del trigger al
cumplimiento de la condición. Tiene algunas limitaciones:


## ORDEN DE LOS DISPARADORES
1. BEFORE ... FOR EACH STATEMENT
2. BEFORE ... FOR EACH ROW
3. ACTUALIZACIÓN DE FILA. (Se bloquea la fila hasta que la transaccion se confirme)
4. AFTER ... FOR EACH ROW
5. AFTER ... FOR EACH STATEMENT


# TRIGGER CON MÚLTIPLES EVENTOS

Puede ser disparado por múltiples eventos. En estos casos, para facilitar su 
control, Oracle permite el uso de "predicados condicionales". Estos predicados
son:
### INSERTING
Devuelve TRUE si el evento que disparó el trigger fue un insert.
### DELETING
Devuelve TRUE si el evento que disparó el trigger fue un delete
### UPDATING
Devuelve TRUE si el evento que disparó el trigger fue un update
### UPDATING (nombre_de_columna)
Devuelve TRUE si el evento que disparó el trigger fue una instrucción update y la
columna especificada ha sido actualizada

Formato de trigger con múltiples eventos.

	IF INSERTING THEN
	...
	ELSIF DELETING THEN
	...
	ELSIF UPDATING THEN
	...
	ELSIF UPDATING('nombre_de_columna') THEN
	...
	END IF

Un trigger no puede contener instrucciones que actualizen tablas mutantes.
