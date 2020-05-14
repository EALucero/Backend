using System;
using System.Collections.Generic;

namespace CSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*const int variableConstante = 1;

            var numero = 0;

            int numeroA = 1;

            numeroA = numeroA + 1;

            string texto = "30";

            bool booleano = false;

            double decimales = 20.33;

            string numeroEnTexto = numeroA.ToString();*/

            //string cars = "renault";

            //string[] carsArray = new string[4] { "audi", "vw", "renault", "fiat" };

            // Console.WriteLine(carsArray[4]);

            // Console.ReadLine();

            //

            List<int> listaEnteros = new List<int>();


            listaEnteros.Add(1);
            listaEnteros.Add(2);

            Console.WriteLine(listaEnteros[1]);

            Console.WriteLine("Lista contiene el 2: " + listaEnteros.Contains(2));
            Console.WriteLine("Lista contiene el 3: " + listaEnteros.Contains(3));

            Console.WriteLine("Cantidad de elementos: " + listaEnteros.Count);
            Console.ReadLine();

            //

            //if (listaEnteros.Count < 4)
            //{
            //    Console.WriteLine("if");
            //}
            //else if (listaEnteros.Count < 1)
            //{
            //    Console.WriteLine("else if");
            //}
            //else
            //{
            //    Console.WriteLine("else");
            //}

            //Console.ReadLine();

            ////

            //string output = (listaEnteros.Count < 1) ? "true" : "false";

            //Console.WriteLine(output);
            //Console.ReadLine();

            ////

            //switch (listaEnteros.Count)
            //{
            //    case 2:
            //        Console.WriteLine("2");
            //        break;

            //    case 1:
            //        Console.WriteLine("1");
            //        break;

            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}
            //Console.ReadLine();

            ////

            //for (int i=0; i<4 ; i++)
            //{
            //    Console.Write(carsArray[i]);
            //}

            //int j = 3;
            //while (j>=0)
            //{
            //    if (j == 2)
            //    {
            //        j--;
            //        break;
            //    }
            //    Console.WriteLine(carsArray[j]);
            //    j--;
            //}
            //Console.ReadLine();

            //

            foreach (var entero in listaEnteros)
            {
                if (entero == 1)
                {
                    Console.WriteLine("Vale 1!!!");
                }

                Console.WriteLine(entero);

            }
            Console.ReadLine();

            MiPrimerMetodo();

            ImprimirCadena("Hola");
            ImprimirCadena("Mundo");
            ImprimirCadena();

            Console.ReadLine();
            return;
        }

        static void MiPrimerMetodo()
        {
            Console.WriteLine("PrimerMetodo");
        }

        static void ImprimirCadena(string cadenaParaImprimir = "Sin Parametro")
        {
            Console.WriteLine(cadenaParaImprimir);
        }

        static void ImprimirCadena(string cadenaParaImprimir, int cantidadDeImpresiones)
        {
            for (int i = 0; i < cantidadDeImpresiones; i++)
            {
                Console.WriteLine(cadenaParaImprimir);
            }
        }

        //static int Suma()
        //{
        //string texto = Console.ReadLine()
        //}

        /*
        public void metodo1()
        {
            int numero = 1;

            var resultado = numero + 30;
        } */
    }
}
