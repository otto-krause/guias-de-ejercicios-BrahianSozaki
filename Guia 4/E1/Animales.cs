namespace E1
{
    public abstract class Animales
    {
        protected int energia;

        public int Energia { get => energia; }

        public Animales(int energia)
        {
            this.energia = energia;
        }

        public abstract void comer();
        public abstract void jugar();

        public void dormir(){
            energia = 100;
        }
    }
}