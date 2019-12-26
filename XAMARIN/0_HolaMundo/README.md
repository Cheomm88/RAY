# Xamarin
Bienvenid@ a este bloque de contenido, finalmente dejamos atrás las bases de la programación y las aplicaciones de terminal.

Pasamos al desarrollo de aplicaciones multiplataforma para móvil, hasta ahora todo ha sido mostrar texto y recoger texto... Pero ahora vamos a poder diseñar pantallas, actualizar información desde internet en nuestra aplicación, y muchas más cosas.


## Básicos de Xamarin Forms

Hasta ahora todo el código venía en un solo fichero, o en varias clases.... En Xamarin Forms vamos a encontrar al menos dos tipos de ficheros donde nosotros haremos cosas, tenemos ficheros de visualización de información que serán los que tienen por extensión **.xaml** y los que tienen el código que se ejecuta que tienen por extensión **xaml.cs**, los ficheros de código tienen una sintáxis muy parecida a la que hemos visto ahora ahora (if, bucles, variables, funciones...).

Dónde encontraremos muchos cambios será en los ficheros de visualización esos que acaban en   **.xaml**, esta clase de lenguajes son denominados lenguajes de marcas, tienen cosas parecidas a lo que hemos visto hasta ahora como los parámetros, toda marca tienen un inicio y un final... y No mucho más.

Vamos a utilizar el [ejemplo de Microsoft](https://docs.microsoft.com/es-es/xamarin/xamarin-forms/xaml/xaml-basics/get-started-with-xaml?tabs=windows ) para explicar como funciona XAML. Este será nuestro primer fichero de vista nada más crear un proyecto vacío:

```xaml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:XamlSamples"
             x:Class="XamlSamples.MainPage">

    <StackLayout>
        <!-- En XAML Esto es un Comentario -->
        <!-- Una etiqueta de texto -->
        <Label Text="Welcome to Xamarin Forms!"
               VerticalOptions="Center"
               HorizontalOptions="Center" />
    </StackLayout>
</ContentPage>
```

La indentación (espacios) nos deja entrever que hay cosas que van dentro de otras, así es como suele ocurrir a la hora de crear pantallas. 

Tenemos un objeto grande que será la ventana/pantalla en este caso es el ```ContePage```, dentro de esta Página de Contenido vamos a tener una estructura de mostrar la información existen varias en este caso se usa una interfaz de tipo Pila llamada ``StackLayout``, es decir los elementos van uno encima de otro distribuyéndose por la ventana.

Dentro de ``StackLayout`` creamos una ``Label`` que es una etiqueta, las etiquetas sirven para mostrar texto, si te fijas verás que la línea de la Etiqueta es larga con varios parámetros como son `Text`,`VerticalOptions` y `HorizontalOptions` y acaba con `/>` lo que significa que ahí acaba la etiqueta.

Los parámetros sirven para diferentes funciones, permiten poner texto o modificar el comportamiento de la etiqueta:

* `Text` es el texto que se va a mostrar.
* `VerticalOptions`   modifica cómo el elemento se presenta cuando hay espacio disponible en el eje Y 
* `HorizontalOptions`    modifica cómo el elemento se presenta cuando hay espacio disponible en el eje X

Podríamos añadir un nuevo parámetro quedando de la siguiente manera
```xaml
        <Label x:Name="hiddenText"
			   Text="Welcome to Xamarin Forms!"
               VerticalOptions="Center"
               HorizontalOptions="Center" />
```
El atributo ```x:Name``` no permitirá acceder de manera automática desde el código a esta etiqueta y modificar su texto, utilizando directamente el nombre eledigo en este caso ha sido denominado ```hiddenText```. 
Por lo que podríamos cambiar el texto utilizando ```hiddenText.Text="Nuevo texto"``` en nuestro fichero de código.

Finalmente encontramos 

```xaml
    </StackLayout>
</ContentPage>
```

Que indican que se ha acabado la interfaz de Pila (`StackLayout`) y la página (`ContentLayout`) por eso tienen una `/ `en el tag de xaml.

Es posible ver como está quedando la pantalla que estamos creando dentro del propio Visual Studio sin necesidad de ejecutar el emulador para ello basta con utilizar la vista de diseño (Shift + F7).