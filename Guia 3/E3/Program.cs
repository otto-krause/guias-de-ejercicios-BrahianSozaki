using System;
using System.Collections.Generic;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int frecuencia;
            int precio;
            MotherBoard mother = new MotherBoard(3000);

            List<Componentes> componentes = new List<Componentes>();

            Console.WriteLine("Ingrese la frecuencia y precio de la ram");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio = Int32.Parse(Console.ReadLine());
            MemoriaRam ram = new MemoriaRam(frecuencia, precio);

            Console.WriteLine("Ingrese la frecuencia y precio del disco ssd");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio = Int32.Parse(Console.ReadLine());
            DiscoSSD ssd = new DiscoSSD(frecuencia, precio);

            Console.WriteLine("Ingrese la frecuencia y precio del disco hdd");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio = Int32.Parse(Console.ReadLine());
            DiscoHDD hdd = new DiscoHDD(frecuencia, precio);

            Console.WriteLine("Ingrese la frecuencia y precio de la placa de video");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio = Int32.Parse(Console.ReadLine());
            PlacaDeVideo placaDeVideo = new PlacaDeVideo(frecuencia, precio);

            Console.WriteLine("Ingrese la frecuencia y precio de la lectora de CD");
            frecuencia = Int32.Parse(Console.ReadLine());
            precio = Int32.Parse(Console.ReadLine());
            LectoraDeCD lectora = new LectoraDeCD(frecuencia, precio);

            componentes.Add(ram);
            componentes.Add(ssd);
            componentes.Add(hdd);
            componentes.Add(placaDeVideo);
            componentes.Add(lectora);

            PC pc = new PC(mother, componentes);

            Console.WriteLine("El precio total de esta pc es: " + pc.PrecioTotal());
            Console.WriteLine("Se puede armar?\n" + pc.SePuedeArmar());
        }
    }
}
