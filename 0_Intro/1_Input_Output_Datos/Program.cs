using System;

namespace InputOutputTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                La información es almacenada en diferentes tipos de datos, esto el programa lo guarda en variables que son borradas una vez el programa se termina de ejecutar
                Las variables pueden ser de diferentes tipos:
                    Numéricos: int, float, double
                                int números enteros (-5, 0, 5, ....)
                                float números con decimales (-15.13f, 0.0f,5.0f) si decidimos ponerle valor desde el código se le añade una f al final para indicar que son números decimales.
                                double números con decimales también.
                    Texto: string, char
                            string permite almacenar frases mientras que char solo un símbolo
             */
            int miEntero = 10;

            //Las variables númericas se pueden sumar, restar, multiplicar, dividir de la siguiente manera
            miEntero = miEntero + 5; //10 + 5 = 15
            //En caso de querer añadir uno se puede hacer de dos formas
            miEntero = miEntero + 1; //15+1 = 16
            miEntero++; //16 + 1 = 17
            //Ahora la variable miEntero tiene el valor 10+5+1+1 = 17


            float miDecimal = 10.0f;

            string miFrase = "Hola mundo";
            //puedes añadir más texto a un string "sumando"
            miFrase = miFrase + " esto es muy aburrido!!"; // Ahora el texto almacenado es "Hola mundo esto es muy aburrido!!"

            char miChar = 'H';

            //Para escribir mensajes por pantalla se usa la función WriteLine
            Console.WriteLine("Escribe tu mensaje:");

            //Para recibir mensajes del usuario se utiliza la función ReadLine
            //es necesario almacenar el valor escrito por el usuario para trabajar
            //con la información
            string textoUsuario = Console.ReadLine();

            //Mostramos el mensaje
            Console.WriteLine(textoUsuario);
        }
    }
}
