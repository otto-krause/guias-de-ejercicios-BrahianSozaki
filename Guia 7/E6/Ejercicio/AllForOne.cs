using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class AllForOne
    {
        List<Quirk> quirksRobados;
        public AllForOne()
        {
            this.quirksRobados = new List<Quirk>();
        }

        public void robarQuirk(Persona robada){
            quirksRobados.Add(robada.Quirk);
            robada.borrarQuirk(robada.Quirk.Nombre);
        }
        public int poder(){
            return quirksRobados.Sum(i => i.poder());
        }
        public bool esPeligroso(){
            return quirksRobados.Any(i => i.esPeligroso());
        }

    }
}