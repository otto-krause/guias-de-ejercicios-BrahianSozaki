using System.Collections.Generic;

namespace E4
{
    public class Peliteca
    {
        List<Pelicula> peliteca = new List<Pelicula>();
        Pelicula p1 = new Pelicula("Avengers EndGame", "Super Heroes", "2019", "Joe Russo");
        Pelicula p2 = new Pelicula("Toy Story 4", "Comedia", "2019", "Josh Cooley");
        Pelicula p3 = new Pelicula("El Viaje de Chihiro", "Fantasia", "2003", "Hayao Miyazaki");
        Pelicula p4 = new Pelicula("Avengers Age of Ultron", "Super Heroes", "2015", "Joss Whedon");
        Pelicula p5 = new Pelicula("Mi vecino Totoro", "Infantil", "1988", "Hayao Miyazaki");

        public Peliteca (){
            peliteca.Add(p1);
            peliteca.Add(p2);
            peliteca.Add(p3);
            peliteca.Add(p4);
            peliteca.Add(p5);
        }

        public string Buscador(string busqueda, int caso){
            string nombres = "No hay peliculas de lo que busca";
            switch (caso){
                case 1:
                    foreach(var i in peliteca){
                        if (i.getGenero() == busqueda){
                            nombres = i.getNombre();
                        }
                    }
                    break;
                case 2:
                    foreach(var i in peliteca){
                        if (i.getNombre() == busqueda){
                            nombres = i.getNombre();
                        }
                    }
                    break;
                case 3:
                    foreach(var i in peliteca){
                        if (i.getAño() == busqueda){
                            nombres = i.getNombre();
                        }
                    }
                    break;
                case 4:
                    foreach(var i in peliteca){
                        if (i.getDirector() == busqueda){
                            nombres = i.getNombre();
                        }
                    }
                    break;
            }
            return nombres;
        }

        public int getCantidadDePeliculas(){
            return peliteca.Count;
        }

        public int CantidadDePeliculasPorGenero(string genero){
            int count = 0;
            foreach(var i in peliteca){
                if (i.getGenero() == genero){
                    count++;
                }
            }
            return count;
        }

    }
}