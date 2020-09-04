namespace Ejercicio
{
    public class PeterParker : SpidermanClasico
    {

        private int resistencia;

        public PeterParker(int resistencia, int fuerza) : base(fuerza){
            this.resistencia = resistencia;
        }

        public override int poder(){
            return fuerza + resistencia;
        }
    }
}