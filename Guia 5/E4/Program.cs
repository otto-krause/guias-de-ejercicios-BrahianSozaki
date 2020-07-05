using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string especialidadRequerida;

            Console.WriteLine("Ingrese la especialidad del medico del cual quiere sacar turno (Traumatologia o Dermatologia)");

            especialidadRequerida = Console.ReadLine();

            Clinica pedido = new Clinica(especialidadRequerida);

            Console.WriteLine(pedido.DisponibilidadDelMedico());
        }
    }
}
