namespace Ejercicio
{
    public class Red : Pajaros
    {
        private int cantidadDeEnojos;
        public Red(int ira) : base(ira)
        {
        }
        public override void seEnoja() => cantidadDeEnojos++;
        public override int fuerza(){
            return ira*10*cantidadDeEnojos;
        }
    }
}