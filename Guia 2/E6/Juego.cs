using System.Collections.Generic;

namespace E6
{
    public class Juego
    {
        private string titulo;
        public string Titulo { get => titulo; }
        private string genero;
        public string Genero { get => genero; }

        List<Reseñas> reseña = new List<Reseñas>();

        public Juego(string titulo, string genero, int estrellas, string comentario)
        {
            this.titulo = titulo;
            this.genero = genero;
            Reseñas r = new Reseñas(estrellas, comentario);
            reseña.Add(r);
        }

        public int getEstrellas(List<string> titulos){//Ver porque no me permite hacer que la lista pertenezca a juegos y funcione correctamente cargando todos los titulos.
            int count = 0;
            foreach (var i in reseña){
                foreach (var j in titulos){
                    if (titulo == j){
                        count++;
                    }
                }
                return i.Estrellas / count++;
            }

            return 0;
        }

        public string Descripcion(){
            foreach (var i in reseña)
                return "Titulo: " + this.titulo + "\nGenero: " + this.genero + "\nCalificacion: " + i.Estrellas + "\nComentario: " + i.Reseña;

            return "No se encontro ningun juego";
        }

    }
}