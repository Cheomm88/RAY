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
        //Protegidas esta clase y sus hijas pueden usarlas.
        
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
        Transport myTransport = new Transport();
        myTransport.name = "Civic Type-R";
        myTransport.SetSpeed(145.5f);
        myTransport.SetAceleration(5.7f);
        myTransport.boost = 3.0f;


        myTransport.Mostrar();
        myTransport.ApplyBost();
        myTransport.Mostrar();
        
    
        Transport otherTransport;
        otherTransport = myTransport;
        otherTransport.name = "Otro vehículo";


        otherTransport.Mostrar();


    }
```



## Miembros estáticos