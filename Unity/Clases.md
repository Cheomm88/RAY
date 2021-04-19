# Clases
Podemos entender una clase como un tipo de dato que tienen la capacidad para almacenar más de una variable, así como funciones.

Es importante entender la diferencia entre clase y objeto, la diferencia es bastante sencilla pero es importante.

- Una **clase** es código, estará formado por líneas de código sin vida.
- Un **Objeto** es cuando esa clase es ejecutada y está "viva".

Las clases permiten ocultar información a otras clases además tienen las siguientes características:

* **Polimorfismo**: que varias clases compartan funciones que se llamen igual.
* **Encapsulación**: juntar atributos y métodos (funciones) de un elemento en un fichero.
* **Herencia**: al igual que las personas pueden recibir una herencia genética, las clases pueden heredar de otra clase sus características.


A continuación vamos a crear una clase desde cero, por lo que debes crear un script y borrar todo su contenido. Recuerda que el fichero y la clase se deben llamar igual.

```csharp
    //Al poner public la clase es accesible para otros elementos que no pertenezcan a este ámbito
    //En esta línea tenemos el nombre de la clase  Transport
    public class Transport
    {
        //Dentro de la clase declaramos atributos (variables) y métodos (funciones)


        //Los atributos son en cierto modo datos o variables. Estos pueden ser protected, public o privadas.
        //protected esta clase y sus hijas pueden usarlas.
        //private solo la propia clase puede acceder a ellas.
        //Pueden ser public es decir cualquier otra clase podría modificarlas y leerlas
        public string name;
        public float boost = 2.0f;
        //Privadas solo esta propia clase puede trabajar con ellas
        private float speed;
        private float aceleration;
        
        

        public void ApplyBost()
        {
            aceleration += bost;
        }
        
        //Setters
        public void SetSpeed(float lSpeed)
        {
            speed = lSpeed;
        }
        
        public void SetAceleration(float lAc)
        {
            aceleration = lAc;
            
        }
        //Getters
        public float GetSpeed()
        {
            return speed;
        }
        
        public float GetAceleration()
        {
            return aceleration;
        }
        
        public void Mostrar()
        {
            Debug.Log("-------------------------");
            Debug.Log("Información del vehículo : " + name);
            Debug.Log("Velocidad " + speed);
            Debug.Log("Aceleración "  + aceleration);
            Debug.Log("Turbo "  + boost);
        }
    }
```
Vemos que tenemos funciones públicas también podríamos tener funciones privadas o protegidas, en este ejemplo hemos decidido dejarlo así.
> Recuerda en caso de no poner public/protected/private por defecto la función o atributo serán de tipo privado.

Si quisieramos crear un vehículo en nuestro programa tendríamos que hacer lo siguiente

```csharp
    Transport myTransport = new Transport();
```

Al declarar la variable no estaríamos creando una instancia, sino el espacio para referenciarla.

```csharp
    Transport myTransportReference;
```

Si lo que queremos es trabajar con un nuevo objeto tendremos que usar `new NombreClase()`. Vamos a utilizar ahora un nuevo scipt de Unity y en el Start vamos a crear un transporte.


```csharp
    void Start()
    {

        //Creamos un NUEVO objeto
        Transport myTransport = new Transport();
        myTransport.name = "Civic Type-R";
        myTransport.SetSpeed(145.5f);
        myTransport.SetAceleration(5.7f);
        myTransport.boost = 3.0f;



        myTransport.Mostrar();
        myTransport.ApplyBost();
        myTransport.Mostrar();
        
    
        //Creamos una REFERENCIA a un objeto
        Transport otherTransport;
        //Decidimos la referencia 
        otherTransport = myTransport;
        //Hacemos cambios en la REFERENCIA
        otherTransport.name = "Otro vehículo";
        //Vemos cambios en REFERENCIA
        otherTransport.Mostrar();
        //Que también se aplican en el objeto original.
        myTransport.Mostrar();
        //Esto es porque están accediendo los dos al mismo dato en la memoria

    }
```

Si te fijas al crear un Script en Unity encontrarás lo siguiente

```csharp

public class MiScript : MonoBehaviour {

```
Al encontrarte con `: MonoBehaviour` significa que nuestro script hereda de la clase MonoBehaviour, por lo que tendrá elementos de esta clase que ha sido creada por los desarrolladores de Unity. Es por ello que tenemos acceso al Start, Update o sistemas de colisiones.

Podríamos crear una clase hjija de Transport para ello podemos hacer lo siguiente

```csharp
    public class Avion : Transport
    {
        public float altura;
        pubic int pasajeros;
    }
```
Esta nueva clase tendrá las características de Transport como velocidad, aceleración o nombre y esto es gracias a `: Transport`.

## Miembros estáticos

Todo lo que hemos definido hasta ahora (variables/atributos y funciones/métodos) serán definidos para cada objeto de la clase. Es posibble crear variables y funciones definidas para la clase en sí, en lugar de lsus instancias. Por ejemplo se podría tener un límite de velocidad igual para cualquier vehículo.

`public static float speedLimit = 120.0f`

De este modo todos los transportes tendrán esa limitación podrías modificar el valor en una instancia y se cambiará en todos.

`myTransport.speedLimit = 80.0f`

Una de las utilidades qeu encontraremos de los miembros estáticos es crear lo que se denomina Singleton, es una práctica que permite tener una clase que gestione información de manera centralizada. Esto puede tener sus aspectos negativos en caso de que apliquemos esta práctica de manera habitual en nuestro proyecto. Puede ser muy útil en nuestros juegos para gestionar puntos, monedas...

El siguiente ejemplo es un singleton utilizado para controlar los puntos. Desde cualquier script podremos añadir puntos utilizando la función de la clase `PointsManager.Instance.AddPoints(CantidadPuntos);` por otro lado podremos obtener los puntos actuales con `PointsManager.Instance.Points;`

```csharp 
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    //La clase se llama PointsManager
    public class PointsManager : MonoBehaviour
    {
        //Miembro estático que nadie podrá acceder, sirve como seguridad.
        //Es del mismo tipo de dato que la clase
        private static PointsManager _instance;

        //Miembro público que puede ser accedido desde cualquier script usando PointsManager.Instance.LoQueQuieroDeLaClase();
        public static PointsManager Instance { get { return _instance; } }

        //Los puntos son privados nadie puede acceder a ellos de manera directa para modificarlos.
        private int _points;
        //A través de esta referencia pueden ser accedidos
        public int Points { get { return _points; } }

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else {
                Destroy(this.gameObject);
            }
        }

        /// <summary>
        /// Añade puntos.
        /// </summary>
        /// <param name="amount">Cantidad de puntos que se van a añadir</param>
        public void AddPoints(int amount)
        {
            _points += amount;
        }
    }
```
