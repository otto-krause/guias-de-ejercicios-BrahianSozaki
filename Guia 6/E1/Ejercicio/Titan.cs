namespace Ejercicio
{
    public abstract class Titan
    {
        protected int tristeza;
        public Titan (int tristeza){
            this.tristeza = tristeza;
        }
        public abstract void comerPizza();
        public abstract void llorarPorRobocop();
        public abstract bool estaTriste();
        public abstract int poder();
    }
}