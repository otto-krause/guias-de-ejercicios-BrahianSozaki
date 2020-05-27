namespace E2
{
    public class Amistosos : Monstruos
    {
        public Amistosos (int respeto) : base(respeto)
        {

        }
        public override void asustar() => respeto += 7;
        public override void reir() => respeto -= 1;
    }
}