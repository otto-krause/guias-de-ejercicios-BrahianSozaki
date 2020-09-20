namespace Ejercicio
{
    public class Chuck : Pajaros
    {
        private int velocidad;
        public Chuck(int velocidad, int ira) : base(ira)
        {
            this.velocidad = velocidad;
        }
        public override void seEnoja() => velocidad *= 2;
        public override int fuerza(){
            if(velocidad <= 80){
                return 150;
            }else{
                return 150 + 5 * (velocidad-80);
            }
        }
    }
}