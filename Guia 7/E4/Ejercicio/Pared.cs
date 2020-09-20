namespace Ejercicio
{
    public class Pared : Obstaculo
    {
        protected int anchoPared;

        public Pared(int anchoPared)
        {
            this.anchoPared = anchoPared;
        }
        public override int resistenciaDelObstaculo(){
            return 1;
        }
    }
}