# Fundamentos de C#
A la hora de programar encontraremos elementos que no tendrán ningún tipo de valor de cara a la ejecución como son los siguientes:
- Líneas vacías o que contengan solo espacios o tabuladores.
- Espacios y tabuladores al principio o fiunal de las líneas.
- Los comentarios ya sean del tipo ````//``` o ```/* Este es mi comentario*/```.
A pesar de que los espacios y tabulaciones no tengan valor de cara a la ejecución del código, si tienen un valor muy importante a la hora de poder interpretar el código. 

Un programa se encuentra dentro de los bloques de código delimitados por las llaves de apertura ``` { ``` y cierre ``` } ```. Es habitual encontrar bloques de código "anidados", es decir, unos dentro de otros en varios niveles. Para mejorar la legibilidad del cóodigo, el contido se indenta ([ver más](https://github.com/Cheomm88/unity-clean-code#identation)). 

Las instrucciones (órdenes) pueden ocupar una o varias líneas y se terminan con un punto y coma ```;```. También pueden existir varias instrucciones en una misma línea, pero eso es algo que solemos evitar para tener una mejor legibilidad.

Más adelante veremos que existen instrucciones (condiciones, bucles...) que no terminan con un punto y coma, sino que generan un nuevo bloque de código y utilizan las llaves.

## Variables y tipos de datos

Durante el desarrollo de aplicaciones encontraremos información o datos con los que vamos a tener que realizar operaciones. Para cada dato se reserva en memoria espacio y se le pone un nombre. A este espacio de memoria lo denominamos **variable** puesto que su contenido puede ser modificado durante la ejecución del programa. En C# las variables se crean mediante una declaración como la siguiente: 

```csharp
	int monedas;
```

Con esta declaración hemos creado una variable llamada _monedas_. La palabra ```int```, que precede al nombre indica el tipo de dato o variable, en este caso es de tipo entero (**int**eger) y es uno de los muchos que existen predifinidos en C# y Unity. A continuación tenemos una tabla de tipos de datos básicos de C#.

Tipo | Contenido | Valores posibles
bool | Sólo puede tener dos valores verdadero o falso. Un tipo de dato importante para entender como se evalúan las condiciones | true - false
int | Números enteros de 32 bits positivos y negativos | -2.147.483.648 .... -1, 0, +1, +2.147.483.647
long | Números enteros de 64 bits positivos y negativos | -9.223.372.036.854.775.808 .... -1, 0, +1, +9.223.372.036.854.775.807
float | Números con parte decimal. | -3,402823*10^38 , -0.000000268, 200.2991, 3,402823*10^38
double | Similar al float pero con mayor rango de números | Números decimales más "largos"
string | Sirven para almacenar texto, aunque también pueden tener números pero estos no sirven directamente para operar (sumar, restar, comparar...) | "Hola, mundo" "GameOver" "0125"

A la hora de elegir un nombre es adecuado seguir [unas pautas](https://github.com/Cheomm88/unity-clean-code#variables).

Una vez declarada la variable será accesible dento de su ámbito. El ámbito de una variable es el bloque de código (sección entre llaves) en la que ha sido declarada/creada. Una excepción a esta regla son las variables públicas.

### Asignación

La asignación es el proceso por el cual le damos un valor a una variable. Al asignar un valor, se almacena el nuevo valor y el anterior se perderá, para asignar un valor bastará con utilizar el signo igual ``` = ```. A la izquierda se pondrá la variable y a la derecha el nuevo valor, por ejemplo.



```csharp
	int monedas;
	monedas = 30; 
```

Está permitido asignar un valor al declarar la variable.

```csharp
	int monedas = 5;
	Debug.Log(monedas.ToString());
	monedas = 30; 
	Debug.Log(monedas.ToString());
```

En este código veremos como monedas cambia de valor primero valdrá 5 y tras la segunda asignación 30. Este tipo de asignación que hemos visto en estos ejemplos es una "expresión literal" se almacena el valor especificado sin necesidad de realizar ningún cálculo.

Dependiendo del tipo de dato se realizará una u otra asignación.

```csharp
	int monedas = 5;
	float vida = 20.5f;
	string nombre = "TheKillerz";
	bool isDead = false;
```

### Expresiones

Hemos visto en el apartado anterior lo que es una expresiónm literal, pero no es la única manera de darle un valor a una variable. Tenemos otras formas de asignarle valores a nuestras variables:
- Un valor literal como ya vimos.
- El nombre de una variable. EL resultado será el valor que está almacenado en la otra variable.
- LLamada a una función.
- Una operación: suma (+), resta (-), división (/), multiplicación (*), resto de una división (%)...

```csharp
	//Valor literal
	int monedas = 30;
	// Nombre de una variable, la cartera tendrá un entero con el valor 30.
	int cartera = monedas; 
	//Realizamos la operación de resta en catera almacenará ahora el valor de 30-10, es decir, 20
	cartera = cartera - 10;
```
Otro ejemplo

```csharp
	float ataqueBase = 6f;
	float bonus = 1.6f;
	float ataqueCombo = (ataqueBase + bonus) * 1.75f;
```
El valor de _ataqueCombo_ será de 13.3f. Para ello sustituimos los valores de cada variable y tenemos en cuenta la prioridad de operaciones (igual que en matemáticas), es decir:
- Primero los paréntesis
- Luego multiplicaciones (*), divisiones (/) y módulos (%)
- Finalmente sumas y restas.

Cuando se trata de otro tipo de datos podemos también utilizar ciertas operaciones como la suma de strings.


```csharp
	string name = "TheKillerZ";
	string text = "Hello, " + name + " ! " ;
	Debug.Log(text);
```

Al ejecutar este código se mostrará en la consola "Hello, TheKillerZ !"

### Incrementos y decrementos

Para aumentar o disminuir el valor de una variable en una unidad se puede realizar de dos maneras.

```csharp
	int vidas = 1;
	//Aumenta por lo que ahora tendrá el valor 2
	vidas++;
	//Decrementa ahora tendrá el valor 1
	vidas--;

	//Otro modo es el siguiente  
	//Aumenta en una unidad o las que escribas a la derecha del igual
	vidas += 1;
	//Decrementa en una unidad o las que escribas a la derecha del igual
	vidas -=1;

	int especial = 5;
	//Le suma a vidas el especial (5)
	vidas += especial;
	//la otra opción sería
	vidas = vidas + especial;

```

Al igual que existe += y -= tenemos la operación de multiplicar *= y división /=.