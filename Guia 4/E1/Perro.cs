namespace E1
{
    public class Perro : Animales
    {
        public Perro(int energia) : base(energia)
        {

        }
        public override void comer() => energia += 15;
        public override void jugar(){
            if (energia >= 20) energia -= 20;
        }
    }
}