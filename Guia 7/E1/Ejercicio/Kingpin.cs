namespace Ejercicio
{
    public class Kingpin
    {
        private int vida;
        public int Vida { get => vida; }
        public Kingpin()
        {
            this.vida = 800;
        }

        public bool fueVencido(){
            return vida <= 0;
        }
        public void reducirVida(int poder) => vida -= poder;
    }
}