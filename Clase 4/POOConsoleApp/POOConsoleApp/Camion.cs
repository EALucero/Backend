using System;
using System.Collections.Generic;
using System.Text;

namespace POOConsoleApp
{
    class Camion : Vehiculo
    {
        public string QueSoy()
        {
            return "Soy un camión";
        }

        public void Frenar()
        {
            Console.WriteLine("Apreté el freno");
        }
    }
}
