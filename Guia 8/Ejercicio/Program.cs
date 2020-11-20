using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar peliculas.
            string opcion = "";
            Peliculas peliculas = new Peliculas();//Investigar porque no funciona sin 
            string pelicula;
            StreamWriter fichero;
            fichero = File.CreateText("peliculas.txt");
            while (opcion!="Salir"){
                Console.WriteLine("Opciones:\n'Ingresar'  'Ver' 'Ver Filtrado' 'Buscar'");
                opcion = Console.ReadLine();
                switch (opcion){
                    case "Ingresar":
                            Console.WriteLine("Ingrese el nombre de las peliculas");
                            do{

                                pelicula = Console.ReadLine();           
                                if(pelicula != "Salir") fichero.WriteLine(pelicula);

                            }while(pelicula != "Salir");

                            fichero.Close();

                            break;
                    case "Ver":
                            Console.WriteLine("Las peliculas son:");
                            peliculas.verLasPeliculas().ForEach(i => Console.WriteLine(i));
                            break;
                    case "Ver Filtrado":
                            Console.WriteLine("Las peliculas filtradas son:");
                            peliculas.verLasPeliculasFiltradas().ForEach(i => Console.WriteLine(i));
                            break;
                    case "Buscar":
                            StreamReader ficheroa;
                            ficheroa = File.OpenText("Peliculas");
                            do{
                                Console.WriteLine("Ingrese el nombre que busca o Salir para terminar la busqueda");
                                pelicula = Console.ReadLine();
                                string aux = "";
                                switch (pelicula){
                                    case "Salir":
                                            fichero.Close();
                                            Console.WriteLine("Cerrado Correctamente");
                                            break;
                                    default:
                                        do{
                                            aux = ficheroa.ReadLine();
                                            if (pelicula == aux)
                                                Console.WriteLine("La pelicula:\n" + pelicula + ". Fue encontrada");
                                            else
                                                Console.WriteLine("No se encontro la pelicula");
                                        }while (aux != null);
                                        break;
                                }
                                //peliculas.buscador(pelicula);
                            }while(pelicula != "Salir");
                            break;
                            
                }
                
            }

        }
    }
}