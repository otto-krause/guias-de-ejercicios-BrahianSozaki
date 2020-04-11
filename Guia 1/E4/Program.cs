using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {

            Gatito gato = new Gatito ("Umbra", true, 100);

            int opcion = 0;

            while (opcion != 6){

                Console.WriteLine("[1]Nombre del gatito\n[2]Saber si esta o no vacunado\n[3]Jugar\n[4]Comer\n[5]Saber si esta saludable\n[6]Salir");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion){

                    case 1:
                        Console.WriteLine(gato.Nombre());
                        break;

                    case 2:
                        if(gato.EstaVacunado()){
                            Console.WriteLine("Esta vacunado");
                        }else{
                            Console.WriteLine("No esta vacunado");
                        }
                        break;

                    case 3:
                        int minutos;
                        Console.WriteLine("Ingrese los minutos de juego");
                        minutos = Int32.Parse(Console.ReadLine());
                        gato.jugar(minutos);
                        break;

                    case 4:
                        gato.Comer();
                        break;

                    case 5:
                        if(gato.estaSaludable()){
                            Console.WriteLine("Esta saludable");
                        }else{
                            Console.WriteLine("No esta saludable");
                        }
                        break;

                }

            }

        }
    }
}
