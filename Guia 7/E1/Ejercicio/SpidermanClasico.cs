namespace Ejercicio
{
    public abstract class SpidermanClasico
    {
        protected int fuerza;

        protected SpidermanClasico(int fuerza)
        {
            this.fuerza = fuerza;
        }

        public abstract int poder();
        public void atacar(Kingpin kingpin) => kingpin.reducirVida(poder());
    }
}