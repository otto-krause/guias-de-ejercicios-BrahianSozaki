namespace Ejercicio
{
    public class Blasters : Arma
    {
        public Blasters(int potencia, int desgaste, int cantidadDeUsos) : base(potencia, desgaste, cantidadDeUsos)
        {
        }
        public override int poder()
        {
            if (potencia > cantidadDeUsos) return potencia - cantidadDeUsos;
            else return 1;
        }
    }
}