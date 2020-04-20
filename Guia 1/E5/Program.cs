using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {

            double lado, lado1, lado2;
            int opcion = 0;

            Console.WriteLine("Ingrese los 3 lados del triangulo: ");
            lado = Double.Parse(Console.ReadLine());
            lado1 = Double.Parse(Console.ReadLine());
            lado2 = Double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(lado,lado1,lado2);

            while (opcion != 5){

                Console.WriteLine("[1]Verificar Escaleno\n[2]Verificar Isosceles\n[3]Verificar Equilatero\n[4]Verificar triangulo Rectangulo\n[5]Salir");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion){

                    case 1:

                        if (triangulo.EsEscaleno()){
                            Console.WriteLine("Es un triangulo escaleno\n");
                        }else{
                            Console.WriteLine("No es un triangulo escaleno\n");
                        }
                        break;

                    case 2:

                        if (triangulo.EsIsosceles()){
                            Console.WriteLine("Es un triangulo Isosceles\n");
                        }else{
                            Console.WriteLine("No es un triangulo Isosceles\n");
                        }
                        break;
                    
                    case 3:

                        if (triangulo.EsEquilatero()){
                            Console.WriteLine("Es un triangulo equilatero\n");
                        }else{
                            Console.WriteLine("No es un triangulo equilatero\n");
                        }
                        break;

                    case 4:

                        if (triangulo.EsTrianguloRectangulo()){
                            Console.WriteLine("Es un triangulo rectangulo");
                        }else{
                            Console.WriteLine("No es un triangulo rectangulo");
                        }
                        break;

                }
                
            }

        }
    }
}