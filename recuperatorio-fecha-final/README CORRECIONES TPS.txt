TP 2 correciones:

Modifica el Main. Con el código original no compila. Listar(Taller taller, ETipo tipo) tiene que ser static

----> Corregido el metodo Listar y no se modifica el main.

TP 3 correciones:

1 - Que se pueda editar un pasajero haciendole doble click 
2 - Un pasajero con DNI 12345 no me deja modificarlo 
3 - Al modificar, no me carga los datos actuales del pasajero. Repensar la edición, está floja.
4 - No hay excepciones propias
5 - La opción de Buscar pasajero es rara, porque es el lugar para generar los tickets. Los tickets se
deberían generar en la compra.
6 - El pdf adjunto está incompleto

-----------> 1: Se agrego un data grid. Ahora se puede modificar y eliminar pasajeros con un doble click
	     2: Una de las verificaciones del dni en modificar estaba mal. Se modifico y ahora solo permite ingresar dni con 7 u 8 caracteres.
	     3: Ahora cada vez que se modifica o se elimina un pasajero se actualiza el datagrid
	     4: Se agregaron excepciones propias
	     5: Ahora el ticket se genera cuando se carga un nuevo pasajero (en el tp3 es solo un cartel)
	     6: Se completo el pdf

TP 4 correciones:

1- Script de base de datos incompleto
2- Los test unitarios no compilan, ni existen
3- Al cargar los tickets y no tener conexión a la BD, la cuenta queda en 1 mucho tiempo marcando
como resultado que se cargaron los tickets
4- Repite el connection string varias veces en el código, debería ser único
5- Hay PasajeroDAO pero no hay tabla pasajeros (raro)
6- Al eliminar el ticket este no desaparece de la pantalla

-----------> 1: Se agrego la base de datos que era lo que faltaba
	     2: Ahora compilan y existen los test
	     3: Ahora si no hay conexion a la base o no trae datos carga un mensaje de error sino carga un mensaje comunicando que se pudo traer los datos
	     4:	Ahora es unico
	     5: Se elimino pasajeroDAO del proyecto
             6: Ahora luego de 2 segundos desaparece de la pantalla
