using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Matilda : Pajaros
    {
        private List<Huevo> huevos;
        public Matilda(int ira) : base(ira)
        {
            huevos = new List<Huevo>();
            Huevo huevo = new Huevo(1000);
            Huevo huevo1 = new Huevo(2000);
            huevos.Add(huevo);
            huevos.Add(huevo1);
        }
        public override void seEnoja(){
            Huevo huevo = new Huevo(2000);
            huevos.Add(huevo);
        }
        public override int fuerza(){
            int fuerzaDeLosHuevos = 0;
            huevos.ForEach(i => fuerzaDeLosHuevos += i.fuerza());
            return ira * 2 + fuerzaDeLosHuevos;
        }
    }
}