using System;
using System.Linq;
using System.Collections.Generic;
namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingrese los numeros que desee y 0 para finalizar los ingresos");
            int ingresos = 0;
            int seguir = 1;
            while(seguir != 0){
                ingresos = Int32.Parse(Console.ReadLine());
                switch(ingresos){
                    case 0:
                        seguir = 0;
                        break;
                    default:
                        numeros.Add(ingresos);
                        break;
                }
            }

            Console.WriteLine("Los numeros ingresados fueron:");
            numeros.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\nDe ellos, la cantidad de impares es:");
            Console.WriteLine(numeros.Count(x => x % 2 != 0));

            Console.WriteLine("\nEl primer par es:");
            Console.WriteLine(numeros.First(x => x % 2 == 0));

            Console.WriteLine("\nLos numeros mayores a 50 son:");
            numeros.Where(x => x > 50).ToList().ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\nSiendo un total de:");
            Console.WriteLine(numeros.Count(x => x > 50) + " numeros mayores a 50");
        }
    }
}
