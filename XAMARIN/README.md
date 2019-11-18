# Xamarin Forms
Bienvenid@ a este bloque de contenido, finalmente dejamos atrás las bases de la programación y las aplicaciones de terminal.

Pasamos al desarrollo de aplicaciones multiplataforma para móvil, hasta ahora todo ha sido mostrar texto y recoger texto... Pero ahora vamos a poder diseñar pantallas, actualizar información desde internet en nuestra aplicación, y muchas más cosas.



Empezaremos por el "Hola Mundo" (sí, otra vez) y posteriormente iremos trabajando con diferentes prácticas.



## Básicos de Xamarin Forms

Hasta ahora todo el código venía en un solo fichero, o en varias clases.... En Xamarin Forms vamos a encontrar al menos dos tipos de ficheros donde nosotros haremos cosas, tenemos ficheros de visualización de información que serán los que tienen por extensión **.xaml.cs** y los que tienen el código que se ejecuta que tienen por extensión **.cs**, los ficheros de código tienen una sintáxis muy parecida a la que hemos visto ahora ahora (if, bucles, variables, funciones...).

Dónde encontraremos muchos cambios será en los ficheros de visualización esos que acaban en   **.xaml.cs**, esta clase de lenguajes son denominados lenguajes de marcas, tienen cosas parecidas a lo que hemos visto hasta ahora como los parámetros, toda marca tienen un inicio y un final... y No mucho más.



Vamos a utilizar el

[ejemplo]: https://docs.microsoft.com/es-es/xamarin/xamarin-forms/xaml/xaml-basics/get-started-with-xaml?tabs=windows

 para explicar los primeros pasos. Este será nuestro primer fichero de vista:



```xaml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:XamlSamples"
             x:Class="XamlSamples.MainPage">

    <StackLayout>
        <!-- Place new controls here -->
        <Label Text="Welcome to Xamarin Forms!"
               VerticalOptions="Center"
               HorizontalOptions="Center" />
    </StackLayout>
</ContentPage>
```

