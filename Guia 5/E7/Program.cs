using System;
using System.Linq;
using System.Collections.Generic;
namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Fotos> fotos = new List<Fotos>();
            Fotos foto1 = new Fotos("C:/Users/usuario/Desktop/Image","7/7/2020","Brahian, Johann, Venialgo");
            fotos.Add(foto1);
            Fotos foto2 = new Fotos("C:/Users/usuario/Desktop/Imagen2","8/6/2020","Brahian, Johann");
            fotos.Add(foto2);
            Fotos foto3 = new Fotos("C:/Users/usuario/Desktop/Brahian Bebe","5/4/2005","Brahian");
            fotos.Add(foto3);

            string n1,n2;

            Console.WriteLine("Ingrese el nombre de las personas que quiere saber en que fotos estan etiquetadas");
            n1 = Console.ReadLine();
            n2 = Console.ReadLine();

            List<Fotos> etiquetados = fotos.Where(i => i.PersonasEtiquetadas.Contains(n1)).ToList();
            etiquetados = etiquetados.Where(i => i.PersonasEtiquetadas.Contains(n2)).ToList();
            etiquetados.ForEach(i => Console.WriteLine("Directorio: " + i.DirectorioDeAlmacenamiento + 
            "\nFecha de creacion: " + i.FechaDeCreacion +
            "\nPersonas Etiquetadas: " + i.PersonasEtiquetadas));

            

        }
    }
}
