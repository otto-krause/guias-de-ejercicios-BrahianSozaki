using System;

namespace Programas
{
    class Program
    {  

        static bool par(int num){
            return num%2==0;
        }

        static bool primo(int num){
            
            int a = 0;
            for (int i = 1; i < (num + 1); i++) {
                if (num % i == 0) {
                    a++;
                }
            }
            
            return a<3;

        }

        static void Main(string[] args)
        {

            int num = 0;
            Console.WriteLine("Ingrese un numero: ");
            num = Int32.Parse(Console.ReadLine());
            
            if(par(num)){
                Console.WriteLine("El numero es par\n");
            }
            
            if(primo(num)){
                Console.WriteLine("El numero es primo\n");
            }

        }
    }
}
