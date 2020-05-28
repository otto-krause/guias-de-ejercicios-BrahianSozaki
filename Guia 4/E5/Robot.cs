namespace E5
{
    public class Robot : SerPensante
    {

        public Robot (int inteligencia) : base(inteligencia)
        {
        }
        public override void pensar()
        {
            inteligencia += conocimientos.Count;
        }
        public override void estudiar (string conocimientoNuevo)
        {
            conocimientos.Add(conocimientoNuevo);
        }
    }
}