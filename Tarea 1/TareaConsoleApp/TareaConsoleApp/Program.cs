using System;

namespace TareaConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola " + nombre + "!");

            Console.WriteLine("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Películas para vos:");

                if (edad <= 10) 
                {
                    Console.WriteLine("Sonic, Spiderman, Coco.");
                } 
                else if (edad <= 20) 
                {
                    Console.WriteLine("Scary Movie, Harry Potter, Kill Bill.");
                } 
                else {
                    Console.WriteLine("Joker, Fragmentado, Donnie Darko.");
                }

            Console.ReadLine();

            //Me rompí los cuernos para que salga con Q y no funcaba, así que lo dejo así por ahora. 
            //Más adelante subiré una versión con esto y bien ordenada, como nos enseñaron ayer. 
            //Ah, me olvidaba 2 cosas, lo de las películas seguro que era con List y lo del Zodíaco
            //lo había hecho con switch, usando sólo el mes, pero no sabía que comienzan cierto día 
            //de un mes y terminan en el siguiente, porque no creo en éstas cosas. :)

            Console.WriteLine("Fecha de nacimiento");
            Console.WriteLine("Año:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mes:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Día:");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime date1 = DateTime.Now; 
            DateTime date2 = new DateTime(year, month, day);
            TimeSpan tSpan = date1 - date2;
            int dias = tSpan.Days;
            Console.WriteLine("Llevas " + dias + " días vividos hasta ahora.");

                if ((month == 1 && day > 20) || (month == 2 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Acuario.");
                }
                else if ((month == 2 && day > 20) || (month == 3 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Piscis.");
                }
                else if ((month == 3 && day > 20) || (month == 4 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Aries.");
                }
                else if ((month == 4 && day > 20) || (month == 5 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Tauro.");
                }
                else if ((month == 5 && day > 20) || (month == 6 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Géminis.");
                }
                else if ((month == 6 && day > 20) || (month == 7 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Cáncer.");
                }
                else if ((month == 7 && day > 20) || (month == 8 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Leo.");
                }
                else if ((month == 8 && day > 20) || (month == 9 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Virgo.");
                }
                else if ((month == 9 && day > 20) || (month == 10 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Libra.");
                }
                else if ((month == 10 && day > 20) || (month == 11 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Escorpio.");
                }
                else if ((month == 11 && day > 20) || (month == 12 && day <= 20))
                {
                    Console.WriteLine("Tu signo es Sagitario.");
                }
                else
                {
                    Console.WriteLine("Tu signo es Capricornio.");
                }

            Console.ReadLine();
            Console.ReadKey();


        }
    }
}
