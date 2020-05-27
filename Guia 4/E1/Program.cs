using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animales perro = new Perro(100);
            Animales pajaro = new Pajaro(100);

            int opcion = 0;

            while(opcion <= 5){

                Console.WriteLine("[1]Darle de comer al Perro\n[2]Darle de comer al Pajaro\n[3]Jugar con el Perro\n[4]Jugar con el Pajaro\n[5]Los animales duermen");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion){
                    case 1:
                        perro.comer();
                        break;
                    case 2:
                        pajaro.comer();
                        break;
                    case 3:
                        perro.jugar();
                        break;
                    case 4:
                        pajaro.jugar();
                        break;
                    case 5:
                        perro.dormir();
                        pajaro.dormir();
                        break;
                }
                Console.WriteLine("El perro posee: " + perro.Energia + "de energia restante");
                Console.WriteLine("El pajaro posee: " + pajaro.Energia + "de energia restante");

            }
        }
    }
}
