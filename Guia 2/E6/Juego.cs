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
            reseña.Add(new Reseñas(estrellas, comentario));
        }

        public int getEstrellas(List<string> titulos){
            int count = 0;
            int acu = 0;
            foreach (var i in reseña){
                foreach (var j in titulos){
                    if (titulo == j){
                        count++;
                        acu = i.Estrellas;
                    }
                }
            }
            return acu / count++;
        }

        public string Descripcion(){
            int Estrellas = 0;
            string Reseña = "";
            foreach (var i in reseña){
                Estrellas = i.Estrellas;
                Reseña = i.Reseña;
            }

            return "Titulo: " + this.titulo + "\nGenero: " + this.genero + "\nCalificacion: " + Estrellas + "\nComentario: " + Reseña;
        }

    }
}