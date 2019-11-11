/*
Autor Eliseo Martín Mora
Este programa es un ejemplo del uso de Arrays y funciones.
*/

using System;

namespace TeoriaArrays
{
    class Program
    {
        static void Main(string[] args)
        {
			//Escribe en la terminal (pantalla) el mensaje
            Console.WriteLine("Hello World!");

			// Un array es una colección de elementos iguales, en este caso de números enteros
			//un array se puede crear de varias formas
			
			//Podemos crearlo metiendo desde el código fuente los datos que queramos
            int[] ejemplo = { 9, 15, 5, 4, 8, 10 };

			//Podemos crearlo del tamaño que consideremos de la siguiente manera
			//En una variable almacenamos el tamaño/número de elementos que tendrá el array
            int n = 5;
			//Nuevamente decalaramos un array de enteros, esto se hace siempre de la siguiente manera
			// TIPO_DE_DATO[]   ----> Indica el tipo de dato que vamos a utilizar y que se trata de un array
			// nombre de la variable
			// se inicializa (= new) y le recordamos el tipo de dato (int[]) y dentro de los corchetes irá el tamaño/nº de elementos que tendrá nuestro array.
            int[] myArray = new int[n];
			// Para almacenar información en este array lo hacemos así
			//Ponemos el nombre de la variable y los corchetes, dentro de los corchetes la posición dentro del array y finalmente le asignamos el valor considerado.
			//Recuerda que los arrays empiezan en la posición 0.
			myArray[3] = 5;


			//Como tenemos varias variables que son arrays de números hemos decidido crear funciones que trabajan con arrays, de esta manera podremos mostrarlo sin necesidad de crear un código para cada array.
            Imprimir(ejemplo);
            Console.WriteLine("");
			//Igualmente hemos creado funciones para obtener el Máximo, Mínimo y la Media de un ARRAY.
            Console.WriteLine("Máximo del array: " + GetMax(ejemplo));
            Console.WriteLine("Mínimo del array: " + GetMin(ejemplo));
            Console.WriteLine("Media: " + GetMedia(ejemplo));
            //Creamos array dinámico de 3 número y lo cargamos
            int[] miArray = new int[3];
            Cargar(miArray);

            Imprimir(miArray);


            //Matriz de muchos alumnos
            //20 alumnos con n examenes
			// Hasta ahora vimos que los arrays pueden ser de una dimensión, pero podemos crearlos de dos dimensiones, esto supone tener una especie de "excel".
			// Alumno    notas               
  			//    0     {4,5,6}
			//    1     {0,2,1}
			//  ...
			//  ...
			//    19     {7,8,9}
            int nAlumnos = 20;
            int nExamenes = 3;
			//Crea un array con 20 filas, y cada fila tendría 3 notas.
            int[,] miClase = new int[nAlumnos, nExamenes];
            Cargar(miClase);
        }

		//Funcion para cargar un array de dos dimensiones.
        static void Cargar(int[,] array)
        {
			//Recorre las 20 filas
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Notas alumno " + i);
				//Este bucle sirve para asignar las notas de un alumno.
                for (int j = 0; j < array.GetLength(i); j++)
                {
                    Console.WriteLine("Nota del examen " + i + " para el alumno " + j);
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
		
		//Función que carga un array de 1 dimensión
        static void Cargar(int[] array)
        {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("Valor para el array en la posición " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }  

		//Función que recibe un array de números y lo muestra.
        static void Imprimir(int[] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + " ,");
                }
                else
                {
                    Console.Write(array[i] + "}");
                }
            }
        }

		//Función que recorre un array buscando el número más grande y lo devuelve.
        static int GetMax(int[] array)
        {
            int maximo = array[0];

            for(int i = 0; i < array.Length;i++)
            {
                if (maximo < array[i])
                {
                    maximo = array[i];
                }
            }
            return maximo;
        }
		
		//Función que recorre un array buscando el número más pequeño y lo devuelve.

        static int GetMin(int[] array)
        {
            int minimo = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (minimo > array[i])
                {
                    minimo = array[i];
                }
            }
            return minimo;
        }
		//Función que calcula la media de un array de números.

        static float GetMedia(int[] array)
        {
            float media = 0.0f;
            for (int i = 0; i < array.Length; i++)
            {
                media += array[i];
            }

            media = media / array.Length;

            return media;
        }

    }
}
