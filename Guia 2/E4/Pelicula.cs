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

        public string getDescripcion(){
            return "Titulo: " + this.nombre + "\nGenero: " + this.genero + "\nAño: " + this.año + "\nDirector: " + this.director + "\n";
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