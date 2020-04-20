using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {

            int opcion = 0, num, num1;
            Matematica calculadora = new Matematica();

            while (opcion != 6){

                Console.WriteLine("Eliga una opcion:\n\t1)Fibonacci\n\t2)Factorial\n\t3)Mayor de dos numeros\n\t4)Menor de dos numeros\n\t5)Cubo de un numero\n\t6)Salir");
                opcion = Int32.Parse(Console.ReadLine());

                switch(opcion){
                    case 1:

                        Console.WriteLine("Ingrese la cantidad de numeros para mostrar en la secuencia");
                        num = Int32.Parse(Console.ReadLine());
                        calculadora.Fibonacci(num);
                        break;

                    case 2:

                        Console.WriteLine("Ingrese un numero para saber su factorial");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es:"+calculadora.Factorial(num));
                        break;

                    case 3:

                        Console.WriteLine("Ingrese dos numeros para saber el mayor");
                        num = Int32.Parse(Console.ReadLine());
                        num1 = Int32.Parse(Console.ReadLine());

                        if (calculadora.Mayor(num,num1)){
                            Console.WriteLine("El mayor es:"+num);
                        }else{
                            Console.WriteLine("El mayor es:"+num1);
                        }
                        
                        break;

                    case 4:

                        Console.WriteLine("Ingrese dos numeros para saber el menor");
                        num = Int32.Parse(Console.ReadLine());
                        num1 = Int32.Parse(Console.ReadLine());
                        
                        if (calculadora.Menor(num,num1)){
                            Console.WriteLine("El menor es:"+num1);
                        }else{
                            Console.WriteLine("El menor es:"+num);
                        }

                        break;

                    case 5:

                        Console.WriteLine("Ingrese un numero para saber el cubo");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El cubo es:"+calculadora.Cubo(num));
                        break;
                }
            }
            
        }
    }
}
