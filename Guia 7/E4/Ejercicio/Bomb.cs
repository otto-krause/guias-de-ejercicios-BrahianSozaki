namespace Ejercicio
{
    public class Bomb : Pajaros
    {
        public Bomb(int ira) : base(ira)
        {
        }
        public override int fuerza(){
            if (ira * 2 <= 9000){
                return ira * 2;
            }else{
                return 9000;
            }
            
        }
        public override void seEnoja() => ira++;
    }
}