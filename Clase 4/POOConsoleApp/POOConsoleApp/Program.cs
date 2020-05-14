using System;
using System.Dynamic;

namespace POOConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto fiat = CrearAuto("blanco");
            Auto fiatRojo = CrearAuto("rojo");
            //Auto fiatAzul = CrearAuto("azul");

            Console.WriteLine(fiat.Color);
            Console.WriteLine(fiatRojo.Color);


            Console.WriteLine(fiat.getRuedas());
            fiat.Acelerar(-60);
            fiat.setLargo(3.70);

            Console.WriteLine(fiat.getVelocidad());
            Console.ReadLine();

            Camion micamion = new Camion();
            Console.WriteLine(fiat.QueSoy()); 
            Console.WriteLine(micamion.QueSoy());

            fiat.Frenar();  
            micamion.Frenar(); 

            fiat.Name = "Mi fiat";
            Console.ReadLine();

        }

        public static Auto CrearAuto(string color)
        {
            var aux = new Auto(color);
            aux.setLargo(2);
            return aux;
        }
    }    
}
