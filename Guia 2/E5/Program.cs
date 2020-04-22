using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermercado supermercado = new Supermercado();
            Console.WriteLine("Las ganancias de hoy son: " + supermercado.Ganancias());
        }
    }
}
