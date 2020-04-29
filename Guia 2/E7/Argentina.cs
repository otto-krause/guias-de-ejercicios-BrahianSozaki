using System.Collections.Generic;
using System;
namespace E7
{
    public class Argentina
    {

        List<Alfajor> alfajores = new List<Alfajor>();

        public Argentina(){
            Alfajor alfajor1 = new Alfajor("Triple fruta", 100, "Waymayen");
            Alfajor alfajor2 = new Alfajor("Triple chocolate", 50, "Capitan del Espacio");
            Alfajor alfajor3 = new Alfajor("Triple chocolate blanco", 37, "Jorgito");
            alfajores.Add(alfajor1);
            alfajores.Add(alfajor2);
            alfajores.Add(alfajor3);
        }
        public void bajarElPrecioDelPetroleo(){
            foreach (var i in alfajores){
                i.Aumentos(1);
                Console.WriteLine(i.Precio);
            }
        }

        public void milllaiHablaPorTv(){
            foreach (var i in alfajores){
                i.Aumentos(2);
                Console.WriteLine(i.Precio);
            }
        }
        public void CoronaVairas(){
            foreach (var i in alfajores){
                i.Aumentos(3);
                Console.WriteLine(i.Precio);
            }
        }

        public int inflacion(){
            int suma = 0;
            foreach (var i in alfajores){
                suma += i.Precio;
            }
            return suma;

        }
    }
}