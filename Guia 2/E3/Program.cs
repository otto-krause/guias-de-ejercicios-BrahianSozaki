using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nombre;
            string posicion;
            string pais;
            int numeroDeLaFigurita;
            int[] count = new int[2];

            Console.WriteLine ("Ingrese los datos de la figurita");

            Console.WriteLine ("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine ("Posicion: ");
            posicion = Console.ReadLine();
            Console.WriteLine ("Pais: ");
            pais = Console.ReadLine();
            Console.WriteLine ("Numero de la figurita: ");
            numeroDeLaFigurita = Int32.Parse(Console.ReadLine());

            Album figurita = new Album ();

            if (figurita.apareceEnElAlbum(numeroDeLaFigurita)) Console.WriteLine("La figurita esta en el album");
            else figurita.ingreso(nombre,posicion,pais,numeroDeLaFigurita);

            for (int i = 0; i < 2; i++){
                count[i] = figurita.DelanterosMedioCampistas(i);
                if (i == 0) Console.WriteLine("La cantidad de delanteros es: "+ count[i]);
                else Console.WriteLine("La cantidad de medio campistas es: "+ count [i]);
            }

            if (figurita.EstaCompleto()) Console.WriteLine("¡¡El album esta completo!!");

        }
    }
}
