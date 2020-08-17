namespace Ejercicio
{
    public class Sables : Arma
    {
        public Sables(int potencia, int desgaste, int cantidadDeUsos) : base(potencia, desgaste, cantidadDeUsos)
        {
        }
        public override int poder(){
            return potencia * cantidadDeUsos * 2;
        }       

    }
}