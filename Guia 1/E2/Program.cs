using System;

namespace Programas
{
    class Program
    {  
        static void Main(string[] args)
        {

            int num = 0, num1 = 0, aux = 0, multi = 0, resto = 0;

            Console.WriteLine("Ingrese 2 numeros para multiplicar y dividir: ");
            num = Int32.Parse(Console.ReadLine());
            num1 = Int32.Parse(Console.ReadLine());

            while (aux != num1)
            {

                multi += num;
                aux += 1;

            }

            Console.WriteLine("El producto es: "+multi);
            aux=0;

            while (num >= num1){

                num-=num1;
                aux+=1;
                resto = num;

            }

            Console.WriteLine("El cociente es: "+aux+"\nEl resto es: "+resto);

        }
    }
}