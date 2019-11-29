# Juegos Matemáticos
En este apartado vamos a hacer uso de los aprendido hasta ahora para crear varios juegos matemáticos.

# Velocidad de cálculo de sumas
En este juego de sumas lo que se realizará será mostrar los dos operandos y un igual, el programa queda a la espera de la respuesta del usuario.

Por ejemplo:
> 4 + 5 =

El usuario pulsará 9 y Enter, al ser el resultado correcto de la suma se mostrará el Acierto y la siguiente pregunta matemática
> 4 + 5 = 9
>
> 8 + 4 = 

Los operandos se calculan de forma aleatorio esto es posible a través de la Clase ```Random```

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

Una vez cometido un error, se mostrará la cantidad de aciertos.

# Extras
* Evitar que si el usuario pulsa enter vacio o sin números el juego se rompa.
* Permitir al usuario elegir un número de vidas al ejecutar el juego: al iniciar el programa se le pregunta por el número de vidas que desea tener y permite al usuario tener ese número de errores antes de morir.
* A través de una función que permita seguir escalando de niveles/dificultad sin tener que definir uno a uno cada nivel (subiendo 10 unidades el número mayor posible).
* Mostrar al final de la partida el tiempo jugado.
* Mostrar aciertos en verde y errores en rojo.

