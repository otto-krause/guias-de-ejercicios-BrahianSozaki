using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int num = 1, count = 0;

            Console.WriteLine("Ingrese sus numeros o ingrese 0 para salir");

            while (num != 0)
            {

                num = Int32.Parse(Console.ReadLine());

                if (num != 0) numeros.Add(num);

                if (num > 50)
                {

                    count++;

                }

            }

            Console.WriteLine("Sus numeros son: ");

            foreach (var i in numeros)
            {

                Console.WriteLine(i);

            }

            int Cantidad_De_Numeros = numeros.Count;

            Console.WriteLine("Se ingresaron: " + Cantidad_De_Numeros + " numeros");

            Console.WriteLine("El primer numero es: " + numeros[0]);

            Console.WriteLine("El ultimo numero es: " + numeros[Cantidad_De_Numeros - 1]);

            Console.WriteLine("La cantidad de numeros mayores a 50 son: " + count);

        }
    }
}
