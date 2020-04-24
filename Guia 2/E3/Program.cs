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

            while (posicion != "Salir"){
                
                Console.WriteLine("Ingrese \"Delantero\" para saber la cantidad de delanteros\n\"Medio Campista\" para saber la cantidad de medio campsitas\nSi desea salir ingrese \"Salir\"");
                posicion = Console.ReadLine();
                if (posicion != "Salir") Console.WriteLine("La cantidad de "+ posicion + " es: "+ figurita.Contador(posicion));
            }

            if (figurita.EstaCompleto()) Console.WriteLine("¡¡El album esta completo!!");

        }
    }
}
