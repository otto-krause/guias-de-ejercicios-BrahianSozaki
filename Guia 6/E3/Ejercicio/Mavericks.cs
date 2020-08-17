namespace Ejercicio
{
    public class Mavericks
    {
        Arma arma;
        private int destreza;

        public Mavericks(Arma arma, int destreza)
        {
            this.arma = arma;
            this.destreza = destreza;
        }

        public int fuerza(){
            return arma.poder() + destreza;
        }

        public bool esDebil(){
            return fuerza() < 200;
        }
    }
}