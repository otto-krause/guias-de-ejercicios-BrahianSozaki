using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {

            Celular celular = new Celular(true,true,20000,2);

            int opcion = 0;

            while (opcion != 3){

                Console.WriteLine("[1]Ver memoria disponible en el celular\n[2]Saber si te carga la sube\n[3]Salir");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    
                    case 1:
                        Console.WriteLine("La cantidad de memoria disponible es:"+celular.MemoriaDisponible());
                        break;

                    case 2:
                        if (celular.TeCargaLaSube()){
                            Console.WriteLine("Si te carga la sube");
                        }else{
                            Console.WriteLine("No te carga la sube");
                        }
                        break;
                        
                }

            }
            
        }
    }
}