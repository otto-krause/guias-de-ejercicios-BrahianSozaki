namespace Ejercicio
{
    public class ChicoBestia : Titan
    {
        string color;
        public ChicoBestia(int tristeza) : base(tristeza)
        {
            this.color = "Verde";
        }
        public int NivelDeTristeza(){
            return tristeza;
        }
        public void cambiarDeColor(string color){
            this.color = color;
            tristeza += 4;
        }
        public override void comerPizza() => color = "Amarillo patito fluorescente de las montañas del himalaya amazonico";
        public override void llorarPorRobocop(){
            if(tristeza > 7) tristeza -= 8;
            else tristeza -= tristeza;
        }
        public override bool estaTriste(){
            return tristeza > 5;
        }
        public override int poder(){
            return color.Length * 13;
        }
    }
}