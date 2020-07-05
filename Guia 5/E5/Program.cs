using System;
using System.Collections.Generic;
using System.Linq;
namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> conocimientos = new List<string>();
            conocimientos.Add("Actuacion");
            conocimientos.Add("Manipulacion");
            conocimientos.Add("Historia");
            conocimientos.Add("Ciencias");
            conocimientos.Add("Videojuegos");
            conocimientos.Add("Programacion");

            //Ultimos 5 conocimientos.

            Console.WriteLine("Ultimos 5 conocimientos:\n");
            conocimientos.Reverse();
            List<string> aux = conocimientos.Take(5).ToList();
            aux.ForEach(i => Console.WriteLine(i));

            aux.Clear();//Borra el contenido de una lista. Lo uso para no crear varias listas auxiliares.

            //Primeros 4 conocimientos ordenados alfabeticamente.

            Console.WriteLine("\nPrimeros 4 ordenados alfabeticamente:\n");
            conocimientos.Reverse();
            aux = conocimientos.Take(4).OrderBy(n => n).ToList();
            aux.ForEach(i => Console.WriteLine(i));

            aux.Clear();

            //Cantidad de conocimientos con terminacion "cion"
            
            Console.WriteLine("\nCantidad de conocimientos con terminacion 'cion':\n");
            int count = conocimientos.Count(i => i.Contains("cion"));
            Console.WriteLine("Hay: " + count + " que tienen la terminacion 'cion'\nEsos conocimientos son:");
            aux = conocimientos.Where(i => i.Contains("cion")).ToList();
            aux.ForEach(i => Console.WriteLine(i));


        }
    }
}
