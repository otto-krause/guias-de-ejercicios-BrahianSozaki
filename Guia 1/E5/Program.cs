using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {

            double lado, lado1, lado2;

            Console.WriteLine("Ingrese los 3 lados del triangulo: ");
            lado = Double.Parse(Console.ReadLine());
            lado1 = Double.Parse(Console.ReadLine());
            lado2 = Double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(lado,lado1,lado2);

            if (triangulo.EsEscaleno()){
                Console.WriteLine("Es un triangulo escaleno\n");
            }

            if (triangulo.EsIsosceles()){
                Console.WriteLine("Es un triangulo Isosceles\n");
            }
            
            if (triangulo.EsEquilatero()){
                Console.WriteLine("Es un triangulo equilatero\n");
            }

            if (triangulo.EsTrianguloRectangulo()){
                Console.WriteLine("Es un triangulo rectangulo");
            }

        }
    }
}