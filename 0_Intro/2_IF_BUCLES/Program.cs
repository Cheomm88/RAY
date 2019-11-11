using System;
/*
Autor Eliseo Martín Mora
Programa que hace uso de condiciones y bucles.

*/
namespace IfBucle
{
    class Program
    {
		//Función principal del programa
        static void Main(string[] args)
        {
            //Lo programas están creados por código, el cual puede ser una orden/instrucción (llevan siempre un ; al final de la linea)
			// y código de control (bucles, condiciones....).
			
			//Las instrucciones pueden servir para declarar un nuevo dato.
			int numero = 0;
			// Para modificar datos
			numero = numero + 10;
			//Asignar valores.
			int numeroDos = 0;
			numeroDos = numero;
			
			/*************************************************

				_________                    .___.__       .__                             
				\_   ___ \  ____   ____    __| _/|__| ____ |__| ____   ____   ____   ______
				/    \  \/ /  _ \ /    \  / __ | |  |/ ___\|  |/  _ \ /    \_/ __ \ /  ___/
				\     \___(  <_> )   |  \/ /_/ | |  \  \___|  (  <_> )   |  \  ___/ \___ \ 
				\______  /\____/|___|  /\____ | |__|\___  >__|\____/|___|  /\___  >____  >
					\/            \/      \/         \/               \/     \/     \/ 
	
			Los programas se ejecutan línea a línea, por lo que si queremos cambiar el rumbo de ejecución sería imposible, es por ello que existen las condiciones. A través de ellas podemos cambiar la ejecución del programa en base a un evento, condición matemática o a una respuesta del usuario.
			
			Si queremos comparar números podemos pesar en varias condiciones:
				Que dos números sean iguales a == b
				Que dos números sean distintos a != b
				Que un número sea mayor que otro a > b
				Que un número sea mayor o igual que otro a >= b
				Que un número sea menor que otro a < b
				Que un número sea menor o igual que otro a <= b

			Podemos también tener varias condiciones que dependan entre sí:
				Que suceda una cosa y la otra a && b 
				Que sucede una cosa o la otra a || b
				
				Estas se pueden acumular para conseguir rangos de edad por ejemplo.
			*************************************************/
			int edadActual = 22;
			int edadMayorEdad = 18;
			int edadJubilado = 75;
			
			/*
				If permite que se ejecute el código cuando una condición se cumple.
				Su estructura habitual es la de 
				
				if(condiciones)
				{
					hacer cosas
					
				}
			
			*/
			if(edadActual > edadMayorEdad)
			{
				Console.WriteLine("Es mayor de edad");
			}
			else  //sino
			{
				Console.WriteLine("Es menor de edad");
			}
			
			//Si la edad es igual
			if(edadActual == 0)
			{
				Console.WriteLine("Es un bebe!!");
			}
			
			if(edadActual >= edadJubilado)
			{
				Console.WriteLine("Se acabó el trabajar");
			}
			
			//Juntamos dos condiciones permitiendo sacar un rango
			if(edadActual < edadJubilado && edadActual > edadMayorEdad)
			{
				Console.WriteLine("Edad para cotizar!");
			}
			
			/*
				Otra opción es el Switch el cual permite acumular muchas sentencias del tipo if-else pero siendo mucho más limpio y cómodo.
				Su sintaxis es la siguiente
				switch(VARIABLE)
				{
					case VALOR:
						Cosas
						break;
					case VALOR2:
						Cosas2;
						break;
					
				}
			*/
			
			//Este ejemplo podría ser un menú
			
			int opt = Convert.ToInt32(Console.ReadLine());
			
			//Analizamos el valor de opt en base a su valor ejecutamos una opción u otra.
			switch(opt)
			{
				case 0:
					Console.WriteLine("Has elegido la opción 0");
					break;
				case 1:
					Console.WriteLine("Has elegido la opción 1");
					break;
				case 2:
					Console.WriteLine("Has elegido la opción 2");
					break;
				case 3:
					Console.WriteLine("Has elegido la opción 3");
					break;				
				case 4:
					Console.WriteLine("Has elegido la opción 4");
					break;
				case 5:
					Console.WriteLine("Has elegido la opción 5");
					break;
			}

			/*
						  ____             _           
						 |  _ \           | |          
						 | |_) |_   _  ___| | ___  ___ 
						 |  _ <| | | |/ __| |/ _ \/ __|
						 | |_) | |_| | (__| |  __/\__ \
						 |____/ \__,_|\___|_|\___||___/
													   
                               
			Los bucles permiten repetir el código a ejecutar varias veces sin necesidad de escribirlo.
			Veremos dos tipos de bucles 
				FOR
				WHILE
			Aunque existen otros.

			
			
			 Bucle FOR es normalmnete utilizado para recorrer elementos o repetir un número determinado de veces una acción.
			 
			 Su sintaxis tipo es la siguiente:
			 
			 Ponemos int porque estamos declarando una nueva variable llamada i, podemos usar cualquier nombre.
			 El máximo será menor estricto en este caso
			 i++ significa que aumenta de uno en uno.
			 Hará "Hacer cosas" máximo -1 veces 
			 for(int i = 0; i < Maximo; i++)
			 {
				 Hacer cosas
			 }
			 
			 */
			 
			 for(int i = 0; i < 10;i++)
			 {
				 Console.WriteLine("Repito " + (i+1) + " veces");
			 }
			 
			 /*
				El bucle while se repite mientras dure una condición, su sintaxis es la siguiente
				while(condición)
				{
					repetir
					
				}
			 
			 */
			 opt = 0;
			 while(opt != 3)
			 {
				Console.WriteLine("Pulse 3 para salir, 0 para bnlbla, 1 para lo otro y 2 para la magia");
				opt = Convert.ToInt32(Console.ReadLine());
				switch(opt)
				{
					case 0:
						Console.WriteLine("Has elegido la opción 0");
						break;
					case 1:
						Console.WriteLine("Has elegido la opción 1");
						break;
					case 2:
						Console.WriteLine("Has elegido la opción 2");
						break;
				}
			 }
			 Console.WriteLine("Sale del while");
		}
    }
}
