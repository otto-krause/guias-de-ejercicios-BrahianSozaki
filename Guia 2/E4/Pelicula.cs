namespace E4
{
    public class Pelicula
    {
        string nombre;
        string genero;
        string año;
        string director;

        public Pelicula (string nombre, string genero, string año, string director){
            this.nombre = nombre;
            this.genero = genero;
            this.año = año;
            this.director = director;
        }

        public string getGenero(){
            return genero;
        }

        public string getNombre(){
            return nombre;
        }

        public string getAño(){
            return año;
        }

        public string getDirector(){
            return director;
        }

    }
}