namespace E1
{
    public class Pajaro : Animales
    {
        public Pajaro(int energia) : base(energia)
        {

        }
        public override void comer() => energia += 10;
        public override void jugar(){
            if (energia >= 0) energia -= 5;
        }
    }
}