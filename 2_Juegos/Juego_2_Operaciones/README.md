# Juegos Matemáticos
En este apartado vamos a hacer uso de los aprendido hasta ahora para crear varios juegos matemáticos.

# Velocidad de operaciones con interrogantes
Parecido al primer juego de las sumas, pero con ligeras mejoras.
Ahora el usuario tendrá que encontrar el número escondido, el cual podría ser cualquiera de los operandos, la operación o incluso el resultado de la operación.

Por ejemplo:
> 4 + ? = 9
>
> 4 + 5 = 9
>
> ? * 4 = 36
>
> 9 * 4 = 36
>
> 5 - 1 = ?
>
> 5 - 1 = 4

Las operaciones serán de forma aleatoria es posible que salgan las siguientes operaciones: la suma, la resta, la multiplicación y la división. Para ello podremos generar un número aleatorio y considerar que según el número podrá ser una u otra operación.

Por ejemplo

| Numero | Operación |
| ------------- | ------------- |
| 0 | + |
| 1 | - |
| 2 | * |
| 3 | / |

Nuevamente los operandos se calculan de forma aleatorio esto es posible a través de la Clase ```Random```

```csharp
	Random generadorNumeros = new Random();
	int numeroAleatorio = generadorNumeros.Next(0, 100); //0 el número más pequeño y 100 el más grande
```

Mientras que el número más pequeño será cero, el juego irá aumentando la dificultad en base a los aciertos, se irá guardando la cantidad de aciertos.
En caso de superar el número de aciertos de un nivel la dificultad se aumenta en base a la tabla anexa.

| Aciertos | Número máximo |
| ------------- | ------------- |
| 0 - 10 | 10 |
| 11 - 19 | 15 |
| 20 - 29 | 20 |
| 30 - 39 | 30 |

Una vez cometido un error, se motrará la cantidad de aciertos

# Extras
* Evitar que si el usuario pulsa enter vacio o sin números el juego se rompa.
* Permitir al usuario elegir un número de vidas al ejecutar el juego: al iniciar el programa se le pregunta por el número de vidas que desea tener y permite al usuario tener ese número de errores antes de morir.
* A través de una función que permita seguir escalando de niveles/dificultad sin tener que definir uno a uno cada nivel (subiendo 5 unidades el número mayor posible).

