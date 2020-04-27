namespace E6
{
    public class Reseñas
    {
        private int estrellas;
        public int Estrellas { get => estrellas;}
        private string reseña;
        public string Reseña { get => reseña;}
        public Reseñas(int estrellas, string reseña)
        {
            this.estrellas = estrellas;
            this.reseña = reseña;
        }
        
    }
}