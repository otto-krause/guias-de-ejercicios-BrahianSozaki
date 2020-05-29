using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            SerPensante robot = new Robot(50);
            SerPensante humano = new Humano(50);
            SerPensante cyborg = new Cyborg(50);
            string opcion = "";

            while (opcion != "Salir"){
                Console.WriteLine("[1]Hacer pensar al Robot\n[2]Hacer estudiar al Robot\n[3]Hacer pensar al Humano\n[4]Hacer estudiar al humano\n[5]Hacer pensar al Cyborg\n[6]Hacer estudiar al Cyborg");
                opcion = Console.ReadLine();
                switch (opcion){
                    case "1":
                        robot.pensar();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese que estudio");
                        opcion = Console.ReadLine();
                        robot.estudiar(opcion);
                        break;
                    case "3":
                        humano.pensar();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese que estudio");
                        opcion = Console.ReadLine();
                        humano.estudiar(opcion);
                        break;
                    case "5":
                        cyborg.pensar();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese que estudio");
                        opcion = Console.ReadLine();
                        cyborg.estudiar(opcion);
                        break;
                    default:
                        opcion = "Salir";
                        break;
                }
            }

        }
    }
}
