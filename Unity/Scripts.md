# Scripts
Si estás leyendo esta guía, probablemente estés aprendiendo a programar C#, cómo escribir algún script simple y qué cosas no hacer. Al crear tu primer script en Unity te encontrarás con lo siguiente.

v

El código de aquí arriba es la plantilla de un nuevo script en C# de Unity. Podemos dividirlo en varias secciones.

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
```

En las primeras líneas son las que "importan" las librerías de código necesarias para que nuestro código funcione. Piensa en ellas como dependencias: no puedes usar una característica de la librería UnityEngine (Unity) si no expecificas en una declaración que las estás *usando*. Asegurate de dejarlas siempre en las primeras líneas de código

```csharp
public class MyCustomScript 
```

El fichero que hemos creado define una clase (una abstracción de un objeto), que es público "public" (accessible por otros scripts/códigos), y su nombre es el mismo que el del fichero. En este caso, se llama *MyCustomScript*. Este es un nombre **horrible** ! No podemos entender que hace la clase simplemente al leer el nombre (ese es tu objetivo). Siempre usa nombres con significado como "PlayerHealth" (SaludJugador) o "Projectile" (Proyectil), **siempre** usando "Pascal Case", es decir, cada palabra tendrá su primera letra en mayúscula.

```csharp
                            : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
```

En la parte superior (justo tras public class MyCustomScript), definimos que clases (si es que hay alguna) vamos a heredar. En este caso, es la clase MonoBehaviour de Unity. Esta es sin duda la clase más importante en el desarrollo de juegos para Unity ahora mismo, podríamos decir que "marca" esta clase como un componente que podremos adjuntar/asignar a un GameObject. Heredar de otra clase no es solo "marcar", es lo que nos "permite crear nuevas clases que se reutilizan, expanden y modifican el comportamiento que está definido en otras clases". Los métodos Start y Update, por ejemplo, son algo que Unity solo llamará durante sus [eventos predefinidos](https://docs.unity3d.com/Manual/ExecutionOrder.html) si tu clase *es* un MonoBehaviour, en la que ampliaras los métodos que necesitas con las funcionalidades adecuadas. (Por ejemplo: en el Update podrás modificar la posición de un objeto).

Un error común entre los que se inician, es pensar que todo debe ser un MonoBehaviour o heredar de otra clase. Esto está muy lejos de la realidad, y se trata de una mala prácticas. Por ejemplo, si tienes un código que solo manipula datos, podrías considerarlo como una clase que no herede de MonoBehaviour.

## Mi primer Script

Vamos a modificar el script creado anteriormente para mostrar un texto en la consola de depuración. Para ello haremos uso de la Clase Debug y la función Log, de la siguiente manera ```Debug.Log("Hola Unity");``` esto es una sentencia de código. Vamos a poner esa línea dentro de la función Start, entre las dos llaves.

La primera llave ```{``` indica el comienzo de un bloque de código, en este caso el inicio de la función Start la cual es ejecutada al iniciarse el programa. Por otro lado la llave ```}``` indica el final de un bloque de código, o en este caso de la función.

Vemos que existen llaves tras la palabra "MonoBehaviour" y tras ello salen las funciones Start y Update para terminar el código con una llave. Cualquier cosa que queramos modificar de nuestro script debe ir entre la primera llave tras MonoBehaviour y la última. Al igual que las sentencias, órdenes o condiciones deben ir dentro de una función fuera de ellas no harán nada.


```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCustomScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Hola Unity");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
```

Si añadimos nuestro Script a un GameObject de la escena y ejecutamos veremos que pone Hola Unity en la consola.

