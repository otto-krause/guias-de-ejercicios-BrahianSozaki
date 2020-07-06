namespace E6
{
    public class Pelicula
    {
        private string nombre;
        public string Nombre { get => nombre; }
        private string genero;
        public string Genero { get => genero; }
        private string año;
        public string Año { get => año; }
        private string director;
        public string Director { get => director; }

        public Pelicula (string nombre, string genero, string año, string director){
            this.nombre = nombre;
            this.genero = genero;
            this.año = año;
            this.director = director;
        }
        public string getDescripcion(){
            return "Titulo: " + this.nombre + "\nGenero: " + this.genero + "\nAño: " + this.año + "\nDirector: " + this.director + "\n";
        }
    }
}