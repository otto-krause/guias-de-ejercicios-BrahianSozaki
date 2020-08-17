namespace Ejercicio
{
    public abstract class Arma
    {
        protected int potencia;
        protected int desgaste;
        protected int cantidadDeUsos;
        protected Arma(int potencia, int desgaste, int cantidadDeUsos)
        {
            this.potencia = potencia;
            this.desgaste = desgaste;
            this.cantidadDeUsos = cantidadDeUsos;
        }

        public abstract int poder();
    }
}