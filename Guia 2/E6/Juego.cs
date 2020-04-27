using System.Collections.Generic;

namespace E6
{
    public class Juego
    {
        private string titulo;
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

        public int getEstrellas(){
            foreach (var i in reseña)
                return i.Estrellas;

            return 0;
        }

        public string Descripcion(){
            foreach (var i in reseña)
                return "Titulo: " + this.titulo + "\nGenero: " + this.genero + "\nCalificacion: " + i.Estrellas + "\nComentario: " + i.Reseña;

            return "No se encontro ningun juego";
        }

    }
}