using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcion = 0;
            string buscar = "";
            Steam steam = new Steam();
            while (opcion != 3){
                Console.WriteLine("\n[1]Buscar por Genero\n[2]Buscar por Calificacion\n[3]Salir");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion){
                    case 1:
                        Console.WriteLine("Ingrese el genero que busca");
                        buscar = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la calificacion (Alta(4-5)-Media(3)-Baja(1-2))");
                        buscar = Console.ReadLine();
                        break;
                }

                if (opcion != 3){
                    foreach (var i in steam.Buscador(buscar, opcion)){
                        Console.WriteLine("\n" + i);
                    }
                }
            }

        }
    }
}
