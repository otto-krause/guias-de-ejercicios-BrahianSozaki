using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {

            Gatito umbra = new Gatito ("Umbra", true, 100);

            Console.WriteLine(umbra.Nombre());

            if(umbra.EstaVacunado()){
                Console.WriteLine("Esta vacunado");
            }else{
                Console.WriteLine("No esta vacunado");
            }

            umbra.jugar(5);
            umbra.Comer();

            if(umbra.estaSaludable()){
                Console.WriteLine("Esta saludable");
            }else{
                Console.WriteLine("No esta saludable");
            }

        }
    }
}
