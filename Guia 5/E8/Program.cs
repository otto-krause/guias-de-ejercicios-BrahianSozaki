using System;
using System.Collections.Generic;
using System.Linq;
namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(2);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(4);
            numeros.Add(6);
            numeros.Add(8);
            numeros.Add(4);
            numeros.Add(7);
            Matematicas2 matematicas = new Matematicas2(numeros);

            string opcion = "";

            while(opcion != "8"){
                Console.WriteLine("[1]Saber los numeros primos de la lista\n"+
                                  "[2]Saber los numeros pares de la lista\n"+
                                  "[3]Mostrar la lista sin repetidos\n"+
                                  "[4]Sumatoria de los numeros\n"+
                                  "[5]Sumatoria de los numeros primos\n"+
                                  "[6]El numero mas grande\n"+
                                  "[7]El numero mas chico\n"+
                                  "[8]Salir");
                opcion = Console.ReadLine();

                switch(opcion){
                    case "1":
                        Console.WriteLine("Numeros Primos:\n");
                        matematicas.primos().ForEach(i => Console.WriteLine(i));
                        break;
                    case "2":
                        Console.WriteLine("\nNumeros Pares:\n");
                        matematicas.pares().ForEach(i => Console.WriteLine(i));
                        break;
                    case "3":
                        Console.WriteLine("\nLista sin repeticiones:\n");
                        matematicas.aplanar().ForEach(i => Console.WriteLine(i));
                        break;
                    case "4":
                        Console.WriteLine("\nSumatoria de los numeros:\n");
                        Console.WriteLine(matematicas.suma());
                        break;
                    case "5":
                        Console.WriteLine("\nSumatoria de los numeros primos:\n");
                        Console.WriteLine(matematicas.sumaPrimos());
                        break;
                    case "6":
                        Console.WriteLine("\nEl numero mas grande:\n");
                        Console.WriteLine(matematicas.mayor());
                        break;
                    case "7":
                        Console.WriteLine("\nEl numero mas chico:\n");
                        Console.WriteLine(matematicas.menor());
                        break;
                }
            }
        }
    }
}
