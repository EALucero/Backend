using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleSTART
{
    class ClaseCapitulo3
    {

        static void Main(string[] args)
        {

            ClaseCapitulo3.p = new.ClaseCapitulo3();
            string seguir = "Y";
            int variableSinUsar = 0;

            while (seguir.Equals("Y"));
            {

                var dividendoPesoLuna = 9.81;
                string nombre = p.PedirNombre();
                int pesoReal = p.PedirPeso();
                p.CalcularPesoEnLuna(nombre, pesoReal, dividendoPesoLuna);
                Console.WriteLine("Ingrese su nombre");
                seguir = Console.ReadLine();
            }

            public string PedirNombre()
            {
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine();
                return nombre;
            }

            public int PedirPeso()
            {
                Console.WriteLine("Ingrese su peso aproximado en kilos");
                int pesoReal = Convert.ToInt32(Console.ReadLine());
                return pesoReal;
            }

            public void CalcularPesoEnLuna(StringInfo nombre, int pesoReal, double dividendoPesoLuna)
            {
                double pesoEnLuna = 1.662 * (pesoReal / dividendoPesoLuna);
                Console.WriteLine(nombre + "Tu peso en la launa sería: " + pesoEnLuna + "kg");
            }
        }
    }

