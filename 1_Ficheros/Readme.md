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

Los streams pueden ser de lectura o de escritura, aquí se muestra un ejemplo:

#### Ejemplo de StreamWriter
El StreamWriter es una clase de C#, la cual nos permitirá escribir en ficheros. En caso del fichero existir lo abre y podemos decidir si lo que queremos es sobreeescribir el contenido o simplemente añadir al final del documento una nueva línea.

Al crear el objeto de tipo StreamWriter ```StreamWriter miStreamWriter = new StreamWriter(ficheroParaEscribir, addContenido)``` podemos elegir el nombre del fichero a escribir, así como el modo de escritura que se usará.

Para el modo de escritura se utiliza un dato de tipo ```bool``` el cual puede tener el valor de ```true``` para añadir contenido al final del documento o puede ser ```false``` para así sobreescribir el fichero si ya existe.
```csharp
//Para crear un stream de escritura es necesario hacer uso de StreamWriter
string ficheroParaEscribir = "miFichero.txt";
bool addContenido = true;

//Creamos un stream para crear un fichero (si el fichero no existe lo crea, sino añade o reemplaza el existente)
StreamWriter miStreamWriter = new StreamWriter(ficheroParaEscribir, addContenido); 
// Añade al fichero el texto "Nueva linea de texto"
miStreamWriter.WriteLine("Nueva linea de texto");
//Cerramos el fichero y se guardan los cambios
miStreamWriter.Close();
```
#### Ejemplo de StreamReader

Al igual que StreamWriter, StreamReader es una clase que nos facilitará la vida con el trabajo con ficheros, en este caso es una clase que nos permite leer ficheros y almacenar su contenido en variables.

En este caso el constructor solo necesita el nombre del fichero a leer.

```csharp
//Para iniciar la lectura de un fichero es necesario utilizar una instancia de StreamReader
//para inicializarlo es necesario pasarle un string con el nombre del fichero
string nombreFichero = "miFichero.txt";            
streamReader = new StreamReader(nombreFichero);
//Leemos en un string todo el contenido del fichero
string text = streamReader.ReadToEnd();
Console.WriteLine("\t El texto que contiene el fichero es: \n" + text);
streamReader.Close();
```

### Métodos de Lectura

ReadLine() Al igual que Console.ReadLine(), este método lee una línea completa de un fichero de texto hasta el siguiente Enter.
	string línea = Sr.ReadLine();

ReadToEnd() este método lee la información que hay desde la lectura anterior (que se pudo haber realizado con un ReadLine) hasta el final del archivo, y todo en el mismo string
	string línea = Sr.ReadToEnd();

Read() es capaz de leer un carácter a la vez.

Para leer o escribir un archivo habrá que seguir el proceso descrito más arriba (abrir, trabajar, cerrar).



### Ejemplo 1
En esta aplicación vamos a crear, escribir y leer ficheros de texto.
https://github.com/Cheomm88/RAY/tree/master/1_Ficheros/1_EjemploFicheros

Una vez ejecutado el programa verás que dentro de la carpeta del proyecto se crea la carpeta bin, dentro de ella existen varias carpetas que llevan directamente al programa compilado (exe) y diversos ficheros, entre ellos podrás encontrar el fichero de texto creado por el programa.

Prueba a modificar el fichero con el editor de texto (Bloc de notas) y guardar los cambios tras ello pidéle al programa que muestre el contenido del fichero.

### Ejemplo 2
En el siguiente ejemplo vamos a crear una aplicación que almacene en un fichero de texto registros con información de una persona y su dirección.
https://github.com/Cheomm88/RAY/tree/master/1_Ficheros/2_FicherosRegistros

### Actividad 1
Tras descargar y comprobar el funcionamiento del [Ejemplo 1](https://github.com/Cheomm88/RAY/tree/master/1_Ficheros/1_EjemploFicheros) es necesario realizar un cambio en la aplicación.

Viendo el código encontrarás comentarios que servirán de ayuda para las modificaciones que deben ser realizadas, actualmente el programa se ejecuta de tal manera que [siempre sobreescribe el fichero](https://github.com/Cheomm88/RAY/blob/444b79ef8c4b822f96263597242620cd21dc366a/1_Ficheros/1_EjemploFicheros/EjemploFicheros/Program.cs#L44) se pide en esta actividad hacer los cambios necesarios para:

- Preguntar al usuario el nombre del fichero de texto que se desea crear/leer.
- Trabajar sobre el fichero que el usuario ha indicado.
- Permitir desde el menú una opción para cambiar de fichero.
- Seleccionar el modo de escritura (sobre-escribir el fichero por completo, añadir texto al final del mismo)




### Actividad 2
Modificar el Ejemplo 2 para que:
1 Exista un menu que permita mostrar todos los registros y salir.
2 Modificar la forma de guardar los registros dejando solo los datos y luego para leerlos pasarlos al struct persona (pista cada línea será el dato almacenado que debe ser cargado.)


# Bibliografía

https://studylib.es/doc/7096513/guia%2312--tema--%E2%80%9Carchivos-en-c%23%E2%80%9D.
