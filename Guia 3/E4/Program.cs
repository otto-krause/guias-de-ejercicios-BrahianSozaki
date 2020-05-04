using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            TragaLibros Jimmy = new TragaLibros();
            TragaLibros Joseph = new TragaLibros();
            TragaLibros Juan = new TragaLibros();

            string opcion = "";
            string titulo;
            string autor;
            string nombre;

            while (opcion != "Salir")
            {
                Console.WriteLine(
                "[1]Ingresar lectura nueva\n" +
                "[2]CI de Jimmy\n" +
                "[3]CI de Joseph leyo\n" +
                "[4]CI de Juan leyo");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el titulo, el autor del libro y quien lo leyo");
                        titulo = Console.ReadLine();
                        autor = Console.ReadLine();
                        nombre = Console.ReadLine();
                        Libro libro = new Libro(titulo, autor);
                        switch (nombre)
                        {
                            case "Jimmy":
                                Jimmy.Leer(libro);
                                break;
                            case "Joseph":
                                Joseph.Leer(libro);
                                break;
                            case "Juan":
                                Juan.Leer(libro);
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("El CI de Jimmy es: " + Jimmy.CalcularCI());
                        break;

                    case "3":
                        Console.WriteLine("El CI de Joseph es: " + Joseph.CalcularCI());
                        break;

                    case "4":
                        Console.WriteLine("El CI de Juan es: " + Juan.CalcularCI());
                        break;
                        
                    default:
                        opcion = "Salir";
                        break;
                }
            }
        }
    }
}
