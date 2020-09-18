using System.Collections.Generic;
namespace Ejercicio
{
    public class AdultosComunes : Adultos
    {
        private int tolerancia;
        List<Niño> niños;

        public AdultosComunes()
        {
            niños = new List<Niño>();
        }

        public int Tolerancia { get => tolerancia; }
        public override int seAsusta(Niño niño){
            int caramelos = 0;
            if (tolerancia < niño.capacidadDeSusto()){
                caramelos = tolerancia / 2;
                if (niño.cantidadDeCaramelos() > 15) niños.Add(niño);
                tolerancia = 10 * niños.Count;
            }
            return caramelos;
        }
    }
}