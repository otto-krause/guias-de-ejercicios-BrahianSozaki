namespace Ejercicio
{
    public class PajarosComunes : Pajaros
    {
        public PajarosComunes(int ira) : base(ira)
        {
        }
        public override int fuerza(){
            return ira * 2;
        }
        public override void seEnoja() => ira++;
    }
}