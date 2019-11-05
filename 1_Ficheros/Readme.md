# Archivos en C#

## Introducción
Hasta ahora nuestros programas en C# han utilizado registros  y variables en memoria por lo que al cerrar la ejecución o al apagar el equipo la información almacenada se ha perdido y hemos tenido que volver a introducir los datos.
Existen diversas maneras para que la información no se pierda al cerrar la aplicación en esta ocasión vamos a hacer uso de los ficheros de texto.

### Streams
La lectura y escritura en un fichero son hechas a través del concepto genérico stream, más allá de las definiciones técnicas que podamos encontrar nos interesa saber lo siguiente:
•	Si los datos son transferidos desde una fuente externa al programa, se habla de leer el stream.
•	Si los datos son transferidos desde el programa a una fuente externa, se hablará de escribir el stream.
C# nos permite utilizar las clases Reader y Writer para facilitarnos el trabajo con el manejo de ficheros.
A la hora de trabajar con un Fichero es importante seguir una secuencia:
1.	Abrir el fichero.
2.	Trabajar (mientras haya texto leer/escribir información).
3.	Cerrar el fichero.

### Métodos

ReadLine() Al igual que Console.ReadLine(), este método lee una línea completa de un fichero de texto hasta el siguiente Enter.
	string línea = Sr.ReadLine();

ReadToEnd() este método lee la información que hay desde la lectura anterior (que se pudo haber realizado con un ReadLine) hasta el final del archivo, y todo en el mismo string
	string línea = Sr.ReadToEnd();

Read() es capaz de leer un carácter a la vez.

Para leer o escribir un archivo habrá que seguir el proceso descrito más arriba (abrir, trabajar, cerrar).
 
### Ejemplo 1
En esta aplicación vamos a crear, escribir y leer ficheros de texto.
https://github.com/Cheomm88/RAY/tree/master/1_Ficheros/1_EjemploFicheros

### Ejemplo 2
En el siguiente ejemplo vamos a crear una aplicación que almacene en un fichero de texto registros con información de una persona y su dirección.
https://github.com/Cheomm88/RAY/tree/master/1_Ficheros/2_FicherosRegistros

### Actividad 1
Modificar el primer ejemplo para que se pueda decidir entre escribir en el fichero borrando todo el texto anterior o añadiendo el texto al final del fichero.

### Actividad 2
Modificar el Ejemplo 2 para que:
1 Exista un menu que permita mostrar todos los registros y salir.
2 Modificar la forma de guardar los registros dejando solo los datos y luego para leerlos pasarlos al struct persona (pista cada línea será el dato almacenado que debe ser cargado.)


# Bibliografía

https://studylib.es/doc/7096513/guia%2312--tema--%E2%80%9Carchivos-en-c%23%E2%80%9D.
