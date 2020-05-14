using System;
using System.Collections.Generic;
using System.Text;

namespace POOConsoleApp
{
    class Vehiculo : IVehiculo
    {
        protected int ruedas = 4;
        protected double largo = 3.40;
        protected double _ancho = 2.05;
        protected int velActual = 0;
        protected string _color;

        public string Color
        {
            get
            {
                if (_color == "negro")
                {
                    return "black";
                }
                return _color;
            }

        }

        public string Name { get; set; }

        public Vehiculo()
        {

        }

        public Vehiculo(string Color)
        {
            Name = "rojo";
        }

        public string QueSoy()
        {
            return "Soy un vehículo";
        }

        public void Frenar()
        {
            Console.WriteLine("Apreté el freno");
        }
    }
}
