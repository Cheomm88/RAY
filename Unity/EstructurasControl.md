# Estructuras de control
Un programa se ejecuta línea a línea, de manera secuencial. Esto es así hasta llegar al final de código que se está ejecutando. Este avance lineal se altera cuando se llega a una estructura de control. Se trata de un mecanismo que el hace que el programa pueda ir por un camino y otro dependendiendo de ciertas condiciones.

## Comparaciones

Antes de empezar a trabajar con las estructuras de control, es importante conocer las operaciones de comparación ya que son importantes para establecer las condiciones que determinarán la ejecución de nuestros programas.

Una comparación constará de dos expresiones separadas por un Operador, estos son los operadores de comparación que utilizaremos. 

 | Operador | Descripción |
 | ------------- | ------------- |
 | == | Ambas expresiones (izquierda y derecha) deben dar el mismo resultado |
 | != | El resultado de las expresiones es diferente |
 | < | El resultado de la expresión de la izquierda debe ser menor que el de la derecha |
 | > | El resultado de la expresión de la izquierda debe ser mayor que el de la derecha |
 | <= | El resultado de la expresión de la izquierda debe ser menor o igual que el de la derecha |
 | >= | El resultado de la expresión de la izquierda debe ser mayor o igual que el de la derecha |

El signo de exclamación ```!``` es utilizado para negar los valores booleanos, por lo que si lo ponemos delante de una expresión booleana lo convierte en lo cotrario. Algo que sea verdadero al ponerle ! delante será falso, y viceversa.

> **OJO** :  un error común es utilizar ```=``` en una comparación, esto no va a comparar los valores sino igualarlo. Para comprobar que dos valores son iguales usaremos ```==```

Las comparaciones rara vez las encontrarás sueltas por el código, en el único caso que podrás verlas es para asignar a un booleano un valor, puesto que una comparación dará un valor verdadero o falso.

```csharp
//El valor de alive será verdadero cuando lifes sea MAYOR que cero.
bool alive = { lifes > 0 };
```

Para crear condiciones más complejas podremos combinar condiciones mediante los operadores lógicos And y Or. A la izquierda y a la derecha del operador, deben situarse expresiones que den como resultado un valor booleano. Si se combinan varios operadores lógicos, se pueden utilizar parentesis.


