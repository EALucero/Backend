using System;
using System.Collections.Generic;
using System.Text;

namespace POOConsoleApp
{
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
            Console.WriteLine("Apreté el embrage");
            Console.WriteLine("Aprete el freno");
        }
    }
}
