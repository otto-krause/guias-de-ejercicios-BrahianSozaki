using System;
using System.Collections.Generic;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto = "Leche la Martona";
            int cantidadDelProducto = 2;//Simulo el ingreso del usuario
            
            Supermercado compra = new Supermercado(producto, cantidadDelProducto);
            Console.WriteLine("Las ganancias de hoy son: " + compra.Ganancias());  
            
        }
    }
}
