namespace Ejercicio
{
    public class Abuelos : Adultos
    {
        public override int seAsusta(Niño niño){
            AdultosComunes adultoComun = new AdultosComunes();
            return adultoComun.seAsusta(niño) / 2;
        }
    }
}