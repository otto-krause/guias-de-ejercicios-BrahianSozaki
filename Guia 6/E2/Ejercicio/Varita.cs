namespace Ejercicio
{
    public abstract class Varita
    {
        protected int potencia;
        protected Receta receta;

        protected Varita(int potencia, Receta receta)
        {
            this.potencia = potencia;
            this.receta = receta;
        }

        public abstract int tiempoParaLaReceta();
    }
}