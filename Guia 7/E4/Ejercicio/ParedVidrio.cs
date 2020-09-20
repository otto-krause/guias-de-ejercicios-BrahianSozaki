namespace Ejercicio
{
    public class ParedVidrio : Pared
    {
        public ParedVidrio(int anchoPared) : base(anchoPared){}
        public override int resistenciaDelObstaculo()
        {
            return 10 * anchoPared;
        }
    }
}