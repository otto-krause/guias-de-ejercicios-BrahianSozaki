using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            FalconArmor falconArmor = new FalconArmor();
            ShadowArmor shadowArmor = new ShadowArmor();
            X x = new X();

            string opcion = "";
            int minutosEntrenados;
            while (opcion != "Salir"){
                Console.WriteLine(
                    "[1]Fuerza de X\n"+
                    "[2]Entrenar\n"+
                    "[3]Cambiar armadura a la Falcon Armor\n"+
                    "[4]Cambiar armadura a la Shadow Armor\n"+
                    "[5]Salir");
                opcion = Console.ReadLine();

                switch (opcion){
                    case "1":
                        Console.WriteLine("La fuerza de x es: " + x.Fuerza());
                        break;
                    case "2":
                        Console.WriteLine("Ingrese la cantidad de minutos entrenados");
                        minutosEntrenados = Int32.Parse(Console.ReadLine());
                        x.Entrenamiento(minutosEntrenados);
                        break;
                    case "3":
                        x.CambiarArmadura(falconArmor);
                        break;
                    case "4":
                        x.CambiarArmadura(shadowArmor);
                        break;
                    default:
                        opcion = "Salir";
                        break;
                }
            }
        }
    }
}
