﻿using System;
using System.Linq;
namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliteca peliculas = new Peliteca();
            string opcion = "";
            string busqueda;

            while (opcion != "7"){
                Console.WriteLine("[1]Buscar por Genero\n"+
                                  "[2]Buscar por nombre\n"+
                                  "[3]Buscar por año\n"+
                                  "[4]Buscar por director\n"+
                                  "[5]Cantidad de peliculas\n"+
                                  "[6]Cantidad de peliculas segun genero\n"+
                                  "[7]Salir\n");
                opcion = Console.ReadLine();
                switch(opcion){
                    case "1":
                        Console.WriteLine("Ingrese el genero de la pelicula que busca");
                        busqueda = Console.ReadLine();
                        peliculas.Buscador(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre de la pelicula que busca");
                        busqueda = Console.ReadLine();
                        peliculas.Buscador(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el año de la pelicula que busca");
                        busqueda =Console.ReadLine();
                        peliculas.Buscador(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el nombre y apellido del director de la pelicula que busca");
                        busqueda = Console.ReadLine();
                        peliculas.Buscador(busqueda, opcion).ForEach(i => Console.WriteLine(i));
                        break;
                    case "5":
                        Console.WriteLine("La cantidad de peliculas es: " + peliculas.CantidadDePeliculas());
                        break;

                    case "6":
                        Console.WriteLine("Ingrese el genero para saber la cantidad de peliculas que posee");
                        busqueda = Console.ReadLine();
                        Console.WriteLine("La cantidad de peliculas que posee ese genero es: " + peliculas.CantidadDePeliculasPorGenero(busqueda));
                        break;
                }
            } 
        }
    }
}
