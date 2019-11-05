using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFicheros
{
    class Program
    {

        static StreamReader streamReader;
        static StreamWriter streamWriter;
        static void Main(string[] args)
        {
            int opt = 0;
            while (opt != 3)
            {
                Console.WriteLine("Pulse 1 para crear un fichero y escribir sobre el mismo");
                Console.WriteLine("Pulse 2 para leer un archivo");
                Console.WriteLine("Pulse 3 para salir");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        CrearFichero();
                        break;
                    case 2:
                        LeerFichero();
                        break;
                }
            }

        }
        static void CrearFichero()
        {
            //StreamWriter permite abriur un fichero, para ello es necesario definir dos parámetros
            //el primero es el nombre del fichero
            //el segundo es un booleano (true/false) para añadir texto al final del fichero
            // true significa que añade al final del fichero la linea escrita.
            // false significa que el fichero será sobreescrito con el nuevo contenido.
            streamWriter = new StreamWriter("miFichero.txt", false); 
            Console.WriteLine("Escriba el texto que contiene el fichero");
            string text = Console.ReadLine();

            //streamWriter puede escribir una linea de la siguiente manera.
            streamWriter.WriteLine(text);
            Console.WriteLine("Se ha almacenado con éxito su fichero");
            streamWriter.Close();
        }
        static void LeerFichero()
        {
            //Para iniciar la lectura de un fichero es necesario utilizar una instancia de StreamReader
            //para inicializarlo es necesario pasarle un string con el nombre del fichero
            string nombreFichero = "miFichero.txt";            
            streamReader = new StreamReader(nombreFichero);
            //Leemos en un string todo el contenido del fichero
            string text = streamReader.ReadToEnd();
            Console.WriteLine("\t El texto que contiene el fichero es: \n" + text);
            streamReader.Close();

        }
    }
}
