using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();

            int opcion = 0;
            
            while (opcion < 5){
                Console.WriteLine("[1]Noche de Sustos\n[2]Noche de Risas\n[3]Generar una lista de Respetables\n[4]Energia generada");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion){
                    case 1:
                        empresa.NocheDeSustos();
                        break;
                    case 2:
                        empresa.NocheDeRisas();
                        break;
                    case 3:
                        empresa.Respetables();
                        break;
                    case 4:
                        Console.WriteLine("La energia generada es: " + empresa.energia());
                        break;
                }
            }
        }
    }
}
