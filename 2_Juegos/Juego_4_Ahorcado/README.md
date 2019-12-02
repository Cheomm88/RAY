# El ahorcado
En esta actividad vamos a crear el juego del ahorcado, habrá un máximo de intentos por turno. 

El jugador 1 escribe una palabra y el jugador 2 tendrá que acertarla.
Una vez el jugador 2 ha acertado o superado el número de intentos, podrá escribir una palabra para que el jugador 1 la descubra.
El máximo número de intentos fallidos por un jugador será el número de letras de la palabra.


Al salir del juego se muestra el resultado final de turnos ganados por cada usuario.


## Ejemplo de partida

> Turno jugador 1: Escriba la palabra.
>
> PALABRA

Se borra la pantalla

> _ _ _ _ _ _ _ 
>
> Intentos restantes 4
>
> 1 - Resolver
>
> 2 - Letra
>
> 3 - Salir
>
> Escriba su opción
>
> 2
>
> ¿Qué letra?
>
> a


Se borra la pantalla

> _ A _ A _ _ A 
>
> Intentos restantes 4
>
> 1 - Resolver
>
> 2 - Letra
>
> 3 - Salir
>
> Escriba su opción
>
> 1
>
> Escriba su palabra
>
> anaconda
>
> La palabra correcta era 'palabra' y no anaconda.

Se limpia la pantalla

> Turno de jugador 2: Escriba la palabra 
> INTERACTIVO

Se borra la pantalla y vuelve a jugar en este caso el jugador 1 trata de descubrir la palabra.



## Indicaciones/Pistas

* La palabra dada por el jugador se almacena en una variable tipo char[]
* En otro String de la misma longitud ponemos todos los símbolos con _ se puede hacer de la siguiente manera

```csharp
	void Main()
	{
			//Lectura de la palabra
            char[] palabraUser = Console.ReadLine().ToCharArray();
			//Creación de cadena cifrada
            char[] palabraCifrada = new String('_', palabraUser.Length).ToCharArray();
			
			//Suponemos que la primera letra ha sido acertada
			palabraCifrada[0] = palabraUser[0];
		
            Console.WriteLine(palabraCifrada);
	}
```

* Una vez el usuario le da una letra se comprueba en la variable con el texto que esa letra existe, en caso de existir se sustituye el _ por la letra.
* Un char[] se puede recorrer como un array de numeros con un bucle for

```csharp
//Acceso a una letra 
palabraCifrada[i] = 'B';
```

# Extras

* El juego no da errores al introducir texto no experado (gameplay y menús).
* El juego reconoce cuando es una letra o una palabra y ejecuta el resolver palabra o letra en base a eso.
* El juego no diferencia entre mayúsculas y minúsculas.
* Sistema de turnos, al empezar el juego se pregunta el número de jugadores. Y se van turnando los jugadores que tratan de adivinar la palabra.
* Cada jugador sumará puntos al acertar una letra (1 punto) y al resolver la palabra 3 puntos).
* Economía de juego: para usar vocales es necesario tener puntos, una vocal cuesta dos puntos. Al elegir una vocal se reducen dos puntos del jugador.

