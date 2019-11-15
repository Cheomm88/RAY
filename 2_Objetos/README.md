# Clases y Objetos
Es importante entender la diferencia entre clase y objeto, la diferencia es bastante sencilla pero es importante.

- Una **clase** es código, estará formado por líneas de código sin vida.
- Un **Objeto** es cuando esa clase es ejecutada y está "viva".

Las clases son la evolución de los structs, tienen funciones, permiten ocultar información a otras clases así como dos características importantes en la programación orientada a objetos como son:

* **Polimorfismo**: que varias clases compartan funciones que se llamen igual.
* **Encapsulación**: juntar atributos y métodos (funciones) de un elemento en un fichero.
* **Herencia**: al igual que las personas pueden recibir una herencia genética, las clases pueden heredar de otra clase sus características.



Hasta ahora siempre hemos trabajado en C# con clases porque C# es un lenguaje Orientado a Objetos, lo que pasa es que hemos "ignorado" ese pequeño detalle.

A partir de ahora empezaremos a trabajar con objetos y clases, a continuación vemos el código de la clase ```Transport``` se trata de una clase con dos atributos privados speed (velocidad) y capacity (capacidad) .

Al ser atributos privados solo se podrá trabajar con ellos a través de funciones públicas, por ello hemos creado dos funciones llamadas Set Algo y Get Algo. Comúmente son denominados setters y getters permiten dar valor a un atributo así como obtener su valor.

```csharp
public class Transport
{
    //Los atributos son en cierto modo datos o variables.
    //Pueden ser public es decir cualquier otra clase podría modificarlas y leerlas
    //Privadas solo esta propia clase puede trabajar con ellas
    //Protegidas esta clase y sus hijas pueden usarlas.
    private float speed;
 	private int capacity;   
    
    //Setters
    public void SetSpeed(float lSpeed)
    {
        speed = lSpeed;
    }
    
    public void SetCapacity(int lCap)
    {
        capacity = lCap;
        
    }
    //Getters
    public float GetSpeed()
    {
        return speed;
    }
    
    public float GetCapacity()
    {
        return capacity;
    }
    
    public void Mostrar()
    {
        Console.WriteLine("Velocidad " + speed);
        Console.WriteLine("Capacidad "  + capacity);
    }
}
```



Ahora en VisualStudio debemos crear un nuevo proyecto, y añadir una nueva clase en la que irá el código de la clase ```Transport``` .

## Nuestro primer ejemplo

Para crear una clase en nuestro proyecto iremos a la barra de herramientas y seleccionaremos Proyecto y dentro de este menú Agregar Clase.

Saldrá una nueva ventana donde debemos crear una nueva clase de C#, ahora a la derecha en el explorador de soluciones encontramos dos ficheros.

![](https://github.com/Cheomm88/RAY/2_Objetos/Imagenes/explorador.png)