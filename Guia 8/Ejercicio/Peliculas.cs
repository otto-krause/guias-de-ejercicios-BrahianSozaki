using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Peliculas
    {
        StreamReader fichero;
        List<string> peliculas;
        public Peliculas(){
            peliculas = new List<string>();
        }
        public List<string> verLasPeliculas(){
            //Ver peliculas
            peliculas.Clear();
            string aux;
            fichero = File.OpenText("peliculas.txt");
            do{
                aux = fichero.ReadLine();
                if (aux != null) peliculas.Add(aux);
            }while (aux != null);
            fichero.Close();
            return peliculas;
        }
        public List<string> verLasPeliculasFiltradas(){
            //Ver peliculas
            peliculas.Clear();
            string aux;
            List<string> peliculasFiltradas = new List<string>();
            fichero = File.OpenText("peliculas.txt");
            do{
                aux = fichero.ReadLine();
                if (aux != null) peliculas.Add(aux);
            }while (aux != null);
            peliculasFiltradas = peliculasFiltradas.Union(peliculas).ToList();
            fichero.Close();
            return peliculasFiltradas;
        }

        public string buscador(string busqueda){
            fichero = File.OpenText("Peliculas.txt");
            string aux = "";
            switch (busqueda){
                case "Salir":
                        fichero.Close();
                        return "Cerrado Correctamente";
                default:
                    do{
                        aux = fichero.ReadLine();
                        if (busqueda == aux)
                            return "La pelicula:\n" + busqueda + ". Fue encontrada";
                        else
                            return "No se encontro la pelicula";
                    }while (aux != null);
            }
        }

    }
}