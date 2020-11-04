namespace Ejercicio
{
    public class Villano : Persona
    {
        bool roboEnOnce;
        bool nuncaTrabajo;
        bool leGustaLaPizzaConPiña;

        public Villano(bool roboEnOnce, bool nuncaTrabajo, bool leGustaLaPizzaConPiña, Quirk quirk) : base(quirk)
        {
            this.roboEnOnce = roboEnOnce;
            this.nuncaTrabajo = nuncaTrabajo;
            this.leGustaLaPizzaConPiña = leGustaLaPizzaConPiña;
        }

        public bool esMuyMalo(){
            return roboEnOnce && nuncaTrabajo && leGustaLaPizzaConPiña;
        }
        public bool algunaVezFueBueno(){
            return !esPeligroso() && !nuncaTrabajo;
        }
    }
}