namespace E5
{
    public class Humano : SerPensante
    {

        public Humano (int inteligencia) : base(inteligencia)
        {
        }
        public override void pensar(string tema)
        {
            for (int i = conocimientos.Count; i == conocimientos.Count-5; i--){
                if(conocimientos[i] == tema) inteligencia += 5;
            }
        }
        public override void estudiar(string conocimientoNuevo)
        {
            conocimientos.Add(conocimientoNuevo);
            foreach (var i in intereses){
                if (conocimientoNuevo == i) inteligencia++;
            }
        }

    }
}