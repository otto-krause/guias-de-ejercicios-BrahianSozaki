namespace Ejercicio
{
    public class ParedPiedra : Pared
    {
        public ParedPiedra(int anchoPared) : base(anchoPared){}
        public override int resistenciaDelObstaculo()
        {
            return 50 * anchoPared;
        }
    }
}