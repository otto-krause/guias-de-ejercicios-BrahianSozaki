namespace Ejercicio
{
    public class MilesMorales : SpidermanClasico
    {
        private int habilidadParaCantar;

        public MilesMorales(int habilidadParaCantar, int fuerza) : base(fuerza)
        {
            this.habilidadParaCantar = habilidadParaCantar;
        }

        public override int poder()
        {
            return fuerza + habilidadParaCantar;
        }
    }
}