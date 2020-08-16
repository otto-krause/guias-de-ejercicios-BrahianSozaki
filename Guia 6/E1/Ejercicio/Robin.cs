using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Robin : Titan
    {
        List<Arma> arsenal;
        int cantidadDePorciones;
        public Robin(List<Arma> arsenal, int tristeza) : base(tristeza)
        {
            this.cantidadDePorciones = 10;
            this.arsenal = arsenal;
        }
        public override void comerPizza() => tristeza -= 1 * cantidadDePorciones;
        public override void llorarPorRobocop() => tristeza += 6;
        public override bool estaTriste(){
            return arsenal.Max(arma => arma.Fuerza()) < 100 && tristeza > 25;
        }
        public override int poder(){
            return arsenal.Max(arma => arma.Fuerza()) - tristeza;
        }
        
    }
}