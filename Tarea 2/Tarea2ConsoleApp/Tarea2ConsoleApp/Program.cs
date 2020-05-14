using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto fiat = CreateAuto("blanco");
            Auto fiatRojo = CreateAuto("rojo");
            Auto fiatAzul = CreateAuto("azul");

            Console.WriteLine(fiat.getRuedas());
            fiat.Acelerar(-60);
            fiat.setLargo(3.70);

            Console.WriteLine(fiat.getVelocidad());
            Console.ReadLine();

            Camion micamion = new Camion();
            Console.WriteLine(fiat.QueSoy());
            fiat.Frenar();
            Console.WriteLine(micamion.QueSoy());
            micamion.Frenar();

            //Console.WriteLine(fiat.Color());
            //Console.WriteLine(fiatRojo.Color());
            Console.ReadLine();

        }

        public static Auto CreateAuto(string color)
        {
            var aux = new Auto(color);
            aux.setLargo(2);
            return aux;
        }
    }

    interface IVehiculo
    {
        string Color { get; }
    }

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

        public Vehiculo()
        {

        }

        public Vehiculo(string color)
        {

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

    class Auto : Vehiculo
    {
        public Auto()
        {

        }

        public Auto(string color)
        {
            _color = color;
        }

        public Auto(string color, double ancho)
        {
            _color = color;
            _ancho = ancho;
        }

        public void Arrancar()
        {
            Console.WriteLine("El auto arrancó");
        }

        public void Acelerar(int velocidad)
        {
            if (velocidad > 0)
            {
                velActual += velocidad;
            }
        }

        public int getRuedas()
        {
            return ruedas;
        }

        public void setLargo(double nuevoValor)
        {
            largo = nuevoValor;
        }

        public int getVelocidad()
        {
            return velActual;
        }

        public string QueSoy()
        {
            return "Soy un auto";
        }

        public void Frenar()
        {
            Console.WriteLine("Apreté el freno y el embrage");
        }
    }

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


//public void decreaseStock(int amount)
//{
//    (_stock - amount) > 0 ? _stock -= amount : throw new Exception("Amount of items requested is higher than avaiable stock");

//}

//bool a = (_stock - amount) > 0 ? true : false;

//var x = (condición) ? valor_a_devoler_si_es_true : valor_a_devoler_si_es_false