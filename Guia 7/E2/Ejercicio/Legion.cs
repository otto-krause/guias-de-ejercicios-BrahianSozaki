using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Legion : Malevolo
    {
        List<Niño> niños;
        public Legion(List<Niño> niños){
            this.niños = niños;
        }
        public void añadirIntegrantes(List<Niño> legion){
            legion.ForEach(i => niños.Add(i));
        }
        public int capacidadDeSusto(){
            int capacidadDeSustoGeneral = 0;
            niños.ForEach(i => capacidadDeSustoGeneral += i.capacidadDeSusto());
            return capacidadDeSustoGeneral;
        }
        public int cantidadDeCaramelos(){
            int cantidadGeneralDeCaramelos = 0;
            niños.ForEach(i => cantidadGeneralDeCaramelos += i.cantidadDeCaramelos());
            return cantidadGeneralDeCaramelos;
        }
        public void asustar(Adultos adulto){
            int caramelos = 0;
            niños.ForEach(i => caramelos += adulto.seAsusta(i));

            var lider = niños.Where(x => x.capacidadDeSusto() == niños.Max(i => i.capacidadDeSusto()));
            foreach (Niño niño in lider) niño.recibirCaramelos(caramelos);            
        }
    }
}