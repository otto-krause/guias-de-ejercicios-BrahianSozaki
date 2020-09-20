namespace Ejercicio
{
    public class Terence : Pajaros
    {
        private int cantidadDeEnojos;
        public Terence( int ira) : base(ira)
        {
        }
        public override void seEnoja() => cantidadDeEnojos++;
        public override int fuerza(){
            return ira * cantidadDeEnojos * 10;
        }
    }
}