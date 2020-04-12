using System;

namespace Programas
{
    class Program
    {  

        static void Main(string[] args)
        {

            Celular celular = new Celular(true,true,20000,2);

            Console.WriteLine("La cantidad de memoria disponible es:"+celular.MemoriaDisponible());
            if (celular.TeCargaLaSube()){
                Console.WriteLine("Si te carga la sube");
            }else{
                Console.WriteLine("No te carga la sube");
            }
            
        }
    }
}