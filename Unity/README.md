# Unity
Unity es un motor 3D que facilita la creación de videojuegos evitando tener que desarrollar herramientas para representar objetos en el espacio 3D y 2D, luces, obtención de los periféricos, etc.

En Unity podrás utilizar C# para ampliar sus funciones así como personalizar comportamientos. A través de este repositorio vereremos una introducción al motor gráfico que es utilizado por muchas compañías a la hora de crear videojuegos como se puede ver en su [Web](https://unity.com/es/madewith)

En un proyecto de de Unity encontraremos variedad de elementos desde texturas (imágenes), modelos 3D, scripts en C# y también elementos más propios de Unity como son las Escenas, GameObjects o Prefabs.

## Escenas
Las escenas **contienen los objetos de su juego**. Pueden ser usadas para crear un menú principal, niveles individuales, y cualquier otra cosa. Piense en cada archivo de escena, como un nivel único. En cada escena, usted va a colocar su ambiente, obstáculos, y decoraciones, el diseño esencial y la construcción de su juego en pedazos.


## GameObjects
Los [GameObjects](https://docs.unity3d.com/Manual/class-GameObject.html) son objetos fundamentales en Unity que representan personajes, props, y el escenario. Estos **no logran nada por sí mismos** pero funcionan como contenedoras para Components, que implementan la verdadera funcionalidad. 

Cuando se selecciona un GameObject en una Escena podremos ver en el inspector la información del GameObject así como sus componentes. La única información que no depende de componentes es la siguiente:
![Visión de un GameObject en el inspector](/images/GameObjectSceneStatusProperties.png)

- Nombre
- Estado de activación al desactivar un GameObject este deja de "funcionar" y ser visto.
![Check box para activar o desactivar GameObject](/images/GOInspectorActiveSetting.png)


- Static: se activa para los objetos que no se mueven, de esta manera Unity puede adelantar cálculos y mejorar el rendimientos.
![Check box para marcar como estático](/images/GOInspectorStaticSetting.png)

- Tag o Etiqueta: es utilizado para reconocer y buscar objetos de una misma categoría por ejemplo buscar todos los enemigos o powerups. En la siguiente línea de código estaríamos buscando todos los enemigos de una escena.
```
GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
```
- Layer o Capa: es similar a la etiqueta pero utilizado por las físicas y el motor de renderizado

![Sección donde modificar el Layer o el Tag de un GameObject](/images/GOInspectorTagsAndLayers.png)

### Componentes

### Prefabs

