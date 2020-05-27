namespace E2
{
    public class Peligrosos : Monstruos
    {
        public Peligrosos (int respeto) : base(respeto)
        {
        }
        public override void asustar() => respeto += 5;
        public override void reir() => respeto -= 2;
    }
}