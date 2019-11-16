# Juegos Matemáticos
En este apartado vamos a hacer uso de los aprendido hasta ahora para crear varios juegos matemáticos.
## Sumas
En este juego el usuario debe responder sumas, lo más rápido posible.

## Operaciones
En este juego las operaciones matemáticas van cambiando así como el número a descubrir.

## Seguridad cibernética
Este hacker necesita habilidad mental para descrifrar la clave y escapar con la información sin ser detectado.


# Código útil para realizar los programas.

## Números aleatorios

Para calcular un número aleatorio haremos uso de la clase ```Random()```

```csharp
	Random generadorNumeros = new Random();
	int numeroAleatorio = generadorNumeros.Next(0, 100); //0 el número más pequeño y 100 el más grande
```

## Tiempo que ha pasado dentro del programa

Podrías querer añadir en alguno de estos juegos la posibilidad de calcular el tiempo necesario para hacer las operaciones o superar el hackeo.
```csharp
	using System.Diagnostics;

	//...

	//Creo un cronómetro
	Stopwatch stopWatch = new Stopwatch();
	//Pongo la cuenta
	stopWatch.Start();
	//Empieza a responder números
	while(jugar == true)
	{
		//mostrar juego
	}
	//Cuando ha fallado paro el tiempo
	stopWatch.Stop();
	// Mostrar mensaje de que has fallado...
	elapsed_time = stopWatch.ElapsedMilliseconds;
	Console.WriteLine("Tiempo de juego " + elapsed_time);
```

Puedes ver un [ejemplo](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.elapsed?view=netframework-4.8#examples) de como mostrar segundos o minutos en ese enlace.


## Cambiar colores de la consola

En el siguiente ejemplo puedes ver como cambiar el color de la consola para 

```csharp
using System;

class Program
{
    static void Main()
    {
        //
        // Write one green line.
        //
        WriteFullLine("This line is green.");
        Console.WriteLine();
        //
        // Write another green line.
        //
        WriteFullLine("This line is also green.");
        Console.WriteLine();
    }

    static void WriteFullLine(string value)
    {
        //
        // This method writes an entire line to the console with the string.
        //
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); // <-- see note
        //
        // Reset the color.
        //
        Console.ResetColor();
    }
}
```