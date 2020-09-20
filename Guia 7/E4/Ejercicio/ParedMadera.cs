namespace Ejercicio
{
    public class ParedMadera : Pared
    {
        public ParedMadera(int anchoPared) : base(anchoPared){}
        public override int resistenciaDelObstaculo()
        {
            return 25 * anchoPared;
        }
    }
}