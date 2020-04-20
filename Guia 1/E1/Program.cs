using System;

namespace Programas
{
    class Program
    {  
        static void Main(string[] args)
        {

            int[] vect = new int[10];
            int suma = 0, menor = 10000, aux = 0;
            float prom = 0;

            Console.WriteLine("Ingrese sus numeros");

            for (int i = 0; i < 10; i++)
            {

                vect[i] = Int32.Parse (Console.ReadLine());
                suma += vect[i];

            }

            Console.WriteLine("La sumatoria es: "+suma);
            prom += suma/10;
            Console.WriteLine("El promedio es: "+prom);

            for (int i = 0; i < 10; i++)
            {

                if (menor > vect[i])
                {

                    menor = vect[i];

                }

            }

            for (int i = 0; i < 10; i++)
            {

                for (int j = 10-1; j >= i; j--)
                {

                    if (vect[j] > vect[i])
                    {

                        aux = vect[j];
                        vect[j] = vect[i];
                        vect [i] = aux;

                    }

                }

            }

            Console.WriteLine("El menor numero es: "+menor);

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Posicion: "+(i+1)+"\nNumero: "+vect[i]);

            }

        }
    }
}
