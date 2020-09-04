namespace Ejercicio
{
    public class SpidermanNoir : SpidermanClasico
    {
        private int resistencia;
        private int cantidadDeArmas;

        public SpidermanNoir(int resistencia, int cantidadDeArmas, int fuerza) : base(fuerza)
        {
            this.resistencia = resistencia;
            this.cantidadDeArmas = cantidadDeArmas;
        }

        public override int poder(){
            return fuerza + resistencia + cantidadDeArmas;
        }
    }
}