# Juegos Matemáticos
En este apartado vamos a hacer uso de los aprendido hasta ahora para crear varios juegos matemáticos.

# Seguridad cibernética
Desarrollar un juego basado en número, en el cuál el jugador deberá descubrir el patrón de números que proteje un servidor con datos muy importantes, así como la encriptación.



Ejemplo de la partida:
> Radio: Tenemos unas pistas sobre el acceso a este sistema.
> El código está formado por tres dígitos.
> La suma de estos tres dígitos da 8
> La multiplicación de los tres dígitos da  16
> Te dejamos el tiempo que necesites, por favor no falles o toda la operación se irá al traste.
> Escribe el primer número
> 2
> Escribe el segundo número
>2
> Escribe el tercer número
>4
> ...
> ...
> Radio: Uff ha estado cerca!! 
> Radio: Bien!! Ya queda menos... Vamos a descargar esos datos...
> Radio: Ups... Están encriptados, esto va a estar más complicado de lo que parecía...

(La historia la puedes modificar como tu quieras, se trata de adivinar los 3 números que hagan que las operaciones funcionen).

El orden de los números de debería afectar puesto que la suma y la multiplicación tienen la propiedad de que el orden de los factores no afecta al resultado final.
Por otro lado podría suceder que un problema tenga varias soluciones es por ello que lo que haremos será comprobar que el resultado de las operaciones es el mismo y no los números. El código sería similar al siguiente
```csharp
	Random generadorNumeros = new Random();
	int a = generadorNumeros.Next(0, 10 + Nivel); 
	int b = generadorNumeros.Next(0, 10 + Nivel); 
	int b = generadorNumeros.Next(0, 10 + Nivel); 
	
	int userA = Convert.ToInt32(Console.ReadLine());
	int userB = Convert.ToInt32(Console.ReadLine());
	int userC = Convert.ToInt32(Console.ReadLine());
	
	if((a + b +c == userA+ userB + userC) && (a + b +c == userA+ userB + userC))
	{
		//Pasar al siguiente nivel....
	}
	else
	{
		//Mostrar mensaje de muerte.
	}
```


Los operandos se calculan de forma aleatorio esto es posible a través de la Clase ```Random```



Mientras que el número más pequeño será cero, el juego irá aumentando la dificultad en base a los aciertos.

A continuación se tiene la tabla del nivel y la dificultad (un nivel será un acertijo) .

| Nivel | Número máximo |
| ------------- | ------------- |
| 0 | 5 |
| 1 | 10 |
| 2 | 15 |
| 3 | 20 |
| 4 | 25 |

* Una vez cometido un error, se mostrará un mensaje de error.
* Cada vez que se acierta se avanza al siguiente nivel donde la historia es libre.
* Puedes crear tantos niveles como quieras y por tanto historia, el mínimo son 4 niveles.


# Extras
* Evitar que si el usuario pulsa enter vacio o sin números el juego se rompa.
* Crear un sistema en el que los niveles se generen de forma aleatoria.
* Tener diferentes mesajes de cierre de la historia/partida seleccionados de forma aleatoria.
* Tener dos historias dentro del juego, se pueden elegir al iniciar la partida. (Por ejemplo CiberHacker y Asalto al banco). Sólo cambian los textos, las reglas del juego son las mismas.
 