| Nombre | Operador | Descripción |
| ------------- | ------------- |  -------------  |
| AND | `&&` | Ambas expresiones (izquierda y derecha) deben ser verdadero |
| OR | ![OR](https://raw.githubusercontent.com/Cheomm88/RAY/master/Unity/images/or.png) | Es verdadero si una delas dos expresiones es verdadera |


## Condiciones

A través de una condición se ejecutará el bloque de código que le siga, en un modo genérico sería algo como:


```csharp
	//Código antes de la condición
	if(condiciones)
	{
		//Código cuando la condición se cumple
	}

	//Código después de la condición
```
Ahora veremos un ejemplo en el que simula un ataque contra un enemigo. 

```csharp

	void Start()
	{
			// Datos inicializados
			float ataqueBase = 6f;
			float bonus = 1.6f;
			float ataqueCombo = (ataqueBase + bonus) * 1.75f; 
			float saludEnemigo = 13.2f;

			//Cuando la condición de eliminar al enemigo se ejecutará el código dentro del bloque/llaves
			if(ataqueCombo > saludEnemigo)
			{
				saludEnemigo = 0.0f;
				Debug.Log("Enemigo derrotado");
			}

			//Independientemente del IF esta parte se ejecutará
			Debug.Log("Fin de ejecución");
	}
```

Después del if podemos añadir un bloque ```else``` se ejecutaría cuando la condición no se cumpla.


```csharp

	void Start()
	{
			// Datos inicializados
			float ataqueBase = 6f;
			float bonus = 1.6f;
			float ataqueCombo = (ataqueBase + bonus) * 1.75f; 
			float saludEnemigo = 13.2f;

			//Cuando la condición de eliminar al enemigo se ejecutará el código dentro del bloque/llaves
			if(ataqueCombo > saludEnemigo)
			{
				saludEnemigo = 0.0f;
				Debug.Log("Enemigo derrotado");
			}
			else
			{
				//Esto se ejecuta cuando la condición superior no se cumple.
				saludEnemigo -= ataqueCombo;
				Debug.Log("El enemigo ha recibido " + ataqueCombo + " de daño");
			}

			//Independientemente del IF esta parte se ejecutará
			Debug.Log("Fin de ejecución");
	}
```
Por último en los else podemos añadir un if generando ```else if (condiciones)```


```csharp

	void Start()
	{
			// Datos inicializados
			float ataqueBase = 6f;
			float bonus = 1.6f;
			float saludEnemigo = 13.2f;

			//Cuando la condición de eliminar al enemigo se ejecutará el código dentro del bloque/llaves
			if(ataqueBase > saludEnemigo)
			{
				saludEnemigo = 0.0f;
				Debug.Log("Enemigo derrotado");
			}
			else if((ataqueBase + bonus) > saludEnemigo)
			{
				saludEnemigo = 0.0f;
				Debug.Log("Enemigo derrotado utilizando un ataque con bonus");
			}
			else
			{
				//Esto se ejecuta cuando ninguna condición superior no se cumple.
				saludEnemigo -= (ataqueBase + bonus);
				Debug.Log("El enemigo ha recibido " + (ataqueBase + bonus) + " de daño.");
			}
			//Independientemente del IF esta parte se ejecutará
			Debug.Log("Fin de ejecución");
	}
```
> Importante
- Solo el bloque ```if``` es imprescindible. Además siempre será el primero.
- Pueden haber tantos bloques ```else if (condiciones)``` como necesites. (No es obligatorio utilizarlo siempre)
- El bloque  ```else``` siempre será el último y no lleva condición. (Nuevamente no es obligatorio.)
- Recuerda que solo se ejecutará uno de los bloques. Es decir, desde que una de las condiciones se cumplan el resto no se ejecutarán.

>Nota
> Pueden existir más instrucciones condicionales dentro de un if u otra estructura de control

Puedes ver más ejemplos en la [web oficial de Unity](https://learn.unity.com/tutorial/if-statements-1?uv=2019.3&projectId=5dc4a877edbc2a00205e1124)

## Bucles

Es una secuencia que ejecuta repetidas veces un bloque de código, hasta que la condición asignada a dicho bucle deja de cumplirse. Puedes ver más ejemplos en la [web oficial de Unity](https://learn.unity.com/tutorial/bucles-xu?language=es&projectId=5dc4a877edbc2a00205e1124#)

### Bucle while

Repite un código hasta que se cumple una condición. Por ejemplo

```csharp

	int vida = 25;
	int ataqueRecibido = 5;
	while(vida > 0)
	{
		Debug.Log("Recibe un ataque que resta  " + ataqueRecibido + " vida ");
		vida -= ataqueRecibido;
	}

	Debug.Log("Vida agotada, personaje ha muerto");

```

Otra versión de este bucle es el ```do while``` el funcionamiento es similar, sólo que su condición se comprueba tras una primera ejecución del código del bloque. Es decir, siempre se ejecutará una vez.

```csharp
	int vida = 25;
	int ataqueRecibido = 5;
	do
	{
		Debug.Log("Recibe un ataque que resta  " + ataqueRecibido + " vida ");
		vida -= ataqueRecibido;
	}while(vida > 0)

	Debug.Log("Vida agotada, personaje ha muerto");
```

Encontramos una serie de pautas reconocibles para cualquier bucle que veamos en un futuro:
- Existen una condiciones iniciales. 
- La condición de repetición del bucle implica observar cambios entre esas condiciones iniciales: por ejemplo, comprobar si la variables ha superado un límite.
- Dentro del bucle se pueden modificar variables y por tanto las condiciones para salir del mismo. Pudiendo incrementar o decrementar valores.

En el bucle ```for``` encontraremos todas estas características en una sola línea

### Bucle for

Utilizado generalmente para recorrer arrays o repetir operaciones tantas veces como se quiera.

```csharp
	
	//Empieza en Cero podría empezar en el número que quieras y acabar en el que tú quieras, en este caso va del 0 al 4 (el cinco no se incluye puesto que es menor estricto)...
	for(int i=0;i<5;i++) { 
	Console.WriteLine("Estoy repitiendo esto " + i + " veces");
	}
```

Como puedes observar tras la palabra for, hay tres partes separadas por un punto y coma:
- La primera es una instrucción que se ejecuta una sola vez, justo antes de iniciar el bucle.
- La siguiente es la condición que se debe cumplir para que el bucle se pare.
- La tercera parte es la instrucción que se ejecuta al final de cada repetición. Al ser una instrucción realmente podríamos poner "cualquier cosa" por ejemplo ```vida += 3```


## Arrays
Son colecciones de elementos iguales, con acceso posicional. Estos elementos pueden ser números, textos, o incluso datos definidos por el desarrollador.

> La primera posición de un array siempre será el 0.

```csharp
	//Crea un array llamado arrayInt con 3 elementos.
	string[] equipos = new string[3];
	//En la primera posición (0) almaceno CD Tenerife
	equipo[0] = "CD Tenerife";
	equipo[1] = "Atlético de Madrid";
	equipo[2] = "CB Canarias";

	// Otro modo de rellenarlo
	string[] equipos2 = new string[] {"CD Tenerife", "Atlético de Madrid", "CB Canarias"};

	//Podría cambiar el valor de un equipo de la siguiente manera
	//Primero va la variable que quiero acceder, luego va la posición dentro del array "[2]" y finalmente hago una asignación.
	equipos2[2] = "UD Las Palmas";

	//Para mostrar, acceder, modificar... todos los elementos lo más habitual es utilizar un bucle for

	for(int i = 0; i < equipo.Lenght;i++)
	{
		Debug.Log("Equipo [" + i + "] = " + equipo[i]);
	}

```

## Funciones
Una función es un bloque de código que se puede llamar desde otros lugares del programa. En Unity al crear un Script encontramos dos funciones `Start` y `Update`. Unity se encarga de realizar las llamadas a dichas funciones. Pero tu puedes crear nuevas funciones propias o implementar otras que Unity tiene preparadas para tí como detectar colisiones.

Vamos a crear una función de ejemplo

```csharp

	//Función creada por Unity
	void Start()
	{
		//LLamo a mi función
		HolaMundo();
		//...pasan más cosas...
		//...
		//...
		//...
		//Lamo de nuevo
		HolaMundo();
	}

	//Mi función

	void HolaMundo()
	{

		Debug.Log("Hola Mundo");

	}

```

Dentro del script es indiferente donde están creadas las funciones, lo que importa es cuando son llamadas. A la hora de crearla encontramos
- La palabra void, que indica que la función no devuelve ningún resultado.
- El nombre de la función `HolaMundo`. Debemos mantener ciertas [reglas a la hora de elegir nombre](https://github.com/Cheomm88/unity-clean-code/blob/master/README.md#methods)
- Los paréntesis están vacíos. Esto implica que la función no tiene parámetros, pero siempre debemos poner dichos paréntesis.
- Las llaves indican el inicio y el final de nuestra función.
- Entre las llaves encontramos el código que se ejecutará al ser llamada la función en este caso simplemente mostrará en el Log un texto que diga "Hola Mundo"

Las funciones pueden recibir parámetros como es el caso de `Debug.Log("Hola Mundo")` donde vemos que ponemos el texto que va a ser mostrado. En nuestro ejemplo vamos a calcular la velocidad, para ello es importante recordar que velocidad = espacio recorrido / tiempo.

Necesitamos la información de espacio recorrido y tiempo, estos serán los parámetros y nuestra función además devolverá la velocidad.

```csharp

	//Función creada por Unity
	float CalcularVelocidad(float espacioRecorrido, float tiempoNecesario)
	{
		float velocidad = espacioRecorrido / tiempoNecesario;
		return velocidad;
	}

```

En esta ocasión podemos observar que:
- La función devuelve un valor por lo que no es void, así que se pone el tipo de dato que devuelve antes que el nombre en este caso es `float`.
- Tras el nombre dentro de los paréntesis encontramos los parámetros estos pueden ser de cualquier tipo de dato, en nuestro ejemplo son dos floats por lo que pone float delante de cada uno y van separados por una coma.
- La función al no ser void, **siempre** debe devolver un dato del tipo que le hemos indicado delante del nombre en este caso `float`. Para que devuelva un valor ponemos `return` y el dato que debe devolver.

Para utilizar nuestra función podemos hacerlo ahora en el `Start`
```csharp

	void Start()
	{

		//Almaceno el valor y lo muestro
		float velocidad = CalcularVelocidad(100, 9.4f);
		Debug.Log("La velocidad es de " + velocidad + "m/s");

		//También puedo usar el valor directamente
		Debug.Log("La velocidad es de " + CalcularVelocidad(100, 9.4f) + "m/s");

		//O usarlo para otros fines por ejemplo calcular la media de velocidad de dos tiempos en un circuito
		float mediaVelocidad = (CalcularVelocidad(100, 9.8f) + CalcularVelocidad(100, 9.2f)) / 2.0f;
		Debug.Log("La velocidad media es de " + mediaVelocidad + "m/s");


	}
	//Función creada por Unity
	float CalcularVelocidad(float espacioRecorrido, float tiempoNecesario)
	{
		float velocidad = espacioRecorrido / tiempoNecesario;
		return velocidad;
	}

```
