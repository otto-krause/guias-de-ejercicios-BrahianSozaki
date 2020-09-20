namespace Ejercicio
{
    public abstract class Pajaros
    {
        protected int ira;
        protected Pajaros(int ira)
        {
            this.ira = ira;
        }
        public abstract int fuerza();
        public void reducirIra() => ira -= 5;
        public abstract void seEnoja();
    }
}