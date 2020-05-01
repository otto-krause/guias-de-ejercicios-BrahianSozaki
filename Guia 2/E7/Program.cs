using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Argentina argentina = new Argentina();

            int opcion = 0;
            int suma;

            while (opcion != 5){
                Console.WriteLine("[1]Bajar el precio del petroleo\n[2]Millai habla por tv?\n[3]CoronaVairas\n[4]Saber inflacion\n[5]Salir");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion){
                    case 1:
                        argentina.bajarElPrecioDelPetroleo();
                        break;
                    case 2:
                        argentina.milllaiHablaPorTv();
                        break;
                    case 3:
                        argentina.CoronaVairas();
                        break;
                    case 4:
                        suma = argentina.inflacion();
                        if (suma < 500) Console.WriteLine("Estado: Inflacion normal");

                        else{

                            if(suma > 500 && suma < 1000) Console.WriteLine("Estado: Super Inflacion");

                            else Console.WriteLine("Estado: Hyper Infalcion\nLa Argentina esta en default");
                            
                        }
                        break;
                }

            }
        }
    }
}
