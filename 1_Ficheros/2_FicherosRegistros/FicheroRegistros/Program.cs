using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FicheroRegistros
{
    class Program
    {
        static StreamWriter streamWriter;
        static StreamReader streamReader;
        struct Persona
        {
            public string Nombre;
            public string Direccion;

        }
        static void Main(string[] args)
        {
            int i = 0;
            string opcion = "S";
            string linea;

            Persona acceso = new Persona();
            
            
            //Creación del fichero
            while (opcion == "S" || opcion == "s")
            {
                Console.Clear();
                //Abrimos el fichero
                streamWriter = new StreamWriter("ficheroAccesos.txt", true);

                //Obtenemos datos del usuario
                Console.WriteLine("Escriba el Nombre del usuario");
                acceso.Nombre = Console.ReadLine();
                Console.WriteLine("Escriba la direcicón del usuario");
                acceso.Direccion = Console.ReadLine();

                //Escribimos en el fichero
                streamWriter.WriteLine("ID:" + (i + 1));
                streamWriter.WriteLine("Nombre:" + acceso.Nombre);
                streamWriter.WriteLine("Direción:" + acceso.Direccion);

                i++;
                streamWriter.Close();

                Console.WriteLine("Desea continuar añadiendo registros? (S/N)");
                opcion = Console.ReadLine();
            }

            //Lectura del fichero

            streamReader = new StreamReader("ficheroAccesos.txt");
            while ((linea = streamReader.ReadLine()) != null) //mientras se pueda leer el fichero (es decir no ha terminado)
            {
                Console.WriteLine(linea);
            }
            streamReader.Close();

        }
    }
}
